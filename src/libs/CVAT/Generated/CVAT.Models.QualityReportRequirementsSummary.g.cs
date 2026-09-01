
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityReportRequirementsSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Completed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_computed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NotComputed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CVAT.QualityReportRequirementSummaryItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportRequirementsSummary" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="enabled"></param>
        /// <param name="completed"></param>
        /// <param name="notComputed"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReportRequirementsSummary(
            int total,
            int enabled,
            int completed,
            int notComputed,
            global::System.Collections.Generic.IList<global::CVAT.QualityReportRequirementSummaryItem> items)
        {
            this.Total = total;
            this.Enabled = enabled;
            this.Completed = completed;
            this.NotComputed = notComputed;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportRequirementsSummary" /> class.
        /// </summary>
        public QualityReportRequirementsSummary()
        {
        }

    }
}