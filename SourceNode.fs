namespace SourceMapSharp

open System.Text.RegularExpressions
open System.Collections.Generic
module SourceNode =
    let REGEX_NEWLINE = Regex @"(\r?\n)"
    // Newline character code for charCodeAt() comparisons
    let NEWLINE_CODE = 10
    
    //We don't need `isSourceNode` since we have DU's

type SourceMappingOriginal = {
    line: int option
    column: int option
    Source: string option
    Name: string option
}
type SourceChunk =
    | ChunkS of string
    | ChunkArrS of string[]
    | ChunkArrSN of SourceNode[]
and SourceNodeChild =
    | S of string
    | SN of SourceNode
    override this.ToString() =
        match this with
        | S s -> s
        | SN sn -> sn.ToString()

// SourceNodes provide a way to abstract over interpolating/concatenating
// snippets of generated JavaScript source code while maintaining the line and
// column information associated with the original source code.
and SourceNode(?_line: int, ?_column: int, ?_source: string, ?_chunks: SourceChunk[], ?_name: string) as this =
    let addChunkToArray (chunk:SourceChunk,arr: ResizeArray<SourceNodeChild>) =
        match chunk with
        | ChunkS str -> arr.Add(S str)
        | ChunkArrS arrs -> arrs |> Array.iter (fun x -> arr.Add(S x))
        | ChunkArrSN arrsn -> arrsn |> Array.iter (fun x -> arr.Add(SN x))
    let mutable _children =
        let arr = ResizeArray<SourceNodeChild>()
        match _chunks with
        |Some chunks ->
            chunks |> Array.iter (fun chunk -> addChunkToArray(chunk,arr))
            arr
        |None -> arr
    
    member val line = _line
    member val column = _column
    member val source = _source
    member val name = _name
    member this.children
        with get() = _children
        and set(value) = _children <- value
    member val sourcesContents = Dictionary<string,string>()

    //  Add a chunk of generated JS to this source node.
    member _.Add(chunk: SourceChunk) : SourceNode =
        addChunkToArray(chunk,this.children)
        this
    // Add a chunk of generated JS to the beginning of this source node.
    member _.Prepend(chunk: SourceChunk) =
        match chunk with
        | ChunkS str -> this.children.Insert(0,S str)
        | ChunkArrS arrs -> this.children.InsertRange(0, arrs |> Array.map S)
        | ChunkArrSN arrsn -> this.children.InsertRange(0, arrsn |> Array.map SN)
        this
    member _.Prepend(chunks: SourceChunk[]) =
        for i = chunks.Length - 1 downto 0 do
            this.Prepend(chunks.[i]) |> ignore
        this
    // Walk over the tree of JS snippets in this node and its children. The
    // walking function is called once for each snippet of JS and is passed that
    // snippet and the its original associated source's line/column location.
    member _.Walk(fn: string -> SourceMappingOriginal -> unit) =
        for chunk in this.children do
            match chunk with
            | S str -> fn str {line = this.line;column=this.column;Source=this.source;Name=this.name}
            | SN sn -> sn.Walk(fn)
    
    //  Like `String.prototype.join` except for SourceNodes. Inserts `aStr` between
    // each of `this.children`.
    member _.Join(sep: string) =
        if this.children.Count > 0 then
            let mutable newChildren = ResizeArray<SourceNodeChild>()
            let len = this.children.Count
            for i = 0 to len - 2 do
                newChildren.Add(this.children.[i])
                newChildren.Add(S sep)
            newChildren.Add(this.children.[len - 1])
            this.children <- newChildren
        this
    //  Return the string representation of this source node. Walks over the tree
    //  and concatenates all the various snippets together to one string.
    override _.ToString() =
        let sb = System.Text.StringBuilder()
        this.Walk(fun s _ -> sb.Append(s) |> ignore)
        sb.ToString()

    // Call String.prototype.replace on the very right-most source snippet. Useful
    //  for trimming whitespace from the end of a source node, etc.
    member _.ReplaceRight(pattern:string, replacement:string) =
        let lastChild = this.children |> Seq.tryLast
        match lastChild with
        | Some (SN sn) -> sn.ReplaceRight(pattern, replacement)
        | Some (S str) ->
            this.children.[this.children.Count - 1] <- (str.Replace(pattern, replacement) |> S)
            this
        | None ->
            this.children.Add("".Replace(pattern,replacement) |> S)
            this
    
    // Set the source content for a source file. This will be added to the SourceMapGenerator
    //  in the sourcesContent field.
    member _.SetSourceContent(file,content) =
        this.sourcesContents.[file] <- content
    
    // Walk over the tree of SourceNodes. The walking function is called for each
    //  source file content and is passed the filename and source content.
    member _.WalkSourceContents fn =
        for child in this.children do
            match child with
            | SN sn -> sn.WalkSourceContents(fn)
            | _ -> ()
        this.sourcesContents |> Seq.iter (fun kvp -> fn(kvp.Key,kvp.Value))
    
    // Returns the string representation of this source node along with a source
    // map.
    member _.ToStringWithSourceMap(?skipValidation:bool,?file:string,?sourceRoot:string) =
        let map =
            match (skipValidation,file,sourceRoot) with
            | Some x, Some y, Some z -> SourceMapGenerator(x, y, z)
            | Some x, Some y, None -> SourceMapGenerator(skipValidation = x,file = y)
            | Some x, None, Some z -> SourceMapGenerator(skipValidation = x, sourceRoot = z)
            | None, Some y, Some z  -> SourceMapGenerator(file = y, sourceRoot = z)
            | None, Some y, None -> SourceMapGenerator (file = y)
            | Some x, None, None -> SourceMapGenerator(skipValidation = x)
            | None, None, Some z -> SourceMapGenerator(sourceRoot = z)
            | None, None, None -> SourceMapGenerator()
        let mutable generatedCode = System.Text.StringBuilder()
        let mutable generatedLine = 1
        let mutable generatedColumn = 0
        let mutable sourceMappingActive = false
        let mutable lastOriginalSource = None
        let mutable lastOriginalLine = None
        let mutable lastOriginalColumn = None
        let mutable lastOriginalName = None
        this.Walk(fun chunk original ->
            generatedCode.Append(chunk) |> ignore
            if original.Source.IsSome && original.line.IsSome && original.column.IsSome then
                if lastOriginalSource <> original.Source ||
                   lastOriginalLine <> original.line ||
                   lastOriginalColumn <> original.column ||
                   lastOriginalName <> original.Name then
                       let _generated: Util.MappingIndex = {line = generatedLine; column = generatedColumn}
                       let _original: Util.MappingIndex = {line = original.line.Value; column = original.column.Value}
                       match original.Name with
                       | Some n -> map.AddMapping(_generated, _original, original.Source.Value, n)
                       | None -> map.AddMapping(_generated, _original, original.Source.Value)
                lastOriginalSource <- original.Source
                lastOriginalLine <- original.line
                lastOriginalColumn <- original.column
                lastOriginalName <- original.Name
                sourceMappingActive <- true
            elif sourceMappingActive then
                let _generated: Util.MappingIndex = {line = generatedLine; column = generatedColumn}
                map.AddMapping(_generated)
                lastOriginalSource <- None
                sourceMappingActive <- false
            
            for idx in [0..chunk.Length-1] do
                if int chunk.[idx] = SourceNode.NEWLINE_CODE then
                    generatedLine <- generatedLine + 1
                    generatedColumn <- 0
                    // Mappings end at eol
                    if idx + 1 = chunk.Length then
                        lastOriginalSource <- None
                        sourceMappingActive <- false
                    elif sourceMappingActive then
                        let _generated: Util.MappingIndex = {line = generatedLine; column = generatedColumn}
                        let _original: Util.MappingIndex = {line = original.line.Value; column = original.column.Value}
                        match original.Source,original.Name with
                        | Some src, Some name -> map.AddMapping(_generated, _original, src,name)
                        | Some src, None -> map.AddMapping(_generated, _original, src)
                        | None, Some name -> map.AddMapping(_generated, _original, name=name)
                        | None, None -> map.AddMapping(_generated, _original)
                        
                else
                    generatedColumn <- generatedColumn + 1
            )
        this.WalkSourceContents(fun (file,content) -> map.SetSourceContent(file,Some content))
        (generatedCode.ToString(), map)
        