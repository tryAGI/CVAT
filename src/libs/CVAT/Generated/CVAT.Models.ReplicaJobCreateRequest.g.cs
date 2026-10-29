
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReplicaJobCreateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public int? Assignee { get; set; }

        /// <summary>
        /// * `replica` - REPLICA
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.ReplicaJobCreateTypeEnumJsonConverter))]
        public global::CVAT.ReplicaJobCreateTypeEnum Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TaskId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ParentJobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicaJobCreateRequest" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="parentJobId"></param>
        /// <param name="assignee"></param>
        /// <param name="type">
        /// * `replica` - REPLICA
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicaJobCreateRequest(
            int taskId,
            int parentJobId,
            int? assignee,
            global::CVAT.ReplicaJobCreateTypeEnum type)
        {
            this.Assignee = assignee;
            this.Type = type;
            this.TaskId = taskId;
            this.ParentJobId = parentJobId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicaJobCreateRequest" /> class.
        /// </summary>
        public ReplicaJobCreateRequest()
        {
        }

    }
}