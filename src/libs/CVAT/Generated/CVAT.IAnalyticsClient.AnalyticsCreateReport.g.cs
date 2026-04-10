#nullable enable

namespace CVAT
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Create an analytics report
        /// </summary>
        /// <param name="rqId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> AnalyticsCreateReportAsync(

            global::CVAT.CreateAnalyticsReportBodyRequest request,
            string? rqId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an analytics report
        /// </summary>
        /// <param name="rqId"></param>
        /// <param name="jobId"></param>
        /// <param name="taskId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> AnalyticsCreateReportAsync(
            string? rqId = default,
            int? jobId = default,
            int? taskId = default,
            int? projectId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}