
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictAnnotationType), TypeInfoPropertyName = "AnnotationConflictAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationGuideRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationGuideWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ShapeType2?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfShapeType2NullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ShapeType2), TypeInfoPropertyName = "ShapeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.NullEnum), TypeInfoPropertyName = "NullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationRequestFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationTypeEnum), TypeInfoPropertyName = "AnnotationTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Count))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ArAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ArParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ArType), TypeInfoPropertyName = "ArType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelMappingEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Shape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Shape))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeComparison))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeComparisonDefaultRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeComparisonRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeComparisonRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfComparatorEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ComparatorEnum), TypeInfoPropertyName = "ComparatorEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeComparisonDefaultRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeComparisonRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeComparisonRuleRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeComparisonRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeVal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeValRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributedShapeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeValRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.BasicOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.BasicUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.BlankEnum), TypeInfoPropertyName = "BlankEnum2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.EventGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Events))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhookType), TypeInfoPropertyName = "WebhookType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.WebhooksEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhooksEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.EventsEnum), TypeInfoPropertyName = "EventsEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FileInfoTypeEnum), TypeInfoPropertyName = "FileInfoTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FrameSelectionMethod), TypeInfoPropertyName = "FrameSelectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.KindEnum), TypeInfoPropertyName = "KindEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.FunctionLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FunctionLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.ShapeType2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.VisibilityEnum), TypeInfoPropertyName = "VisibilityEnum2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.JobValidationRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationStatusEnum), TypeInfoPropertyName = "JobValidationStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationLayoutRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Label))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Attribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.Sublabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Sublabel))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedQualityRequirementListItemList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRequirementListItem))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedUserGrowthDataList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.UserGrowthData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.UserGrowthData))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedQualityRequirementRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfAnnotationTypeEnumBlankEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfQualityTargetMetricNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfQualityPointSizeBaseBlankEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityPointSizeBase), TypeInfoPropertyName = "QualityPointSizeBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedQualitySettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRequirementListItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedTaskValidationLayoutWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedTaskWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedUserGrowthDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedWebhookWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhookContentType), TypeInfoPropertyName = "WebhookContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.EventsEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Plugins))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TasksSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportConfusionMatrix))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportConfusionMatrixAxes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportJobsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportRequirementCalculation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportRequirementCalculationStatusEnum), TypeInfoPropertyName = "QualityReportRequirementCalculationStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ReasonEnum?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfReasonEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ReasonEnum), TypeInfoPropertyName = "ReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportRequirementSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportScoreComponents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportRequirementsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualityReportRequirementSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportTasksSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRequirementBulkCreateNodeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualityRequirementBulkCreateNodeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRequirementBulkCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRequirementRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualitySettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QueueRequestAcquireInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RequestCategoryEnum), TypeInfoPropertyName = "RequestCategoryEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QueueRequestAcquireOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QueueRequestCompleteInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributedShapeRequest>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ValidationMode?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfValidationModeNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ValidationMode), TypeInfoPropertyName = "ValidationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.TaskWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.Token))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhookWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CloudstoragesListCredentialsType), TypeInfoPropertyName = "CloudstoragesListCredentialsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CloudstoragesListProviderType), TypeInfoPropertyName = "CloudstoragesListProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.EventsListAction), TypeInfoPropertyName = "EventsListAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.EventsCreateExportLocation), TypeInfoPropertyName = "EventsCreateExportLocation2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRetrieveReportRequirementConfusionFormat), TypeInfoPropertyName = "QualityRetrieveReportRequirementConfusionFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRetrieveReportDataFormat), TypeInfoPropertyName = "QualityRetrieveReportDataFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListSettingsParentType), TypeInfoPropertyName = "QualityListSettingsParentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListSettingsRequirementsAnnotationType), TypeInfoPropertyName = "QualityListSettingsRequirementsAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RequestsListStatus), TypeInfoPropertyName = "RequestsListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SchemaRetrieveLang), TypeInfoPropertyName = "SchemaRetrieveLang2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SchemaRetrieveScheme), TypeInfoPropertyName = "SchemaRetrieveScheme2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhooksListType), TypeInfoPropertyName = "WebhooksListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.SocialAuthMethods>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AnnotationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.FunctionCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualityRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportTarget?), TypeInfoPropertyName = "NullableQualityReportTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictType?), TypeInfoPropertyName = "NullableAnnotationConflictType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictSeverity?), TypeInfoPropertyName = "NullableAnnotationConflictSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictAnnotationType?), TypeInfoPropertyName = "NullableAnnotationConflictAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ShapeType2?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfShapeType2NullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ShapeType2?), TypeInfoPropertyName = "NullableShapeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.NullEnum?), TypeInfoPropertyName = "NullableNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationTypeEnum?), TypeInfoPropertyName = "NullableAnnotationTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ArType?), TypeInfoPropertyName = "NullableArType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.InputTypeEnum?), TypeInfoPropertyName = "NullableInputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfComparatorEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ComparatorEnum?), TypeInfoPropertyName = "NullableComparatorEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.BlankEnum?), TypeInfoPropertyName = "NullableBlankEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ChunkType?), TypeInfoPropertyName = "NullableChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProviderTypeEnum?), TypeInfoPropertyName = "NullableProviderTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CredentialsTypeEnum?), TypeInfoPropertyName = "NullableCredentialsTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.StorageType?), TypeInfoPropertyName = "NullableStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.StorageMethod?), TypeInfoPropertyName = "NullableStorageMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SortingMethod?), TypeInfoPropertyName = "NullableSortingMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.DataResponse?), TypeInfoPropertyName = "NullableDataResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhookType?), TypeInfoPropertyName = "NullableWebhookType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.EventsEnum?), TypeInfoPropertyName = "NullableEventsEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FileInfoTypeEnum?), TypeInfoPropertyName = "NullableFileInfoTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.FrameSelectionMethod?), TypeInfoPropertyName = "NullableFrameSelectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.KindEnum?), TypeInfoPropertyName = "NullableKindEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.VisibilityEnum?), TypeInfoPropertyName = "NullableVisibilityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelType?), TypeInfoPropertyName = "NullableLabelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RoleEnum?), TypeInfoPropertyName = "NullableRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobStatus?), TypeInfoPropertyName = "NullableJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobStage?), TypeInfoPropertyName = "NullableJobStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OperationStatus?), TypeInfoPropertyName = "NullableOperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobType?), TypeInfoPropertyName = "NullableJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityTargetMetric?), TypeInfoPropertyName = "NullableQualityTargetMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationStatusEnum?), TypeInfoPropertyName = "NullableJobValidationStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LimitTypeEnum?), TypeInfoPropertyName = "NullableLimitTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LocationEnum?), TypeInfoPropertyName = "NullableLocationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.MetaUser?), TypeInfoPropertyName = "NullableMetaUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfAnnotationTypeEnumBlankEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfQualityTargetMetricNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfQualityPointSizeBaseBlankEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityPointSizeBase?), TypeInfoPropertyName = "NullableQualityPointSizeBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhookContentType?), TypeInfoPropertyName = "NullableWebhookContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportRequirementCalculationStatusEnum?), TypeInfoPropertyName = "NullableQualityReportRequirementCalculationStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ReasonEnum?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfReasonEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ReasonEnum?), TypeInfoPropertyName = "NullableReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RequestCategoryEnum?), TypeInfoPropertyName = "NullableRequestCategoryEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RequestStatus?), TypeInfoPropertyName = "NullableRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RqStatusStateEnum?), TypeInfoPropertyName = "NullableRqStatusStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SelectionSchemaEnum?), TypeInfoPropertyName = "NullableSelectionSchemaEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ValidationMode?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfValidationModeNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ValidationMode?), TypeInfoPropertyName = "NullableValidationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CloudstoragesListCredentialsType?), TypeInfoPropertyName = "NullableCloudstoragesListCredentialsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.CloudstoragesListProviderType?), TypeInfoPropertyName = "NullableCloudstoragesListProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.EventsListAction?), TypeInfoPropertyName = "NullableEventsListAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.EventsCreateExportLocation?), TypeInfoPropertyName = "NullableEventsCreateExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListDimension?), TypeInfoPropertyName = "NullableJobsListDimension2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListMediaType?), TypeInfoPropertyName = "NullableJobsListMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListMode?), TypeInfoPropertyName = "NullableJobsListMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListStage?), TypeInfoPropertyName = "NullableJobsListStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListState?), TypeInfoPropertyName = "NullableJobsListState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsListType?), TypeInfoPropertyName = "NullableJobsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsRetrieveAnnotationsLocation?), TypeInfoPropertyName = "NullableJobsRetrieveAnnotationsLocation2")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsCreateAnnotationsImportMode?), TypeInfoPropertyName = "NullableJobsCreateAnnotationsImportMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsCreateAnnotationsLocation?), TypeInfoPropertyName = "NullableJobsCreateAnnotationsLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsPartialUpdateAnnotationsAction?), TypeInfoPropertyName = "NullableJobsPartialUpdateAnnotationsAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsRetrieveDataQuality?), TypeInfoPropertyName = "NullableJobsRetrieveDataQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsRetrieveDataType?), TypeInfoPropertyName = "NullableJobsRetrieveDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobsCreateDatasetExportLocation?), TypeInfoPropertyName = "NullableJobsCreateDatasetExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.LabelsListType?), TypeInfoPropertyName = "NullableLabelsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.MembershipsListRole?), TypeInfoPropertyName = "NullableMembershipsListRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsListStatus?), TypeInfoPropertyName = "NullableProjectsListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateBackupExportLocation?), TypeInfoPropertyName = "NullableProjectsCreateBackupExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateDatasetLocation?), TypeInfoPropertyName = "NullableProjectsCreateDatasetLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateDatasetExportLocation?), TypeInfoPropertyName = "NullableProjectsCreateDatasetExportLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ProjectsCreateBackupLocation?), TypeInfoPropertyName = "NullableProjectsCreateBackupLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListConflictsSeverity?), TypeInfoPropertyName = "NullableQualityListConflictsSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListConflictsType?), TypeInfoPropertyName = "NullableQualityListConflictsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListJobValidationsStatus?), TypeInfoPropertyName = "NullableQualityListJobValidationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListReportsTarget?), TypeInfoPropertyName = "NullableQualityListReportsTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRetrieveReportRequirementConfusionFormat?), TypeInfoPropertyName = "NullableQualityRetrieveReportRequirementConfusionFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRetrieveReportDataFormat?), TypeInfoPropertyName = "NullableQualityRetrieveReportDataFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListSettingsParentType?), TypeInfoPropertyName = "NullableQualityListSettingsParentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListSettingsRequirementsAnnotationType?), TypeInfoPropertyName = "NullableQualityListSettingsRequirementsAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RequestsListStatus?), TypeInfoPropertyName = "NullableRequestsListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SchemaRetrieveLang?), TypeInfoPropertyName = "NullableSchemaRetrieveLang2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.SchemaRetrieveScheme?), TypeInfoPropertyName = "NullableSchemaRetrieveScheme2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.WebhooksListType?), TypeInfoPropertyName = "NullableWebhooksListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.ReportEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AnnotationsStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AnnotationId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Shape>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.ShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeComparisonRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeComparisonRuleRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeValRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.EventRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Chapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FrameMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.DatasetFormat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.WebhooksEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.ShapeType2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionSublabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionAttributeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionSublabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionLabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.JobValidationRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Attribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Sublabel>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AccessTokenRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AnnotationConflict>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualityRequirementListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualitySettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Request>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.TaskRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.Usage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.UserGrowthData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.WebhookDeliveryRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.WebhookRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SublabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.PatchedLabelRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualityRequirementListItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.EventsEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualityReportRequirementSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualityRequirementBulkCreateNodeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributedShapeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.UserAgreement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.UserAgreementRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.SocialAuthMethods>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AnnotationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.FunctionCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualityRequirement>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::CVAT.JsonConverters.DataResponseJsonConverter());
            options.Converters.Add(new global::CVAT.JsonConverters.MetaUserJsonConverter());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ShapeType2?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ReasonEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
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
                    typeToConvert == typeof(global::CVAT.AnnotationConflictAnnotationType)

                    || typeToConvert == typeof(global::CVAT.AnnotationConflictAnnotationType?)

                    || typeToConvert == typeof(global::CVAT.AnnotationConflictSeverity)

                    || typeToConvert == typeof(global::CVAT.AnnotationConflictSeverity?)

                    || typeToConvert == typeof(global::CVAT.AnnotationConflictType)

                    || typeToConvert == typeof(global::CVAT.AnnotationConflictType?)

                    || typeToConvert == typeof(global::CVAT.AnnotationTypeEnum)

                    || typeToConvert == typeof(global::CVAT.AnnotationTypeEnum?)

                    || typeToConvert == typeof(global::CVAT.ArType)

                    || typeToConvert == typeof(global::CVAT.ArType?)

                    || typeToConvert == typeof(global::CVAT.BlankEnum)

                    || typeToConvert == typeof(global::CVAT.BlankEnum?)

                    || typeToConvert == typeof(global::CVAT.ChunkType)

                    || typeToConvert == typeof(global::CVAT.ChunkType?)

                    || typeToConvert == typeof(global::CVAT.ComparatorEnum)

                    || typeToConvert == typeof(global::CVAT.ComparatorEnum?)

                    || typeToConvert == typeof(global::CVAT.CredentialsTypeEnum)

                    || typeToConvert == typeof(global::CVAT.CredentialsTypeEnum?)

                    || typeToConvert == typeof(global::CVAT.EventsEnum)

                    || typeToConvert == typeof(global::CVAT.EventsEnum?)

                    || typeToConvert == typeof(global::CVAT.FileInfoTypeEnum)

                    || typeToConvert == typeof(global::CVAT.FileInfoTypeEnum?)

                    || typeToConvert == typeof(global::CVAT.FrameSelectionMethod)

                    || typeToConvert == typeof(global::CVAT.FrameSelectionMethod?)

                    || typeToConvert == typeof(global::CVAT.InputTypeEnum)

                    || typeToConvert == typeof(global::CVAT.InputTypeEnum?)

                    || typeToConvert == typeof(global::CVAT.JobStage)

                    || typeToConvert == typeof(global::CVAT.JobStage?)

                    || typeToConvert == typeof(global::CVAT.JobStatus)

                    || typeToConvert == typeof(global::CVAT.JobStatus?)

                    || typeToConvert == typeof(global::CVAT.JobType)

                    || typeToConvert == typeof(global::CVAT.JobType?)

                    || typeToConvert == typeof(global::CVAT.JobValidationStatusEnum)

                    || typeToConvert == typeof(global::CVAT.JobValidationStatusEnum?)

                    || typeToConvert == typeof(global::CVAT.KindEnum)

                    || typeToConvert == typeof(global::CVAT.KindEnum?)

                    || typeToConvert == typeof(global::CVAT.LabelType)

                    || typeToConvert == typeof(global::CVAT.LabelType?)

                    || typeToConvert == typeof(global::CVAT.LimitTypeEnum)

                    || typeToConvert == typeof(global::CVAT.LimitTypeEnum?)

                    || typeToConvert == typeof(global::CVAT.LocationEnum)

                    || typeToConvert == typeof(global::CVAT.LocationEnum?)

                    || typeToConvert == typeof(global::CVAT.NullEnum)

                    || typeToConvert == typeof(global::CVAT.NullEnum?)

                    || typeToConvert == typeof(global::CVAT.OperationStatus)

                    || typeToConvert == typeof(global::CVAT.OperationStatus?)

                    || typeToConvert == typeof(global::CVAT.ProviderTypeEnum)

                    || typeToConvert == typeof(global::CVAT.ProviderTypeEnum?)

                    || typeToConvert == typeof(global::CVAT.QualityPointSizeBase)

                    || typeToConvert == typeof(global::CVAT.QualityPointSizeBase?)

                    || typeToConvert == typeof(global::CVAT.QualityReportRequirementCalculationStatusEnum)

                    || typeToConvert == typeof(global::CVAT.QualityReportRequirementCalculationStatusEnum?)

                    || typeToConvert == typeof(global::CVAT.QualityReportTarget)

                    || typeToConvert == typeof(global::CVAT.QualityReportTarget?)

                    || typeToConvert == typeof(global::CVAT.QualityTargetMetric)

                    || typeToConvert == typeof(global::CVAT.QualityTargetMetric?)

                    || typeToConvert == typeof(global::CVAT.ReasonEnum)

                    || typeToConvert == typeof(global::CVAT.ReasonEnum?)

                    || typeToConvert == typeof(global::CVAT.RequestCategoryEnum)

                    || typeToConvert == typeof(global::CVAT.RequestCategoryEnum?)

                    || typeToConvert == typeof(global::CVAT.RequestStatus)

                    || typeToConvert == typeof(global::CVAT.RequestStatus?)

                    || typeToConvert == typeof(global::CVAT.RoleEnum)

                    || typeToConvert == typeof(global::CVAT.RoleEnum?)

                    || typeToConvert == typeof(global::CVAT.RqStatusStateEnum)

                    || typeToConvert == typeof(global::CVAT.RqStatusStateEnum?)

                    || typeToConvert == typeof(global::CVAT.SelectionSchemaEnum)

                    || typeToConvert == typeof(global::CVAT.SelectionSchemaEnum?)

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

                    || typeToConvert == typeof(global::CVAT.VisibilityEnum)

                    || typeToConvert == typeof(global::CVAT.VisibilityEnum?)

                    || typeToConvert == typeof(global::CVAT.WebhookContentType)

                    || typeToConvert == typeof(global::CVAT.WebhookContentType?)

                    || typeToConvert == typeof(global::CVAT.WebhookType)

                    || typeToConvert == typeof(global::CVAT.WebhookType?)

                    || typeToConvert == typeof(global::CVAT.CloudstoragesListCredentialsType)

                    || typeToConvert == typeof(global::CVAT.CloudstoragesListCredentialsType?)

                    || typeToConvert == typeof(global::CVAT.CloudstoragesListProviderType)

                    || typeToConvert == typeof(global::CVAT.CloudstoragesListProviderType?)

                    || typeToConvert == typeof(global::CVAT.EventsListAction)

                    || typeToConvert == typeof(global::CVAT.EventsListAction?)

                    || typeToConvert == typeof(global::CVAT.EventsCreateExportLocation)

                    || typeToConvert == typeof(global::CVAT.EventsCreateExportLocation?)

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

                    || typeToConvert == typeof(global::CVAT.JobsCreateDatasetExportLocation?)

                    || typeToConvert == typeof(global::CVAT.LabelsListType)

                    || typeToConvert == typeof(global::CVAT.LabelsListType?)

                    || typeToConvert == typeof(global::CVAT.MembershipsListRole)

                    || typeToConvert == typeof(global::CVAT.MembershipsListRole?)

                    || typeToConvert == typeof(global::CVAT.ProjectsListStatus)

                    || typeToConvert == typeof(global::CVAT.ProjectsListStatus?)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateBackupExportLocation)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateBackupExportLocation?)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateDatasetLocation)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateDatasetLocation?)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateDatasetExportLocation)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateDatasetExportLocation?)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateBackupLocation)

                    || typeToConvert == typeof(global::CVAT.ProjectsCreateBackupLocation?)

                    || typeToConvert == typeof(global::CVAT.QualityListConflictsSeverity)

                    || typeToConvert == typeof(global::CVAT.QualityListConflictsSeverity?)

                    || typeToConvert == typeof(global::CVAT.QualityListConflictsType)

                    || typeToConvert == typeof(global::CVAT.QualityListConflictsType?)

                    || typeToConvert == typeof(global::CVAT.QualityListJobValidationsStatus)

                    || typeToConvert == typeof(global::CVAT.QualityListJobValidationsStatus?)

                    || typeToConvert == typeof(global::CVAT.QualityListReportsTarget)

                    || typeToConvert == typeof(global::CVAT.QualityListReportsTarget?)

                    || typeToConvert == typeof(global::CVAT.QualityRetrieveReportRequirementConfusionFormat)

                    || typeToConvert == typeof(global::CVAT.QualityRetrieveReportRequirementConfusionFormat?)

                    || typeToConvert == typeof(global::CVAT.QualityRetrieveReportDataFormat)

                    || typeToConvert == typeof(global::CVAT.QualityRetrieveReportDataFormat?)

                    || typeToConvert == typeof(global::CVAT.QualityListSettingsParentType)

                    || typeToConvert == typeof(global::CVAT.QualityListSettingsParentType?)

                    || typeToConvert == typeof(global::CVAT.QualityListSettingsRequirementsAnnotationType)

                    || typeToConvert == typeof(global::CVAT.QualityListSettingsRequirementsAnnotationType?)

                    || typeToConvert == typeof(global::CVAT.RequestsListStatus)

                    || typeToConvert == typeof(global::CVAT.RequestsListStatus?)

                    || typeToConvert == typeof(global::CVAT.SchemaRetrieveLang)

                    || typeToConvert == typeof(global::CVAT.SchemaRetrieveLang?)

                    || typeToConvert == typeof(global::CVAT.SchemaRetrieveScheme)

                    || typeToConvert == typeof(global::CVAT.SchemaRetrieveScheme?)

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

                    || typeToConvert == typeof(global::CVAT.TasksCreateBackupLocation?)

                    || typeToConvert == typeof(global::CVAT.WebhooksListType)

                    || typeToConvert == typeof(global::CVAT.WebhooksListType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::CVAT.AnnotationConflictAnnotationType))
                {
                    return new global::CVAT.JsonConverters.AnnotationConflictAnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationConflictAnnotationType?))
                {
                    return new global::CVAT.JsonConverters.AnnotationConflictAnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationConflictSeverity))
                {
                    return new global::CVAT.JsonConverters.AnnotationConflictSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationConflictSeverity?))
                {
                    return new global::CVAT.JsonConverters.AnnotationConflictSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationConflictType))
                {
                    return new global::CVAT.JsonConverters.AnnotationConflictTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationConflictType?))
                {
                    return new global::CVAT.JsonConverters.AnnotationConflictTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationTypeEnum))
                {
                    return new global::CVAT.JsonConverters.AnnotationTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationTypeEnum?))
                {
                    return new global::CVAT.JsonConverters.AnnotationTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ArType))
                {
                    return new global::CVAT.JsonConverters.ArTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ArType?))
                {
                    return new global::CVAT.JsonConverters.ArTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.BlankEnum))
                {
                    return new global::CVAT.JsonConverters.BlankEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.BlankEnum?))
                {
                    return new global::CVAT.JsonConverters.BlankEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ChunkType))
                {
                    return new global::CVAT.JsonConverters.ChunkTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ChunkType?))
                {
                    return new global::CVAT.JsonConverters.ChunkTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ComparatorEnum))
                {
                    return new global::CVAT.JsonConverters.ComparatorEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ComparatorEnum?))
                {
                    return new global::CVAT.JsonConverters.ComparatorEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.CredentialsTypeEnum))
                {
                    return new global::CVAT.JsonConverters.CredentialsTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.CredentialsTypeEnum?))
                {
                    return new global::CVAT.JsonConverters.CredentialsTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.EventsEnum))
                {
                    return new global::CVAT.JsonConverters.EventsEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.EventsEnum?))
                {
                    return new global::CVAT.JsonConverters.EventsEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.FileInfoTypeEnum))
                {
                    return new global::CVAT.JsonConverters.FileInfoTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.FileInfoTypeEnum?))
                {
                    return new global::CVAT.JsonConverters.FileInfoTypeEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::CVAT.JobValidationStatusEnum))
                {
                    return new global::CVAT.JsonConverters.JobValidationStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobValidationStatusEnum?))
                {
                    return new global::CVAT.JsonConverters.JobValidationStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.KindEnum))
                {
                    return new global::CVAT.JsonConverters.KindEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.KindEnum?))
                {
                    return new global::CVAT.JsonConverters.KindEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LabelType))
                {
                    return new global::CVAT.JsonConverters.LabelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LabelType?))
                {
                    return new global::CVAT.JsonConverters.LabelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LimitTypeEnum))
                {
                    return new global::CVAT.JsonConverters.LimitTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LimitTypeEnum?))
                {
                    return new global::CVAT.JsonConverters.LimitTypeEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::CVAT.OperationStatus))
                {
                    return new global::CVAT.JsonConverters.OperationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.OperationStatus?))
                {
                    return new global::CVAT.JsonConverters.OperationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ProviderTypeEnum))
                {
                    return new global::CVAT.JsonConverters.ProviderTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ProviderTypeEnum?))
                {
                    return new global::CVAT.JsonConverters.ProviderTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityPointSizeBase))
                {
                    return new global::CVAT.JsonConverters.QualityPointSizeBaseJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityPointSizeBase?))
                {
                    return new global::CVAT.JsonConverters.QualityPointSizeBaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityReportRequirementCalculationStatusEnum))
                {
                    return new global::CVAT.JsonConverters.QualityReportRequirementCalculationStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityReportRequirementCalculationStatusEnum?))
                {
                    return new global::CVAT.JsonConverters.QualityReportRequirementCalculationStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityReportTarget))
                {
                    return new global::CVAT.JsonConverters.QualityReportTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityReportTarget?))
                {
                    return new global::CVAT.JsonConverters.QualityReportTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityTargetMetric))
                {
                    return new global::CVAT.JsonConverters.QualityTargetMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityTargetMetric?))
                {
                    return new global::CVAT.JsonConverters.QualityTargetMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ReasonEnum))
                {
                    return new global::CVAT.JsonConverters.ReasonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ReasonEnum?))
                {
                    return new global::CVAT.JsonConverters.ReasonEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.RequestCategoryEnum))
                {
                    return new global::CVAT.JsonConverters.RequestCategoryEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.RequestCategoryEnum?))
                {
                    return new global::CVAT.JsonConverters.RequestCategoryEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.RequestStatus))
                {
                    return new global::CVAT.JsonConverters.RequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.RequestStatus?))
                {
                    return new global::CVAT.JsonConverters.RequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.RoleEnum))
                {
                    return new global::CVAT.JsonConverters.RoleEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.RoleEnum?))
                {
                    return new global::CVAT.JsonConverters.RoleEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.RqStatusStateEnum))
                {
                    return new global::CVAT.JsonConverters.RqStatusStateEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.RqStatusStateEnum?))
                {
                    return new global::CVAT.JsonConverters.RqStatusStateEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.SelectionSchemaEnum))
                {
                    return new global::CVAT.JsonConverters.SelectionSchemaEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.SelectionSchemaEnum?))
                {
                    return new global::CVAT.JsonConverters.SelectionSchemaEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::CVAT.VisibilityEnum))
                {
                    return new global::CVAT.JsonConverters.VisibilityEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.VisibilityEnum?))
                {
                    return new global::CVAT.JsonConverters.VisibilityEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.WebhookContentType))
                {
                    return new global::CVAT.JsonConverters.WebhookContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.WebhookContentType?))
                {
                    return new global::CVAT.JsonConverters.WebhookContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.WebhookType))
                {
                    return new global::CVAT.JsonConverters.WebhookTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.WebhookType?))
                {
                    return new global::CVAT.JsonConverters.WebhookTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.CloudstoragesListCredentialsType))
                {
                    return new global::CVAT.JsonConverters.CloudstoragesListCredentialsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.CloudstoragesListCredentialsType?))
                {
                    return new global::CVAT.JsonConverters.CloudstoragesListCredentialsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.CloudstoragesListProviderType))
                {
                    return new global::CVAT.JsonConverters.CloudstoragesListProviderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.CloudstoragesListProviderType?))
                {
                    return new global::CVAT.JsonConverters.CloudstoragesListProviderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.EventsListAction))
                {
                    return new global::CVAT.JsonConverters.EventsListActionJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.EventsListAction?))
                {
                    return new global::CVAT.JsonConverters.EventsListActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.EventsCreateExportLocation))
                {
                    return new global::CVAT.JsonConverters.EventsCreateExportLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.EventsCreateExportLocation?))
                {
                    return new global::CVAT.JsonConverters.EventsCreateExportLocationNullableJsonConverter();
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

                if (typeToConvert == typeof(global::CVAT.LabelsListType))
                {
                    return new global::CVAT.JsonConverters.LabelsListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.LabelsListType?))
                {
                    return new global::CVAT.JsonConverters.LabelsListTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.MembershipsListRole))
                {
                    return new global::CVAT.JsonConverters.MembershipsListRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.MembershipsListRole?))
                {
                    return new global::CVAT.JsonConverters.MembershipsListRoleNullableJsonConverter();
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

                if (typeToConvert == typeof(global::CVAT.QualityListConflictsSeverity))
                {
                    return new global::CVAT.JsonConverters.QualityListConflictsSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListConflictsSeverity?))
                {
                    return new global::CVAT.JsonConverters.QualityListConflictsSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListConflictsType))
                {
                    return new global::CVAT.JsonConverters.QualityListConflictsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListConflictsType?))
                {
                    return new global::CVAT.JsonConverters.QualityListConflictsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListJobValidationsStatus))
                {
                    return new global::CVAT.JsonConverters.QualityListJobValidationsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListJobValidationsStatus?))
                {
                    return new global::CVAT.JsonConverters.QualityListJobValidationsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListReportsTarget))
                {
                    return new global::CVAT.JsonConverters.QualityListReportsTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListReportsTarget?))
                {
                    return new global::CVAT.JsonConverters.QualityListReportsTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityRetrieveReportRequirementConfusionFormat))
                {
                    return new global::CVAT.JsonConverters.QualityRetrieveReportRequirementConfusionFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityRetrieveReportRequirementConfusionFormat?))
                {
                    return new global::CVAT.JsonConverters.QualityRetrieveReportRequirementConfusionFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityRetrieveReportDataFormat))
                {
                    return new global::CVAT.JsonConverters.QualityRetrieveReportDataFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityRetrieveReportDataFormat?))
                {
                    return new global::CVAT.JsonConverters.QualityRetrieveReportDataFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListSettingsParentType))
                {
                    return new global::CVAT.JsonConverters.QualityListSettingsParentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListSettingsParentType?))
                {
                    return new global::CVAT.JsonConverters.QualityListSettingsParentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListSettingsRequirementsAnnotationType))
                {
                    return new global::CVAT.JsonConverters.QualityListSettingsRequirementsAnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListSettingsRequirementsAnnotationType?))
                {
                    return new global::CVAT.JsonConverters.QualityListSettingsRequirementsAnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.RequestsListStatus))
                {
                    return new global::CVAT.JsonConverters.RequestsListStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.RequestsListStatus?))
                {
                    return new global::CVAT.JsonConverters.RequestsListStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.SchemaRetrieveLang))
                {
                    return new global::CVAT.JsonConverters.SchemaRetrieveLangJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.SchemaRetrieveLang?))
                {
                    return new global::CVAT.JsonConverters.SchemaRetrieveLangNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.SchemaRetrieveScheme))
                {
                    return new global::CVAT.JsonConverters.SchemaRetrieveSchemeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.SchemaRetrieveScheme?))
                {
                    return new global::CVAT.JsonConverters.SchemaRetrieveSchemeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::CVAT.WebhooksListType))
                {
                    return new global::CVAT.JsonConverters.WebhooksListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.WebhooksListType?))
                {
                    return new global::CVAT.JsonConverters.WebhooksListTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}