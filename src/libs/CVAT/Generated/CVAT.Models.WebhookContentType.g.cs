
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `application/json` - JSON
    /// </summary>
    public enum WebhookContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookContentType value)
        {
            return value switch
            {
                WebhookContentType.ApplicationJson => "application/json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => WebhookContentType.ApplicationJson,
                _ => null,
            };
        }
    }
}