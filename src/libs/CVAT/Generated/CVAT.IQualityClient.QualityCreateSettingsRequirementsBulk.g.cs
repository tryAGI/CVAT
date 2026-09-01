#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// Create a hierarchy of quality requirements
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::CVAT.QualityRequirement>> QualityCreateSettingsRequirementsBulkAsync(

            global::CVAT.QualityRequirementBulkCreateRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a hierarchy of quality requirements
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::CVAT.QualityRequirement>>> QualityCreateSettingsRequirementsBulkAsResponseAsync(

            global::CVAT.QualityRequirementBulkCreateRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a hierarchy of quality requirements
        /// </summary>
        /// <param name="settingsId"></param>
        /// <param name="requirements"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::CVAT.QualityRequirement>> QualityCreateSettingsRequirementsBulkAsync(
            int settingsId,
            global::System.Collections.Generic.IList<global::CVAT.QualityRequirementBulkCreateNodeRequest> requirements,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}