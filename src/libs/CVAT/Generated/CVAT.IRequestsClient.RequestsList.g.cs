#nullable enable

namespace CVAT
{
    public partial interface IRequestsClient
    {
        /// <summary>
        /// List requests
        /// </summary>
        /// <param name="action"></param>
        /// <param name="filter"></param>
        /// <param name="format"></param>
        /// <param name="jobId"></param>
        /// <param name="org"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectId"></param>
        /// <param name="sort"></param>
        /// <param name="status"></param>
        /// <param name="subresource"></param>
        /// <param name="target"></param>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedRequestList> RequestsListAsync(
            string? action = default,
            string? filter = default,
            string? format = default,
            int? jobId = default,
            string? org = default,
            int? page = default,
            int? pageSize = default,
            int? projectId = default,
            string? sort = default,
            global::CVAT.RequestsListStatus? status = default,
            string? subresource = default,
            string? target = default,
            int? taskId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}