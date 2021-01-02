namespace SourceMapSharp

open System.Collections.Generic
open SourceMapSharp.Util

open System.Text.Json
open System.Text.Json.Serialization
module SourceMapGenerator =
    let setup() = 
        let options = JsonSerializerOptions()
        options.Converters.Add(JsonFSharpConverter())
        
        
 //An instance of the SourceMapGenerator represents a source map which is
 //being built incrementally. You may pass an object with the following
 //properties:
 //  - file: The filename of the generated source.
 //  - sourceRoot: A root for all relative URLs in this source map.
 
type SourceMapGenerator(?skipValidation:bool,?file:string,?sourceRoot:string) as this=
    
    do SourceMapGenerator.setup()
    
    static member version = 3
    member val _file = file
    member val _sourceRoot = sourceRoot
    member val _skipValidation = (skipValidation |> Option.defaultValue false) with get,set
    member val _sources = ArraySet()
    member val _names = ArraySet()
    member val _mappings = MappingList()
    member val _sourcesContents = Dictionary<string,string>()
    
    //A mapping can have one of the three levels of data:
    //  1. Just the generated position.
    //  2. The Generated position, original position, and original source.
    //  3. Generated and original position, original source, as well as a name
    //    token.
   
    // To maintain consistency, we validate that any new mapping being added falls
    // in to one of these categories.

    static member ValidateMapping(generated: MappingIndex,original: MappingIndex option,source: string option,name: string option) =
        //we don't need to check original.line & original.column === "number" because of F# type checks
        let mutable isInvalid = true
        if generated.line > 0 && generated.column >=0 && original.IsNone && source.IsNone && name.IsNone then
            isInvalid <- false
            
        elif generated.line > 0 && generated.column >=0
             && original.IsSome && original.Value.line > 0 && original.Value.column >= 0
             && source.IsSome then
             isInvalid <- false
             
        if isInvalid then
            let err = sprintf "Invalid mapping: %s"
                          (JsonSerializer.Serialize({|generated = generated;source=source;original=original;name=name|}))
            raise (System.Exception(err))
        
    //
   //Add a single mapping from original source line and column to the generated
   //source's line and column for this source map being created. The mapping
   //object should have the following properties:
   //  - generated: An object with the generated line and column positions.
   //  - original: An object with the original line and column positions.
   //  - source: The original source file (relative to the sourceRoot).
   //  - name: An optional original token name for this mapping.
   //
    member _.AddMapping(generated: MappingIndex,?original: MappingIndex,?source: string,?name: string) =
        if not this._skipValidation then
            do SourceMapGenerator.ValidateMapping(generated,original,source,name)
        
        if source.IsSome then
            if not (this._sources.Has(source.Value)) then
              this._sources.Add(source.Value, false)
        
        if name.IsSome then
            if not (this._names.Has(name.Value)) then
              this._names.Add(name.Value, false)
              
        this._mappings.Add({Generated=generated;Original=original;Source=source;Name=name})
        
    member _.GenerateSourcesContent(aSources, aSourceRoot: string option) =
        aSources
        |> Array.ofSeq
        |> Seq.map (fun source ->
            if this._sourcesContents.Keys.Count = 0 then
                None
            else
                let mutable s = source
                if aSourceRoot.IsSome then
                    s <- "" //TODO: util.relative(aSourceRoot, source);
                //don't need `util.toSetString(source)` in F#
                if this._sourcesContents.ContainsKey(s) then
                    Some <| this._sourcesContents.[s]
                 else
                    None
            )
        
    member _.SetSourceContent(aSourceFile, aSourceContent: string option) =
        let mutable source = aSourceFile
        if this._sourceRoot.IsSome then
            source <- "" //TODO: util.relative(aSourceRoot, source);
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
        
        
    member _.toJSON() =
        let version,sources,names,mappings = (SourceMapGenerator.version,
                                              this._sources.ToArray(),
                                              this._names.ToArray(),
                                              this.SerializeMappings()
                                              )
        let sourcesContent = 
            if this._sourcesContents.Keys.Count > 0 then
                Some(this.GenerateSourcesContent(sources,this._sourceRoot))
            else
                None
                
        {version=version
         sources=sources
         names=names
         mappings=mappings
         file=this._file
         sourcesContent=sourcesContent
         sourceRoot=this._sourceRoot}
        
    //Render the source map being generated to a string.
    override _.ToString() = JsonSerializer.Serialize(this.toJSON())
    
    //Serialize the accumulated mappings in to the stream of base 64 VLQs
    //specified by the source map format.
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
            //hack for 'continue' keyword in JS
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
                  //JS has 'continue' here, which we're emulating with a mutable bool
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
                        |> Option.bind (fun x -> this._names.indexOf x)
                        |> Option.iter (fun indexOfMappingName ->
                            nameIdx <- indexOfMappingName
                            next <- next + Base64Vlq.Encode (nameIdx - previousName)
                            previousName <- nameIdx
                        )
                result <- result + next
        result