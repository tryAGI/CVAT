#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// List quality requirements
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="annotationType"></param>
        /// <param name="enabled"></param>
        /// <param name="filter"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectId"></param>
        /// <param name="settingsId"></param>
        /// <param name="sort"></param>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedQualityRequirementListItemList> QualityListSettingsRequirementsAsync(
            string? xOrganization = default,
            global::CVAT.QualityListSettingsRequirementsAnnotationType? annotationType = default,
            bool? enabled = default,
            string? filter = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            int? projectId = default,
            int? settingsId = default,
            string? sort = default,
            int? taskId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List quality requirements
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="annotationType"></param>
        /// <param name="enabled"></param>
        /// <param name="filter"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectId"></param>
        /// <param name="settingsId"></param>
        /// <param name="sort"></param>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.PaginatedQualityRequirementListItemList>> QualityListSettingsRequirementsAsResponseAsync(
            string? xOrganization = default,
            global::CVAT.QualityListSettingsRequirementsAnnotationType? annotationType = default,
            bool? enabled = default,
            string? filter = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            int? projectId = default,
            int? settingsId = default,
            string? sort = default,
            int? taskId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}