
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `any` - ANY<br/>
    /// * `cuboid` - CUBOID<br/>
    /// * `ellipse` - ELLIPSE<br/>
    /// * `mask` - MASK<br/>
    /// * `points` - POINTS<br/>
    /// * `polygon` - POLYGON<br/>
    /// * `polyline` - POLYLINE<br/>
    /// * `rectangle` - RECTANGLE<br/>
    /// * `skeleton` - SKELETON<br/>
    /// * `tag` - TAG
    /// </summary>
    public enum LabelType
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
    public static class LabelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LabelType value)
        {
            return value switch
            {
                LabelType.Any => "any",
                LabelType.Cuboid => "cuboid",
                LabelType.Ellipse => "ellipse",
                LabelType.Mask => "mask",
                LabelType.Points => "points",
                LabelType.Polygon => "polygon",
                LabelType.Polyline => "polyline",
                LabelType.Rectangle => "rectangle",
                LabelType.Skeleton => "skeleton",
                LabelType.Tag => "tag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LabelType? ToEnum(string value)
        {
            return value switch
            {
                "any" => LabelType.Any,
                "cuboid" => LabelType.Cuboid,
                "ellipse" => LabelType.Ellipse,
                "mask" => LabelType.Mask,
                "points" => LabelType.Points,
                "polygon" => LabelType.Polygon,
                "polyline" => LabelType.Polyline,
                "rectangle" => LabelType.Rectangle,
                "skeleton" => LabelType.Skeleton,
                "tag" => LabelType.Tag,
                _ => null,
            };
        }
    }
}