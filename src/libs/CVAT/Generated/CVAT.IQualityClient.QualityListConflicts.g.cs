#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// List annotation conflicts in a quality report
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="filter"></param>
        /// <param name="frame"></param>
        /// <param name="jobId"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectId"></param>
        /// <param name="reportId"></param>
        /// <param name="severity"></param>
        /// <param name="sort"></param>
        /// <param name="taskId"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedAnnotationConflictList> QualityListConflictsAsync(
            string? xOrganization = default,
            string? filter = default,
            int? frame = default,
            int? jobId = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            int? projectId = default,
            int? reportId = default,
            global::CVAT.QualityListConflictsSeverity? severity = default,
            string? sort = default,
            int? taskId = default,
            global::CVAT.QualityListConflictsType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}