
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `cache` - CACHE<br/>
    /// * `file_system` - FILE_SYSTEM
    /// </summary>
    public enum StorageMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Cache,
        /// <summary>
        /// 
        /// </summary>
        FileSystem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StorageMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StorageMethod value)
        {
            return value switch
            {
                StorageMethod.Cache => "cache",
                StorageMethod.FileSystem => "file_system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StorageMethod? ToEnum(string value)
        {
            return value switch
            {
                "cache" => StorageMethod.Cache,
                "file_system" => StorageMethod.FileSystem,
                _ => null,
            };
        }
    }
}