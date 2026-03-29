
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionCallParams
    {
        /// <summary>
        /// The name of the function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The id of the task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public int? Task { get; set; }

        /// <summary>
        /// The id of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public int? Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallParams" /> class.
        /// </summary>
        /// <param name="id">
        /// The name of the function
        /// </param>
        /// <param name="task">
        /// The id of the task
        /// </param>
        /// <param name="job">
        /// The id of the job
        /// </param>
        /// <param name="threshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallParams(
            string? id,
            int? task,
            int? job,
            double? threshold)
        {
            this.Id = id;
            this.Task = task;
            this.Job = job;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallParams" /> class.
        /// </summary>
        public FunctionCallParams()
        {
        }
    }
}