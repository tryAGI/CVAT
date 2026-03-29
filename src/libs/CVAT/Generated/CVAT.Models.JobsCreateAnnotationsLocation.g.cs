
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsCreateAnnotationsLocation
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
    public static class JobsCreateAnnotationsLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsCreateAnnotationsLocation value)
        {
            return value switch
            {
                JobsCreateAnnotationsLocation.CloudStorage => "cloud_storage",
                JobsCreateAnnotationsLocation.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsCreateAnnotationsLocation? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => JobsCreateAnnotationsLocation.CloudStorage,
                "local" => JobsCreateAnnotationsLocation.Local,
                _ => null,
            };
        }
    }
}