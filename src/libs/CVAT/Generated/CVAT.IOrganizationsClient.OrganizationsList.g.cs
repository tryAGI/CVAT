#nullable enable

namespace CVAT
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List organizations
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="slug"></param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedOrganizationReadList> OrganizationsListAsync(
            string? filter = default,
            string? name = default,
            string? owner = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            string? slug = default,
            string? sort = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organizations
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="slug"></param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.PaginatedOrganizationReadList>> OrganizationsListAsResponseAsync(
            string? filter = default,
            string? name = default,
            string? owner = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            string? slug = default,
            string? sort = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}