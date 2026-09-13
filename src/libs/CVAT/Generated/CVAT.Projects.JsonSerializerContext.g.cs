
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.BasicUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.InputTypeEnum), TypeInfoPropertyName = "InputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RqId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.DatasetFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelType), TypeInfoPropertyName = "LabelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Storage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LocationEnum), TypeInfoPropertyName = "LocationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedProjectReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.ProjectRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.SublabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SublabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedProjectWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.StorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsListStatus), TypeInfoPropertyName = "ProjectsListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateBackupExportLocation), TypeInfoPropertyName = "ProjectsCreateBackupExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateDatasetLocation), TypeInfoPropertyName = "ProjectsCreateDatasetLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateDatasetExportLocation), TypeInfoPropertyName = "ProjectsCreateDatasetExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateBackupLocation), TypeInfoPropertyName = "ProjectsCreateBackupLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.InputTypeEnum?), TypeInfoPropertyName = "NullableInputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelType?), TypeInfoPropertyName = "NullableLabelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobStatus?), TypeInfoPropertyName = "NullableJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LocationEnum?), TypeInfoPropertyName = "NullableLocationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsListStatus?), TypeInfoPropertyName = "NullableProjectsListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateBackupExportLocation?), TypeInfoPropertyName = "NullableProjectsCreateBackupExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateDatasetLocation?), TypeInfoPropertyName = "NullableProjectsCreateDatasetLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateDatasetExportLocation?), TypeInfoPropertyName = "NullableProjectsCreateDatasetExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateBackupLocation?), TypeInfoPropertyName = "NullableProjectsCreateBackupLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.ProjectRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SublabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.PatchedLabelRequest>))]
    internal sealed partial class ProjectsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::CVAT.JobStatus)

                    || typeToConvert == typeof(global::CVAT.JobStatus?)

                    || typeToConvert == typeof(global::CVAT.LabelType)

                    || typeToConvert == typeof(global::CVAT.LabelType?)

                    || typeToConvert == typeof(global::CVAT.LocationEnum)

                    || typeToConvert == typeof(global::CVAT.LocationEnum?)

                    || typeToConvert == typeof(global::CVAT.ProjectsListStatus)

                    || typeToConvert == typeof(global::CVAT.ProjectsListStatus?)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateBackupExportLocation)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateBackupExportLocation?)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateDatasetLocation)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateDatasetLocation?)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateDatasetExportLocation)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateDatasetExportLocation?)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateBackupLocation)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateBackupLocation?);
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

                if (typeToConvert == typeof(global::CVAT.JobStatus))
                {
                    return new global::CVAT.JsonConverters.JobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobStatus?))
                {
                    return new global::CVAT.JsonConverters.JobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LabelType))
                {
                    return new global::CVAT.JsonConverters.LabelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LabelType?))
                {
                    return new global::CVAT.JsonConverters.LabelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LocationEnum))
                {
                    return new global::CVAT.JsonConverters.LocationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LocationEnum?))
                {
                    return new global::CVAT.JsonConverters.LocationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ProjectsListStatus))
                {
                    return new global::CVAT.JsonConverters.ProjectsListStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ProjectsListStatus?))
                {
                    return new global::CVAT.JsonConverters.ProjectsListStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ProjectsCreateBackupExportLocation))
                {
                    return new global::CVAT.JsonConverters.ProjectsCreateBackupExportLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ProjectsCreateBackupExportLocation?))
                {
                    return new global::CVAT.JsonConverters.ProjectsCreateBackupExportLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ProjectsCreateDatasetLocation))
                {
                    return new global::CVAT.JsonConverters.ProjectsCreateDatasetLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ProjectsCreateDatasetLocation?))
                {
                    return new global::CVAT.JsonConverters.ProjectsCreateDatasetLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ProjectsCreateDatasetExportLocation))
                {
                    return new global::CVAT.JsonConverters.ProjectsCreateDatasetExportLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ProjectsCreateDatasetExportLocation?))
                {
                    return new global::CVAT.JsonConverters.ProjectsCreateDatasetExportLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ProjectsCreateBackupLocation))
                {
                    return new global::CVAT.JsonConverters.ProjectsCreateBackupLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ProjectsCreateBackupLocation?))
                {
                    return new global::CVAT.JsonConverters.ProjectsCreateBackupLocationNullableJsonConverter();
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
                    0 => new ProjectsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}