
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobRead
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("task_name")]
        public string? TaskName { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public global::CVAT.BasicUser? Assignee { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guide_id")]
        public int? GuideId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public string? Dimension { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bug_tracker")]
        public string? BugTracker { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.JobStatusJsonConverter))]
        public global::CVAT.JobStatus? Status { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.JobStageJsonConverter))]
        public global::CVAT.JobStage? Stage { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OperationStatusJsonConverter))]
        public global::CVAT.OperationStatus? State { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_count")]
        public int? FrameCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame")]
        public int? StartFrame { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_frame")]
        public int? StopFrame { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_chunk_size")]
        public int? DataChunkSize { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_compressed_chunk_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.ChunkTypeJsonConverter))]
        public global::CVAT.ChunkType? DataCompressedChunkType { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_original_chunk_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.ChunkTypeJsonConverter))]
        public global::CVAT.ChunkType? DataOriginalChunkType { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.IssuesSummary Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.LabelsSummary Labels { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.JobTypeJsonConverter))]
        public global::CVAT.JobType? Type { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_storage")]
        public global::CVAT.Storage? TargetStorage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_storage")]
        public global::CVAT.Storage? SourceStorage { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee_updated_date")]
        public global::System.DateTime? AssigneeUpdatedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_job_id")]
        public int? ParentJobId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensus_replicas")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? ConsensusReplicas { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas_count")]
        public int? ReplicasCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobRead" /> class.
        /// </summary>
        /// <param name="issues"></param>
        /// <param name="labels"></param>
        /// <param name="url">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="taskId">
        /// Included only in responses
        /// </param>
        /// <param name="taskName">
        /// Included only in responses
        /// </param>
        /// <param name="projectId">
        /// Included only in responses
        /// </param>
        /// <param name="projectName">
        /// Included only in responses
        /// </param>
        /// <param name="assignee">
        /// Included only in responses
        /// </param>
        /// <param name="guideId">
        /// Included only in responses
        /// </param>
        /// <param name="dimension">
        /// Included only in responses
        /// </param>
        /// <param name="bugTracker">
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Included only in responses
        /// </param>
        /// <param name="stage">
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Included only in responses
        /// </param>
        /// <param name="mode">
        /// Included only in responses
        /// </param>
        /// <param name="frameCount">
        /// Included only in responses
        /// </param>
        /// <param name="startFrame">
        /// Included only in responses
        /// </param>
        /// <param name="stopFrame">
        /// Included only in responses
        /// </param>
        /// <param name="dataChunkSize">
        /// Included only in responses
        /// </param>
        /// <param name="dataCompressedChunkType">
        /// Included only in responses
        /// </param>
        /// <param name="dataOriginalChunkType">
        /// Included only in responses
        /// </param>
        /// <param name="createdDate">
        /// Included only in responses
        /// </param>
        /// <param name="updatedDate">
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// Included only in responses
        /// </param>
        /// <param name="organization">
        /// Included only in responses
        /// </param>
        /// <param name="targetStorage"></param>
        /// <param name="sourceStorage"></param>
        /// <param name="assigneeUpdatedDate">
        /// Included only in responses
        /// </param>
        /// <param name="parentJobId">
        /// Included only in responses
        /// </param>
        /// <param name="replicasCount">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobRead(
            global::CVAT.IssuesSummary issues,
            global::CVAT.LabelsSummary labels,
            string? url,
            int? id,
            int? taskId,
            string? taskName,
            int? projectId,
            string? projectName,
            global::CVAT.BasicUser? assignee,
            int? guideId,
            string? dimension,
            string? bugTracker,
            global::CVAT.JobStatus? status,
            global::CVAT.JobStage? stage,
            global::CVAT.OperationStatus? state,
            string? mode,
            int? frameCount,
            int? startFrame,
            int? stopFrame,
            int? dataChunkSize,
            global::CVAT.ChunkType? dataCompressedChunkType,
            global::CVAT.ChunkType? dataOriginalChunkType,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate,
            global::CVAT.JobType? type,
            int? organization,
            global::CVAT.Storage? targetStorage,
            global::CVAT.Storage? sourceStorage,
            global::System.DateTime? assigneeUpdatedDate,
            int? parentJobId,
            int? replicasCount)
        {
            this.Url = url;
            this.Id = id;
            this.TaskId = taskId;
            this.TaskName = taskName;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Assignee = assignee;
            this.GuideId = guideId;
            this.Dimension = dimension;
            this.BugTracker = bugTracker;
            this.Status = status;
            this.Stage = stage;
            this.State = state;
            this.Mode = mode;
            this.FrameCount = frameCount;
            this.StartFrame = startFrame;
            this.StopFrame = stopFrame;
            this.DataChunkSize = dataChunkSize;
            this.DataCompressedChunkType = dataCompressedChunkType;
            this.DataOriginalChunkType = dataOriginalChunkType;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.Issues = issues ?? throw new global::System.ArgumentNullException(nameof(issues));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Type = type;
            this.Organization = organization;
            this.TargetStorage = targetStorage;
            this.SourceStorage = sourceStorage;
            this.AssigneeUpdatedDate = assigneeUpdatedDate;
            this.ParentJobId = parentJobId;
            this.ReplicasCount = replicasCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobRead" /> class.
        /// </summary>
        public JobRead()
        {
        }
    }
}