namespace SourceMapSharp

open System.Collections.Generic
open SourceMapSharp.Util

open System.Text.Json
open System.Text.Json.Serialization

module SourceMapConsumer =
    let version = 3
    let GENERATED_ORDER = 1
    let ORIGINAL_ORDER = 2
    let GREATEST_LOWER_BOUND = 1
    let LEAST_UPPER_BOUND = 2


type BasicSourceMapConsumer(sourceMap: SourceGeneratorJSON, sourceMapUrl: string) =
    do
        if SourceMapConsumer.version <> sourceMap.version
        then failwithf "Unsupported version %i" sourceMap.version

    let _version = sourceMap.version

    let _mappings = sourceMap.mappings
    // Don't loosen up on 'names' like in JS, because no Sass problem
    let _sourceLookupCache = Dictionary<_,_>()
    // Pass `true` below to allow duplicate names and sources. While source maps
    // are intended to be compressed and deduplicated, the TypeScript compiler
    // sometimes generates source maps with duplicates in them. See Github issue
    // #72 and bugzil.la/889492.
    let _names =  ArraySet.fromArray(sourceMap.names |> Array.ofSeq, true)
    let _sources = ArraySet.fromArray(sourceMap.sources |> Array.ofSeq, true)
    let sourceRoot = sourceMap.sourceRoot |> Option.defaultValue ""
    let sourceUrls =
        sourceMap.sources
        |> Seq.map (fun s -> computeSourceUrl sourceRoot s sourceMapUrl)
        |> Array.ofSeq
    let _absoluteSources = ArraySet.fromArray(sourceUrls, true)
    let sourcesContent = sourceMap.sourcesContent |> Option.defaultValue Seq.empty
    member val _computedColumnSpans = false
    member val _mappingsPtr = 0

    member _.sources() = _absoluteSources.ToArray()
