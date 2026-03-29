
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Events
    {
        /// <summary>
        /// * `organization` - ORGANIZATION<br/>
        /// * `project` - PROJECT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.WebhookTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.WebhookType WebhookType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CVAT.EventsEnum> Events1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Events" /> class.
        /// </summary>
        /// <param name="webhookType">
        /// * `organization` - ORGANIZATION<br/>
        /// * `project` - PROJECT
        /// </param>
        /// <param name="events1"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Events(
            global::CVAT.WebhookType webhookType,
            global::System.Collections.Generic.IList<global::CVAT.EventsEnum> events1)
        {
            this.WebhookType = webhookType;
            this.Events1 = events1 ?? throw new global::System.ArgumentNullException(nameof(events1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Events" /> class.
        /// </summary>
        public Events()
        {
        }
    }
}