
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `image_size` - IMAGE_SIZE<br/>
    /// * `group_bbox_size` - GROUP_BBOX_SIZE
    /// </summary>
    public enum QualityPointSizeBase
    {
        /// <summary>
        /// 
        /// </summary>
        GroupBboxSize,
        /// <summary>
        /// 
        /// </summary>
        ImageSize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityPointSizeBaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityPointSizeBase value)
        {
            return value switch
            {
                QualityPointSizeBase.GroupBboxSize => "group_bbox_size",
                QualityPointSizeBase.ImageSize => "image_size",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityPointSizeBase? ToEnum(string value)
        {
            return value switch
            {
                "group_bbox_size" => QualityPointSizeBase.GroupBboxSize,
                "image_size" => QualityPointSizeBase.ImageSize,
                _ => null,
            };
        }
    }
}