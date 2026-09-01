
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualitySettingsRequest
    {
        /// <summary>
        /// A JSON-based logic expression used to filter jobs for quality validation.<br/>
        /// The filter supports various terms to specify conditions on job: ['assignee', 'id', 'stage', 'state', 'task_id', 'task_name', 'type']
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_filter")]
        public string? JobFilter { get; set; }

        /// <summary>
        /// Allow using project settings when computing task quality.<br/>
        /// Only applicable to task quality settings inside projects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherit")]
        public bool? Inherit { get; set; }

        /// <summary>
        /// The maximum number of job validation attempts for the job assignee.<br/>
        /// The job can be automatically accepted if the job quality is above the required<br/>
        /// threshold, defined by the target threshold parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_validations_per_job")]
        public int? MaxValidationsPerJob { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItemRequest>? Requirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualitySettingsRequest" /> class.
        /// </summary>
        /// <param name="jobFilter">
        /// A JSON-based logic expression used to filter jobs for quality validation.<br/>
        /// The filter supports various terms to specify conditions on job: ['assignee', 'id', 'stage', 'state', 'task_id', 'task_name', 'type']
        /// </param>
        /// <param name="inherit">
        /// Allow using project settings when computing task quality.<br/>
        /// Only applicable to task quality settings inside projects
        /// </param>
        /// <param name="maxValidationsPerJob">
        /// The maximum number of job validation attempts for the job assignee.<br/>
        /// The job can be automatically accepted if the job quality is above the required<br/>
        /// threshold, defined by the target threshold parameter.
        /// </param>
        /// <param name="requirements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualitySettingsRequest(
            string? jobFilter,
            bool? inherit,
            int? maxValidationsPerJob,
            global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItemRequest>? requirements)
        {
            this.JobFilter = jobFilter;
            this.Inherit = inherit;
            this.MaxValidationsPerJob = maxValidationsPerJob;
            this.Requirements = requirements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualitySettingsRequest" /> class.
        /// </summary>
        public QualitySettingsRequest()
        {
        }

    }
}