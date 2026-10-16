
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NumericUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Tasks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Projects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_storages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CloudStorages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Webhooks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ai_agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExternalAiAgents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ai_agent_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExternalAiAgentCalls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_ai_agent_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InternalAiAgentCalls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_storage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long InternalStorageBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memberships")]
        public int? Memberships { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations")]
        public int? Organizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericUsage" /> class.
        /// </summary>
        /// <param name="tasks"></param>
        /// <param name="projects"></param>
        /// <param name="cloudStorages"></param>
        /// <param name="webhooks"></param>
        /// <param name="externalAiAgents"></param>
        /// <param name="externalAiAgentCalls"></param>
        /// <param name="internalAiAgentCalls"></param>
        /// <param name="internalStorageBytes"></param>
        /// <param name="memberships"></param>
        /// <param name="organizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumericUsage(
            int tasks,
            int projects,
            int cloudStorages,
            int webhooks,
            int externalAiAgents,
            int externalAiAgentCalls,
            int internalAiAgentCalls,
            long internalStorageBytes,
            int? memberships,
            int? organizations)
        {
            this.Tasks = tasks;
            this.Projects = projects;
            this.CloudStorages = cloudStorages;
            this.Webhooks = webhooks;
            this.ExternalAiAgents = externalAiAgents;
            this.ExternalAiAgentCalls = externalAiAgentCalls;
            this.InternalAiAgentCalls = internalAiAgentCalls;
            this.InternalStorageBytes = internalStorageBytes;
            this.Memberships = memberships;
            this.Organizations = organizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericUsage" /> class.
        /// </summary>
        public NumericUsage()
        {
        }

    }
}