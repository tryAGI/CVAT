#nullable enable

namespace CVAT
{
    public partial interface ICloudstoragesClient
    {
        /// <summary>
        /// Create a cloud storage
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.CloudStorageRead> CloudstoragesCreateAsync(

            global::CVAT.CloudStorageWriteRequest request,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a cloud storage
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.CloudStorageRead> CloudstoragesCreateAsync(
            global::CVAT.ProviderTypeEnum providerType,
            string resource,
            string displayName,
            global::CVAT.CredentialsTypeEnum credentialsType,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::CVAT.BasicUserRequest? owner = default,
            string? sessionToken = default,
            string? accountName = default,
            string? key = default,
            string? secretKey = default,
            string? connectionString = default,
            byte[]? keyFile = default,
            string? keyFilename = default,
            string? specificAttributes = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? manifests = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}