#nullable enable

namespace CVAT
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// List jobs
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="assignee"></param>
        /// <param name="dimension"></param>
        /// <param name="filter"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentJobId"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="stage"></param>
        /// <param name="state"></param>
        /// <param name="taskId"></param>
        /// <param name="taskName"></param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedJobReadList> JobsListAsync(
            string? xOrganization = default,
            string? assignee = default,
            global::CVAT.JobsListDimension? dimension = default,
            string? filter = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            int? parentJobId = default,
            int? projectId = default,
            string? projectName = default,
            string? search = default,
            string? sort = default,
            global::CVAT.JobsListStage? stage = default,
            global::CVAT.JobsListState? state = default,
            int? taskId = default,
            string? taskName = default,
            global::CVAT.JobsListType? type = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}