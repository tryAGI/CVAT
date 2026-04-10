#nullable enable

namespace CVAT
{
    public partial interface ICloudstoragesClient
    {
        /// <summary>
        /// Update a cloud storage
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.CloudStorageRead> CloudstoragesPartialUpdateAsync(
            int id,

            global::CVAT.PatchedCloudStorageWriteRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a cloud storage
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.CloudStorageRead> CloudstoragesPartialUpdateAsync(
            int id,
            global::CVAT.ProviderTypeEnum? providerType = default,
            string? resource = default,
            string? displayName = default,
            global::CVAT.BasicUserRequest? owner = default,
            global::CVAT.CredentialsTypeEnum? credentialsType = default,
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
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}