
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `rectangle` - RECTANGLE<br/>
    /// * `polygon` - POLYGON<br/>
    /// * `polyline` - POLYLINE<br/>
    /// * `points` - POINTS<br/>
    /// * `ellipse` - ELLIPSE<br/>
    /// * `cuboid` - CUBOID<br/>
    /// * `mask` - MASK<br/>
    /// * `skeleton` - SKELETON
    /// </summary>
    public enum ShapeType
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShapeType value)
        {
            return value switch
            {
                ShapeType.Cuboid => "cuboid",
                ShapeType.Ellipse => "ellipse",
                ShapeType.Mask => "mask",
                ShapeType.Points => "points",
                ShapeType.Polygon => "polygon",
                ShapeType.Polyline => "polyline",
                ShapeType.Rectangle => "rectangle",
                ShapeType.Skeleton => "skeleton",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShapeType? ToEnum(string value)
        {
            return value switch
            {
                "cuboid" => ShapeType.Cuboid,
                "ellipse" => ShapeType.Ellipse,
                "mask" => ShapeType.Mask,
                "points" => ShapeType.Points,
                "polygon" => ShapeType.Polygon,
                "polyline" => ShapeType.Polyline,
                "rectangle" => ShapeType.Rectangle,
                "skeleton" => ShapeType.Skeleton,
                _ => null,
            };
        }
    }
}