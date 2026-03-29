
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `organization` - ORGANIZATION<br/>
    /// * `project` - PROJECT
    /// </summary>
    public enum WebhookType
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
    public static class WebhookTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookType value)
        {
            return value switch
            {
                WebhookType.Organization => "organization",
                WebhookType.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => WebhookType.Organization,
                "project" => WebhookType.Project,
                _ => null,
            };
        }
    }
}