namespace SourceMapSharp

open System.Text.RegularExpressions
open System.Collections.Generic
module SourceNode =
    let REGEX_NEWLINE = Regex @"(\r?\n)"
    let NEWLINE_CODE = 10

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
and SourceNodeChild = S of string | SN of SourceNode
and SourceNode(?_line: int, ?_column: int, ?_source: string, ?_chunks: SourceChunk[], ?_name: string) as this =
    do if _chunks.IsSome then
            _chunks.Value |> Array.iter (fun x -> this.Add x |> ignore)
        else ()

    member val line = _line
    member val column = _column
    member val source = _source
    member val name = _name
    member val children = ResizeArray<SourceNodeChild>() with get,set
    member val sourcesContents = Dictionary<string,string>()

    
    member _.Add(chunk: SourceChunk) : SourceNode =
        match chunk with
        | ChunkS str -> this.children.Add(S str)
        | ChunkArrS arrs -> arrs |> Array.iter (fun x -> this.children.Add(S x))
        | ChunkArrSN arrsn -> arrsn |> Array.iter (fun x -> this.children.Add(SN x))
        this
    member _.Prepend(chunk: SourceChunk) =
        match chunk with
        | ChunkS str -> this.children.Insert(0,S str)
        | ChunkArrS arrs -> this.children.InsertRange(0, arrs |> Array.map S)
        | ChunkArrSN arrsn -> this.children.InsertRange(0, arrsn |> Array.map SN)
        this
    
    member _.Walk(fn: string -> SourceMappingOriginal -> unit) =
        for chunk in this.children do
            match chunk with
            | S str -> fn str {line = this.line;column=this.column;Source=this.source;Name=this.name}
            | SN sn -> sn.Walk(fn)
    
    member _.Join(sep: string) =
        if this.children.Count > 0 then
            let mutable newChildren = ResizeArray<SourceNodeChild>()
            for i in [0..this.children.Count - 1] do
                newChildren.Add(this.children.[i])
                newChildren.Add(S sep)
            newChildren.Add(this.children.[this.children.Count])
            this.children <- newChildren
        this
    
    override _.ToString() =
        let sb = System.Text.StringBuilder()
        this.Walk(fun s _ -> sb.Append(s) |> ignore)
        sb.ToString()

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
    
    member _.SetSourceContent(file,content) =
        this.sourcesContents.[file] <- content
    
    member _.WalkSourceContents fn =
        for child in this.children do
            match child with
            | SN sn -> sn.WalkSourceContents(fn)
            | _ -> ()
        this.sourcesContents |> Seq.iter (fun kvp -> fn(kvp.Key,kvp.Value))
    
    member _.ToStringWithSourceMap(skipValidation:bool option,file:string option,sourceRoot:string option) =
        let map = SourceMapGenerator(skipValidation,file,sourceRoot)
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
                       map.AddMapping(_generated, Some _original, original.Source,original.Name)
                lastOriginalSource <- original.Source
                lastOriginalLine <- original.line
                lastOriginalColumn <- original.column
                lastOriginalName <- original.Name
                sourceMappingActive <- true
            elif sourceMappingActive then
                let _generated: Util.MappingIndex = {line = generatedLine; column = generatedColumn}
                map.AddMapping(_generated, None,None,None)
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
                        map.AddMapping(_generated, Some _original, original.Source,original.Name)
                else
                    generatedColumn <- generatedColumn + 1
            )
        this.WalkSourceContents(fun (file,content) -> map.SetSourceContent(file,Some content))
        (generatedCode.ToString(), map)
        