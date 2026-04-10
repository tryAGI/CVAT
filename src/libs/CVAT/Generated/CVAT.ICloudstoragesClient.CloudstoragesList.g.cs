#nullable enable

namespace CVAT
{
    public partial interface ICloudstoragesClient
    {
        /// <summary>
        /// List cloud storages
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="credentialsType"></param>
        /// <param name="filter"></param>
        /// <param name="name"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="owner"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="providerType"></param>
        /// <param name="resource"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedCloudStorageReadList> CloudstoragesListAsync(
            string? xOrganization = default,
            global::CVAT.CloudstoragesListCredentialsType? credentialsType = default,
            string? filter = default,
            string? name = default,
            string? org = default,
            int? orgId = default,
            string? owner = default,
            int? page = default,
            int? pageSize = default,
            global::CVAT.CloudstoragesListProviderType? providerType = default,
            string? resource = default,
            string? search = default,
            string? sort = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}