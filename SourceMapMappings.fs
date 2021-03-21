namespace SourceMapSharp

open SourceMapSharp

// Translation of Rust code from https://github.com/fitzgen/source-map-mappings
[<RequireQualifiedAccess>]
module SourceMapMappings =
  /// When doing fuzzy searching, whether to slide the next larger or next smaller
  /// mapping from the queried location.
  type Bias =
    // XXX: make sure these values always match `mozilla/source-map`'s
    // `SourceMapConsumer.{GreatestLower,LeastUpper}Bound` values!
    /// Slide to the next smaller mapping.
    | GreatestLowerBound
    /// Slide to the next larger mapping.
    | LeastUpperBound
  with static member Default = Bias.GreatestLowerBound
    
    /// Errors that can occur during parsing.
  type Error =
    // NB: 0 is reserved for OK.
    /// The mappings contained a negative line, column, source index, or name
    /// index.
    | UnexpectedNegativeNumber = 1u
    /// The mappings contained a number larger than `u32::MAX`.
    | UnexpectedlyBigNumber = 2u
    /// Reached EOF while in the middle of parsing a VLQ.
    | VlqUnexpectedEof = 3u
    /// Encountered an invalid base 64 character while parsing a VLQ.
    | VlqInvalidBase64 = 4u
    /// VLQ encountered a number that, when decoded, would not fit in as i64
    | VlqOverflow = 5u
   
   /// Original location information within a mapping.
  ///
  /// Contains a source filename, an original line, and an original column. Might
  /// also contain an associated name.
   type OriginalLocation = {
     source: uint32
     original_line: uint32
     original_column: uint32
     name: uint32 option
   }
   /// A single bidirectional mapping.
   /// Always contains generated location information.
   /// Might contain original location information, and if so, might also have an
   /// associated name.
   
  type Mapping = {
    mutable generated_line: uint32
    mutable generated_column: uint32
    /// The end column of this mapping's generated location span.
    ///
    /// Before `Mappings::computed_column_spans` has been called, this is always
    /// `None`. After `Mappings::computed_column_spans` has been called, it
    /// either contains `Some` column at which the generated location ends
    /// (exclusive), or it contains `None` if it spans until the end of the
    /// generated line.
    last_generated_column: uint32 option
    original: OriginalLocation option
  } with static member Default = { generated_line = 0u; generated_column=0u; last_generated_column=None; original=None}
   
  type Mappings = {
     by_generated: Mapping array
     computed_column_spans: bool
     // The `by_original` field maps source index to mappings within that
     // original source. This lets us essentially do bucket sort on a per-source
     // basis, and also enables lazily sorting different source's mappings.
     by_original: (Mapping array) option
  } with static member Default = { by_generated = Array.empty; computed_column_spans=false; by_original=None}
   
  type MappingCallback =
       // These two parameters are always valid.
       (*generated_line*)uint32 ->
       (*generated_column*)uint32 ->
       // The `last_generated_column` parameter is only valid if
       // `has_last_generated_column` is `true`.
       (*has_last_generated_column*)bool ->
       (*last_generated_column*)uint32 ->
           // The `source`, `original_line`, and `original_column` parameters are
          // only valid if `has_original` is `true`.
          (*has_original*)bool -> (*source*) uint32 -> (*original_line*) uint32 -> (*original_column*) uint32 ->
              // The `name` parameter is only valid if `has_name` is `true`.
              (*has_name*) bool -> (*name*) uint32
  
  let inline is_mapping_separator(byte: char) :bool = byte = ';' || byte = ','
  
  let inline map_or(def, fn) (value: 't option) =
    match value with
    |Some x -> fn x
    |None -> def
    
  let inline read_relative_vlq(previous,input) =
    let decoded = Base64Vlq.VlqDecode(input)
    let (n,overflowed) = 
  let invoke_mapping_callback (mapping:Mapping) =
      let generated_line = mapping.generated_line
      let generated_column = mapping.generated_column
      let (has_last_generated_column,last_generated_column) =
        match mapping.last_generated_column with
        | Some x -> (true, x)
        | None -> (false, 0u)
      let (has_original, source,original_line, original_column, has_name, name) =
        if mapping.original.IsSome then
          let original = mapping.original.Value
          let (has_name, name) =
            match original.name with
            | Some y -> (true, y)
            | None -> (false,0u)
          (true, original.source, original.original_line, original.original_column, has_name, name)
        else
          (false, 0u, 0u, 0u, false, 0u)
      
      (
        generated_line,
        generated_column,
        has_last_generated_column,
        last_generated_column,
        has_original,
        source,
        original_line,
        original_column,
        has_name,
        name
     )
  let parse_mappings(input: string) : Result<Mappings,Error> =
      let mutable generated_line = 0u
      let mutable generated_column = 0u
      let mutable original_line = 0u
      let mutable original_column = 0u
      let mutable source = 0u
      let mutable name = 0u
      let mutable generated_line_start_index = 0u
      let mutable mappings = Mappings.Default
      // `input.len() / 2` is the upper bound on how many mappings the string
      // might contain. There would be some sequence like `A,A,A,...` or
      // `A;A;A;...`.
      let mutable by_generated: Mapping array = Array.empty
      input |> String.iteri (fun i (b) ->
        let chrs = input.ToCharArray()
        match b with
        | ',' -> ()
        | _ ->
          let mutable mapping = Mapping.Default
          mapping.generated_line <- generated_line
          // First is a generated column that is always present.
//          read_relative_vlq(&mut generated_column, &mut input)?;
//          mapping.generated_column = generated_column as u32;
          let m =  Array.tryItem (i+1) chrs
          if m |> map_or(true, is_mapping_separator)
          then None
          else
            
          
        ()
      )
      if generated_line_start_index < uint32 by_generated.LongLength then
        //by_generated[generated_line_start_index..].sort_unstable_by(comparators::ByGeneratedTail::compare);
        ()
      Result.Ok {mappings with by_generated = by_generated}