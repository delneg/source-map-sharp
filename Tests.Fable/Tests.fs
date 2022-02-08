
open Fable.Mocha

let _ = 
    [|
        Tests_Fable.Util.utilTests
        Tests_Fable.Base64.base64Tests
        Tests_Fable.ArraySet.arraySetTests
        Tests_Fable.SourceMapGenerator.sourceMapGeneratorTests
        Tests_Fable.SourceNode.sourceNodeTests
    |] |> Array.map Mocha.runTests
