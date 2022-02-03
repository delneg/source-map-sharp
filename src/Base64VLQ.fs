namespace SourceMapSharp

open System
#if !FABLE_COMPILER
open System.IO
open System.Runtime.Serialization
#endif

// Original C# Code
// https://github.com/madskristensen/WebEssentials2013/blob/96d37799/EditorExtensions/Shared/Helpers/Base64VLQ.cs
[<Serializable>]
type VlqException() =
    inherit Exception()
    new(message : string) = 
        (VlqException ())
        then
            ()
    new(message : string, innerException : Exception) = 
        (VlqException ())
        then
            ()
#if !FABLE_COMPILER
    new(info : SerializationInfo, context : StreamingContext) = 
        (VlqException ())
        then
            ()
#endif

module Base64 =
    let intToCharMap = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".ToCharArray()
    let base64Encode(c:int) =
        if (0 <= c && c < intToCharMap.Length) then
            intToCharMap.[c]
        else
           #if FABLE_COMPILER
           failwith $"Must be between 0 and 63: {c}"
           #else
           raise (VlqException("Must be between 0 and 63: " + string c) :> System.Exception)
           #endif
           
           
    let base64Decode(c: char) =
        let index = Array.IndexOf(intToCharMap,c)
        if index > -1 then index
        else
            #if FABLE_COMPILER
           failwith $"Not a valid base 64 digit: {c}"
           #else
            raise (VlqException("Not a valid base 64 digit: " + string c))
           #endif
           

type Base64Vlq() =
    // A single base 64 digit can contain 6 bits of data. For the base 64 variable
    // length quantities we use in the source map spec, the first bit is the sign,
    // the next four bits are the actual value, and the 6th bit is the
    // continuation bit. The continuation bit tells us whether there are more
    // digits in this value following this digit.
    //
    //   Continuation
    //   |    Sign
    //   |    |
    //   V    V
    //   101011
    static member VLQ_BASE_SHIFT = 5
    // binary: 100000
    static member VLQ_BASE = 1 <<< Base64Vlq.VLQ_BASE_SHIFT
    // binary: 011111
    static member VLQ_BASE_MASK = Base64Vlq.VLQ_BASE - 1
    // binary: 100000
    static member VLQ_CONTINUATION_BIT = Base64Vlq.VLQ_BASE

    static member private IsMappingSeparator(ch : int) = 
        ch = (int ',') || ch = (int ';')

#if !FABLE_COMPILER
    static member private GetName(index : int, basePath : string, sources : string[]) = 
        if sources.Length = 0
        then Some (String.Empty)
        elif sources.Length > index
        then Some (Path.GetFullPath (Path.Combine (basePath, sources.[index])))
        else None
#endif

    // Converts from a two-complement value to a value where the sign bit is
    // placed in the least significant bit.  For example, as decimals:
    //   1 becomes 2 (10 binary), -1 becomes 3 (11 binary)
    //   2 becomes 4 (100 binary), -2 becomes 5 (101 binary)
    static member private ToVLQSigned(value : int) = 
        if value < 0
        then (-value <<< 1) + 1
        else (value <<< 1) + 0

    // Converts to a two-complement value from a value where the sign bit is
    // is placed in the least significant bit.  For example, as decimals:
    //   2 (10 binary) becomes 1, 3 (11 binary) becomes -1
    //   4 (100 binary) becomes 2, 5 (101 binary) becomes -2
    static member private FromVLQSigned(value : int) = 
        let mutable isNegative = value &&& 1 = 1
        let mutable shifted = value >>> 1
        if isNegative
        then -shifted
        else shifted

    static member Encode(number : int) = 
        let mutable encoded = new System.Text.StringBuilder()
        let mutable (digit : int) = Unchecked.defaultof<int>
        let mutable vlq = Base64Vlq.ToVLQSigned (number)
        // isZeroCase is needed because F# doesn't have 'do {} while'
        let mutable isZeroCase = number = 0
        while vlq > 0 || isZeroCase do
            isZeroCase <- false
            digit <- vlq &&& Base64Vlq.VLQ_BASE_MASK
            vlq <- vlq >>> Base64Vlq.VLQ_BASE_SHIFT
            if vlq > 0 then
                // There are still more digits in this value, so we must make sure the
                // continuation bit is marked.
                digit <- digit ||| Base64Vlq.VLQ_CONTINUATION_BIT
            encoded.Append(Base64.base64Encode(digit)) |> ignore
        encoded.ToString ()

#if !FABLE_COMPILER
    static member VlqDecode(stream : TextReader) = 
        let mutable result = 0
        let mutable shift = 0
        let mutable continuation = true
        let mutable (digit : int) = 0
        while continuation do
            if stream.Peek() = -1 then
                raise (VlqException("Expected more digits in base 64 VLQ value."))
            digit <- Base64.base64Decode(char (stream.Read()))
            continuation <- (digit &&& Base64Vlq.VLQ_CONTINUATION_BIT) <> 0
            digit <- digit &&& Base64Vlq.VLQ_BASE_MASK
            result <- result + (digit <<< shift)
            shift <- shift + Base64Vlq.VLQ_BASE_SHIFT
        Base64Vlq.FromVLQSigned (result)
#endif
