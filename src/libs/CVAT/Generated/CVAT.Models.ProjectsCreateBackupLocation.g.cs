
#nullable enable

namespace CVAT
{
    /// <summary>
    /// Default Value: local
    /// </summary>
    public enum ProjectsCreateBackupLocation
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
    public static class ProjectsCreateBackupLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsCreateBackupLocation value)
        {
            return value switch
            {
                ProjectsCreateBackupLocation.CloudStorage => "cloud_storage",
                ProjectsCreateBackupLocation.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsCreateBackupLocation? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => ProjectsCreateBackupLocation.CloudStorage,
                "local" => ProjectsCreateBackupLocation.Local,
                _ => null,
            };
        }
    }
}