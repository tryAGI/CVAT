
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabelMappingEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sublabels")]
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.SublabelMappingEntry>? Sublabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelMappingEntry" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attributes"></param>
        /// <param name="sublabels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelMappingEntry(
            string name,
            global::System.Collections.Generic.Dictionary<string, string>? attributes,
            global::System.Collections.Generic.Dictionary<string, global::CVAT.SublabelMappingEntry>? sublabels)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Attributes = attributes;
            this.Sublabels = sublabels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelMappingEntry" /> class.
        /// </summary>
        public LabelMappingEntry()
        {
        }
    }
}