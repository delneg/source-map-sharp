module Tests.Util

open Fable.Mocha
open SourceMapSharp
open SourceMapSharp.Util

type TestUtils =
  static member assertEqualSourceMaps(s1:SourceMapGenerator,s2:SourceMapGenerator) =
    Expect.equal (s1.ToString()) (s2.ToString()) "sourcemaps not equal"
  
//  static member assertEqualSourceMaps(s1:SourceMapGenerator,s2:SourceGeneratorJSON) =
//     Expect.equal (s1.ToString()) (s2.Serialize()) "source map json not equal"
//     
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