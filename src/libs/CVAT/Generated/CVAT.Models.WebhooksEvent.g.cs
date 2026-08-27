
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhooksEvent
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public global::CVAT.EventGroup? Group { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksEvent" /> class.
        /// </summary>
        /// <param name="key">
        /// Included only in responses
        /// </param>
        /// <param name="group">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksEvent(
            string? key,
            global::CVAT.EventGroup? group)
        {
            this.Key = key;
            this.Group = group;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksEvent" /> class.
        /// </summary>
        public WebhooksEvent()
        {
        }

    }
}