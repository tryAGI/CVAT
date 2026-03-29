
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum EventsListAction
    {
        /// <summary>
        /// 
        /// </summary>
        Download,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventsListActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventsListAction value)
        {
            return value switch
            {
                EventsListAction.Download => "download",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventsListAction? ToEnum(string value)
        {
            return value switch
            {
                "download" => EventsListAction.Download,
                _ => null,
            };
        }
    }
}