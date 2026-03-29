
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `queued` - Queued<br/>
    /// * `started` - Started<br/>
    /// * `failed` - Failed<br/>
    /// * `finished` - Finished
    /// </summary>
    public enum RequestStatus
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
    public static class RequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestStatus value)
        {
            return value switch
            {
                RequestStatus.Failed => "failed",
                RequestStatus.Finished => "finished",
                RequestStatus.Queued => "queued",
                RequestStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => RequestStatus.Failed,
                "finished" => RequestStatus.Finished,
                "queued" => RequestStatus.Queued,
                "started" => RequestStatus.Started,
                _ => null,
            };
        }
    }
}