
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksCreateDatasetExportLocation
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
    public static class TasksCreateDatasetExportLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksCreateDatasetExportLocation value)
        {
            return value switch
            {
                TasksCreateDatasetExportLocation.CloudStorage => "cloud_storage",
                TasksCreateDatasetExportLocation.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksCreateDatasetExportLocation? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => TasksCreateDatasetExportLocation.CloudStorage,
                "local" => TasksCreateDatasetExportLocation.Local,
                _ => null,
            };
        }
    }
}