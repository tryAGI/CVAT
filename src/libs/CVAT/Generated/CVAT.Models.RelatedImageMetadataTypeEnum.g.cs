
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `related_image` - related_image
    /// </summary>
    public enum RelatedImageMetadataTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        RelatedImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RelatedImageMetadataTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RelatedImageMetadataTypeEnum value)
        {
            return value switch
            {
                RelatedImageMetadataTypeEnum.RelatedImage => "related_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RelatedImageMetadataTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "related_image" => RelatedImageMetadataTypeEnum.RelatedImage,
                _ => null,
            };
        }
    }
}