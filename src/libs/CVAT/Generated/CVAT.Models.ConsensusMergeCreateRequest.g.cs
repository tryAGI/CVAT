
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsensusMergeCreateRequest
    {
        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public int? TaskId { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int? JobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusMergeCreateRequest" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Included only in requests
        /// </param>
        /// <param name="jobId">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsensusMergeCreateRequest(
            int? taskId,
            int? jobId)
        {
            this.TaskId = taskId;
            this.JobId = jobId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusMergeCreateRequest" /> class.
        /// </summary>
        public ConsensusMergeCreateRequest()
        {
        }
    }
}