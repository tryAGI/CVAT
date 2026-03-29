
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationId
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("obj_id")]
        public int? ObjId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int? JobId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.AnnotationConflictAnnotationTypeJsonConverter))]
        public global::CVAT.AnnotationConflictAnnotationType? Type { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shape_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ShapeType2?, global::CVAT.NullEnum>))]
        public global::CVAT.OneOf<global::CVAT.ShapeType2?, global::CVAT.NullEnum>? ShapeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationId" /> class.
        /// </summary>
        /// <param name="objId">
        /// Included only in responses
        /// </param>
        /// <param name="jobId">
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// Included only in responses
        /// </param>
        /// <param name="shapeType">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationId(
            int? objId,
            int? jobId,
            global::CVAT.AnnotationConflictAnnotationType? type,
            global::CVAT.OneOf<global::CVAT.ShapeType2?, global::CVAT.NullEnum>? shapeType)
        {
            this.ObjId = objId;
            this.JobId = jobId;
            this.Type = type;
            this.ShapeType = shapeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationId" /> class.
        /// </summary>
        public AnnotationId()
        {
        }
    }
}