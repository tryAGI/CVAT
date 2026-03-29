
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
    public enum ShapeType2
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
    public static class ShapeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShapeType2 value)
        {
            return value switch
            {
                ShapeType2.Cuboid => "cuboid",
                ShapeType2.Ellipse => "ellipse",
                ShapeType2.Mask => "mask",
                ShapeType2.Points => "points",
                ShapeType2.Polygon => "polygon",
                ShapeType2.Polyline => "polyline",
                ShapeType2.Rectangle => "rectangle",
                ShapeType2.Skeleton => "skeleton",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShapeType2? ToEnum(string value)
        {
            return value switch
            {
                "cuboid" => ShapeType2.Cuboid,
                "ellipse" => ShapeType2.Ellipse,
                "mask" => ShapeType2.Mask,
                "points" => ShapeType2.Points,
                "polygon" => ShapeType2.Polygon,
                "polyline" => ShapeType2.Polyline,
                "rectangle" => ShapeType2.Rectangle,
                "skeleton" => ShapeType2.Skeleton,
                _ => null,
            };
        }
    }
}