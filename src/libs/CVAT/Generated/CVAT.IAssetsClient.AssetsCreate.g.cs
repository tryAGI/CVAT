#nullable enable

namespace CVAT
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Create an asset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AssetRead> AssetsCreateAsync(

            global::CVAT.AssetWriteRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AssetRead> AssetsCreateAsync(
            int guideId,
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}