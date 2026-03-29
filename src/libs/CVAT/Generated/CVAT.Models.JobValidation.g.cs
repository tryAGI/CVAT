
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobValidation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt_number")]
        public int? AttemptNumber { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts_remaining")]
        public int? AttemptsRemaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee_id")]
        public int? AssigneeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee_last_updated")]
        public global::System.DateTime? AssigneeLastUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actual_score")]
        public double? ActualScore { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_score")]
        public double? RequiredScore { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.QualityTargetMetricJsonConverter))]
        public global::CVAT.QualityTargetMetric? TargetMetric { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_id")]
        public int? ReportId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.JobValidationStatusEnumJsonConverter))]
        public global::CVAT.JobValidationStatusEnum? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobValidation" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="jobId">
        /// Included only in responses
        /// </param>
        /// <param name="attemptNumber">
        /// Included only in responses
        /// </param>
        /// <param name="attemptsRemaining">
        /// Included only in responses
        /// </param>
        /// <param name="assigneeId"></param>
        /// <param name="assigneeLastUpdated"></param>
        /// <param name="createdDate"></param>
        /// <param name="actualScore"></param>
        /// <param name="requiredScore">
        /// Included only in responses
        /// </param>
        /// <param name="targetMetric">
        /// Included only in responses
        /// </param>
        /// <param name="reportId">
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Included only in responses
        /// </param>
        /// <param name="messages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobValidation(
            int? id,
            int? jobId,
            int? attemptNumber,
            int? attemptsRemaining,
            int? assigneeId,
            global::System.DateTime? assigneeLastUpdated,
            global::System.DateTime? createdDate,
            double? actualScore,
            double? requiredScore,
            global::CVAT.QualityTargetMetric? targetMetric,
            int? reportId,
            global::CVAT.JobValidationStatusEnum? status,
            global::System.Collections.Generic.IList<string>? messages)
        {
            this.Id = id;
            this.JobId = jobId;
            this.AttemptNumber = attemptNumber;
            this.AttemptsRemaining = attemptsRemaining;
            this.AssigneeId = assigneeId;
            this.AssigneeLastUpdated = assigneeLastUpdated;
            this.CreatedDate = createdDate;
            this.ActualScore = actualScore;
            this.RequiredScore = requiredScore;
            this.TargetMetric = targetMetric;
            this.ReportId = reportId;
            this.Status = status;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobValidation" /> class.
        /// </summary>
        public JobValidation()
        {
        }
    }
}