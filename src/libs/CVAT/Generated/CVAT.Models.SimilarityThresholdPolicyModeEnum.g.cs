
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `constant` - constant<br/>
    /// * `linear` - linear
    /// </summary>
    public enum SimilarityThresholdPolicyModeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Constant,
        /// <summary>
        ///
        /// </summary>
        Linear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimilarityThresholdPolicyModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimilarityThresholdPolicyModeEnum value)
        {
            return value switch
            {
                SimilarityThresholdPolicyModeEnum.Constant => "constant",
                SimilarityThresholdPolicyModeEnum.Linear => "linear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimilarityThresholdPolicyModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "constant" => SimilarityThresholdPolicyModeEnum.Constant,
                "linear" => SimilarityThresholdPolicyModeEnum.Linear,
                _ => null,
            };
        }
    }
}