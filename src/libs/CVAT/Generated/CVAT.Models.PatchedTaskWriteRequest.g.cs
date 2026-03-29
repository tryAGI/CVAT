
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedTaskWriteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedTaskWriteRequest" /> class.
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
        /// <param name="labels"></param>
        /// <param name="subset"></param>
        /// <param name="targetStorage"></param>
        /// <param name="sourceStorage"></param>
        /// <param name="organizationId">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedTaskWriteRequest(
            string? name,
            int? projectId,
            int? ownerId,
            int? assigneeId,
            string? bugTracker,
            global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>? labels,
            string? subset,
            global::CVAT.StorageRequest? targetStorage,
            global::CVAT.StorageRequest? sourceStorage,
            int? organizationId)
        {
            this.Name = name;
            this.ProjectId = projectId;
            this.OwnerId = ownerId;
            this.AssigneeId = assigneeId;
            this.BugTracker = bugTracker;
            this.Labels = labels;
            this.Subset = subset;
            this.TargetStorage = targetStorage;
            this.SourceStorage = sourceStorage;
            this.OrganizationId = organizationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedTaskWriteRequest" /> class.
        /// </summary>
        public PatchedTaskWriteRequest()
        {
        }
    }
}