
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobValidationCreateRequest
    {
        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int? JobId { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobValidationCreateRequest" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Included only in requests
        /// </param>
        /// <param name="timeout">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobValidationCreateRequest(
            int? jobId,
            int? timeout)
        {
            this.JobId = jobId;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobValidationCreateRequest" /> class.
        /// </summary>
        public JobValidationCreateRequest()
        {
        }
    }
}