
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public enum QualityListSettingsRequirementsAnnotationType
    {
        /// <summary>
        ///
        /// </summary>
        Ellipse,
        /// <summary>
        ///
        /// </summary>
        Mask,
        /// <summary>
        ///
        /// </summary>
        Points,
        /// <summary>
        ///
        /// </summary>
        Polygon,
        /// <summary>
        ///
        /// </summary>
        Polyline,
        /// <summary>
        ///
        /// </summary>
        Rectangle,
        /// <summary>
        ///
        /// </summary>
        Skeleton,
        /// <summary>
        ///
        /// </summary>
        SkeletonKeypoint,
        /// <summary>
        ///
        /// </summary>
        Tag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityListSettingsRequirementsAnnotationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityListSettingsRequirementsAnnotationType value)
        {
            return value switch
            {
                QualityListSettingsRequirementsAnnotationType.Ellipse => "ellipse",
                QualityListSettingsRequirementsAnnotationType.Mask => "mask",
                QualityListSettingsRequirementsAnnotationType.Points => "points",
                QualityListSettingsRequirementsAnnotationType.Polygon => "polygon",
                QualityListSettingsRequirementsAnnotationType.Polyline => "polyline",
                QualityListSettingsRequirementsAnnotationType.Rectangle => "rectangle",
                QualityListSettingsRequirementsAnnotationType.Skeleton => "skeleton",
                QualityListSettingsRequirementsAnnotationType.SkeletonKeypoint => "skeleton_keypoint",
                QualityListSettingsRequirementsAnnotationType.Tag => "tag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityListSettingsRequirementsAnnotationType? ToEnum(string value)
        {
            return value switch
            {
                "ellipse" => QualityListSettingsRequirementsAnnotationType.Ellipse,
                "mask" => QualityListSettingsRequirementsAnnotationType.Mask,
                "points" => QualityListSettingsRequirementsAnnotationType.Points,
                "polygon" => QualityListSettingsRequirementsAnnotationType.Polygon,
                "polyline" => QualityListSettingsRequirementsAnnotationType.Polyline,
                "rectangle" => QualityListSettingsRequirementsAnnotationType.Rectangle,
                "skeleton" => QualityListSettingsRequirementsAnnotationType.Skeleton,
                "skeleton_keypoint" => QualityListSettingsRequirementsAnnotationType.SkeletonKeypoint,
                "tag" => QualityListSettingsRequirementsAnnotationType.Tag,
                _ => null,
            };
        }
    }
}