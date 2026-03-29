
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
        /// Deprecated. Use 'validation_frames' instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_count")]
        public int? FrameCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_frames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ValidationFrames { get; set; }

        /// <summary>
        /// Deprecated. Use 'validation_frame_share' instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_share")]
        public double? FrameShare { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("warning_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WarningCount { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ValidCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ds_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gt_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GtCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accuracy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Accuracy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("precision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Precision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recall")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Recall { get; set; }

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
        /// <param name="warningCount"></param>
        /// <param name="errorCount"></param>
        /// <param name="conflictsByType"></param>
        /// <param name="validCount"></param>
        /// <param name="dsCount"></param>
        /// <param name="gtCount"></param>
        /// <param name="totalCount"></param>
        /// <param name="accuracy"></param>
        /// <param name="precision"></param>
        /// <param name="recall"></param>
        /// <param name="frameCount">
        /// Deprecated. Use 'validation_frames' instead
        /// </param>
        /// <param name="frameShare">
        /// Deprecated. Use 'validation_frame_share' instead
        /// </param>
        /// <param name="tasks">
        /// Included only in project reports
        /// </param>
        /// <param name="jobs">
        /// Included only in task and project reports
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReportSummary(
            int totalFrames,
            int validationFrames,
            double validationFrameShare,
            int conflictCount,
            int warningCount,
            int errorCount,
            global::System.Collections.Generic.Dictionary<string, int> conflictsByType,
            int validCount,
            int dsCount,
            int gtCount,
            int totalCount,
            double accuracy,
            double precision,
            double recall,
            int? frameCount,
            double? frameShare,
            global::CVAT.QualityReportTasksSummary? tasks,
            global::CVAT.QualityReportJobsSummary? jobs)
        {
            this.TotalFrames = totalFrames;
            this.FrameCount = frameCount;
            this.ValidationFrames = validationFrames;
            this.FrameShare = frameShare;
            this.ValidationFrameShare = validationFrameShare;
            this.ConflictCount = conflictCount;
            this.WarningCount = warningCount;
            this.ErrorCount = errorCount;
            this.ConflictsByType = conflictsByType ?? throw new global::System.ArgumentNullException(nameof(conflictsByType));
            this.ValidCount = validCount;
            this.DsCount = dsCount;
            this.GtCount = gtCount;
            this.TotalCount = totalCount;
            this.Accuracy = accuracy;
            this.Precision = precision;
            this.Recall = recall;
            this.Tasks = tasks;
            this.Jobs = jobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportSummary" /> class.
        /// </summary>
        public QualityReportSummary()
        {
        }
    }
}