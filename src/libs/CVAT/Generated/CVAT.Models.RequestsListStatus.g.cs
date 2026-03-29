
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestsListStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Finished,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestsListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestsListStatus value)
        {
            return value switch
            {
                RequestsListStatus.Failed => "failed",
                RequestsListStatus.Finished => "finished",
                RequestsListStatus.Queued => "queued",
                RequestsListStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestsListStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => RequestsListStatus.Failed,
                "finished" => RequestsListStatus.Finished,
                "queued" => RequestsListStatus.Queued,
                "started" => RequestsListStatus.Started,
                _ => null,
            };
        }
    }
}