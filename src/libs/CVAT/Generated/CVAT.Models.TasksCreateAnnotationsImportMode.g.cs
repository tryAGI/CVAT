
#nullable enable

namespace CVAT
{
    /// <summary>
    /// Default Value: replace
    /// </summary>
    public enum TasksCreateAnnotationsImportMode
    {
        /// <summary>
        /// 
        /// </summary>
        Append,
        /// <summary>
        /// 
        /// </summary>
        Replace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksCreateAnnotationsImportModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksCreateAnnotationsImportMode value)
        {
            return value switch
            {
                TasksCreateAnnotationsImportMode.Append => "append",
                TasksCreateAnnotationsImportMode.Replace => "replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksCreateAnnotationsImportMode? ToEnum(string value)
        {
            return value switch
            {
                "append" => TasksCreateAnnotationsImportMode.Append,
                "replace" => TasksCreateAnnotationsImportMode.Replace,
                _ => null,
            };
        }
    }
}