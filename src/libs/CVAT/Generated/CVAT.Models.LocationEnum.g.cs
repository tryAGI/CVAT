
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `cloud_storage` - CLOUD_STORAGE<br/>
    /// * `local` - LOCAL
    /// </summary>
    public enum LocationEnum
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
    public static class LocationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocationEnum value)
        {
            return value switch
            {
                LocationEnum.CloudStorage => "cloud_storage",
                LocationEnum.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocationEnum? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => LocationEnum.CloudStorage,
                "local" => LocationEnum.Local,
                _ => null,
            };
        }
    }
}