#nullable enable

namespace CVAT
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Initiate a process to export events
        /// </summary>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="from"></param>
        /// <param name="jobId"></param>
        /// <param name="location"></param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="taskId"></param>
        /// <param name="to"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> EventsCreateExportAsync(
            int? cloudStorageId = default,
            string? filename = default,
            global::System.DateTime? from = default,
            int? jobId = default,
            global::CVAT.EventsCreateExportLocation? location = default,
            int? orgId = default,
            int? projectId = default,
            int? taskId = default,
            global::System.DateTime? to = default,
            int? userId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}