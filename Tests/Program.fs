module Program =
    open Wasmtime
    open System
    open FSharp.Interop.Dynamic
    
    let mapping_callback (generatedLine: uint32,generatedColumn:uint32,
                          hasLastGeneratedColumn:bool,lastGeneratedColumn:uint32,
                          hasOriginal:bool,source:uint32,originalLine:uint32,originalColumn:uint32,hasName:bool,name:uint32) :unit =
        printfn "generatedLine: %i, generatedColumn %i" generatedLine generatedColumn
    let [<EntryPoint>] main _ =
        let engine = new Engine()
        let store = new Store(engine)
        let md = Module.FromFile(engine, "./source-map/lib/mappings.wasm")
        let host = new Host(store)
//        host.DefineFunction("env","start_parse_mappings",fun () -> printfn "Start parse mappings") |> ignore
        host.DefineFunction("env","mapping_callback",fun (a:Func<'T,'TResult>) -> ()) |> ignore
        
        let instance = host.Instantiate(md)
        let str = ";EAAC;;IAEE;;MEEE"
        let size = str.Length
        let mappingsBufPtr = instance?allocate_mappings(size)
        
        printfn "bufPtr: %A, memories - %A" mappingsBufPtr instance.Memories
//        let res = instance?parse_mappings()
        0
