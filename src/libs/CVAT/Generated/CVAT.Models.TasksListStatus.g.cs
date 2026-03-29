
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksListStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Validation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksListStatus value)
        {
            return value switch
            {
                TasksListStatus.Annotation => "annotation",
                TasksListStatus.Completed => "completed",
                TasksListStatus.Validation => "validation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksListStatus? ToEnum(string value)
        {
            return value switch
            {
                "annotation" => TasksListStatus.Annotation,
                "completed" => TasksListStatus.Completed,
                "validation" => TasksListStatus.Validation,
                _ => null,
            };
        }
    }
}