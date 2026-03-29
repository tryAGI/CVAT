
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OnlineFunctionCallRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public int? Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public int? Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineFunctionCallRequest" /> class.
        /// </summary>
        /// <param name="job"></param>
        /// <param name="task"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OnlineFunctionCallRequest(
            int? job,
            int? task)
        {
            this.Job = job;
            this.Task = task;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineFunctionCallRequest" /> class.
        /// </summary>
        public OnlineFunctionCallRequest()
        {
        }
    }
}