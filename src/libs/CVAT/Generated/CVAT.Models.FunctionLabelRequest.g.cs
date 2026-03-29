
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionLabelRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.LabelTypeJsonConverter))]
        public global::CVAT.LabelType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::CVAT.FunctionAttributeRequest>? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sublabels")]
        public global::System.Collections.Generic.IList<global::CVAT.FunctionSublabelRequest>? Sublabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionLabelRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: any
        /// </param>
        /// <param name="attributes"></param>
        /// <param name="sublabels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionLabelRequest(
            string name,
            global::CVAT.LabelType? type,
            global::System.Collections.Generic.IList<global::CVAT.FunctionAttributeRequest>? attributes,
            global::System.Collections.Generic.IList<global::CVAT.FunctionSublabelRequest>? sublabels)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Attributes = attributes;
            this.Sublabels = sublabels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionLabelRequest" /> class.
        /// </summary>
        public FunctionLabelRequest()
        {
        }
    }
}