
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityReportConfusionMatrix
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> Rows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("axes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.QualityReportConfusionMatrixAxes Axes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("precision")]
        public global::System.Collections.Generic.IList<double>? Precision { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recall")]
        public global::System.Collections.Generic.IList<double>? Recall { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accuracy")]
        public global::System.Collections.Generic.IList<double>? Accuracy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jaccard_index")]
        public global::System.Collections.Generic.IList<double>? JaccardIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportConfusionMatrix" /> class.
        /// </summary>
        /// <param name="labels"></param>
        /// <param name="rows"></param>
        /// <param name="axes"></param>
        /// <param name="precision"></param>
        /// <param name="recall"></param>
        /// <param name="accuracy"></param>
        /// <param name="jaccardIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReportConfusionMatrix(
            global::System.Collections.Generic.IList<string> labels,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> rows,
            global::CVAT.QualityReportConfusionMatrixAxes axes,
            global::System.Collections.Generic.IList<double>? precision,
            global::System.Collections.Generic.IList<double>? recall,
            global::System.Collections.Generic.IList<double>? accuracy,
            global::System.Collections.Generic.IList<double>? jaccardIndex)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
            this.Axes = axes ?? throw new global::System.ArgumentNullException(nameof(axes));
            this.Precision = precision;
            this.Recall = recall;
            this.Accuracy = accuracy;
            this.JaccardIndex = jaccardIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportConfusionMatrix" /> class.
        /// </summary>
        public QualityReportConfusionMatrix()
        {
        }

    }
}