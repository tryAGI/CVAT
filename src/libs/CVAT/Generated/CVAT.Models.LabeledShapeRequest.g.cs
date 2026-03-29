
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabeledShapeRequest
    {
        /// <summary>
        /// * `rectangle` - RECTANGLE<br/>
        /// * `polygon` - POLYGON<br/>
        /// * `polyline` - POLYLINE<br/>
        /// * `points` - POINTS<br/>
        /// * `ellipse` - ELLIPSE<br/>
        /// * `cuboid` - CUBOID<br/>
        /// * `mask` - MASK<br/>
        /// * `skeleton` - SKELETON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.ShapeType2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.ShapeType2 Type { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("occluded")]
        public bool? Occluded { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outside")]
        public bool? Outside { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("z_order")]
        public int? ZOrder { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotation")]
        public double? Rotation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        public global::System.Collections.Generic.IList<double>? Points { get; set; }

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
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::CVAT.AttributeValRequest>? Attributes { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        public global::System.Collections.Generic.IList<global::CVAT.SubLabeledShapeRequest>? Elements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledShapeRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// * `rectangle` - RECTANGLE<br/>
        /// * `polygon` - POLYGON<br/>
        /// * `polyline` - POLYLINE<br/>
        /// * `points` - POINTS<br/>
        /// * `ellipse` - ELLIPSE<br/>
        /// * `cuboid` - CUBOID<br/>
        /// * `mask` - MASK<br/>
        /// * `skeleton` - SKELETON
        /// </param>
        /// <param name="frame"></param>
        /// <param name="labelId"></param>
        /// <param name="occluded">
        /// Default Value: false
        /// </param>
        /// <param name="outside">
        /// Default Value: false
        /// </param>
        /// <param name="zOrder">
        /// Default Value: 0
        /// </param>
        /// <param name="rotation">
        /// Default Value: 0F
        /// </param>
        /// <param name="points"></param>
        /// <param name="id"></param>
        /// <param name="group"></param>
        /// <param name="source">
        /// Default Value: manual
        /// </param>
        /// <param name="attributes">
        /// Default Value: []
        /// </param>
        /// <param name="score">
        /// Default Value: 1F
        /// </param>
        /// <param name="elements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabeledShapeRequest(
            global::CVAT.ShapeType2 type,
            int frame,
            int labelId,
            bool? occluded,
            bool? outside,
            int? zOrder,
            double? rotation,
            global::System.Collections.Generic.IList<double>? points,
            int? id,
            int? group,
            string? source,
            global::System.Collections.Generic.IList<global::CVAT.AttributeValRequest>? attributes,
            double? score,
            global::System.Collections.Generic.IList<global::CVAT.SubLabeledShapeRequest>? elements)
        {
            this.Type = type;
            this.Occluded = occluded;
            this.Outside = outside;
            this.ZOrder = zOrder;
            this.Rotation = rotation;
            this.Points = points;
            this.Id = id;
            this.Frame = frame;
            this.LabelId = labelId;
            this.Group = group;
            this.Source = source;
            this.Attributes = attributes;
            this.Score = score;
            this.Elements = elements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledShapeRequest" /> class.
        /// </summary>
        public LabeledShapeRequest()
        {
        }
    }
}