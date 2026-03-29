
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueRequestAcquireInputRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// * `interactive` - Interactive<br/>
        /// * `batch` - Batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.RequestCategoryEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.RequestCategoryEnum RequestCategory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueRequestAcquireInputRequest" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestCategory">
        /// * `interactive` - Interactive<br/>
        /// * `batch` - Batch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueRequestAcquireInputRequest(
            string agentId,
            global::CVAT.RequestCategoryEnum requestCategory)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.RequestCategory = requestCategory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueRequestAcquireInputRequest" /> class.
        /// </summary>
        public QueueRequestAcquireInputRequest()
        {
        }
    }
}