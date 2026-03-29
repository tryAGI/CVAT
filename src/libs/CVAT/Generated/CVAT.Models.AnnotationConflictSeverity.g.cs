
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `warning` - WARNING<br/>
    /// * `error` - ERROR
    /// </summary>
    public enum AnnotationConflictSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationConflictSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationConflictSeverity value)
        {
            return value switch
            {
                AnnotationConflictSeverity.Error => "error",
                AnnotationConflictSeverity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationConflictSeverity? ToEnum(string value)
        {
            return value switch
            {
                "error" => AnnotationConflictSeverity.Error,
                "warning" => AnnotationConflictSeverity.Warning,
                _ => null,
            };
        }
    }
}