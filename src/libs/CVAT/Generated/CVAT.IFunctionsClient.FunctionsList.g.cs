#nullable enable

namespace CVAT
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// List functions
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="filter"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedFunctionList> FunctionsListAsync(
            string? xOrganization = default,
            string? filter = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            string? sort = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}