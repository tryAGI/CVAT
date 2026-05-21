
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabeledImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LabelId { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public int? Group { get; set; }

        /// <summary>
        /// Default Value: manual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Frame { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::CVAT.AttributeVal>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledImage" /> class.
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="frame"></param>
        /// <param name="id"></param>
        /// <param name="group">
        /// Default Value: 0
        /// </param>
        /// <param name="source">
        /// Default Value: manual
        /// </param>
        /// <param name="attributes">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabeledImage(
            int labelId,
            int frame,
            int? id,
            int? group,
            string? source,
            global::System.Collections.Generic.IList<global::CVAT.AttributeVal>? attributes)
        {
            this.Id = id;
            this.LabelId = labelId;
            this.Group = group;
            this.Source = source;
            this.Frame = frame;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledImage" /> class.
        /// </summary>
        public LabeledImage()
        {
        }

    }
}