#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// Create a quality requirement
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.QualityRequirement> QualityCreateSettingsRequirementsAsync(

            global::CVAT.QualityRequirementRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a quality requirement
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.QualityRequirement>> QualityCreateSettingsRequirementsAsResponseAsync(

            global::CVAT.QualityRequirementRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a quality requirement
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.QualityRequirement> QualityCreateSettingsRequirementsAsync(
            int? settingsId = default,
            string? name = default,
            int? sortOrder = default,
            string? filter = default,
            bool? enabled = default,
            global::CVAT.OneOf<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? annotationType = default,
            global::CVAT.OneOf<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>? metric = default,
            double? requiredScore = default,
            int? parentRequirement = default,
            global::CVAT.OneOf<global::CVAT.SimilarityMetricEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? similarityMetric = default,
            global::CVAT.OneOf<double?, global::CVAT.SimilarityThresholdPolicyRequest>? iouThreshold = default,
            double? oksThreshold = default,
            double? boundaryFThreshold = default,
            double? boundaryFTolerance = default,
            double? pointSize = default,
            global::CVAT.OneOf<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? pointSizeBase = default,
            double? lineThickness = default,
            bool? matchOrientation = default,
            double? lineOrientationThreshold = default,
            bool? matchGroups = default,
            double? groupMatchThreshold = default,
            bool? checkCoveredAnnotations = default,
            double? objectVisibilityThreshold = default,
            bool? panopticComparison = default,
            global::CVAT.AttributeComparisonRequest? attributeComparison = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}