
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `cloud_storage` - CLOUD_STORAGE<br/>
    /// * `local` - LOCAL<br/>
    /// * `share` - SHARE
    /// </summary>
    public enum StorageType
    {
        /// <summary>
        /// 
        /// </summary>
        CloudStorage,
        /// <summary>
        /// 
        /// </summary>
        Local,
        /// <summary>
        /// 
        /// </summary>
        Share,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StorageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StorageType value)
        {
            return value switch
            {
                StorageType.CloudStorage => "cloud_storage",
                StorageType.Local => "local",
                StorageType.Share => "share",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StorageType? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => StorageType.CloudStorage,
                "local" => StorageType.Local,
                "share" => StorageType.Share,
                _ => null,
            };
        }
    }
}