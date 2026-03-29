
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubLabeledTrack
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Frame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LabelId { get; set; }

        /// <summary>
        /// 
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
        [global::System.Text.Json.Serialization.JsonPropertyName("shapes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CVAT.TrackedShape> Shapes { get; set; }

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
        /// Initializes a new instance of the <see cref="SubLabeledTrack" /> class.
        /// </summary>
        /// <param name="frame"></param>
        /// <param name="labelId"></param>
        /// <param name="shapes"></param>
        /// <param name="id"></param>
        /// <param name="group"></param>
        /// <param name="source">
        /// Default Value: manual
        /// </param>
        /// <param name="attributes">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubLabeledTrack(
            int frame,
            int labelId,
            global::System.Collections.Generic.IList<global::CVAT.TrackedShape> shapes,
            int? id,
            int? group,
            string? source,
            global::System.Collections.Generic.IList<global::CVAT.AttributeVal>? attributes)
        {
            this.Id = id;
            this.Frame = frame;
            this.LabelId = labelId;
            this.Group = group;
            this.Source = source;
            this.Shapes = shapes ?? throw new global::System.ArgumentNullException(nameof(shapes));
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubLabeledTrack" /> class.
        /// </summary>
        public SubLabeledTrack()
        {
        }
    }
}