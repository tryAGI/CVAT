
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.AnnotationRequestFunction Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enqueued")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Enqueued { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Started { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Ended { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exc_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExcInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="function"></param>
        /// <param name="status"></param>
        /// <param name="progress"></param>
        /// <param name="enqueued"></param>
        /// <param name="started"></param>
        /// <param name="ended"></param>
        /// <param name="excInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationRequest(
            string id,
            global::CVAT.AnnotationRequestFunction function,
            string status,
            int progress,
            global::System.DateTime enqueued,
            global::System.DateTime started,
            global::System.DateTime ended,
            string excInfo)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Progress = progress;
            this.Enqueued = enqueued;
            this.Started = started;
            this.Ended = ended;
            this.ExcInfo = excInfo ?? throw new global::System.ArgumentNullException(nameof(excInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationRequest" /> class.
        /// </summary>
        public AnnotationRequest()
        {
        }
    }
}