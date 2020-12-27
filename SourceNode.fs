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
    