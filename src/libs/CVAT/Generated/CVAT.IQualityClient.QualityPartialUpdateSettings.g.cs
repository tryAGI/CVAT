#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// Update a quality settings instance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.QualitySettings> QualityPartialUpdateSettingsAsync(
            int id,

            global::CVAT.PatchedQualitySettingsRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a quality settings instance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.QualitySettings>> QualityPartialUpdateSettingsAsResponseAsync(
            int id,

            global::CVAT.PatchedQualitySettingsRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a quality settings instance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="jobFilter">
        /// A JSON-based logic expression used to filter jobs for quality validation.<br/>
        /// The filter supports various terms to specify conditions on job: ['assignee', 'id', 'stage', 'state', 'task_id', 'task_name', 'type']
        /// </param>
        /// <param name="inherit">
        /// Allow using project settings when computing task quality.<br/>
        /// Only applicable to task quality settings inside projects
        /// </param>
        /// <param name="targetMetric">
        /// The primary metric used for quality estimation<br/>
        /// * `accuracy` - ACCURACY<br/>
        /// * `precision` - PRECISION<br/>
        /// * `recall` - RECALL
        /// </param>
        /// <param name="targetMetricThreshold">
        /// Defines the minimal quality requirements in terms of the selected target metric.
        /// </param>
        /// <param name="maxValidationsPerJob">
        /// The maximum number of job validation attempts for the job assignee.<br/>
        /// The job can be automatically accepted if the job quality is above the required<br/>
        /// threshold, defined by the target threshold parameter.
        /// </param>
        /// <param name="iouThreshold">
        /// Used for distinction between matched / unmatched shapes<br/>
        /// Default Value: 0.4F
        /// </param>
        /// <param name="oksSigma">
        /// Like IoU threshold, but for points.<br/>
        /// The percent of the bbox side, used as the radius of the circle around the GT point,<br/>
        /// where the checked point is expected to be. For boxes with different width and<br/>
        /// height, the "side" is computed as a geometric mean of the width and height.<br/>
        /// Read more: https://cocodataset.org/#keypoints-eval<br/>
        /// Default Value: 0.09F
        /// </param>
        /// <param name="pointSizeBase">
        /// When comparing point annotations (including both separate points and point groups),<br/>
        /// the OKS sigma parameter defines matching area for each GT point based to the<br/>
        /// object size. The point size base parameter allows to configure how to determine<br/>
        /// the object size.<br/>
        /// If image_size, the image size is used. Useful if each point<br/>
        /// annotation represents a separate object or boxes grouped with points do not<br/>
        /// represent object boundaries.<br/>
        /// If group_bbox_size, the object size is based on<br/>
        /// the point group bbox size. Useful if each point group represents an object<br/>
        /// or there is a bbox grouped with points, representing the object size.<br/>
        /// * `image_size` - IMAGE_SIZE<br/>
        /// * `group_bbox_size` - GROUP_BBOX_SIZE<br/>
        /// Default Value: group_bbox_size
        /// </param>
        /// <param name="lineThickness">
        /// Thickness of polylines, relatively to the (image area) ^ 0.5.<br/>
        /// The distance to the boundary around the GT line,<br/>
        /// inside of which the checked line points should be<br/>
        /// Default Value: 0.01F
        /// </param>
        /// <param name="lowOverlapThreshold">
        /// Used for distinction between strong / weak (low_overlap) matches<br/>
        /// Default Value: 0.8F
        /// </param>
        /// <param name="compareLineOrientation">
        /// Enables or disables polyline orientation comparison<br/>
        /// Default Value: true
        /// </param>
        /// <param name="lineOrientationThreshold">
        /// The minimal gain in the GT IoU between the given and reversed line directions<br/>
        /// to consider the line inverted.<br/>
        /// Only used when the 'compare_line_orientation' parameter is true<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="compareGroups">
        /// Enables or disables annotation group checks<br/>
        /// Default Value: true
        /// </param>
        /// <param name="groupMatchThreshold">
        /// Minimal IoU for groups to be considered matching.<br/>
        /// Only used when the 'compare_groups' parameter is true<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="checkCoveredAnnotations">
        /// Check for partially-covered annotations, useful in segmentation tasks<br/>
        /// Default Value: true
        /// </param>
        /// <param name="objectVisibilityThreshold">
        /// Minimal visible area percent of the spatial annotations (polygons, masks)<br/>
        /// for reporting covered annotations.<br/>
        /// Only used when the 'object_visibility_threshold' parameter is true<br/>
        /// Default Value: 0.05F
        /// </param>
        /// <param name="panopticComparison">
        /// Use only the visible part of the masks and polygons in comparisons<br/>
        /// Default Value: true
        /// </param>
        /// <param name="compareAttributes">
        /// Enables or disables annotation attribute comparison<br/>
        /// Default Value: true
        /// </param>
        /// <param name="emptyIsAnnotated">
        /// Consider empty frames annotated as "empty". This affects target metrics like<br/>
        /// accuracy in cases there are no annotations. If disabled, frames without annotations<br/>
        /// are counted as not matching (accuracy is 0). If enabled, accuracy will be 1 instead.<br/>
        /// This will also add virtual annotations to empty frames in the comparison results.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.QualitySettings> QualityPartialUpdateSettingsAsync(
            int id,
            string? jobFilter = default,
            bool? inherit = default,
            global::CVAT.QualityTargetMetric? targetMetric = default,
            double? targetMetricThreshold = default,
            int? maxValidationsPerJob = default,
            double? iouThreshold = default,
            double? oksSigma = default,
            global::CVAT.QualityPointSizeBase? pointSizeBase = default,
            double? lineThickness = default,
            double? lowOverlapThreshold = default,
            bool? compareLineOrientation = default,
            double? lineOrientationThreshold = default,
            bool? compareGroups = default,
            double? groupMatchThreshold = default,
            bool? checkCoveredAnnotations = default,
            double? objectVisibilityThreshold = default,
            bool? panopticComparison = default,
            bool? compareAttributes = default,
            bool? emptyIsAnnotated = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}