#nullable enable

namespace CVAT
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Initialize process to export resource as a dataset in a specific format<br/>
        /// The request `POST /api/&lt;projects|tasks|jobs&gt;/id/dataset/export` will initialize<br/>
        /// a background process to export a dataset. To check status of the process<br/>
        /// please, use `GET /api/requests/&lt;rq_id&gt;` where **rq_id** is request ID returned in the response for this endpoint.
        /// </summary>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <param name="saveImages">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> JobsCreateDatasetExportAsync(
            string format,
            int id,
            int? cloudStorageId = default,
            string? filename = default,
            global::CVAT.JobsCreateDatasetExportLocation? location = default,
            bool? saveImages = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}