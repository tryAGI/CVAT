
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `annotation` - ANNOTATION<br/>
    /// * `ground_truth` - GROUND_TRUTH<br/>
    /// * `replica` - REPLICA
    /// </summary>
    public enum JobType
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
    public static class JobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobType value)
        {
            return value switch
            {
                JobType.Annotation => "annotation",
                JobType.GroundTruth => "ground_truth",
                JobType.Replica => "replica",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobType? ToEnum(string value)
        {
            return value switch
            {
                "annotation" => JobType.Annotation,
                "ground_truth" => JobType.GroundTruth,
                "replica" => JobType.Replica,
                _ => null,
            };
        }
    }
}