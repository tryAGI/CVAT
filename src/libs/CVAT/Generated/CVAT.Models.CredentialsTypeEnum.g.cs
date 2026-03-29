
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `KEY_SECRET_KEY_PAIR` - KEY_SECRET_KEY_PAIR<br/>
    /// * `ACCOUNT_NAME_TOKEN_PAIR` - ACCOUNT_NAME_TOKEN_PAIR<br/>
    /// * `KEY_FILE_PATH` - KEY_FILE_PATH<br/>
    /// * `ANONYMOUS_ACCESS` - ANONYMOUS_ACCESS<br/>
    /// * `CONNECTION_STRING` - CONNECTION_STRING
    /// </summary>
    public enum CredentialsTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        AccountNameTokenPair,
        /// <summary>
        /// 
        /// </summary>
        AnonymousAccess,
        /// <summary>
        /// 
        /// </summary>
        ConnectionString,
        /// <summary>
        /// 
        /// </summary>
        KeyFilePath,
        /// <summary>
        /// 
        /// </summary>
        KeySecretKeyPair,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CredentialsTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CredentialsTypeEnum value)
        {
            return value switch
            {
                CredentialsTypeEnum.AccountNameTokenPair => "ACCOUNT_NAME_TOKEN_PAIR",
                CredentialsTypeEnum.AnonymousAccess => "ANONYMOUS_ACCESS",
                CredentialsTypeEnum.ConnectionString => "CONNECTION_STRING",
                CredentialsTypeEnum.KeyFilePath => "KEY_FILE_PATH",
                CredentialsTypeEnum.KeySecretKeyPair => "KEY_SECRET_KEY_PAIR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CredentialsTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "ACCOUNT_NAME_TOKEN_PAIR" => CredentialsTypeEnum.AccountNameTokenPair,
                "ANONYMOUS_ACCESS" => CredentialsTypeEnum.AnonymousAccess,
                "CONNECTION_STRING" => CredentialsTypeEnum.ConnectionString,
                "KEY_FILE_PATH" => CredentialsTypeEnum.KeyFilePath,
                "KEY_SECRET_KEY_PAIR" => CredentialsTypeEnum.KeySecretKeyPair,
                _ => null,
            };
        }
    }
}