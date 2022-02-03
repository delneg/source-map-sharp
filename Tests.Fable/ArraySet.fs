module Tests.ArraySet

open Fable.Mocha
open SourceMapSharp



let makeTestSet () =
    let set = ArraySet()

    for i in [ 0 .. 99 ] do
        set.Add(string i, false)

    set

let arraySetTests =
    testList "ArraySet" [
        
        testCase "test .has() membership" <| fun () ->
            let set = makeTestSet ()

            for i in [ 0 .. 99 ] do
                
                Expect.isTrue(set.Has(string i)) "test .has() membership"


        testCase "test .indexOf() elements" <| fun () ->
            let set = makeTestSet ()

            for i in [ 0 .. 99 ] do
                let a = set.indexOf (string i)
                Expect.equal a  (Some(i)) "test .indexOf() elements"


        testCase "test .at() indexing" <| fun () ->
            let set = makeTestSet ()

            for i in [ 0 .. 99 ] do
                let a = set.At(i)
                Expect.equal a (Some(string i)) "test .at() indexing"


        testCase "test creating from an array" <| fun () ->
          let set =
                ArraySet.fromArray
                    ([| "foo"
                        "bar"
                        "baz"
                        "quux"
                        "hasOwnProperty" |],
                     false)
          Expect.isTrue(set.Has("foo")) "foo"
          Expect.isTrue(set.Has("bar")) "bar"
          Expect.isTrue(set.Has("baz")) "baz"
          Expect.isTrue(set.Has("quux")) "quux"
          Expect.isTrue(set.Has("hasOwnProperty")) "hasOwnProperty"
          
          Expect.equal (set.indexOf("foo")) (Some 0) "indexOf foo"
          Expect.equal (set.indexOf("bar")) (Some 1) "indexOf bar"
          Expect.equal (set.indexOf("baz")) (Some 2) "indexOf baz"
          Expect.equal (set.indexOf("quux"))(Some 3) "indexOf quux"
          
          Expect.equal (set.At(0)) (Some "foo") ".At foo"
          Expect.equal (set.At(1)) (Some "bar") ".At bar"
          Expect.equal (set.At(2)) (Some "baz") ".At baz"
          Expect.equal (set.At(3))(Some "quux") ".At quux"
          

        testCase "test that you can add __proto__; see github issue #30" <| fun () ->
            let set = ArraySet ()
            set.Add("__proto__",false)
            Expect.isTrue(set.Has("__proto__")) "__proto__ has"
            Expect.equal (set.indexOf("__proto__")) (Some(0)) "indexOf __proto__"
            Expect.equal (set.At(0)) (Some("__proto__")) ".At __proto__"



        testCase "test .fromArray() with duplicates" <| fun () ->
            let set = ArraySet.fromArray ([| "foo";"foo"|],false)
            
            Expect.isTrue (set.Has("foo")) "set has foo"
            Expect.equal (set.At(0)) (Some "foo") "set at 0 is foo"
            Expect.equal (set.indexOf("foo")) (Some 0) "set indexOf foo is 0"
            Expect.equal (set.ToArray().Count)  1 "set toArray count is 1"
            
            let set = ArraySet.fromArray ([| "foo";"foo"|],true)
            
            Expect.isTrue (set.Has("foo")) "set has foo"
            Expect.equal (set.At(0)) (Some "foo") "set at 0 is foo"
            Expect.equal (set.At(1)) (Some "foo") "set at 1 is foo"
            Expect.equal (set.indexOf("foo")) (Some 0) "set indexOf foo is 0"
            Expect.equal (set.ToArray().Count) 2 "set toArray count is 2"
            

        testCase "test .add() with duplicates" <| fun () ->
            
            let set = ArraySet()
            set.Add("foo",false)
            set.Add("foo",false)
            
            Expect.isTrue (set.Has("foo")) "set has foo"
            Expect.equal (set.At(0)) (Some "foo") "set at 0 is foo"
            Expect.equal (set.indexOf("foo")) (Some 0) "set indexOf foo is 0"
            Expect.equal (set.ToArray().Count)  1 "set.ToArray().Count is 1"
            
            set.Add("foo",true)
            
            Expect.isTrue (set.Has("foo")) "set has foo"
            Expect.equal (set.At(0)) (Some "foo") "set at 0 is foo"
            Expect.equal (set.At(1)) (Some "foo") "set at 1 is foo"
            Expect.equal (set.indexOf("foo")) (Some 0) "set indexOf foo is 0"
            Expect.equal (set.ToArray().Count)  2 "set.ToArray().Count is 2"


        testCase "test .size()" <| fun () ->
            let set = ArraySet ()
            set.Add("foo",false)
            set.Add("bar",false)
            set.Add("baz",false)
            Expect.equal (set.Size()) 3  ".size() == 3"


        testCase "test .size() with disallowed duplicates" <| fun () ->
            let set = ArraySet ()
            set.Add("foo",false)
            set.Add("foo",false)
            set.Add("bar",false)
            set.Add("bar",false)
            set.Add("baz",false)
            set.Add("baz",false)
            Expect.equal (set.Size()) 3  ".size() with disallowed duplicates == 3"
            

        testCase "test .size() with allowed duplicates" <| fun () ->
            let set = ArraySet ()
            set.Add("foo",false)
            set.Add("foo",true)
            set.Add("bar",false)
            set.Add("bar",true)
            set.Add("baz",false)
            set.Add("baz",true)
            Expect.equal (set.Size()) 3 ".size() with allowed duplicates == 3"
    ]
