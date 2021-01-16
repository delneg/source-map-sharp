module Tests.Util

open SourceMapSharp
open SourceMapSharp.Util
open Xunit
open System.Text.Json

type TestUtils =
  static member assertEqualSourceMaps(s1:SourceMapGenerator,s2:SourceMapGenerator) =
    Assert.Equal (s1.ToString(),s2.ToString())
  
  static member assertEqualSourceMaps(s1:SourceMapGenerator,s2:SourceGeneratorJSON) =
    Assert.Equal (s1.ToString(),JsonSerializer.Serialize(s2))
    
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