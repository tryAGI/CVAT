
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsListMode
    {
        /// <summary>
        /// 
        /// </summary>
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        Interpolation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsListModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsListMode value)
        {
            return value switch
            {
                JobsListMode.Annotation => "annotation",
                JobsListMode.Interpolation => "interpolation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsListMode? ToEnum(string value)
        {
            return value switch
            {
                "annotation" => JobsListMode.Annotation,
                "interpolation" => JobsListMode.Interpolation,
                _ => null,
            };
        }
    }
}