namespace SourceMapSharp

open SourceMapSharp.Util

module MappingList =

    let inline generatedPositionAfter (mappingA:Mapping) (mappingB:Mapping) =
      let lineA = mappingA.Generated.line
      let lineB = mappingB.Generated.line
      let columnA = mappingA.Generated.column
      let columnB = mappingB.Generated.column
      lineB > lineA
      || (lineB = lineA && columnB >= columnA)
      || compareByGeneratedPositionsInflated mappingA mappingB <= 0 

type MappingList() =
    let _array = ResizeArray<Mapping>()
    let mutable _sorted = true
    let mutable _last = {Generated = {line = -1; column = 0};Original=None;Source = None;Name=None}

    member _.UnsortedForEach(aCallback) =
        _array.ForEach(aCallback)

    member _.Add(aMapping: Mapping) =
        if MappingList.generatedPositionAfter _last aMapping then
            _last <- aMapping
            _array.Add(aMapping)
        else
            _sorted <- false
            _array.Add(aMapping)

    member _.ToArray() =
        if not _sorted then
            _array.Sort(sharedMappingComparer)
            _sorted <- true
        _array
