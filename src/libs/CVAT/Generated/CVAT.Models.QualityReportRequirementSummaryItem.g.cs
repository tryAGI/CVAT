
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
        /// * `accuracy` - ACCURACY<br/>
        /// * `precision` - PRECISION<br/>
        /// * `recall` - RECALL<br/>
        /// * `jaccard_index` - JACCARD_INDEX<br/>
        /// * `dice` - DICE<br/>
        /// * `mean_accuracy` - MEAN_ACCURACY<br/>
        /// * `mean_precision` - MEAN_PRECISION<br/>
        /// * `mean_recall` - MEAN_RECALL<br/>
        /// * `mean_jaccard_index` - MEAN_JACCARD_INDEX<br/>
        /// * `mean_dice` - MEAN_DICE<br/>
        /// * `label_accuracy` - LABEL_ACCURACY<br/>
        /// * `label_precision` - LABEL_PRECISION<br/>
        /// * `label_recall` - LABEL_RECALL<br/>
        /// * `label_jaccard_index` - LABEL_JACCARD_INDEX<br/>
        /// * `label_dice` - LABEL_DICE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.QualityTargetMetricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.QualityTargetMetric Metric { get; set; }

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
        /// <param name="metric">
        /// * `accuracy` - ACCURACY<br/>
        /// * `precision` - PRECISION<br/>
        /// * `recall` - RECALL<br/>
        /// * `jaccard_index` - JACCARD_INDEX<br/>
        /// * `dice` - DICE<br/>
        /// * `mean_accuracy` - MEAN_ACCURACY<br/>
        /// * `mean_precision` - MEAN_PRECISION<br/>
        /// * `mean_recall` - MEAN_RECALL<br/>
        /// * `mean_jaccard_index` - MEAN_JACCARD_INDEX<br/>
        /// * `mean_dice` - MEAN_DICE<br/>
        /// * `label_accuracy` - LABEL_ACCURACY<br/>
        /// * `label_precision` - LABEL_PRECISION<br/>
        /// * `label_recall` - LABEL_RECALL<br/>
        /// * `label_jaccard_index` - LABEL_JACCARD_INDEX<br/>
        /// * `label_dice` - LABEL_DICE
        /// </param>
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
            global::CVAT.QualityTargetMetric metric,
            global::CVAT.QualityReportScoreComponents scoreComponents,
            global::CVAT.QualityReportRequirementCalculation calculation,
            double threshold,
            int? requirementId,
            double? score)
        {
            this.RequirementId = requirementId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metric = metric;
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