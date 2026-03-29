
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsReport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedDate { get; set; }

        /// <summary>
        /// * `job` - JOB<br/>
        /// * `task` - TASK<br/>
        /// * `project` - PROJECT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.QualityReportTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.QualityReportTarget Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public int? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statistics")]
        public global::System.Collections.Generic.IList<object>? Statistics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CVAT.ReportEvent> Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CVAT.AnnotationsStatistics> Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReport" /> class.
        /// </summary>
        /// <param name="createdDate"></param>
        /// <param name="updatedDate"></param>
        /// <param name="target">
        /// * `job` - JOB<br/>
        /// * `task` - TASK<br/>
        /// * `project` - PROJECT
        /// </param>
        /// <param name="events"></param>
        /// <param name="annotations"></param>
        /// <param name="jobId"></param>
        /// <param name="taskId"></param>
        /// <param name="projectId"></param>
        /// <param name="statistics">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsReport(
            global::System.DateTime createdDate,
            global::System.DateTime updatedDate,
            global::CVAT.QualityReportTarget target,
            global::System.Collections.Generic.IList<global::CVAT.ReportEvent> events,
            global::System.Collections.Generic.IList<global::CVAT.AnnotationsStatistics> annotations,
            int? jobId,
            int? taskId,
            int? projectId,
            global::System.Collections.Generic.IList<object>? statistics)
        {
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.Target = target;
            this.JobId = jobId;
            this.TaskId = taskId;
            this.ProjectId = projectId;
            this.Statistics = statistics;
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReport" /> class.
        /// </summary>
        public AnalyticsReport()
        {
        }
    }
}