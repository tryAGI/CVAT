
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `video` - VIDEO<br/>
    /// * `imageset` - IMAGESET<br/>
    /// * `list` - LIST
    /// </summary>
    public enum ChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        Imageset,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkType value)
        {
            return value switch
            {
                ChunkType.Imageset => "imageset",
                ChunkType.List => "list",
                ChunkType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkType? ToEnum(string value)
        {
            return value switch
            {
                "imageset" => ChunkType.Imageset,
                "list" => ChunkType.List,
                "video" => ChunkType.Video,
                _ => null,
            };
        }
    }
}