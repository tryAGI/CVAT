
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientEventsRequest
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::CVAT.EventRequest>? Events { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_event")]
        public global::CVAT.EventRequest? PreviousEvent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientEventsRequest" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="events">
        /// Default Value: []
        /// </param>
        /// <param name="previousEvent">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientEventsRequest(
            global::System.DateTime timestamp,
            global::System.Collections.Generic.IList<global::CVAT.EventRequest>? events,
            global::CVAT.EventRequest? previousEvent)
        {
            this.Events = events;
            this.PreviousEvent = previousEvent;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientEventsRequest" /> class.
        /// </summary>
        public ClientEventsRequest()
        {
        }
    }
}