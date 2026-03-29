
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `worker` - Worker<br/>
    /// * `supervisor` - Supervisor<br/>
    /// * `maintainer` - Maintainer<br/>
    /// * `owner` - Owner
    /// </summary>
    public enum RoleEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Maintainer,
        /// <summary>
        /// 
        /// </summary>
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Supervisor,
        /// <summary>
        /// 
        /// </summary>
        Worker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RoleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoleEnum value)
        {
            return value switch
            {
                RoleEnum.Maintainer => "maintainer",
                RoleEnum.Owner => "owner",
                RoleEnum.Supervisor => "supervisor",
                RoleEnum.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoleEnum? ToEnum(string value)
        {
            return value switch
            {
                "maintainer" => RoleEnum.Maintainer,
                "owner" => RoleEnum.Owner,
                "supervisor" => RoleEnum.Supervisor,
                "worker" => RoleEnum.Worker,
                _ => null,
            };
        }
    }
}