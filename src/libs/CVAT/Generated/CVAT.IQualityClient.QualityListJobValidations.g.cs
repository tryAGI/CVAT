#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// List job validations
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="assignee"></param>
        /// <param name="filter"></param>
        /// <param name="jobId"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectId"></param>
        /// <param name="reportId"></param>
        /// <param name="sort"></param>
        /// <param name="status"></param>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedJobValidationList> QualityListJobValidationsAsync(
            string? xOrganization = default,
            int? assignee = default,
            string? filter = default,
            int? jobId = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            int? projectId = default,
            int? reportId = default,
            string? sort = default,
            global::CVAT.QualityListJobValidationsStatus? status = default,
            int? taskId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}