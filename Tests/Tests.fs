module Tests

open System
open Xunit

module MyMath =
    let private square x = x * x
    let private isOdd x = x % 2 <> 0

    let squaresOfOdds xs = 
        xs 
        |> Seq.filter isOdd 
        |> Seq.map square
        
[<Fact>]
let ``My test`` () =
    Assert.True(true)
    
[<Fact>]
let ``Sequence of Evens returns empty collection`` () =
    let expected = Seq.empty<int>
    let actual = MyMath.squaresOfOdds [2; 4; 6; 8; 10]
    Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)