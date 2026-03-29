
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsRetrieveAnnotationsLocation
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
    public static class JobsRetrieveAnnotationsLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsRetrieveAnnotationsLocation value)
        {
            return value switch
            {
                JobsRetrieveAnnotationsLocation.CloudStorage => "cloud_storage",
                JobsRetrieveAnnotationsLocation.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsRetrieveAnnotationsLocation? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => JobsRetrieveAnnotationsLocation.CloudStorage,
                "local" => JobsRetrieveAnnotationsLocation.Local,
                _ => null,
            };
        }
    }
}