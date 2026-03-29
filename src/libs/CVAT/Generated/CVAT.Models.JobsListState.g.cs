
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsListState
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
    public static class JobsListStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsListState value)
        {
            return value switch
            {
                JobsListState.Completed => "completed",
                JobsListState.InProgress => "in progress",
                JobsListState.New => "new",
                JobsListState.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsListState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => JobsListState.Completed,
                "in progress" => JobsListState.InProgress,
                "new" => JobsListState.New,
                "rejected" => JobsListState.Rejected,
                _ => null,
            };
        }
    }
}