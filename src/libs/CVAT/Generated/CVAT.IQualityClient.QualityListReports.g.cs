#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// Method returns a paginated list of quality reports.<br/>
        /// Please note that children reports are included by default<br/>
        /// if the "task_id", "project_id" filters are used.<br/>
        /// If you want to restrict the list of results to a specific report type,<br/>
        /// use the "target" parameter.<br/>
        /// The "parent_id" filter includes all the nested reports recursively.<br/>
        /// For instance, if the "parent_id" is a project report,<br/>
        /// all the related task and job reports will be returned.<br/>
        /// Please note that a report can be reused in several parent reports,<br/>
        /// but the "parent_id" field in responses will include only the first parent report id.<br/>
        /// The "parent_id" filter still returns all the relevant nested reports,<br/>
        /// even though the response "parent_id" values may be different from the requested one.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="filter"></param>
        /// <param name="jobId"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentId"></param>
        /// <param name="projectId"></param>
        /// <param name="sort"></param>
        /// <param name="target"></param>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedQualityReportList> QualityListReportsAsync(
            string? xOrganization = default,
            string? filter = default,
            int? jobId = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            int? parentId = default,
            int? projectId = default,
            string? sort = default,
            global::CVAT.QualityListReportsTarget? target = default,
            int? taskId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Method returns a paginated list of quality reports.<br/>
        /// Please note that children reports are included by default<br/>
        /// if the "task_id", "project_id" filters are used.<br/>
        /// If you want to restrict the list of results to a specific report type,<br/>
        /// use the "target" parameter.<br/>
        /// The "parent_id" filter includes all the nested reports recursively.<br/>
        /// For instance, if the "parent_id" is a project report,<br/>
        /// all the related task and job reports will be returned.<br/>
        /// Please note that a report can be reused in several parent reports,<br/>
        /// but the "parent_id" field in responses will include only the first parent report id.<br/>
        /// The "parent_id" filter still returns all the relevant nested reports,<br/>
        /// even though the response "parent_id" values may be different from the requested one.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="filter"></param>
        /// <param name="jobId"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentId"></param>
        /// <param name="projectId"></param>
        /// <param name="sort"></param>
        /// <param name="target"></param>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.PaginatedQualityReportList>> QualityListReportsAsResponseAsync(
            string? xOrganization = default,
            string? filter = default,
            int? jobId = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            int? parentId = default,
            int? projectId = default,
            string? sort = default,
            global::CVAT.QualityListReportsTarget? target = default,
            int? taskId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}