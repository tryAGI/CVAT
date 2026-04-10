#nullable enable

namespace CVAT
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// List issues
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="assignee"></param>
        /// <param name="filter"></param>
        /// <param name="frameId"></param>
        /// <param name="jobId"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="owner"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="resolved"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedIssueReadList> IssuesListAsync(
            string? xOrganization = default,
            string? assignee = default,
            string? filter = default,
            int? frameId = default,
            int? jobId = default,
            string? org = default,
            int? orgId = default,
            string? owner = default,
            int? page = default,
            int? pageSize = default,
            bool? resolved = default,
            string? search = default,
            string? sort = default,
            int? taskId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}