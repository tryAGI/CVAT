#nullable enable

namespace CVAT
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Initiate process to backup resource<br/>
        /// The request `POST /api/&lt;projects|tasks&gt;/id/backup/export` will initialize<br/>
        /// a background process to backup a resource. To check status of the process<br/>
        /// please, use `GET /api/requests/&lt;rq_id&gt;` where **rq_id** is request ID returned in the response for this endpoint.
        /// </summary>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="id"></param>
        /// <param name="lightweight">
        /// Default Value: true
        /// </param>
        /// <param name="location"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> ProjectsCreateBackupExportAsync(
            int id,
            int? cloudStorageId = default,
            string? filename = default,
            bool? lightweight = default,
            global::CVAT.ProjectsCreateBackupExportLocation? location = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}