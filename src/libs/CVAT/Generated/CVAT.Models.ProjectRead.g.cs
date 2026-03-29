
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectRead
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
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::CVAT.BasicUser? Owner { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public global::CVAT.BasicUser? Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guide_id")]
        public int? GuideId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bug_tracker")]
        public string? BugTracker { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_subsets")]
        public global::System.Collections.Generic.IList<string>? TaskSubsets { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.JobStatusJsonConverter))]
        public global::CVAT.JobStatus? Status { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public string? Dimension { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Organization { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_storage")]
        public global::CVAT.Storage? TargetStorage { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_storage")]
        public global::CVAT.Storage? SourceStorage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.TasksSummary Tasks { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRead" /> class.
        /// </summary>
        /// <param name="tasks"></param>
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
        /// <param name="owner">
        /// Included only in responses
        /// </param>
        /// <param name="assignee">
        /// Included only in responses
        /// </param>
        /// <param name="guideId"></param>
        /// <param name="bugTracker">
        /// Included only in responses
        /// </param>
        /// <param name="taskSubsets">
        /// Included only in responses
        /// </param>
        /// <param name="createdDate">
        /// Included only in responses
        /// </param>
        /// <param name="updatedDate">
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Included only in responses
        /// </param>
        /// <param name="dimension">
        /// Included only in responses
        /// </param>
        /// <param name="organizationId">
        /// Included only in responses
        /// </param>
        /// <param name="targetStorage">
        /// Included only in responses
        /// </param>
        /// <param name="sourceStorage">
        /// Included only in responses
        /// </param>
        /// <param name="assigneeUpdatedDate">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectRead(
            global::CVAT.TasksSummary tasks,
            global::CVAT.LabelsSummary labels,
            string? url,
            int? id,
            string? name,
            global::CVAT.BasicUser? owner,
            global::CVAT.BasicUser? assignee,
            int? guideId,
            string? bugTracker,
            global::System.Collections.Generic.IList<string>? taskSubsets,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate,
            global::CVAT.JobStatus? status,
            string? dimension,
            int? organizationId,
            global::CVAT.Storage? targetStorage,
            global::CVAT.Storage? sourceStorage,
            global::System.DateTime? assigneeUpdatedDate)
        {
            this.Url = url;
            this.Id = id;
            this.Name = name;
            this.Owner = owner;
            this.Assignee = assignee;
            this.GuideId = guideId;
            this.BugTracker = bugTracker;
            this.TaskSubsets = taskSubsets;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.Status = status;
            this.Dimension = dimension;
            this.OrganizationId = organizationId;
            this.TargetStorage = targetStorage;
            this.SourceStorage = sourceStorage;
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.AssigneeUpdatedDate = assigneeUpdatedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRead" /> class.
        /// </summary>
        public ProjectRead()
        {
        }
    }
}