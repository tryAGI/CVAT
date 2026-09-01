
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityReportSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_frames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalFrames { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_frames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ValidationFrames { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_frame_share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ValidationFrameShare { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conflict_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConflictCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErrorCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conflicts_by_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> ConflictsByType { get; set; }

        /// <summary>
        /// Included only in project reports
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        public global::CVAT.QualityReportTasksSummary? Tasks { get; set; }

        /// <summary>
        /// Included only in task and project reports
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public global::CVAT.QualityReportJobsSummary? Jobs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::CVAT.QualityReportRequirementsSummary? Requirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportSummary" /> class.
        /// </summary>
        /// <param name="totalFrames"></param>
        /// <param name="validationFrames"></param>
        /// <param name="validationFrameShare"></param>
        /// <param name="conflictCount"></param>
        /// <param name="errorCount"></param>
        /// <param name="conflictsByType"></param>
        /// <param name="tasks">
        /// Included only in project reports
        /// </param>
        /// <param name="jobs">
        /// Included only in task and project reports
        /// </param>
        /// <param name="requirements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReportSummary(
            int totalFrames,
            int validationFrames,
            double validationFrameShare,
            int conflictCount,
            int errorCount,
            global::System.Collections.Generic.Dictionary<string, int> conflictsByType,
            global::CVAT.QualityReportTasksSummary? tasks,
            global::CVAT.QualityReportJobsSummary? jobs,
            global::CVAT.QualityReportRequirementsSummary? requirements)
        {
            this.TotalFrames = totalFrames;
            this.ValidationFrames = validationFrames;
            this.ValidationFrameShare = validationFrameShare;
            this.ConflictCount = conflictCount;
            this.ErrorCount = errorCount;
            this.ConflictsByType = conflictsByType ?? throw new global::System.ArgumentNullException(nameof(conflictsByType));
            this.Tasks = tasks;
            this.Jobs = jobs;
            this.Requirements = requirements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportSummary" /> class.
        /// </summary>
        public QualityReportSummary()
        {
        }

    }
}