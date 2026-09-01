
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `tag` - Tag<br/>
    /// * `rectangle` - Rectangle<br/>
    /// * `skeleton` - Skeleton<br/>
    /// * `skeleton_keypoint` - Skeleton Keypoint<br/>
    /// * `points` - Points<br/>
    /// * `polyline` - Polyline<br/>
    /// * `mask` - Mask<br/>
    /// * `polygon` - Polygon<br/>
    /// * `ellipse` - Ellipse
    /// </summary>
    public enum AnnotationTypeEnum
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
    public static class AnnotationTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationTypeEnum value)
        {
            return value switch
            {
                AnnotationTypeEnum.Ellipse => "ellipse",
                AnnotationTypeEnum.Mask => "mask",
                AnnotationTypeEnum.Points => "points",
                AnnotationTypeEnum.Polygon => "polygon",
                AnnotationTypeEnum.Polyline => "polyline",
                AnnotationTypeEnum.Rectangle => "rectangle",
                AnnotationTypeEnum.Skeleton => "skeleton",
                AnnotationTypeEnum.SkeletonKeypoint => "skeleton_keypoint",
                AnnotationTypeEnum.Tag => "tag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "ellipse" => AnnotationTypeEnum.Ellipse,
                "mask" => AnnotationTypeEnum.Mask,
                "points" => AnnotationTypeEnum.Points,
                "polygon" => AnnotationTypeEnum.Polygon,
                "polyline" => AnnotationTypeEnum.Polyline,
                "rectangle" => AnnotationTypeEnum.Rectangle,
                "skeleton" => AnnotationTypeEnum.Skeleton,
                "skeleton_keypoint" => AnnotationTypeEnum.SkeletonKeypoint,
                "tag" => AnnotationTypeEnum.Tag,
                _ => null,
            };
        }
    }
}