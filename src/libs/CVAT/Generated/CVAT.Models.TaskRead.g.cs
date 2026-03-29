
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskRead
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
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
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::CVAT.BasicUser? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public global::CVAT.BasicUser? Assignee { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bug_tracker")]
        public string? BugTracker { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("overlap")]
        public int? Overlap { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_size")]
        public int? SegmentSize { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.JobStatusJsonConverter))]
        public global::CVAT.JobStatus? Status { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_chunk_size")]
        public int? DataChunkSize { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_original_chunk_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.ChunkTypeJsonConverter))]
        public global::CVAT.ChunkType? DataOriginalChunkType { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_compressed_chunk_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.ChunkTypeJsonConverter))]
        public global::CVAT.ChunkType? DataCompressedChunkType { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_cloud_storage_id")]
        public int? DataCloudStorageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guide_id")]
        public int? GuideId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_quality")]
        public int? ImageQuality { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public int? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public string? Dimension { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subset")]
        public string? Subset { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Obsolete("This property marked as deprecated.")]
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.JobsSummary Jobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.LabelsSummary Labels { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee_updated_date")]
        public global::System.DateTime? AssigneeUpdatedDate { get; set; }

        /// <summary>
        /// Describes how the task validation is performed. Configured at task creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_mode")]
        public string? ValidationMode { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensus_enabled")]
        public bool? ConsensusEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskRead" /> class.
        /// </summary>
        /// <param name="jobs"></param>
        /// <param name="labels"></param>
        /// <param name="url">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// Included only in responses
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="projectName">
        /// Included only in responses
        /// </param>
        /// <param name="mode">
        /// Included only in responses
        /// </param>
        /// <param name="owner"></param>
        /// <param name="assignee"></param>
        /// <param name="bugTracker">
        /// Included only in responses
        /// </param>
        /// <param name="createdDate">
        /// Included only in responses
        /// </param>
        /// <param name="updatedDate">
        /// Included only in responses
        /// </param>
        /// <param name="overlap">
        /// Included only in responses
        /// </param>
        /// <param name="segmentSize">
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Included only in responses
        /// </param>
        /// <param name="dataChunkSize">
        /// Included only in responses
        /// </param>
        /// <param name="dataOriginalChunkType">
        /// Included only in responses
        /// </param>
        /// <param name="dataCompressedChunkType">
        /// Included only in responses
        /// </param>
        /// <param name="dataCloudStorageId">
        /// Included only in responses
        /// </param>
        /// <param name="guideId"></param>
        /// <param name="size">
        /// Included only in responses
        /// </param>
        /// <param name="imageQuality">
        /// Included only in responses
        /// </param>
        /// <param name="data">
        /// Included only in responses
        /// </param>
        /// <param name="dimension"></param>
        /// <param name="subset">
        /// Included only in responses
        /// </param>
        /// <param name="organizationId">
        /// Included only in responses
        /// </param>
        /// <param name="targetStorage"></param>
        /// <param name="sourceStorage"></param>
        /// <param name="assigneeUpdatedDate">
        /// Included only in responses
        /// </param>
        /// <param name="validationMode">
        /// Describes how the task validation is performed. Configured at task creation
        /// </param>
        /// <param name="consensusEnabled">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskRead(
            global::CVAT.JobsSummary jobs,
            global::CVAT.LabelsSummary labels,
            string? url,
            int? id,
            string? name,
            int? projectId,
            string? projectName,
            string? mode,
            global::CVAT.BasicUser? owner,
            global::CVAT.BasicUser? assignee,
            string? bugTracker,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate,
            int? overlap,
            int? segmentSize,
            global::CVAT.JobStatus? status,
            int? dataChunkSize,
            global::CVAT.ChunkType? dataOriginalChunkType,
            global::CVAT.ChunkType? dataCompressedChunkType,
            int? dataCloudStorageId,
            int? guideId,
            int? size,
            int? imageQuality,
            int? data,
            string? dimension,
            string? subset,
            int? organizationId,
            global::CVAT.Storage? targetStorage,
            global::CVAT.Storage? sourceStorage,
            global::System.DateTime? assigneeUpdatedDate,
            string? validationMode,
            bool? consensusEnabled)
        {
            this.Url = url;
            this.Id = id;
            this.Name = name;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Mode = mode;
            this.Owner = owner;
            this.Assignee = assignee;
            this.BugTracker = bugTracker;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.Overlap = overlap;
            this.SegmentSize = segmentSize;
            this.Status = status;
            this.DataChunkSize = dataChunkSize;
            this.DataOriginalChunkType = dataOriginalChunkType;
            this.DataCompressedChunkType = dataCompressedChunkType;
            this.DataCloudStorageId = dataCloudStorageId;
            this.GuideId = guideId;
            this.Size = size;
            this.ImageQuality = imageQuality;
            this.Data = data;
            this.Dimension = dimension;
            this.Subset = subset;
            this.OrganizationId = organizationId;
            this.TargetStorage = targetStorage;
            this.SourceStorage = sourceStorage;
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.AssigneeUpdatedDate = assigneeUpdatedDate;
            this.ValidationMode = validationMode;
            this.ConsensusEnabled = consensusEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskRead" /> class.
        /// </summary>
        public TaskRead()
        {
        }
    }
}