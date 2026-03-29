
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsCreateDatasetExportLocation
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
    public static class JobsCreateDatasetExportLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsCreateDatasetExportLocation value)
        {
            return value switch
            {
                JobsCreateDatasetExportLocation.CloudStorage => "cloud_storage",
                JobsCreateDatasetExportLocation.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsCreateDatasetExportLocation? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => JobsCreateDatasetExportLocation.CloudStorage,
                "local" => JobsCreateDatasetExportLocation.Local,
                _ => null,
            };
        }
    }
}