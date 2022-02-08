namespace SourceMapSharp

open System.Collections.Generic
open SourceMapSharp.Util


// An instance of the SourceMapGenerator represents a source map which is
// being built incrementally. You may pass an object with the following
// properties:
//  - file: The filename of the generated source.
//  - sourceRoot: A root for all relative URLs in this source map.


type SourceMapGenerator(?skipValidation:bool, ?file:string, ?sourceRoot:string) =

    let _file = file
    let _sourceRoot = sourceRoot
    let _skipValidation = defaultArg skipValidation false
    let _names = ArraySet()
    let _mappings = MappingList()
    member val _sourcesContents = Dictionary<string,string>()
    member val _sources = ArraySet()

    static member version = 3
    // A mapping can have one of the three levels of data:
    //  1. Just the generated position.
    //  2. The Generated position, original position, and original source.
    //  3. Generated and original position, original source, as well as a name
    //    token.

    // To maintain consistency, we validate that any new mapping being added falls
    // in to one of these categories.

    static member ValidateMapping(generated: MappingIndex,original: MappingIndex option,source: string option,name: string option) =
        // we don't need to check original.line & original.column === "number" because of F# type checks
        let mutable isInvalid = true
        if generated.line > 0 && generated.column >=0 && original.IsNone && source.IsNone && name.IsNone then
            isInvalid <- false

        elif generated.line > 0 && generated.column >=0
             && original.IsSome && original.Value.line > 0 && original.Value.column >= 0
             && source.IsSome then
             isInvalid <- false

        if isInvalid then
            let options = {|generated = generated; source=source; original=original; name=name|}
            let err = sprintf "Invalid mapping: %A" options
            raise (System.Exception(err))

    // Add a single mapping from original source line and column to the generated
    // source's line and column for this source map being created. The mapping
    // object should have the following properties:
    //  - generated: An object with the generated line and column positions.
    //  - original: An object with the original line and column positions.
    //  - source: The original source file (relative to the sourceRoot).
    //  - name: An optional original token name for this mapping.
    //
    member this.AddMapping(generated: MappingIndex,?original: MappingIndex,?source: string,?name: string) =
        if not _skipValidation then
            do SourceMapGenerator.ValidateMapping(generated,original,source,name)

        if source.IsSome then
            if not (this._sources.Has(source.Value)) then
                this._sources.Add(source.Value, false)

        if name.IsSome then
            if not (_names.Has(name.Value)) then
                _names.Add(name.Value, false)

        _mappings.Add({Generated=generated;Original=original;Source=source;Name=name})

    member this.GenerateSourcesContent(aSources, aSourceRoot: string option) =
        aSources
        |> Seq.map (fun source ->
            if this._sourcesContents.Keys.Count = 0 then
                None
            else
                let mutable s = source
                if aSourceRoot.IsSome then
                    s <- getRelativePath(_sourceRoot.Value,source)
                // don't need `util.toSetString(source)` in F#
                if this._sourcesContents.ContainsKey(s) then
                    Some <| this._sourcesContents.[s]
                 else
                    None
            )

    member this.SetSourceContent(aSourceFile, aSourceContent: string option) =
        let mutable source = aSourceFile
        if _sourceRoot.IsSome then
            source <- getRelativePath(_sourceRoot.Value,source)
        if aSourceContent.IsSome then
            // Add the source content to the _sourcesContents map.
            // We don't need to create a new _sourceContents
            // because it's always initialized
            this._sourcesContents.[source] <- aSourceContent.Value
        elif this._sourcesContents.Keys.Count > 0 then
            // Remove the source file from the _sourcesContents map.
            // We don't need to set _sourcesContents to null,
            // because we only use `.Keys.Count` checks
            this._sourcesContents.Remove(source) |> ignore

    member this.toJSON() =
        let version,sources,names,mappings = (SourceMapGenerator.version,
                                              this._sources.ToArray(),
                                              _names.ToArray(),
                                              this.SerializeMappings()
                                              )
        let sourcesContent =
            if this._sourcesContents.Keys.Count > 0 then
                Some(this.GenerateSourcesContent(sources,_sourceRoot))
            else
                None

        { version=version
          sources=sources
          names=names
          mappings=mappings
          file=_file
          sourcesContent=sourcesContent
          sourceRoot=_sourceRoot }

#if !FABLE_COMPILER
    // Render the source map being generated to a string.
    override this.ToString() = this.toJSON().Serialize()
#endif

    // Serialize the accumulated mappings in to the stream of base 64 VLQs
    // specified by the source map format.
    member this.SerializeMappings() =
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
        let mappings = _mappings.ToArray()
        for i in [0..mappings.Count - 1] do
            // hack for 'continue' keyword in JS
            let mutable shouldContinue = false
            let mapping = mappings.[i]
            next <- ""
            if mapping.Generated.line <> previousGeneratedLine then
                previousGeneratedColumn <- 0
                while mapping.Generated.line <> previousGeneratedLine do
                    next <- next + ";"
                    previousGeneratedLine <- previousGeneratedLine + 1
            elif i > 0 then
                let compared = compareByGeneratedPositionsInflated mapping mappings.[i-1]
                if compared = 0 then
                    // JS has 'continue' here, which we're emulating with a mutable bool
                    shouldContinue <- true
                else
                    next <- next + ","
            if not shouldContinue then
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

                        next <- next + Base64Vlq.Encode (original.column - previousOriginalColumn)
                        previousOriginalColumn <- original.column
                    )

                    if mapping.Name.IsSome then
                        mapping.Name
                        |> Option.bind (fun x -> _names.indexOf x)
                        |> Option.iter (fun indexOfMappingName ->
                            nameIdx <- indexOfMappingName
                            next <- next + Base64Vlq.Encode (nameIdx - previousName)
                            previousName <- nameIdx
                        )
                result <- result + next
        result