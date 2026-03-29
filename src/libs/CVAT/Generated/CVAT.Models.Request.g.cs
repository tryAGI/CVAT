
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request
    {
        /// <summary>
        /// * `queued` - Queued<br/>
        /// * `started` - Started<br/>
        /// * `failed` - Failed<br/>
        /// * `finished` - Finished
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.RequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.RequestStatus Status { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.RequestDataOperation Operation { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_date")]
        public global::System.DateTime? StartedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_date")]
        public global::System.DateTime? FinishedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiry_date")]
        public global::System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::CVAT.UserIdentifiers? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_id")]
        public int? ResultId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        /// <param name="status">
        /// * `queued` - Queued<br/>
        /// * `started` - Started<br/>
        /// * `failed` - Failed<br/>
        /// * `finished` - Finished
        /// </param>
        /// <param name="id"></param>
        /// <param name="operation"></param>
        /// <param name="createdDate"></param>
        /// <param name="message">
        /// Included only in responses
        /// </param>
        /// <param name="progress">
        /// Included only in responses
        /// </param>
        /// <param name="startedDate"></param>
        /// <param name="finishedDate"></param>
        /// <param name="expiryDate">
        /// Included only in responses
        /// </param>
        /// <param name="owner">
        /// Included only in responses
        /// </param>
        /// <param name="resultUrl"></param>
        /// <param name="resultId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request(
            global::CVAT.RequestStatus status,
            string id,
            global::CVAT.RequestDataOperation operation,
            global::System.DateTime createdDate,
            string? message,
            double? progress,
            global::System.DateTime? startedDate,
            global::System.DateTime? finishedDate,
            global::System.DateTime? expiryDate,
            global::CVAT.UserIdentifiers? owner,
            string? resultUrl,
            int? resultId)
        {
            this.Status = status;
            this.Message = message;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
            this.Progress = progress;
            this.CreatedDate = createdDate;
            this.StartedDate = startedDate;
            this.FinishedDate = finishedDate;
            this.ExpiryDate = expiryDate;
            this.Owner = owner;
            this.ResultUrl = resultUrl;
            this.ResultId = resultId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        public Request()
        {
        }
    }
}