#nullable enable

namespace CVAT
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Import a dataset into a project<br/>
        /// The request POST /api/projects/id/dataset initiates a background process to import dataset into a project.<br/>
        /// Please, use the GET /api/requests/&lt;rq_id&gt; endpoint for checking status of the process.<br/>
        /// The `rq_id` parameter can be found in the response on initiating request.
        /// </summary>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> ProjectsCreateDatasetAsync(
            int id,

            global::CVAT.DatasetFileRequest request,
            int? cloudStorageId = default,
            string? filename = default,
            string? format = default,
            global::CVAT.ProjectsCreateDatasetLocation? location = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import a dataset into a project<br/>
        /// The request POST /api/projects/id/dataset initiates a background process to import dataset into a project.<br/>
        /// Please, use the GET /api/requests/&lt;rq_id&gt; endpoint for checking status of the process.<br/>
        /// The `rq_id` parameter can be found in the response on initiating request.
        /// </summary>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <param name="datasetFile"></param>
        /// <param name="datasetFilename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> ProjectsCreateDatasetAsync(
            int id,
            byte[] datasetFile,
            string datasetFilename,
            int? cloudStorageId = default,
            string? filename = default,
            string? format = default,
            global::CVAT.ProjectsCreateDatasetLocation? location = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}