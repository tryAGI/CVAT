
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `paid` - PAID<br/>
    /// * `custom` - CUSTOM
    /// </summary>
    public enum Type2c0Enum
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Paid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Type2c0EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Type2c0Enum value)
        {
            return value switch
            {
                Type2c0Enum.Custom => "custom",
                Type2c0Enum.Paid => "paid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Type2c0Enum? ToEnum(string value)
        {
            return value switch
            {
                "custom" => Type2c0Enum.Custom,
                "paid" => Type2c0Enum.Paid,
                _ => null,
            };
        }
    }
}