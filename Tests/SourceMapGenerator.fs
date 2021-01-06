module Tests.SourceMapGenerator

open System
open SourceMapSharp
open Xunit
open System.Text.Json
open SourceMapSharp.Util

module SourceMapGeneratorTests =
    let testMap: SourceGeneratorJSON = {
     version=3
     file="min.js"|>Some
     sources= seq {"one.js";"two.js"}
     names=seq {"bar";"baz";"n"}
     mappings="CAAC,IAAI,IAAM,SAAUA,GAClB,OAAOC,IAAID;CCDb,IAAI,IAAM,SAAUE,GAClB,OAAOA"
     sourcesContent=None
     sourceRoot="/the/root"|>Some
    }
    
    [<Fact>]
    let ``test some simple stuff`` () =
        let map = SourceMapGenerator(file="foo.js",sourceRoot=".").toJSON()        
        Assert.True map.file.IsSome
        Assert.True map.sourceRoot.IsSome
        let map = SourceMapGenerator().toJSON()
        Assert.True map.file.IsNone
        Assert.True map.sourceRoot.IsNone
    
    [<Fact>]
    let ``test  JSON serialization`` () =
        let map = SourceMapGenerator(file="foo.js",sourceRoot=".")
        let s = map.ToString()
        Assert.NotNull s
        
    [<Fact>]
    let ``test adding mappings (case 1)`` () =
        let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
        let generated: MappingIndex = {line=1;column=1}
        map.AddMapping(generated)
        
    [<Fact>]
    let ``test adding mappings (case 2)`` () =
        let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
        let generated: MappingIndex = {line=1;column=1}
        let original: MappingIndex = {line=1;column=1}
        map.AddMapping(generated,original,"bar.js")
        
    [<Fact>]
    let ``test adding mappings (case 3)`` () =
        let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
        let generated: MappingIndex = {line=1;column=1}
        let original: MappingIndex = {line=1;column=1}
        map.AddMapping(generated,original,"bar.js","someToken")
    
    [<Fact>]
    let ``test adding mappings (invalid)`` () =
        let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
        let generated: MappingIndex = {line=1;column=1}
        let original: MappingIndex = {line=1;column=1}
        Assert.Throws(Exception().GetType(),Action(fun _ -> map.AddMapping(generated,original)))
    
    [<Fact>]
    let ``test adding mappings with skipValidation`` () =
        let map = SourceMapGenerator(skipValidation=true, file="generated-foo.js",sourceRoot=".")
        let generated: MappingIndex = {line=1;column=1}
        let original: MappingIndex = {line=1;column=1}
        map.AddMapping(generated,original)
        
    [<Fact>]
    let ``test that the correct mappings are being generated`` () =
        let map = SourceMapGenerator(file="min.js",sourceRoot="/the/root")
        let generated: MappingIndex = { line= 1; column= 1 }
        let original: MappingIndex = { line= 1; column= 1 }
        map.AddMapping(generated, original, "one.js")

        let generated: MappingIndex = { line= 1; column= 5 }
        let original: MappingIndex = { line= 1; column= 5 }
        map.AddMapping(generated, original, "one.js")

        let generated: MappingIndex = { line= 1; column= 9 }
        let original: MappingIndex = { line= 1; column= 11 }
        map.AddMapping(generated, original, "one.js")

        let generated: MappingIndex = { line= 1; column= 18 }
        let original: MappingIndex = { line= 1; column= 21 }
        map.AddMapping(generated, original, "one.js", "bar")

        let generated: MappingIndex = { line= 1; column= 21 }
        let original: MappingIndex = { line= 2; column= 3 }
        map.AddMapping(generated, original, "one.js")

        let generated: MappingIndex = { line= 1; column= 28 }
        let original: MappingIndex = { line= 2; column= 10 }
        map.AddMapping(generated, original, "one.js", "baz")

        let generated: MappingIndex = { line= 1; column= 32 }
        let original: MappingIndex = { line= 2; column= 14 }
        map.AddMapping(generated, original, "one.js", "bar")

        let generated: MappingIndex = { line= 2; column= 1 }
        let original: MappingIndex = { line= 1; column= 1 }
        map.AddMapping(generated, original, "two.js")

        let generated: MappingIndex = { line= 2; column= 5 }
        let original: MappingIndex = { line= 1; column= 5 }
        map.AddMapping(generated, original, "two.js")

        let generated: MappingIndex = { line= 2; column= 9 }
        let original: MappingIndex = { line= 1; column= 11 }
        map.AddMapping(generated, original, "two.js")

        let generated: MappingIndex = { line= 2; column= 18 }
        let original: MappingIndex = { line= 1; column= 21 }
        map.AddMapping(generated, original, "two.js", "n")

        let generated: MappingIndex = { line= 2; column= 21 }
        let original: MappingIndex = { line= 2; column= 3 }
        map.AddMapping(generated, original, "two.js")

        let generated: MappingIndex = { line= 2; column= 28 }
        let original: MappingIndex = { line= 2; column= 10 }
        map.AddMapping(generated, original, "two.js", "n")
        
        Assert.Equal (map.ToString(),JsonSerializer.Serialize(testMap))
        
    [<Fact>]
    let ``test that adding a mapping with an empty string name does not break generation`` () =
        let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
        let generated: MappingIndex = {line=1;column=1}
        let original: MappingIndex = {line=1;column=1}
        map.AddMapping(generated,original, source="bar.js",name="")
        map.ToString()
    
    [<Fact>]
    let ``test that source content can be set`` () =
        let map = SourceMapGenerator(file="min.js",sourceRoot="/the/root")
        let generated: MappingIndex = { line= 1; column= 1 }
        let original: MappingIndex = { line= 1; column= 1 }
        map.AddMapping(generated, original, "one.js")
        let generated: MappingIndex = { line= 2; column= 1 }
        let original: MappingIndex = { line= 1; column= 1 }
        map.AddMapping(generated, original, "two.js")
        map.SetSourceContent("one.js",Some "one file content")
        let j = map.toJSON()
        let _src = j.sources |> Array.ofSeq
        let _srcC = j.sourcesContent.Value |> Array.ofSeq
        Assert.True (_src.[0] = "one.js")
        Assert.True (_src.[1] = "two.js")
        Assert.True(_srcC.[0].Value = "one file content")
        Assert.True(_srcC.[1].IsNone)
    [<Fact>]
    let ``test sorting with duplicate generated mappings`` () =
        let map = SourceMapGenerator(file="test.js")
        let generated1: MappingIndex = { line= 3; column= 0 }
        let original1: MappingIndex = { line= 2; column= 0 }
        map.AddMapping(generated1, original1, "a.js")

        let generated2: MappingIndex = { line= 2; column= 0 }
        map.AddMapping(generated2)

        let generated3: MappingIndex = { line= 2; column= 0 }
        map.AddMapping(generated3)

        let generated4: MappingIndex = { line= 1; column= 0 }
        let original4: MappingIndex = { line= 1; column= 0 }
        map.AddMapping(generated4, original4, "a.js")
        let expected = {
             version=3
             file="test.js"|>Some
             sources= seq {"a.js"}
             names= Seq.empty
             mappings="AAAA;A;AACA"
             sourcesContent=None
             sourceRoot=None
            }
        Assert.Equal (map.ToString(),JsonSerializer.Serialize(expected))
    [<Fact>]
    let ``test ignore duplicate mappings.`` () =
        let map1 = SourceMapGenerator(file="min.js",sourceRoot="/the/root")
        let map2 = SourceMapGenerator(file="min.js",sourceRoot="/the/root")
        
        let nullMapping1: MappingIndex = { line= 1; column= 0 }
        let nullMapping2: MappingIndex = { line= 2; column= 2 }

        map1.AddMapping(nullMapping1)
        map1.AddMapping(nullMapping1)
        
        map2.AddMapping(nullMapping1)
        
        Assert.Equal (map1.ToString(),map2.ToString())
        
        map1.AddMapping(nullMapping2)
        map1.AddMapping(nullMapping1)

        map2.AddMapping(nullMapping2)
        
        Assert.Equal (map1.ToString(),map2.ToString())
        
        let srcMapping1Generated: MappingIndex = { line= 1; column= 0 }
        let srcMapping1Original: MappingIndex = { line= 11; column= 0 }
        let srcMapping1Source = "srcMapping1.js"
        
        let srcMapping2Generated: MappingIndex = { line= 2; column= 2 }
        let srcMapping2Original: MappingIndex = { line= 11; column= 0 }
        let srcMapping2Source = "srcMapping2.js"
        
        let map1 = SourceMapGenerator(file="min.js",sourceRoot="/the/root")
        let map2 = SourceMapGenerator(file="min.js",sourceRoot="/the/root")
        
        map1.AddMapping(srcMapping1Generated,srcMapping1Original,srcMapping1Source)
        map1.AddMapping(srcMapping1Generated,srcMapping1Original,srcMapping1Source)
        
        map2.AddMapping(srcMapping1Generated,srcMapping1Original,srcMapping1Source)
        
        Assert.Equal (map1.ToString(),map2.ToString())
        
        map1.AddMapping(srcMapping2Generated,srcMapping2Original,srcMapping2Source)
        map1.AddMapping(srcMapping1Generated,srcMapping1Original,srcMapping1Source)
        
        map2.AddMapping(srcMapping2Generated,srcMapping2Original,srcMapping2Source)
        
        Assert.Equal (map1.ToString(),map2.ToString())
        
        
        let fullMapping1Generated: MappingIndex = { line= 1; column= 0 }
        let fullMapping1Original: MappingIndex = { line= 11; column= 0 }
        let fullMapping1Source = "fullMapping1.js"
        let fullMapping1Name = "fullMapping1"
        
        let fullMapping2Generated: MappingIndex = { line= 2; column= 2 }
        let fullMapping2Original: MappingIndex = { line= 11; column= 0 }
        let fullMapping2Source = "fullMapping2.js"
        let fullMapping2Name = "fullMapping2"
        
        let map1 = SourceMapGenerator(file="min.js",sourceRoot="/the/root")
        let map2 = SourceMapGenerator(file="min.js",sourceRoot="/the/root")
        
        map1.AddMapping(fullMapping1Generated,fullMapping1Original,fullMapping1Source,fullMapping1Name)
        map1.AddMapping(fullMapping1Generated,fullMapping1Original,fullMapping1Source,fullMapping1Name)
        
        map2.AddMapping(fullMapping1Generated,fullMapping1Original,fullMapping1Source,fullMapping1Name)
        
        Assert.Equal (map1.ToString(),map2.ToString())
        
        map1.AddMapping(fullMapping2Generated,fullMapping2Original,fullMapping2Source,fullMapping2Name)
        map1.AddMapping(fullMapping1Generated,fullMapping1Original,fullMapping1Source,fullMapping1Name)
        
        map2.AddMapping(fullMapping2Generated,fullMapping2Original,fullMapping2Source,fullMapping2Name)
        Assert.Equal (map1.ToString(),map2.ToString())
        
        
    [<Fact>]
    let ``test github issue #72, check for duplicate names or sources`` () =
        let map = SourceMapGenerator(file="test.js")
        let generated1: MappingIndex = { line= 1; column= 1 }
        let original1: MappingIndex = { line= 2; column= 2 }
        map.AddMapping(generated1, original1, "a.js", "foo")

        let generated2: MappingIndex = { line= 3; column= 3 }
        let original2: MappingIndex = { line= 4; column= 4 }
        map.AddMapping(generated2, original2, "a.js", "foo")

        let expected = {
             version=3
             file="test.js"|>Some
             sources= seq {"a.js"}
             names= seq {"foo"}
             mappings="CACEA;;GAEEA"
             sourcesContent=None
             sourceRoot=None
            }
        Assert.Equal (map.ToString(),JsonSerializer.Serialize(expected))
        
    [<Fact>]
    let ``test setting sourcesContent to null when already null`` () =
        let map = SourceMapGenerator(file="foo.js")
        map.SetSourceContent("bar.js",None)
    
    [<Fact>]
    let ``test numeric names #231`` () =
        let map = SourceMapGenerator()
        let generated: MappingIndex = {line=1;column=10}
        let original: MappingIndex = {line=1;column=10}
        // type safe names! can't pass number
        map.AddMapping(generated,original, source="a.js",name="8")
        
        let m = map.toJSON()
        Assert.Equal(m.names |> Seq.length,1)
        Assert.Equal(m.names |> Seq.head,"8")