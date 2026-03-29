
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksCreateBackupExportLocation
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
    public static class TasksCreateBackupExportLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksCreateBackupExportLocation value)
        {
            return value switch
            {
                TasksCreateBackupExportLocation.CloudStorage => "cloud_storage",
                TasksCreateBackupExportLocation.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksCreateBackupExportLocation? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => TasksCreateBackupExportLocation.CloudStorage,
                "local" => TasksCreateBackupExportLocation.Local,
                _ => null,
            };
        }
    }
}