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
            double? iouThreshold = default,
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