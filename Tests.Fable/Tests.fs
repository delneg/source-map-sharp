module Tests

open Fable.Mocha
open SourceMapSharp

let arithmeticTests =
    testList
        "Arithmetic tests"
        [

          testCase "plus works" <| fun () ->
              Expect.areEqualWithMsg "plus" (1 + 1) 2

          testCase "Test for falsehood" <| fun () ->
              Expect.isFalse (1 = 2)

          testCaseAsync "Test async code" <| fun () ->
              async {
                  let! x = async { return 21 }
                  let answer = x * 2
                  Expect.areEqualWithMsg "async" 42 answer
              }
        ]


let actualTests =

    testList "Util" [
          testCase "test relative()" <| fun () ->

              Expect.areEqual (Util.getRelativePath ("/the/root", "/the/root/one.js")) "one.js"
              Expect.areEqual (Util.getRelativePath ("http://the/root", "http://the/root/one.js")) "one.js"
              Expect.areEqual (Util.getRelativePath ("/the/root", "/the/rootone.js")) "../rootone.js"
              Expect.areEqual (Util.getRelativePath ("http://the/root", "http://the/rootone.js")) "../rootone.js"
              Expect.areEqual (Util.getRelativePath ("/the/root", "/therootone.js")) "../../therootone.js"
              Expect.areEqual (Util.getRelativePath ("http://the/root", "/therootone.js")) "/therootone.js"
              Expect.areEqual (Util.getRelativePath ("", "/the/root/one.js")) "/the/root/one.js"
              Expect.areEqual (Util.getRelativePath (".", "/the/root/one.js")) "/the/root/one.js"
              Expect.areEqual (Util.getRelativePath ("", "the/root/one.js")) "the/root/one.js"
              Expect.areEqual (Util.getRelativePath (".", "the/root/one.js")) "the/root/one.js"
              Expect.areEqual (Util.getRelativePath ("/", "/the/root/one.js")) "the/root/one.js"
              Expect.areEqual (Util.getRelativePath ("/", "the/root/one.js")) "the/root/one.js"
         ]

Mocha.runTests [ arithmeticTests; actualTests ]
