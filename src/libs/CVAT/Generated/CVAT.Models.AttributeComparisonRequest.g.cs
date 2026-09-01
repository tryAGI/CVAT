
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AttributeComparisonRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public global::CVAT.AttributeComparisonDefaultRuleRequest? Default { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::CVAT.AttributeComparisonRuleRequest>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeComparisonRequest" /> class.
        /// </summary>
        /// <param name="default"></param>
        /// <param name="rules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttributeComparisonRequest(
            global::CVAT.AttributeComparisonDefaultRuleRequest? @default,
            global::System.Collections.Generic.IList<global::CVAT.AttributeComparisonRuleRequest>? rules)
        {
            this.Default = @default;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeComparisonRequest" /> class.
        /// </summary>
        public AttributeComparisonRequest()
        {
        }

    }
}