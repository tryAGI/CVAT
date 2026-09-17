
#nullable enable

namespace CVAT
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum WebhooksRetrieveEventsType
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
    public static class WebhooksRetrieveEventsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRetrieveEventsType value)
        {
            return value switch
            {
                WebhooksRetrieveEventsType.All => "all",
                WebhooksRetrieveEventsType.Organization => "organization",
                WebhooksRetrieveEventsType.Project => "project",
                WebhooksRetrieveEventsType.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRetrieveEventsType? ToEnum(string value)
        {
            return value switch
            {
                "all" => WebhooksRetrieveEventsType.All,
                "organization" => WebhooksRetrieveEventsType.Organization,
                "project" => WebhooksRetrieveEventsType.Project,
                "server" => WebhooksRetrieveEventsType.Server,
                _ => null,
            };
        }
    }
}