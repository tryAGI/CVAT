
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `lexicographical` - LEXICOGRAPHICAL<br/>
    /// * `natural` - NATURAL<br/>
    /// * `predefined` - PREDEFINED<br/>
    /// * `random` - RANDOM
    /// </summary>
    public enum SortingMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Lexicographical,
        /// <summary>
        /// 
        /// </summary>
        Natural,
        /// <summary>
        /// 
        /// </summary>
        Predefined,
        /// <summary>
        /// 
        /// </summary>
        Random,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SortingMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SortingMethod value)
        {
            return value switch
            {
                SortingMethod.Lexicographical => "lexicographical",
                SortingMethod.Natural => "natural",
                SortingMethod.Predefined => "predefined",
                SortingMethod.Random => "random",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SortingMethod? ToEnum(string value)
        {
            return value switch
            {
                "lexicographical" => SortingMethod.Lexicographical,
                "natural" => SortingMethod.Natural,
                "predefined" => SortingMethod.Predefined,
                "random" => SortingMethod.Random,
                _ => null,
            };
        }
    }
}