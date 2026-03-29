
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedLabelRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The hex value for the RGB color. Will be generated automatically, unless specified explicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The list of attributes. If you want to remove an attribute, you need to recreate the label and specify the remaining attributes.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::CVAT.AttributeRequest>? Attributes { get; set; }

        /// <summary>
        /// Delete the label. Only applicable in the PATCH methods of a project or a task.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Associated annotation type for this label<br/>
        /// * `any` - ANY<br/>
        /// * `cuboid` - CUBOID<br/>
        /// * `ellipse` - ELLIPSE<br/>
        /// * `mask` - MASK<br/>
        /// * `points` - POINTS<br/>
        /// * `polygon` - POLYGON<br/>
        /// * `polyline` - POLYLINE<br/>
        /// * `rectangle` - RECTANGLE<br/>
        /// * `skeleton` - SKELETON<br/>
        /// * `tag` - TAG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.LabelTypeJsonConverter))]
        public global::CVAT.LabelType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("svg")]
        public string? Svg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sublabels")]
        public global::System.Collections.Generic.IList<global::CVAT.SublabelRequest>? Sublabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLabelRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="color">
        /// The hex value for the RGB color. Will be generated automatically, unless specified explicitly.
        /// </param>
        /// <param name="attributes">
        /// The list of attributes. If you want to remove an attribute, you need to recreate the label and specify the remaining attributes.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="deleted">
        /// Delete the label. Only applicable in the PATCH methods of a project or a task.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="type">
        /// Associated annotation type for this label<br/>
        /// * `any` - ANY<br/>
        /// * `cuboid` - CUBOID<br/>
        /// * `ellipse` - ELLIPSE<br/>
        /// * `mask` - MASK<br/>
        /// * `points` - POINTS<br/>
        /// * `polygon` - POLYGON<br/>
        /// * `polyline` - POLYLINE<br/>
        /// * `rectangle` - RECTANGLE<br/>
        /// * `skeleton` - SKELETON<br/>
        /// * `tag` - TAG
        /// </param>
        /// <param name="svg"></param>
        /// <param name="sublabels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedLabelRequest(
            int? id,
            string? name,
            string? color,
            global::System.Collections.Generic.IList<global::CVAT.AttributeRequest>? attributes,
            bool? deleted,
            global::CVAT.LabelType? type,
            string? svg,
            global::System.Collections.Generic.IList<global::CVAT.SublabelRequest>? sublabels)
        {
            this.Id = id;
            this.Name = name;
            this.Color = color;
            this.Attributes = attributes;
            this.Deleted = deleted;
            this.Type = type;
            this.Svg = svg;
            this.Sublabels = sublabels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLabelRequest" /> class.
        /// </summary>
        public PatchedLabelRequest()
        {
        }
    }
}