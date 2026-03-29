
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedJobWriteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public int? Assignee { get; set; }

        /// <summary>
        /// * `annotation` - ANNOTATION<br/>
        /// * `validation` - VALIDATION<br/>
        /// * `acceptance` - ACCEPTANCE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.JobStageJsonConverter))]
        public global::CVAT.JobStage? Stage { get; set; }

        /// <summary>
        /// * `new` - NEW<br/>
        /// * `in progress` - IN_PROGRESS<br/>
        /// * `completed` - COMPLETED<br/>
        /// * `rejected` - REJECTED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OperationStatusJsonConverter))]
        public global::CVAT.OperationStatus? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedJobWriteRequest" /> class.
        /// </summary>
        /// <param name="assignee"></param>
        /// <param name="stage">
        /// * `annotation` - ANNOTATION<br/>
        /// * `validation` - VALIDATION<br/>
        /// * `acceptance` - ACCEPTANCE
        /// </param>
        /// <param name="state">
        /// * `new` - NEW<br/>
        /// * `in progress` - IN_PROGRESS<br/>
        /// * `completed` - COMPLETED<br/>
        /// * `rejected` - REJECTED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedJobWriteRequest(
            int? assignee,
            global::CVAT.JobStage? stage,
            global::CVAT.OperationStatus? state)
        {
            this.Assignee = assignee;
            this.Stage = stage;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedJobWriteRequest" /> class.
        /// </summary>
        public PatchedJobWriteRequest()
        {
        }
    }
}