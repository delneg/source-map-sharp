namespace SourceMapSharp

open System.Collections.Generic

type ArraySet<'T when 'T : equality>() as this =
    member val _array = new ResizeArray<'T>()
    member val _set = Dictionary<'T,int>()
    
    member _.Size() = this._array.Count
    member _.Has(aStr:'T) =
        this._set.ContainsKey(aStr)
    member _.indexOf(aStr: 'T) =
        if this._set.ContainsKey(aStr) then Some this._set.[aStr] else None
    member _.Add(aStr: 'T,aAllowDuplicates:bool) =
        let isDuplicate = this._array.Contains aStr
        let idx = this.Size()
        if not isDuplicate || aAllowDuplicates then
            this._array.Add(aStr)
        if not isDuplicate then
            this._set.[aStr] <- idx
    member _.At(aIdx: int) =
        if aIdx >= 0 && aIdx < this._array.Count then
            Some this._array.[aIdx]
        else None
    member _.ToArray() = this._array
    static member fromArray(aArray: 'T [], allowDuplicates) =
        let s = new ArraySet<'T>()
        for i in aArray do
            s.Add(i,allowDuplicates)
        s
    
    