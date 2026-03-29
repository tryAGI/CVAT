
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskWriteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee_id")]
        public int? AssigneeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bug_tracker")]
        public string? BugTracker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlap")]
        public int? Overlap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_size")]
        public int? SegmentSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subset")]
        public string? Subset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_storage")]
        public global::CVAT.StorageRequest? TargetStorage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_storage")]
        public global::CVAT.StorageRequest? SourceStorage { get; set; }

        /// <summary>
        /// The number of consensus replica jobs for each annotation job.<br/>
        /// Configured at task creation<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensus_replicas")]
        public int? ConsensusReplicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWriteRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="ownerId">
        /// Included only in requests
        /// </param>
        /// <param name="assigneeId">
        /// Included only in requests
        /// </param>
        /// <param name="bugTracker"></param>
        /// <param name="overlap"></param>
        /// <param name="segmentSize"></param>
        /// <param name="labels"></param>
        /// <param name="subset"></param>
        /// <param name="targetStorage"></param>
        /// <param name="sourceStorage"></param>
        /// <param name="consensusReplicas">
        /// The number of consensus replica jobs for each annotation job.<br/>
        /// Configured at task creation<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskWriteRequest(
            string name,
            int? projectId,
            int? ownerId,
            int? assigneeId,
            string? bugTracker,
            int? overlap,
            int? segmentSize,
            global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>? labels,
            string? subset,
            global::CVAT.StorageRequest? targetStorage,
            global::CVAT.StorageRequest? sourceStorage,
            int? consensusReplicas)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId;
            this.OwnerId = ownerId;
            this.AssigneeId = assigneeId;
            this.BugTracker = bugTracker;
            this.Overlap = overlap;
            this.SegmentSize = segmentSize;
            this.Labels = labels;
            this.Subset = subset;
            this.TargetStorage = targetStorage;
            this.SourceStorage = sourceStorage;
            this.ConsensusReplicas = consensusReplicas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWriteRequest" /> class.
        /// </summary>
        public TaskWriteRequest()
        {
        }
    }
}