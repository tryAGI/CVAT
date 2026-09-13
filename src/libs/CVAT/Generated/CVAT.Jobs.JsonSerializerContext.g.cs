
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ShapeType2), TypeInfoPropertyName = "ShapeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeVal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeValRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeValRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Chapter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ChapterMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ChunkType), TypeInfoPropertyName = "ChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.DataMetaRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Chapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.FrameMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FrameMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.StorageType), TypeInfoPropertyName = "StorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RqId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FrameSelectionMethod), TypeInfoPropertyName = "FrameSelectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.IssuesSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobStage), TypeInfoPropertyName = "JobStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OperationStatus), TypeInfoPropertyName = "OperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobType), TypeInfoPropertyName = "JobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Storage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationLayoutRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledShape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledInterval>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledImageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledShapeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledTrackRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledTrackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledIntervalRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledIntervalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeVal>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.SubLabeledShape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SubLabeledShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.SubLabeledShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SubLabeledShapeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.TrackedShape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TrackedShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.SubLabeledTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SubLabeledTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.TrackedShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TrackedShapeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.SubLabeledTrackRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SubLabeledTrackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LocationEnum), TypeInfoPropertyName = "LocationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedJobReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.JobRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedJobDataMetaWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedJobValidationLayoutWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedJobWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedLabeledDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListDimension), TypeInfoPropertyName = "JobsListDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListMediaType), TypeInfoPropertyName = "JobsListMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListMode), TypeInfoPropertyName = "JobsListMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListStage), TypeInfoPropertyName = "JobsListStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListState), TypeInfoPropertyName = "JobsListState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListType), TypeInfoPropertyName = "JobsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsRetrieveAnnotationsLocation), TypeInfoPropertyName = "JobsRetrieveAnnotationsLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsCreateAnnotationsImportMode), TypeInfoPropertyName = "JobsCreateAnnotationsImportMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsCreateAnnotationsLocation), TypeInfoPropertyName = "JobsCreateAnnotationsLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsPartialUpdateAnnotationsAction), TypeInfoPropertyName = "JobsPartialUpdateAnnotationsAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsRetrieveDataQuality), TypeInfoPropertyName = "JobsRetrieveDataQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsRetrieveDataType), TypeInfoPropertyName = "JobsRetrieveDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsCreateDatasetExportLocation), TypeInfoPropertyName = "JobsCreateDatasetExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ShapeType2?), TypeInfoPropertyName = "NullableShapeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ChunkType?), TypeInfoPropertyName = "NullableChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.StorageType?), TypeInfoPropertyName = "NullableStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FrameSelectionMethod?), TypeInfoPropertyName = "NullableFrameSelectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobStatus?), TypeInfoPropertyName = "NullableJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobStage?), TypeInfoPropertyName = "NullableJobStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OperationStatus?), TypeInfoPropertyName = "NullableOperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobType?), TypeInfoPropertyName = "NullableJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LocationEnum?), TypeInfoPropertyName = "NullableLocationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListDimension?), TypeInfoPropertyName = "NullableJobsListDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListMediaType?), TypeInfoPropertyName = "NullableJobsListMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListMode?), TypeInfoPropertyName = "NullableJobsListMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListStage?), TypeInfoPropertyName = "NullableJobsListStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListState?), TypeInfoPropertyName = "NullableJobsListState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListType?), TypeInfoPropertyName = "NullableJobsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsRetrieveAnnotationsLocation?), TypeInfoPropertyName = "NullableJobsRetrieveAnnotationsLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsCreateAnnotationsImportMode?), TypeInfoPropertyName = "NullableJobsCreateAnnotationsImportMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsCreateAnnotationsLocation?), TypeInfoPropertyName = "NullableJobsCreateAnnotationsLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsPartialUpdateAnnotationsAction?), TypeInfoPropertyName = "NullableJobsPartialUpdateAnnotationsAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsRetrieveDataQuality?), TypeInfoPropertyName = "NullableJobsRetrieveDataQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsRetrieveDataType?), TypeInfoPropertyName = "NullableJobsRetrieveDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsCreateDatasetExportLocation?), TypeInfoPropertyName = "NullableJobsCreateDatasetExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeValRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Chapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FrameMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledShape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledInterval>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledImageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledTrackRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledIntervalRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeVal>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SubLabeledShape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SubLabeledShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.TrackedShape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SubLabeledTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.TrackedShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SubLabeledTrackRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.JobRead>))]
    internal sealed partial class JobsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JobsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static JobsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private JobsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::CVAT.ChunkType)

                    || typeToConvert == typeof(global::CVAT.ChunkType?)

                    || typeToConvert == typeof(global::CVAT.FrameSelectionMethod)

                    || typeToConvert == typeof(global::CVAT.FrameSelectionMethod?)

                    || typeToConvert == typeof(global::CVAT.JobStage)

                    || typeToConvert == typeof(global::CVAT.JobStage?)

                    || typeToConvert == typeof(global::CVAT.JobStatus)

                    || typeToConvert == typeof(global::CVAT.JobStatus?)

                    || typeToConvert == typeof(global::CVAT.JobType)

                    || typeToConvert == typeof(global::CVAT.JobType?)

                    || typeToConvert == typeof(global::CVAT.LocationEnum)

                    || typeToConvert == typeof(global::CVAT.LocationEnum?)

                    || typeToConvert == typeof(global::CVAT.OperationStatus)

                    || typeToConvert == typeof(global::CVAT.OperationStatus?)

                    || typeToConvert == typeof(global::CVAT.ShapeType2)

                    || typeToConvert == typeof(global::CVAT.ShapeType2?)

                    || typeToConvert == typeof(global::CVAT.StorageType)

                    || typeToConvert == typeof(global::CVAT.StorageType?)

                    || typeToConvert == typeof(global::CVAT.JobsListDimension)

                    || typeToConvert == typeof(global::CVAT.JobsListDimension?)

                    || typeToConvert == typeof(global::CVAT.JobsListMediaType)

                    || typeToConvert == typeof(global::CVAT.JobsListMediaType?)

                    || typeToConvert == typeof(global::CVAT.JobsListMode)

                    || typeToConvert == typeof(global::CVAT.JobsListMode?)

                    || typeToConvert == typeof(global::CVAT.JobsListStage)

                    || typeToConvert == typeof(global::CVAT.JobsListStage?)

                    || typeToConvert == typeof(global::CVAT.JobsListState)

                    || typeToConvert == typeof(global::CVAT.JobsListState?)

                    || typeToConvert == typeof(global::CVAT.JobsListType)

                    || typeToConvert == typeof(global::CVAT.JobsListType?)

                    || typeToConvert == typeof(global::CVAT.JobsRetrieveAnnotationsLocation)

                    || typeToConvert == typeof(global::CVAT.JobsRetrieveAnnotationsLocation?)

                    || typeToConvert == typeof(global::CVAT.JobsCreateAnnotationsImportMode)

                    || typeToConvert == typeof(global::CVAT.JobsCreateAnnotationsImportMode?)

                    || typeToConvert == typeof(global::CVAT.JobsCreateAnnotationsLocation)

                    || typeToConvert == typeof(global::CVAT.JobsCreateAnnotationsLocation?)

                    || typeToConvert == typeof(global::CVAT.JobsPartialUpdateAnnotationsAction)

                    || typeToConvert == typeof(global::CVAT.JobsPartialUpdateAnnotationsAction?)

                    || typeToConvert == typeof(global::CVAT.JobsRetrieveDataQuality)

                    || typeToConvert == typeof(global::CVAT.JobsRetrieveDataQuality?)

                    || typeToConvert == typeof(global::CVAT.JobsRetrieveDataType)

                    || typeToConvert == typeof(global::CVAT.JobsRetrieveDataType?)

                    || typeToConvert == typeof(global::CVAT.JobsCreateDatasetExportLocation)

                    || typeToConvert == typeof(global::CVAT.JobsCreateDatasetExportLocation?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::CVAT.ChunkType))
                {
                    return new global::CVAT.JsonConverters.ChunkTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ChunkType?))
                {
                    return new global::CVAT.JsonConverters.ChunkTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.FrameSelectionMethod))
                {
                    return new global::CVAT.JsonConverters.FrameSelectionMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.FrameSelectionMethod?))
                {
                    return new global::CVAT.JsonConverters.FrameSelectionMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobStage))
                {
                    return new global::CVAT.JsonConverters.JobStageJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobStage?))
                {
                    return new global::CVAT.JsonConverters.JobStageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobStatus))
                {
                    return new global::CVAT.JsonConverters.JobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobStatus?))
                {
                    return new global::CVAT.JsonConverters.JobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobType))
                {
                    return new global::CVAT.JsonConverters.JobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobType?))
                {
                    return new global::CVAT.JsonConverters.JobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LocationEnum))
                {
                    return new global::CVAT.JsonConverters.LocationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LocationEnum?))
                {
                    return new global::CVAT.JsonConverters.LocationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.OperationStatus))
                {
                    return new global::CVAT.JsonConverters.OperationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.OperationStatus?))
                {
                    return new global::CVAT.JsonConverters.OperationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ShapeType2))
                {
                    return new global::CVAT.JsonConverters.ShapeType2JsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ShapeType2?))
                {
                    return new global::CVAT.JsonConverters.ShapeType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.StorageType))
                {
                    return new global::CVAT.JsonConverters.StorageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.StorageType?))
                {
                    return new global::CVAT.JsonConverters.StorageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsListDimension))
                {
                    return new global::CVAT.JsonConverters.JobsListDimensionJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsListDimension?))
                {
                    return new global::CVAT.JsonConverters.JobsListDimensionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsListMediaType))
                {
                    return new global::CVAT.JsonConverters.JobsListMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsListMediaType?))
                {
                    return new global::CVAT.JsonConverters.JobsListMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsListMode))
                {
                    return new global::CVAT.JsonConverters.JobsListModeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsListMode?))
                {
                    return new global::CVAT.JsonConverters.JobsListModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsListStage))
                {
                    return new global::CVAT.JsonConverters.JobsListStageJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsListStage?))
                {
                    return new global::CVAT.JsonConverters.JobsListStageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsListState))
                {
                    return new global::CVAT.JsonConverters.JobsListStateJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsListState?))
                {
                    return new global::CVAT.JsonConverters.JobsListStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsListType))
                {
                    return new global::CVAT.JsonConverters.JobsListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsListType?))
                {
                    return new global::CVAT.JsonConverters.JobsListTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsRetrieveAnnotationsLocation))
                {
                    return new global::CVAT.JsonConverters.JobsRetrieveAnnotationsLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsRetrieveAnnotationsLocation?))
                {
                    return new global::CVAT.JsonConverters.JobsRetrieveAnnotationsLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsCreateAnnotationsImportMode))
                {
                    return new global::CVAT.JsonConverters.JobsCreateAnnotationsImportModeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsCreateAnnotationsImportMode?))
                {
                    return new global::CVAT.JsonConverters.JobsCreateAnnotationsImportModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsCreateAnnotationsLocation))
                {
                    return new global::CVAT.JsonConverters.JobsCreateAnnotationsLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsCreateAnnotationsLocation?))
                {
                    return new global::CVAT.JsonConverters.JobsCreateAnnotationsLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsPartialUpdateAnnotationsAction))
                {
                    return new global::CVAT.JsonConverters.JobsPartialUpdateAnnotationsActionJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsPartialUpdateAnnotationsAction?))
                {
                    return new global::CVAT.JsonConverters.JobsPartialUpdateAnnotationsActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsRetrieveDataQuality))
                {
                    return new global::CVAT.JsonConverters.JobsRetrieveDataQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsRetrieveDataQuality?))
                {
                    return new global::CVAT.JsonConverters.JobsRetrieveDataQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsRetrieveDataType))
                {
                    return new global::CVAT.JsonConverters.JobsRetrieveDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsRetrieveDataType?))
                {
                    return new global::CVAT.JsonConverters.JobsRetrieveDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsCreateDatasetExportLocation))
                {
                    return new global::CVAT.JsonConverters.JobsCreateDatasetExportLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobsCreateDatasetExportLocation?))
                {
                    return new global::CVAT.JsonConverters.JobsCreateDatasetExportLocationNullableJsonConverter();
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
                    0 => new JobsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}