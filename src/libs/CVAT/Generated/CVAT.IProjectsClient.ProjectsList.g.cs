#nullable enable

namespace CVAT
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List projects
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="assignee"></param>
        /// <param name="filter"></param>
        /// <param name="name"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="owner"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedProjectReadList> ProjectsListAsync(
            string? xOrganization = default,
            string? assignee = default,
            string? filter = default,
            string? name = default,
            string? org = default,
            int? orgId = default,
            string? owner = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            string? sort = default,
            global::CVAT.ProjectsListStatus? status = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}