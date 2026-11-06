
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `gt.shape_area` - gt.shape_area
    /// </summary>
    public enum InputEnum
    {
        /// <summary>
        ///
        /// </summary>
        GtShapeArea,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputEnum value)
        {
            return value switch
            {
                InputEnum.GtShapeArea => "gt.shape_area",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputEnum? ToEnum(string value)
        {
            return value switch
            {
                "gt.shape_area" => InputEnum.GtShapeArea,
                _ => null,
            };
        }
    }
}