#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// List quality settings instances<br/>
        /// Please note that child task settings are included by default<br/>
        /// if the "project_id" filter is used.<br/>
        /// If you want to restrict results only to a specific parent type, use the "parent_type" parameter.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="filter"></param>
        /// <param name="inherit"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentType"></param>
        /// <param name="projectId"></param>
        /// <param name="sort"></param>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedQualitySettingsList> QualityListSettingsAsync(
            string? xOrganization = default,
            string? filter = default,
            bool? inherit = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            global::CVAT.QualityListSettingsParentType? parentType = default,
            int? projectId = default,
            string? sort = default,
            int? taskId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}