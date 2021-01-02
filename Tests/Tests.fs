module Tests

open System
open SourceMapSharp
open Xunit
open System.Text.Json
module Base64Tests =
    [<Fact>]
    let ``Base64 encode test out of range encoding`` () =
        let action =
            Action(fun _ -> Base64.base64Encode -1 |> ignore)

        Assert.Throws(VlqException().GetType(), action)

    [<Fact>]
    let ``Base64 encode test out of range encoding#2`` () =
        let action =
            Action(fun _ -> Base64.base64Encode 64 |> ignore)

        Assert.Throws(VlqException().GetType(), action)

    [<Fact>]
    let ``test normal encoding and decoding`` () =
        for i in [ 0 .. 63 ] do
            Base64.base64Encode i |> ignore


    let vlqs =
        [| (-255, "/P")
           (-254, "9P")
           (-253, "7P")
           (-252, "5P")
           (-251, "3P")
           (-250, "1P")
           (-249, "zP")
           (-248, "xP")
           (-247, "vP")
           (-246, "tP")
           (-245, "rP")
           (-244, "pP")
           (-243, "nP")
           (-242, "lP")
           (-241, "jP")
           (-240, "hP")
           (-239, "/O")
           (-238, "9O")
           (-237, "7O")
           (-236, "5O")
           (-235, "3O")
           (-234, "1O")
           (-233, "zO")
           (-232, "xO")
           (-231, "vO")
           (-230, "tO")
           (-229, "rO")
           (-228, "pO")
           (-227, "nO")
           (-226, "lO")
           (-225, "jO")
           (-224, "hO")
           (-223, "/N")
           (-222, "9N")
           (-221, "7N")
           (-220, "5N")
           (-219, "3N")
           (-218, "1N")
           (-217, "zN")
           (-216, "xN")
           (-215, "vN")
           (-214, "tN")
           (-213, "rN")
           (-212, "pN")
           (-211, "nN")
           (-210, "lN")
           (-209, "jN")
           (-208, "hN")
           (-207, "/M")
           (-206, "9M")
           (-205, "7M")
           (-204, "5M")
           (-203, "3M")
           (-202, "1M")
           (-201, "zM")
           (-200, "xM")
           (-199, "vM")
           (-198, "tM")
           (-197, "rM")
           (-196, "pM")
           (-195, "nM")
           (-194, "lM")
           (-193, "jM")
           (-192, "hM")
           (-191, "/L")
           (-190, "9L")
           (-189, "7L")
           (-188, "5L")
           (-187, "3L")
           (-186, "1L")
           (-185, "zL")
           (-184, "xL")
           (-183, "vL")
           (-182, "tL")
           (-181, "rL")
           (-180, "pL")
           (-179, "nL")
           (-178, "lL")
           (-177, "jL")
           (-176, "hL")
           (-175, "/K")
           (-174, "9K")
           (-173, "7K")
           (-172, "5K")
           (-171, "3K")
           (-170, "1K")
           (-169, "zK")
           (-168, "xK")
           (-167, "vK")
           (-166, "tK")
           (-165, "rK")
           (-164, "pK")
           (-163, "nK")
           (-162, "lK")
           (-161, "jK")
           (-160, "hK")
           (-159, "/J")
           (-158, "9J")
           (-157, "7J")
           (-156, "5J")
           (-155, "3J")
           (-154, "1J")
           (-153, "zJ")
           (-152, "xJ")
           (-151, "vJ")
           (-150, "tJ")
           (-149, "rJ")
           (-148, "pJ")
           (-147, "nJ")
           (-146, "lJ")
           (-145, "jJ")
           (-144, "hJ")
           (-143, "/I")
           (-142, "9I")
           (-141, "7I")
           (-140, "5I")
           (-139, "3I")
           (-138, "1I")
           (-137, "zI")
           (-136, "xI")
           (-135, "vI")
           (-134, "tI")
           (-133, "rI")
           (-132, "pI")
           (-131, "nI")
           (-130, "lI")
           (-129, "jI")
           (-128, "hI")
           (-127, "/H")
           (-126, "9H")
           (-125, "7H")
           (-124, "5H")
           (-123, "3H")
           (-122, "1H")
           (-121, "zH")
           (-120, "xH")
           (-119, "vH")
           (-118, "tH")
           (-117, "rH")
           (-116, "pH")
           (-115, "nH")
           (-114, "lH")
           (-113, "jH")
           (-112, "hH")
           (-111, "/G")
           (-110, "9G")
           (-109, "7G")
           (-108, "5G")
           (-107, "3G")
           (-106, "1G")
           (-105, "zG")
           (-104, "xG")
           (-103, "vG")
           (-102, "tG")
           (-101, "rG")
           (-100, "pG")
           (-99, "nG")
           (-98, "lG")
           (-97, "jG")
           (-96, "hG")
           (-95, "/F")
           (-94, "9F")
           (-93, "7F")
           (-92, "5F")
           (-91, "3F")
           (-90, "1F")
           (-89, "zF")
           (-88, "xF")
           (-87, "vF")
           (-86, "tF")
           (-85, "rF")
           (-84, "pF")
           (-83, "nF")
           (-82, "lF")
           (-81, "jF")
           (-80, "hF")
           (-79, "/E")
           (-78, "9E")
           (-77, "7E")
           (-76, "5E")
           (-75, "3E")
           (-74, "1E")
           (-73, "zE")
           (-72, "xE")
           (-71, "vE")
           (-70, "tE")
           (-69, "rE")
           (-68, "pE")
           (-67, "nE")
           (-66, "lE")
           (-65, "jE")
           (-64, "hE")
           (-63, "/D")
           (-62, "9D")
           (-61, "7D")
           (-60, "5D")
           (-59, "3D")
           (-58, "1D")
           (-57, "zD")
           (-56, "xD")
           (-55, "vD")
           (-54, "tD")
           (-53, "rD")
           (-52, "pD")
           (-51, "nD")
           (-50, "lD")
           (-49, "jD")
           (-48, "hD")
           (-47, "/C")
           (-46, "9C")
           (-45, "7C")
           (-44, "5C")
           (-43, "3C")
           (-42, "1C")
           (-41, "zC")
           (-40, "xC")
           (-39, "vC")
           (-38, "tC")
           (-37, "rC")
           (-36, "pC")
           (-35, "nC")
           (-34, "lC")
           (-33, "jC")
           (-32, "hC")
           (-31, "/B")
           (-30, "9B")
           (-29, "7B")
           (-28, "5B")
           (-27, "3B")
           (-26, "1B")
           (-25, "zB")
           (-24, "xB")
           (-23, "vB")
           (-22, "tB")
           (-21, "rB")
           (-20, "pB")
           (-19, "nB")
           (-18, "lB")
           (-17, "jB")
           (-16, "hB")
           (-15, "f")
           (-14, "d")
           (-13, "b")
           (-12, "Z")
           (-11, "X")
           (-10, "V")
           (-9, "T")
           (-8, "R")
           (-7, "P")
           (-6, "N")
           (-5, "L")
           (-4, "J")
           (-3, "H")
           (-2, "F")
           (-1, "D")
           (0, "A")
           (1, "C")
           (2, "E")
           (3, "G")
           (4, "I")
           (5, "K")
           (6, "M")
           (7, "O")
           (8, "Q")
           (9, "S")
           (10, "U")
           (11, "W")
           (12, "Y")
           (13, "a")
           (14, "c")
           (15, "e")
           (16, "gB")
           (17, "iB")
           (18, "kB")
           (19, "mB")
           (20, "oB")
           (21, "qB")
           (22, "sB")
           (23, "uB")
           (24, "wB")
           (25, "yB")
           (26, "0B")
           (27, "2B")
           (28, "4B")
           (29, "6B")
           (30, "8B")
           (31, "+B")
           (32, "gC")
           (33, "iC")
           (34, "kC")
           (35, "mC")
           (36, "oC")
           (37, "qC")
           (38, "sC")
           (39, "uC")
           (40, "wC")
           (41, "yC")
           (42, "0C")
           (43, "2C")
           (44, "4C")
           (45, "6C")
           (46, "8C")
           (47, "+C")
           (48, "gD")
           (49, "iD")
           (50, "kD")
           (51, "mD")
           (52, "oD")
           (53, "qD")
           (54, "sD")
           (55, "uD")
           (56, "wD")
           (57, "yD")
           (58, "0D")
           (59, "2D")
           (60, "4D")
           (61, "6D")
           (62, "8D")
           (63, "+D")
           (64, "gE")
           (65, "iE")
           (66, "kE")
           (67, "mE")
           (68, "oE")
           (69, "qE")
           (70, "sE")
           (71, "uE")
           (72, "wE")
           (73, "yE")
           (74, "0E")
           (75, "2E")
           (76, "4E")
           (77, "6E")
           (78, "8E")
           (79, "+E")
           (80, "gF")
           (81, "iF")
           (82, "kF")
           (83, "mF")
           (84, "oF")
           (85, "qF")
           (86, "sF")
           (87, "uF")
           (88, "wF")
           (89, "yF")
           (90, "0F")
           (91, "2F")
           (92, "4F")
           (93, "6F")
           (94, "8F")
           (95, "+F")
           (96, "gG")
           (97, "iG")
           (98, "kG")
           (99, "mG")
           (100, "oG")
           (101, "qG")
           (102, "sG")
           (103, "uG")
           (104, "wG")
           (105, "yG")
           (106, "0G")
           (107, "2G")
           (108, "4G")
           (109, "6G")
           (110, "8G")
           (111, "+G")
           (112, "gH")
           (113, "iH")
           (114, "kH")
           (115, "mH")
           (116, "oH")
           (117, "qH")
           (118, "sH")
           (119, "uH")
           (120, "wH")
           (121, "yH")
           (122, "0H")
           (123, "2H")
           (124, "4H")
           (125, "6H")
           (126, "8H")
           (127, "+H")
           (128, "gI")
           (129, "iI")
           (130, "kI")
           (131, "mI")
           (132, "oI")
           (133, "qI")
           (134, "sI")
           (135, "uI")
           (136, "wI")
           (137, "yI")
           (138, "0I")
           (139, "2I")
           (140, "4I")
           (141, "6I")
           (142, "8I")
           (143, "+I")
           (144, "gJ")
           (145, "iJ")
           (146, "kJ")
           (147, "mJ")
           (148, "oJ")
           (149, "qJ")
           (150, "sJ")
           (151, "uJ")
           (152, "wJ")
           (157, "6J")
           (158, "8J")
           (159, "+J")
           (160, "gK")
           (161, "iK")
           (162, "kK")
           (163, "mK")
           (164, "oK")
           (165, "qK")
           (166, "sK")
           (167, "uK")
           (168, "wK")
           (169, "yK")
           (170, "0K")
           (171, "2K")
           (172, "4K")
           (173, "6K")
           (174, "8K")
           (175, "+K")
           (176, "gL")
           (177, "iL")
           (178, "kL")
           (179, "mL")
           (180, "oL")
           (181, "qL")
           (182, "sL")
           (183, "uL")
           (184, "wL")
           (185, "yL")
           (186, "0L")
           (187, "2L")
           (188, "4L")
           (189, "6L")
           (190, "8L")
           (191, "+L")
           (192, "gM")
           (193, "iM")
           (194, "kM")
           (195, "mM")
           (196, "oM")
           (197, "qM")
           (198, "sM")
           (199, "uM")
           (200, "wM")
           (201, "yM")
           (202, "0M")
           (203, "2M")
           (204, "4M")
           (205, "6M")
           (206, "8M")
           (207, "+M")
           (208, "gN")
           (209, "iN")
           (210, "kN")
           (211, "mN")
           (212, "oN")
           (213, "qN")
           (214, "sN")
           (215, "uN")
           (216, "wN")
           (217, "yN")
           (218, "0N")
           (219, "2N")
           (220, "4N")
           (221, "6N")
           (222, "8N")
           (223, "+N")
           (224, "gO")
           (225, "iO")
           (226, "kO")
           (227, "mO")
           (228, "oO")
           (229, "qO")
           (230, "sO")
           (231, "uO")
           (232, "wO")
           (233, "yO")
           (234, "0O")
           (235, "2O")
           (236, "4O")
           (237, "6O")
           (238, "8O")
           (239, "+O")
           (240, "gP")
           (241, "iP")
           (242, "kP")
           (243, "mP")
           (244, "oP")
           (245, "qP")
           (246, "sP")
           (247, "uP")
           (248, "wP")
           (249, "yP")
           (250, "0P")
           (251, "2P")
           (252, "4P")
           (253, "6P")
           (254, "8P")
           (255, "+P") |]


    [<Fact>]
    let ``test normal encoding and decoding for VLQ`` () =
        for (num, str) in vlqs do
            let s = Base64Vlq.Encode num
            Assert.Equal(str, s)

module ArraySetTests =

    let makeTestSet () =
        let set = ArraySet()

        for i in [ 0 .. 99 ] do
            set.Add(string i, false)

        set

    [<Fact>]
    let ``test .has() membership`` () =
        let set = makeTestSet ()

        for i in [ 0 .. 99 ] do
            Assert.True(set.Has(string i))

    [<Fact>]
    let ``test .indexOf() elements`` () =
        let set = makeTestSet ()

        for i in [ 0 .. 99 ] do
            let a = set.indexOf (string i)
            Assert.StrictEqual(a, Some i)

    [<Fact>]
    let ``test .at() indexing`` () =
        let set = makeTestSet ()

        for i in [ 0 .. 99 ] do
            let a = set.At(i)
            Assert.StrictEqual(a, Some(string i))

    [<Fact>]
    let ``test creating from an array`` () =
      let set =
            ArraySet.fromArray
                ([| "foo"
                    "bar"
                    "baz"
                    "quux"
                    "hasOwnProperty" |],
                 false)
      Assert.True(set.Has("foo"))
      Assert.True(set.Has("bar"))
      Assert.True(set.Has("baz"))
      Assert.True(set.Has("quux"))
      Assert.True(set.Has("hasOwnProperty"))
      
      Assert.StrictEqual(set.indexOf("foo"), Some 0)
      Assert.StrictEqual(set.indexOf("bar"), Some 1)
      Assert.StrictEqual(set.indexOf("baz"), Some 2)
      Assert.StrictEqual(set.indexOf("quux"), Some 3)
      
      Assert.StrictEqual(set.At(0), Some "foo")
      Assert.StrictEqual(set.At(1), Some "bar")
      Assert.StrictEqual(set.At(2), Some "baz")
      Assert.StrictEqual(set.At(3), Some "quux")
      

    [<Fact>]
    let ``test that you can add __proto__; see github issue #30`` () =
        let set = ArraySet ()
        set.Add("__proto__",false)
        Assert.True(set.Has("__proto__"))
        Assert.StrictEqual(set.indexOf("__proto__"), Some 0)
        Assert.StrictEqual(set.At(0), Some "__proto__")


    [<Fact>]
    let ``test .fromArray() with duplicates`` () =
        let set = ArraySet.fromArray ([| "foo";"foo"|],false)
        
        Assert.True(set.Has("foo"))
        Assert.StrictEqual(set.At(0), Some "foo")
        Assert.StrictEqual(set.indexOf("foo"), Some 0)
        Assert.StrictEqual(set.ToArray().Count, 1)
        
        let set = ArraySet.fromArray ([| "foo";"foo"|],true)
        
        Assert.True(set.Has("foo"))
        Assert.StrictEqual(set.At(0), Some "foo")
        Assert.StrictEqual(set.At(1), Some "foo")
        Assert.StrictEqual(set.indexOf("foo"), Some 0)
        Assert.StrictEqual(set.ToArray().Count, 2)
        
    [<Fact>]
    let ``test .add() with duplicates`` () =
        
        let set = ArraySet()
        set.Add("foo",false)
        set.Add("foo",false)
        
        Assert.True(set.Has("foo"))
        Assert.StrictEqual(set.At(0), Some "foo")
        Assert.StrictEqual(set.indexOf("foo"), Some 0)
        Assert.StrictEqual(set.ToArray().Count, 1)
        
        set.Add("foo",true)
        
        Assert.True(set.Has("foo"))
        Assert.StrictEqual(set.At(0), Some "foo")
        Assert.StrictEqual(set.At(1), Some "foo")
        Assert.StrictEqual(set.indexOf("foo"), Some 0)
        Assert.StrictEqual(set.ToArray().Count, 2)
    
    [<Fact>]
    let ``test .size()`` () =
        let set = ArraySet ()
        set.Add("foo",false)
        set.Add("bar",false)
        set.Add("baz",false)
        Assert.StrictEqual(set.Size(), 3)
    
    [<Fact>]
    let ``test .size() with disallowed duplicates`` () =
        let set = ArraySet ()
        set.Add("foo",false)
        set.Add("foo",false)
        set.Add("bar",false)
        set.Add("bar",false)
        set.Add("baz",false)
        set.Add("baz",false)
        Assert.StrictEqual(set.Size(), 3)
        

    [<Fact>]
    let ``test .size() with allowed duplicates`` () =
        let set = ArraySet ()
        set.Add("foo",false)
        set.Add("foo",true)
        set.Add("bar",false)
        set.Add("bar",true)
        set.Add("baz",false)
        set.Add("baz",true)
        Assert.StrictEqual(set.Size(), 3)

module SourceMapGeneratorTests =
    let testMap: Util.SourceGeneratorJSON = {
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
        let generated: Util.MappingIndex = {line=1;column=1}
        map.AddMapping(generated)
        
    [<Fact>]
    let ``test adding mappings (case 2)`` () =
        let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
        let generated: Util.MappingIndex = {line=1;column=1}
        let original: Util.MappingIndex = {line=1;column=1}
        map.AddMapping(generated,original,"bar.js")
        
    [<Fact>]
    let ``test adding mappings (case 3)`` () =
        let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
        let generated: Util.MappingIndex = {line=1;column=1}
        let original: Util.MappingIndex = {line=1;column=1}
        map.AddMapping(generated,original,"bar.js","someToken")
    
    [<Fact>]
    let ``test adding mappings (invalid)`` () =
        let map = SourceMapGenerator(file="generated-foo.js",sourceRoot=".")
        let generated: Util.MappingIndex = {line=1;column=1}
        let original: Util.MappingIndex = {line=1;column=1}
        Assert.Throws(Exception().GetType(),Action(fun _ -> map.AddMapping(generated,original)))
    
    [<Fact>]
    let ``test adding mappings with skipValidation`` () =
        let map = SourceMapGenerator(skipValidation=true, file="generated-foo.js",sourceRoot=".")
        let generated: Util.MappingIndex = {line=1;column=1}
        let original: Util.MappingIndex = {line=1;column=1}
        map.AddMapping(generated,original)
        
    [<Fact>]
    let ``test that the correct mappings are being generated`` () =
        let map = SourceMapGenerator(file="min.js",sourceRoot="/the/root")
        let generated: Util.MappingIndex = { line= 1; column= 1 }
        let original: Util.MappingIndex = { line= 1; column= 1 }
        map.AddMapping(generated, original, "one.js")

        let generated: Util.MappingIndex = { line= 1; column= 5 }
        let original: Util.MappingIndex = { line= 1; column= 5 }
        map.AddMapping(generated, original, "one.js")

        let generated: Util.MappingIndex = { line= 1; column= 9 }
        let original: Util.MappingIndex = { line= 1; column= 11 }
        map.AddMapping(generated, original, "one.js")

        let generated: Util.MappingIndex = { line= 1; column= 18 }
        let original: Util.MappingIndex = { line= 1; column= 21 }
        map.AddMapping(generated, original, "one.js", "bar")

        let generated: Util.MappingIndex = { line= 1; column= 21 }
        let original: Util.MappingIndex = { line= 2; column= 3 }
        map.AddMapping(generated, original, "one.js")

        let generated: Util.MappingIndex = { line= 1; column= 28 }
        let original: Util.MappingIndex = { line= 2; column= 10 }
        map.AddMapping(generated, original, "one.js", "baz")

        let generated: Util.MappingIndex = { line= 1; column= 32 }
        let original: Util.MappingIndex = { line= 2; column= 14 }
        map.AddMapping(generated, original, "one.js", "bar")

        let generated: Util.MappingIndex = { line= 2; column= 1 }
        let original: Util.MappingIndex = { line= 1; column= 1 }
        map.AddMapping(generated, original, "two.js")

        let generated: Util.MappingIndex = { line= 2; column= 5 }
        let original: Util.MappingIndex = { line= 1; column= 5 }
        map.AddMapping(generated, original, "two.js")

        let generated: Util.MappingIndex = { line= 2; column= 9 }
        let original: Util.MappingIndex = { line= 1; column= 11 }
        map.AddMapping(generated, original, "two.js")

        let generated: Util.MappingIndex = { line= 2; column= 18 }
        let original: Util.MappingIndex = { line= 1; column= 21 }
        map.AddMapping(generated, original, "two.js", "n")

        let generated: Util.MappingIndex = { line= 2; column= 21 }
        let original: Util.MappingIndex = { line= 2; column= 3 }
        map.AddMapping(generated, original, "two.js")

        let generated: Util.MappingIndex = { line= 2; column= 28 }
        let original: Util.MappingIndex = { line= 2; column= 10 }
        map.AddMapping(generated, original, "two.js", "n")
        
        printfn "%s\n%s" (map.ToString()) (JsonSerializer.Serialize(testMap))
        
        
        //TODO: expected: "CAAC,IAAI,IAAM,SAAUA,GAClB,OAAOC,IAAID;CCDb,IAAI,IAAM,SAAUE,GAClB,OAAOA"
        // actual:  "CAAA,IAAI,IAAM,SAAUA,GAClB,OAAOC,IAAID;CCDb,IAAI,IAAM,SAAUE,GAClB,OAAOA"
        Assert.Equal (map.ToString(),JsonSerializer.Serialize(testMap))