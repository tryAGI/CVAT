
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityReportTargetMetricSummary
    {
        /// <summary>
        /// * `accuracy` - accuracy<br/>
        /// * `precision` - precision<br/>
        /// * `recall` - recall<br/>
        /// * `jaccard_index` - jaccard_index<br/>
        /// * `dice` - dice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.QualityReportTargetMetricSummaryMetricEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.QualityReportTargetMetricSummaryMetricEnum Metric { get; set; }

        /// <summary>
        /// * `micro` - micro<br/>
        /// * `mean` - mean<br/>
        /// * `label` - label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.AggregationEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.AggregationEnum Aggregation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.QualityReportTargetMetricValues Values { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("worst_labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> WorstLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportTargetMetricSummary" /> class.
        /// </summary>
        /// <param name="metric">
        /// * `accuracy` - accuracy<br/>
        /// * `precision` - precision<br/>
        /// * `recall` - recall<br/>
        /// * `jaccard_index` - jaccard_index<br/>
        /// * `dice` - dice
        /// </param>
        /// <param name="aggregation">
        /// * `micro` - micro<br/>
        /// * `mean` - mean<br/>
        /// * `label` - label
        /// </param>
        /// <param name="values"></param>
        /// <param name="worstLabels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReportTargetMetricSummary(
            global::CVAT.QualityReportTargetMetricSummaryMetricEnum metric,
            global::CVAT.AggregationEnum aggregation,
            global::CVAT.QualityReportTargetMetricValues values,
            global::System.Collections.Generic.IList<string> worstLabels)
        {
            this.Metric = metric;
            this.Aggregation = aggregation;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.WorstLabels = worstLabels ?? throw new global::System.ArgumentNullException(nameof(worstLabels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportTargetMetricSummary" /> class.
        /// </summary>
        public QualityReportTargetMetricSummary()
        {
        }

    }
}