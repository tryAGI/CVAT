
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksListValidationMode
    {
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        GtPool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksListValidationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksListValidationMode value)
        {
            return value switch
            {
                TasksListValidationMode.Gt => "gt",
                TasksListValidationMode.GtPool => "gt_pool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksListValidationMode? ToEnum(string value)
        {
            return value switch
            {
                "gt" => TasksListValidationMode.Gt,
                "gt_pool" => TasksListValidationMode.GtPool,
                _ => null,
            };
        }
    }
}