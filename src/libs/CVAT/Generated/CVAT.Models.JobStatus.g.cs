
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `annotation` - ANNOTATION<br/>
    /// * `validation` - VALIDATION<br/>
    /// * `completed` - COMPLETED
    /// </summary>
    public enum JobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Validation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStatus value)
        {
            return value switch
            {
                JobStatus.Annotation => "annotation",
                JobStatus.Completed => "completed",
                JobStatus.Validation => "validation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStatus? ToEnum(string value)
        {
            return value switch
            {
                "annotation" => JobStatus.Annotation,
                "completed" => JobStatus.Completed,
                "validation" => JobStatus.Validation,
                _ => null,
            };
        }
    }
}