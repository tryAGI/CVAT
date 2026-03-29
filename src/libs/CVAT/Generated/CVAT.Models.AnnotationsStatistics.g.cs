
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationsStatistics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LabelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LabelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rectangle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.Count Rectangle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ellipse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.Count Ellipse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polygon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.Count Polygon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polyline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.Count Polyline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.Count Points { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.Count Mask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cuboid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.Count Cuboid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skeleton")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.Count Skeleton { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.Count Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationsStatistics" /> class.
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="labelName"></param>
        /// <param name="rectangle"></param>
        /// <param name="ellipse"></param>
        /// <param name="polygon"></param>
        /// <param name="polyline"></param>
        /// <param name="points"></param>
        /// <param name="mask"></param>
        /// <param name="cuboid"></param>
        /// <param name="skeleton"></param>
        /// <param name="tag"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationsStatistics(
            int labelId,
            string labelName,
            global::CVAT.Count rectangle,
            global::CVAT.Count ellipse,
            global::CVAT.Count polygon,
            global::CVAT.Count polyline,
            global::CVAT.Count points,
            global::CVAT.Count mask,
            global::CVAT.Count cuboid,
            global::CVAT.Count skeleton,
            global::CVAT.Count tag)
        {
            this.LabelId = labelId;
            this.LabelName = labelName ?? throw new global::System.ArgumentNullException(nameof(labelName));
            this.Rectangle = rectangle ?? throw new global::System.ArgumentNullException(nameof(rectangle));
            this.Ellipse = ellipse ?? throw new global::System.ArgumentNullException(nameof(ellipse));
            this.Polygon = polygon ?? throw new global::System.ArgumentNullException(nameof(polygon));
            this.Polyline = polyline ?? throw new global::System.ArgumentNullException(nameof(polyline));
            this.Points = points ?? throw new global::System.ArgumentNullException(nameof(points));
            this.Mask = mask ?? throw new global::System.ArgumentNullException(nameof(mask));
            this.Cuboid = cuboid ?? throw new global::System.ArgumentNullException(nameof(cuboid));
            this.Skeleton = skeleton ?? throw new global::System.ArgumentNullException(nameof(skeleton));
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationsStatistics" /> class.
        /// </summary>
        public AnnotationsStatistics()
        {
        }
    }
}