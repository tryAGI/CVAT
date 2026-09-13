
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ShapeType2), TypeInfoPropertyName = "ShapeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.NullEnum), TypeInfoPropertyName = "NullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.InputTypeEnum), TypeInfoPropertyName = "InputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.DataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.StorageMethod), TypeInfoPropertyName = "StorageMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SortingMethod), TypeInfoPropertyName = "SortingMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ValidationParamsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.DataResponse), TypeInfoPropertyName = "DataResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RqId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FrameSelectionMethod), TypeInfoPropertyName = "FrameSelectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelType), TypeInfoPropertyName = "LabelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Storage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsSummary))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedTaskReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.TaskRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TaskRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedDataMetaWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.SublabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SublabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedLabeledDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.StorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedTaskValidationLayoutWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedTaskWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RqStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RqStatusStateEnum), TypeInfoPropertyName = "RqStatusStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TaskFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TaskValidationLayoutRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ValidationMode?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfValidationModeNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ValidationMode), TypeInfoPropertyName = "ValidationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TaskWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListDimension), TypeInfoPropertyName = "TasksListDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListMediaType), TypeInfoPropertyName = "TasksListMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListMode), TypeInfoPropertyName = "TasksListMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListStatus), TypeInfoPropertyName = "TasksListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListValidationMode), TypeInfoPropertyName = "TasksListValidationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateAnnotationsImportMode), TypeInfoPropertyName = "TasksCreateAnnotationsImportMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateAnnotationsLocation), TypeInfoPropertyName = "TasksCreateAnnotationsLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksPartialUpdateAnnotationsAction), TypeInfoPropertyName = "TasksPartialUpdateAnnotationsAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateBackupExportLocation), TypeInfoPropertyName = "TasksCreateBackupExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksRetrieveDataQuality), TypeInfoPropertyName = "TasksRetrieveDataQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksRetrieveDataType), TypeInfoPropertyName = "TasksRetrieveDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateDatasetExportLocation), TypeInfoPropertyName = "TasksCreateDatasetExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateBackupLocation), TypeInfoPropertyName = "TasksCreateBackupLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ShapeType2?), TypeInfoPropertyName = "NullableShapeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.NullEnum?), TypeInfoPropertyName = "NullableNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.InputTypeEnum?), TypeInfoPropertyName = "NullableInputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ChunkType?), TypeInfoPropertyName = "NullableChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.StorageType?), TypeInfoPropertyName = "NullableStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.StorageMethod?), TypeInfoPropertyName = "NullableStorageMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SortingMethod?), TypeInfoPropertyName = "NullableSortingMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.DataResponse?), TypeInfoPropertyName = "NullableDataResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FrameSelectionMethod?), TypeInfoPropertyName = "NullableFrameSelectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelType?), TypeInfoPropertyName = "NullableLabelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobStatus?), TypeInfoPropertyName = "NullableJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LocationEnum?), TypeInfoPropertyName = "NullableLocationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RqStatusStateEnum?), TypeInfoPropertyName = "NullableRqStatusStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ValidationMode?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfValidationModeNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ValidationMode?), TypeInfoPropertyName = "NullableValidationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListDimension?), TypeInfoPropertyName = "NullableTasksListDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListMediaType?), TypeInfoPropertyName = "NullableTasksListMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListMode?), TypeInfoPropertyName = "NullableTasksListMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListStatus?), TypeInfoPropertyName = "NullableTasksListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListValidationMode?), TypeInfoPropertyName = "NullableTasksListValidationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateAnnotationsImportMode?), TypeInfoPropertyName = "NullableTasksCreateAnnotationsImportMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateAnnotationsLocation?), TypeInfoPropertyName = "NullableTasksCreateAnnotationsLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksPartialUpdateAnnotationsAction?), TypeInfoPropertyName = "NullableTasksPartialUpdateAnnotationsAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateBackupExportLocation?), TypeInfoPropertyName = "NullableTasksCreateBackupExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksRetrieveDataQuality?), TypeInfoPropertyName = "NullableTasksRetrieveDataQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksRetrieveDataType?), TypeInfoPropertyName = "NullableTasksRetrieveDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateDatasetExportLocation?), TypeInfoPropertyName = "NullableTasksCreateDatasetExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateBackupLocation?), TypeInfoPropertyName = "NullableTasksCreateBackupLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeValRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Chapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FrameMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.TaskRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SublabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.PatchedLabelRequest>))]
    internal sealed partial class TasksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TasksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TasksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TasksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::CVAT.JsonConverters.DataResponseJsonConverter());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ShapeType2?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ValidationMode?, global::CVAT.NullEnum?>());
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

                    || typeToConvert == typeof(global::CVAT.InputTypeEnum)

                    || typeToConvert == typeof(global::CVAT.InputTypeEnum?)

                    || typeToConvert == typeof(global::CVAT.JobStatus)

                    || typeToConvert == typeof(global::CVAT.JobStatus?)

                    || typeToConvert == typeof(global::CVAT.LabelType)

                    || typeToConvert == typeof(global::CVAT.LabelType?)

                    || typeToConvert == typeof(global::CVAT.LocationEnum)

                    || typeToConvert == typeof(global::CVAT.LocationEnum?)

                    || typeToConvert == typeof(global::CVAT.NullEnum)

                    || typeToConvert == typeof(global::CVAT.NullEnum?)

                    || typeToConvert == typeof(global::CVAT.RqStatusStateEnum)

                    || typeToConvert == typeof(global::CVAT.RqStatusStateEnum?)

                    || typeToConvert == typeof(global::CVAT.ShapeType2)

                    || typeToConvert == typeof(global::CVAT.ShapeType2?)

                    || typeToConvert == typeof(global::CVAT.SortingMethod)

                    || typeToConvert == typeof(global::CVAT.SortingMethod?)

                    || typeToConvert == typeof(global::CVAT.StorageMethod)

                    || typeToConvert == typeof(global::CVAT.StorageMethod?)

                    || typeToConvert == typeof(global::CVAT.StorageType)

                    || typeToConvert == typeof(global::CVAT.StorageType?)

                    || typeToConvert == typeof(global::CVAT.ValidationMode)

                    || typeToConvert == typeof(global::CVAT.ValidationMode?)

                    || typeToConvert == typeof(global::CVAT.TasksListDimension)

                    || typeToConvert == typeof(global::CVAT.TasksListDimension?)

                    || typeToConvert == typeof(global::CVAT.TasksListMediaType)

                    || typeToConvert == typeof(global::CVAT.TasksListMediaType?)

                    || typeToConvert == typeof(global::CVAT.TasksListMode)

                    || typeToConvert == typeof(global::CVAT.TasksListMode?)

                    || typeToConvert == typeof(global::CVAT.TasksListStatus)

                    || typeToConvert == typeof(global::CVAT.TasksListStatus?)

                    || typeToConvert == typeof(global::CVAT.TasksListValidationMode)

                    || typeToConvert == typeof(global::CVAT.TasksListValidationMode?)

                    || typeToConvert == typeof(global::CVAT.TasksCreateAnnotationsImportMode)

                    || typeToConvert == typeof(global::CVAT.TasksCreateAnnotationsImportMode?)

                    || typeToConvert == typeof(global::CVAT.TasksCreateAnnotationsLocation)

                    || typeToConvert == typeof(global::CVAT.TasksCreateAnnotationsLocation?)

                    || typeToConvert == typeof(global::CVAT.TasksPartialUpdateAnnotationsAction)

                    || typeToConvert == typeof(global::CVAT.TasksPartialUpdateAnnotationsAction?)

                    || typeToConvert == typeof(global::CVAT.TasksCreateBackupExportLocation)

                    || typeToConvert == typeof(global::CVAT.TasksCreateBackupExportLocation?)

                    || typeToConvert == typeof(global::CVAT.TasksRetrieveDataQuality)

                    || typeToConvert == typeof(global::CVAT.TasksRetrieveDataQuality?)

                    || typeToConvert == typeof(global::CVAT.TasksRetrieveDataType)

                    || typeToConvert == typeof(global::CVAT.TasksRetrieveDataType?)

                    || typeToConvert == typeof(global::CVAT.TasksCreateDatasetExportLocation)

                    || typeToConvert == typeof(global::CVAT.TasksCreateDatasetExportLocation?)

                    || typeToConvert == typeof(global::CVAT.TasksCreateBackupLocation)

                    || typeToConvert == typeof(global::CVAT.TasksCreateBackupLocation?);
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

                if (typeToConvert == typeof(global::CVAT.NullEnum))
                {
                    return new global::CVAT.JsonConverters.NullEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.NullEnum?))
                {
                    return new global::CVAT.JsonConverters.NullEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.RqStatusStateEnum))
                {
                    return new global::CVAT.JsonConverters.RqStatusStateEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.RqStatusStateEnum?))
                {
                    return new global::CVAT.JsonConverters.RqStatusStateEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ShapeType2))
                {
                    return new global::CVAT.JsonConverters.ShapeType2JsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ShapeType2?))
                {
                    return new global::CVAT.JsonConverters.ShapeType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.SortingMethod))
                {
                    return new global::CVAT.JsonConverters.SortingMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.SortingMethod?))
                {
                    return new global::CVAT.JsonConverters.SortingMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.StorageMethod))
                {
                    return new global::CVAT.JsonConverters.StorageMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.StorageMethod?))
                {
                    return new global::CVAT.JsonConverters.StorageMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.StorageType))
                {
                    return new global::CVAT.JsonConverters.StorageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.StorageType?))
                {
                    return new global::CVAT.JsonConverters.StorageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ValidationMode))
                {
                    return new global::CVAT.JsonConverters.ValidationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ValidationMode?))
                {
                    return new global::CVAT.JsonConverters.ValidationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksListDimension))
                {
                    return new global::CVAT.JsonConverters.TasksListDimensionJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksListDimension?))
                {
                    return new global::CVAT.JsonConverters.TasksListDimensionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksListMediaType))
                {
                    return new global::CVAT.JsonConverters.TasksListMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksListMediaType?))
                {
                    return new global::CVAT.JsonConverters.TasksListMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksListMode))
                {
                    return new global::CVAT.JsonConverters.TasksListModeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksListMode?))
                {
                    return new global::CVAT.JsonConverters.TasksListModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksListStatus))
                {
                    return new global::CVAT.JsonConverters.TasksListStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksListStatus?))
                {
                    return new global::CVAT.JsonConverters.TasksListStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksListValidationMode))
                {
                    return new global::CVAT.JsonConverters.TasksListValidationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksListValidationMode?))
                {
                    return new global::CVAT.JsonConverters.TasksListValidationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksCreateAnnotationsImportMode))
                {
                    return new global::CVAT.JsonConverters.TasksCreateAnnotationsImportModeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksCreateAnnotationsImportMode?))
                {
                    return new global::CVAT.JsonConverters.TasksCreateAnnotationsImportModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksCreateAnnotationsLocation))
                {
                    return new global::CVAT.JsonConverters.TasksCreateAnnotationsLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksCreateAnnotationsLocation?))
                {
                    return new global::CVAT.JsonConverters.TasksCreateAnnotationsLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksPartialUpdateAnnotationsAction))
                {
                    return new global::CVAT.JsonConverters.TasksPartialUpdateAnnotationsActionJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksPartialUpdateAnnotationsAction?))
                {
                    return new global::CVAT.JsonConverters.TasksPartialUpdateAnnotationsActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksCreateBackupExportLocation))
                {
                    return new global::CVAT.JsonConverters.TasksCreateBackupExportLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksCreateBackupExportLocation?))
                {
                    return new global::CVAT.JsonConverters.TasksCreateBackupExportLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksRetrieveDataQuality))
                {
                    return new global::CVAT.JsonConverters.TasksRetrieveDataQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksRetrieveDataQuality?))
                {
                    return new global::CVAT.JsonConverters.TasksRetrieveDataQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksRetrieveDataType))
                {
                    return new global::CVAT.JsonConverters.TasksRetrieveDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksRetrieveDataType?))
                {
                    return new global::CVAT.JsonConverters.TasksRetrieveDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksCreateDatasetExportLocation))
                {
                    return new global::CVAT.JsonConverters.TasksCreateDatasetExportLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksCreateDatasetExportLocation?))
                {
                    return new global::CVAT.JsonConverters.TasksCreateDatasetExportLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksCreateBackupLocation))
                {
                    return new global::CVAT.JsonConverters.TasksCreateBackupLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.TasksCreateBackupLocation?))
                {
                    return new global::CVAT.JsonConverters.TasksCreateBackupLocationNullableJsonConverter();
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
                    0 => new TasksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}