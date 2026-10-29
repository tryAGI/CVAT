
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `ground_truth` - GROUND_TRUTH
    /// </summary>
    public enum GroundTruthJobCreateTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        GroundTruth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroundTruthJobCreateTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroundTruthJobCreateTypeEnum value)
        {
            return value switch
            {
                GroundTruthJobCreateTypeEnum.GroundTruth => "ground_truth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroundTruthJobCreateTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "ground_truth" => GroundTruthJobCreateTypeEnum.GroundTruth,
                _ => null,
            };
        }
    }
}