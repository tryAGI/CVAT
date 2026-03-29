
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabeledData
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<global::CVAT.LabeledImage>? Tags { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shapes")]
        public global::System.Collections.Generic.IList<global::CVAT.LabeledShape>? Shapes { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        public global::System.Collections.Generic.IList<global::CVAT.LabeledTrack>? Tracks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledData" /> class.
        /// </summary>
        /// <param name="version">
        /// Default Value: 0
        /// </param>
        /// <param name="tags">
        /// Default Value: []
        /// </param>
        /// <param name="shapes">
        /// Default Value: []
        /// </param>
        /// <param name="tracks">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabeledData(
            int? version,
            global::System.Collections.Generic.IList<global::CVAT.LabeledImage>? tags,
            global::System.Collections.Generic.IList<global::CVAT.LabeledShape>? shapes,
            global::System.Collections.Generic.IList<global::CVAT.LabeledTrack>? tracks)
        {
            this.Version = version;
            this.Tags = tags;
            this.Shapes = shapes;
            this.Tracks = tracks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledData" /> class.
        /// </summary>
        public LabeledData()
        {
        }
    }
}