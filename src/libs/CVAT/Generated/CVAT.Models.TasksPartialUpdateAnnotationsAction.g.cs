
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksPartialUpdateAnnotationsAction
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksPartialUpdateAnnotationsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksPartialUpdateAnnotationsAction value)
        {
            return value switch
            {
                TasksPartialUpdateAnnotationsAction.Create => "create",
                TasksPartialUpdateAnnotationsAction.Delete => "delete",
                TasksPartialUpdateAnnotationsAction.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksPartialUpdateAnnotationsAction? ToEnum(string value)
        {
            return value switch
            {
                "create" => TasksPartialUpdateAnnotationsAction.Create,
                "delete" => TasksPartialUpdateAnnotationsAction.Delete,
                "update" => TasksPartialUpdateAnnotationsAction.Update,
                _ => null,
            };
        }
    }
}