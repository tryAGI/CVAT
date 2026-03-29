
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectsCreateDatasetExportLocation
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
    public static class ProjectsCreateDatasetExportLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsCreateDatasetExportLocation value)
        {
            return value switch
            {
                ProjectsCreateDatasetExportLocation.CloudStorage => "cloud_storage",
                ProjectsCreateDatasetExportLocation.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsCreateDatasetExportLocation? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => ProjectsCreateDatasetExportLocation.CloudStorage,
                "local" => ProjectsCreateDatasetExportLocation.Local,
                _ => null,
            };
        }
    }
}