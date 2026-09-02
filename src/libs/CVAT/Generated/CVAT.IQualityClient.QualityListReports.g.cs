#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// Method returns a paginated list of quality reports.<br/>
        /// The "target" parameter is required when the "task_id" or "project_id"<br/>
        /// filter is used.<br/>
        /// The "parent_id" filter requires the "target" parameter. Valid parent<br/>
        /// report target to requested target combinations are: task to job,<br/>
        /// project to task, and project to job.<br/>
        /// Please note that a report can be reused in several parent reports,<br/>
        /// but the "parent_id" field in responses will include only the first parent report id.<br/>
        /// Filtering project report children with target "job" still returns all the relevant<br/>
        /// nested job reports, even though their response "parent_id" values refer to task reports.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="filter"></param>
        /// <param name="includeLegacy">
        /// Default Value: false
        /// </param>
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
            bool? includeLegacy = default,
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
        /// The "target" parameter is required when the "task_id" or "project_id"<br/>
        /// filter is used.<br/>
        /// The "parent_id" filter requires the "target" parameter. Valid parent<br/>
        /// report target to requested target combinations are: task to job,<br/>
        /// project to task, and project to job.<br/>
        /// Please note that a report can be reused in several parent reports,<br/>
        /// but the "parent_id" field in responses will include only the first parent report id.<br/>
        /// Filtering project report children with target "job" still returns all the relevant<br/>
        /// nested job reports, even though their response "parent_id" values refer to task reports.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="filter"></param>
        /// <param name="includeLegacy">
        /// Default Value: false
        /// </param>
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
            bool? includeLegacy = default,
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