#nullable enable

namespace CVAT
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Create an asset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AssetRead> AssetsCreateAsync(

            global::CVAT.AssetWriteRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an asset
        /// </summary>
        /// <param name="guideId"></param>
        /// <param name="file">
        /// Included only in requests
        /// </param>
        /// <param name="filename">
        /// Included only in requests
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AssetRead> AssetsCreateAsync(
            int guideId,
            byte[] file,
            string filename,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}