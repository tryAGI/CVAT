
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationConflict
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame")]
        public int? Frame { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.AnnotationConflictTypeJsonConverter))]
        public global::CVAT.AnnotationConflictType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CVAT.AnnotationId> AnnotationIds { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_id")]
        public int? ReportId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.AnnotationConflictSeverityJsonConverter))]
        public global::CVAT.AnnotationConflictSeverity? Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationConflict" /> class.
        /// </summary>
        /// <param name="annotationIds"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="frame">
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// Included only in responses
        /// </param>
        /// <param name="reportId">
        /// Included only in responses
        /// </param>
        /// <param name="severity">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationConflict(
            global::System.Collections.Generic.IList<global::CVAT.AnnotationId> annotationIds,
            int? id,
            int? frame,
            global::CVAT.AnnotationConflictType? type,
            int? reportId,
            global::CVAT.AnnotationConflictSeverity? severity)
        {
            this.Id = id;
            this.Frame = frame;
            this.Type = type;
            this.AnnotationIds = annotationIds ?? throw new global::System.ArgumentNullException(nameof(annotationIds));
            this.ReportId = reportId;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationConflict" /> class.
        /// </summary>
        public AnnotationConflict()
        {
        }
    }
}