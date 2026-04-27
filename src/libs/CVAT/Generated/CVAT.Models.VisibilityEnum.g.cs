
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `public` - Public<br/>
    /// * `private` - Private
    /// </summary>
    public enum VisibilityEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VisibilityEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisibilityEnum value)
        {
            return value switch
            {
                VisibilityEnum.Private => "private",
                VisibilityEnum.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisibilityEnum? ToEnum(string value)
        {
            return value switch
            {
                "private" => VisibilityEnum.Private,
                "public" => VisibilityEnum.Public,
                _ => null,
            };
        }
    }
}