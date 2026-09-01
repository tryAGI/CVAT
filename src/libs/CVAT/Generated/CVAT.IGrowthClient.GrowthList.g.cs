#nullable enable

namespace CVAT
{
    public partial interface IGrowthClient
    {
        /// <summary>
        /// List growth data
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedUserGrowthDataList> GrowthListAsync(
            string? filter = default,
            int? page = default,
            int? pageSize = default,
            string? sort = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List growth data
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.PaginatedUserGrowthDataList>> GrowthListAsResponseAsync(
            string? filter = default,
            int? page = default,
            int? pageSize = default,
            string? sort = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}