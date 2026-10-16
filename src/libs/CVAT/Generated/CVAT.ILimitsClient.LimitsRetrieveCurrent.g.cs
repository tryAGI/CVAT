#nullable enable

namespace CVAT
{
    public partial interface ILimitsClient
    {
        /// <summary>
        /// Get limits for the current user or organization<br/>
        /// Returns stored limit metadata with effective limits. Expired records use Free defaults.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.CurrentLimit> LimitsRetrieveCurrentAsync(
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get limits for the current user or organization<br/>
        /// Returns stored limit metadata with effective limits. Expired records use Free defaults.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.CurrentLimit>> LimitsRetrieveCurrentAsResponseAsync(
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}