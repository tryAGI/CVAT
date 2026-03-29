
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `Queued` - Queued<br/>
    /// * `Started` - Started<br/>
    /// * `Finished` - Finished<br/>
    /// * `Failed` - Failed
    /// </summary>
    public enum RqStatusStateEnum
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
    public static class RqStatusStateEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RqStatusStateEnum value)
        {
            return value switch
            {
                RqStatusStateEnum.Failed => "Failed",
                RqStatusStateEnum.Finished => "Finished",
                RqStatusStateEnum.Queued => "Queued",
                RqStatusStateEnum.Started => "Started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RqStatusStateEnum? ToEnum(string value)
        {
            return value switch
            {
                "Failed" => RqStatusStateEnum.Failed,
                "Finished" => RqStatusStateEnum.Finished,
                "Queued" => RqStatusStateEnum.Queued,
                "Started" => RqStatusStateEnum.Started,
                _ => null,
            };
        }
    }
}