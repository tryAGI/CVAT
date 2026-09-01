
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityReportConfusionMatrixAxes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cols")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cols { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportConfusionMatrixAxes" /> class.
        /// </summary>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReportConfusionMatrixAxes(
            string cols,
            string rows)
        {
            this.Cols = cols ?? throw new global::System.ArgumentNullException(nameof(cols));
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportConfusionMatrixAxes" /> class.
        /// </summary>
        public QualityReportConfusionMatrixAxes()
        {
        }

    }
}