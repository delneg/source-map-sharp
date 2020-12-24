namespace SourceMapSharp

open System.Collections.Generic
open SourceMapSharp.Util

type SourceMapGenerator(?skipValidation:bool) as this=
    
//    this._file = util.getArg(aArgs, "file", null);
//    this._sourceRoot = util.getArg(aArgs, "sourceRoot", null);
    member val _skipValidation = (skipValidation |> Option.defaultValue false) with get,set
    member val _sources = ArraySet()
    member val _names = ArraySet()
    member val _mappings = MappingList()
    member val _sourcesContents = Dictionary<string,string>()

    member _.SerializeMappings() =
        let mutable previousGeneratedColumn = 0
        let mutable previousGeneratedLine = 1
        let mutable previousOriginalColumn = 0
        let mutable previousOriginalLine = 0
        let mutable previousName = 0;
        let mutable previousSource = 0
        let mutable result = ""
        let mutable next = ""
        let mutable nameIdx = 0
        let mutable sourceIdx  = 0
        let mappings = this._mappings.ToArray()
        for i in [0..mappings.Count - 1] do
            let mapping = mappings.[i]
            next <- ""
            if mapping.Generated.line <> previousGeneratedLine then
                previousGeneratedColumn <- 0
                while mapping.Generated.line <> previousGeneratedLine do
                    next <- next + ";"
                    previousGeneratedLine <- previousGeneratedLine + 1
            elif i > 0 then
              if (compareByGeneratedPositionsInflated mapping mappings.[i-1]) = 0 then
                  //TODO: continue ?
                  ()
              next <- next + "," 
            next <- next + Base64Vlq.Encode (mapping.Generated.column - previousGeneratedColumn)
            previousGeneratedColumn <- mapping.Generated.column
            if mapping.Source.IsSome then
                mapping.Source
                |> Option.bind (fun x -> this._sources.indexOf x)
                |> Option.iter (fun indexOfMappingSource ->
                    sourceIdx <- indexOfMappingSource
                    next <- next + Base64Vlq.Encode (sourceIdx - previousSource)
                    previousSource <- sourceIdx
                )
                // lines are stored 0-based in SourceMap spec version 3
                mapping.Original
                |> Option.iter (fun original ->
                    next <- next + Base64Vlq.Encode (original.line - 1 - previousOriginalLine)
                    previousOriginalLine <- original.line - 1
                    
                    next <- next + Base64Vlq.Encode (original.column - 1 - previousOriginalColumn)
                    previousOriginalColumn <- original.column - 1
                )
                
                if mapping.Name.IsSome then
                    mapping.Name
                    |> Option.bind (fun x -> this._names.indexOf x)
                    |> Option.iter (fun indexOfMappingName ->
                        nameIdx <- indexOfMappingName
                        next <- next + Base64Vlq.Encode (nameIdx - previousName)
                        previousName <- nameIdx
                    )
            result <- result + next
        result