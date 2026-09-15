
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `registration` - Registration<br/>
    /// * `social` - Social<br/>
    /// * `sso` - SSO<br/>
    /// * `ldap` - LDAP<br/>
    /// * `invitation` - Invitation
    /// </summary>
    public enum CreatedViaEnum
    {
        /// <summary>
        ///
        /// </summary>
        Invitation,
        /// <summary>
        ///
        /// </summary>
        Ldap,
        /// <summary>
        ///
        /// </summary>
        Registration,
        /// <summary>
        ///
        /// </summary>
        Social,
        /// <summary>
        ///
        /// </summary>
        Sso,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatedViaEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatedViaEnum value)
        {
            return value switch
            {
                CreatedViaEnum.Invitation => "invitation",
                CreatedViaEnum.Ldap => "ldap",
                CreatedViaEnum.Registration => "registration",
                CreatedViaEnum.Social => "social",
                CreatedViaEnum.Sso => "sso",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatedViaEnum? ToEnum(string value)
        {
            return value switch
            {
                "invitation" => CreatedViaEnum.Invitation,
                "ldap" => CreatedViaEnum.Ldap,
                "registration" => CreatedViaEnum.Registration,
                "social" => CreatedViaEnum.Social,
                "sso" => CreatedViaEnum.Sso,
                _ => null,
            };
        }
    }
}