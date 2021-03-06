module Tests.SourceNode

open SourceMapSharp
open Xunit
open SourceMapSharp.Util
open Tests.Util
module SourceNodeTests =
    [<Fact>]
    let ``test .add()`` () =
        let node = SourceNode()
        node.Add(SourceChunk.ChunkS "function noop() {}") |> ignore
        node.Add(SourceChunk.ChunkArrSN [|SourceNode()|]) |> ignore
        node.Add(SourceChunk.ChunkArrSN [|SourceNode(_chunks=[|SourceChunk.ChunkS "return 10;"|])|]) |> ignore
        node.Add(SourceChunk.ChunkArrS [|"function foo() {";"}"|]) |> ignore
    [<Fact>]
    let ``test .prepend()`` () =
        let node = SourceNode()
        let s = "function noop() {}"
        node.Prepend(SourceChunk.ChunkS s) |> ignore
        Assert.Equal(node.children.[0],SourceNodeChild.S s)
        Assert.Equal(node.children.Count,1)
        
        node.Prepend(SourceChunk.ChunkArrSN [|SourceNode()|]) |> ignore
        Assert.True(match node.children.[0] with | SN _ -> true | S _ -> false)
        Assert.True(match node.children.[1] with | SN _ -> false | S _ -> true)
        Assert.True(match node.children.[1] with | SN _ -> false | S ss -> s = ss)
        Assert.True(node.children.Count = 2)
        
        node.Prepend(
            [|SourceChunk.ChunkS "function foo() {"
              SourceChunk.ChunkArrSN [|SourceNode(_chunks=[|SourceChunk.ChunkS "return 10;"|])|]
              SourceChunk.ChunkS "}"
            |]) |> ignore

        Assert.Equal(node.children.[0].ToString(), "function foo() {")
        Assert.Equal(node.children.[1].ToString(), "return 10;")
        Assert.Equal(node.children.[2].ToString(), "}")
        Assert.Equal(node.children.[3].ToString(), "")
        Assert.Equal(node.children.[4].ToString(), "function noop() {}")
        Assert.True(node.children.Count = 5)
        
    [<Fact>]
    let ``test .toString()`` () =
        let node = SourceNode(_chunks=[|
            SourceChunk.ChunkS "function foo() {"
            SourceChunk.ChunkArrSN [|SourceNode(_chunks=[|SourceChunk.ChunkS "return 10;"|])|]
            SourceChunk.ChunkS "}"
        |])
        Assert.Equal(node.ToString(),"function foo() {return 10;}")
    
    [<Fact>]
    let ``test .join()`` () =
        let node = SourceNode(_chunks=[|
            SourceChunk.ChunkS "a"
            SourceChunk.ChunkS "b"
            SourceChunk.ChunkS "c"
            SourceChunk.ChunkS "d"
        |])
        Assert.Equal("a, b, c, d", node.Join(", ").ToString())
    
    [<Fact>]
    let ``test .walk()`` () =
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
            Assert.Equal(expected.[i].str,chunk)
            Assert.Equal(expected.[i].source, loc.Source)
            Assert.Equal(expected.[i].line, loc.line)
            Assert.Equal(expected.[i].column, loc.column)
            i <- i+1
        )
    
    [<Fact>]
    let ``test .replaceRight()`` () =
        // Not nested
        let node = SourceNode(_chunks=[|
            SourceChunk.ChunkS "hello world"
        |])
        node.ReplaceRight("world","universe") |> ignore
        Assert.Equal("hello universe", node.ToString())
        
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
        Assert.Equal("hey sexy mama, want to watch Futurama?", node.ToString())
        
        
    [<Fact>]
    let ``test .toStringWithSourceMap()`` () =
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
            Assert.Equal(expected, code)
            //todo: sourcemapconsumer part
        )
    [<Fact>]
    let ``test .toStringWithSourceMap() with consecutive newlines`` () =
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
            Assert.Equal(expected, code)
            
            let map = SourceMapGenerator(file="foo.js")
            let generated: MappingIndex = { line= 3; column= 0 }
            let original: MappingIndex = { line= 1; column= 0 }
            map.AddMapping(generated, original, "a.js")
            let generated: MappingIndex = { line= 4; column= 0 }
            let original: MappingIndex = { line= 2; column= 0 }
            map.AddMapping(generated, original, "a.js")
            TestUtils.assertEqualSourceMaps(map,inputMap)
        )
    
    [<Fact>]
    let ``test .toStringWithSourceMap() merging duplicate mappings`` () =
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
            Assert.Equal(expected, code)
            
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
    
    
    [<Fact>]
    let ``test .toStringWithSourceMap() multi-line SourceNodes`` () =
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
            Assert.Equal(expected, code)
            
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
        
    [<Fact>]
    let ``test .toStringWithSourceMap() with empty string`` () =
        let node = SourceNode(_line=1,_column=0,_source="empty.js",_chunks=[|SourceChunk.ChunkS ""|])
        let (code, _) = node.ToStringWithSourceMap(file="")
        Assert.Equal(code,"")
        
    [<Fact>]
    let ``test setSourceContent with toStringWithSourceMap`` () =
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
        Assert.NotNull(map) //dummy assert
        
        Assert.Equal(map._sources.Size(), 2)
        Assert.Equal(map._sources.At(0).Value, "a.js")
        Assert.Equal(map._sources.At(1).Value, "b.js")
        Assert.Equal(map._sourcesContents.Count, 2)
        let sc = map._sourcesContents |> Seq.map (fun kvp -> kvp.Value) |> Array.ofSeq
        Assert.Equal(sc.[0], "someContent")
        Assert.Equal(sc.[1], "otherContent")
   
    [<Fact>]
    let ``test walkSourceContents`` () =
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
        Assert.Equal(results.Count, 2)
        Assert.Equal(fst results.[0], "a.js")
        Assert.Equal(snd results.[0], "someContent")
        Assert.Equal(fst results.[1], "b.js")
        Assert.Equal(snd results.[1], "otherContent")
    