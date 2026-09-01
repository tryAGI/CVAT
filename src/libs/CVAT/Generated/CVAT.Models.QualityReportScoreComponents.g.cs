
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityReportScoreComponents
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ValidCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MissingCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExtraCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportScoreComponents" /> class.
        /// </summary>
        /// <param name="validCount"></param>
        /// <param name="missingCount"></param>
        /// <param name="extraCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReportScoreComponents(
            int validCount,
            int missingCount,
            int extraCount)
        {
            this.ValidCount = validCount;
            this.MissingCount = missingCount;
            this.ExtraCount = extraCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportScoreComponents" /> class.
        /// </summary>
        public QualityReportScoreComponents()
        {
        }

    }
}