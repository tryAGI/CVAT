
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RqStatus
    {
        /// <summary>
        /// * `Queued` - Queued<br/>
        /// * `Started` - Started<br/>
        /// * `Finished` - Finished<br/>
        /// * `Failed` - Failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.RqStatusStateEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.RqStatusStateEnum State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RqStatus" /> class.
        /// </summary>
        /// <param name="state">
        /// * `Queued` - Queued<br/>
        /// * `Started` - Started<br/>
        /// * `Finished` - Finished<br/>
        /// * `Failed` - Failed
        /// </param>
        /// <param name="message"></param>
        /// <param name="progress">
        /// Default Value: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RqStatus(
            global::CVAT.RqStatusStateEnum state,
            string? message,
            double? progress)
        {
            this.State = state;
            this.Message = message;
            this.Progress = progress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RqStatus" /> class.
        /// </summary>
        public RqStatus()
        {
        }
    }
}