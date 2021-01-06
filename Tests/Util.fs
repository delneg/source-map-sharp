module Tests.Util

open System
open SourceMapSharp
open Xunit

module UtilTests =
    [<Fact>]
    let ``test relative()`` () =
      
      Assert.Equal(Util.getRelativePath("/the/root","/the/root/one.js"), "one.js")
      
      Assert.Equal(
        Util.getRelativePath("http://the/root", "http://the/root/one.js"),
        "one.js"
      )
      
      Assert.Equal(
        Util.getRelativePath("/the/root", "/the/rootone.js"),
        "../rootone.js"
      )
      
      Assert.Equal(
        Util.getRelativePath("http://the/root", "http://the/rootone.js"),
        "../rootone.js"
      )
      
      Assert.Equal(
        Util.getRelativePath("/the/root", "/therootone.js"),
        "../../therootone.js"
      )
      
      Assert.Equal(
        Util.getRelativePath("http://the/root", "/therootone.js"),
        "/therootone.js"
      )
      
      Assert.Equal(Util.getRelativePath("", "/the/root/one.js"), "/the/root/one.js")
      
      Assert.Equal(Util.getRelativePath(".", "/the/root/one.js"), "/the/root/one.js")
      
      Assert.Equal(Util.getRelativePath("", "the/root/one.js"), "the/root/one.js")
      
      Assert.Equal(Util.getRelativePath(".", "the/root/one.js"), "the/root/one.js")
      
      Assert.Equal(Util.getRelativePath("/", "/the/root/one.js"), "the/root/one.js")
      
      Assert.Equal(Util.getRelativePath("/", "the/root/one.js"), "the/root/one.js")