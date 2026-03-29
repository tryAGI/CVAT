
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedProjectWriteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: []<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>? Labels { get; set; }

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
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_storage")]
        public global::CVAT.StorageRequest? TargetStorage { get; set; }

        /// <summary>
        /// Included only in requests
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
        /// Initializes a new instance of the <see cref="PatchedProjectWriteRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="labels">
        /// Default Value: []<br/>
        /// Included only in requests
        /// </param>
        /// <param name="ownerId">
        /// Included only in requests
        /// </param>
        /// <param name="assigneeId">
        /// Included only in requests
        /// </param>
        /// <param name="bugTracker"></param>
        /// <param name="targetStorage">
        /// Included only in requests
        /// </param>
        /// <param name="sourceStorage">
        /// Included only in requests
        /// </param>
        /// <param name="organizationId">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedProjectWriteRequest(
            string? name,
            global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>? labels,
            int? ownerId,
            int? assigneeId,
            string? bugTracker,
            global::CVAT.StorageRequest? targetStorage,
            global::CVAT.StorageRequest? sourceStorage,
            int? organizationId)
        {
            this.Name = name;
            this.Labels = labels;
            this.OwnerId = ownerId;
            this.AssigneeId = assigneeId;
            this.BugTracker = bugTracker;
            this.TargetStorage = targetStorage;
            this.SourceStorage = sourceStorage;
            this.OrganizationId = organizationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedProjectWriteRequest" /> class.
        /// </summary>
        public PatchedProjectWriteRequest()
        {
        }
    }
}