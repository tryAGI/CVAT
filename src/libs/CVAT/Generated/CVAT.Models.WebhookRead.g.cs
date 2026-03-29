
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRead
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_url")]
        public string? TargetUrl { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// * `organization` - ORGANIZATION<br/>
        /// * `project` - PROJECT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.WebhookTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.WebhookType Type { get; set; }

        /// <summary>
        /// * `application/json` - JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.WebhookContentTypeJsonConverter))]
        public global::CVAT.WebhookContentType ContentType { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_ssl")]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_date")]
        public global::System.DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::CVAT.BasicUser? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::CVAT.EventsEnum>? Events { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_status")]
        public int? LastStatus { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_delivery_date")]
        public global::System.DateTime? LastDeliveryDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRead" /> class.
        /// </summary>
        /// <param name="type">
        /// * `organization` - ORGANIZATION<br/>
        /// * `project` - PROJECT
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="url">
        /// Included only in responses
        /// </param>
        /// <param name="targetUrl">
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Included only in responses
        /// </param>
        /// <param name="contentType">
        /// * `application/json` - JSON
        /// </param>
        /// <param name="isActive">
        /// Included only in responses
        /// </param>
        /// <param name="enableSsl">
        /// Included only in responses
        /// </param>
        /// <param name="createdDate">
        /// Included only in responses
        /// </param>
        /// <param name="updatedDate">
        /// Included only in responses
        /// </param>
        /// <param name="owner">
        /// Included only in responses
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organization">
        /// Included only in responses
        /// </param>
        /// <param name="events">
        /// Included only in responses
        /// </param>
        /// <param name="lastStatus">
        /// Included only in responses
        /// </param>
        /// <param name="lastDeliveryDate">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRead(
            global::CVAT.WebhookType type,
            int? id,
            string? url,
            string? targetUrl,
            string? description,
            global::CVAT.WebhookContentType contentType,
            bool? isActive,
            bool? enableSsl,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate,
            global::CVAT.BasicUser? owner,
            int? projectId,
            int? organization,
            global::System.Collections.Generic.IList<global::CVAT.EventsEnum>? events,
            int? lastStatus,
            global::System.DateTime? lastDeliveryDate)
        {
            this.Id = id;
            this.Url = url;
            this.TargetUrl = targetUrl;
            this.Description = description;
            this.Type = type;
            this.ContentType = contentType;
            this.IsActive = isActive;
            this.EnableSsl = enableSsl;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.Owner = owner;
            this.ProjectId = projectId;
            this.Organization = organization;
            this.Events = events;
            this.LastStatus = lastStatus;
            this.LastDeliveryDate = lastDeliveryDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRead" /> class.
        /// </summary>
        public WebhookRead()
        {
        }
    }
}