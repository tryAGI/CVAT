
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public int? OrgId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_ai_agent_calls")]
        public string? InternalAiAgentCalls { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ai_agent_calls")]
        public string? ExternalAiAgentCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="userId">
        /// Included only in responses
        /// </param>
        /// <param name="orgId">
        /// Included only in responses
        /// </param>
        /// <param name="internalAiAgentCalls">
        /// Included only in responses
        /// </param>
        /// <param name="externalAiAgentCalls">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Usage(
            int? userId,
            int? orgId,
            string? internalAiAgentCalls,
            string? externalAiAgentCalls)
        {
            this.UserId = userId;
            this.OrgId = orgId;
            this.InternalAiAgentCalls = internalAiAgentCalls;
            this.ExternalAiAgentCalls = externalAiAgentCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }
    }
}