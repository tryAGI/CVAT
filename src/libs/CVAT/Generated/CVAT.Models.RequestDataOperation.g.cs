
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestDataOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public int? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_id")]
        public string? FunctionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lightweight")]
        public bool? Lightweight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDataOperation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="target"></param>
        /// <param name="projectId"></param>
        /// <param name="taskId"></param>
        /// <param name="jobId"></param>
        /// <param name="format"></param>
        /// <param name="functionId"></param>
        /// <param name="lightweight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestDataOperation(
            string type,
            string target,
            int? projectId,
            int? taskId,
            int? jobId,
            string? format,
            string? functionId,
            bool? lightweight)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.ProjectId = projectId;
            this.TaskId = taskId;
            this.JobId = jobId;
            this.Format = format;
            this.FunctionId = functionId;
            this.Lightweight = lightweight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDataOperation" /> class.
        /// </summary>
        public RequestDataOperation()
        {
        }
    }
}