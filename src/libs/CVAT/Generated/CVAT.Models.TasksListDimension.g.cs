
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksListDimension
    {
        /// <summary>
        /// 
        /// </summary>
        x2d,
        /// <summary>
        /// 
        /// </summary>
        x3d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksListDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksListDimension value)
        {
            return value switch
            {
                TasksListDimension.x2d => "2d",
                TasksListDimension.x3d => "3d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksListDimension? ToEnum(string value)
        {
            return value switch
            {
                "2d" => TasksListDimension.x2d,
                "3d" => TasksListDimension.x3d,
                _ => null,
            };
        }
    }
}