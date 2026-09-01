#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// Update a quality settings instance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.QualitySettings> QualityPartialUpdateSettingsAsync(
            int id,

            global::CVAT.PatchedQualitySettingsRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a quality settings instance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.QualitySettings>> QualityPartialUpdateSettingsAsResponseAsync(
            int id,

            global::CVAT.PatchedQualitySettingsRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a quality settings instance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="jobFilter">
        /// A JSON-based logic expression used to filter jobs for quality validation.<br/>
        /// The filter supports various terms to specify conditions on job: ['assignee', 'id', 'stage', 'state', 'task_id', 'task_name', 'type']
        /// </param>
        /// <param name="inherit">
        /// Allow using project settings when computing task quality.<br/>
        /// Only applicable to task quality settings inside projects
        /// </param>
        /// <param name="maxValidationsPerJob">
        /// The maximum number of job validation attempts for the job assignee.<br/>
        /// The job can be automatically accepted if the job quality is above the required<br/>
        /// threshold, defined by the target threshold parameter.
        /// </param>
        /// <param name="requirements"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.QualitySettings> QualityPartialUpdateSettingsAsync(
            int id,
            string? jobFilter = default,
            bool? inherit = default,
            int? maxValidationsPerJob = default,
            global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItemRequest>? requirements = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}