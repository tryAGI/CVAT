
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Attribute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.InputTypeEnum), TypeInfoPropertyName = "InputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelType), TypeInfoPropertyName = "LabelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Label))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Attribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Sublabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Sublabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedLabelList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Label>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.SublabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SublabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelsListType), TypeInfoPropertyName = "LabelsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.InputTypeEnum?), TypeInfoPropertyName = "NullableInputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelType?), TypeInfoPropertyName = "NullableLabelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelsListType?), TypeInfoPropertyName = "NullableLabelsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Attribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Sublabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Label>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SublabelRequest>))]
    internal sealed partial class LabelsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LabelsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LabelsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private LabelsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::CVAT.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::CVAT.InputTypeEnum)

                    || typeToConvert == typeof(global::CVAT.InputTypeEnum?)

                    || typeToConvert == typeof(global::CVAT.LabelType)

                    || typeToConvert == typeof(global::CVAT.LabelType?)

                    || typeToConvert == typeof(global::CVAT.LabelsListType)

                    || typeToConvert == typeof(global::CVAT.LabelsListType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::CVAT.InputTypeEnum))
                {
                    return new global::CVAT.JsonConverters.InputTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.InputTypeEnum?))
                {
                    return new global::CVAT.JsonConverters.InputTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LabelType))
                {
                    return new global::CVAT.JsonConverters.LabelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LabelType?))
                {
                    return new global::CVAT.JsonConverters.LabelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LabelsListType))
                {
                    return new global::CVAT.JsonConverters.LabelsListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LabelsListType?))
                {
                    return new global::CVAT.JsonConverters.LabelsListTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new LabelsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}