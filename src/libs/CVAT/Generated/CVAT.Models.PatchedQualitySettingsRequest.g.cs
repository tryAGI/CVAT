
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedQualitySettingsRequest
    {
        /// <summary>
        /// A JSON-based logic expression used to filter jobs for quality validation.<br/>
        /// The filter supports various terms to specify conditions on job: ['assignee', 'id', 'stage', 'state', 'task_id', 'task_name', 'type']
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_filter")]
        public string? JobFilter { get; set; }

        /// <summary>
        /// Allow using project settings when computing task quality.<br/>
        /// Only applicable to task quality settings inside projects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherit")]
        public bool? Inherit { get; set; }

        /// <summary>
        /// The primary metric used for quality estimation<br/>
        /// * `accuracy` - ACCURACY<br/>
        /// * `precision` - PRECISION<br/>
        /// * `recall` - RECALL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.QualityTargetMetricJsonConverter))]
        public global::CVAT.QualityTargetMetric? TargetMetric { get; set; }

        /// <summary>
        /// Defines the minimal quality requirements in terms of the selected target metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_metric_threshold")]
        public double? TargetMetricThreshold { get; set; }

        /// <summary>
        /// The maximum number of job validation attempts for the job assignee.<br/>
        /// The job can be automatically accepted if the job quality is above the required<br/>
        /// threshold, defined by the target threshold parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_validations_per_job")]
        public int? MaxValidationsPerJob { get; set; }

        /// <summary>
        /// Used for distinction between matched / unmatched shapes<br/>
        /// Default Value: 0.4F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iou_threshold")]
        public double? IouThreshold { get; set; }

        /// <summary>
        /// Like IoU threshold, but for points.<br/>
        /// The percent of the bbox side, used as the radius of the circle around the GT point,<br/>
        /// where the checked point is expected to be. For boxes with different width and<br/>
        /// height, the "side" is computed as a geometric mean of the width and height.<br/>
        /// Read more: https://cocodataset.org/#keypoints-eval<br/>
        /// Default Value: 0.09F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oks_sigma")]
        public double? OksSigma { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("point_size_base")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.QualityPointSizeBaseJsonConverter))]
        public global::CVAT.QualityPointSizeBase? PointSizeBase { get; set; }

        /// <summary>
        /// Thickness of polylines, relatively to the (image area) ^ 0.5.<br/>
        /// The distance to the boundary around the GT line,<br/>
        /// inside of which the checked line points should be<br/>
        /// Default Value: 0.01F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_thickness")]
        public double? LineThickness { get; set; }

        /// <summary>
        /// Used for distinction between strong / weak (low_overlap) matches<br/>
        /// Default Value: 0.8F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_overlap_threshold")]
        public double? LowOverlapThreshold { get; set; }

        /// <summary>
        /// Enables or disables polyline orientation comparison<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compare_line_orientation")]
        public bool? CompareLineOrientation { get; set; }

        /// <summary>
        /// The minimal gain in the GT IoU between the given and reversed line directions<br/>
        /// to consider the line inverted.<br/>
        /// Only used when the 'compare_line_orientation' parameter is true<br/>
        /// Default Value: 0.1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_orientation_threshold")]
        public double? LineOrientationThreshold { get; set; }

        /// <summary>
        /// Enables or disables annotation group checks<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compare_groups")]
        public bool? CompareGroups { get; set; }

        /// <summary>
        /// Minimal IoU for groups to be considered matching.<br/>
        /// Only used when the 'compare_groups' parameter is true<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_match_threshold")]
        public double? GroupMatchThreshold { get; set; }

        /// <summary>
        /// Check for partially-covered annotations, useful in segmentation tasks<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_covered_annotations")]
        public bool? CheckCoveredAnnotations { get; set; }

        /// <summary>
        /// Minimal visible area percent of the spatial annotations (polygons, masks)<br/>
        /// for reporting covered annotations.<br/>
        /// Only used when the 'object_visibility_threshold' parameter is true<br/>
        /// Default Value: 0.05F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_visibility_threshold")]
        public double? ObjectVisibilityThreshold { get; set; }

        /// <summary>
        /// Use only the visible part of the masks and polygons in comparisons<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panoptic_comparison")]
        public bool? PanopticComparison { get; set; }

        /// <summary>
        /// Enables or disables annotation attribute comparison<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compare_attributes")]
        public bool? CompareAttributes { get; set; }

        /// <summary>
        /// Consider empty frames annotated as "empty". This affects target metrics like<br/>
        /// accuracy in cases there are no annotations. If disabled, frames without annotations<br/>
        /// are counted as not matching (accuracy is 0). If enabled, accuracy will be 1 instead.<br/>
        /// This will also add virtual annotations to empty frames in the comparison results.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("empty_is_annotated")]
        public bool? EmptyIsAnnotated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedQualitySettingsRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedQualitySettingsRequest(
            string? jobFilter,
            bool? inherit,
            global::CVAT.QualityTargetMetric? targetMetric,
            double? targetMetricThreshold,
            int? maxValidationsPerJob,
            double? iouThreshold,
            double? oksSigma,
            global::CVAT.QualityPointSizeBase? pointSizeBase,
            double? lineThickness,
            double? lowOverlapThreshold,
            bool? compareLineOrientation,
            double? lineOrientationThreshold,
            bool? compareGroups,
            double? groupMatchThreshold,
            bool? checkCoveredAnnotations,
            double? objectVisibilityThreshold,
            bool? panopticComparison,
            bool? compareAttributes,
            bool? emptyIsAnnotated)
        {
            this.JobFilter = jobFilter;
            this.Inherit = inherit;
            this.TargetMetric = targetMetric;
            this.TargetMetricThreshold = targetMetricThreshold;
            this.MaxValidationsPerJob = maxValidationsPerJob;
            this.IouThreshold = iouThreshold;
            this.OksSigma = oksSigma;
            this.PointSizeBase = pointSizeBase;
            this.LineThickness = lineThickness;
            this.LowOverlapThreshold = lowOverlapThreshold;
            this.CompareLineOrientation = compareLineOrientation;
            this.LineOrientationThreshold = lineOrientationThreshold;
            this.CompareGroups = compareGroups;
            this.GroupMatchThreshold = groupMatchThreshold;
            this.CheckCoveredAnnotations = checkCoveredAnnotations;
            this.ObjectVisibilityThreshold = objectVisibilityThreshold;
            this.PanopticComparison = panopticComparison;
            this.CompareAttributes = compareAttributes;
            this.EmptyIsAnnotated = emptyIsAnnotated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedQualitySettingsRequest" /> class.
        /// </summary>
        public PatchedQualitySettingsRequest()
        {
        }
    }
}