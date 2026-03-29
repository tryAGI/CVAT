
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `email_address` - Email Address<br/>
    /// * `lowest_weight` - Lowest Weight
    /// </summary>
    public enum SelectionSchemaEnum
    {
        /// <summary>
        /// 
        /// </summary>
        EmailAddress,
        /// <summary>
        /// 
        /// </summary>
        LowestWeight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SelectionSchemaEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelectionSchemaEnum value)
        {
            return value switch
            {
                SelectionSchemaEnum.EmailAddress => "email_address",
                SelectionSchemaEnum.LowestWeight => "lowest_weight",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelectionSchemaEnum? ToEnum(string value)
        {
            return value switch
            {
                "email_address" => SelectionSchemaEnum.EmailAddress,
                "lowest_weight" => SelectionSchemaEnum.LowestWeight,
                _ => null,
            };
        }
    }
}