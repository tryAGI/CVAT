
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum QualityListJobValidationsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityListJobValidationsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityListJobValidationsStatus value)
        {
            return value switch
            {
                QualityListJobValidationsStatus.Accepted => "accepted",
                QualityListJobValidationsStatus.Disabled => "disabled",
                QualityListJobValidationsStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityListJobValidationsStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => QualityListJobValidationsStatus.Accepted,
                "disabled" => QualityListJobValidationsStatus.Disabled,
                "rejected" => QualityListJobValidationsStatus.Rejected,
                _ => null,
            };
        }
    }
}