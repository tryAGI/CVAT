
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public enum RelatedFileMetadataDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        File,
        /// <summary>
        ///
        /// </summary>
        RelatedImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RelatedFileMetadataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RelatedFileMetadataDiscriminatorType value)
        {
            return value switch
            {
                RelatedFileMetadataDiscriminatorType.File => "file",
                RelatedFileMetadataDiscriminatorType.RelatedImage => "related_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RelatedFileMetadataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => RelatedFileMetadataDiscriminatorType.File,
                "related_image" => RelatedFileMetadataDiscriminatorType.RelatedImage,
                _ => null,
            };
        }
    }
}