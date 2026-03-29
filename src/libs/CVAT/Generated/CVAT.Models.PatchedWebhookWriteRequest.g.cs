
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedWebhookWriteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_url")]
        public string? TargetUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// * `application/json` - JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.WebhookContentTypeJsonConverter))]
        public global::CVAT.WebhookContentType? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_ssl")]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::CVAT.EventsEnum>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedWebhookWriteRequest" /> class.
        /// </summary>
        /// <param name="targetUrl"></param>
        /// <param name="description"></param>
        /// <param name="contentType">
        /// * `application/json` - JSON
        /// </param>
        /// <param name="secret"></param>
        /// <param name="isActive"></param>
        /// <param name="enableSsl"></param>
        /// <param name="events">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedWebhookWriteRequest(
            string? targetUrl,
            string? description,
            global::CVAT.WebhookContentType? contentType,
            string? secret,
            bool? isActive,
            bool? enableSsl,
            global::System.Collections.Generic.IList<global::CVAT.EventsEnum>? events)
        {
            this.TargetUrl = targetUrl;
            this.Description = description;
            this.ContentType = contentType;
            this.Secret = secret;
            this.IsActive = isActive;
            this.EnableSsl = enableSsl;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedWebhookWriteRequest" /> class.
        /// </summary>
        public PatchedWebhookWriteRequest()
        {
        }
    }
}