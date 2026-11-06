
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `iou` - iou
    /// </summary>
    public enum SimilarityThresholdPolicyTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Iou,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimilarityThresholdPolicyTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimilarityThresholdPolicyTypeEnum value)
        {
            return value switch
            {
                SimilarityThresholdPolicyTypeEnum.Iou => "iou",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimilarityThresholdPolicyTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "iou" => SimilarityThresholdPolicyTypeEnum.Iou,
                _ => null,
            };
        }
    }
}