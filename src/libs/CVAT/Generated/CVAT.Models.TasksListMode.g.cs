
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksListMode
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
    public static class TasksListModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksListMode value)
        {
            return value switch
            {
                TasksListMode.Annotation => "annotation",
                TasksListMode.Interpolation => "interpolation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksListMode? ToEnum(string value)
        {
            return value switch
            {
                "annotation" => TasksListMode.Annotation,
                "interpolation" => TasksListMode.Interpolation,
                _ => null,
            };
        }
    }
}