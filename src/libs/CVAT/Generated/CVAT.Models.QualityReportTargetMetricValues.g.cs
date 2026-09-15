
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityReportTargetMetricValues
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("micro")]
        public double? Micro { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mean")]
        public double? Mean { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public double? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportTargetMetricValues" /> class.
        /// </summary>
        /// <param name="micro"></param>
        /// <param name="mean"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReportTargetMetricValues(
            double? micro,
            double? mean,
            double? label)
        {
            this.Micro = micro;
            this.Mean = mean;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportTargetMetricValues" /> class.
        /// </summary>
        public QualityReportTargetMetricValues()
        {
        }

    }
}