
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `paid` - PAID<br/>
    /// * `custom` - CUSTOM
    /// </summary>
    public enum LimitTypeEnum
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
    public static class LimitTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LimitTypeEnum value)
        {
            return value switch
            {
                LimitTypeEnum.Custom => "custom",
                LimitTypeEnum.Paid => "paid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LimitTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "custom" => LimitTypeEnum.Custom,
                "paid" => LimitTypeEnum.Paid,
                _ => null,
            };
        }
    }
}