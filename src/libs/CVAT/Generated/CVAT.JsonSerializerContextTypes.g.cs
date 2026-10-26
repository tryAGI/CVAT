
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
        public global::CVAT.AnnotationConflictAnnotationType? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationFileRequest? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationGuideRead? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationGuideWriteRequest? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.ShapeType2?, global::CVAT.NullEnum?>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ShapeType2? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.NullEnum? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationRequest? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationRequestFunction? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AnnotationTypeEnum? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Count? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ArAssignment? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ArParams? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ArType? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntry>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelMappingEntry? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Shape>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Shape? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ArParamsRequest? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntryRequest>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelMappingEntryRequest? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ShapeRequest>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ShapeRequest? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AssetRead? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AssetWriteRequest? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Attribute? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.InputTypeEnum? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeComparison? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeComparisonDefaultRule? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributeComparisonRule>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeComparisonRule? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ComparatorEnum? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeComparisonDefaultRuleRequest? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeComparisonRequest? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributeComparisonRuleRequest>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeComparisonRuleRequest? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeRequest? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeVal? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributeValRequest? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.AttributedShapeRequest? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributeValRequest>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.BasicOrganization? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.BasicUserRequest? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.BlankEnum? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Chapter? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ChapterMetadata? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ChunkType? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ClientEvents? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Event>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Event? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ClientEventsRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.EventRequest>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.EventRequest? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CloudStorageContent? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FileInfo>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FileInfo? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CloudStorageRead? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProviderTypeEnum? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CredentialsTypeEnum? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CloudStorageWriteRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CommentRead? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CommentWriteRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CommentsSummary? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ConsensusMergeCreateRequest? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ConsensusSettings? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CreateAnalyticsReportBodyRequest? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CreatedViaEnum? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CurrentLimit? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Type2c0Enum? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LimitsField? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CvatUsageReasonEnum? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.DataMetaRead? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Chapter>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FrameMeta>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FrameMeta? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.StorageType? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.DataRequest? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.StorageMethod? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SortingMethod? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ValidationParamsRequest? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.DataResponse? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RqId? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.DatasetFileRequest? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.DatasetFormat? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.DatasetFormats? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.DatasetFormat>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.EventGroup? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Events? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.WebhooksEvent>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhooksEvent? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.EventsEnum? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FileInfoTypeEnum? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FrameSelectionMethod? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Function? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.KindEnum? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionLabel>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionLabel? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ShapeType2>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.VisibilityEnum? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionAttribute? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionAttributeRequest? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionCall? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionCallParams? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionCallRequest? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionIdAndArParamsRequest? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelType? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionAttribute>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionSublabel>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionSublabel? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionLabelRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionAttributeRequest>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionSublabelRequest>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionSublabelRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FunctionRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionLabelRequest>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.InvitationRead? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RoleEnum? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.InvitationWriteRequest? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.IssueRead? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.IssueWriteRequest? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.IssuesSummary? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobRead? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobStatus? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobStage? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OperationStatus? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelsSummary? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Storage? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidation? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityTargetMetric? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.JobValidationRequirement>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidationRequirement? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidationStatusEnum? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidationCreateRequest? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobValidationLayoutRead? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobWriteRequest? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsSummary? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Label? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Attribute>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Sublabel>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Sublabel? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.SublabelMappingEntry>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SublabelMappingEntry? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.SublabelMappingEntryRequest>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SublabelMappingEntryRequest? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledData? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledImage>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledImage? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledShape>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledShape? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledTrack>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledTrack? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledInterval>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledInterval? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledDataRequest? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledImageRequest>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledImageRequest? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledShapeRequest>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledShapeRequest? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledTrackRequest>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledTrackRequest? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.LabeledIntervalRequest>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabeledIntervalRequest? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributeVal>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledShape>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SubLabeledShape? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledShapeRequest>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SubLabeledShapeRequest? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.TrackedShape>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TrackedShape? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledTrack>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SubLabeledTrack? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.TrackedShapeRequest>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TrackedShapeRequest? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledTrackRequest>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SubLabeledTrackRequest? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Limit? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LimitRequest? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LimitsFieldRequest? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LocationEnum? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LoginSerializerExRequest? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.MembershipRead? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.MetaUser? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.User? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.NumericUsage? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OnlineFunctionCallRequest? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OrganizationRead? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OrganizationWriteRequest? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedAccessTokenReadList? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AccessTokenRead>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedAnnotationConflictList? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AnnotationConflict>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedCloudStorageReadList? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.CloudStorageRead>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedCommentReadList? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.CommentRead>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedConsensusSettingsList? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ConsensusSettings>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedFunctionList? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Function>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedInvitationReadList? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.InvitationRead>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedIssueReadList? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.IssueRead>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedJobReadList? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.JobRead>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedJobValidationList? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.JobValidation>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedLabelList? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Label>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedLimitList? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Limit>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedMembershipReadList? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.MembershipRead>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedMetaUserList? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.MetaUser>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedOrganizationReadList? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.OrganizationRead>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedProjectReadList? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.ProjectRead>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectRead? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedQualityReportList? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityReport>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReport? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedQualityRequirementListItemList? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItem>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementListItem? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedQualitySettingsList? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualitySettings>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualitySettings? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedRequestList? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.Request>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Request? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedTaskReadList? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.TaskRead>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TaskRead? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedUserGrowthDataList? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.UserGrowthData>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.UserGrowthData? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedWebhookDeliveryReadList? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.WebhookDeliveryRead>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookDeliveryRead? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PaginatedWebhookReadList? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.WebhookRead>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookRead? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PasswordChangeRequest? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PasswordResetConfirmRequest? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PasswordResetSerializerExRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedAccessTokenWriteRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedAnnotationGuideWriteRequest? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedCloudStorageWriteRequest? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedCommentWriteRequest? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedConsensusSettingsRequest? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedDataMetaWriteRequest? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedIssueWriteRequest? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedJobDataMetaWriteRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedJobValidationLayoutWriteRequest? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedJobWriteRequest? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedLabelRequest? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributeRequest>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SublabelRequest>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SublabelRequest? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedLabeledDataRequest? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedLimitRequest? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedMembershipWriteRequest? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedOrganizationWriteRequest? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedProjectWriteRequest? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.StorageRequest? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedQualityRequirementRequest? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityPointSizeBase? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedQualitySettingsRequest? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItemRequest>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementListItemRequest? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedTaskValidationLayoutWriteRequest? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedTaskWriteRequest? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedUserGrowthDataRequest? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedUserRequest? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.CvatUsageReasonEnum?, global::CVAT.BlankEnum?>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.PlannedActivitiesEnum>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PlannedActivitiesEnum? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.PatchedWebhookWriteRequest? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookContentType? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.EventsEnum>? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Plugins? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectFileRequest? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksSummary? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectWriteRequest? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportSummary? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportConfusionMatrix? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportConfusionMatrixAxes? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTargetMetricSummary? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportCreateRequest? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportJobsSummary? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportRequirementCalculation? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportRequirementCalculationStatusEnum? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.ReasonEnum?, global::CVAT.NullEnum?>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ReasonEnum? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportRequirementSummaryItem? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportScoreComponents? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportRequirementsSummary? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityReportRequirementSummaryItem>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTasksSummary? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTargetMetricSummaryMetricEnum? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityReportTargetMetricValues? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirement? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementBulkCreateNodeRequest? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirementBulkCreateNodeRequest>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementBulkCreateRequest? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRequirementRequest? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualitySettingsRequest? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestAcquireInputRequest? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RequestCategoryEnum? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestAcquireOutput? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestCompleteInputRequest? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AttributedShapeRequest>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestFailInputRequest? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QueueRequestUpdateInputRequest? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RegisterSerializerWithSubscriptions? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.UserAgreement>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.UserAgreement? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RegisterSerializerWithSubscriptionsRequest? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.UserAgreementRequest>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.UserAgreementRequest? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RequestStatus? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RequestDataOperation? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.UserIdentifiers? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RestAuthDetail? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RqStatus? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RqStatusStateEnum? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SSOAuthMethod? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SelectionSchemaEnum? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SSOLoginURL? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SocialAuthMethod? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SocialAuthMethods? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SocialLoginSerializerExRequest? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TaskFileRequest? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TaskValidationLayoutRead? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.ValidationMode?, global::CVAT.NullEnum?>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ValidationMode? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TaskWriteRequest? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Token? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.Usage? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.OneOf<global::CVAT.CreatedViaEnum?, global::CVAT.NullEnum?>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookType? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhookWriteRequest? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CloudstoragesListCredentialsType? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.CloudstoragesListProviderType? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.EventsListAction? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.EventsCreateExportLocation? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListDimension? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListMediaType? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListMode? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListStage? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListState? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsListType? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsRetrieveAnnotationsLocation? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsCreateAnnotationsImportMode? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsCreateAnnotationsLocation? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsPartialUpdateAnnotationsAction? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsRetrieveDataQuality? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsRetrieveDataType? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobsCreateDatasetExportLocation? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.LabelsListType? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.MembershipsListRole? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsListStatus? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsCreateBackupExportLocation? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsCreateDatasetLocation? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsCreateDatasetExportLocation? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ProjectsCreateBackupLocation? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListConflictsSeverity? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListConflictsType? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListJobValidationsStatus? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListReportsTarget? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRetrieveReportRequirementConfusionFormat? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityRetrieveReportDataFormat? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListSettingsParentType? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.QualityListSettingsRequirementsAnnotationType? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RequestsListStatus? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SchemaRetrieveLang? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.SchemaRetrieveScheme? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListDimension? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListMediaType? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListMode? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListStatus? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksListValidationMode? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateAnnotationsImportMode? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateAnnotationsLocation? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksPartialUpdateAnnotationsAction? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateBackupExportLocation? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksRetrieveDataQuality? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksRetrieveDataType? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateDatasetExportLocation? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.TasksCreateBackupLocation? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhooksListType? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.WebhooksRetrieveEventsType? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.SocialAuthMethods>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.AnnotationRequest>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.FunctionCall>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirement>? Type440 { get; set; }

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
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Shape>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ShapeRequest>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributeComparisonRule>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributeComparisonRuleRequest>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributeValRequest>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Event>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.EventRequest>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FileInfo>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Chapter>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FrameMeta>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.DatasetFormat>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.WebhooksEvent>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionLabel>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ShapeType2>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionAttribute>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionSublabel>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionAttributeRequest>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionSublabelRequest>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionLabelRequest>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.JobValidationRequirement>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Attribute>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Sublabel>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledImage>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledShape>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledTrack>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledInterval>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledImageRequest>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledShapeRequest>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledTrackRequest>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.LabeledIntervalRequest>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributeVal>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SubLabeledShape>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SubLabeledShapeRequest>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.TrackedShape>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SubLabeledTrack>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.TrackedShapeRequest>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SubLabeledTrackRequest>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AccessTokenRead>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AnnotationConflict>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.CloudStorageRead>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.CommentRead>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ConsensusSettings>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Function>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.InvitationRead>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.IssueRead>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.JobRead>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.JobValidation>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Label>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Limit>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.MembershipRead>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.MetaUser>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.OrganizationRead>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.ProjectRead>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityReport>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityRequirementListItem>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualitySettings>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.Request>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.TaskRead>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.UserGrowthData>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.WebhookDeliveryRead>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.WebhookRead>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributeRequest>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SublabelRequest>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.PatchedLabelRequest>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityRequirementListItemRequest>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.PlannedActivitiesEnum>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.EventsEnum>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityReportRequirementSummaryItem>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityRequirementBulkCreateNodeRequest>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AttributedShapeRequest>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.UserAgreement>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.UserAgreementRequest>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.SocialAuthMethods>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.AnnotationRequest>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.FunctionCall>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.QualityRequirement>? ListType86 { get; set; }
    }
}