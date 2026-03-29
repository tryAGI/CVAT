
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum LabelsListType
    {
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        Cuboid,
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
        Tag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LabelsListTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LabelsListType value)
        {
            return value switch
            {
                LabelsListType.Any => "any",
                LabelsListType.Cuboid => "cuboid",
                LabelsListType.Ellipse => "ellipse",
                LabelsListType.Mask => "mask",
                LabelsListType.Points => "points",
                LabelsListType.Polygon => "polygon",
                LabelsListType.Polyline => "polyline",
                LabelsListType.Rectangle => "rectangle",
                LabelsListType.Skeleton => "skeleton",
                LabelsListType.Tag => "tag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LabelsListType? ToEnum(string value)
        {
            return value switch
            {
                "any" => LabelsListType.Any,
                "cuboid" => LabelsListType.Cuboid,
                "ellipse" => LabelsListType.Ellipse,
                "mask" => LabelsListType.Mask,
                "points" => LabelsListType.Points,
                "polygon" => LabelsListType.Polygon,
                "polyline" => LabelsListType.Polyline,
                "rectangle" => LabelsListType.Rectangle,
                "skeleton" => LabelsListType.Skeleton,
                "tag" => LabelsListType.Tag,
                _ => null,
            };
        }
    }
}