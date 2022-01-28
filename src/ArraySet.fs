namespace SourceMapSharp

open System.Collections.Generic

type ArraySet<'T when 'T : equality>() =
    let _array = new ResizeArray<'T>()
    let _set = Dictionary<'T,int>()
    member _.Size() = _set.Count
    member _.Has(aStr:'T) =
        _set.ContainsKey(aStr)
    member _.indexOf(aStr: 'T) =
        if _set.ContainsKey(aStr) then Some _set.[aStr] else None
    member _.Add(aStr: 'T,aAllowDuplicates:bool) =
        let isDuplicate = _array.Contains aStr
        let idx = _set.Count
        if not isDuplicate || aAllowDuplicates then
            _array.Add(aStr)
        if not isDuplicate then
            _set.[aStr] <- idx
    member _.At(aIdx: int) =
        if aIdx >= 0 && aIdx < _array.Count then
            Some _array.[aIdx]
        else None
    member _.ToArray() = _array
    static member fromArray(aArray: 'T [], allowDuplicates) =
        let s = new ArraySet<'T>()
        for i in aArray do
            s.Add(i,allowDuplicates)
        s
