#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// Create a quality report<br/>
        /// Deprecation warning: Utilizing this endpoint to check the computation status is no longer possible.<br/>
        /// Consider using common requests API: GET /api/requests/&lt;rq_id&gt;
        /// </summary>
        /// <param name="rqId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.QualityReport> QualityCreateReportAsync(

            global::CVAT.QualityReportCreateRequest request,
            string? rqId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a quality report<br/>
        /// Deprecation warning: Utilizing this endpoint to check the computation status is no longer possible.<br/>
        /// Consider using common requests API: GET /api/requests/&lt;rq_id&gt;
        /// </summary>
        /// <param name="rqId"></param>
        /// <param name="taskId">
        /// Included only in requests
        /// </param>
        /// <param name="projectId">
        /// Included only in requests
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.QualityReport> QualityCreateReportAsync(
            int taskId,
            int projectId,
            string? rqId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}