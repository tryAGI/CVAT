
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
            typeof(global::CVAT.JsonConverters.AnnotationConflictAnnotationTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.AnnotationConflictAnnotationTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.AnnotationConflictSeverityJsonConverter),

            typeof(global::CVAT.JsonConverters.AnnotationConflictSeverityNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.AnnotationConflictTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.AnnotationConflictTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.ChunkTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.ChunkTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.CredentialsTypeEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.CredentialsTypeEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.EventsEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.EventsEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.FileInfoTypeEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.FileInfoTypeEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.FrameSelectionMethodJsonConverter),

            typeof(global::CVAT.JsonConverters.FrameSelectionMethodNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.InputTypeEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.InputTypeEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobStageJsonConverter),

            typeof(global::CVAT.JsonConverters.JobStageNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobStatusJsonConverter),

            typeof(global::CVAT.JsonConverters.JobStatusNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.JobTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobValidationStatusEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.JobValidationStatusEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.KindEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.KindEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.LabelTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.LabelTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.LimitTypeEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.LimitTypeEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.LocationEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.LocationEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.OperationStatusJsonConverter),

            typeof(global::CVAT.JsonConverters.OperationStatusNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.ProviderTypeEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.ProviderTypeEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityPointSizeBaseJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityPointSizeBaseNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityReportTargetJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityReportTargetNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityTargetMetricJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityTargetMetricNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.RequestCategoryEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.RequestCategoryEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.RequestStatusJsonConverter),

            typeof(global::CVAT.JsonConverters.RequestStatusNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.RoleEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.RoleEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.RqStatusStateEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.RqStatusStateEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.SelectionSchemaEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.SelectionSchemaEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.ShapeType2JsonConverter),

            typeof(global::CVAT.JsonConverters.ShapeType2NullableJsonConverter),

            typeof(global::CVAT.JsonConverters.SortingMethodJsonConverter),

            typeof(global::CVAT.JsonConverters.SortingMethodNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.StorageMethodJsonConverter),

            typeof(global::CVAT.JsonConverters.StorageMethodNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.StorageTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.StorageTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.TypeCcbEnumJsonConverter),

            typeof(global::CVAT.JsonConverters.TypeCcbEnumNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.ValidationModeJsonConverter),

            typeof(global::CVAT.JsonConverters.ValidationModeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.WebhookContentTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.WebhookContentTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.WebhookTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.WebhookTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.CloudstoragesListCredentialsTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.CloudstoragesListCredentialsTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.CloudstoragesListProviderTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.CloudstoragesListProviderTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.EventsListActionJsonConverter),

            typeof(global::CVAT.JsonConverters.EventsListActionNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.EventsCreateExportLocationJsonConverter),

            typeof(global::CVAT.JsonConverters.EventsCreateExportLocationNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsListDimensionJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsListDimensionNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsListStageJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsListStageNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsListStateJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsListStateNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsListTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsListTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsRetrieveAnnotationsLocationJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsRetrieveAnnotationsLocationNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsCreateAnnotationsLocationJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsCreateAnnotationsLocationNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsPartialUpdateAnnotationsActionJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsPartialUpdateAnnotationsActionNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsRetrieveDataQualityJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsRetrieveDataQualityNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsRetrieveDataTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsRetrieveDataTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsCreateDatasetExportLocationJsonConverter),

            typeof(global::CVAT.JsonConverters.JobsCreateDatasetExportLocationNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.LabelsListTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.LabelsListTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.MembershipsListRoleJsonConverter),

            typeof(global::CVAT.JsonConverters.MembershipsListRoleNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.ProjectsListStatusJsonConverter),

            typeof(global::CVAT.JsonConverters.ProjectsListStatusNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.ProjectsCreateBackupExportLocationJsonConverter),

            typeof(global::CVAT.JsonConverters.ProjectsCreateBackupExportLocationNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.ProjectsCreateDatasetLocationJsonConverter),

            typeof(global::CVAT.JsonConverters.ProjectsCreateDatasetLocationNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.ProjectsCreateDatasetExportLocationJsonConverter),

            typeof(global::CVAT.JsonConverters.ProjectsCreateDatasetExportLocationNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.ProjectsCreateBackupLocationJsonConverter),

            typeof(global::CVAT.JsonConverters.ProjectsCreateBackupLocationNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityListConflictsSeverityJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityListConflictsSeverityNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityListConflictsTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityListConflictsTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityListJobValidationsStatusJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityListJobValidationsStatusNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityListReportsTargetJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityListReportsTargetNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityRetrieveReportDataFormatJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityRetrieveReportDataFormatNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityListSettingsParentTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.QualityListSettingsParentTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.RequestsListStatusJsonConverter),

            typeof(global::CVAT.JsonConverters.RequestsListStatusNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.SchemaRetrieveLangJsonConverter),

            typeof(global::CVAT.JsonConverters.SchemaRetrieveLangNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.SchemaRetrieveSchemeJsonConverter),

            typeof(global::CVAT.JsonConverters.SchemaRetrieveSchemeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksListDimensionJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksListDimensionNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksListStatusJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksListStatusNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksListValidationModeJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksListValidationModeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksCreateAnnotationsLocationJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksCreateAnnotationsLocationNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksPartialUpdateAnnotationsActionJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksPartialUpdateAnnotationsActionNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksCreateBackupExportLocationJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksCreateBackupExportLocationNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksRetrieveDataQualityJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksRetrieveDataQualityNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksRetrieveDataTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksRetrieveDataTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksCreateDatasetExportLocationJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksCreateDatasetExportLocationNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksCreateBackupLocationJsonConverter),

            typeof(global::CVAT.JsonConverters.TasksCreateBackupLocationNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.WebhooksListTypeJsonConverter),

            typeof(global::CVAT.JsonConverters.WebhooksListTypeNullableJsonConverter),

            typeof(global::CVAT.JsonConverters.DataResponseJsonConverter),

            typeof(global::CVAT.JsonConverters.MetaUserJsonConverter),

            typeof(global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ShapeType2?, global::CVAT.NullEnum>),

            typeof(global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ValidationMode?, global::CVAT.NullEnum>),

            typeof(global::CVAT.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.About))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AcceptInvitationRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AccessTokenRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.BasicUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AccessTokenWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnalyticsReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportTarget), TypeInfoPropertyName = "QualityReportTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.ReportEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ReportEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AnnotationsStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationsStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictType), TypeInfoPropertyName = "AnnotationConflictType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AnnotationId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictSeverity), TypeInfoPropertyName = "AnnotationConflictSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictAnnotationType), TypeInfoPropertyName = "AnnotationConflictAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationGuideRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationGuideWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ShapeType2?, global::CVAT.NullEnum>), TypeInfoPropertyName = "OneOfShapeType2NullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ShapeType2), TypeInfoPropertyName = "ShapeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.NullEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationRequestFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Count))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ArAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ArParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TypeCcbEnum), TypeInfoPropertyName = "TypeCcbEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelMappingEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Shape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Shape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ArParamsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntryRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelMappingEntryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.ShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ShapeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AssetRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AssetWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Attribute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.InputTypeEnum), TypeInfoPropertyName = "InputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeVal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeValRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.BasicOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.BasicUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Chapter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ChapterMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ChunkType), TypeInfoPropertyName = "ChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ClientEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ClientEventsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.EventRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.EventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CloudStorageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.FileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FileInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CloudStorageRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProviderTypeEnum), TypeInfoPropertyName = "ProviderTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CredentialsTypeEnum), TypeInfoPropertyName = "CredentialsTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CloudStorageWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CommentRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CommentWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CommentsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ConsensusMergeCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ConsensusSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CreateAnalyticsReportBodyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.DataMetaRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Chapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.FrameMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FrameMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.StorageType), TypeInfoPropertyName = "StorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.DataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.StorageMethod), TypeInfoPropertyName = "StorageMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SortingMethod), TypeInfoPropertyName = "SortingMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ValidationParamsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.DataResponse), TypeInfoPropertyName = "DataResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RqId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.DatasetFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.DatasetFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.DatasetFormats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.DatasetFormat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Events))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhookType), TypeInfoPropertyName = "WebhookType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.EventsEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.EventsEnum), TypeInfoPropertyName = "EventsEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FileInfoTypeEnum), TypeInfoPropertyName = "FileInfoTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FrameSelectionMethod), TypeInfoPropertyName = "FrameSelectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.KindEnum), TypeInfoPropertyName = "KindEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.FunctionLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FunctionLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.ShapeType2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FunctionAttribute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FunctionAttributeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FunctionCallParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FunctionCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FunctionIdAndArParamsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelType), TypeInfoPropertyName = "LabelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.FunctionAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.FunctionSublabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FunctionSublabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FunctionLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.FunctionAttributeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.FunctionSublabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FunctionSublabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FunctionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.FunctionLabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.InvitationRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RoleEnum), TypeInfoPropertyName = "RoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.InvitationWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.IssueRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.IssueWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.IssuesSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobStage), TypeInfoPropertyName = "JobStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OperationStatus), TypeInfoPropertyName = "OperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobType), TypeInfoPropertyName = "JobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Storage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityTargetMetric), TypeInfoPropertyName = "QualityTargetMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationStatusEnum), TypeInfoPropertyName = "JobValidationStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationLayoutRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Label))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Attribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Sublabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Sublabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::CVAT.SublabelMappingEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SublabelMappingEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::CVAT.SublabelMappingEntryRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SublabelMappingEntryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledShape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledImageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledShapeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.LabeledTrackRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabeledTrackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeVal>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeValRequest>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Limit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LimitTypeEnum), TypeInfoPropertyName = "LimitTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LimitsField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LimitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LimitsFieldRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LocationEnum), TypeInfoPropertyName = "LocationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LoginSerializerExRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.MembershipRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.MetaUser), TypeInfoPropertyName = "MetaUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OnlineFunctionCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OrganizationRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OrganizationWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedAccessTokenReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AccessTokenRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedAnnotationConflictList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AnnotationConflict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedAnnotationRequestList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AnnotationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedCloudStorageReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.CloudStorageRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedCommentReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.CommentRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedConsensusSettingsList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.ConsensusSettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedFunctionList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Function>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedInvitationReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.InvitationRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedIssueReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.IssueRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedJobReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.JobRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedJobValidationList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.JobValidation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedLabelList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Label>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedLimitList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Limit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedMembershipReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.MembershipRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedMetaUserList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.MetaUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedOrganizationReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.OrganizationRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedProjectReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.ProjectRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedQualityReportList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualityReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedQualitySettingsList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualitySettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualitySettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedRequestList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Request>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedTaskReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.TaskRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TaskRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedUsageList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Usage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedWebhookDeliveryReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.WebhookDeliveryRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhookDeliveryRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedWebhookReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.WebhookRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhookRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PasswordChangeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PasswordResetConfirmRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PasswordResetSerializerExRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedAccessTokenWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedAnnotationGuideWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedCloudStorageWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedCommentWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedConsensusSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedDataMetaWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedInvitationWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedIssueWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedJobDataMetaWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedJobValidationLayoutWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedJobWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.SublabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SublabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedLabeledDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedLimitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedMembershipWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedOrganizationWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedProjectWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.StorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedQualitySettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityPointSizeBase), TypeInfoPropertyName = "QualityPointSizeBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedTaskValidationLayoutWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedTaskWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedWebhookWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhookContentType), TypeInfoPropertyName = "WebhookContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Plugins))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportJobsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportTasksSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QueueRequestAcquireInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RequestCategoryEnum), TypeInfoPropertyName = "RequestCategoryEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QueueRequestAcquireOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QueueRequestCompleteInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QueueRequestFailInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QueueRequestUpdateInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RegisterSerializerWithSubscriptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.UserAgreement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.UserAgreement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RegisterSerializerWithSubscriptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.UserAgreementRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.UserAgreementRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RequestStatus), TypeInfoPropertyName = "RequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RequestDataOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.UserIdentifiers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RestAuthDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RqStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RqStatusStateEnum), TypeInfoPropertyName = "RqStatusStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SSOAuthMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SelectionSchemaEnum), TypeInfoPropertyName = "SelectionSchemaEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SSOLoginURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SocialAuthMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SocialAuthMethods))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SocialLoginSerializerExRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TaskFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TaskValidationLayoutRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ValidationMode?, global::CVAT.NullEnum>), TypeInfoPropertyName = "OneOfValidationModeNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ValidationMode), TypeInfoPropertyName = "ValidationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TaskWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Token))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhookWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CloudstoragesListCredentialsType), TypeInfoPropertyName = "CloudstoragesListCredentialsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CloudstoragesListProviderType), TypeInfoPropertyName = "CloudstoragesListProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.EventsListAction), TypeInfoPropertyName = "EventsListAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.EventsCreateExportLocation), TypeInfoPropertyName = "EventsCreateExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListDimension), TypeInfoPropertyName = "JobsListDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListStage), TypeInfoPropertyName = "JobsListStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListState), TypeInfoPropertyName = "JobsListState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListType), TypeInfoPropertyName = "JobsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsRetrieveAnnotationsLocation), TypeInfoPropertyName = "JobsRetrieveAnnotationsLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsCreateAnnotationsLocation), TypeInfoPropertyName = "JobsCreateAnnotationsLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsPartialUpdateAnnotationsAction), TypeInfoPropertyName = "JobsPartialUpdateAnnotationsAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsRetrieveDataQuality), TypeInfoPropertyName = "JobsRetrieveDataQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsRetrieveDataType), TypeInfoPropertyName = "JobsRetrieveDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsCreateDatasetExportLocation), TypeInfoPropertyName = "JobsCreateDatasetExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelsListType), TypeInfoPropertyName = "LabelsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.MembershipsListRole), TypeInfoPropertyName = "MembershipsListRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsListStatus), TypeInfoPropertyName = "ProjectsListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateBackupExportLocation), TypeInfoPropertyName = "ProjectsCreateBackupExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateDatasetLocation), TypeInfoPropertyName = "ProjectsCreateDatasetLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateDatasetExportLocation), TypeInfoPropertyName = "ProjectsCreateDatasetExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateBackupLocation), TypeInfoPropertyName = "ProjectsCreateBackupLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListConflictsSeverity), TypeInfoPropertyName = "QualityListConflictsSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListConflictsType), TypeInfoPropertyName = "QualityListConflictsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListJobValidationsStatus), TypeInfoPropertyName = "QualityListJobValidationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListReportsTarget), TypeInfoPropertyName = "QualityListReportsTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRetrieveReportDataFormat), TypeInfoPropertyName = "QualityRetrieveReportDataFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListSettingsParentType), TypeInfoPropertyName = "QualityListSettingsParentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RequestsListStatus), TypeInfoPropertyName = "RequestsListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SchemaRetrieveLang), TypeInfoPropertyName = "SchemaRetrieveLang2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SchemaRetrieveScheme), TypeInfoPropertyName = "SchemaRetrieveScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListDimension), TypeInfoPropertyName = "TasksListDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListStatus), TypeInfoPropertyName = "TasksListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksListValidationMode), TypeInfoPropertyName = "TasksListValidationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateAnnotationsLocation), TypeInfoPropertyName = "TasksCreateAnnotationsLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksPartialUpdateAnnotationsAction), TypeInfoPropertyName = "TasksPartialUpdateAnnotationsAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateBackupExportLocation), TypeInfoPropertyName = "TasksCreateBackupExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksRetrieveDataQuality), TypeInfoPropertyName = "TasksRetrieveDataQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksRetrieveDataType), TypeInfoPropertyName = "TasksRetrieveDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateDatasetExportLocation), TypeInfoPropertyName = "TasksCreateDatasetExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksCreateBackupLocation), TypeInfoPropertyName = "TasksCreateBackupLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhooksListType), TypeInfoPropertyName = "WebhooksListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.SocialAuthMethods>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.FunctionCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.ReportEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AnnotationsStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AnnotationId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Shape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.ShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.EventRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Chapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FrameMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.DatasetFormat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.EventsEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.ShapeType2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionSublabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionAttributeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionSublabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionLabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Attribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Sublabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledShape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledImageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.LabeledTrackRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeVal>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeValRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SubLabeledShape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SubLabeledShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.TrackedShape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SubLabeledTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.TrackedShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SubLabeledTrackRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AccessTokenRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AnnotationConflict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AnnotationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.CloudStorageRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.CommentRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.ConsensusSettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Function>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.InvitationRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.IssueRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.JobRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.JobValidation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Label>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Limit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.MembershipRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.MetaUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.OrganizationRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.ProjectRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualityReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualitySettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Request>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.TaskRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Usage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.WebhookDeliveryRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.WebhookRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SublabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.PatchedLabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.UserAgreement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.UserAgreementRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SocialAuthMethods>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionCall>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}