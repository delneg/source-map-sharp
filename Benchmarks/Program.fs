module Benchmarks
open System.Collections.Generic
open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open SourceMapSharp
open SourceMapSharp.Util


//| Method |      Mean |    Error |   StdDev |    Gen 0 |   Gen 1 | Allocated |
//|------- |----------:|---------:|---------:|---------:|--------:|----------:|
//|   Tiny |  24.20 us | 0.133 us | 0.118 us |   9.1248 |  0.4578 |     75 KB |
//|  Small | 210.93 us | 1.009 us | 0.894 us |  65.4297 | 15.6250 |    535 KB |
//| Normal | 593.94 us | 6.691 us | 5.587 us | 163.0859 | 54.6875 |  1,337 KB |



[<PlainExporter; MemoryDiagnoser>]
type SourceMapGen() =
     
    [<Benchmark>]
    member _.Tiny() = 
        let map = SourceMapGenerator(?sourceRoot=None)
        let generated: MappingIndex = { line= 9; column= 0 }
        let original: MappingIndex = { line= 6; column= 4 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 0 }
        let original: MappingIndex = { line= 7; column= 4 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 21 }
        let original: MappingIndex = { line= 7; column= 15 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 25; column= 33 }
        let original: MappingIndex = { line= 8; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 26; column= 11 }
        let original: MappingIndex = { line= 8; column= 22 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 26; column= 11 }
        let original: MappingIndex = { line= 8; column= 22 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 26; column= 11 }
        let original: MappingIndex = { line= 8; column= 22 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 29; column= 38 }
        let original: MappingIndex = { line= 9; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 29; column= 41 }
        let original: MappingIndex = { line= 9; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 30; column= 11 }
        let original: MappingIndex = { line= 10; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 11 }
        let original: MappingIndex = { line= 10; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 11 }
        let original: MappingIndex = { line= 10; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 11 }
        let original: MappingIndex = { line= 10; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 30; column= 22 }
        let original: MappingIndex = { line= 10; column= 25 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 33; column= 42 }
        let original: MappingIndex = { line= 11; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 33; column= 45 }
        let original: MappingIndex = { line= 11; column= 21 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 34; column= 0 }
        let original: MappingIndex = { line= 12; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 0 }
        let original: MappingIndex = { line= 12; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 8 }
        let original: MappingIndex = { line= 12; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 8 }
        let original: MappingIndex = { line= 12; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 8 }
        let original: MappingIndex = { line= 12; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 8 }
        let original: MappingIndex = { line= 12; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 34; column= 19 }
        let original: MappingIndex = { line= 12; column= 28 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 35; column= 15 }
        let original: MappingIndex = { line= 12; column= 44 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 35; column= 31 }
        let original: MappingIndex = { line= 12; column= 44 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 35; column= 31 }
        let original: MappingIndex = { line= 12; column= 44 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 35; column= 39 }
        let original: MappingIndex = { line= 12; column= 50 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 38; column= 15 }
        let original: MappingIndex = { line= 12; column= 61 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 42; column= 42 }
        let original: MappingIndex = { line= 13; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 42; column= 45 }
        let original: MappingIndex = { line= 13; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 42; column= 51 }
        let original: MappingIndex = { line= 13; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aAllowDuplicates")
        let generated: MappingIndex = { line= 43; column= 10 }
        let original: MappingIndex = { line= 14; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "isDuplicate")
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 43; column= 41 }
        let original: MappingIndex = { line= 14; column= 42 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 44; column= 10 }
        let original: MappingIndex = { line= 15; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "idx")
        let generated: MappingIndex = { line= 44; column= 16 }
        let original: MappingIndex = { line= 15; column= 18 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 44; column= 16 }
        let original: MappingIndex = { line= 15; column= 18 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 44; column= 16 }
        let original: MappingIndex = { line= 15; column= 18 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 45; column= 0 }
        let original: MappingIndex = { line= 16; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 0 }
        let original: MappingIndex = { line= 16; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 8 }
        let original: MappingIndex = { line= 16; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 9 }
        let original: MappingIndex = { line= 16; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 10 }
        let original: MappingIndex = { line= 16; column= 15 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "isDuplicate")
        let generated: MappingIndex = { line= 45; column= 25 }
        let original: MappingIndex = { line= 16; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 32 }
        let original: MappingIndex = { line= 16; column= 30 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aAllowDuplicates")
        let generated: MappingIndex = { line= 46; column= 0 }
        let original: MappingIndex = { line= 17; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 14 }
        let original: MappingIndex = { line= 17; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 14 }
        let original: MappingIndex = { line= 17; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 14 }
        let original: MappingIndex = { line= 17; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 46; column= 28 }
        let original: MappingIndex = { line= 17; column= 23 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 48; column= 0 }
        let original: MappingIndex = { line= 18; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 48; column= 0 }
        let original: MappingIndex = { line= 18; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 48; column= 8 }
        let original: MappingIndex = { line= 18; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 48; column= 9 }
        let original: MappingIndex = { line= 18; column= 15 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "isDuplicate")
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 19; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 19; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 19; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 19; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 49; column= 19 }
        let original: MappingIndex = { line= 19; column= 18 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 49; column= 25 }
        let original: MappingIndex = { line= 19; column= 27 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "idx")
        let generated: MappingIndex = { line= 53; column= 41 }
        let original: MappingIndex = { line= 20; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 53; column= 44 }
        let original: MappingIndex = { line= 20; column= 16 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aIdx")
        let generated: MappingIndex = { line= 54; column= 0 }
        let original: MappingIndex = { line= 21; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 0 }
        let original: MappingIndex = { line= 21; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 8 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 8 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 9 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 9 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aIdx")
        let generated: MappingIndex = { line= 54; column= 17 }
        let original: MappingIndex = { line= 21; column= 19 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 24 }
        let original: MappingIndex = { line= 21; column= 24 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 24 }
        let original: MappingIndex = { line= 21; column= 24 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aIdx")
        let generated: MappingIndex = { line= 54; column= 31 }
        let original: MappingIndex = { line= 21; column= 31 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 31 }
        let original: MappingIndex = { line= 21; column= 31 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 31 }
        let original: MappingIndex = { line= 21; column= 31 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 55; column= 15 }
        let original: MappingIndex = { line= 22; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 55; column= 20 }
        let original: MappingIndex = { line= 22; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 55; column= 20 }
        let original: MappingIndex = { line= 22; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 55; column= 20 }
        let original: MappingIndex = { line= 22; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        map.toJSON()
        
    [<Benchmark>]
    member _.Small() = 
        let map = SourceMapGenerator(?sourceRoot=None)
        let generated: MappingIndex = { line= 9; column= 0 }
        let original: MappingIndex = { line= 6; column= 4 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 0 }
        let original: MappingIndex = { line= 7; column= 4 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 21 }
        let original: MappingIndex = { line= 7; column= 15 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 25; column= 33 }
        let original: MappingIndex = { line= 8; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 26; column= 11 }
        let original: MappingIndex = { line= 8; column= 22 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 26; column= 11 }
        let original: MappingIndex = { line= 8; column= 22 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 26; column= 11 }
        let original: MappingIndex = { line= 8; column= 22 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 29; column= 38 }
        let original: MappingIndex = { line= 9; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 29; column= 41 }
        let original: MappingIndex = { line= 9; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 30; column= 11 }
        let original: MappingIndex = { line= 10; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 11 }
        let original: MappingIndex = { line= 10; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 11 }
        let original: MappingIndex = { line= 10; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 11 }
        let original: MappingIndex = { line= 10; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 30; column= 22 }
        let original: MappingIndex = { line= 10; column= 25 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 33; column= 42 }
        let original: MappingIndex = { line= 11; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 33; column= 45 }
        let original: MappingIndex = { line= 11; column= 21 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 34; column= 0 }
        let original: MappingIndex = { line= 12; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 0 }
        let original: MappingIndex = { line= 12; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 8 }
        let original: MappingIndex = { line= 12; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 8 }
        let original: MappingIndex = { line= 12; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 8 }
        let original: MappingIndex = { line= 12; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 8 }
        let original: MappingIndex = { line= 12; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 34; column= 19 }
        let original: MappingIndex = { line= 12; column= 28 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 35; column= 15 }
        let original: MappingIndex = { line= 12; column= 44 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 35; column= 31 }
        let original: MappingIndex = { line= 12; column= 44 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 35; column= 31 }
        let original: MappingIndex = { line= 12; column= 44 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 35; column= 39 }
        let original: MappingIndex = { line= 12; column= 50 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 38; column= 15 }
        let original: MappingIndex = { line= 12; column= 61 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 42; column= 42 }
        let original: MappingIndex = { line= 13; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 42; column= 45 }
        let original: MappingIndex = { line= 13; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 42; column= 51 }
        let original: MappingIndex = { line= 13; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aAllowDuplicates")
        let generated: MappingIndex = { line= 43; column= 10 }
        let original: MappingIndex = { line= 14; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "isDuplicate")
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 43; column= 41 }
        let original: MappingIndex = { line= 14; column= 42 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 44; column= 10 }
        let original: MappingIndex = { line= 15; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "idx")
        let generated: MappingIndex = { line= 44; column= 16 }
        let original: MappingIndex = { line= 15; column= 18 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 44; column= 16 }
        let original: MappingIndex = { line= 15; column= 18 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 44; column= 16 }
        let original: MappingIndex = { line= 15; column= 18 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 45; column= 0 }
        let original: MappingIndex = { line= 16; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 0 }
        let original: MappingIndex = { line= 16; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 8 }
        let original: MappingIndex = { line= 16; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 9 }
        let original: MappingIndex = { line= 16; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 10 }
        let original: MappingIndex = { line= 16; column= 15 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "isDuplicate")
        let generated: MappingIndex = { line= 45; column= 25 }
        let original: MappingIndex = { line= 16; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 32 }
        let original: MappingIndex = { line= 16; column= 30 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aAllowDuplicates")
        let generated: MappingIndex = { line= 46; column= 0 }
        let original: MappingIndex = { line= 17; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 14 }
        let original: MappingIndex = { line= 17; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 14 }
        let original: MappingIndex = { line= 17; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 14 }
        let original: MappingIndex = { line= 17; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 46; column= 28 }
        let original: MappingIndex = { line= 17; column= 23 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 48; column= 0 }
        let original: MappingIndex = { line= 18; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 48; column= 0 }
        let original: MappingIndex = { line= 18; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 48; column= 8 }
        let original: MappingIndex = { line= 18; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 48; column= 9 }
        let original: MappingIndex = { line= 18; column= 15 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "isDuplicate")
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 19; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 19; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 19; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 19; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 49; column= 19 }
        let original: MappingIndex = { line= 19; column= 18 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 49; column= 25 }
        let original: MappingIndex = { line= 19; column= 27 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "idx")
        let generated: MappingIndex = { line= 53; column= 41 }
        let original: MappingIndex = { line= 20; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 53; column= 44 }
        let original: MappingIndex = { line= 20; column= 16 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aIdx")
        let generated: MappingIndex = { line= 54; column= 0 }
        let original: MappingIndex = { line= 21; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 0 }
        let original: MappingIndex = { line= 21; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 8 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 8 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 9 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 9 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aIdx")
        let generated: MappingIndex = { line= 54; column= 17 }
        let original: MappingIndex = { line= 21; column= 19 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 24 }
        let original: MappingIndex = { line= 21; column= 24 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 24 }
        let original: MappingIndex = { line= 21; column= 24 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aIdx")
        let generated: MappingIndex = { line= 54; column= 31 }
        let original: MappingIndex = { line= 21; column= 31 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 31 }
        let original: MappingIndex = { line= 21; column= 31 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 31 }
        let original: MappingIndex = { line= 21; column= 31 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 55; column= 15 }
        let original: MappingIndex = { line= 22; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 55; column= 20 }
        let original: MappingIndex = { line= 22; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 55; column= 20 }
        let original: MappingIndex = { line= 22; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 55; column= 20 }
        let original: MappingIndex = { line= 22; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 55; column= 29 }
        let original: MappingIndex = { line= 22; column= 25 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aIdx")
        let generated: MappingIndex = { line= 21; column= 45 }
        let original: MappingIndex = { line= 14; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "message")
        let generated: MappingIndex = { line= 22; column= 0 }
        let original: MappingIndex = { line= 15; column= 9 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 22; column= 0 }
        let original: MappingIndex = { line= 15; column= 9 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "``.ctor``")
        let generated: MappingIndex = { line= 25; column= 44 }
        let original: MappingIndex = { line= 18; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "message")
        let generated: MappingIndex = { line= 25; column= 53 }
        let original: MappingIndex = { line= 18; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "innerException")
        let generated: MappingIndex = { line= 26; column= 0 }
        let original: MappingIndex = { line= 19; column= 9 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 26; column= 0 }
        let original: MappingIndex = { line= 19; column= 9 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "``.ctor``")
        let generated: MappingIndex = { line= 29; column= 35 }
        let original: MappingIndex = { line= 30; column= 23 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 29; column= 35 }
        let original: MappingIndex = { line= 30; column= 23 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 31; column= 36 }
        let original: MappingIndex = { line= 31; column= 21 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 32; column= 0 }
        let original: MappingIndex = { line= 32; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 0 }
        let original: MappingIndex = { line= 32; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 8 }
        let original: MappingIndex = { line= 32; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 8 }
        let original: MappingIndex = { line= 32; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 9 }
        let original: MappingIndex = { line= 32; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 9 }
        let original: MappingIndex = { line= 32; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 14 }
        let original: MappingIndex = { line= 32; column= 17 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 32; column= 21 }
        let original: MappingIndex = { line= 32; column= 22 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 21 }
        let original: MappingIndex = { line= 32; column= 22 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 32; column= 25 }
        let original: MappingIndex = { line= 32; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 25 }
        let original: MappingIndex = { line= 32; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "intToCharMap")
        let generated: MappingIndex = { line= 33; column= 15 }
        let original: MappingIndex = { line= 33; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 33; column= 15 }
        let original: MappingIndex = { line= 33; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "intToCharMap")
        let generated: MappingIndex = { line= 33; column= 35 }
        let original: MappingIndex = { line= 33; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 36; column= 0 }
        let original: MappingIndex = { line= 36; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 36; column= 25 }
        let original: MappingIndex = { line= 36; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 36; column= 54 }
        let original: MappingIndex = { line= 36; column= 49 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 40; column= 36 }
        let original: MappingIndex = { line= 42; column= 21 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 41; column= 10 }
        let original: MappingIndex = { line= 43; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "index")
        let generated: MappingIndex = { line= 41; column= 18 }
        let original: MappingIndex = { line= 43; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 41; column= 26 }
        let original: MappingIndex = { line= 43; column= 34 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "intToCharMap")
        let generated: MappingIndex = { line= 41; column= 47 }
        let original: MappingIndex = { line= 43; column= 47 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 42; column= 0 }
        let original: MappingIndex = { line= 44; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 42; column= 0 }
        let original: MappingIndex = { line= 44; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 42; column= 8 }
        let original: MappingIndex = { line= 44; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 42; column= 8 }
        let original: MappingIndex = { line= 44; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "index")
        let generated: MappingIndex = { line= 42; column= 16 }
        let original: MappingIndex = { line= 44; column= 19 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 15 }
        let original: MappingIndex = { line= 44; column= 27 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "index")
        let generated: MappingIndex = { line= 46; column= 0 }
        let original: MappingIndex = { line= 47; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 25 }
        let original: MappingIndex = { line= 47; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 55 }
        let original: MappingIndex = { line= 47; column= 50 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 64; column= 11 }
        let original: MappingIndex = { line= 65; column= 35 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 68; column= 11 }
        let original: MappingIndex = { line= 67; column= 29 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 68; column= 11 }
        let original: MappingIndex = { line= 67; column= 29 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 68; column= 16 }
        let original: MappingIndex = { line= 67; column= 35 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 68; column= 16 }
        let original: MappingIndex = { line= 67; column= 35 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "VLQ_BASE_SHIFT")
        let generated: MappingIndex = { line= 72; column= 11 }
        let original: MappingIndex = { line= 69; column= 34 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 72; column= 11 }
        let original: MappingIndex = { line= 69; column= 34 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 72; column= 11 }
        let original: MappingIndex = { line= 69; column= 34 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "VLQ_BASE")
        let generated: MappingIndex = { line= 72; column= 38 }
        let original: MappingIndex = { line= 69; column= 55 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 76; column= 11 }
        let original: MappingIndex = { line= 71; column= 41 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 76; column= 11 }
        let original: MappingIndex = { line= 71; column= 41 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "VLQ_BASE")
        let generated: MappingIndex = { line= 79; column= 48 }
        let original: MappingIndex = { line= 73; column= 45 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "ch")
        let generated: MappingIndex = { line= 80; column= 0 }
        let original: MappingIndex = { line= 74; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 80; column= 0 }
        let original: MappingIndex = { line= 74; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 80; column= 8 }
        let original: MappingIndex = { line= 74; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 80; column= 8 }
        let original: MappingIndex = { line= 74; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "ch")
        let generated: MappingIndex = { line= 80; column= 15 }
        let original: MappingIndex = { line= 74; column= 18 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 81; column= 15 }
        let original: MappingIndex = { line= 74; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 84; column= 15 }
        let original: MappingIndex = { line= 74; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 84; column= 15 }
        let original: MappingIndex = { line= 74; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "ch")
        let generated: MappingIndex = { line= 84; column= 22 }
        let original: MappingIndex = { line= 74; column= 36 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 88; column= 41 }
        let original: MappingIndex = { line= 89; column= 38 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 89; column= 0 }
        let original: MappingIndex = { line= 90; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 89; column= 0 }
        let original: MappingIndex = { line= 90; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 89; column= 8 }
        let original: MappingIndex = { line= 90; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 89; column= 8 }
        let original: MappingIndex = { line= 90; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 89; column= 16 }
        let original: MappingIndex = { line= 90; column= 19 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 90; column= 16 }
        let original: MappingIndex = { line= 91; column= 13 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 90; column= 17 }
        let original: MappingIndex = { line= 91; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 90; column= 17 }
        let original: MappingIndex = { line= 91; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 90; column= 40 }
        let original: MappingIndex = { line= 91; column= 15 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 90; column= 50 }
        let original: MappingIndex = { line= 91; column= 25 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 90; column= 55 }
        let original: MappingIndex = { line= 91; column= 30 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 93; column= 16 }
        let original: MappingIndex = { line= 92; column= 13 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 93; column= 17 }
        let original: MappingIndex = { line= 92; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 93; column= 17 }
        let original: MappingIndex = { line= 92; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 93; column= 26 }
        let original: MappingIndex = { line= 92; column= 24 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 93; column= 31 }
        let original: MappingIndex = { line= 92; column= 29 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 97; column= 43 }
        let original: MappingIndex = { line= 98; column= 40 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 98; column= 8 }
        let original: MappingIndex = { line= 99; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "isNegative")
        let generated: MappingIndex = { line= 98; column= 21 }
        let original: MappingIndex = { line= 99; column= 33 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 98; column= 22 }
        let original: MappingIndex = { line= 99; column= 33 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 98; column= 22 }
        let original: MappingIndex = { line= 99; column= 33 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 98; column= 30 }
        let original: MappingIndex = { line= 99; column= 43 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 98; column= 37 }
        let original: MappingIndex = { line= 99; column= 47 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 99; column= 8 }
        let original: MappingIndex = { line= 100; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "shifted")
        let generated: MappingIndex = { line= 99; column= 18 }
        let original: MappingIndex = { line= 100; column= 30 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 99; column= 18 }
        let original: MappingIndex = { line= 100; column= 30 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 99; column= 27 }
        let original: MappingIndex = { line= 100; column= 40 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 100; column= 0 }
        let original: MappingIndex = { line= 101; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 100; column= 0 }
        let original: MappingIndex = { line= 101; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 100; column= 8 }
        let original: MappingIndex = { line= 101; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "isNegative")
        let generated: MappingIndex = { line= 101; column= 15 }
        let original: MappingIndex = { line= 102; column= 13 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 101; column= 38 }
        let original: MappingIndex = { line= 102; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "shifted")
        let generated: MappingIndex = { line= 104; column= 15 }
        let original: MappingIndex = { line= 103; column= 13 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "shifted")
        let generated: MappingIndex = { line= 108; column= 43 }
        let original: MappingIndex = { line= 105; column= 25 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "number")
        let generated: MappingIndex = { line= 109; column= 8 }
        let original: MappingIndex = { line= 106; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "encoded")
        let generated: MappingIndex = { line= 109; column= 18 }
        let original: MappingIndex = { line= 106; column= 30 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 110; column= 8 }
        let original: MappingIndex = { line= 107; column= 21 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "digit")
        let generated: MappingIndex = { line= 111; column= 8 }
        let original: MappingIndex = { line= 108; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "vlq")
        let generated: MappingIndex = { line= 111; column= 14 }
        let original: MappingIndex = { line= 108; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 111; column= 14 }
        let original: MappingIndex = { line= 108; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "ToVLQSigned")
        let generated: MappingIndex = { line= 111; column= 46 }
        let original: MappingIndex = { line= 108; column= 49 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "number")
        let generated: MappingIndex = { line= 112; column= 8 }
        let original: MappingIndex = { line= 110; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "isZeroCase")
        let generated: MappingIndex = { line= 112; column= 21 }
        let original: MappingIndex = { line= 110; column= 33 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 112; column= 21 }
        let original: MappingIndex = { line= 110; column= 33 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "number")
        let generated: MappingIndex = { line= 112; column= 32 }
        let original: MappingIndex = { line= 110; column= 42 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 0 }
        let original: MappingIndex = { line= 111; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 11 }
        let original: MappingIndex = { line= 111; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 12 }
        let original: MappingIndex = { line= 111; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 12 }
        let original: MappingIndex = { line= 111; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "vlq")
        let generated: MappingIndex = { line= 113; column= 18 }
        let original: MappingIndex = { line= 111; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 23 }
        let original: MappingIndex = { line= 111; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 30 }
        let original: MappingIndex = { line= 111; column= 25 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "isZeroCase")
        let generated: MappingIndex = { line= 114; column= 0 }
        let original: MappingIndex = { line= 112; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 114; column= 0 }
        let original: MappingIndex = { line= 112; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "isZeroCase")
        let generated: MappingIndex = { line= 114; column= 21 }
        let original: MappingIndex = { line= 112; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 115; column= 0 }
        let original: MappingIndex = { line= 113; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 115; column= 0 }
        let original: MappingIndex = { line= 113; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "digit")
        let generated: MappingIndex = { line= 115; column= 18 }
        let original: MappingIndex = { line= 113; column= 21 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 115; column= 18 }
        let original: MappingIndex = { line= 113; column= 21 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "vlq")
        let generated: MappingIndex = { line= 115; column= 24 }
        let original: MappingIndex = { line= 113; column= 29 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 115; column= 24 }
        let original: MappingIndex = { line= 113; column= 29 }
        let generated: MappingIndex = { line= 8; column= 0 }
        let original: MappingIndex = { line= 17; column= 4 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 9; column= 0 }
        let original: MappingIndex = { line= 18; column= 4 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 9; column= 23 }
        let original: MappingIndex = { line= 18; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 0 }
        let original: MappingIndex = { line= 19; column= 4 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 22 }
        let original: MappingIndex = { line= 19; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 34 }
        let original: MappingIndex = { line= 19; column= 37 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 51 }
        let original: MappingIndex = { line= 19; column= 45 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 55 }
        let original: MappingIndex = { line= 19; column= 58 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 59 }
        let original: MappingIndex = { line= 19; column= 70 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 67 }
        let original: MappingIndex = { line= 19; column= 84 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 75 }
        let original: MappingIndex = { line= 19; column= 94 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 22; column= 55 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 22; column= 58 }
        let original: MappingIndex = { line= 21; column= 29 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "aCallback")
        let generated: MappingIndex = { line= 23; column= 0 }
        let original: MappingIndex = { line= 22; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 23; column= 0 }
        let original: MappingIndex = { line= 22; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 23; column= 0 }
        let original: MappingIndex = { line= 22; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 23; column= 0 }
        let original: MappingIndex = { line= 22; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 23; column= 21 }
        let original: MappingIndex = { line= 22; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "aCallback")
        let generated: MappingIndex = { line= 26; column= 43 }
        let original: MappingIndex = { line= 24; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 26; column= 46 }
        let original: MappingIndex = { line= 24; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "aMapping")
        let generated: MappingIndex = { line= 27; column= 8 }
        let original: MappingIndex = { line= 7; column= 39 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 27; column= 18 }
        let original: MappingIndex = { line= 7; column= 58 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 27; column= 28 }
        let original: MappingIndex = { line= 8; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineA")
        let generated: MappingIndex = { line= 27; column= 35 }
        let original: MappingIndex = { line= 9; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineB")
        let generated: MappingIndex = { line= 27; column= 42 }
        let original: MappingIndex = { line= 58; column= 52 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 27; column= 54 }
        let original: MappingIndex = { line= 58; column= 72 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 27; column= 66 }
        let original: MappingIndex = { line= 59; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 27; column= 71 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 27; column= 75 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 27; column= 79 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 27; column= 91 }
        let original: MappingIndex = { line= 69; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapAOriginal")
        let generated: MappingIndex = { line= 27; column= 105 }
        let original: MappingIndex = { line= 69; column= 42 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapBOriginal")
        let generated: MappingIndex = { line= 27; column= 119 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 27; column= 125 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 27; column= 131 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 27; column= 137 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 0 }
        let original: MappingIndex = { line= 25; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 0 }
        let original: MappingIndex = { line= 25; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 9 }
        let original: MappingIndex = { line= 7; column= 39 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 20 }
        let original: MappingIndex = { line= 25; column= 46 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 20 }
        let original: MappingIndex = { line= 25; column= 46 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 28; column= 30 }
        let original: MappingIndex = { line= 7; column= 58 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 41 }
        let original: MappingIndex = { line= 25; column= 52 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "aMapping")
        let generated: MappingIndex = { line= 28; column= 52 }
        let original: MappingIndex = { line= 8; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineA")
        let generated: MappingIndex = { line= 28; column= 61 }
        let original: MappingIndex = { line= 8; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 61 }
        let original: MappingIndex = { line= 8; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 61 }
        let original: MappingIndex = { line= 8; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 92 }
        let original: MappingIndex = { line= 9; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineB")
        let generated: MappingIndex = { line= 28; column= 101 }
        let original: MappingIndex = { line= 9; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 101 }
        let original: MappingIndex = { line= 9; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 101 }
        let original: MappingIndex = { line= 9; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 131 }
        let original: MappingIndex = { line= 12; column= 6 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 132 }
        let original: MappingIndex = { line= 12; column= 6 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 133 }
        let original: MappingIndex = { line= 12; column= 6 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 133 }
        let original: MappingIndex = { line= 12; column= 6 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineB")
        let generated: MappingIndex = { line= 28; column= 141 }
        let original: MappingIndex = { line= 12; column= 14 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineA")
        let generated: MappingIndex = { line= 28; column= 150 }
        let original: MappingIndex = { line= 12; column= 6 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 158 }
        let original: MappingIndex = { line= 13; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 158 }
        let original: MappingIndex = { line= 13; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 159 }
        let original: MappingIndex = { line= 13; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 159 }
        let original: MappingIndex = { line= 13; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineB")
        let generated: MappingIndex = { line= 28; column= 169 }
        let original: MappingIndex = { line= 13; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineA")
        let generated: MappingIndex = { line= 28; column= 180 }
        let original: MappingIndex = { line= 13; column= 27 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 180 }
        let original: MappingIndex = { line= 11; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 180 }
        let original: MappingIndex = { line= 11; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 180 }
        let original: MappingIndex = { line= 11; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 209 }
        let original: MappingIndex = { line= 10; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 209 }
        let original: MappingIndex = { line= 10; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 209 }
        let original: MappingIndex = { line= 10; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 240 }
        let original: MappingIndex = { line= 12; column= 6 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 248 }
        let original: MappingIndex = { line= 14; column= 9 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 250 }
        let original: MappingIndex = { line= 58; column= 52 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 263 }
        let original: MappingIndex = { line= 14; column= 45 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 274 }
        let original: MappingIndex = { line= 58; column= 72 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 287 }
        let original: MappingIndex = { line= 14; column= 54 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 298 }
        let original: MappingIndex = { line= 59; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 305 }
        let original: MappingIndex = { line= 59; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 305 }
        let original: MappingIndex = { line= 59; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 305 }
        let original: MappingIndex = { line= 59; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 305 }
        let original: MappingIndex = { line= 59; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 333 }
        let original: MappingIndex = { line= 59; column= 52 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 333 }
        let original: MappingIndex = { line= 59; column= 52 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 333 }
        let original: MappingIndex = { line= 59; column= 52 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 361 }
        let original: MappingIndex = { line= 60; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 362 }
        let original: MappingIndex = { line= 60; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 362 }
        let original: MappingIndex = { line= 60; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 370 }
        let original: MappingIndex = { line= 60; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 375 }
        let original: MappingIndex = { line= 60; column= 25 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 383 }
        let original: MappingIndex = { line= 62; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 383 }
        let original: MappingIndex = { line= 62; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 391 }
        let original: MappingIndex = { line= 62; column= 19 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 391 }
        let original: MappingIndex = { line= 62; column= 19 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 391 }
        let original: MappingIndex = { line= 62; column= 19 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 391 }
        let original: MappingIndex = { line= 62; column= 19 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 421 }
        let original: MappingIndex = { line= 62; column= 47 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 421 }
        let original: MappingIndex = { line= 62; column= 47 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 421 }
        let original: MappingIndex = { line= 62; column= 47 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 456 }
        let original: MappingIndex = { line= 63; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 457 }
        let original: MappingIndex = { line= 63; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 457 }
        let original: MappingIndex = { line= 63; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 465 }
        let original: MappingIndex = { line= 63; column= 22 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 470 }
        let original: MappingIndex = { line= 63; column= 29 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 478 }
        let original: MappingIndex = { line= 65; column= 14 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 478 }
        let original: MappingIndex = { line= 65; column= 14 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 487 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 492 }
        let original: MappingIndex = { line= 65; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 492 }
        let original: MappingIndex = { line= 65; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 512 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 517 }
        let original: MappingIndex = { line= 65; column= 44 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 517 }
        let original: MappingIndex = { line= 65; column= 44 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 536 }
        let original: MappingIndex = { line= 48; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 537 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 537 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 538 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 538 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 554 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 554 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 570 }
        let original: MappingIndex = { line= 49; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 571 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 571 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 577 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 585 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 591 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 598 }
        let original: MappingIndex = { line= 49; column= 40 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 603 }
        let original: MappingIndex = { line= 50; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 604 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 604 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 610 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 616 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 622 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 629 }
        let original: MappingIndex = { line= 50; column= 42 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 633 }
        let original: MappingIndex = { line= 51; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 641 }
        let original: MappingIndex = { line= 52; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 642 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 642 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 643 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 643 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 659 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 659 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 674 }
        let original: MappingIndex = { line= 53; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 679 }
        let original: MappingIndex = { line= 54; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 680 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 680 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 694 }
        let original: MappingIndex = { line= 54; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 699 }
        let original: MappingIndex = { line= 55; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 700 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 700 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 714 }
        let original: MappingIndex = { line= 55; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 719 }
        let original: MappingIndex = { line= 56; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 734 }
        let original: MappingIndex = { line= 66; column= 14 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 735 }
        let original: MappingIndex = { line= 66; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 735 }
        let original: MappingIndex = { line= 66; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 743 }
        let original: MappingIndex = { line= 66; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 748 }
        let original: MappingIndex = { line= 66; column= 31 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 756 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 28; column= 770 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 770 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 791 }
        let original: MappingIndex = { line= 68; column= 41 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 791 }
        let original: MappingIndex = { line= 68; column= 41 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 813 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 814 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 814 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 814 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 28; column= 840 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 841 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 841 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 841 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 28; column= 868 }
        let original: MappingIndex = { line= 69; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapAOriginal")
        let generated: MappingIndex = { line= 28; column= 883 }
        let original: MappingIndex = { line= 69; column= 19 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 883 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 28; column= 899 }
        let original: MappingIndex = { line= 69; column= 42 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapBOriginal")
        let generated: MappingIndex = { line= 28; column= 914 }
        let original: MappingIndex = { line= 69; column= 37 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 914 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 28; column= 930 }
        let original: MappingIndex = { line= 70; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 930 }
        let original: MappingIndex = { line= 70; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 938 }
        let original: MappingIndex = { line= 70; column= 27 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 938 }
        let original: MappingIndex = { line= 70; column= 27 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 938 }
        let original: MappingIndex = { line= 70; column= 27 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapAOriginal")
        let generated: MappingIndex = { line= 28; column= 958 }
        let original: MappingIndex = { line= 70; column= 47 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 958 }
        let original: MappingIndex = { line= 70; column= 47 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapBOriginal")
        let generated: MappingIndex = { line= 28; column= 983 }
        let original: MappingIndex = { line= 71; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 984 }
        let original: MappingIndex = { line= 71; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 984 }
        let original: MappingIndex = { line= 71; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 992 }
        let original: MappingIndex = { line= 71; column= 30 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 997 }
        let original: MappingIndex = { line= 71; column= 37 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 1005 }
        let original: MappingIndex = { line= 73; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1005 }
        let original: MappingIndex = { line= 73; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 1013 }
        let original: MappingIndex = { line= 73; column= 31 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1013 }
        let original: MappingIndex = { line= 73; column= 31 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1013 }
        let original: MappingIndex = { line= 73; column= 31 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapAOriginal")
        let generated: MappingIndex = { line= 28; column= 1035 }
        let original: MappingIndex = { line= 73; column= 53 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1035 }
        let original: MappingIndex = { line= 73; column= 53 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapBOriginal")
        let generated: MappingIndex = { line= 28; column= 1062 }
        let original: MappingIndex = { line= 74; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1063 }
        let original: MappingIndex = { line= 74; column= 27 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1063 }
        let original: MappingIndex = { line= 74; column= 27 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 1071 }
        let original: MappingIndex = { line= 74; column= 34 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1076 }
        let original: MappingIndex = { line= 74; column= 41 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 1084 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1091 }
        let original: MappingIndex = { line= 75; column= 36 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1091 }
        let original: MappingIndex = { line= 75; column= 36 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 1109 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1116 }
        let original: MappingIndex = { line= 75; column= 50 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1116 }
        let original: MappingIndex = { line= 75; column= 50 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 1133 }
        let original: MappingIndex = { line= 48; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1134 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1134 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1135 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1135 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1153 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1153 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1171 }
        let original: MappingIndex = { line= 49; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1172 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1172 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1178 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1188 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1194 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1203 }
        let original: MappingIndex = { line= 49; column= 40 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1208 }
        let original: MappingIndex = { line= 50; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1209 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1209 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1215 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1223 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1229 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1238 }
        let original: MappingIndex = { line= 50; column= 42 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1242 }
        let original: MappingIndex = { line= 51; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1250 }
        let original: MappingIndex = { line= 52; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1251 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1251 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1252 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1252 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1270 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1270 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1287 }
        let original: MappingIndex = { line= 53; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1292 }
        let original: MappingIndex = { line= 54; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1293 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1293 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1309 }
        let original: MappingIndex = { line= 54; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1314 }
        let original: MappingIndex = { line= 55; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1315 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1315 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1331 }
        let original: MappingIndex = { line= 55; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1336 }
        let original: MappingIndex = { line= 56; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1355 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1362 }
        let original: MappingIndex = { line= 76; column= 30 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1362 }
        let original: MappingIndex = { line= 76; column= 30 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 1380 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1387 }
        let original: MappingIndex = { line= 76; column= 44 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1387 }
        let original: MappingIndex = { line= 76; column= 44 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 1404 }
        let original: MappingIndex = { line= 48; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1405 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1405 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1406 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1406 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1424 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1424 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1442 }
        let original: MappingIndex = { line= 49; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1443 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1443 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1449 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1459 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1465 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1474 }
        let original: MappingIndex = { line= 49; column= 40 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1479 }
        let original: MappingIndex = { line= 50; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1480 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1480 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1486 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1494 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1500 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1509 }
        let original: MappingIndex = { line= 50; column= 42 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1513 }
        let original: MappingIndex = { line= 51; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1521 }
        let original: MappingIndex = { line= 52; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1522 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1522 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1523 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1523 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1541 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1541 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1558 }
        let original: MappingIndex = { line= 53; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1563 }
        let original: MappingIndex = { line= 54; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1564 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1564 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1580 }
        let original: MappingIndex = { line= 54; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1585 }
        let original: MappingIndex = { line= 55; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1586 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1586 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1602 }
        let original: MappingIndex = { line= 55; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1607 }
        let original: MappingIndex = { line= 56; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1621 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1628 }
        let original: MappingIndex = { line= 76; column= 30 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1628 }
        let original: MappingIndex = { line= 76; column= 30 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 1646 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1653 }
        let original: MappingIndex = { line= 76; column= 44 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1653 }
        let original: MappingIndex = { line= 76; column= 44 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 1670 }
        let original: MappingIndex = { line= 48; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1671 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1671 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1672 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1672 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1690 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1690 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1708 }
        let original: MappingIndex = { line= 49; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1709 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1709 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1715 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1725 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1731 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1740 }
        let original: MappingIndex = { line= 49; column= 40 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1745 }
        let original: MappingIndex = { line= 50; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1746 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1746 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1752 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1760 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1766 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1775 }
        let original: MappingIndex = { line= 50; column= 42 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1779 }
        let original: MappingIndex = { line= 51; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1787 }
        let original: MappingIndex = { line= 52; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1788 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1788 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1789 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1789 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1807 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1807 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1824 }
        let original: MappingIndex = { line= 53; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1829 }
        let original: MappingIndex = { line= 54; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1830 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1830 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1846 }
        let original: MappingIndex = { line= 54; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1851 }
        let original: MappingIndex = { line= 55; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1852 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1852 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1868 }
        let original: MappingIndex = { line= 55; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1873 }
        let original: MappingIndex = { line= 56; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1895 }
        let original: MappingIndex = { line= 14; column= 66 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 29; column= 0 }
        let original: MappingIndex = { line= 26; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 29; column= 0 }
        let original: MappingIndex = { line= 26; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 29; column= 18 }
        let original: MappingIndex = { line= 26; column= 21 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "aMapping")
        let generated: MappingIndex = { line= 30; column= 0 }
        let original: MappingIndex = { line= 27; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 14 }
        let original: MappingIndex = { line= 27; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 14 }
        let original: MappingIndex = { line= 27; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 14 }
        let original: MappingIndex = { line= 27; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 30; column= 28 }
        let original: MappingIndex = { line= 27; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "aMapping")
        let generated: MappingIndex = { line= 33; column= 0 }
        let original: MappingIndex = { line= 29; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 33; column= 0 }
        let original: MappingIndex = { line= 29; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 33; column= 20 }
        let original: MappingIndex = { line= 29; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 0 }
        let original: MappingIndex = { line= 30; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 14 }
        let original: MappingIndex = { line= 30; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 14 }
        map.toJSON()
    
    [<Benchmark>]
    member _.Normal() = 
        let map = SourceMapGenerator(?sourceRoot=None)
        let generated: MappingIndex = { line= 9; column= 0 }
        let original: MappingIndex = { line= 6; column= 4 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 0 }
        let original: MappingIndex = { line= 7; column= 4 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 21 }
        let original: MappingIndex = { line= 7; column= 15 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 25; column= 33 }
        let original: MappingIndex = { line= 8; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 26; column= 11 }
        let original: MappingIndex = { line= 8; column= 22 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 26; column= 11 }
        let original: MappingIndex = { line= 8; column= 22 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 26; column= 11 }
        let original: MappingIndex = { line= 8; column= 22 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 29; column= 38 }
        let original: MappingIndex = { line= 9; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 29; column= 41 }
        let original: MappingIndex = { line= 9; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 30; column= 11 }
        let original: MappingIndex = { line= 10; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 11 }
        let original: MappingIndex = { line= 10; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 11 }
        let original: MappingIndex = { line= 10; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 11 }
        let original: MappingIndex = { line= 10; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 30; column= 22 }
        let original: MappingIndex = { line= 10; column= 25 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 33; column= 42 }
        let original: MappingIndex = { line= 11; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 33; column= 45 }
        let original: MappingIndex = { line= 11; column= 21 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 34; column= 0 }
        let original: MappingIndex = { line= 12; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 0 }
        let original: MappingIndex = { line= 12; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 8 }
        let original: MappingIndex = { line= 12; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 8 }
        let original: MappingIndex = { line= 12; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 8 }
        let original: MappingIndex = { line= 12; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 8 }
        let original: MappingIndex = { line= 12; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 34; column= 19 }
        let original: MappingIndex = { line= 12; column= 28 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 35; column= 15 }
        let original: MappingIndex = { line= 12; column= 44 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 35; column= 31 }
        let original: MappingIndex = { line= 12; column= 44 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 35; column= 31 }
        let original: MappingIndex = { line= 12; column= 44 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 35; column= 39 }
        let original: MappingIndex = { line= 12; column= 50 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 38; column= 15 }
        let original: MappingIndex = { line= 12; column= 61 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 42; column= 42 }
        let original: MappingIndex = { line= 13; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 42; column= 45 }
        let original: MappingIndex = { line= 13; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 42; column= 51 }
        let original: MappingIndex = { line= 13; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aAllowDuplicates")
        let generated: MappingIndex = { line= 43; column= 10 }
        let original: MappingIndex = { line= 14; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "isDuplicate")
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 24 }
        let original: MappingIndex = { line= 14; column= 26 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 43; column= 41 }
        let original: MappingIndex = { line= 14; column= 42 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 44; column= 10 }
        let original: MappingIndex = { line= 15; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "idx")
        let generated: MappingIndex = { line= 44; column= 16 }
        let original: MappingIndex = { line= 15; column= 18 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 44; column= 16 }
        let original: MappingIndex = { line= 15; column= 18 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 44; column= 16 }
        let original: MappingIndex = { line= 15; column= 18 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 45; column= 0 }
        let original: MappingIndex = { line= 16; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 0 }
        let original: MappingIndex = { line= 16; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 8 }
        let original: MappingIndex = { line= 16; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 9 }
        let original: MappingIndex = { line= 16; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 10 }
        let original: MappingIndex = { line= 16; column= 15 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "isDuplicate")
        let generated: MappingIndex = { line= 45; column= 25 }
        let original: MappingIndex = { line= 16; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 45; column= 32 }
        let original: MappingIndex = { line= 16; column= 30 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aAllowDuplicates")
        let generated: MappingIndex = { line= 46; column= 0 }
        let original: MappingIndex = { line= 17; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 14 }
        let original: MappingIndex = { line= 17; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 14 }
        let original: MappingIndex = { line= 17; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 14 }
        let original: MappingIndex = { line= 17; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 46; column= 28 }
        let original: MappingIndex = { line= 17; column= 23 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 48; column= 0 }
        let original: MappingIndex = { line= 18; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 48; column= 0 }
        let original: MappingIndex = { line= 18; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 48; column= 8 }
        let original: MappingIndex = { line= 18; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 48; column= 9 }
        let original: MappingIndex = { line= 18; column= 15 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "isDuplicate")
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 19; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 19; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 19; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 19; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 49; column= 19 }
        let original: MappingIndex = { line= 19; column= 18 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aStr")
        let generated: MappingIndex = { line= 49; column= 25 }
        let original: MappingIndex = { line= 19; column= 27 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "idx")
        let generated: MappingIndex = { line= 53; column= 41 }
        let original: MappingIndex = { line= 20; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 53; column= 44 }
        let original: MappingIndex = { line= 20; column= 16 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aIdx")
        let generated: MappingIndex = { line= 54; column= 0 }
        let original: MappingIndex = { line= 21; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 0 }
        let original: MappingIndex = { line= 21; column= 8 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 8 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 8 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 9 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 9 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aIdx")
        let generated: MappingIndex = { line= 54; column= 17 }
        let original: MappingIndex = { line= 21; column= 19 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 24 }
        let original: MappingIndex = { line= 21; column= 24 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 24 }
        let original: MappingIndex = { line= 21; column= 24 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aIdx")
        let generated: MappingIndex = { line= 54; column= 31 }
        let original: MappingIndex = { line= 21; column= 31 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 31 }
        let original: MappingIndex = { line= 21; column= 31 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 54; column= 31 }
        let original: MappingIndex = { line= 21; column= 31 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 55; column= 15 }
        let original: MappingIndex = { line= 22; column= 12 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 55; column= 20 }
        let original: MappingIndex = { line= 22; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 55; column= 20 }
        let original: MappingIndex = { line= 22; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=None)
        let generated: MappingIndex = { line= 55; column= 20 }
        let original: MappingIndex = { line= 22; column= 17 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "_")
        let generated: MappingIndex = { line= 55; column= 29 }
        let original: MappingIndex = { line= 22; column= 25 }
        map.AddMapping(generated, original, source="../../../src/ArraySet.fs",?name=Some "aIdx")
        let generated: MappingIndex = { line= 21; column= 45 }
        let original: MappingIndex = { line= 14; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "message")
        let generated: MappingIndex = { line= 22; column= 0 }
        let original: MappingIndex = { line= 15; column= 9 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 22; column= 0 }
        let original: MappingIndex = { line= 15; column= 9 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "``.ctor``")
        let generated: MappingIndex = { line= 25; column= 44 }
        let original: MappingIndex = { line= 18; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "message")
        let generated: MappingIndex = { line= 25; column= 53 }
        let original: MappingIndex = { line= 18; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "innerException")
        let generated: MappingIndex = { line= 26; column= 0 }
        let original: MappingIndex = { line= 19; column= 9 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 26; column= 0 }
        let original: MappingIndex = { line= 19; column= 9 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "``.ctor``")
        let generated: MappingIndex = { line= 29; column= 35 }
        let original: MappingIndex = { line= 30; column= 23 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 29; column= 35 }
        let original: MappingIndex = { line= 30; column= 23 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 31; column= 36 }
        let original: MappingIndex = { line= 31; column= 21 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 32; column= 0 }
        let original: MappingIndex = { line= 32; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 0 }
        let original: MappingIndex = { line= 32; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 8 }
        let original: MappingIndex = { line= 32; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 8 }
        let original: MappingIndex = { line= 32; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 9 }
        let original: MappingIndex = { line= 32; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 9 }
        let original: MappingIndex = { line= 32; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 14 }
        let original: MappingIndex = { line= 32; column= 17 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 32; column= 21 }
        let original: MappingIndex = { line= 32; column= 22 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 21 }
        let original: MappingIndex = { line= 32; column= 22 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 32; column= 25 }
        let original: MappingIndex = { line= 32; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 32; column= 25 }
        let original: MappingIndex = { line= 32; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "intToCharMap")
        let generated: MappingIndex = { line= 33; column= 15 }
        let original: MappingIndex = { line= 33; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 33; column= 15 }
        let original: MappingIndex = { line= 33; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "intToCharMap")
        let generated: MappingIndex = { line= 33; column= 35 }
        let original: MappingIndex = { line= 33; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 36; column= 0 }
        let original: MappingIndex = { line= 36; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 36; column= 25 }
        let original: MappingIndex = { line= 36; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 36; column= 54 }
        let original: MappingIndex = { line= 36; column= 49 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 40; column= 36 }
        let original: MappingIndex = { line= 42; column= 21 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 41; column= 10 }
        let original: MappingIndex = { line= 43; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "index")
        let generated: MappingIndex = { line= 41; column= 18 }
        let original: MappingIndex = { line= 43; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 41; column= 26 }
        let original: MappingIndex = { line= 43; column= 34 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "intToCharMap")
        let generated: MappingIndex = { line= 41; column= 47 }
        let original: MappingIndex = { line= 43; column= 47 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 42; column= 0 }
        let original: MappingIndex = { line= 44; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 42; column= 0 }
        let original: MappingIndex = { line= 44; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 42; column= 8 }
        let original: MappingIndex = { line= 44; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 42; column= 8 }
        let original: MappingIndex = { line= 44; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "index")
        let generated: MappingIndex = { line= 42; column= 16 }
        let original: MappingIndex = { line= 44; column= 19 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 43; column= 15 }
        let original: MappingIndex = { line= 44; column= 27 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "index")
        let generated: MappingIndex = { line= 46; column= 0 }
        let original: MappingIndex = { line= 47; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 25 }
        let original: MappingIndex = { line= 47; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 46; column= 55 }
        let original: MappingIndex = { line= 47; column= 50 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "c")
        let generated: MappingIndex = { line= 64; column= 11 }
        let original: MappingIndex = { line= 65; column= 35 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 68; column= 11 }
        let original: MappingIndex = { line= 67; column= 29 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 68; column= 11 }
        let original: MappingIndex = { line= 67; column= 29 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 68; column= 16 }
        let original: MappingIndex = { line= 67; column= 35 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 68; column= 16 }
        let original: MappingIndex = { line= 67; column= 35 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "VLQ_BASE_SHIFT")
        let generated: MappingIndex = { line= 72; column= 11 }
        let original: MappingIndex = { line= 69; column= 34 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 72; column= 11 }
        let original: MappingIndex = { line= 69; column= 34 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 72; column= 11 }
        let original: MappingIndex = { line= 69; column= 34 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "VLQ_BASE")
        let generated: MappingIndex = { line= 72; column= 38 }
        let original: MappingIndex = { line= 69; column= 55 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 76; column= 11 }
        let original: MappingIndex = { line= 71; column= 41 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 76; column= 11 }
        let original: MappingIndex = { line= 71; column= 41 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "VLQ_BASE")
        let generated: MappingIndex = { line= 79; column= 48 }
        let original: MappingIndex = { line= 73; column= 45 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "ch")
        let generated: MappingIndex = { line= 80; column= 0 }
        let original: MappingIndex = { line= 74; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 80; column= 0 }
        let original: MappingIndex = { line= 74; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 80; column= 8 }
        let original: MappingIndex = { line= 74; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 80; column= 8 }
        let original: MappingIndex = { line= 74; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "ch")
        let generated: MappingIndex = { line= 80; column= 15 }
        let original: MappingIndex = { line= 74; column= 18 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 81; column= 15 }
        let original: MappingIndex = { line= 74; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 84; column= 15 }
        let original: MappingIndex = { line= 74; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 84; column= 15 }
        let original: MappingIndex = { line= 74; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "ch")
        let generated: MappingIndex = { line= 84; column= 22 }
        let original: MappingIndex = { line= 74; column= 36 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 88; column= 41 }
        let original: MappingIndex = { line= 89; column= 38 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 89; column= 0 }
        let original: MappingIndex = { line= 90; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 89; column= 0 }
        let original: MappingIndex = { line= 90; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 89; column= 8 }
        let original: MappingIndex = { line= 90; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 89; column= 8 }
        let original: MappingIndex = { line= 90; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 89; column= 16 }
        let original: MappingIndex = { line= 90; column= 19 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 90; column= 16 }
        let original: MappingIndex = { line= 91; column= 13 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 90; column= 17 }
        let original: MappingIndex = { line= 91; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 90; column= 17 }
        let original: MappingIndex = { line= 91; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 90; column= 40 }
        let original: MappingIndex = { line= 91; column= 15 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 90; column= 50 }
        let original: MappingIndex = { line= 91; column= 25 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 90; column= 55 }
        let original: MappingIndex = { line= 91; column= 30 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 93; column= 16 }
        let original: MappingIndex = { line= 92; column= 13 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 93; column= 17 }
        let original: MappingIndex = { line= 92; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 93; column= 17 }
        let original: MappingIndex = { line= 92; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 93; column= 26 }
        let original: MappingIndex = { line= 92; column= 24 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 93; column= 31 }
        let original: MappingIndex = { line= 92; column= 29 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 97; column= 43 }
        let original: MappingIndex = { line= 98; column= 40 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 98; column= 8 }
        let original: MappingIndex = { line= 99; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "isNegative")
        let generated: MappingIndex = { line= 98; column= 21 }
        let original: MappingIndex = { line= 99; column= 33 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 98; column= 22 }
        let original: MappingIndex = { line= 99; column= 33 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 98; column= 22 }
        let original: MappingIndex = { line= 99; column= 33 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 98; column= 30 }
        let original: MappingIndex = { line= 99; column= 43 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 98; column= 37 }
        let original: MappingIndex = { line= 99; column= 47 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 99; column= 8 }
        let original: MappingIndex = { line= 100; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "shifted")
        let generated: MappingIndex = { line= 99; column= 18 }
        let original: MappingIndex = { line= 100; column= 30 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 99; column= 18 }
        let original: MappingIndex = { line= 100; column= 30 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "value")
        let generated: MappingIndex = { line= 99; column= 27 }
        let original: MappingIndex = { line= 100; column= 40 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 100; column= 0 }
        let original: MappingIndex = { line= 101; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 100; column= 0 }
        let original: MappingIndex = { line= 101; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 100; column= 8 }
        let original: MappingIndex = { line= 101; column= 11 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "isNegative")
        let generated: MappingIndex = { line= 101; column= 15 }
        let original: MappingIndex = { line= 102; column= 13 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 101; column= 38 }
        let original: MappingIndex = { line= 102; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "shifted")
        let generated: MappingIndex = { line= 104; column= 15 }
        let original: MappingIndex = { line= 103; column= 13 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "shifted")
        let generated: MappingIndex = { line= 108; column= 43 }
        let original: MappingIndex = { line= 105; column= 25 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "number")
        let generated: MappingIndex = { line= 109; column= 8 }
        let original: MappingIndex = { line= 106; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "encoded")
        let generated: MappingIndex = { line= 109; column= 18 }
        let original: MappingIndex = { line= 106; column= 30 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 110; column= 8 }
        let original: MappingIndex = { line= 107; column= 21 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "digit")
        let generated: MappingIndex = { line= 111; column= 8 }
        let original: MappingIndex = { line= 108; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "vlq")
        let generated: MappingIndex = { line= 111; column= 14 }
        let original: MappingIndex = { line= 108; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 111; column= 14 }
        let original: MappingIndex = { line= 108; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "ToVLQSigned")
        let generated: MappingIndex = { line= 111; column= 46 }
        let original: MappingIndex = { line= 108; column= 49 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "number")
        let generated: MappingIndex = { line= 112; column= 8 }
        let original: MappingIndex = { line= 110; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "isZeroCase")
        let generated: MappingIndex = { line= 112; column= 21 }
        let original: MappingIndex = { line= 110; column= 33 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 112; column= 21 }
        let original: MappingIndex = { line= 110; column= 33 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "number")
        let generated: MappingIndex = { line= 112; column= 32 }
        let original: MappingIndex = { line= 110; column= 42 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 0 }
        let original: MappingIndex = { line= 111; column= 8 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 11 }
        let original: MappingIndex = { line= 111; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 12 }
        let original: MappingIndex = { line= 111; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 12 }
        let original: MappingIndex = { line= 111; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "vlq")
        let generated: MappingIndex = { line= 113; column= 18 }
        let original: MappingIndex = { line= 111; column= 20 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 23 }
        let original: MappingIndex = { line= 111; column= 14 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 30 }
        let original: MappingIndex = { line= 111; column= 25 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "isZeroCase")
        let generated: MappingIndex = { line= 114; column= 0 }
        let original: MappingIndex = { line= 112; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 114; column= 0 }
        let original: MappingIndex = { line= 112; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "isZeroCase")
        let generated: MappingIndex = { line= 114; column= 21 }
        let original: MappingIndex = { line= 112; column= 26 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 115; column= 0 }
        let original: MappingIndex = { line= 113; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 115; column= 0 }
        let original: MappingIndex = { line= 113; column= 12 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "digit")
        let generated: MappingIndex = { line= 115; column= 18 }
        let original: MappingIndex = { line= 113; column= 21 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 115; column= 18 }
        let original: MappingIndex = { line= 113; column= 21 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=Some "vlq")
        let generated: MappingIndex = { line= 115; column= 24 }
        let original: MappingIndex = { line= 113; column= 29 }
        map.AddMapping(generated, original, source="../../../src/Base64VLQ.fs",?name=None)
        let generated: MappingIndex = { line= 115; column= 24 }
        let original: MappingIndex = { line= 113; column= 29 }
        let generated: MappingIndex = { line= 8; column= 0 }
        let original: MappingIndex = { line= 17; column= 4 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 9; column= 0 }
        let original: MappingIndex = { line= 18; column= 4 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 9; column= 23 }
        let original: MappingIndex = { line= 18; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 0 }
        let original: MappingIndex = { line= 19; column= 4 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 22 }
        let original: MappingIndex = { line= 19; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 34 }
        let original: MappingIndex = { line= 19; column= 37 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 51 }
        let original: MappingIndex = { line= 19; column= 45 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 55 }
        let original: MappingIndex = { line= 19; column= 58 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 59 }
        let original: MappingIndex = { line= 19; column= 70 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 67 }
        let original: MappingIndex = { line= 19; column= 84 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 75 }
        let original: MappingIndex = { line= 19; column= 94 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 22; column= 55 }
        let original: MappingIndex = { line= 21; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 22; column= 58 }
        let original: MappingIndex = { line= 21; column= 29 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "aCallback")
        let generated: MappingIndex = { line= 23; column= 0 }
        let original: MappingIndex = { line= 22; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 23; column= 0 }
        let original: MappingIndex = { line= 22; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 23; column= 0 }
        let original: MappingIndex = { line= 22; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 23; column= 0 }
        let original: MappingIndex = { line= 22; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 23; column= 21 }
        let original: MappingIndex = { line= 22; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "aCallback")
        let generated: MappingIndex = { line= 26; column= 43 }
        let original: MappingIndex = { line= 24; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 26; column= 46 }
        let original: MappingIndex = { line= 24; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "aMapping")
        let generated: MappingIndex = { line= 27; column= 8 }
        let original: MappingIndex = { line= 7; column= 39 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 27; column= 18 }
        let original: MappingIndex = { line= 7; column= 58 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 27; column= 28 }
        let original: MappingIndex = { line= 8; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineA")
        let generated: MappingIndex = { line= 27; column= 35 }
        let original: MappingIndex = { line= 9; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineB")
        let generated: MappingIndex = { line= 27; column= 42 }
        let original: MappingIndex = { line= 58; column= 52 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 27; column= 54 }
        let original: MappingIndex = { line= 58; column= 72 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 27; column= 66 }
        let original: MappingIndex = { line= 59; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 27; column= 71 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 27; column= 75 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 27; column= 79 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 27; column= 91 }
        let original: MappingIndex = { line= 69; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapAOriginal")
        let generated: MappingIndex = { line= 27; column= 105 }
        let original: MappingIndex = { line= 69; column= 42 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapBOriginal")
        let generated: MappingIndex = { line= 27; column= 119 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 27; column= 125 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 27; column= 131 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 27; column= 137 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 0 }
        let original: MappingIndex = { line= 25; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 0 }
        let original: MappingIndex = { line= 25; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 9 }
        let original: MappingIndex = { line= 7; column= 39 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 20 }
        let original: MappingIndex = { line= 25; column= 46 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 20 }
        let original: MappingIndex = { line= 25; column= 46 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 28; column= 30 }
        let original: MappingIndex = { line= 7; column= 58 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 41 }
        let original: MappingIndex = { line= 25; column= 52 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "aMapping")
        let generated: MappingIndex = { line= 28; column= 52 }
        let original: MappingIndex = { line= 8; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineA")
        let generated: MappingIndex = { line= 28; column= 61 }
        let original: MappingIndex = { line= 8; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 61 }
        let original: MappingIndex = { line= 8; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 61 }
        let original: MappingIndex = { line= 8; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 92 }
        let original: MappingIndex = { line= 9; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineB")
        let generated: MappingIndex = { line= 28; column= 101 }
        let original: MappingIndex = { line= 9; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 101 }
        let original: MappingIndex = { line= 9; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 101 }
        let original: MappingIndex = { line= 9; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 131 }
        let original: MappingIndex = { line= 12; column= 6 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 132 }
        let original: MappingIndex = { line= 12; column= 6 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 133 }
        let original: MappingIndex = { line= 12; column= 6 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 133 }
        let original: MappingIndex = { line= 12; column= 6 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineB")
        let generated: MappingIndex = { line= 28; column= 141 }
        let original: MappingIndex = { line= 12; column= 14 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineA")
        let generated: MappingIndex = { line= 28; column= 150 }
        let original: MappingIndex = { line= 12; column= 6 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 158 }
        let original: MappingIndex = { line= 13; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 158 }
        let original: MappingIndex = { line= 13; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 159 }
        let original: MappingIndex = { line= 13; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 159 }
        let original: MappingIndex = { line= 13; column= 10 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineB")
        let generated: MappingIndex = { line= 28; column= 169 }
        let original: MappingIndex = { line= 13; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "lineA")
        let generated: MappingIndex = { line= 28; column= 180 }
        let original: MappingIndex = { line= 13; column= 27 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 180 }
        let original: MappingIndex = { line= 11; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 180 }
        let original: MappingIndex = { line= 11; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 180 }
        let original: MappingIndex = { line= 11; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 209 }
        let original: MappingIndex = { line= 10; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 209 }
        let original: MappingIndex = { line= 10; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 209 }
        let original: MappingIndex = { line= 10; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 240 }
        let original: MappingIndex = { line= 12; column= 6 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 248 }
        let original: MappingIndex = { line= 14; column= 9 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 250 }
        let original: MappingIndex = { line= 58; column= 52 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 263 }
        let original: MappingIndex = { line= 14; column= 45 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 274 }
        let original: MappingIndex = { line= 58; column= 72 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 287 }
        let original: MappingIndex = { line= 14; column= 54 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 298 }
        let original: MappingIndex = { line= 59; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 305 }
        let original: MappingIndex = { line= 59; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 305 }
        let original: MappingIndex = { line= 59; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 305 }
        let original: MappingIndex = { line= 59; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 305 }
        let original: MappingIndex = { line= 59; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 333 }
        let original: MappingIndex = { line= 59; column= 52 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 333 }
        let original: MappingIndex = { line= 59; column= 52 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 333 }
        let original: MappingIndex = { line= 59; column= 52 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 361 }
        let original: MappingIndex = { line= 60; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 362 }
        let original: MappingIndex = { line= 60; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 362 }
        let original: MappingIndex = { line= 60; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 370 }
        let original: MappingIndex = { line= 60; column= 18 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 375 }
        let original: MappingIndex = { line= 60; column= 25 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 383 }
        let original: MappingIndex = { line= 62; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 383 }
        let original: MappingIndex = { line= 62; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 391 }
        let original: MappingIndex = { line= 62; column= 19 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 391 }
        let original: MappingIndex = { line= 62; column= 19 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 391 }
        let original: MappingIndex = { line= 62; column= 19 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 391 }
        let original: MappingIndex = { line= 62; column= 19 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 421 }
        let original: MappingIndex = { line= 62; column= 47 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 421 }
        let original: MappingIndex = { line= 62; column= 47 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 421 }
        let original: MappingIndex = { line= 62; column= 47 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 456 }
        let original: MappingIndex = { line= 63; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 457 }
        let original: MappingIndex = { line= 63; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 457 }
        let original: MappingIndex = { line= 63; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 465 }
        let original: MappingIndex = { line= 63; column= 22 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 470 }
        let original: MappingIndex = { line= 63; column= 29 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 478 }
        let original: MappingIndex = { line= 65; column= 14 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 478 }
        let original: MappingIndex = { line= 65; column= 14 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 487 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 492 }
        let original: MappingIndex = { line= 65; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 492 }
        let original: MappingIndex = { line= 65; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 512 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 517 }
        let original: MappingIndex = { line= 65; column= 44 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 517 }
        let original: MappingIndex = { line= 65; column= 44 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 536 }
        let original: MappingIndex = { line= 48; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 537 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 537 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 538 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 538 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 554 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 554 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 570 }
        let original: MappingIndex = { line= 49; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 571 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 571 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 577 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 585 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 591 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 598 }
        let original: MappingIndex = { line= 49; column= 40 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 603 }
        let original: MappingIndex = { line= 50; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 604 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 604 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 610 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 616 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 622 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 629 }
        let original: MappingIndex = { line= 50; column= 42 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 633 }
        let original: MappingIndex = { line= 51; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 641 }
        let original: MappingIndex = { line= 52; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 642 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 642 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 643 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 643 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 659 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 659 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 674 }
        let original: MappingIndex = { line= 53; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 679 }
        let original: MappingIndex = { line= 54; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 680 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 680 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 694 }
        let original: MappingIndex = { line= 54; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 699 }
        let original: MappingIndex = { line= 55; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 700 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 700 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 714 }
        let original: MappingIndex = { line= 55; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 719 }
        let original: MappingIndex = { line= 56; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 734 }
        let original: MappingIndex = { line= 66; column= 14 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 735 }
        let original: MappingIndex = { line= 66; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 735 }
        let original: MappingIndex = { line= 66; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 743 }
        let original: MappingIndex = { line= 66; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 748 }
        let original: MappingIndex = { line= 66; column= 31 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 756 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 28; column= 770 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 770 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 791 }
        let original: MappingIndex = { line= 68; column= 41 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 791 }
        let original: MappingIndex = { line= 68; column= 41 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 813 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 814 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 814 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 814 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 28; column= 840 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 841 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 841 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 841 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 28; column= 868 }
        let original: MappingIndex = { line= 69; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapAOriginal")
        let generated: MappingIndex = { line= 28; column= 883 }
        let original: MappingIndex = { line= 69; column= 19 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 883 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 28; column= 899 }
        let original: MappingIndex = { line= 69; column= 42 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapBOriginal")
        let generated: MappingIndex = { line= 28; column= 914 }
        let original: MappingIndex = { line= 69; column= 37 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 914 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 28; column= 930 }
        let original: MappingIndex = { line= 70; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 930 }
        let original: MappingIndex = { line= 70; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 938 }
        let original: MappingIndex = { line= 70; column= 27 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 938 }
        let original: MappingIndex = { line= 70; column= 27 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 938 }
        let original: MappingIndex = { line= 70; column= 27 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapAOriginal")
        let generated: MappingIndex = { line= 28; column= 958 }
        let original: MappingIndex = { line= 70; column= 47 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 958 }
        let original: MappingIndex = { line= 70; column= 47 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapBOriginal")
        let generated: MappingIndex = { line= 28; column= 983 }
        let original: MappingIndex = { line= 71; column= 20 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 984 }
        let original: MappingIndex = { line= 71; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 984 }
        let original: MappingIndex = { line= 71; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 992 }
        let original: MappingIndex = { line= 71; column= 30 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 997 }
        let original: MappingIndex = { line= 71; column= 37 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 1005 }
        let original: MappingIndex = { line= 73; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1005 }
        let original: MappingIndex = { line= 73; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 1013 }
        let original: MappingIndex = { line= 73; column= 31 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1013 }
        let original: MappingIndex = { line= 73; column= 31 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1013 }
        let original: MappingIndex = { line= 73; column= 31 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapAOriginal")
        let generated: MappingIndex = { line= 28; column= 1035 }
        let original: MappingIndex = { line= 73; column= 53 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1035 }
        let original: MappingIndex = { line= 73; column= 53 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mapBOriginal")
        let generated: MappingIndex = { line= 28; column= 1062 }
        let original: MappingIndex = { line= 74; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1063 }
        let original: MappingIndex = { line= 74; column= 27 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1063 }
        let original: MappingIndex = { line= 74; column= 27 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 1071 }
        let original: MappingIndex = { line= 74; column= 34 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1076 }
        let original: MappingIndex = { line= 74; column= 41 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 28; column= 1084 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1091 }
        let original: MappingIndex = { line= 75; column= 36 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1091 }
        let original: MappingIndex = { line= 75; column= 36 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 1109 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1116 }
        let original: MappingIndex = { line= 75; column= 50 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1116 }
        let original: MappingIndex = { line= 75; column= 50 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 1133 }
        let original: MappingIndex = { line= 48; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1134 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1134 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1135 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1135 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1153 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1153 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1171 }
        let original: MappingIndex = { line= 49; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1172 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1172 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1178 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1188 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1194 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1203 }
        let original: MappingIndex = { line= 49; column= 40 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1208 }
        let original: MappingIndex = { line= 50; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1209 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1209 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1215 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1223 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1229 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1238 }
        let original: MappingIndex = { line= 50; column= 42 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1242 }
        let original: MappingIndex = { line= 51; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1250 }
        let original: MappingIndex = { line= 52; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1251 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1251 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1252 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1252 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1270 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1270 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1287 }
        let original: MappingIndex = { line= 53; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1292 }
        let original: MappingIndex = { line= 54; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1293 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1293 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1309 }
        let original: MappingIndex = { line= 54; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1314 }
        let original: MappingIndex = { line= 55; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1315 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1315 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1331 }
        let original: MappingIndex = { line= 55; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1336 }
        let original: MappingIndex = { line= 56; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1355 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1362 }
        let original: MappingIndex = { line= 76; column= 30 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1362 }
        let original: MappingIndex = { line= 76; column= 30 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 1380 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1387 }
        let original: MappingIndex = { line= 76; column= 44 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1387 }
        let original: MappingIndex = { line= 76; column= 44 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 1404 }
        let original: MappingIndex = { line= 48; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1405 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1405 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1406 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1406 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1424 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1424 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1442 }
        let original: MappingIndex = { line= 49; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1443 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1443 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1449 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1459 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1465 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1474 }
        let original: MappingIndex = { line= 49; column= 40 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1479 }
        let original: MappingIndex = { line= 50; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1480 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1480 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1486 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1494 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1500 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1509 }
        let original: MappingIndex = { line= 50; column= 42 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1513 }
        let original: MappingIndex = { line= 51; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1521 }
        let original: MappingIndex = { line= 52; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1522 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1522 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1523 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1523 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1541 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1541 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1558 }
        let original: MappingIndex = { line= 53; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1563 }
        let original: MappingIndex = { line= 54; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1564 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1564 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1580 }
        let original: MappingIndex = { line= 54; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1585 }
        let original: MappingIndex = { line= 55; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1586 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1586 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1602 }
        let original: MappingIndex = { line= 55; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1607 }
        let original: MappingIndex = { line= 56; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1621 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1628 }
        let original: MappingIndex = { line= 76; column= 30 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1628 }
        let original: MappingIndex = { line= 76; column= 30 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 28; column= 1646 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1653 }
        let original: MappingIndex = { line= 76; column= 44 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1653 }
        let original: MappingIndex = { line= 76; column= 44 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 28; column= 1670 }
        let original: MappingIndex = { line= 48; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1671 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1671 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1672 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1672 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1690 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1690 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1708 }
        let original: MappingIndex = { line= 49; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1709 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1709 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1715 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1725 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1731 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1740 }
        let original: MappingIndex = { line= 49; column= 40 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1745 }
        let original: MappingIndex = { line= 50; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1746 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1746 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1752 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1760 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1766 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1775 }
        let original: MappingIndex = { line= 50; column= 42 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1779 }
        let original: MappingIndex = { line= 51; column= 17 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1787 }
        let original: MappingIndex = { line= 52; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1788 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1788 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1789 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1789 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1807 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1807 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1824 }
        let original: MappingIndex = { line= 53; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1829 }
        let original: MappingIndex = { line= 54; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1830 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1830 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 28; column= 1846 }
        let original: MappingIndex = { line= 54; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1851 }
        let original: MappingIndex = { line= 55; column= 8 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1852 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1852 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 28; column= 1868 }
        let original: MappingIndex = { line= 55; column= 28 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1873 }
        let original: MappingIndex = { line= 56; column= 13 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 1895 }
        let original: MappingIndex = { line= 14; column= 66 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 29; column= 0 }
        let original: MappingIndex = { line= 26; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 29; column= 0 }
        let original: MappingIndex = { line= 26; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 29; column= 18 }
        let original: MappingIndex = { line= 26; column= 21 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "aMapping")
        let generated: MappingIndex = { line= 30; column= 0 }
        let original: MappingIndex = { line= 27; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 14 }
        let original: MappingIndex = { line= 27; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 14 }
        let original: MappingIndex = { line= 27; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 14 }
        let original: MappingIndex = { line= 27; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 30; column= 28 }
        let original: MappingIndex = { line= 27; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "aMapping")
        let generated: MappingIndex = { line= 33; column= 0 }
        let original: MappingIndex = { line= 29; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 33; column= 0 }
        let original: MappingIndex = { line= 29; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=Some "_")
        let generated: MappingIndex = { line= 33; column= 20 }
        let original: MappingIndex = { line= 29; column= 23 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 0 }
        let original: MappingIndex = { line= 30; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 34; column= 14 }
        let original: MappingIndex = { line= 30; column= 12 }
        map.AddMapping(generated, original, source="../../../src/MappingList.fs",?name=None)
        let generated: MappingIndex = { line= 8; column= 41 }
        let original: MappingIndex = { line= 7; column= 18 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 10; column= 49 }
        let original: MappingIndex = { line= 8; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 12; column= 48 }
        let original: MappingIndex = { line= 9; column= 25 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 14; column= 54 }
        let original: MappingIndex = { line= 10; column= 31 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 16; column= 51 }
        let original: MappingIndex = { line= 11; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 19; column= 16 }
        let original: MappingIndex = { line= 14; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceMap")
        let generated: MappingIndex = { line= 19; column= 27 }
        let original: MappingIndex = { line= 14; column= 60 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceMapUrl")
        let generated: MappingIndex = { line= 20; column= 0 }
        let original: MappingIndex = { line= 16; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 20; column= 0 }
        let original: MappingIndex = { line= 16; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 20; column= 12 }
        let original: MappingIndex = { line= 16; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 20; column= 12 }
        let original: MappingIndex = { line= 16; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "version")
        let generated: MappingIndex = { line= 20; column= 42 }
        let original: MappingIndex = { line= 16; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 20; column= 42 }
        let original: MappingIndex = { line= 16; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceMap")
        let generated: MappingIndex = { line= 21; column= 0 }
        let original: MappingIndex = { line= 17; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 21; column= 0 }
        let original: MappingIndex = { line= 17; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 21; column= 19 }
        let original: MappingIndex = { line= 17; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 21; column= 26 }
        let original: MappingIndex = { line= 17; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 21; column= 53 }
        let original: MappingIndex = { line= 17; column= 48 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 21; column= 53 }
        let original: MappingIndex = { line= 17; column= 48 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceMap")
        let generated: MappingIndex = { line= 23; column= 14 }
        let original: MappingIndex = { line= 23; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "_sourceLookupCache")
        let generated: MappingIndex = { line= 23; column= 35 }
        let original: MappingIndex = { line= 23; column= 29 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 24; column= 14 }
        let original: MappingIndex = { line= 28; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "_names")
        let generated: MappingIndex = { line= 24; column= 23 }
        let original: MappingIndex = { line= 28; column= 18 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 24; column= 65 }
        let original: MappingIndex = { line= 28; column= 37 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 24; column= 65 }
        let original: MappingIndex = { line= 28; column= 37 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceMap")
        let generated: MappingIndex = { line= 24; column= 83 }
        let original: MappingIndex = { line= 28; column= 69 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 25; column= 14 }
        let original: MappingIndex = { line= 29; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "_sources")
        let generated: MappingIndex = { line= 25; column= 25 }
        let original: MappingIndex = { line= 29; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 25; column= 67 }
        let original: MappingIndex = { line= 29; column= 38 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 25; column= 67 }
        let original: MappingIndex = { line= 29; column= 38 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceMap")
        let generated: MappingIndex = { line= 25; column= 87 }
        let original: MappingIndex = { line= 29; column= 72 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 26; column= 14 }
        let original: MappingIndex = { line= 30; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceRoot")
        let generated: MappingIndex = { line= 26; column= 27 }
        let original: MappingIndex = { line= 30; column= 45 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 26; column= 38 }
        let original: MappingIndex = { line= 30; column= 21 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 26; column= 38 }
        let original: MappingIndex = { line= 30; column= 21 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceMap")
        let generated: MappingIndex = { line= 26; column= 60 }
        let original: MappingIndex = { line= 30; column= 65 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 27; column= 14 }
        let original: MappingIndex = { line= 31; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceUrls")
        let generated: MappingIndex = { line= 27; column= 38 }
        let original: MappingIndex = { line= 33; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 27; column= 43 }
        let original: MappingIndex = { line= 33; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "s")
        let generated: MappingIndex = { line= 27; column= 49 }
        let original: MappingIndex = { line= 33; column= 29 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 27; column= 66 }
        let original: MappingIndex = { line= 33; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceRoot")
        let generated: MappingIndex = { line= 27; column= 78 }
        let original: MappingIndex = { line= 33; column= 57 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "s")
        let generated: MappingIndex = { line= 27; column= 81 }
        let original: MappingIndex = { line= 33; column= 59 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceMapUrl")
        let generated: MappingIndex = { line= 27; column= 96 }
        let original: MappingIndex = { line= 32; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 27; column= 96 }
        let original: MappingIndex = { line= 32; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceMap")
        let generated: MappingIndex = { line= 28; column= 0 }
        let original: MappingIndex = { line= 35; column= 4 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 32 }
        let original: MappingIndex = { line= 35; column= 27 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 28; column= 63 }
        let original: MappingIndex = { line= 35; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceUrls")
        let generated: MappingIndex = { line= 28; column= 75 }
        let original: MappingIndex = { line= 35; column= 58 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 29; column= 14 }
        let original: MappingIndex = { line= 36; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourcesContent")
        let generated: MappingIndex = { line= 29; column= 31 }
        let original: MappingIndex = { line= 36; column= 53 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 29; column= 42 }
        let original: MappingIndex = { line= 36; column= 25 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 29; column= 42 }
        let original: MappingIndex = { line= 36; column= 25 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceMap")
        let generated: MappingIndex = { line= 29; column= 68 }
        let original: MappingIndex = { line= 36; column= 73 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 0 }
        let original: MappingIndex = { line= 37; column= 38 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 30; column= 40 }
        let original: MappingIndex = { line= 37; column= 38 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 31; column= 0 }
        let original: MappingIndex = { line= 38; column= 30 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 31; column= 32 }
        let original: MappingIndex = { line= 38; column= 30 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=None)
        let generated: MappingIndex = { line= 39; column= 54 }
        let original: MappingIndex = { line= 14; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapConsumer.fs",?name=Some "sourceMap")
        let generated: MappingIndex = { line= 16; column= 16 }
        let original: MappingIndex = { line= 14; column= 25 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "skipValidation")
        let generated: MappingIndex = { line= 16; column= 32 }
        let original: MappingIndex = { line= 14; column= 47 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "file")
        let generated: MappingIndex = { line= 16; column= 38 }
        let original: MappingIndex = { line= 14; column= 61 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "sourceRoot")
        let generated: MappingIndex = { line= 17; column= 0 }
        let original: MappingIndex = { line= 16; column= 4 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 17; column= 21 }
        let original: MappingIndex = { line= 16; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "file")
        let generated: MappingIndex = { line= 18; column= 0 }
        let original: MappingIndex = { line= 17; column= 4 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 18; column= 27 }
        let original: MappingIndex = { line= 17; column= 22 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "sourceRoot")
        let generated: MappingIndex = { line= 19; column= 0 }
        let original: MappingIndex = { line= 18; column= 4 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 19; column= 31 }
        let original: MappingIndex = { line= 18; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 19; column= 42 }
        let original: MappingIndex = { line= 18; column= 37 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "skipValidation")
        let generated: MappingIndex = { line= 19; column= 58 }
        let original: MappingIndex = { line= 18; column= 52 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 20; column= 0 }
        let original: MappingIndex = { line= 19; column= 4 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 20; column= 22 }
        let original: MappingIndex = { line= 19; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 21; column= 0 }
        let original: MappingIndex = { line= 20; column= 4 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 21; column= 25 }
        let original: MappingIndex = { line= 20; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 22; column= 0 }
        let original: MappingIndex = { line= 21; column= 34 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 22; column= 37 }
        let original: MappingIndex = { line= 21; column= 34 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 23; column= 0 }
        let original: MappingIndex = { line= 22; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 23; column= 28 }
        let original: MappingIndex = { line= 22; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 31; column= 48 }
        let original: MappingIndex = { line= 14; column= 25 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "skipValidation")
        let generated: MappingIndex = { line= 31; column= 64 }
        let original: MappingIndex = { line= 14; column= 47 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "file")
        let generated: MappingIndex = { line= 31; column= 70 }
        let original: MappingIndex = { line= 14; column= 61 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "sourceRoot")
        let generated: MappingIndex = { line= 35; column= 57 }
        let original: MappingIndex = { line= 21; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "__")
        let generated: MappingIndex = { line= 36; column= 11 }
        let original: MappingIndex = { line= 21; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 36; column= 11 }
        let original: MappingIndex = { line= 21; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "__")
        let generated: MappingIndex = { line= 39; column= 49 }
        let original: MappingIndex = { line= 22; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "__")
        let generated: MappingIndex = { line= 40; column= 11 }
        let original: MappingIndex = { line= 22; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 40; column= 11 }
        let original: MappingIndex = { line= 22; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "__")
        let generated: MappingIndex = { line= 44; column= 11 }
        let original: MappingIndex = { line= 24; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 47; column= 61 }
        let original: MappingIndex = { line= 34; column= 34 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "generated")
        let generated: MappingIndex = { line= 47; column= 72 }
        let original: MappingIndex = { line= 34; column= 58 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 47; column= 82 }
        let original: MappingIndex = { line= 34; column= 88 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 47; column= 90 }
        let original: MappingIndex = { line= 34; column= 110 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "name")
        let generated: MappingIndex = { line= 48; column= 8 }
        let original: MappingIndex = { line= 36; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "isInvalid")
        let generated: MappingIndex = { line= 48; column= 20 }
        let original: MappingIndex = { line= 36; column= 32 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 37; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 0 }
        let original: MappingIndex = { line= 37; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 8 }
        let original: MappingIndex = { line= 37; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 8 }
        let original: MappingIndex = { line= 37; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 9 }
        let original: MappingIndex = { line= 37; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 9 }
        let original: MappingIndex = { line= 37; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 10 }
        let original: MappingIndex = { line= 37; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 10 }
        let original: MappingIndex = { line= 37; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 11 }
        let original: MappingIndex = { line= 37; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 11 }
        let original: MappingIndex = { line= 37; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 12 }
        let original: MappingIndex = { line= 37; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 12 }
        let original: MappingIndex = { line= 37; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 12 }
        let original: MappingIndex = { line= 37; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "generated")
        let generated: MappingIndex = { line= 49; column= 29 }
        let original: MappingIndex = { line= 37; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 36 }
        let original: MappingIndex = { line= 37; column= 33 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 36 }
        let original: MappingIndex = { line= 37; column= 33 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 36 }
        let original: MappingIndex = { line= 37; column= 33 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "generated")
        let generated: MappingIndex = { line= 49; column= 56 }
        let original: MappingIndex = { line= 37; column= 52 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 64 }
        let original: MappingIndex = { line= 37; column= 57 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 64 }
        let original: MappingIndex = { line= 37; column= 57 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 49; column= 87 }
        let original: MappingIndex = { line= 37; column= 76 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 87 }
        let original: MappingIndex = { line= 37; column= 76 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 49; column= 108 }
        let original: MappingIndex = { line= 37; column= 93 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 49; column= 108 }
        let original: MappingIndex = { line= 37; column= 93 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "name")
        let generated: MappingIndex = { line= 50; column= 0 }
        let original: MappingIndex = { line= 38; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 50; column= 0 }
        let original: MappingIndex = { line= 38; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "isInvalid")
        let generated: MappingIndex = { line= 50; column= 20 }
        let original: MappingIndex = { line= 38; column= 25 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 9 }
        let original: MappingIndex = { line= 40; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 9 }
        let original: MappingIndex = { line= 40; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 13 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 13 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 14 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 14 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 15 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 15 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 16 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 16 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 17 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 17 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 18 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 18 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 18 }
        let original: MappingIndex = { line= 40; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "generated")
        let generated: MappingIndex = { line= 52; column= 35 }
        let original: MappingIndex = { line= 40; column= 30 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 42 }
        let original: MappingIndex = { line= 40; column= 35 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 42 }
        let original: MappingIndex = { line= 40; column= 35 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 42 }
        let original: MappingIndex = { line= 40; column= 35 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "generated")
        let generated: MappingIndex = { line= 52; column= 62 }
        let original: MappingIndex = { line= 40; column= 54 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 70 }
        let original: MappingIndex = { line= 41; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 70 }
        let original: MappingIndex = { line= 41; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 52; column= 93 }
        let original: MappingIndex = { line= 41; column= 35 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 93 }
        let original: MappingIndex = { line= 41; column= 35 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 93 }
        let original: MappingIndex = { line= 41; column= 35 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 101 }
        let original: MappingIndex = { line= 41; column= 35 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 52; column= 118 }
        let original: MappingIndex = { line= 41; column= 57 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 126 }
        let original: MappingIndex = { line= 41; column= 62 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 126 }
        let original: MappingIndex = { line= 41; column= 62 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 126 }
        let original: MappingIndex = { line= 41; column= 62 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 134 }
        let original: MappingIndex = { line= 41; column= 62 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 52; column= 154 }
        let original: MappingIndex = { line= 41; column= 87 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 162 }
        let original: MappingIndex = { line= 42; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 52; column= 162 }
        let original: MappingIndex = { line= 42; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 53; column= 0 }
        let original: MappingIndex = { line= 43; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 53; column= 0 }
        let original: MappingIndex = { line= 43; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "isInvalid")
        let generated: MappingIndex = { line= 53; column= 20 }
        let original: MappingIndex = { line= 43; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 55; column= 0 }
        let original: MappingIndex = { line= 45; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 55; column= 0 }
        let original: MappingIndex = { line= 45; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 55; column= 8 }
        let original: MappingIndex = { line= 45; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "isInvalid")
        let generated: MappingIndex = { line= 56; column= 14 }
        let original: MappingIndex = { line= 46; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "options")
        let generated: MappingIndex = { line= 57; column= 23 }
        let original: MappingIndex = { line= 46; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "generated")
        let generated: MappingIndex = { line= 58; column= 18 }
        let original: MappingIndex = { line= 46; column= 90 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "name")
        let generated: MappingIndex = { line= 59; column= 22 }
        let original: MappingIndex = { line= 46; column= 75 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 60; column= 20 }
        let original: MappingIndex = { line= 46; column= 58 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 62; column= 14 }
        let original: MappingIndex = { line= 47; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "err")
        let generated: MappingIndex = { line= 62; column= 20 }
        let original: MappingIndex = { line= 47; column= 22 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 62; column= 20 }
        let original: MappingIndex = { line= 47; column= 22 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 62; column= 27 }
        let original: MappingIndex = { line= 47; column= 30 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 62; column= 34 }
        let original: MappingIndex = { line= 47; column= 30 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 62; column= 58 }
        let original: MappingIndex = { line= 47; column= 52 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "options")
        let generated: MappingIndex = { line= 63; column= 0 }
        let original: MappingIndex = { line= 48; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 63; column= 15 }
        let original: MappingIndex = { line= 48; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 63; column= 25 }
        let original: MappingIndex = { line= 48; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "err")
        let generated: MappingIndex = { line= 67; column= 57 }
        let original: MappingIndex = { line= 58; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 67; column= 64 }
        let original: MappingIndex = { line= 58; column= 27 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "generated")
        let generated: MappingIndex = { line= 67; column= 75 }
        let original: MappingIndex = { line= 58; column= 52 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 67; column= 85 }
        let original: MappingIndex = { line= 58; column= 76 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 67; column= 93 }
        let original: MappingIndex = { line= 58; column= 92 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "name")
        let generated: MappingIndex = { line= 68; column= 0 }
        let original: MappingIndex = { line= 59; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 68; column= 0 }
        let original: MappingIndex = { line= 59; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 68; column= 8 }
        let original: MappingIndex = { line= 59; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 68; column= 9 }
        let original: MappingIndex = { line= 59; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 68; column= 9 }
        let original: MappingIndex = { line= 59; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 69; column= 0 }
        let original: MappingIndex = { line= 60; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 69; column= 0 }
        let original: MappingIndex = { line= 60; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "ValidateMapping")
        let generated: MappingIndex = { line= 69; column= 53 }
        let original: MappingIndex = { line= 60; column= 50 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "generated")
        let generated: MappingIndex = { line= 69; column= 64 }
        let original: MappingIndex = { line= 60; column= 60 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 69; column= 74 }
        let original: MappingIndex = { line= 60; column= 69 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 69; column= 82 }
        let original: MappingIndex = { line= 60; column= 76 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "name")
        let generated: MappingIndex = { line= 71; column= 0 }
        let original: MappingIndex = { line= 62; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 71; column= 0 }
        let original: MappingIndex = { line= 62; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 71; column= 8 }
        let original: MappingIndex = { line= 62; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 71; column= 8 }
        let original: MappingIndex = { line= 62; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 72; column= 0 }
        let original: MappingIndex = { line= 63; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 72; column= 0 }
        let original: MappingIndex = { line= 63; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 72; column= 12 }
        let original: MappingIndex = { line= 63; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 72; column= 13 }
        let original: MappingIndex = { line= 63; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 72; column= 35 }
        let original: MappingIndex = { line= 63; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 72; column= 35 }
        let original: MappingIndex = { line= 63; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "_sources")
        let generated: MappingIndex = { line= 72; column= 68 }
        let original: MappingIndex = { line= 63; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 72; column= 76 }
        let original: MappingIndex = { line= 63; column= 38 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 72; column= 84 }
        let original: MappingIndex = { line= 63; column= 38 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 73; column= 0 }
        let original: MappingIndex = { line= 64; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 73; column= 38 }
        let original: MappingIndex = { line= 64; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 73; column= 38 }
        let original: MappingIndex = { line= 64; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "_sources")
        let generated: MappingIndex = { line= 73; column= 71 }
        let original: MappingIndex = { line= 64; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 73; column= 79 }
        let original: MappingIndex = { line= 64; column= 34 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 73; column= 87 }
        let original: MappingIndex = { line= 64; column= 34 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 73; column= 96 }
        let original: MappingIndex = { line= 64; column= 48 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 76; column= 0 }
        let original: MappingIndex = { line= 66; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 76; column= 0 }
        let original: MappingIndex = { line= 66; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 76; column= 8 }
        let original: MappingIndex = { line= 66; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 76; column= 8 }
        let original: MappingIndex = { line= 66; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "name")
        let generated: MappingIndex = { line= 77; column= 0 }
        let original: MappingIndex = { line= 67; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 77; column= 0 }
        let original: MappingIndex = { line= 67; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 77; column= 12 }
        let original: MappingIndex = { line= 67; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 77; column= 13 }
        let original: MappingIndex = { line= 67; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 77; column= 35 }
        let original: MappingIndex = { line= 67; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 77; column= 35 }
        let original: MappingIndex = { line= 67; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 77; column= 49 }
        let original: MappingIndex = { line= 67; column= 31 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 77; column= 57 }
        let original: MappingIndex = { line= 67; column= 31 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "name")
        let generated: MappingIndex = { line= 78; column= 0 }
        let original: MappingIndex = { line= 68; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 78; column= 38 }
        let original: MappingIndex = { line= 68; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 78; column= 38 }
        let original: MappingIndex = { line= 68; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 78; column= 52 }
        let original: MappingIndex = { line= 68; column= 27 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 78; column= 60 }
        let original: MappingIndex = { line= 68; column= 27 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "name")
        let generated: MappingIndex = { line= 78; column= 67 }
        let original: MappingIndex = { line= 68; column= 39 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 81; column= 0 }
        let original: MappingIndex = { line= 70; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 81; column= 31 }
        let original: MappingIndex = { line= 70; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 81; column= 31 }
        let original: MappingIndex = { line= 70; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 81; column= 48 }
        let original: MappingIndex = { line= 70; column= 22 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 81; column= 60 }
        let original: MappingIndex = { line= 70; column= 33 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "generated")
        let generated: MappingIndex = { line= 81; column= 71 }
        let original: MappingIndex = { line= 70; column= 52 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 81; column= 81 }
        let original: MappingIndex = { line= 70; column= 68 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 81; column= 89 }
        let original: MappingIndex = { line= 70; column= 80 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "name")
        let generated: MappingIndex = { line= 84; column= 68 }
        let original: MappingIndex = { line= 72; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 84; column= 75 }
        let original: MappingIndex = { line= 72; column= 39 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "aSources")
        let generated: MappingIndex = { line= 84; column= 85 }
        let original: MappingIndex = { line= 72; column= 49 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "aSourceRoot")
        let generated: MappingIndex = { line= 85; column= 11 }
        let original: MappingIndex = { line= 74; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 85; column= 16 }
        let original: MappingIndex = { line= 74; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 86; column= 0 }
        let original: MappingIndex = { line= 75; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 86; column= 0 }
        let original: MappingIndex = { line= 75; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 86; column= 12 }
        let original: MappingIndex = { line= 75; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 86; column= 12 }
        let original: MappingIndex = { line= 75; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 86; column= 19 }
        let original: MappingIndex = { line= 75; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 86; column= 19 }
        let original: MappingIndex = { line= 75; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 86; column= 19 }
        let original: MappingIndex = { line= 75; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 86; column= 19 }
        let original: MappingIndex = { line= 75; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "_sourcesContents")
        let generated: MappingIndex = { line= 86; column= 60 }
        let original: MappingIndex = { line= 75; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 86; column= 79 }
        let original: MappingIndex = { line= 75; column= 50 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 87; column= 19 }
        let original: MappingIndex = { line= 76; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 90; column= 16 }
        let original: MappingIndex = { line= 78; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s")
        let generated: MappingIndex = { line= 90; column= 20 }
        let original: MappingIndex = { line= 78; column= 32 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 91; column= 0 }
        let original: MappingIndex = { line= 79; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 91; column= 0 }
        let original: MappingIndex = { line= 79; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 91; column= 16 }
        let original: MappingIndex = { line= 79; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 91; column= 16 }
        let original: MappingIndex = { line= 79; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "aSourceRoot")
        let generated: MappingIndex = { line= 92; column= 0 }
        let original: MappingIndex = { line= 80; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 92; column= 0 }
        let original: MappingIndex = { line= 80; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s")
        let generated: MappingIndex = { line= 92; column= 20 }
        let original: MappingIndex = { line= 80; column= 25 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 92; column= 36 }
        let original: MappingIndex = { line= 80; column= 41 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 92; column= 44 }
        let original: MappingIndex = { line= 80; column= 41 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 92; column= 44 }
        let original: MappingIndex = { line= 80; column= 41 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 92; column= 64 }
        let original: MappingIndex = { line= 80; column= 59 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 94; column= 0 }
        let original: MappingIndex = { line= 82; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 94; column= 0 }
        let original: MappingIndex = { line= 82; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 94; column= 16 }
        let original: MappingIndex = { line= 82; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 94; column= 16 }
        let original: MappingIndex = { line= 82; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 94; column= 16 }
        let original: MappingIndex = { line= 82; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 94; column= 16 }
        let original: MappingIndex = { line= 82; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "_sourcesContents")
        let generated: MappingIndex = { line= 94; column= 57 }
        let original: MappingIndex = { line= 82; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 94; column= 68 }
        let original: MappingIndex = { line= 82; column= 53 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s")
        let generated: MappingIndex = { line= 95; column= 23 }
        let original: MappingIndex = { line= 83; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 95; column= 39 }
        let original: MappingIndex = { line= 83; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 95; column= 39 }
        let original: MappingIndex = { line= 83; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "_sourcesContents")
        let generated: MappingIndex = { line= 95; column= 80 }
        let original: MappingIndex = { line= 83; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 95; column= 88 }
        let original: MappingIndex = { line= 83; column= 51 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s")
        let generated: MappingIndex = { line= 98; column= 23 }
        let original: MappingIndex = { line= 85; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 101; column= 7 }
        let original: MappingIndex = { line= 73; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "aSources")
        let generated: MappingIndex = { line= 104; column= 62 }
        let original: MappingIndex = { line= 88; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 104; column= 69 }
        let original: MappingIndex = { line= 88; column= 33 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "aSourceFile")
        let generated: MappingIndex = { line= 104; column= 82 }
        let original: MappingIndex = { line= 88; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "aSourceContent")
        let generated: MappingIndex = { line= 105; column= 8 }
        let original: MappingIndex = { line= 89; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 105; column= 17 }
        let original: MappingIndex = { line= 89; column= 29 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "aSourceFile")
        let generated: MappingIndex = { line= 106; column= 0 }
        let original: MappingIndex = { line= 90; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 106; column= 0 }
        let original: MappingIndex = { line= 90; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 106; column= 8 }
        let original: MappingIndex = { line= 90; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 106; column= 8 }
        let original: MappingIndex = { line= 90; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 106; column= 8 }
        let original: MappingIndex = { line= 90; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 107; column= 0 }
        let original: MappingIndex = { line= 91; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 107; column= 0 }
        let original: MappingIndex = { line= 91; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 107; column= 17 }
        let original: MappingIndex = { line= 91; column= 22 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 107; column= 33 }
        let original: MappingIndex = { line= 91; column= 38 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 107; column= 41 }
        let original: MappingIndex = { line= 91; column= 38 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 107; column= 41 }
        let original: MappingIndex = { line= 91; column= 38 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 107; column= 61 }
        let original: MappingIndex = { line= 91; column= 56 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 109; column= 0 }
        let original: MappingIndex = { line= 92; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 109; column= 0 }
        let original: MappingIndex = { line= 92; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 109; column= 8 }
        let original: MappingIndex = { line= 92; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 109; column= 8 }
        let original: MappingIndex = { line= 92; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "aSourceContent")
        let generated: MappingIndex = { line= 110; column= 0 }
        let original: MappingIndex = { line= 96; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 110; column= 0 }
        let original: MappingIndex = { line= 96; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 110; column= 0 }
        let original: MappingIndex = { line= 96; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 110; column= 0 }
        let original: MappingIndex = { line= 96; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "_sourcesContents")
        let generated: MappingIndex = { line= 110; column= 49 }
        let original: MappingIndex = { line= 96; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 110; column= 60 }
        let original: MappingIndex = { line= 96; column= 35 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 110; column= 68 }
        let original: MappingIndex = { line= 96; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 110; column= 76 }
        let original: MappingIndex = { line= 96; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "aSourceContent")
        let generated: MappingIndex = { line= 112; column= 9 }
        let original: MappingIndex = { line= 97; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 112; column= 9 }
        let original: MappingIndex = { line= 97; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 112; column= 13 }
        let original: MappingIndex = { line= 97; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 112; column= 13 }
        let original: MappingIndex = { line= 97; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 112; column= 20 }
        let original: MappingIndex = { line= 97; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 112; column= 20 }
        let original: MappingIndex = { line= 97; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 112; column= 20 }
        let original: MappingIndex = { line= 97; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 112; column= 20 }
        let original: MappingIndex = { line= 97; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "_sourcesContents")
        let generated: MappingIndex = { line= 112; column= 61 }
        let original: MappingIndex = { line= 97; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 112; column= 78 }
        let original: MappingIndex = { line= 97; column= 48 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 0 }
        let original: MappingIndex = { line= 101; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 0 }
        let original: MappingIndex = { line= 101; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 0 }
        let original: MappingIndex = { line= 101; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 113; column= 0 }
        let original: MappingIndex = { line= 101; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "_sourcesContents")
        let generated: MappingIndex = { line= 113; column= 49 }
        let original: MappingIndex = { line= 101; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 113; column= 63 }
        let original: MappingIndex = { line= 101; column= 41 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "source")
        let generated: MappingIndex = { line= 117; column= 43 }
        let original: MappingIndex = { line= 103; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 118; column= 10 }
        let original: MappingIndex = { line= 104; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "patternInput")
        let generated: MappingIndex = { line= 118; column= 26 }
        let original: MappingIndex = { line= 104; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 118; column= 26 }
        let original: MappingIndex = { line= 104; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "version")
        let generated: MappingIndex = { line= 118; column= 60 }
        let original: MappingIndex = { line= 105; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 118; column= 80 }
        let original: MappingIndex = { line= 105; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 118; column= 80 }
        let original: MappingIndex = { line= 105; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "_sources")
        let generated: MappingIndex = { line= 118; column= 113 }
        let original: MappingIndex = { line= 105; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 118; column= 122 }
        let original: MappingIndex = { line= 106; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 118; column= 142 }
        let original: MappingIndex = { line= 106; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 118; column= 142 }
        let original: MappingIndex = { line= 106; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 118; column= 157 }
        let original: MappingIndex = { line= 107; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 118; column= 157 }
        let original: MappingIndex = { line= 107; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "SerializeMappings")
        let generated: MappingIndex = { line= 118; column= 195 }
        let original: MappingIndex = { line= 107; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 119; column= 10 }
        let original: MappingIndex = { line= 104; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "sources")
        let generated: MappingIndex = { line= 119; column= 20 }
        let original: MappingIndex = { line= 104; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 119; column= 20 }
        let original: MappingIndex = { line= 104; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "patternInput")
        let generated: MappingIndex = { line= 120; column= 11 }
        let original: MappingIndex = { line= 115; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 35 }
        let original: MappingIndex = { line= 104; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 35 }
        let original: MappingIndex = { line= 104; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "patternInput")
        let generated: MappingIndex = { line= 120; column= 52 }
        let original: MappingIndex = { line= 116; column= 18 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "sources")
        let generated: MappingIndex = { line= 120; column= 61 }
        let original: MappingIndex = { line= 104; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 61 }
        let original: MappingIndex = { line= 104; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "patternInput")
        let generated: MappingIndex = { line= 120; column= 78 }
        let original: MappingIndex = { line= 104; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 78 }
        let original: MappingIndex = { line= 104; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "patternInput")
        let generated: MappingIndex = { line= 120; column= 95 }
        let original: MappingIndex = { line= 119; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 95 }
        let original: MappingIndex = { line= 119; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 120; column= 108 }
        let original: MappingIndex = { line= 110; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 109 }
        let original: MappingIndex = { line= 110; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 109 }
        let original: MappingIndex = { line= 110; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 116 }
        let original: MappingIndex = { line= 110; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 116 }
        let original: MappingIndex = { line= 110; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 116 }
        let original: MappingIndex = { line= 110; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 116 }
        let original: MappingIndex = { line= 110; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "_sourcesContents")
        let generated: MappingIndex = { line= 120; column= 157 }
        let original: MappingIndex = { line= 110; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 120; column= 174 }
        let original: MappingIndex = { line= 110; column= 50 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 179 }
        let original: MappingIndex = { line= 111; column= 21 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 179 }
        let original: MappingIndex = { line= 111; column= 21 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "GenerateSourcesContent")
        let generated: MappingIndex = { line= 120; column= 231 }
        let original: MappingIndex = { line= 111; column= 21 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 120; column= 238 }
        let original: MappingIndex = { line= 111; column= 49 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "sources")
        let generated: MappingIndex = { line= 120; column= 247 }
        let original: MappingIndex = { line= 111; column= 57 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 247 }
        let original: MappingIndex = { line= 111; column= 57 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 120; column= 269 }
        let original: MappingIndex = { line= 113; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 278 }
        let original: MappingIndex = { line= 121; column= 21 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 120; column= 278 }
        let original: MappingIndex = { line= 121; column= 21 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 123; column= 54 }
        let original: MappingIndex = { line= 130; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 124; column= 8 }
        let original: MappingIndex = { line= 58; column= 52 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 124; column= 18 }
        let original: MappingIndex = { line= 58; column= 72 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 124; column= 28 }
        let original: MappingIndex = { line= 59; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 124; column= 33 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 124; column= 37 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 124; column= 41 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 124; column= 53 }
        let original: MappingIndex = { line= 69; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapAOriginal")
        let generated: MappingIndex = { line= 124; column= 67 }
        let original: MappingIndex = { line= 69; column= 42 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapBOriginal")
        let generated: MappingIndex = { line= 124; column= 81 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 124; column= 87 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 124; column= 93 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 124; column= 99 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 124; column= 105 }
        let original: MappingIndex = { line= 164; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "objectArg")
        let generated: MappingIndex = { line= 125; column= 8 }
        let original: MappingIndex = { line= 131; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousGeneratedColumn")
        let generated: MappingIndex = { line= 125; column= 34 }
        let original: MappingIndex = { line= 131; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 126; column= 8 }
        let original: MappingIndex = { line= 132; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousGeneratedLine")
        let generated: MappingIndex = { line= 126; column= 32 }
        let original: MappingIndex = { line= 132; column= 44 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 127; column= 8 }
        let original: MappingIndex = { line= 133; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousOriginalColumn")
        let generated: MappingIndex = { line= 127; column= 33 }
        let original: MappingIndex = { line= 133; column= 45 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 128; column= 8 }
        let original: MappingIndex = { line= 134; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousOriginalLine")
        let generated: MappingIndex = { line= 128; column= 31 }
        let original: MappingIndex = { line= 134; column= 43 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 129; column= 8 }
        let original: MappingIndex = { line= 135; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousName")
        let generated: MappingIndex = { line= 129; column= 23 }
        let original: MappingIndex = { line= 135; column= 35 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 130; column= 8 }
        let original: MappingIndex = { line= 136; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousSource")
        let generated: MappingIndex = { line= 130; column= 25 }
        let original: MappingIndex = { line= 136; column= 37 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 131; column= 10 }
        let original: MappingIndex = { line= 137; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "result")
        let generated: MappingIndex = { line= 131; column= 19 }
        let original: MappingIndex = { line= 137; column= 21 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 132; column= 8 }
        let original: MappingIndex = { line= 138; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "next")
        let generated: MappingIndex = { line= 132; column= 15 }
        let original: MappingIndex = { line= 138; column= 27 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 133; column= 8 }
        let original: MappingIndex = { line= 139; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "nameIdx")
        let generated: MappingIndex = { line= 133; column= 18 }
        let original: MappingIndex = { line= 139; column= 30 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 134; column= 8 }
        let original: MappingIndex = { line= 140; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "sourceIdx")
        let generated: MappingIndex = { line= 134; column= 20 }
        let original: MappingIndex = { line= 140; column= 33 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 135; column= 10 }
        let original: MappingIndex = { line= 141; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappings")
        let generated: MappingIndex = { line= 135; column= 21 }
        let original: MappingIndex = { line= 141; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 135; column= 42 }
        let original: MappingIndex = { line= 141; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 135; column= 42 }
        let original: MappingIndex = { line= 141; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 136; column= 10 }
        let original: MappingIndex = { line= 142; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "enumerator")
        let generated: MappingIndex = { line= 136; column= 23 }
        let original: MappingIndex = { line= 142; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 136; column= 37 }
        let original: MappingIndex = { line= 142; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 136; column= 44 }
        let original: MappingIndex = { line= 142; column= 18 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 136; column= 56 }
        let original: MappingIndex = { line= 142; column= 18 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 136; column= 62 }
        let original: MappingIndex = { line= 142; column= 21 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 136; column= 62 }
        let original: MappingIndex = { line= 142; column= 21 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 136; column= 62 }
        let original: MappingIndex = { line= 142; column= 21 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappings")
        let generated: MappingIndex = { line= 136; column= 80 }
        let original: MappingIndex = { line= 142; column= 38 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 137; column= 0 }
        let original: MappingIndex = { line= 142; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 138; column= 0 }
        let original: MappingIndex = { line= 142; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 138; column= 15 }
        let original: MappingIndex = { line= 142; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 138; column= 15 }
        let original: MappingIndex = { line= 142; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "enumerator")
        let generated: MappingIndex = { line= 138; column= 15 }
        let original: MappingIndex = { line= 142; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "enumerator")
        let generated: MappingIndex = { line= 139; column= 18 }
        let original: MappingIndex = { line= 142; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "i")
        let generated: MappingIndex = { line= 139; column= 22 }
        let original: MappingIndex = { line= 142; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 139; column= 22 }
        let original: MappingIndex = { line= 142; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "enumerator")
        let generated: MappingIndex = { line= 139; column= 22 }
        let original: MappingIndex = { line= 142; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "enumerator")
        let generated: MappingIndex = { line= 140; column= 16 }
        let original: MappingIndex = { line= 144; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "shouldContinue")
        let generated: MappingIndex = { line= 140; column= 33 }
        let original: MappingIndex = { line= 144; column= 41 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 141; column= 18 }
        let original: MappingIndex = { line= 145; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapping")
        let generated: MappingIndex = { line= 141; column= 28 }
        let original: MappingIndex = { line= 145; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 141; column= 28 }
        let original: MappingIndex = { line= 145; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappings")
        let generated: MappingIndex = { line= 141; column= 37 }
        let original: MappingIndex = { line= 145; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "i")
        let generated: MappingIndex = { line= 142; column= 0 }
        let original: MappingIndex = { line= 146; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 142; column= 0 }
        let original: MappingIndex = { line= 146; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "next")
        let generated: MappingIndex = { line= 142; column= 19 }
        let original: MappingIndex = { line= 146; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 143; column= 0 }
        let original: MappingIndex = { line= 147; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 143; column= 0 }
        let original: MappingIndex = { line= 147; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 143; column= 16 }
        let original: MappingIndex = { line= 147; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 143; column= 16 }
        let original: MappingIndex = { line= 147; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 143; column= 16 }
        let original: MappingIndex = { line= 147; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 143; column= 16 }
        let original: MappingIndex = { line= 147; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapping")
        let generated: MappingIndex = { line= 143; column= 43 }
        let original: MappingIndex = { line= 147; column= 41 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousGeneratedLine")
        let generated: MappingIndex = { line= 144; column= 0 }
        let original: MappingIndex = { line= 148; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 144; column= 0 }
        let original: MappingIndex = { line= 148; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousGeneratedColumn")
        let generated: MappingIndex = { line= 144; column= 42 }
        let original: MappingIndex = { line= 148; column= 43 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 145; column= 0 }
        let original: MappingIndex = { line= 149; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 145; column= 23 }
        let original: MappingIndex = { line= 149; column= 22 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 145; column= 23 }
        let original: MappingIndex = { line= 149; column= 22 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 145; column= 23 }
        let original: MappingIndex = { line= 149; column= 22 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 145; column= 23 }
        let original: MappingIndex = { line= 149; column= 22 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapping")
        let generated: MappingIndex = { line= 145; column= 50 }
        let original: MappingIndex = { line= 149; column= 48 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousGeneratedLine")
        let generated: MappingIndex = { line= 146; column= 0 }
        let original: MappingIndex = { line= 150; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 146; column= 52 }
        let original: MappingIndex = { line= 150; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "next")
        let generated: MappingIndex = { line= 146; column= 58 }
        let original: MappingIndex = { line= 150; column= 32 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 147; column= 0 }
        let original: MappingIndex = { line= 151; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 147; column= 0 }
        let original: MappingIndex = { line= 151; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousGeneratedLine")
        let generated: MappingIndex = { line= 147; column= 46 }
        let original: MappingIndex = { line= 151; column= 45 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 147; column= 46 }
        let original: MappingIndex = { line= 151; column= 45 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousGeneratedLine")
        let generated: MappingIndex = { line= 147; column= 70 }
        let original: MappingIndex = { line= 151; column= 69 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 150; column= 17 }
        let original: MappingIndex = { line= 152; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 150; column= 17 }
        let original: MappingIndex = { line= 152; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 150; column= 21 }
        let original: MappingIndex = { line= 152; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 150; column= 21 }
        let original: MappingIndex = { line= 152; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "i")
        let generated: MappingIndex = { line= 150; column= 25 }
        let original: MappingIndex = { line= 152; column= 21 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 0 }
        let original: MappingIndex = { line= 154; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 0 }
        let original: MappingIndex = { line= 154; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 20 }
        let original: MappingIndex = { line= 154; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 22 }
        let original: MappingIndex = { line= 58; column= 52 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 151; column= 33 }
        let original: MappingIndex = { line= 153; column= 67 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapping")
        let generated: MappingIndex = { line= 151; column= 43 }
        let original: MappingIndex = { line= 58; column= 72 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 151; column= 54 }
        let original: MappingIndex = { line= 153; column= 75 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 54 }
        let original: MappingIndex = { line= 153; column= 75 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappings")
        let generated: MappingIndex = { line= 151; column= 63 }
        let original: MappingIndex = { line= 153; column= 85 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 63 }
        let original: MappingIndex = { line= 153; column= 85 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "i")
        let generated: MappingIndex = { line= 151; column= 67 }
        let original: MappingIndex = { line= 153; column= 87 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 72 }
        let original: MappingIndex = { line= 59; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 79 }
        let original: MappingIndex = { line= 59; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 79 }
        let original: MappingIndex = { line= 59; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 79 }
        let original: MappingIndex = { line= 59; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 79 }
        let original: MappingIndex = { line= 59; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 151; column= 105 }
        let original: MappingIndex = { line= 59; column= 52 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 105 }
        let original: MappingIndex = { line= 59; column= 52 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 105 }
        let original: MappingIndex = { line= 59; column= 52 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 151; column= 131 }
        let original: MappingIndex = { line= 60; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 132 }
        let original: MappingIndex = { line= 60; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 132 }
        let original: MappingIndex = { line= 60; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 140 }
        let original: MappingIndex = { line= 60; column= 18 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 145 }
        let original: MappingIndex = { line= 60; column= 25 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 153 }
        let original: MappingIndex = { line= 62; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 153 }
        let original: MappingIndex = { line= 62; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 161 }
        let original: MappingIndex = { line= 62; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 161 }
        let original: MappingIndex = { line= 62; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 161 }
        let original: MappingIndex = { line= 62; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 161 }
        let original: MappingIndex = { line= 62; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 151; column= 189 }
        let original: MappingIndex = { line= 62; column= 47 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 189 }
        let original: MappingIndex = { line= 62; column= 47 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 189 }
        let original: MappingIndex = { line= 62; column= 47 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 151; column= 222 }
        let original: MappingIndex = { line= 63; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 223 }
        let original: MappingIndex = { line= 63; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 223 }
        let original: MappingIndex = { line= 63; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 231 }
        let original: MappingIndex = { line= 63; column= 22 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 236 }
        let original: MappingIndex = { line= 63; column= 29 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 244 }
        let original: MappingIndex = { line= 65; column= 14 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 244 }
        let original: MappingIndex = { line= 65; column= 14 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 253 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 258 }
        let original: MappingIndex = { line= 65; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 258 }
        let original: MappingIndex = { line= 65; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 151; column= 276 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 281 }
        let original: MappingIndex = { line= 65; column= 44 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 281 }
        let original: MappingIndex = { line= 65; column= 44 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 151; column= 298 }
        let original: MappingIndex = { line= 48; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 299 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 299 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 300 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 300 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 316 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 316 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 332 }
        let original: MappingIndex = { line= 49; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 333 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 333 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 341 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 349 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 357 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 364 }
        let original: MappingIndex = { line= 49; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 369 }
        let original: MappingIndex = { line= 50; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 370 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 370 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 378 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 384 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 392 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 399 }
        let original: MappingIndex = { line= 50; column= 42 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 403 }
        let original: MappingIndex = { line= 51; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 411 }
        let original: MappingIndex = { line= 52; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 412 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 412 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 413 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 413 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 429 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 429 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 444 }
        let original: MappingIndex = { line= 53; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 449 }
        let original: MappingIndex = { line= 54; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 450 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 450 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 464 }
        let original: MappingIndex = { line= 54; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 469 }
        let original: MappingIndex = { line= 55; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 470 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 470 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 484 }
        let original: MappingIndex = { line= 55; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 489 }
        let original: MappingIndex = { line= 56; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 504 }
        let original: MappingIndex = { line= 66; column= 14 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 505 }
        let original: MappingIndex = { line= 66; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 505 }
        let original: MappingIndex = { line= 66; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 513 }
        let original: MappingIndex = { line= 66; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 518 }
        let original: MappingIndex = { line= 66; column= 31 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 526 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 151; column= 540 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 540 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 151; column= 559 }
        let original: MappingIndex = { line= 68; column= 41 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 559 }
        let original: MappingIndex = { line= 68; column= 41 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 151; column= 579 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 580 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 580 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 580 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 151; column= 606 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 607 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 607 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 607 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 151; column= 634 }
        let original: MappingIndex = { line= 69; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapAOriginal")
        let generated: MappingIndex = { line= 151; column= 649 }
        let original: MappingIndex = { line= 69; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 649 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 151; column= 665 }
        let original: MappingIndex = { line= 69; column= 42 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapBOriginal")
        let generated: MappingIndex = { line= 151; column= 680 }
        let original: MappingIndex = { line= 69; column= 37 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 680 }
        let original: MappingIndex = { line= 68; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "matchValue")
        let generated: MappingIndex = { line= 151; column= 696 }
        let original: MappingIndex = { line= 70; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 696 }
        let original: MappingIndex = { line= 70; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 704 }
        let original: MappingIndex = { line= 70; column= 27 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 704 }
        let original: MappingIndex = { line= 70; column= 27 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 704 }
        let original: MappingIndex = { line= 70; column= 27 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapAOriginal")
        let generated: MappingIndex = { line= 151; column= 724 }
        let original: MappingIndex = { line= 70; column= 47 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 724 }
        let original: MappingIndex = { line= 70; column= 47 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapBOriginal")
        let generated: MappingIndex = { line= 151; column= 749 }
        let original: MappingIndex = { line= 71; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 750 }
        let original: MappingIndex = { line= 71; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 750 }
        let original: MappingIndex = { line= 71; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 758 }
        let original: MappingIndex = { line= 71; column= 30 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 763 }
        let original: MappingIndex = { line= 71; column= 37 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 771 }
        let original: MappingIndex = { line= 73; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 771 }
        let original: MappingIndex = { line= 73; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 779 }
        let original: MappingIndex = { line= 73; column= 31 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 779 }
        let original: MappingIndex = { line= 73; column= 31 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 779 }
        let original: MappingIndex = { line= 73; column= 31 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapAOriginal")
        let generated: MappingIndex = { line= 151; column= 801 }
        let original: MappingIndex = { line= 73; column= 53 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 801 }
        let original: MappingIndex = { line= 73; column= 53 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapBOriginal")
        let generated: MappingIndex = { line= 151; column= 828 }
        let original: MappingIndex = { line= 74; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 829 }
        let original: MappingIndex = { line= 74; column= 27 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 829 }
        let original: MappingIndex = { line= 74; column= 27 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 837 }
        let original: MappingIndex = { line= 74; column= 34 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 842 }
        let original: MappingIndex = { line= 74; column= 41 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "cmp")
        let generated: MappingIndex = { line= 151; column= 850 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 857 }
        let original: MappingIndex = { line= 75; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 857 }
        let original: MappingIndex = { line= 75; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 151; column= 873 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 880 }
        let original: MappingIndex = { line= 75; column= 50 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 880 }
        let original: MappingIndex = { line= 75; column= 50 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 151; column= 895 }
        let original: MappingIndex = { line= 48; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 896 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 896 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 897 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 897 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 915 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 915 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 933 }
        let original: MappingIndex = { line= 49; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 934 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 934 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 942 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 952 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 960 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 969 }
        let original: MappingIndex = { line= 49; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 974 }
        let original: MappingIndex = { line= 50; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 975 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 975 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 983 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 991 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 999 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1008 }
        let original: MappingIndex = { line= 50; column= 42 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1012 }
        let original: MappingIndex = { line= 51; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1020 }
        let original: MappingIndex = { line= 52; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1021 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1021 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1022 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1022 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1040 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1040 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1057 }
        let original: MappingIndex = { line= 53; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1062 }
        let original: MappingIndex = { line= 54; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1063 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1063 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1079 }
        let original: MappingIndex = { line= 54; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1084 }
        let original: MappingIndex = { line= 55; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1085 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1085 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1101 }
        let original: MappingIndex = { line= 55; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1106 }
        let original: MappingIndex = { line= 56; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1125 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1132 }
        let original: MappingIndex = { line= 76; column= 30 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1132 }
        let original: MappingIndex = { line= 76; column= 30 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 151; column= 1148 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1155 }
        let original: MappingIndex = { line= 76; column= 44 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1155 }
        let original: MappingIndex = { line= 76; column= 44 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 151; column= 1170 }
        let original: MappingIndex = { line= 48; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1171 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1171 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1172 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1172 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1190 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1190 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1208 }
        let original: MappingIndex = { line= 49; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1209 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1209 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1217 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1227 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1235 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1244 }
        let original: MappingIndex = { line= 49; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1249 }
        let original: MappingIndex = { line= 50; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1250 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1250 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1258 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1266 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1274 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1283 }
        let original: MappingIndex = { line= 50; column= 42 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1287 }
        let original: MappingIndex = { line= 51; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1295 }
        let original: MappingIndex = { line= 52; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1296 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1296 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1297 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1297 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1315 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1315 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1332 }
        let original: MappingIndex = { line= 53; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1337 }
        let original: MappingIndex = { line= 54; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1338 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1338 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1354 }
        let original: MappingIndex = { line= 54; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1359 }
        let original: MappingIndex = { line= 55; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1360 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1360 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1376 }
        let original: MappingIndex = { line= 55; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1381 }
        let original: MappingIndex = { line= 56; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1395 }
        let original: MappingIndex = { line= 47; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1402 }
        let original: MappingIndex = { line= 76; column= 30 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1402 }
        let original: MappingIndex = { line= 76; column= 30 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingA")
        let generated: MappingIndex = { line= 151; column= 1418 }
        let original: MappingIndex = { line= 47; column= 43 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1425 }
        let original: MappingIndex = { line= 76; column= 44 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1425 }
        let original: MappingIndex = { line= 76; column= 44 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mappingB")
        let generated: MappingIndex = { line= 151; column= 1440 }
        let original: MappingIndex = { line= 48; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1441 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1441 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1442 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1442 }
        let original: MappingIndex = { line= 48; column= 11 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1460 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1460 }
        let original: MappingIndex = { line= 48; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1478 }
        let original: MappingIndex = { line= 49; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1479 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1479 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1487 }
        let original: MappingIndex = { line= 49; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1497 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1505 }
        let original: MappingIndex = { line= 49; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1514 }
        let original: MappingIndex = { line= 49; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1519 }
        let original: MappingIndex = { line= 50; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1520 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1520 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1528 }
        let original: MappingIndex = { line= 50; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1536 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1544 }
        let original: MappingIndex = { line= 50; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1553 }
        let original: MappingIndex = { line= 50; column= 42 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1557 }
        let original: MappingIndex = { line= 51; column= 17 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1565 }
        let original: MappingIndex = { line= 52; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1566 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1566 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1567 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1567 }
        let original: MappingIndex = { line= 52; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1585 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1585 }
        let original: MappingIndex = { line= 52; column= 26 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1602 }
        let original: MappingIndex = { line= 53; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1607 }
        let original: MappingIndex = { line= 54; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1608 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1608 }
        let original: MappingIndex = { line= 54; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s1")
        let generated: MappingIndex = { line= 151; column= 1624 }
        let original: MappingIndex = { line= 54; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1629 }
        let original: MappingIndex = { line= 55; column= 8 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1630 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1630 }
        let original: MappingIndex = { line= 55; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "s2")
        let generated: MappingIndex = { line= 151; column= 1646 }
        let original: MappingIndex = { line= 55; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1651 }
        let original: MappingIndex = { line= 56; column= 13 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 151; column= 1674 }
        let original: MappingIndex = { line= 154; column= 30 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 152; column= 0 }
        let original: MappingIndex = { line= 156; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 152; column= 0 }
        let original: MappingIndex = { line= 156; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "shouldContinue")
        let generated: MappingIndex = { line= 152; column= 37 }
        let original: MappingIndex = { line= 156; column= 38 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 155; column= 0 }
        let original: MappingIndex = { line= 158; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 155; column= 52 }
        let original: MappingIndex = { line= 158; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "next")
        let generated: MappingIndex = { line= 155; column= 58 }
        let original: MappingIndex = { line= 158; column= 32 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 158; column= 0 }
        let original: MappingIndex = { line= 159; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 158; column= 0 }
        let original: MappingIndex = { line= 159; column= 12 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 158; column= 16 }
        let original: MappingIndex = { line= 159; column= 15 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 158; column= 17 }
        let original: MappingIndex = { line= 159; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "shouldContinue")
        let generated: MappingIndex = { line= 159; column= 0 }
        let original: MappingIndex = { line= 160; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 159; column= 48 }
        let original: MappingIndex = { line= 160; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "next")
        let generated: MappingIndex = { line= 159; column= 54 }
        let original: MappingIndex = { line= 160; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 159; column= 81 }
        let original: MappingIndex = { line= 160; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 159; column= 81 }
        let original: MappingIndex = { line= 160; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 159; column= 81 }
        let original: MappingIndex = { line= 160; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 159; column= 81 }
        let original: MappingIndex = { line= 160; column= 46 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapping")
        let generated: MappingIndex = { line= 159; column= 108 }
        let original: MappingIndex = { line= 160; column= 73 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousGeneratedColumn")
        let generated: MappingIndex = { line= 160; column= 0 }
        let original: MappingIndex = { line= 161; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 160; column= 0 }
        let original: MappingIndex = { line= 161; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousGeneratedColumn")
        let generated: MappingIndex = { line= 160; column= 43 }
        let original: MappingIndex = { line= 161; column= 43 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 160; column= 43 }
        let original: MappingIndex = { line= 161; column= 43 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 160; column= 43 }
        let original: MappingIndex = { line= 161; column= 43 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapping")
        let generated: MappingIndex = { line= 161; column= 0 }
        let original: MappingIndex = { line= 162; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 161; column= 0 }
        let original: MappingIndex = { line= 162; column= 16 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 161; column= 20 }
        let original: MappingIndex = { line= 162; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 161; column= 20 }
        let original: MappingIndex = { line= 162; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 161; column= 20 }
        let original: MappingIndex = { line= 162; column= 19 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapping")
        let generated: MappingIndex = { line= 162; column= 0 }
        let original: MappingIndex = { line= 165; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 162; column= 29 }
        let original: MappingIndex = { line= 165; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "indexOfMappingSource")
        let generated: MappingIndex = { line= 163; column= 0 }
        let original: MappingIndex = { line= 166; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 163; column= 0 }
        let original: MappingIndex = { line= 166; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "sourceIdx")
        let generated: MappingIndex = { line= 163; column= 37 }
        let original: MappingIndex = { line= 166; column= 37 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "indexOfMappingSource")
        let generated: MappingIndex = { line= 164; column= 0 }
        let original: MappingIndex = { line= 167; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 164; column= 56 }
        let original: MappingIndex = { line= 167; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "next")
        let generated: MappingIndex = { line= 164; column= 62 }
        let original: MappingIndex = { line= 167; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 164; column= 89 }
        let original: MappingIndex = { line= 167; column= 54 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 164; column= 89 }
        let original: MappingIndex = { line= 167; column= 54 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "sourceIdx")
        let generated: MappingIndex = { line= 164; column= 101 }
        let original: MappingIndex = { line= 167; column= 66 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousSource")
        let generated: MappingIndex = { line= 165; column= 0 }
        let original: MappingIndex = { line= 168; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 165; column= 0 }
        let original: MappingIndex = { line= 168; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousSource")
        let generated: MappingIndex = { line= 165; column= 42 }
        let original: MappingIndex = { line= 168; column= 42 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "sourceIdx")
        let generated: MappingIndex = { line= 166; column= 31 }
        let original: MappingIndex = { line= 164; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 166; column= 37 }
        let original: MappingIndex = { line= 164; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "objectArg")
        let generated: MappingIndex = { line= 166; column= 49 }
        let original: MappingIndex = { line= 164; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 166; column= 49 }
        let original: MappingIndex = { line= 164; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "_sources")
        let generated: MappingIndex = { line= 166; column= 82 }
        let original: MappingIndex = { line= 164; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        let generated: MappingIndex = { line= 166; column= 91 }
        let original: MappingIndex = { line= 164; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "arg00")
        let generated: MappingIndex = { line= 166; column= 101 }
        let original: MappingIndex = { line= 164; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 166; column= 127 }
        let original: MappingIndex = { line= 164; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "objectArg")
        let generated: MappingIndex = { line= 166; column= 138 }
        let original: MappingIndex = { line= 164; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "arg00")
        let generated: MappingIndex = { line= 166; column= 147 }
        let original: MappingIndex = { line= 163; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 166; column= 147 }
        let original: MappingIndex = { line= 163; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapping")
        let generated: MappingIndex = { line= 167; column= 0 }
        let original: MappingIndex = { line= 172; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 167; column= 29 }
        let original: MappingIndex = { line= 172; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 168; column= 0 }
        let original: MappingIndex = { line= 173; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 168; column= 56 }
        let original: MappingIndex = { line= 173; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "next")
        let generated: MappingIndex = { line= 168; column= 62 }
        let original: MappingIndex = { line= 173; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 168; column= 89 }
        let original: MappingIndex = { line= 173; column= 54 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 168; column= 90 }
        let original: MappingIndex = { line= 173; column= 54 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 168; column= 90 }
        let original: MappingIndex = { line= 173; column= 54 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 168; column= 90 }
        let original: MappingIndex = { line= 173; column= 54 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 168; column= 106 }
        let original: MappingIndex = { line= 173; column= 70 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 168; column= 111 }
        let original: MappingIndex = { line= 173; column= 74 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousOriginalLine")
        let generated: MappingIndex = { line= 169; column= 0 }
        let original: MappingIndex = { line= 174; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 169; column= 0 }
        let original: MappingIndex = { line= 174; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousOriginalLine")
        let generated: MappingIndex = { line= 169; column= 49 }
        let original: MappingIndex = { line= 174; column= 48 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 169; column= 49 }
        let original: MappingIndex = { line= 174; column= 48 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 169; column= 49 }
        let original: MappingIndex = { line= 174; column= 48 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 169; column= 65 }
        let original: MappingIndex = { line= 174; column= 64 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 170; column= 0 }
        let original: MappingIndex = { line= 176; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 170; column= 56 }
        let original: MappingIndex = { line= 176; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "next")
        let generated: MappingIndex = { line= 170; column= 62 }
        let original: MappingIndex = { line= 176; column= 36 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 170; column= 89 }
        let original: MappingIndex = { line= 176; column= 54 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 170; column= 89 }
        let original: MappingIndex = { line= 176; column= 54 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 170; column= 89 }
        let original: MappingIndex = { line= 176; column= 54 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 170; column= 107 }
        let original: MappingIndex = { line= 176; column= 72 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousOriginalColumn")
        let generated: MappingIndex = { line= 171; column= 0 }
        let original: MappingIndex = { line= 177; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 171; column= 0 }
        let original: MappingIndex = { line= 177; column= 24 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousOriginalColumn")
        let generated: MappingIndex = { line= 171; column= 50 }
        let original: MappingIndex = { line= 177; column= 50 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 171; column= 50 }
        let original: MappingIndex = { line= 177; column= 50 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "original")
        let generated: MappingIndex = { line= 172; column= 31 }
        let original: MappingIndex = { line= 171; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 172; column= 31 }
        let original: MappingIndex = { line= 171; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapping")
        let generated: MappingIndex = { line= 173; column= 0 }
        let original: MappingIndex = { line= 180; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 173; column= 0 }
        let original: MappingIndex = { line= 180; column= 20 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 173; column= 24 }
        let original: MappingIndex = { line= 180; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 173; column= 24 }
        let original: MappingIndex = { line= 180; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 173; column= 24 }
        let original: MappingIndex = { line= 180; column= 23 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "mapping")
        let generated: MappingIndex = { line= 174; column= 0 }
        let original: MappingIndex = { line= 183; column= 27 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 174; column= 33 }
        let original: MappingIndex = { line= 183; column= 44 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "indexOfMappingName")
        let generated: MappingIndex = { line= 175; column= 0 }
        let original: MappingIndex = { line= 184; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 175; column= 0 }
        let original: MappingIndex = { line= 184; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "nameIdx")
        let generated: MappingIndex = { line= 175; column= 39 }
        let original: MappingIndex = { line= 184; column= 39 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "indexOfMappingName")
        let generated: MappingIndex = { line= 176; column= 0 }
        let original: MappingIndex = { line= 185; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 176; column= 60 }
        let original: MappingIndex = { line= 185; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "next")
        let generated: MappingIndex = { line= 176; column= 66 }
        let original: MappingIndex = { line= 185; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 176; column= 93 }
        let original: MappingIndex = { line= 185; column= 58 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 176; column= 93 }
        let original: MappingIndex = { line= 185; column= 58 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "nameIdx")
        let generated: MappingIndex = { line= 176; column= 103 }
        let original: MappingIndex = { line= 185; column= 68 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousName")
        let generated: MappingIndex = { line= 177; column= 0 }
        let original: MappingIndex = { line= 186; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 177; column= 0 }
        let original: MappingIndex = { line= 186; column= 28 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "previousName")
        let generated: MappingIndex = { line= 177; column= 44 }
        let original: MappingIndex = { line= 186; column= 44 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "nameIdx")
        let generated: MappingIndex = { line= 178; column= 35 }
        let original: MappingIndex = { line= 182; column= 27 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 178; column= 41 }
        let original: MappingIndex = { line= 182; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "arg00")
        let generated: MappingIndex = { line= 178; column= 53 }
        let original: MappingIndex = { line= 182; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 178; column= 79 }
        let original: MappingIndex = { line= 182; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=None)
        let generated: MappingIndex = { line= 178; column= 79 }
        let original: MappingIndex = { line= 182; column= 40 }
        map.AddMapping(generated, original, source="../../../src/SourceMapGenerator.fs",?name=Some "this")
        map.toJSON()

[<EntryPoint>]
let main argv =
    let arrays = BenchmarkRunner.Run<SourceMapGen>()
    0 // return an integer exit code