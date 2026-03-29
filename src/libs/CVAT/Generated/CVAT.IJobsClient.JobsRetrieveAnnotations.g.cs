#nullable enable

namespace CVAT
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Get job annotations<br/>
        /// Deprecation warning:<br/>
        /// Utilizing this endpoint to export job dataset in a specific format<br/>
        /// is no longer possible.<br/>
        /// Consider using new API:<br/>
        /// - `POST /api/jobs/&lt;job_id&gt;/dataset/export?save_images=True` to initiate export process<br/>
        /// - `GET /api/requests/&lt;rq_id&gt;` to check process status,<br/>
        ///     where `rq_id` is request id returned on initializing request<br/>
        /// - `GET result_url` to download a prepared file,<br/>
        ///     where `result_url` can be found in the response on checking status request
        /// </summary>
        /// <param name="action"></param>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.LabeledData> JobsRetrieveAnnotationsAsync(
            int id,
            string? action = default,
            int? cloudStorageId = default,
            string? filename = default,
            string? format = default,
            global::CVAT.JobsRetrieveAnnotationsLocation? location = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}