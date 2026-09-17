
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `organization` - ORGANIZATION<br/>
    /// * `project` - PROJECT<br/>
    /// * `server` - SERVER<br/>
    /// * `all` - ALL
    /// </summary>
    public enum AllWebhookType
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Project,
        /// <summary>
        ///
        /// </summary>
        Server,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AllWebhookTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AllWebhookType value)
        {
            return value switch
            {
                AllWebhookType.All => "all",
                AllWebhookType.Organization => "organization",
                AllWebhookType.Project => "project",
                AllWebhookType.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AllWebhookType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AllWebhookType.All,
                "organization" => AllWebhookType.Organization,
                "project" => AllWebhookType.Project,
                "server" => AllWebhookType.Server,
                _ => null,
            };
        }
    }
}