module Tests_Fable.SourceNode
open Fable.Mocha
open Fable.SimpleJson
open SourceMapSharp
open SourceMapSharp.Util
open Tests_Fable.Util


let sourceNodeTests =
    
    testList "SourceNode" [
        
         testCase "test .add()" <| fun () ->
            let node = SourceNode()
            node.Add(SourceChunk.ChunkS "function noop() {}") |> ignore
            node.Add(SourceChunk.ChunkArrSN [|SourceNode()|]) |> ignore
            node.Add(SourceChunk.ChunkArrSN [|SourceNode(_chunks=[|SourceChunk.ChunkS "return 10;"|])|]) |> ignore
            node.Add(SourceChunk.ChunkArrS [|"function foo() {";"}"|]) |> ignore
        
         testCase "test .prepend()" <| fun () ->
            let node = SourceNode()
            let s = "function noop() {}"
            node.Prepend(SourceChunk.ChunkS s) |> ignore
            Expect.equal node.children.[0] (SourceNodeChild.S s) "node children[0] equals source node child s"
            Expect.equal node.children.Count 1 "node children count is 1"
            
            node.Prepend(SourceChunk.ChunkArrSN [|SourceNode()|]) |> ignore
            Expect.isTrue (match node.children.[0] with | SN _ -> true | S _ -> false) "node children[0] is SN"
            Expect.isTrue (match node.children.[1] with | SN _ -> false | S _ -> true) "node children[1] is S"
            Expect.isTrue (match node.children.[1] with | SN _ -> false | S ss -> s = ss) "node children [1] is ss"
            Expect.isTrue (node.children.Count = 2) "node children count is 2"
            
            node.Prepend(
                [|SourceChunk.ChunkS "function foo() {"
                  SourceChunk.ChunkArrSN [|SourceNode(_chunks=[|SourceChunk.ChunkS "return 10;"|])|]
                  SourceChunk.ChunkS "}"
                |]) |> ignore

            Expect.equal (node.children.[0].ToString()) "function foo() {" "node children 0 is foo"
            Expect.equal (node.children.[1].ToString()) "return 10;" "node children 1 is return 10"
            Expect.equal (node.children.[2].ToString()) "}" "node children 2 is }"
            Expect.equal (node.children.[3].ToString()) "" "node children 2 is blank"
            Expect.equal (node.children.[4].ToString()) "function noop() {}"  "node children 4 is noop fn"
            Expect.isTrue (node.children.Count = 5) "node children count is 5"
            
        
         testCase "test .toString()" <| fun () ->
            let node = SourceNode(_chunks=[|
                SourceChunk.ChunkS "function foo() {"
                SourceChunk.ChunkArrSN [|SourceNode(_chunks=[|SourceChunk.ChunkS "return 10;"|])|]
                SourceChunk.ChunkS "}"
            |])
            Expect.equal (node.ToString()) "function foo() {return 10;}" "node is function foo return 10"
        
        
         testCase "test .join()" <| fun () ->
            let node = SourceNode(_chunks=[|
                SourceChunk.ChunkS "a"
                SourceChunk.ChunkS "b"
                SourceChunk.ChunkS "c"
                SourceChunk.ChunkS "d"
            |])
            Expect.equal ("a, b, c, d") (node.Join(", ").ToString()) "a b c d is equal to node chunks"
        
        
         testCase "test .walk()" <| fun () ->
            let node = SourceNode(_chunks=[|
                SourceChunk.ChunkS "(function () {\n"
                SourceChunk.ChunkS "  "
                SourceChunk.ChunkArrSN [|
                    SourceNode(_line=1,_column=0,_source="a.js",
                               _chunks=[|SourceChunk.ChunkS "someCall()"|])
                |]
                SourceChunk.ChunkS ";\n"
                SourceChunk.ChunkS "  "
                SourceChunk.ChunkArrSN [|
                    SourceNode(_line=2,_column=0,_source="b.js",
                               _chunks=[|SourceChunk.ChunkS "if (foo) bar()"|])
                |]
                SourceChunk.ChunkS ";\n"
                SourceChunk.ChunkS "}());"
            |])
            
            let expected = [|
                {| str= "(function () {\n"; source= None; line= None; column= None |}
                {| str= "  "; source= None; line= None; column= None |}
                {| str= "someCall()"; source= Some "a.js"; line= Some 1; column= Some 0 |}
                {| str= ";\n"; source= None; line= None; column= None |}
                {| str= "  "; source= None; line= None; column= None |}
                {| str= "if (foo) bar()"; source= Some "b.js"; line= Some 2; column= Some 0 |}
                {| str= ";\n"; source= None; line= None; column= None |}
                {| str= "}());"; source= None; line= None; column= None |}
              |]


            let mutable i = 0
            node.Walk(fun chunk loc ->
                Expect.equal expected.[i].str chunk $"chunk str is equal for {i}"
                Expect.equal expected.[i].source loc.Source $"chunk source is equal for {i}"
                Expect.equal expected.[i].line loc.line $"chunk line is equal for {i}"
                Expect.equal expected.[i].column loc.column $"chunk column is equal for {i}"
                i <- i+1
            )
        
        
         testCase "test .replaceRight()" <| fun () ->
            // Not nested
            let node = SourceNode(_chunks=[|
                SourceChunk.ChunkS "hello world"
            |])
            node.ReplaceRight("world","universe") |> ignore
            Expect.equal "hello universe" (node.ToString()) "node replaceRight works"
            
            // Nested
            let node = SourceNode(_chunks=[|
                SourceChunk.ChunkArrSN [|
                    SourceNode(_chunks=[|
                        SourceChunk.ChunkS "hey sexy mama, "
                    |])
                    SourceNode(_chunks=[|
                        SourceChunk.ChunkS "want to kill all humans?"
                    |])
                |]
            |])
            node.ReplaceRight("kill all humans", "watch Futurama") |> ignore
            Expect.equal "hey sexy mama, want to watch Futurama?" (node.ToString()) "replace right works for nested"
            
            
        
         testCase "test .toStringWithSourceMap()" <| fun () ->
            ["\n";"\r\n"] |> List.iter (fun nl ->
                let c1 = SourceChunk.ChunkS ("(function () {" + nl)
                let c2 = SourceChunk.ChunkS ("  ")
                let c3 = SourceNode(_line=1,_column=0,_source="a.js", _name="originalCall",
                                    _chunks=[|SourceChunk.ChunkS "someCall"|])
                let c4 = SourceNode(_line=1,_column=8,_source="a.js",
                                    _chunks=[|SourceChunk.ChunkS "()"|])
                let c5 = SourceChunk.ChunkS (";" + nl)
                let c6 = SourceChunk.ChunkS ("  ")
                let c7 = SourceNode(_line=2,_column=0,_source="b.js",
                                    _chunks=[|SourceChunk.ChunkS "if (foo) bar()"|])
                let c8 = SourceChunk.ChunkS (";" + nl)
                let c9 = SourceChunk.ChunkS ("}());")
                let node = SourceNode(_chunks=[|
                    c1
                    c2
                    SourceChunk.ChunkArrSN ([|c3;c4|])
                    c5
                    c6
                    SourceChunk.ChunkArrSN ([|c7|])
                    c8
                    c9
                |])
                let (code, resultMap) = node.ToStringWithSourceMap(file="foo.js")
                let expected = String.concat nl [
                  "(function () {"
                  "  someCall();"
                  "  if (foo) bar();"
                  "}());"
                  ]
                Expect.equal expected code "toStringWithSourceMap works"
                //todo: sourcemapconsumer part
            )
        
         testCase "test .toStringWithSourceMap() with consecutive newlines" <| fun () ->
            ["\n";"\r\n"] |> List.iter (fun nl ->
                let c1 = SourceChunk.ChunkS ("/***/" + nl + nl)
                let c2 = SourceNode(_line=1,_column=0,_source="a.js",
                                    _chunks=[|SourceChunk.ChunkS ("'use strict';" + nl)|])
                let c3 = SourceNode(_line=2,_column=0,_source="a.js",
                                    _chunks=[|SourceChunk.ChunkS "a();"|])
                let input = SourceNode(_chunks=[|
                    c1
                    SourceChunk.ChunkArrSN ([|c2;c3|])
                |])
                let (code, inputMap) = input.ToStringWithSourceMap(file="foo.js")
                let expected = String.concat nl [
                  "/***/"
                  ""
                  "'use strict';"
                  "a();"
                  ]
                Expect.equal expected code "ToStringWithSourceMap works for many newlines"
                
                let map = SourceMapGenerator(file="foo.js")
                let generated: MappingIndex = { line= 3; column= 0 }
                let original: MappingIndex = { line= 1; column= 0 }
                map.AddMapping(generated, original, "a.js")
                let generated: MappingIndex = { line= 4; column= 0 }
                let original: MappingIndex = { line= 2; column= 0 }
                map.AddMapping(generated, original, "a.js")
                TestUtils.assertEqualSourceMaps(map,inputMap)
            )
        
        
         testCase "test .toStringWithSourceMap() merging duplicate mappings" <| fun () ->
            ["\n";"\r\n"] |> List.iter (fun nl ->
                let c1 = SourceNode(_line=1,_column=0,_source="a.js", _chunks=[|SourceChunk.ChunkS ("(function")|])
                let c2 = SourceNode(_line=1,_column=0,_source="a.js",_chunks=[|SourceChunk.ChunkS ("() {" + nl)|])
                let c3 = SourceChunk.ChunkS ("  ")
                let c4 = SourceNode(_line=1,_column=0,_source="a.js",_chunks=[|SourceChunk.ChunkS ("var Test = ")|])
                let c5 = SourceNode(_line=1,_column=0,_source="b.js",_chunks=[|SourceChunk.ChunkS ("{};" + nl)|])
                let c6 = SourceNode(_line=2,_column=0,_source="b.js",_chunks=[|SourceChunk.ChunkS ("Test")|])
                let c7 = SourceNode(_line=2,_column=0,_source="b.js",_name="A",_chunks=[|SourceChunk.ChunkS (".A")|])
                let c8 = SourceNode(_line=2,_column=20,_source="b.js",_name="A",_chunks=[|SourceChunk.ChunkS (" = { value: ")|])
                let c9 = SourceChunk.ChunkS ("1234")
                let c10 = SourceNode(_line=2,_column=40,_source="b.js",_name="A",_chunks=[|SourceChunk.ChunkS (" };" + nl)|])
                let c11 = SourceChunk.ChunkS ("}());" + nl)
                let c12 = SourceChunk.ChunkS ("/* Generated Source */")
                let input = SourceNode(_chunks=[|
                    SourceChunk.ChunkArrSN ([|c1;c2|])
                    c3
                    SourceChunk.ChunkArrSN ([|c4;c5;c6;c7;c8|])
                    c9
                    SourceChunk.ChunkArrSN ([|c10|])
                    c11
                    c12
                |])
                let (code, inputMap) = input.ToStringWithSourceMap(file="foo.js")
                let expected = String.concat nl [
                  "(function() {"
                  "  var Test = {};"
                  "Test.A = { value: 1234 };"
                  "}());"
                  "/* Generated Source */" ]
                Expect.equal expected code "ToStringWithSourceMap with duplicate maps works"
                
                let map = SourceMapGenerator(file="foo.js")
                let generated: MappingIndex = { line= 1; column= 0 }
                let original: MappingIndex = { line= 1; column= 0 }
                map.AddMapping(generated, original, "a.js")
                
                // Here is no need for a empty mapping,
                // because mappings ends at eol
                let generated: MappingIndex = { line= 2; column= 2 }
                let original: MappingIndex = { line= 1; column= 0 }
                map.AddMapping(generated, original, "a.js")
                
                let generated: MappingIndex = { line= 2; column= 13 }
                let original: MappingIndex = { line= 1; column= 0 }
                map.AddMapping(generated, original, "b.js")
                
                
                let generated: MappingIndex = { line= 3; column= 0 }
                let original: MappingIndex = { line= 2; column= 0 }
                map.AddMapping(generated, original, "b.js")
                
                let generated: MappingIndex = { line= 3; column= 4 }
                let original: MappingIndex = { line= 2; column= 0 }
                map.AddMapping(generated, original, "b.js", name="A")
                
                let generated: MappingIndex = { line= 3; column= 6 }
                let original: MappingIndex = { line= 2; column= 20 }
                map.AddMapping(generated, original, "b.js", name="A")
                
                // This empty mapping is required,
                // because there is a hole in the middle of the line
                let generated: MappingIndex = { line= 3; column= 18 }
                map.AddMapping(generated)
                
                let generated: MappingIndex = { line= 3; column= 22 }
                let original: MappingIndex = { line= 2; column= 40 }
                map.AddMapping(generated, original, "b.js", name="A")
                // Here is no need for a empty mapping,
                // because mappings ends at eol
                TestUtils.assertEqualSourceMaps(map,inputMap)
           )
        
        
        
         testCase "test .toStringWithSourceMap() multi-line SourceNodes" <| fun () ->
            ["\n";"\r\n"] |> List.iter (fun nl ->
                let c1 = SourceNode(_line=1,_column=0,_source="a.js",
                                    _chunks=[|SourceChunk.ChunkS ("(function() {" + nl + "var nextLine = 1;" + nl + "anotherLine();" + nl)|])
                let c2 = SourceNode(_line=2,_column=2,_source="b.js",_chunks=[|SourceChunk.ChunkS ("Test.call(this, 123);" + nl)|])
                let c3 = SourceNode(_line=2,_column=2,_source="b.js",_chunks=[|SourceChunk.ChunkS ("this['stuff'] = 'v';" + nl)|])
                let c4 = SourceNode(_line=2,_column=2,_source="b.js",_chunks=[|SourceChunk.ChunkS ("anotherLine();" + nl)|])
                let c5 = SourceChunk.ChunkS ("/*" + nl + "Generated" + nl + "Source" + nl + "*/" + nl)
                let c6 = SourceNode(_line=3,_column=4,_source="c.js",_chunks=[|SourceChunk.ChunkS ("anotherLine();" + nl)|])
                let c7 = SourceChunk.ChunkS ("/*" + nl + "Generated" + nl + "Source" + nl + "*/")
                
                let input = SourceNode(_chunks=[|
                    SourceChunk.ChunkArrSN ([|c1;c2;c3;c4|])
                    c5
                    SourceChunk.ChunkArrSN ([|c6|])
                    c7
                |])
                let (code, inputMap) = input.ToStringWithSourceMap(file="foo.js")
                let expected = String.concat nl [
                  "(function() {"
                  "var nextLine = 1;"
                  "anotherLine();"
                  "Test.call(this, 123);"
                  "this['stuff'] = 'v';"
                  "anotherLine();"
                  "/*"
                  "Generated"
                  "Source"
                  "*/"
                  "anotherLine();"
                  "/*"
                  "Generated"
                  "Source"
                  "*/" ]
                Expect.equal expected code "ToStringWithSourceMap works with multiline sourcemaps"
                
                let map = SourceMapGenerator(file="foo.js")
                let generated: MappingIndex = { line= 1; column= 0 }
                let original: MappingIndex = { line= 1; column= 0 }
                map.AddMapping(generated, original, "a.js")
                
                let generated: MappingIndex = { line= 2; column= 0 }
                let original: MappingIndex = { line= 1; column= 0 }
                map.AddMapping(generated, original, "a.js")
                
                let generated: MappingIndex = { line= 3; column= 0 }
                let original: MappingIndex = { line= 1; column= 0 }
                map.AddMapping(generated, original, "a.js")
                
                let generated: MappingIndex = { line= 4; column= 0 }
                let original: MappingIndex = { line= 2; column= 2 }
                map.AddMapping(generated, original, "b.js")
                
                let generated: MappingIndex = { line= 5; column= 0 }
                let original: MappingIndex = { line= 2; column= 2 }
                map.AddMapping(generated, original, "b.js")
                
                let generated: MappingIndex = { line= 6; column= 0 }
                let original: MappingIndex = { line= 2; column= 2 }
                map.AddMapping(generated, original, "b.js")
                
                let generated: MappingIndex = { line= 11; column= 0 }
                let original: MappingIndex = { line= 3; column= 4 }
                map.AddMapping(generated, original, "c.js")
                
                TestUtils.assertEqualSourceMaps(map,inputMap)
                
           )
            
        
         testCase "test .toStringWithSourceMap() with empty string" <| fun () ->
            let node = SourceNode(_line=1,_column=0,_source="empty.js",_chunks=[|SourceChunk.ChunkS ""|])
            let (code, _) = node.ToStringWithSourceMap(file="")
            Expect.equal code ""  "toStringWithSourceMap works for empty string"
            
        
         testCase "test setSourceContent with toStringWithSourceMap" <| fun () ->
            let aNode = SourceNode(_line=1,_column=1,_source="a.js",_chunks=[|SourceChunk.ChunkS "a"|])
            aNode.SetSourceContent("a.js","someContent")
            let node = SourceNode(_chunks=[|
                SourceChunk.ChunkS "(function () {\n"
                SourceChunk.ChunkS "  "
                SourceChunk.ChunkArrSN [| aNode |]
                SourceChunk.ChunkS "  "
                SourceChunk.ChunkArrSN [|
                    SourceNode(_line=1,_column=1,_source="b.js",_chunks=[|SourceChunk.ChunkS "b"|])
                |]
                SourceChunk.ChunkS "}());"
            |])
            node.SetSourceContent("b.js","otherContent")
            let (_, map) = node.ToStringWithSourceMap(file="foo.js")
//            Expect.pass (fun () -> map |> ignore) //dummy assert
            
            Expect.equal (map._sources.Size()) 2 "sources is 2"
            Expect.equal (map._sources.At(0).Value) "a.js" "first is a.js"
            Expect.equal (map._sources.At(1).Value) "b.js" "second is b.js"
            Expect.equal map._sourcesContents.Count 2 "sources count is 2"
            let sc = map._sourcesContents |> Seq.map (fun kvp -> kvp.Value) |> Array.ofSeq
            Expect.equal sc.[0] "someContent" "some content in a"
            Expect.equal sc.[1] "otherContent" "other content in b"
       
        
         testCase "test walkSourceContents" <| fun () ->
            let aNode = SourceNode(_line=1,_column=0,_source="a.js",_chunks=[|SourceChunk.ChunkS "a"|])
            aNode.SetSourceContent("a.js","someContent")
            let node = SourceNode(_chunks=[|
                SourceChunk.ChunkS "(function () {\n"
                SourceChunk.ChunkS "  "
                SourceChunk.ChunkArrSN [| aNode |]
                SourceChunk.ChunkS "  "
                SourceChunk.ChunkArrSN [|
                    SourceNode(_line=1,_column=1,_source="b.js",_chunks=[|SourceChunk.ChunkS "b"|])
                |]
                SourceChunk.ChunkS "}());"
            |])
            node.SetSourceContent("b.js","otherContent")
            let results = ResizeArray<_>()
            node.WalkSourceContents(results.Add)
            Expect.equal results.Count 2 "results count is 2"
            Expect.equal (fst results.[0]) "a.js" "results.1.0 is correct"
            Expect.equal (snd results.[0]) "someContent" "results.2.0 is correct"
            Expect.equal (fst results.[1]) "b.js" "results.1.1 is correct"
            Expect.equal (snd results.[1]) "otherContent" "results.2.1 is correct"
    ]