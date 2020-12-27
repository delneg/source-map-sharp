namespace SourceMapSharp

open System.Text.RegularExpressions

module SourceNode =
    let REGEX_NEWLINE = Regex @"(\r?\n)"
    let NEWLINE_CODE = 10
type SourceChunk =
    | ChunkS of string
    | ChunkArrS of string[]
    | ChunkArrSN of SourceNode[]
and SourceNodeChild = S of string | SN of SourceNode
and SourceNode(?_line: int, ?_column: int, ?_source: string, ?_chunks: SourceChunk[], ?_name: string) as this =
//    do (if _chunks.IsSome then _chunks.Value |> Array.iter this.Add else ())
    member val line = _line
    member val column = _column
    member val source = _source
    member val name = _name
    member val children = ResizeArray<SourceNodeChild>()

    
    member _.Add(chunk: SourceChunk) =
        match chunk with
        | ChunkS str -> this.children.Add(S str)
        | ChunkArrS arrs -> arrs |> Array.iter (fun x -> this.children.Add(S x))
        | ChunkArrSN arrsn -> arrsn |> Array.iter (fun x -> this.children.Add(SN x))
        this
    
    
    

