
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum EventsCreateExportLocation
    {
        /// <summary>
        /// 
        /// </summary>
        CloudStorage,
        /// <summary>
        /// 
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventsCreateExportLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventsCreateExportLocation value)
        {
            return value switch
            {
                EventsCreateExportLocation.CloudStorage => "cloud_storage",
                EventsCreateExportLocation.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventsCreateExportLocation? ToEnum(string value)
        {
            return value switch
            {
                "cloud_storage" => EventsCreateExportLocation.CloudStorage,
                "local" => EventsCreateExportLocation.Local,
                _ => null,
            };
        }
    }
}