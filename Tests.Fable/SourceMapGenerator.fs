module Tests.SourceMapGenerator
open Fable.Mocha
open Fable.SimpleJson
open SourceMapSharp
open SourceMapSharp.Util
let testMap: SourceGeneratorJSON = {
     version=3
     file="min.js"|>Some
     sources= seq {"one.js";"two.js"}
     names=seq {"bar";"baz";"n"}
     mappings="CAAC,IAAI,IAAM,SAAUA,GAClB,OAAOC,IAAID;CCDb,IAAI,IAAM,SAAUE,GAClB,OAAOA"
     sourcesContent=None
     sourceRoot="/the/root"|>Some
    }
let sourceMapGeneratorTests =
    
    testList "SourceGenerator" [
    
        testCase "test some simple stuff" <| fun () ->
            let map = SourceMapGenerator(file="foo.js",sourceRoot=".").toJSON()
            Expect.isTrue map.file.IsSome "map file is some"
            Expect.isTrue map.sourceRoot.IsSome "sourceRoot is some"
            let map = SourceMapGenerator().toJSON()
            Expect.isTrue map.file.IsNone "map file is none"
            Expect.isTrue map.sourceRoot.IsNone "map sourceroot is none"
        
        
        testCase "test JSON serialization 1" <| fun () ->
            let map = SourceMapGenerator(file="foo.js",sourceRoot=".")
            let s = map.ToString()
            Expect.isNotNull s "s is not null"

        
        testCase "test JSON serialization 2" <| fun () ->
            let s = Json.serialize testMap
            Expect.equal """{"version": 3, "sources": ["one.js", "two.js"], "names": ["bar", "baz", "n"], "mappings": "CAAC,IAAI,IAAM,SAAUA,GAClB,OAAOC,IAAID;CCDb,IAAI,IAAM,SAAUE,GAClB,OAAOA", "file": "min.js", "sourcesContent": null, "sourceRoot": "/the/root"}""" s "json ser test 2"
            
        
        testCase "test adding mappings (case 1)" <| fun () ->
            let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
            let generated: MappingIndex = {line=1;column=1}
            Expect.pass (map.AddMapping(generated))
            
        
        testCase "test adding mappings (case 2)" <| fun () ->
            let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
            let generated: MappingIndex = {line=1;column=1}
            let original: MappingIndex = {line=1;column=1}
            Expect.pass (map.AddMapping(generated,original,"bar.js"))
            
        
        testCase "test adding mappings (case 3)" <| fun () ->
            let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
            let generated: MappingIndex = {line=1;column=1}
            let original: MappingIndex = {line=1;column=1}
            Expect.pass (map.AddMapping(generated,original,"bar.js","someToken"))
        
        
        testCase "test adding mappings (invalid)" <| fun () ->
            let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
            let generated: MappingIndex = {line=1;column=1}
            let original: MappingIndex = {line=1;column=1}
            Expect.throws (fun _ -> map.AddMapping(generated,original)) "invalid mappings"
        
        
        testCase "test adding mappings with skipValidation" <| fun () ->
            let map = SourceMapGenerator(skipValidation=true, file="generated-foo.js",sourceRoot=".")
            let generated: MappingIndex = {line=1;column=1}
            let original: MappingIndex = {line=1;column=1}
            Expect.pass (map.AddMapping(generated,original))
            
        
        testCase "test that the correct mappings are being generated" <| fun () ->
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
            
            Tests.Util.TestUtils.assertEqualSourceMaps(map,testMap)
            
            
        
        testCase "test that adding a mapping with an empty string name does not break generation" <| fun () ->
            let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
            let generated: MappingIndex = {line=1;column=1}
            let original: MappingIndex = {line=1;column=1}
            Expect.pass (map.AddMapping(generated,original, source="bar.js",name=""))
            Expect.pass (map.toJSON() |> ignore)
        
        
        testCase "test that source content can be set" <| fun () ->
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
            Expect.isTrue (_src.[0] = "one.js") "src[0] is one"
            Expect.isTrue (_src.[1] = "two.js") "src[1] is two"
            Expect.isTrue (_srcC.[0].Value = "one file content") "src[0] is some"
            Expect.isTrue (_srcC.[1].IsNone) "src[1] is none"
        
        testCase "test sorting with duplicate generated mappings" <| fun () ->
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
            Tests.Util.TestUtils.assertEqualSourceMaps(map,expected)
        
        testCase "test ignore duplicate mappings." <| fun () ->
            let map1 = SourceMapGenerator(file="min.js",sourceRoot="/the/root")
            let map2 = SourceMapGenerator(file="min.js",sourceRoot="/the/root")
            
            let nullMapping1: MappingIndex = { line= 1; column= 0 }
            let nullMapping2: MappingIndex = { line= 2; column= 2 }

            map1.AddMapping(nullMapping1)
            map1.AddMapping(nullMapping1)
            
            map2.AddMapping(nullMapping1)
            
            Tests.Util.TestUtils.assertEqualSourceMaps(map1,map2)
                    
            map1.AddMapping(nullMapping2)
            map1.AddMapping(nullMapping1)

            map2.AddMapping(nullMapping2)
            
            Tests.Util.TestUtils.assertEqualSourceMaps(map1,map2)
            
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
            
            Tests.Util.TestUtils.assertEqualSourceMaps(map1,map2)
            
            map1.AddMapping(srcMapping2Generated,srcMapping2Original,srcMapping2Source)
            map1.AddMapping(srcMapping1Generated,srcMapping1Original,srcMapping1Source)
            
            map2.AddMapping(srcMapping2Generated,srcMapping2Original,srcMapping2Source)
            
            Tests.Util.TestUtils.assertEqualSourceMaps(map1,map2)
            
            
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
            
            Tests.Util.TestUtils.assertEqualSourceMaps(map1,map2)
            
            map1.AddMapping(fullMapping2Generated,fullMapping2Original,fullMapping2Source,fullMapping2Name)
            map1.AddMapping(fullMapping1Generated,fullMapping1Original,fullMapping1Source,fullMapping1Name)
            
            map2.AddMapping(fullMapping2Generated,fullMapping2Original,fullMapping2Source,fullMapping2Name)
            Tests.Util.TestUtils.assertEqualSourceMaps(map1,map2)
            
            
        
        testCase "test github issue #72, check for duplicate names or sources" <| fun () ->
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
            Tests.Util.TestUtils.assertEqualSourceMaps(map,expected)
            
        
        testCase "test setting sourcesContent to null when already null" <| fun () ->
            let map = SourceMapGenerator(file="foo.js")
            Expect.pass (map.SetSourceContent("bar.js",None))
        
        
        testCase "test numeric names #231" <| fun () ->
            let map = SourceMapGenerator()
            let generated: MappingIndex = {line=1;column=10}
            let original: MappingIndex = {line=1;column=10}
            // type safe names! can't pass number
            map.AddMapping(generated,original, source="a.js",name="8")
            
            let m = map.toJSON()
            Expect.equal (m.names |> Seq.length) 1 "m is of length 1"
            Expect.equal (m.names |> Seq.head) "8" "m head is 8"
    ]