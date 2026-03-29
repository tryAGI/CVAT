
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `disabled` - DISABLED<br/>
    /// * `accepted` - ACCEPTED<br/>
    /// * `rejected` - REJECTED
    /// </summary>
    public enum JobValidationStatusEnum
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
    public static class JobValidationStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobValidationStatusEnum value)
        {
            return value switch
            {
                JobValidationStatusEnum.Accepted => "accepted",
                JobValidationStatusEnum.Disabled => "disabled",
                JobValidationStatusEnum.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobValidationStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => JobValidationStatusEnum.Accepted,
                "disabled" => JobValidationStatusEnum.Disabled,
                "rejected" => JobValidationStatusEnum.Rejected,
                _ => null,
            };
        }
    }
}