#nullable enable

namespace CVAT
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Get data of a job
        /// </summary>
        /// <param name="id"></param>
        /// <param name="index"></param>
        /// <param name="number"></param>
        /// <param name="quality"></param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> JobsRetrieveDataAsync(
            int id,
            global::CVAT.JobsRetrieveDataType type,
            int? index = default,
            int? number = default,
            global::CVAT.JobsRetrieveDataQuality? quality = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get data of a job
        /// </summary>
        /// <param name="id"></param>
        /// <param name="index"></param>
        /// <param name="number"></param>
        /// <param name="quality"></param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> JobsRetrieveDataAsStreamAsync(
            int id,
            global::CVAT.JobsRetrieveDataType type,
            int? index = default,
            int? number = default,
            global::CVAT.JobsRetrieveDataQuality? quality = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get data of a job
        /// </summary>
        /// <param name="id"></param>
        /// <param name="index"></param>
        /// <param name="number"></param>
        /// <param name="quality"></param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<byte[]>> JobsRetrieveDataAsResponseAsync(
            int id,
            global::CVAT.JobsRetrieveDataType type,
            int? index = default,
            int? number = default,
            global::CVAT.JobsRetrieveDataQuality? quality = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}