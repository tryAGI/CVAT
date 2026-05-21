
#nullable enable

namespace CVAT
{
    /// <summary>
    /// Default Value: replace
    /// </summary>
    public enum JobsCreateAnnotationsImportMode
    {
        /// <summary>
        /// 
        /// </summary>
        Append,
        /// <summary>
        /// 
        /// </summary>
        Replace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsCreateAnnotationsImportModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsCreateAnnotationsImportMode value)
        {
            return value switch
            {
                JobsCreateAnnotationsImportMode.Append => "append",
                JobsCreateAnnotationsImportMode.Replace => "replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsCreateAnnotationsImportMode? ToEnum(string value)
        {
            return value switch
            {
                "append" => JobsCreateAnnotationsImportMode.Append,
                "replace" => JobsCreateAnnotationsImportMode.Replace,
                _ => null,
            };
        }
    }
}