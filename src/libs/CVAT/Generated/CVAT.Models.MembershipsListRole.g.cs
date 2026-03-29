
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum MembershipsListRole
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
    public static class MembershipsListRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MembershipsListRole value)
        {
            return value switch
            {
                MembershipsListRole.Maintainer => "maintainer",
                MembershipsListRole.Owner => "owner",
                MembershipsListRole.Supervisor => "supervisor",
                MembershipsListRole.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MembershipsListRole? ToEnum(string value)
        {
            return value switch
            {
                "maintainer" => MembershipsListRole.Maintainer,
                "owner" => MembershipsListRole.Owner,
                "supervisor" => MembershipsListRole.Supervisor,
                "worker" => MembershipsListRole.Worker,
                _ => null,
            };
        }
    }
}