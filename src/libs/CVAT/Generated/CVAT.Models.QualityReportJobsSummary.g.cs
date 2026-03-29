
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityReportJobsSummary
    {
        /// <summary>
        /// Non-GT jobs in included tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Jobs excluded by filters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Excluded { get; set; }

        /// <summary>
        /// Included jobs without validation frames
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_checkable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NotCheckable { get; set; }

        /// <summary>
        /// Included job count = total - excluded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Included { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportJobsSummary" /> class.
        /// </summary>
        /// <param name="total">
        /// Non-GT jobs in included tasks
        /// </param>
        /// <param name="excluded">
        /// Jobs excluded by filters
        /// </param>
        /// <param name="notCheckable">
        /// Included jobs without validation frames
        /// </param>
        /// <param name="included">
        /// Included job count = total - excluded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReportJobsSummary(
            int total,
            int excluded,
            int notCheckable,
            int included)
        {
            this.Total = total;
            this.Excluded = excluded;
            this.NotCheckable = notCheckable;
            this.Included = included;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportJobsSummary" /> class.
        /// </summary>
        public QualityReportJobsSummary()
        {
        }
    }
}