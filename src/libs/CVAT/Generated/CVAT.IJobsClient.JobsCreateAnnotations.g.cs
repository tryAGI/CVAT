#nullable enable

namespace CVAT
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Import annotations into a job<br/>
        /// The request POST /api/jobs/id/annotations initiates a background process to import annotations into a job.<br/>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> JobsCreateAnnotationsAsync(
            int id,

            global::CVAT.AnnotationFileRequest request,
            int? cloudStorageId = default,
            string? filename = default,
            string? format = default,
            global::CVAT.JobsCreateAnnotationsLocation? location = default,
            bool? useDefaultLocation = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import annotations into a job<br/>
        /// The request POST /api/jobs/id/annotations initiates a background process to import annotations into a job.<br/>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> JobsCreateAnnotationsAsync(
            int id,
            byte[] annotationFile,
            string annotationFilename,
            int? cloudStorageId = default,
            string? filename = default,
            string? format = default,
            global::CVAT.JobsCreateAnnotationsLocation? location = default,
            bool? useDefaultLocation = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}