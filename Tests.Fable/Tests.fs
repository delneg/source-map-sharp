module Tests

open Fable.Mocha
open SourceMapSharp

let _ = 
    [|
        Tests.Util.utilTests
        Tests.Base64.base64Tests
    |] |> Array.map Mocha.runTests
