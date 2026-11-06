
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchedQualityRequirementRequest
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
        /// * `recall` - RECALL<br/>
        /// * `jaccard_index` - JACCARD_INDEX<br/>
        /// * `dice` - DICE<br/>
        /// * `mean_accuracy` - MEAN_ACCURACY<br/>
        /// * `mean_precision` - MEAN_PRECISION<br/>
        /// * `mean_recall` - MEAN_RECALL<br/>
        /// * `mean_jaccard_index` - MEAN_JACCARD_INDEX<br/>
        /// * `mean_dice` - MEAN_DICE<br/>
        /// * `label_accuracy` - LABEL_ACCURACY<br/>
        /// * `label_precision` - LABEL_PRECISION<br/>
        /// * `label_recall` - LABEL_RECALL<br/>
        /// * `label_jaccard_index` - LABEL_JACCARD_INDEX<br/>
        /// * `label_dice` - LABEL_DICE
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
        /// The similarity metric used to match the objects. The supported metrics<br/>
        /// depend on the annotation type:<br/>
        /// - ellipse: 'boundary_f', 'iou' (default);<br/>
        /// - mask: 'boundary_f', 'iou' (default);<br/>
        /// - points: 'oks' (default);<br/>
        /// - polygon: 'boundary_f', 'iou' (default);<br/>
        /// - polyline: 'boundary_f', 'iou' (default);<br/>
        /// - rectangle: 'boundary_f', 'iou' (default);<br/>
        /// - skeleton: 'oks' (default);<br/>
        /// - skeleton_keypoint: 'oks' (default);<br/>
        /// - tag: 'equality' (default)<br/>
        /// * `iou` - IoU<br/>
        /// * `oks` - OKS<br/>
        /// * `boundary_f` - Boundary F<br/>
        /// * `equality` - Equality
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.SimilarityMetricEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>))]
        public global::CVAT.OneOf<global::CVAT.SimilarityMetricEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? SimilarityMetric { get; set; }

        /// <summary>
        /// The minimal IoU for distinction between matched / unmatched objects. Only used with the 'iou' similarity metric. A constant threshold or an IoU policy by GT shape area (rectangle, polygon, mask, ellipse). Null inherits the whole threshold from the parent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iou_threshold")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OneOfJsonConverter<double?, global::CVAT.SimilarityThresholdPolicyRequest>))]
        public global::CVAT.OneOf<double?, global::CVAT.SimilarityThresholdPolicyRequest>? IouThreshold { get; set; }

        /// <summary>
        /// The minimal OKS for distinction between matched / unmatched objects.<br/>
        /// Only used with the 'oks' similarity metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oks_threshold")]
        public double? OksThreshold { get; set; }

        /// <summary>
        /// The minimal Boundary F score for distinction between matched / unmatched<br/>
        /// objects. Only used with the 'boundary_f' similarity metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("boundary_f_threshold")]
        public double? BoundaryFThreshold { get; set; }

        /// <summary>
        /// The maximum allowed boundary deviation, in pixels. The boundary points<br/>
        /// within this distance from the other object boundary are considered matching.<br/>
        /// Only used with the 'boundary_f' similarity metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("boundary_f_tolerance")]
        public double? BoundaryFTolerance { get; set; }

        /// <summary>
        /// The point "size" (the OKS sigma), as a fraction of the object size, defined by<br/>
        /// the point size base. Corresponds to the standard deviation of the keypoint position.<br/>
        /// Larger values give larger areas around the GT points, where the checked points<br/>
        /// are accepted.<br/>
        /// Read more about the point matching in the documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("point_size")]
        public double? PointSize { get; set; }

        /// <summary>
        /// When comparing point groups, skeletons, and skeleton keypoints,<br/>
        /// the point size parameter defines matching area for each GT point based to the<br/>
        /// object size. The point size base parameter allows to configure how to determine<br/>
        /// the object size. Single points without a group are always compared<br/>
        /// using the image size.<br/>
        /// If image_size, the image size is used. Useful if each point<br/>
        /// annotation represents a separate object or boxes grouped with points do not<br/>
        /// represent object boundaries.<br/>
        /// If group_bbox_size, the object size is based on<br/>
        /// the point group or skeleton bbox size. Useful if each point group represents<br/>
        /// an object or there is a bbox grouped with points, representing the object size.<br/>
        /// * `image_size` - IMAGE_SIZE<br/>
        /// * `group_bbox_size` - GROUP_BBOX_SIZE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("point_size_base")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>))]
        public global::CVAT.OneOf<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? PointSizeBase { get; set; }

        /// <summary>
        /// Thickness of polylines, relatively to the (image area) ^ 0.5.<br/>
        /// The distance to the boundary around the GT line,<br/>
        /// inside of which the checked line points should be.<br/>
        /// With the 'boundary_f' similarity metric, the boundary tolerance is used instead
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
        /// Initializes a new instance of the <see cref="PatchedQualityRequirementRequest" /> class.
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
        /// * `recall` - RECALL<br/>
        /// * `jaccard_index` - JACCARD_INDEX<br/>
        /// * `dice` - DICE<br/>
        /// * `mean_accuracy` - MEAN_ACCURACY<br/>
        /// * `mean_precision` - MEAN_PRECISION<br/>
        /// * `mean_recall` - MEAN_RECALL<br/>
        /// * `mean_jaccard_index` - MEAN_JACCARD_INDEX<br/>
        /// * `mean_dice` - MEAN_DICE<br/>
        /// * `label_accuracy` - LABEL_ACCURACY<br/>
        /// * `label_precision` - LABEL_PRECISION<br/>
        /// * `label_recall` - LABEL_RECALL<br/>
        /// * `label_jaccard_index` - LABEL_JACCARD_INDEX<br/>
        /// * `label_dice` - LABEL_DICE
        /// </param>
        /// <param name="requiredScore">
        /// Defines the minimal quality requirements in terms of the selected target metric.
        /// </param>
        /// <param name="parentRequirement">
        /// The parent requirement. Child requirements inherit comparison settings from it.
        /// </param>
        /// <param name="similarityMetric">
        /// The similarity metric used to match the objects. The supported metrics<br/>
        /// depend on the annotation type:<br/>
        /// - ellipse: 'boundary_f', 'iou' (default);<br/>
        /// - mask: 'boundary_f', 'iou' (default);<br/>
        /// - points: 'oks' (default);<br/>
        /// - polygon: 'boundary_f', 'iou' (default);<br/>
        /// - polyline: 'boundary_f', 'iou' (default);<br/>
        /// - rectangle: 'boundary_f', 'iou' (default);<br/>
        /// - skeleton: 'oks' (default);<br/>
        /// - skeleton_keypoint: 'oks' (default);<br/>
        /// - tag: 'equality' (default)<br/>
        /// * `iou` - IoU<br/>
        /// * `oks` - OKS<br/>
        /// * `boundary_f` - Boundary F<br/>
        /// * `equality` - Equality
        /// </param>
        /// <param name="iouThreshold">
        /// The minimal IoU for distinction between matched / unmatched objects. Only used with the 'iou' similarity metric. A constant threshold or an IoU policy by GT shape area (rectangle, polygon, mask, ellipse). Null inherits the whole threshold from the parent.
        /// </param>
        /// <param name="oksThreshold">
        /// The minimal OKS for distinction between matched / unmatched objects.<br/>
        /// Only used with the 'oks' similarity metric.
        /// </param>
        /// <param name="boundaryFThreshold">
        /// The minimal Boundary F score for distinction between matched / unmatched<br/>
        /// objects. Only used with the 'boundary_f' similarity metric.
        /// </param>
        /// <param name="boundaryFTolerance">
        /// The maximum allowed boundary deviation, in pixels. The boundary points<br/>
        /// within this distance from the other object boundary are considered matching.<br/>
        /// Only used with the 'boundary_f' similarity metric.
        /// </param>
        /// <param name="pointSize">
        /// The point "size" (the OKS sigma), as a fraction of the object size, defined by<br/>
        /// the point size base. Corresponds to the standard deviation of the keypoint position.<br/>
        /// Larger values give larger areas around the GT points, where the checked points<br/>
        /// are accepted.<br/>
        /// Read more about the point matching in the documentation.
        /// </param>
        /// <param name="pointSizeBase">
        /// When comparing point groups, skeletons, and skeleton keypoints,<br/>
        /// the point size parameter defines matching area for each GT point based to the<br/>
        /// object size. The point size base parameter allows to configure how to determine<br/>
        /// the object size. Single points without a group are always compared<br/>
        /// using the image size.<br/>
        /// If image_size, the image size is used. Useful if each point<br/>
        /// annotation represents a separate object or boxes grouped with points do not<br/>
        /// represent object boundaries.<br/>
        /// If group_bbox_size, the object size is based on<br/>
        /// the point group or skeleton bbox size. Useful if each point group represents<br/>
        /// an object or there is a bbox grouped with points, representing the object size.<br/>
        /// * `image_size` - IMAGE_SIZE<br/>
        /// * `group_bbox_size` - GROUP_BBOX_SIZE
        /// </param>
        /// <param name="lineThickness">
        /// Thickness of polylines, relatively to the (image area) ^ 0.5.<br/>
        /// The distance to the boundary around the GT line,<br/>
        /// inside of which the checked line points should be.<br/>
        /// With the 'boundary_f' similarity metric, the boundary tolerance is used instead
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
        public PatchedQualityRequirementRequest(
            int? settingsId,
            string? name,
            int? sortOrder,
            string? filter,
            bool? enabled,
            global::CVAT.OneOf<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? annotationType,
            global::CVAT.OneOf<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>? metric,
            double? requiredScore,
            int? parentRequirement,
            global::CVAT.OneOf<global::CVAT.SimilarityMetricEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? similarityMetric,
            global::CVAT.OneOf<double?, global::CVAT.SimilarityThresholdPolicyRequest>? iouThreshold,
            double? oksThreshold,
            double? boundaryFThreshold,
            double? boundaryFTolerance,
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
            this.SimilarityMetric = similarityMetric;
            this.IouThreshold = iouThreshold;
            this.OksThreshold = oksThreshold;
            this.BoundaryFThreshold = boundaryFThreshold;
            this.BoundaryFTolerance = boundaryFTolerance;
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
        /// Initializes a new instance of the <see cref="PatchedQualityRequirementRequest" /> class.
        /// </summary>
        public PatchedQualityRequirementRequest()
        {
        }

    }
}