open System.Collections.Generic
open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open Bogus
let fake = Faker()

[<PlainExporter; MemoryDiagnoser>]
type CustomArray() =
    [<DefaultValue; Params(10000)>]
    val mutable public N : int
    
    let mutable nums = Array.empty
    
   
    [<GlobalSetup>]
    member this.Setup() =
        let first = [|for _ in 1..this.N do fake.Random.Long()|]
        nums <-  first
        
    [<Benchmark>]
    member _.ArrayFilter() = Array.filter (fun x -> x % 2L = 0L) nums
  
    

[<EntryPoint>]
let main argv =
    let arrays = BenchmarkRunner.Run<CustomArray>()
    0 // return an integer exit code