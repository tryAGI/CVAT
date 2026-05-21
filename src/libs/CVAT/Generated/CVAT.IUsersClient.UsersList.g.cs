#nullable enable

namespace CVAT
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List users
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="filter"></param>
        /// <param name="firstName"></param>
        /// <param name="isActive"></param>
        /// <param name="lastName"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedMetaUserList> UsersListAsync(
            string? xOrganization = default,
            string? filter = default,
            string? firstName = default,
            bool? isActive = default,
            string? lastName = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            string? sort = default,
            string? username = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List users
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="filter"></param>
        /// <param name="firstName"></param>
        /// <param name="isActive"></param>
        /// <param name="lastName"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.PaginatedMetaUserList>> UsersListAsResponseAsync(
            string? xOrganization = default,
            string? filter = default,
            string? firstName = default,
            bool? isActive = default,
            string? lastName = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            string? sort = default,
            string? username = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}