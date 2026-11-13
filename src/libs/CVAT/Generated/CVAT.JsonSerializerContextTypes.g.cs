
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
        public global::CVAT.OneOf<global::CVAT.ShapeType2?, global::CVAT.NullEnum?>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ShapeType2? Type33 { get; set; }
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
        public global::CVAT.FrameSelectionMethod? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Function? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.KindEnum? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionLabel>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionLabel? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ShapeType2>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.VisibilityEnum? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionAttribute? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionAttributeRequest? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionCall? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionCallParams? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionCallRequest? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionIdAndArParamsRequest? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelType? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionAttribute>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionSublabel>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionSublabel? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionLabelRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionAttributeRequest>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionSublabelRequest>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionSublabelRequest? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionRequest? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionLabelRequest>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.GroundTruthJobCreateRequest? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.GroundTruthJobCreateTypeEnum? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.InputEnum? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.InvitationRead? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RoleEnum? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.InvitationWriteRequest? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.IssueRead? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.IssueWriteRequest? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.IssuesSummary? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobRead? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobStatus? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobStage? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OperationStatus? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelsSummary? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobType? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Storage? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidation? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityTargetMetric? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.JobValidationRequirement>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidationRequirement? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidationStatusEnum? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidationCreateRequest? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidationLayoutRead? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobWriteRequest? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ReplicaJobCreateRequest? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobWriteRequestDiscriminator? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobWriteRequestDiscriminatorType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsSummary? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Label? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Attribute>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Sublabel>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Sublabel? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.SublabelMappingEntry>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SublabelMappingEntry? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.SublabelMappingEntryRequest>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SublabelMappingEntryRequest? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledData? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledImage>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledImage? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledShape>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledShape? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledTrack>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledTrack? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledInterval>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledInterval? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledDataRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledImageRequest>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledImageRequest? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledShapeRequest>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledShapeRequest? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledTrackRequest>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledTrackRequest? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledIntervalRequest>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledIntervalRequest? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributeVal>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledShape>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SubLabeledShape? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledShapeRequest>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SubLabeledShapeRequest? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.TrackedShape>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TrackedShape? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledTrack>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SubLabeledTrack? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.TrackedShapeRequest>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TrackedShapeRequest? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledTrackRequest>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SubLabeledTrackRequest? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Limit? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LimitRequest? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LimitsFieldRequest? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LocationEnum? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LoginSerializerExRequest? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.MembershipRead? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.MetaUser? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.User? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.NumericUsage? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OnlineFunctionCallRequest? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OrganizationRead? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OrganizationWriteRequest? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedAccessTokenReadList? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AccessTokenRead>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedAnnotationConflictList? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AnnotationConflict>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedCloudStorageReadList? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.CloudStorageRead>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedCommentReadList? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.CommentRead>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedConsensusSettingsList? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ConsensusSettings>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedFunctionList? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Function>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedInvitationReadList? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.InvitationRead>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedIssueReadList? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.IssueRead>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedJobReadList? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.JobRead>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedJobValidationList? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.JobValidation>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedLabelList? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Label>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedLimitList? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Limit>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedMembershipReadList? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.MembershipRead>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedMetaUserList? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.MetaUser>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedOrganizationReadList? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.OrganizationRead>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedProjectReadList? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ProjectRead>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectRead? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedQualityReportList? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityReport>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReport? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedQualityRequirementListItemList? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItem>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementListItem? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedQualitySettingsList? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualitySettings>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualitySettings? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedRequestList? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Request>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Request? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedTaskReadList? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.TaskRead>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TaskRead? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedUserGrowthDataList? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.UserGrowthData>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.UserGrowthData? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedWebhookDeliveryReadList? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.WebhookDeliveryRead>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookDeliveryRead? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedWebhookReadList? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.WebhookRead>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookRead? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PasswordChangeRequest? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PasswordResetConfirmRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PasswordResetSerializerExRequest? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedAccessTokenWriteRequest? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedAnnotationGuideWriteRequest? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedCloudStorageWriteRequest? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedCommentWriteRequest? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedConsensusSettingsRequest? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedDataMetaWriteRequest? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedIssueWriteRequest? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedJobDataMetaWriteRequest? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedJobValidationLayoutWriteRequest? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedJobWriteRequest? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedLabelRequest? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributeRequest>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SublabelRequest>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SublabelRequest? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedLabeledDataRequest? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedLimitRequest? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedMembershipWriteRequest? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedOrganizationWriteRequest? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedProjectWriteRequest? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.StorageRequest? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedQualityRequirementRequest? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.SimilarityMetricEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SimilarityMetricEnum? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<double?, global::CVAT.SimilarityThresholdPolicyRequest>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SimilarityThresholdPolicyRequest? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityPointSizeBase? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedQualitySettingsRequest? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItemRequest>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementListItemRequest? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedTaskValidationLayoutWriteRequest? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedTaskWriteRequest? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedUserGrowthDataRequest? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedUserRequest? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.CvatUsageReasonEnum?, global::CVAT.BlankEnum?>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.PlannedActivitiesEnum>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PlannedActivitiesEnum? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedWebhookWriteRequest? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookContentType? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.EventsEnum>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Plugins? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectFileRequest? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksSummary? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectWriteRequest? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportSummary? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportConfusionMatrix? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportConfusionMatrixAxes? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTargetMetricSummary? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportCreateRequest? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportJobsSummary? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportRequirementCalculation? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportRequirementCalculationStatusEnum? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.ReasonEnum?, global::CVAT.NullEnum?>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ReasonEnum? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportRequirementSummaryItem? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportScoreComponents? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportRequirementsSummary? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityReportRequirementSummaryItem>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTasksSummary? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTargetMetricSummaryMetricEnum? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTargetMetricValues? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirement? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<double?, global::CVAT.SimilarityThresholdPolicy>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SimilarityThresholdPolicy? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementBulkCreateNodeRequest? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirementBulkCreateNodeRequest>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementBulkCreateRequest? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementRequest? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualitySettingsRequest? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestAcquireInputRequest? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RequestCategoryEnum? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestAcquireOutput? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestCompleteInputRequest? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributedShapeRequest>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestFailInputRequest? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestUpdateInputRequest? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RegisterSerializerWithSubscriptions? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.UserAgreement>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.UserAgreement? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RegisterSerializerWithSubscriptionsRequest? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.UserAgreementRequest>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.UserAgreementRequest? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ReplicaJobCreateTypeEnum? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RequestStatus? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RequestDataOperation? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.UserIdentifiers? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RestAuthDetail? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RqStatus? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RqStatusStateEnum? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SSOAuthMethod? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SelectionSchemaEnum? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SSOLoginURL? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SimilarityThresholdPolicyTypeEnum? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SimilarityThresholdPolicyModeEnum? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ThresholdPolicyPoint>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ThresholdPolicyPoint? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ThresholdPolicyPointRequest>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ThresholdPolicyPointRequest? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SocialAuthMethod? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SocialAuthMethods? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SocialLoginSerializerExRequest? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TaskFileRequest? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TaskValidationLayoutRead? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.ValidationMode?, global::CVAT.NullEnum?>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ValidationMode? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TaskWriteRequest? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Token? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Usage? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.CreatedViaEnum?, global::CVAT.NullEnum?>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookType? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookWriteRequest? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CloudstoragesListCredentialsType? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CloudstoragesListProviderType? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.EventsListAction? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.EventsCreateExportLocation? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListDimension? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListMediaType? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListMode? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListStage? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListState? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListType? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsRetrieveAnnotationsLocation? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsCreateAnnotationsImportMode? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsCreateAnnotationsLocation? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsPartialUpdateAnnotationsAction? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsRetrieveDataQuality? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsRetrieveDataType? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsCreateDatasetExportLocation? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelsListType? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.MembershipsListRole? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsListStatus? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsCreateBackupExportLocation? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsCreateDatasetLocation? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsCreateDatasetExportLocation? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsCreateBackupLocation? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListConflictsSeverity? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListConflictsType? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListJobValidationsStatus? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListReportsTarget? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRetrieveReportRequirementConfusionFormat? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRetrieveReportDataFormat? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListSettingsParentType? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListSettingsRequirementsAnnotationType? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RequestsListStatus? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SchemaRetrieveLang? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SchemaRetrieveScheme? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListDimension? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListMediaType? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListMode? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListStatus? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListValidationMode? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateAnnotationsImportMode? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateAnnotationsLocation? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksPartialUpdateAnnotationsAction? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateBackupExportLocation? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksRetrieveDataQuality? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksRetrieveDataType? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateDatasetExportLocation? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateBackupLocation? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhooksListType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhooksRetrieveEventsType? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SocialAuthMethods>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AnnotationRequest>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionCall>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirement>? Type462 { get; set; }

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
        public global::System.Collections.Generic.List<global::CVAT.FunctionLabel>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ShapeType2>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionAttribute>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionSublabel>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionAttributeRequest>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionSublabelRequest>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionLabelRequest>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.JobValidationRequirement>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Attribute>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Sublabel>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledImage>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledShape>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledTrack>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledInterval>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledImageRequest>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledShapeRequest>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledTrackRequest>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledIntervalRequest>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributeVal>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SubLabeledShape>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SubLabeledShapeRequest>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.TrackedShape>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SubLabeledTrack>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.TrackedShapeRequest>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SubLabeledTrackRequest>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AccessTokenRead>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AnnotationConflict>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.CloudStorageRead>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.CommentRead>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ConsensusSettings>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Function>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.InvitationRead>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.IssueRead>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.JobRead>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.JobValidation>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Label>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Limit>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.MembershipRead>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.MetaUser>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.OrganizationRead>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ProjectRead>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityReport>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityRequirementListItem>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualitySettings>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Request>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.TaskRead>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.UserGrowthData>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.WebhookDeliveryRead>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.WebhookRead>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributeRequest>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SublabelRequest>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.PatchedLabelRequest>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityRequirementListItemRequest>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.PlannedActivitiesEnum>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.EventsEnum>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityReportRequirementSummaryItem>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityRequirementBulkCreateNodeRequest>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributedShapeRequest>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.UserAgreement>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.UserAgreementRequest>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ThresholdPolicyPoint>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ThresholdPolicyPointRequest>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SocialAuthMethods>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AnnotationRequest>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionCall>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityRequirement>? ListType89 { get; set; }
    }
}