
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `exact` - exact<br/>
    /// * `levenshtein` - levenshtein
    /// </summary>
    public enum ComparatorEnum
    {
        /// <summary>
        ///
        /// </summary>
        Exact,
        /// <summary>
        ///
        /// </summary>
        Levenshtein,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComparatorEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComparatorEnum value)
        {
            return value switch
            {
                ComparatorEnum.Exact => "exact",
                ComparatorEnum.Levenshtein => "levenshtein",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComparatorEnum? ToEnum(string value)
        {
            return value switch
            {
                "exact" => ComparatorEnum.Exact,
                "levenshtein" => ComparatorEnum.Levenshtein,
                _ => null,
            };
        }
    }
}