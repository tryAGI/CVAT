
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityReportTasksSummary
    {
        /// <summary>
        /// Total task count
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Tasks with individual settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Custom { get; set; }

        /// <summary>
        /// Tasks with validation not configured
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_configured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NotConfigured { get; set; }

        /// <summary>
        /// Tasks excluded by filters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Excluded { get; set; }

        /// <summary>
        /// Included task count = total - custom - non_configured - excluded
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
        /// Initializes a new instance of the <see cref="QualityReportTasksSummary" /> class.
        /// </summary>
        /// <param name="total">
        /// Total task count
        /// </param>
        /// <param name="custom">
        /// Tasks with individual settings
        /// </param>
        /// <param name="notConfigured">
        /// Tasks with validation not configured
        /// </param>
        /// <param name="excluded">
        /// Tasks excluded by filters
        /// </param>
        /// <param name="included">
        /// Included task count = total - custom - non_configured - excluded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReportTasksSummary(
            int total,
            int custom,
            int notConfigured,
            int excluded,
            int included)
        {
            this.Total = total;
            this.Custom = custom;
            this.NotConfigured = notConfigured;
            this.Excluded = excluded;
            this.Included = included;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportTasksSummary" /> class.
        /// </summary>
        public QualityReportTasksSummary()
        {
        }
    }
}