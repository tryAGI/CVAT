
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AttributeComparison
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public global::CVAT.AttributeComparisonDefaultRule? Default { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::CVAT.AttributeComparisonRule>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeComparison" /> class.
        /// </summary>
        /// <param name="default"></param>
        /// <param name="rules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttributeComparison(
            global::CVAT.AttributeComparisonDefaultRule? @default,
            global::System.Collections.Generic.IList<global::CVAT.AttributeComparisonRule>? rules)
        {
            this.Default = @default;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeComparison" /> class.
        /// </summary>
        public AttributeComparison()
        {
        }

    }
}