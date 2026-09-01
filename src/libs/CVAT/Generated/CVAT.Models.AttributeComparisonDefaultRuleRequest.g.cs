
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AttributeComparisonDefaultRuleRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>))]
        public global::CVAT.OneOf<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>? Comparator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeComparisonDefaultRuleRequest" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="comparator"></param>
        /// <param name="threshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttributeComparisonDefaultRuleRequest(
            bool? enabled,
            global::CVAT.OneOf<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>? comparator,
            double? threshold)
        {
            this.Enabled = enabled;
            this.Comparator = comparator;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeComparisonDefaultRuleRequest" /> class.
        /// </summary>
        public AttributeComparisonDefaultRuleRequest()
        {
        }

    }
}