
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `file` - file
    /// </summary>
    public enum FileMetadataTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileMetadataTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileMetadataTypeEnum value)
        {
            return value switch
            {
                FileMetadataTypeEnum.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileMetadataTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "file" => FileMetadataTypeEnum.File,
                _ => null,
            };
        }
    }
}