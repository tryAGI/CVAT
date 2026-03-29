
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedAnnotationGuideWriteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public int? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAnnotationGuideWriteRequest" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="projectId"></param>
        /// <param name="markdown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedAnnotationGuideWriteRequest(
            int? taskId,
            int? projectId,
            string? markdown)
        {
            this.TaskId = taskId;
            this.ProjectId = projectId;
            this.Markdown = markdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAnnotationGuideWriteRequest" /> class.
        /// </summary>
        public PatchedAnnotationGuideWriteRequest()
        {
        }
    }
}