
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `default` - DEFAULT<br/>
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
        Default,
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
                LimitTypeEnum.Default => "default",
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
                "default" => LimitTypeEnum.Default,
                "paid" => LimitTypeEnum.Paid,
                _ => null,
            };
        }
    }
}