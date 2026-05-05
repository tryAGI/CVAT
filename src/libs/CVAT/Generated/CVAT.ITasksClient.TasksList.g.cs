#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// List tasks
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="assignee"></param>
        /// <param name="dimension"></param>
        /// <param name="filter"></param>
        /// <param name="mode"></param>
        /// <param name="name"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="owner"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="status"></param>
        /// <param name="subset"></param>
        /// <param name="trackerLink"></param>
        /// <param name="validationMode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedTaskReadList> TasksListAsync(
            string? xOrganization = default,
            string? assignee = default,
            global::CVAT.TasksListDimension? dimension = default,
            string? filter = default,
            global::CVAT.TasksListMode? mode = default,
            string? name = default,
            string? org = default,
            int? orgId = default,
            string? owner = default,
            int? page = default,
            int? pageSize = default,
            int? projectId = default,
            string? projectName = default,
            string? search = default,
            string? sort = default,
            global::CVAT.TasksListStatus? status = default,
            string? subset = default,
            string? trackerLink = default,
            global::CVAT.TasksListValidationMode? validationMode = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List tasks
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="assignee"></param>
        /// <param name="dimension"></param>
        /// <param name="filter"></param>
        /// <param name="mode"></param>
        /// <param name="name"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="owner"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="status"></param>
        /// <param name="subset"></param>
        /// <param name="trackerLink"></param>
        /// <param name="validationMode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.PaginatedTaskReadList>> TasksListAsResponseAsync(
            string? xOrganization = default,
            string? assignee = default,
            global::CVAT.TasksListDimension? dimension = default,
            string? filter = default,
            global::CVAT.TasksListMode? mode = default,
            string? name = default,
            string? org = default,
            int? orgId = default,
            string? owner = default,
            int? page = default,
            int? pageSize = default,
            int? projectId = default,
            string? projectName = default,
            string? search = default,
            string? sort = default,
            global::CVAT.TasksListStatus? status = default,
            string? subset = default,
            string? trackerLink = default,
            global::CVAT.TasksListValidationMode? validationMode = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}