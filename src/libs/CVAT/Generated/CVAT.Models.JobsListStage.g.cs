
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsListStage
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
    public static class JobsListStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsListStage value)
        {
            return value switch
            {
                JobsListStage.Acceptance => "acceptance",
                JobsListStage.Annotation => "annotation",
                JobsListStage.Validation => "validation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsListStage? ToEnum(string value)
        {
            return value switch
            {
                "acceptance" => JobsListStage.Acceptance,
                "annotation" => JobsListStage.Annotation,
                "validation" => JobsListStage.Validation,
                _ => null,
            };
        }
    }
}