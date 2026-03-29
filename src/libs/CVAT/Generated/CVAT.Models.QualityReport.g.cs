
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityReport
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int? JobId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public int? TaskId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public int? ParentId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.QualityReportSummary Summary { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_last_updated")]
        public global::System.DateTime? TargetLastUpdated { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gt_last_updated")]
        public global::System.DateTime? GtLastUpdated { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public global::CVAT.BasicUser? Assignee { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReport" /> class.
        /// </summary>
        /// <param name="target">
        /// * `job` - JOB<br/>
        /// * `task` - TASK<br/>
        /// * `project` - PROJECT
        /// </param>
        /// <param name="summary"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="jobId">
        /// Included only in responses
        /// </param>
        /// <param name="taskId">
        /// Included only in responses
        /// </param>
        /// <param name="projectId">
        /// Included only in responses
        /// </param>
        /// <param name="parentId">
        /// Included only in responses
        /// </param>
        /// <param name="createdDate">
        /// Included only in responses
        /// </param>
        /// <param name="targetLastUpdated">
        /// Included only in responses
        /// </param>
        /// <param name="gtLastUpdated">
        /// Included only in responses
        /// </param>
        /// <param name="assignee">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReport(
            global::CVAT.QualityReportTarget target,
            global::CVAT.QualityReportSummary summary,
            int? id,
            int? jobId,
            int? taskId,
            int? projectId,
            int? parentId,
            global::System.DateTime? createdDate,
            global::System.DateTime? targetLastUpdated,
            global::System.DateTime? gtLastUpdated,
            global::CVAT.BasicUser? assignee)
        {
            this.Id = id;
            this.JobId = jobId;
            this.TaskId = taskId;
            this.ProjectId = projectId;
            this.ParentId = parentId;
            this.Target = target;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.CreatedDate = createdDate;
            this.TargetLastUpdated = targetLastUpdated;
            this.GtLastUpdated = gtLastUpdated;
            this.Assignee = assignee;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReport" /> class.
        /// </summary>
        public QualityReport()
        {
        }
    }
}