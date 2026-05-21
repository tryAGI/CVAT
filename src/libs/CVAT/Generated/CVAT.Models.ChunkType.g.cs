
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `video` - VIDEO<br/>
    /// * `imageset` - IMAGESET<br/>
    /// * `audio_mp3` - AUDIO_MP3
    /// </summary>
    public enum ChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioMp3,
        /// <summary>
        /// 
        /// </summary>
        Imageset,
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
                ChunkType.AudioMp3 => "audio_mp3",
                ChunkType.Imageset => "imageset",
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
                "audio_mp3" => ChunkType.AudioMp3,
                "imageset" => ChunkType.Imageset,
                "video" => ChunkType.Video,
                _ => null,
            };
        }
    }
}