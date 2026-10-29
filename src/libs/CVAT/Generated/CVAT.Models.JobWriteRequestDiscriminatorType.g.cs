
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public enum JobWriteRequestDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GroundTruth,
        /// <summary>
        ///
        /// </summary>
        Replica,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobWriteRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobWriteRequestDiscriminatorType value)
        {
            return value switch
            {
                JobWriteRequestDiscriminatorType.GroundTruth => "ground_truth",
                JobWriteRequestDiscriminatorType.Replica => "replica",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobWriteRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ground_truth" => JobWriteRequestDiscriminatorType.GroundTruth,
                "replica" => JobWriteRequestDiscriminatorType.Replica,
                _ => null,
            };
        }
    }
}