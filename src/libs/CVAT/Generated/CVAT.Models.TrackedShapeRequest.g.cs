
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackedShapeRequest
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
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::CVAT.AttributeValRequest>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedShapeRequest" /> class.
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
        /// <param name="attributes">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackedShapeRequest(
            global::CVAT.ShapeType2 type,
            int frame,
            bool? occluded,
            bool? outside,
            int? zOrder,
            double? rotation,
            global::System.Collections.Generic.IList<double>? points,
            int? id,
            global::System.Collections.Generic.IList<global::CVAT.AttributeValRequest>? attributes)
        {
            this.Type = type;
            this.Occluded = occluded;
            this.Outside = outside;
            this.ZOrder = zOrder;
            this.Rotation = rotation;
            this.Points = points;
            this.Id = id;
            this.Frame = frame;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedShapeRequest" /> class.
        /// </summary>
        public TrackedShapeRequest()
        {
        }
    }
}