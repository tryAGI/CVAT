
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksListType
    {
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksListTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksListType value)
        {
            return value switch
            {
                WebhooksListType.Organization => "organization",
                WebhooksListType.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksListType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => WebhooksListType.Organization,
                "project" => WebhooksListType.Project,
                _ => null,
            };
        }
    }
}