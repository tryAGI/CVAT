
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SublabelRequest
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("has_parent")]
        public bool? HasParent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SublabelRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="color">
        /// The hex value for the RGB color. Will be generated automatically, unless specified explicitly.
        /// </param>
        /// <param name="attributes">
        /// The list of attributes. If you want to remove an attribute, you need to recreate the label and specify the remaining attributes.<br/>
        /// Default Value: []
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
        /// <param name="hasParent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SublabelRequest(
            string name,
            int? id,
            string? color,
            global::System.Collections.Generic.IList<global::CVAT.AttributeRequest>? attributes,
            global::CVAT.LabelType? type,
            bool? hasParent)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color;
            this.Attributes = attributes;
            this.Type = type;
            this.HasParent = hasParent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SublabelRequest" /> class.
        /// </summary>
        public SublabelRequest()
        {
        }
    }
}