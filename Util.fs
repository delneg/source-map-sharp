namespace SourceMapSharp
open System.Collections.Generic
module Util =
    type MappingIndex = {line: int; column: int}
    type Mapping = {
        Generated: MappingIndex
        Original: MappingIndex option
        Source: string option
        Name: string option
        
    }
    
    type SourceGeneratorJSON = {
        version: int
        sources: seq<string>
        names: seq<string>
        mappings: string
        file: string option
        sourcesContent: seq<string option> option
        sourceRoot: string option
    }
    let strcmp (s1: string option) (s2:string option) =
        if s1.IsSome && s2.IsSome then
            if s1 = s2 then 0
            elif s1 > s2 then 1
            else -1
        elif s1.IsNone && s2.IsNone then
            0
        elif s1.IsNone then 1
        elif s2.IsNone then -1
        else -1
    
    
    let compareByGeneratedPositionsInflated (mappingA: Mapping) (mappingB: Mapping) =
        let mutable cmp = mappingA.Generated.line - mappingB.Generated.line
        if cmp <> 0 then cmp
        else
            cmp <- mappingA.Generated.column - mappingB.Generated.column
            if cmp <> 0 then cmp
            else
              cmp <- strcmp mappingA.Source mappingB.Source
              if cmp <> 0 then cmp
              else
                match (mappingA.Original,mappingB.Original) with
                | (Some mapAOriginal,Some mapBOriginal) ->
                    cmp <- mapAOriginal.line - mapBOriginal.line
                    if cmp <> 0 then cmp
                    else
                        cmp <- mapAOriginal.column - mapBOriginal.column
                        if cmp <> 0 then cmp
                        else strcmp mappingA.Name mappingB.Name
                | _ -> strcmp mappingA.Name mappingB.Name

    
    let [<Literal>] private dummyFile = "__DUMMY-FILE__.txt"
    let private Combine (path1: string, path2: string) =
        let path1 =
            if path1.Length = 0 then path1
            else (path1.TrimEnd [|'\\';'/'|]) + "/"
        path1 + (path2.TrimStart [|'\\';'/'|])

    let private ChangeExtension (path: string, ext: string) =
        let i = path.LastIndexOf(".")
        if i < 0 then path
        else path.Substring(0, i) + ext

    let private GetExtension (path: string) =
        let i = path.LastIndexOf(".")
        if i < 0 then ""
        else path.Substring(i)
        
    let private normalizePath (path: string) =
        path.Replace('\\', '/')
    
    /// Checks if path starts with "./", ".\" or ".."
    let private isRelativePath (path: string) =
        let len = path.Length
        if len = 0
        then false
        elif path.[0] = '.' then
            if len = 1
            then true
            // Some folders start with a dot, see #1599
            // For simplicity, ignore folders starting with TWO dots
            else match path.[1] with
                    | '/' | '\\' | '.' -> true
                    | _ -> false
        else false
        
    /// Creates a relative path from one file or folder to another. 
    let private getRelativeFileOrDirPath fromIsDir fromFullPath toIsDir toFullPath = 
         // Algorithm adapted from http://stackoverflow.com/a/6244188 
         let pathDifference (path1: string) (path2: string) = 
             let mutable c = 0  //index up to which the paths are the same 
             let mutable d = -1 //index of trailing slash for the portion where the paths are the s 
             while c < path1.Length && c < path2.Length && path1.[c] = path2.[c] do 
                 if path1.[c] = '/' then d <- c 
                 c <- c + 1 
             if c = 0 
             then path2 
             elif c = path1.Length && c = path2.Length 
             then "" 
             else 
                 let mutable builder = "" 
                 while c < path1.Length do 
                     if path1.[c] = '/' then builder <- builder + "../" 
                     c <- c + 1 
                 if builder.Length = 0 && path2.Length - 1 = d 
                 then "./" 
                 else builder + path2.Substring(d + 1) 
         // Add a dummy file to make it work correctly with dirs 
         let addDummyFile isDir path = 
             if isDir 
             then Combine (path, dummyFile) 
             else path 
         // Normalizing shouldn't be necessary at this stage but just in case 
         let fromFullPath = normalizePath fromFullPath 
         let toFullPath = normalizePath toFullPath 
         let fromPath = addDummyFile fromIsDir fromFullPath 
         let toPath = addDummyFile toIsDir toFullPath 
         match (pathDifference fromPath toPath).Replace(dummyFile, "") with 
         | "" -> "." 
         | path -> path 

    let getRelativePath (fromFullPath,toFullPath) = 
         // This is not 100% reliable, but IO.Directory.Exists doesn't 
         // work either if the directory doesn't exist (e.g. `outDir`) 
         let isDir = GetExtension >> System.String.IsNullOrWhiteSpace 
         // let isDir = IO.Directory.Exists 
         getRelativeFileOrDirPath (isDir fromFullPath) fromFullPath (isDir toFullPath) toFullPath
         
         
    type MappingComparer() =
      interface IComparer<Mapping> with
        member _.Compare(a,b) = compareByGeneratedPositionsInflated a b
        