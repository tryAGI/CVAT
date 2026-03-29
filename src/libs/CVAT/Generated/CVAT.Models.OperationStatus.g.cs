
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `new` - NEW<br/>
    /// * `in progress` - IN_PROGRESS<br/>
    /// * `completed` - COMPLETED<br/>
    /// * `rejected` - REJECTED
    /// </summary>
    public enum OperationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        New,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OperationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OperationStatus value)
        {
            return value switch
            {
                OperationStatus.Completed => "completed",
                OperationStatus.InProgress => "in progress",
                OperationStatus.New => "new",
                OperationStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OperationStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OperationStatus.Completed,
                "in progress" => OperationStatus.InProgress,
                "new" => OperationStatus.New,
                "rejected" => OperationStatus.Rejected,
                _ => null,
            };
        }
    }
}