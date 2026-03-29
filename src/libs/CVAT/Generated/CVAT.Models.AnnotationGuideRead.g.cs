
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationGuideRead
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public int? TaskId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_date")]
        public global::System.DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationGuideRead" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="taskId">
        /// Included only in responses
        /// </param>
        /// <param name="projectId">
        /// Included only in responses
        /// </param>
        /// <param name="createdDate">
        /// Included only in responses
        /// </param>
        /// <param name="updatedDate">
        /// Included only in responses
        /// </param>
        /// <param name="markdown">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationGuideRead(
            int? id,
            int? taskId,
            int? projectId,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate,
            string? markdown)
        {
            this.Id = id;
            this.TaskId = taskId;
            this.ProjectId = projectId;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.Markdown = markdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationGuideRead" /> class.
        /// </summary>
        public AnnotationGuideRead()
        {
        }
    }
}