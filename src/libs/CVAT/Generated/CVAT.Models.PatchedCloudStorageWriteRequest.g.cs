
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedCloudStorageWriteRequest
    {
        /// <summary>
        /// * `AWS_S3_BUCKET` - Amazon S3<br/>
        /// * `AZURE_CONTAINER` - Azure Blob Storage<br/>
        /// * `GOOGLE_CLOUD_STORAGE` - Google Cloud Storage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.ProviderTypeEnumJsonConverter))]
        public global::CVAT.ProviderTypeEnum? ProviderType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::CVAT.BasicUserRequest? Owner { get; set; }

        /// <summary>
        /// * `KEY_SECRET_KEY_PAIR` - KEY_SECRET_KEY_PAIR<br/>
        /// * `ACCOUNT_NAME_TOKEN_PAIR` - ACCOUNT_NAME_TOKEN_PAIR<br/>
        /// * `KEY_FILE_PATH` - KEY_FILE_PATH<br/>
        /// * `ANONYMOUS_ACCESS` - ANONYMOUS_ACCESS<br/>
        /// * `CONNECTION_STRING` - CONNECTION_STRING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.CredentialsTypeEnumJsonConverter))]
        public global::CVAT.CredentialsTypeEnum? CredentialsType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_token")]
        public string? SessionToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_name")]
        public string? AccountName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_key")]
        public string? SecretKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_string")]
        public string? ConnectionString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_file")]
        public byte[]? KeyFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_filename")]
        public string? KeyFilename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specific_attributes")]
        public string? SpecificAttributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifests")]
        public global::System.Collections.Generic.IList<string>? Manifests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedCloudStorageWriteRequest" /> class.
        /// </summary>
        /// <param name="providerType">
        /// * `AWS_S3_BUCKET` - Amazon S3<br/>
        /// * `AZURE_CONTAINER` - Azure Blob Storage<br/>
        /// * `GOOGLE_CLOUD_STORAGE` - Google Cloud Storage
        /// </param>
        /// <param name="resource"></param>
        /// <param name="displayName"></param>
        /// <param name="owner"></param>
        /// <param name="credentialsType">
        /// * `KEY_SECRET_KEY_PAIR` - KEY_SECRET_KEY_PAIR<br/>
        /// * `ACCOUNT_NAME_TOKEN_PAIR` - ACCOUNT_NAME_TOKEN_PAIR<br/>
        /// * `KEY_FILE_PATH` - KEY_FILE_PATH<br/>
        /// * `ANONYMOUS_ACCESS` - ANONYMOUS_ACCESS<br/>
        /// * `CONNECTION_STRING` - CONNECTION_STRING
        /// </param>
        /// <param name="sessionToken"></param>
        /// <param name="accountName"></param>
        /// <param name="key"></param>
        /// <param name="secretKey"></param>
        /// <param name="connectionString"></param>
        /// <param name="keyFile"></param>
        /// <param name="keyFilename"></param>
        /// <param name="specificAttributes"></param>
        /// <param name="description"></param>
        /// <param name="manifests">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedCloudStorageWriteRequest(
            global::CVAT.ProviderTypeEnum? providerType,
            string? resource,
            string? displayName,
            global::CVAT.BasicUserRequest? owner,
            global::CVAT.CredentialsTypeEnum? credentialsType,
            string? sessionToken,
            string? accountName,
            string? key,
            string? secretKey,
            string? connectionString,
            byte[]? keyFile,
            string? keyFilename,
            string? specificAttributes,
            string? description,
            global::System.Collections.Generic.IList<string>? manifests)
        {
            this.ProviderType = providerType;
            this.Resource = resource;
            this.DisplayName = displayName;
            this.Owner = owner;
            this.CredentialsType = credentialsType;
            this.SessionToken = sessionToken;
            this.AccountName = accountName;
            this.Key = key;
            this.SecretKey = secretKey;
            this.ConnectionString = connectionString;
            this.KeyFile = keyFile;
            this.KeyFilename = keyFilename;
            this.SpecificAttributes = specificAttributes;
            this.Description = description;
            this.Manifests = manifests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedCloudStorageWriteRequest" /> class.
        /// </summary>
        public PatchedCloudStorageWriteRequest()
        {
        }
    }
}