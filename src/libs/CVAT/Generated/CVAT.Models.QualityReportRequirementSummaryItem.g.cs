
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityReportRequirementSummaryItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirement_id")]
        public int? RequirementId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Metric { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_components")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.QualityReportScoreComponents ScoreComponents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calculation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.QualityReportRequirementCalculation Calculation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportRequirementSummaryItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metric"></param>
        /// <param name="scoreComponents"></param>
        /// <param name="calculation"></param>
        /// <param name="threshold"></param>
        /// <param name="requirementId"></param>
        /// <param name="score"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReportRequirementSummaryItem(
            string name,
            string metric,
            global::CVAT.QualityReportScoreComponents scoreComponents,
            global::CVAT.QualityReportRequirementCalculation calculation,
            double threshold,
            int? requirementId,
            double? score)
        {
            this.RequirementId = requirementId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
            this.Score = score;
            this.ScoreComponents = scoreComponents ?? throw new global::System.ArgumentNullException(nameof(scoreComponents));
            this.Calculation = calculation ?? throw new global::System.ArgumentNullException(nameof(calculation));
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportRequirementSummaryItem" /> class.
        /// </summary>
        public QualityReportRequirementSummaryItem()
        {
        }

    }
}