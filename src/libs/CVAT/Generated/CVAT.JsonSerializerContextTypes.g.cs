
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::CVAT.About? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AcceptInvitationRead? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AccessTokenRead? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.BasicUser? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AccessTokenWriteRequest? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AggregationEnum? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AllWebhookType? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnalyticsReport? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTarget? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ReportEvent>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ReportEvent? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AnnotationsStatistics>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationsStatistics? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationConflict? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationConflictType? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AnnotationId>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationId? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationConflictSeverity? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AnnotationConflictRequirement>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationConflictRequirement? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationConflictAnnotationType? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationFileRequest? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationGuideRead? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationGuideWriteRequest? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.ShapeType?, global::CVAT.NullEnum?>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ShapeType? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.NullEnum? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationRequest? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationRequestFunction? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationTypeEnum? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Count? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ArAssignment? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ArParams? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ArType? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntry>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelMappingEntry? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Shape>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Shape? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ArParamsRequest? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntryRequest>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelMappingEntryRequest? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ShapeRequest>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ShapeRequest? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AssetRead? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AssetWriteRequest? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Attribute? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.InputTypeEnum? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeComparison? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeComparisonDefaultRule? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributeComparisonRule>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeComparisonRule? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ComparatorEnum? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeComparisonDefaultRuleRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeComparisonRequest? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributeComparisonRuleRequest>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeComparisonRuleRequest? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeRequest? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeVal? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeValRequest? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributedShapeRequest? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributeValRequest>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.BasicOrganization? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.BasicUserRequest? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.BlankEnum? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Chapter? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ChapterMetadata? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ChunkType? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ClientEvents? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Event>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Event? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ClientEventsRequest? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.EventRequest>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.EventRequest? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CloudStorageContent? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FileInfo>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FileInfo? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CloudStorageRead? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProviderTypeEnum? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CredentialsTypeEnum? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CloudStorageWriteRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CommentRead? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CommentWriteRequest? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CommentsSummary? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ConsensusMergeCreateRequest? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ConsensusSettings? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CreateAnalyticsReportBodyRequest? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CreatedViaEnum? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CurrentLimit? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Type2c0Enum? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LimitsField? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CvatUsageReasonEnum? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.DataMetaRead? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Chapter>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FrameMeta>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FrameMeta? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.StorageType? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.DataRequest? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.StorageMethod? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SortingMethod? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ValidationParamsRequest? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.DataResponse? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RqId? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.DatasetFileRequest? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.DatasetFormat? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.DatasetFormats? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.DatasetFormat>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.EventGroup? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Events? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.WebhooksEvent>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhooksEvent? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.EventsEnum? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ExtrapolationEnum? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FileInfoTypeEnum? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FileMetadata? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FileMetadataTypeEnum? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.RelatedFileMetadata>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RelatedFileMetadata? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FrameSelectionMethod? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Function? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.KindEnum? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionLabel>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionLabel? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ShapeType>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.VisibilityEnum? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionAttribute? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionAttributeRequest? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionCall? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionCallParams? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionCallRequest? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionIdAndArParamsRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelType? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionAttribute>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionSublabel>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionSublabel? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionLabelRequest? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionAttributeRequest>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionSublabelRequest>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionSublabelRequest? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionRequest? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionLabelRequest>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.GroundTruthJobCreateRequest? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.GroundTruthJobCreateTypeEnum? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.InputEnum? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.InvitationRead? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RoleEnum? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.InvitationWriteRequest? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.IssueRead? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.IssueWriteRequest? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.IssuesSummary? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobRead? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobStatus? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobStage? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OperationStatus? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelsSummary? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobType? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Storage? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidation? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityTargetMetric? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.JobValidationRequirement>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidationRequirement? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidationStatusEnum? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidationCreateRequest? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidationLayoutRead? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobWriteRequest? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ReplicaJobCreateRequest? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobWriteRequestDiscriminator? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobWriteRequestDiscriminatorType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsSummary? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Label? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Attribute>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Sublabel>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Sublabel? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.SublabelMappingEntry>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SublabelMappingEntry? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.SublabelMappingEntryRequest>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SublabelMappingEntryRequest? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledData? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledImage>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledImage? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledShape>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledShape? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledTrack>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledTrack? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledInterval>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledInterval? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledDataRequest? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledImageRequest>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledImageRequest? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledShapeRequest>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledShapeRequest? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledTrackRequest>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledTrackRequest? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledIntervalRequest>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledIntervalRequest? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributeVal>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledShape>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SubLabeledShape? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledShapeRequest>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SubLabeledShapeRequest? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.TrackedShape>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TrackedShape? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledTrack>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SubLabeledTrack? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.TrackedShapeRequest>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TrackedShapeRequest? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledTrackRequest>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SubLabeledTrackRequest? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Limit? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LimitRequest? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LimitsFieldRequest? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LocationEnum? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LoginSerializerExRequest? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.MembershipRead? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.MetaUser? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.User? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.NumericUsage? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OnlineFunctionCallRequest? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OrganizationRead? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OrganizationWriteRequest? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedAccessTokenReadList? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AccessTokenRead>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedAnnotationConflictList? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AnnotationConflict>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedCloudStorageReadList? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.CloudStorageRead>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedCommentReadList? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.CommentRead>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedConsensusSettingsList? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ConsensusSettings>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedFunctionList? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Function>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedInvitationReadList? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.InvitationRead>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedIssueReadList? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.IssueRead>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedJobReadList? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.JobRead>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedJobValidationList? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.JobValidation>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedLabelList? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Label>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedLimitList? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Limit>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedMembershipReadList? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.MembershipRead>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedMetaUserList? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.MetaUser>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedOrganizationReadList? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.OrganizationRead>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedProjectReadList? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ProjectRead>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectRead? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedQualityReportList? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityReport>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReport? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedQualityRequirementListItemList? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItem>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementListItem? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedQualitySettingsList? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualitySettings>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualitySettings? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedRequestList? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Request>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Request? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedTaskReadList? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.TaskRead>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TaskRead? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedUserGrowthDataList? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.UserGrowthData>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.UserGrowthData? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedWebhookDeliveryReadList? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.WebhookDeliveryRead>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookDeliveryRead? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedWebhookReadList? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.WebhookRead>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookRead? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PasswordChangeRequest? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PasswordResetConfirmRequest? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PasswordResetSerializerExRequest? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedAccessTokenWriteRequest? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedAnnotationGuideWriteRequest? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedCloudStorageWriteRequest? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedCommentWriteRequest? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedConsensusSettingsRequest? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedDataMetaWriteRequest? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedIssueWriteRequest? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedJobDataMetaWriteRequest? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedJobValidationLayoutWriteRequest? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedJobWriteRequest? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedLabelRequest? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributeRequest>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SublabelRequest>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SublabelRequest? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedLabeledDataRequest? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedLimitRequest? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedMembershipWriteRequest? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedOrganizationWriteRequest? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedProjectWriteRequest? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.StorageRequest? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedQualityRequirementRequest? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.SimilarityMetricEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SimilarityMetricEnum? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<double?, global::CVAT.SimilarityThresholdPolicyRequest>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SimilarityThresholdPolicyRequest? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityPointSizeBase? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedQualitySettingsRequest? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItemRequest>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementListItemRequest? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedTaskValidationLayoutWriteRequest? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedTaskWriteRequest? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedUserGrowthDataRequest? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedUserRequest? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.CvatUsageReasonEnum?, global::CVAT.BlankEnum?>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.PlannedActivitiesEnum>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PlannedActivitiesEnum? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedWebhookWriteRequest? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookContentType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.EventsEnum>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Plugins? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectFileRequest? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksSummary? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectWriteRequest? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportSummary? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportConfusionMatrix? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportConfusionMatrixAxes? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTargetMetricSummary? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportCreateRequest? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportJobsSummary? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportRequirementCalculation? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportRequirementCalculationStatusEnum? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.ReasonEnum?, global::CVAT.NullEnum?>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ReasonEnum? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportRequirementSummaryItem? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportScoreComponents? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportRequirementsSummary? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityReportRequirementSummaryItem>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTasksSummary? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTargetMetricSummaryMetricEnum? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTargetMetricValues? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirement? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<double?, global::CVAT.SimilarityThresholdPolicy>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SimilarityThresholdPolicy? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementBulkCreateNodeRequest? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirementBulkCreateNodeRequest>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementBulkCreateRequest? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementRequest? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualitySettingsRequest? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestAcquireInputRequest? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RequestCategoryEnum? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestAcquireOutput? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestCompleteInputRequest? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributedShapeRequest>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestFailInputRequest? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestUpdateInputRequest? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RegisterSerializerWithSubscriptions? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.UserAgreement>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.UserAgreement? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RegisterSerializerWithSubscriptionsRequest? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.UserAgreementRequest>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.UserAgreementRequest? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RelatedImageMetadata? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RelatedFileMetadataDiscriminator? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RelatedFileMetadataDiscriminatorType? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RelatedImageMetadataTypeEnum? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ReplicaJobCreateTypeEnum? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RequestStatus? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RequestDataOperation? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.UserIdentifiers? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RestAuthDetail? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RqStatus? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RqStatusStateEnum? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SSOAuthMethod? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SelectionSchemaEnum? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SSOLoginURL? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SimilarityThresholdPolicyTypeEnum? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SimilarityThresholdPolicyModeEnum? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ThresholdPolicyPoint>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ThresholdPolicyPoint? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ThresholdPolicyPointRequest>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ThresholdPolicyPointRequest? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SocialAuthMethod? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SocialAuthMethods? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SocialLoginSerializerExRequest? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TaskFileRequest? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TaskValidationLayoutRead? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.ValidationMode?, global::CVAT.NullEnum?>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ValidationMode? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TaskWriteRequest? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Token? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Usage? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.CreatedViaEnum?, global::CVAT.NullEnum?>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookType? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookWriteRequest? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CloudstoragesListCredentialsType? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CloudstoragesListProviderType? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.EventsListAction? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.EventsCreateExportLocation? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListDimension? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListMediaType? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListMode? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListStage? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListState? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListType? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsRetrieveAnnotationsLocation? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsCreateAnnotationsImportMode? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsCreateAnnotationsLocation? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsPartialUpdateAnnotationsAction? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsRetrieveDataQuality? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsRetrieveDataType? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsCreateDatasetExportLocation? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelsListType? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.MembershipsListRole? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsListStatus? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsCreateBackupExportLocation? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsCreateDatasetLocation? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsCreateDatasetExportLocation? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsCreateBackupLocation? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListConflictsSeverity? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListConflictsType? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListJobValidationsStatus? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListReportsTarget? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRetrieveReportRequirementConfusionFormat? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRetrieveReportDataFormat? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListSettingsParentType? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListSettingsRequirementsAnnotationType? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RequestsListStatus? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SchemaRetrieveLang? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SchemaRetrieveScheme? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListDimension? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListMediaType? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListMode? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListStatus? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListValidationMode? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateAnnotationsImportMode? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateAnnotationsLocation? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksPartialUpdateAnnotationsAction? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateBackupExportLocation? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksRetrieveDataQuality? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksRetrieveDataType? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateDatasetExportLocation? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateBackupLocation? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhooksListType? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhooksRetrieveEventsType? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SocialAuthMethods>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AnnotationRequest>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionCall>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirement>? Type470 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ReportEvent>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AnnotationsStatistics>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AnnotationId>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AnnotationConflictRequirement>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Shape>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ShapeRequest>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributeComparisonRule>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributeComparisonRuleRequest>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributeValRequest>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Event>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.EventRequest>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FileInfo>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Chapter>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FrameMeta>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.DatasetFormat>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.WebhooksEvent>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.RelatedFileMetadata>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionLabel>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ShapeType>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionAttribute>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionSublabel>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionAttributeRequest>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionSublabelRequest>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionLabelRequest>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.JobValidationRequirement>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Attribute>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Sublabel>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledImage>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledShape>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledTrack>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledInterval>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledImageRequest>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledShapeRequest>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledTrackRequest>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledIntervalRequest>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributeVal>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SubLabeledShape>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SubLabeledShapeRequest>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.TrackedShape>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SubLabeledTrack>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.TrackedShapeRequest>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SubLabeledTrackRequest>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AccessTokenRead>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AnnotationConflict>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.CloudStorageRead>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.CommentRead>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ConsensusSettings>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Function>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.InvitationRead>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.IssueRead>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.JobRead>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.JobValidation>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Label>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Limit>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.MembershipRead>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.MetaUser>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.OrganizationRead>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ProjectRead>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityReport>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityRequirementListItem>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualitySettings>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Request>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.TaskRead>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.UserGrowthData>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.WebhookDeliveryRead>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.WebhookRead>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributeRequest>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SublabelRequest>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.PatchedLabelRequest>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityRequirementListItemRequest>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.PlannedActivitiesEnum>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.EventsEnum>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityReportRequirementSummaryItem>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityRequirementBulkCreateNodeRequest>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributedShapeRequest>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.UserAgreement>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.UserAgreementRequest>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ThresholdPolicyPoint>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ThresholdPolicyPointRequest>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SocialAuthMethods>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AnnotationRequest>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionCall>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityRequirement>? ListType90 { get; set; }
    }
}