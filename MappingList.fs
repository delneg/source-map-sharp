namespace SourceMapSharp

open System.Collections.Generic
open SourceMapSharp.Util

module MappingList =
    
    let generatedPositionAfter (mappingA:Mapping) (mappingB:Mapping) =
      let lineA = mappingA.Generated.line
      let lineB = mappingB.Generated.line
      let columnA = mappingA.Generated.column
      let columnB = mappingB.Generated.column
      lineB > lineA
      || (lineB = lineA && columnB >= columnA)
      || compareByGeneratedPositionsInflated mappingA mappingB <= 0 

type MappingList() as this =
    member val _array = ResizeArray<Mapping>()
    member val _sorted = true with get,set
    member val _last = {Generated = {line = -1; column = 0};Original=None;Source = None;Name=None} with get,set
    
    member _.UnsortedForEach(aCallback) =
        this._array.ForEach(aCallback)
        
    member _.Add(aMapping: Mapping) =
        if MappingList.generatedPositionAfter this._last aMapping then
            this._last <- aMapping
            this._array.Add(aMapping)
        else
            this._sorted <- false
            this._array.Add(aMapping)
            
    member _.ToArray() =
        if not this._sorted then
            this._array.Sort(MappingComparer())
            this._sorted <- true
        this._array
            
            
