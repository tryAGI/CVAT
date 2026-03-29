
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum CloudstoragesListCredentialsType
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
    public static class CloudstoragesListCredentialsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CloudstoragesListCredentialsType value)
        {
            return value switch
            {
                CloudstoragesListCredentialsType.AccountNameTokenPair => "ACCOUNT_NAME_TOKEN_PAIR",
                CloudstoragesListCredentialsType.AnonymousAccess => "ANONYMOUS_ACCESS",
                CloudstoragesListCredentialsType.ConnectionString => "CONNECTION_STRING",
                CloudstoragesListCredentialsType.KeyFilePath => "KEY_FILE_PATH",
                CloudstoragesListCredentialsType.KeySecretKeyPair => "KEY_SECRET_KEY_PAIR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CloudstoragesListCredentialsType? ToEnum(string value)
        {
            return value switch
            {
                "ACCOUNT_NAME_TOKEN_PAIR" => CloudstoragesListCredentialsType.AccountNameTokenPair,
                "ANONYMOUS_ACCESS" => CloudstoragesListCredentialsType.AnonymousAccess,
                "CONNECTION_STRING" => CloudstoragesListCredentialsType.ConnectionString,
                "KEY_FILE_PATH" => CloudstoragesListCredentialsType.KeyFilePath,
                "KEY_SECRET_KEY_PAIR" => CloudstoragesListCredentialsType.KeySecretKeyPair,
                _ => null,
            };
        }
    }
}