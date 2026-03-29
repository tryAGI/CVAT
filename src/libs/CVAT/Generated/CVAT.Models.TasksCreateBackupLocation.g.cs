
#nullable enable

namespace CVAT
{
    /// <summary>
    /// Default Value: local
    /// </summary>
    public enum TasksCreateBackupLocation
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
    public static class TasksCreateBackupLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksCreateBackupLocation value)
        {
            return value switch
            {
                TasksCreateBackupLocation.CloudStorage => "cloud_storage",
                TasksCreateBackupLocation.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksCreateBackupLocation? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => TasksCreateBackupLocation.CloudStorage,
                "local" => TasksCreateBackupLocation.Local,
                _ => null,
            };
        }
    }
}