#nullable enable

namespace CVAT
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// List labels
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="color"></param>
        /// <param name="filter"></param>
        /// <param name="jobId"></param>
        /// <param name="name"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parent"></param>
        /// <param name="parentId"></param>
        /// <param name="projectId"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="taskId"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedLabelList> LabelsListAsync(
            string? xOrganization = default,
            string? color = default,
            string? filter = default,
            int? jobId = default,
            string? name = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            string? parent = default,
            int? parentId = default,
            int? projectId = default,
            string? search = default,
            string? sort = default,
            int? taskId = default,
            global::CVAT.LabelsListType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}