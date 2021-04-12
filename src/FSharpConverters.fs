// https://gist.github.com/mbuhot/c224f15e0266adf5ba8ca4e882f88a75

namespace System.Text.Json

#if !FABLE_COMPILER

open System
open System.Collections.Generic
open System.Text.Json.Serialization

// Converts Option<T> to/from JSON by projecting to null or T
type OptionValueConverter<'T>() =
    inherit JsonConverter<'T option>()

    override this.Read (reader: byref<Utf8JsonReader>, _typ: Type, options: JsonSerializerOptions) =
        match reader.TokenType with
        | JsonTokenType.Null -> None
        | _ -> Some <| JsonSerializer.Deserialize<'T>(&reader, options)

    override this.Write (writer: Utf8JsonWriter, value: 'T option, options: JsonSerializerOptions) =
        match value with
        | None -> writer.WriteNullValue ()
        | Some value -> JsonSerializer.Serialize(writer, value, options)

// Instantiates the correct OptionValueConverter<T>
type OptionConverter() =
    inherit JsonConverterFactory()
        override this.CanConvert(t: Type) : bool =
            t.IsGenericType &&
            t.GetGenericTypeDefinition() = typedefof<Option<_>>

        override this.CreateConverter(typeToConvert: Type,
                                      _options: JsonSerializerOptions) : JsonConverter =
            let typ = typeToConvert.GetGenericArguments() |> Array.head
            let converterType = typedefof<OptionValueConverter<_>>.MakeGenericType(typ)
            Activator.CreateInstance(converterType) :?> JsonConverter

// Converts Map<K,V> to/from JSON by projecting to Dictionary<K,V>
type MapValueConverter<'K, 'V when 'K : comparison>() =
    inherit JsonConverter<Map<'K, 'V>>()

    override this.Read (reader: byref<Utf8JsonReader>, _typ: Type, options: JsonSerializerOptions) =
        JsonSerializer.Deserialize<System.Collections.Generic.Dictionary<'K, 'V>>(&reader, options)
        |> Seq.map (|KeyValue|)
        |> Map.ofSeq

    override this.Write (writer: Utf8JsonWriter, value: Map<'K, 'V>, options: JsonSerializerOptions) =
        let dictionary = Dictionary<'K, 'V>()
        value |> Map.iter (fun k v -> dictionary.Add(k, v))
        JsonSerializer.Serialize(writer, dictionary, options)

// Instantiates the correct MapValueConverter<T>
type MapConverter() =
    inherit JsonConverterFactory()
        override this.CanConvert(t: Type) : bool =
            t.IsGenericType &&
            List.contains (t.GetGenericTypeDefinition()) [typedefof<Map<_, _>>; typedefof<IDictionary<_,_>>]

        override this.CreateConverter(typeToConvert: Type,
                                      _options: JsonSerializerOptions) : JsonConverter =
            let typArgs = typeToConvert.GetGenericArguments()
            let converterType = typedefof<MapValueConverter<_,_>>.MakeGenericType(typArgs)
            Activator.CreateInstance(converterType) :?> JsonConverter

// Converts List<T> to/from JSON by projecting to IEnumerable<T>
type ListValueConverter<'T>() =
    inherit JsonConverter<'T list>()

    override this.Read (reader: byref<Utf8JsonReader>, _typ: Type, options: JsonSerializerOptions) =
        JsonSerializer.Deserialize<'T seq>(&reader, options)
        |> List.ofSeq

    override this.Write (writer: Utf8JsonWriter, value: 'T list, options: JsonSerializerOptions) =
        JsonSerializer.Serialize(writer, (List.toSeq value), options)

// Instantiates the correct ListValueConverter<T>
type ListConverter() =
    inherit JsonConverterFactory()
        override this.CanConvert(t: Type) : bool =
            t.IsGenericType &&
            List.contains (t.GetGenericTypeDefinition()) [typedefof<list<_>>; typedefof<IReadOnlyCollection<_>>]

        override this.CreateConverter(typeToConvert: Type,
                                      _options: JsonSerializerOptions) : JsonConverter =
            let typArgs = typeToConvert.GetGenericArguments()
            let converterType = typedefof<ListValueConverter<_>>.MakeGenericType(typArgs)
            Activator.CreateInstance(converterType) :?> JsonConverter

module FSharpConverters =
    let Options =
        let opt = JsonSerializerOptions()
        opt.Converters.Add(new OptionConverter()) |> ignore
        opt.Converters.Add(new MapConverter()) |> ignore
        opt.Converters.Add(new ListConverter()) |> ignore
        opt

#endif //!FABLE_COMPILER
