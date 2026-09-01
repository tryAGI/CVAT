
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityRequirementListItemRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings_id")]
        public int? SettingsId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        public int? SortOrder { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>))]
        public global::CVAT.OneOf<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? AnnotationType { get; set; }

        /// <summary>
        /// The primary metric used for quality estimation<br/>
        /// * `accuracy` - ACCURACY<br/>
        /// * `precision` - PRECISION<br/>
        /// * `recall` - RECALL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>))]
        public global::CVAT.OneOf<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>? Metric { get; set; }

        /// <summary>
        /// Defines the minimal quality requirements in terms of the selected target metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_score")]
        public double? RequiredScore { get; set; }

        /// <summary>
        /// The parent requirement. Child requirements inherit comparison settings from it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_requirement")]
        public int? ParentRequirement { get; set; }

        /// <summary>
        /// Used for distinction between matched / unmatched shapes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iou_threshold")]
        public double? IouThreshold { get; set; }

        /// <summary>
        /// Like IoU threshold, but for points.<br/>
        /// The percent of the bbox side, used as the radius of the circle around the GT point,<br/>
        /// where the checked point is expected to be. For boxes with different width and<br/>
        /// height, the "side" is computed as a geometric mean of the width and height.<br/>
        /// Read more: https://cocodataset.org/#keypoints-eval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("point_size")]
        public double? PointSize { get; set; }

        /// <summary>
        /// When comparing point annotations (including both separate points and point groups),<br/>
        /// the point size parameter defines matching area for each GT point based to the<br/>
        /// object size. The point size base parameter allows to configure how to determine<br/>
        /// the object size.<br/>
        /// If image_size, the image size is used. Useful if each point<br/>
        /// annotation represents a separate object or boxes grouped with points do not<br/>
        /// represent object boundaries.<br/>
        /// If group_bbox_size, the object size is based on<br/>
        /// the point group bbox size. Useful if each point group represents an object<br/>
        /// or there is a bbox grouped with points, representing the object size.<br/>
        /// * `image_size` - IMAGE_SIZE<br/>
        /// * `group_bbox_size` - GROUP_BBOX_SIZE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("point_size_base")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>))]
        public global::CVAT.OneOf<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? PointSizeBase { get; set; }

        /// <summary>
        /// Thickness of polylines, relatively to the (image area) ^ 0.5.<br/>
        /// The distance to the boundary around the GT line,<br/>
        /// inside of which the checked line points should be
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_thickness")]
        public double? LineThickness { get; set; }

        /// <summary>
        /// Enables or disables polyline orientation comparison
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_orientation")]
        public bool? MatchOrientation { get; set; }

        /// <summary>
        /// The minimal gain in the GT IoU between the given and reversed line directions<br/>
        /// to consider the line inverted.<br/>
        /// Only used when the 'match_orientation' parameter is true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_orientation_threshold")]
        public double? LineOrientationThreshold { get; set; }

        /// <summary>
        /// Enables or disables annotation group checks. Only annotations of the same shape type can form matching groups.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_groups")]
        public bool? MatchGroups { get; set; }

        /// <summary>
        /// Minimal IoU for groups to be considered matching.<br/>
        /// Only used when the 'match_groups' parameter is true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_match_threshold")]
        public double? GroupMatchThreshold { get; set; }

        /// <summary>
        /// Check for partially-covered annotations, useful in segmentation tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_covered_annotations")]
        public bool? CheckCoveredAnnotations { get; set; }

        /// <summary>
        /// Minimal visible area percent of the spatial annotations (polygons, masks)<br/>
        /// for reporting covered annotations.<br/>
        /// Only used when the 'object_visibility_threshold' parameter is true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_visibility_threshold")]
        public double? ObjectVisibilityThreshold { get; set; }

        /// <summary>
        /// Use only the visible part of the masks and polygons in comparisons
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panoptic_comparison")]
        public bool? PanopticComparison { get; set; }

        /// <summary>
        /// Incremental attribute comparison settings. The default rule applies to attributes without an override; rules override behavior for individual AttributeSpec ids.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_comparison")]
        public global::CVAT.AttributeComparisonRequest? AttributeComparison { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityRequirementListItemRequest" /> class.
        /// </summary>
        /// <param name="settingsId"></param>
        /// <param name="name"></param>
        /// <param name="sortOrder"></param>
        /// <param name="filter"></param>
        /// <param name="enabled"></param>
        /// <param name="annotationType"></param>
        /// <param name="metric">
        /// The primary metric used for quality estimation<br/>
        /// * `accuracy` - ACCURACY<br/>
        /// * `precision` - PRECISION<br/>
        /// * `recall` - RECALL
        /// </param>
        /// <param name="requiredScore">
        /// Defines the minimal quality requirements in terms of the selected target metric.
        /// </param>
        /// <param name="parentRequirement">
        /// The parent requirement. Child requirements inherit comparison settings from it.
        /// </param>
        /// <param name="iouThreshold">
        /// Used for distinction between matched / unmatched shapes
        /// </param>
        /// <param name="pointSize">
        /// Like IoU threshold, but for points.<br/>
        /// The percent of the bbox side, used as the radius of the circle around the GT point,<br/>
        /// where the checked point is expected to be. For boxes with different width and<br/>
        /// height, the "side" is computed as a geometric mean of the width and height.<br/>
        /// Read more: https://cocodataset.org/#keypoints-eval
        /// </param>
        /// <param name="pointSizeBase">
        /// When comparing point annotations (including both separate points and point groups),<br/>
        /// the point size parameter defines matching area for each GT point based to the<br/>
        /// object size. The point size base parameter allows to configure how to determine<br/>
        /// the object size.<br/>
        /// If image_size, the image size is used. Useful if each point<br/>
        /// annotation represents a separate object or boxes grouped with points do not<br/>
        /// represent object boundaries.<br/>
        /// If group_bbox_size, the object size is based on<br/>
        /// the point group bbox size. Useful if each point group represents an object<br/>
        /// or there is a bbox grouped with points, representing the object size.<br/>
        /// * `image_size` - IMAGE_SIZE<br/>
        /// * `group_bbox_size` - GROUP_BBOX_SIZE
        /// </param>
        /// <param name="lineThickness">
        /// Thickness of polylines, relatively to the (image area) ^ 0.5.<br/>
        /// The distance to the boundary around the GT line,<br/>
        /// inside of which the checked line points should be
        /// </param>
        /// <param name="matchOrientation">
        /// Enables or disables polyline orientation comparison
        /// </param>
        /// <param name="lineOrientationThreshold">
        /// The minimal gain in the GT IoU between the given and reversed line directions<br/>
        /// to consider the line inverted.<br/>
        /// Only used when the 'match_orientation' parameter is true
        /// </param>
        /// <param name="matchGroups">
        /// Enables or disables annotation group checks. Only annotations of the same shape type can form matching groups.
        /// </param>
        /// <param name="groupMatchThreshold">
        /// Minimal IoU for groups to be considered matching.<br/>
        /// Only used when the 'match_groups' parameter is true
        /// </param>
        /// <param name="checkCoveredAnnotations">
        /// Check for partially-covered annotations, useful in segmentation tasks
        /// </param>
        /// <param name="objectVisibilityThreshold">
        /// Minimal visible area percent of the spatial annotations (polygons, masks)<br/>
        /// for reporting covered annotations.<br/>
        /// Only used when the 'object_visibility_threshold' parameter is true
        /// </param>
        /// <param name="panopticComparison">
        /// Use only the visible part of the masks and polygons in comparisons
        /// </param>
        /// <param name="attributeComparison">
        /// Incremental attribute comparison settings. The default rule applies to attributes without an override; rules override behavior for individual AttributeSpec ids.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityRequirementListItemRequest(
            int? settingsId,
            string? name,
            int? sortOrder,
            string? filter,
            bool? enabled,
            global::CVAT.OneOf<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? annotationType,
            global::CVAT.OneOf<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>? metric,
            double? requiredScore,
            int? parentRequirement,
            double? iouThreshold,
            double? pointSize,
            global::CVAT.OneOf<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? pointSizeBase,
            double? lineThickness,
            bool? matchOrientation,
            double? lineOrientationThreshold,
            bool? matchGroups,
            double? groupMatchThreshold,
            bool? checkCoveredAnnotations,
            double? objectVisibilityThreshold,
            bool? panopticComparison,
            global::CVAT.AttributeComparisonRequest? attributeComparison)
        {
            this.SettingsId = settingsId;
            this.Name = name;
            this.SortOrder = sortOrder;
            this.Filter = filter;
            this.Enabled = enabled;
            this.AnnotationType = annotationType;
            this.Metric = metric;
            this.RequiredScore = requiredScore;
            this.ParentRequirement = parentRequirement;
            this.IouThreshold = iouThreshold;
            this.PointSize = pointSize;
            this.PointSizeBase = pointSizeBase;
            this.LineThickness = lineThickness;
            this.MatchOrientation = matchOrientation;
            this.LineOrientationThreshold = lineOrientationThreshold;
            this.MatchGroups = matchGroups;
            this.GroupMatchThreshold = groupMatchThreshold;
            this.CheckCoveredAnnotations = checkCoveredAnnotations;
            this.ObjectVisibilityThreshold = objectVisibilityThreshold;
            this.PanopticComparison = panopticComparison;
            this.AttributeComparison = attributeComparison;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityRequirementListItemRequest" /> class.
        /// </summary>
        public QualityRequirementListItemRequest()
        {
        }

    }
}