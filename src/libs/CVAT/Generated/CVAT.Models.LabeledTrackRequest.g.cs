
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabeledTrackRequest
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
        public global::System.Collections.Generic.IList<global::CVAT.AttributeValRequest>? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shapes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CVAT.TrackedShapeRequest> Shapes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledTrackRequest>? Elements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledTrackRequest" /> class.
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="frame"></param>
        /// <param name="shapes"></param>
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
        /// <param name="elements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabeledTrackRequest(
            int labelId,
            int frame,
            global::System.Collections.Generic.IList<global::CVAT.TrackedShapeRequest> shapes,
            int? id,
            int? group,
            string? source,
            global::System.Collections.Generic.IList<global::CVAT.AttributeValRequest>? attributes,
            global::System.Collections.Generic.IList<global::CVAT.SubLabeledTrackRequest>? elements)
        {
            this.Id = id;
            this.LabelId = labelId;
            this.Group = group;
            this.Source = source;
            this.Frame = frame;
            this.Attributes = attributes;
            this.Shapes = shapes ?? throw new global::System.ArgumentNullException(nameof(shapes));
            this.Elements = elements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledTrackRequest" /> class.
        /// </summary>
        public LabeledTrackRequest()
        {
        }

    }
}