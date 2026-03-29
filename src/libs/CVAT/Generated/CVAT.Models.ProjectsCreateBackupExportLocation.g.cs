
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectsCreateBackupExportLocation
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
    public static class ProjectsCreateBackupExportLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsCreateBackupExportLocation value)
        {
            return value switch
            {
                ProjectsCreateBackupExportLocation.CloudStorage => "cloud_storage",
                ProjectsCreateBackupExportLocation.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsCreateBackupExportLocation? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => ProjectsCreateBackupExportLocation.CloudStorage,
                "local" => ProjectsCreateBackupExportLocation.Local,
                _ => null,
            };
        }
    }
}