#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// Create a job validation request<br/>
        /// The endpoint can be used this way:<br/>
        ///     request_data = {"job_id": 42}<br/>
        ///     response = post(body=request_data)<br/>
        ///     if response.status == 200:<br/>
        ///         return response.data["status"] # likely, "disabled"<br/>
        ///     rq_id = response.data["rq_id"]<br/>
        ///     while True:<br/>
        ///         response = get(f"/api/requests/{rq_id}")<br/>
        ///         background_request = json.loads(response.data)<br/>
        ///         if background_request["status"] == "finished":<br/>
        ///             return background_request<br/>
        ///         elif background_request["status"] == "failed":<br/>
        ///             raise Exception(background_request["message"])<br/>
        /// Only the last validation request to a job is considered valid. If a new request arrives<br/>
        /// before the previous one is completed, the previous one is considered canceled.<br/>
        /// The attempts counter will be increased regardless of the results being collected.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.JobValidation> QualityCreateValidationAsync(

            global::CVAT.JobValidationCreateRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a job validation request<br/>
        /// The endpoint can be used this way:<br/>
        ///     request_data = {"job_id": 42}<br/>
        ///     response = post(body=request_data)<br/>
        ///     if response.status == 200:<br/>
        ///         return response.data["status"] # likely, "disabled"<br/>
        ///     rq_id = response.data["rq_id"]<br/>
        ///     while True:<br/>
        ///         response = get(f"/api/requests/{rq_id}")<br/>
        ///         background_request = json.loads(response.data)<br/>
        ///         if background_request["status"] == "finished":<br/>
        ///             return background_request<br/>
        ///         elif background_request["status"] == "failed":<br/>
        ///             raise Exception(background_request["message"])<br/>
        /// Only the last validation request to a job is considered valid. If a new request arrives<br/>
        /// before the previous one is completed, the previous one is considered canceled.<br/>
        /// The attempts counter will be increased regardless of the results being collected.
        /// </summary>
        /// <param name="jobId">
        /// Included only in requests
        /// </param>
        /// <param name="timeout">
        /// Included only in requests
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.JobValidation> QualityCreateValidationAsync(
            int jobId,
            int? timeout,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}