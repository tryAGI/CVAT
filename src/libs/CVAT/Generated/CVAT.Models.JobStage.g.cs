
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `annotation` - ANNOTATION<br/>
    /// * `validation` - VALIDATION<br/>
    /// * `acceptance` - ACCEPTANCE
    /// </summary>
    public enum JobStage
    {
        /// <summary>
        /// 
        /// </summary>
        Acceptance,
        /// <summary>
        /// 
        /// </summary>
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        Validation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStage value)
        {
            return value switch
            {
                JobStage.Acceptance => "acceptance",
                JobStage.Annotation => "annotation",
                JobStage.Validation => "validation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStage? ToEnum(string value)
        {
            return value switch
            {
                "acceptance" => JobStage.Acceptance,
                "annotation" => JobStage.Annotation,
                "validation" => JobStage.Validation,
                _ => null,
            };
        }
    }
}