
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueRequestCompleteInputRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::CVAT.LabeledDataRequest? Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shapes")]
        public global::System.Collections.Generic.IList<global::CVAT.ShapeRequest>? Shapes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("states")]
        public global::System.Collections.Generic.IList<string>? States { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueRequestCompleteInputRequest" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="annotations"></param>
        /// <param name="shapes"></param>
        /// <param name="states"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueRequestCompleteInputRequest(
            string agentId,
            global::CVAT.LabeledDataRequest? annotations,
            global::System.Collections.Generic.IList<global::CVAT.ShapeRequest>? shapes,
            global::System.Collections.Generic.IList<string>? states)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Annotations = annotations;
            this.Shapes = shapes;
            this.States = states;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueRequestCompleteInputRequest" /> class.
        /// </summary>
        public QueueRequestCompleteInputRequest()
        {
        }
    }
}