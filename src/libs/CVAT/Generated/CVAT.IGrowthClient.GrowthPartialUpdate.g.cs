#nullable enable

namespace CVAT
{
    public partial interface IGrowthClient
    {
        /// <summary>
        /// Update growth data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.UserGrowthData> GrowthPartialUpdateAsync(
            string id,

            global::CVAT.PatchedUserGrowthDataRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update growth data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.UserGrowthData>> GrowthPartialUpdateAsResponseAsync(
            string id,

            global::CVAT.PatchedUserGrowthDataRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update growth data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="githubPromptShown"></param>
        /// <param name="githubPromptSupportClicked"></param>
        /// <param name="promotionNotificationsAllowed"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.UserGrowthData> GrowthPartialUpdateAsync(
            string id,
            bool? githubPromptShown = default,
            bool? githubPromptSupportClicked = default,
            bool? promotionNotificationsAllowed = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}