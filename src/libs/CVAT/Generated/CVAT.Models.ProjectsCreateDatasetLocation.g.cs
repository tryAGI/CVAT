
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectsCreateDatasetLocation
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
    public static class ProjectsCreateDatasetLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsCreateDatasetLocation value)
        {
            return value switch
            {
                ProjectsCreateDatasetLocation.CloudStorage => "cloud_storage",
                ProjectsCreateDatasetLocation.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsCreateDatasetLocation? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => ProjectsCreateDatasetLocation.CloudStorage,
                "local" => ProjectsCreateDatasetLocation.Local,
                _ => null,
            };
        }
    }
}