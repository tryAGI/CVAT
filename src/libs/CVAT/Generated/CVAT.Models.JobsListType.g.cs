
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public enum JobsListType
    {
        /// <summary>
        ///
        /// </summary>
        Annotation,
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
    public static class JobsListTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsListType value)
        {
            return value switch
            {
                JobsListType.Annotation => "annotation",
                JobsListType.GroundTruth => "ground_truth",
                JobsListType.Replica => "replica",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsListType? ToEnum(string value)
        {
            return value switch
            {
                "annotation" => JobsListType.Annotation,
                "ground_truth" => JobsListType.GroundTruth,
                "replica" => JobsListType.Replica,
                _ => null,
            };
        }
    }
}