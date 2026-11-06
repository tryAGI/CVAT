
#nullable enable

namespace CVAT
{
    /// <summary>
    /// An IoU threshold policy for rectangle, polygon, mask, and ellipse requirements.<br/>
    /// The `iou_threshold` field also accepts a finite number between 0 and 1, such as `0.7`.<br/>
    /// Existing numeric thresholds are returned as numbers.<br/>
    /// A constant policy uses one threshold for all shapes:<br/>
    /// ```json<br/>
    /// {"type": "iou", "mode": "constant", "value": 0.7}<br/>
    /// ```<br/>
    /// A linear policy chooses a threshold from the GT shape area in px²:<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "type": "iou",<br/>
    ///   "mode": "linear",<br/>
    ///   "input": "gt.shape_area",<br/>
    ///   "extrapolation": "clamp",<br/>
    ///   "points": [{"x": 100, "y": 0.4}, {"x": 1000, "y": 0.9}]<br/>
    /// }<br/>
    /// ```<br/>
    /// Linear policies require 2-200 points with unique positive areas sorted in ascending order<br/>
    /// and thresholds between 0 and 1. Outside the curve, the nearest endpoint applies.<br/>
    /// Policies without `type` are accepted as IoU for compatibility; responses include it.<br/>
    /// Other threshold types are not supported.<br/>
    /// Setting a child's threshold to `null` restores inheritance of the whole threshold.<br/>
    /// Root requirements cannot inherit their threshold.
    /// </summary>
    public sealed partial class SimilarityThresholdPolicyRequest
    {
        /// <summary>
        /// Threshold type. Omitted type is accepted as IoU for compatibility; responses always include it.<br/>
        /// * `iou` - iou
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.SimilarityThresholdPolicyTypeEnumJsonConverter))]
        public global::CVAT.SimilarityThresholdPolicyTypeEnum? Type { get; set; }

        /// <summary>
        /// * `constant` - constant<br/>
        /// * `linear` - linear
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.SimilarityThresholdPolicyModeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.SimilarityThresholdPolicyModeEnum Mode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// * `gt.shape_area` - gt.shape_area
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.InputEnumJsonConverter))]
        public global::CVAT.InputEnum? Input { get; set; }

        /// <summary>
        /// * `clamp` - clamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extrapolation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.ExtrapolationEnumJsonConverter))]
        public global::CVAT.ExtrapolationEnum? Extrapolation { get; set; }

        /// <summary>
        /// Required in linear mode: 2-200 points sorted by unique positive GT area.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        public global::System.Collections.Generic.IList<global::CVAT.ThresholdPolicyPointRequest>? Points { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityThresholdPolicyRequest" /> class.
        /// </summary>
        /// <param name="mode">
        /// * `constant` - constant<br/>
        /// * `linear` - linear
        /// </param>
        /// <param name="type">
        /// Threshold type. Omitted type is accepted as IoU for compatibility; responses always include it.<br/>
        /// * `iou` - iou
        /// </param>
        /// <param name="value"></param>
        /// <param name="input">
        /// * `gt.shape_area` - gt.shape_area
        /// </param>
        /// <param name="extrapolation">
        /// * `clamp` - clamp
        /// </param>
        /// <param name="points">
        /// Required in linear mode: 2-200 points sorted by unique positive GT area.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimilarityThresholdPolicyRequest(
            global::CVAT.SimilarityThresholdPolicyModeEnum mode,
            global::CVAT.SimilarityThresholdPolicyTypeEnum? type,
            double? value,
            global::CVAT.InputEnum? input,
            global::CVAT.ExtrapolationEnum? extrapolation,
            global::System.Collections.Generic.IList<global::CVAT.ThresholdPolicyPointRequest>? points)
        {
            this.Type = type;
            this.Mode = mode;
            this.Value = value;
            this.Input = input;
            this.Extrapolation = extrapolation;
            this.Points = points;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityThresholdPolicyRequest" /> class.
        /// </summary>
        public SimilarityThresholdPolicyRequest()
        {
        }

    }
}