module Tests.ArraySet
open SourceMapSharp
open Xunit

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
