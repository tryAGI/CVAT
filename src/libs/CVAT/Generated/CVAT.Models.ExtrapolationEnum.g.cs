
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `clamp` - clamp
    /// </summary>
    public enum ExtrapolationEnum
    {
        /// <summary>
        ///
        /// </summary>
        Clamp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtrapolationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtrapolationEnum value)
        {
            return value switch
            {
                ExtrapolationEnum.Clamp => "clamp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtrapolationEnum? ToEnum(string value)
        {
            return value switch
            {
                "clamp" => ExtrapolationEnum.Clamp,
                _ => null,
            };
        }
    }
}