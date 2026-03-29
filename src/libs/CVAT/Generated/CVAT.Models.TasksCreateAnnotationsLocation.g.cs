
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksCreateAnnotationsLocation
    {
        /// <summary>
        /// 
        /// </summary>
        CloudStorage,
        /// <summary>
        /// 
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksCreateAnnotationsLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksCreateAnnotationsLocation value)
        {
            return value switch
            {
                TasksCreateAnnotationsLocation.CloudStorage => "cloud_storage",
                TasksCreateAnnotationsLocation.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksCreateAnnotationsLocation? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => TasksCreateAnnotationsLocation.CloudStorage,
                "local" => TasksCreateAnnotationsLocation.Local,
                _ => null,
            };
        }
    }
}