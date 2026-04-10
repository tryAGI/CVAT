#nullable enable

namespace CVAT
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Get an analytics report<br/>
        /// Receive analytics report
        /// </summary>
        /// <param name="endDate"></param>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="startDate"></param>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AnalyticsReport> AnalyticsGetReportsAsync(
            global::System.DateTime? endDate = default,
            int? jobId = default,
            int? projectId = default,
            global::System.DateTime? startDate = default,
            int? taskId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}