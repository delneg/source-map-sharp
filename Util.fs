namespace SourceMapSharp
open System.Collections.Generic
module Util =
    type MappingIndex = {line: int; column: int}
    type Mapping = {
        Generated: MappingIndex
        Original: MappingIndex option
        Source: string option
        Name: string option
        
    }
    
    type SourceGeneratorJSON = {
        version: int
        sources: seq<string>
        names: seq<string>
        mappings: string
        file: string option
        sourcesContent: seq<string option> option
        sourceRoot: string option
    }
    let strcmp (s1: string option) (s2:string option) =
        if s1.IsSome && s2.IsSome then
            if s1 = s2 then 0
            elif s1 > s2 then 1
            else -1
        elif s1.IsNone && s2.IsNone then
            0
        elif s1.IsNone then 1
        elif s2.IsNone then -1
        else -1
    
    
    let compareByGeneratedPositionsInflated (mappingA: Mapping) (mappingB: Mapping) =
        let mutable cmp = mappingA.Generated.line - mappingB.Generated.line
        if cmp <> 0 then cmp
        else
            cmp <- mappingA.Generated.column - mappingB.Generated.column
            if cmp <> 0 then cmp
            else
              cmp <- strcmp mappingA.Source mappingB.Source
              if cmp <> 0 then cmp
              else
                match (mappingA.Original,mappingB.Original) with
                | (Some mapAOriginal,Some mapBOriginal) ->
                    cmp <- mapAOriginal.line - mapBOriginal.line
                    if cmp <> 0 then cmp
                    else
                        cmp <- mapAOriginal.column - mapBOriginal.column
                        if cmp <> 0 then cmp
                        else strcmp mappingA.Name mappingB.Name
                | _ -> strcmp mappingA.Name mappingB.Name


    type MappingComparer() =
      interface IComparer<Mapping> with
        member _.Compare(a,b) = compareByGeneratedPositionsInflated a b
        