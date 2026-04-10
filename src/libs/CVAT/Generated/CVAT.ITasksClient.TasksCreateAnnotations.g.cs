#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Import annotations into a task<br/>
        /// The request POST /api/tasks/id/annotations initiates a background process to import annotations into a task.<br/>
        /// Please, use the GET /api/requests/&lt;rq_id&gt; endpoint for checking status of the process.<br/>
        /// The `rq_id` parameter can be found in the response on initiating request.
        /// </summary>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <param name="useDefaultLocation">
        /// Default Value: true
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> TasksCreateAnnotationsAsync(
            int id,

            global::CVAT.AnnotationFileRequest request,
            int? cloudStorageId = default,
            string? filename = default,
            string? format = default,
            global::CVAT.TasksCreateAnnotationsLocation? location = default,
            bool? useDefaultLocation = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import annotations into a task<br/>
        /// The request POST /api/tasks/id/annotations initiates a background process to import annotations into a task.<br/>
        /// Please, use the GET /api/requests/&lt;rq_id&gt; endpoint for checking status of the process.<br/>
        /// The `rq_id` parameter can be found in the response on initiating request.
        /// </summary>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <param name="useDefaultLocation">
        /// Default Value: true
        /// </param>
        /// <param name="annotationFile"></param>
        /// <param name="annotationFilename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> TasksCreateAnnotationsAsync(
            int id,
            byte[] annotationFile,
            string annotationFilename,
            int? cloudStorageId = default,
            string? filename = default,
            string? format = default,
            global::CVAT.TasksCreateAnnotationsLocation? location = default,
            bool? useDefaultLocation = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}