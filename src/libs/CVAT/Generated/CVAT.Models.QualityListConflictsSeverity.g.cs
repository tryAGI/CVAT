
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum QualityListConflictsSeverity
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
    public static class QualityListConflictsSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityListConflictsSeverity value)
        {
            return value switch
            {
                QualityListConflictsSeverity.Error => "error",
                QualityListConflictsSeverity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityListConflictsSeverity? ToEnum(string value)
        {
            return value switch
            {
                "error" => QualityListConflictsSeverity.Error,
                "warning" => QualityListConflictsSeverity.Warning,
                _ => null,
            };
        }
    }
}