module Tests_Fable.Util

open Fable.Mocha
open SourceMapSharp
open SourceMapSharp.Util
open Fable.SimpleJson
type TestUtils =
  static member assertEqualSourceMaps(s1:SourceMapGenerator,s2:SourceMapGenerator) =
    let serialized1 = Json.serialize (s1.toJSON())
    let serialized2 = Json.serialize (s2.toJSON())
    Expect.equal serialized1 serialized2 "sourcemaps not equal"
  
  static member assertEqualSourceMaps(s1:SourceMapGenerator,s2:SourceGeneratorJSON) =
     let serialized2 = Json.serialize s2
     let serialized1 = Json.serialize (s1.toJSON())
     Expect.equal serialized1 serialized2 "source map json not equal"
   
let utilTests =
    testList "Util" [
          testCase "test relative()" <| fun () ->

              Expect.equal (Util.getRelativePath ("/the/root", "/the/root/one.js")) "one.js" "relative path not equal"
              Expect.equal (Util.getRelativePath ("http://the/root", "http://the/root/one.js")) "one.js" "relative path not equal"
              Expect.equal (Util.getRelativePath ("/the/root", "/the/rootone.js")) "../rootone.js" "relative path not equal"
              Expect.equal (Util.getRelativePath ("http://the/root", "http://the/rootone.js")) "../rootone.js" "relative path not equal"
              Expect.equal (Util.getRelativePath ("/the/root", "/therootone.js")) "../../therootone.js" "relative path not equal"
              Expect.equal (Util.getRelativePath ("http://the/root", "/therootone.js")) "/therootone.js" "relative path not equal"
              Expect.equal (Util.getRelativePath ("", "/the/root/one.js")) "/the/root/one.js" "relative path not equal"
              Expect.equal (Util.getRelativePath (".", "/the/root/one.js")) "/the/root/one.js" "relative path not equal"
              Expect.equal (Util.getRelativePath ("", "the/root/one.js")) "the/root/one.js" "relative path not equal"
              Expect.equal (Util.getRelativePath (".", "the/root/one.js")) "the/root/one.js" "relative path not equal"
              Expect.equal (Util.getRelativePath ("/", "/the/root/one.js")) "the/root/one.js" "relative path not equal"
              Expect.equal (Util.getRelativePath ("/", "the/root/one.js")) "the/root/one.js" "relative path not equal"
         ]