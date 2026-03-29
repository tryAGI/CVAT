
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `interactive` - Interactive<br/>
    /// * `batch` - Batch
    /// </summary>
    public enum RequestCategoryEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Batch,
        /// <summary>
        /// 
        /// </summary>
        Interactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestCategoryEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestCategoryEnum value)
        {
            return value switch
            {
                RequestCategoryEnum.Batch => "batch",
                RequestCategoryEnum.Interactive => "interactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestCategoryEnum? ToEnum(string value)
        {
            return value switch
            {
                "batch" => RequestCategoryEnum.Batch,
                "interactive" => RequestCategoryEnum.Interactive,
                _ => null,
            };
        }
    }
}