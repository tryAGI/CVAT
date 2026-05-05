#nullable enable

namespace CVAT
{
    public partial interface IServerClient
    {
        /// <summary>
        /// List files/directories in the mounted share
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::CVAT.FileInfo>> ServerListShareAsync(
            string? directory = default,
            string? search = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List files/directories in the mounted share
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::CVAT.FileInfo>>> ServerListShareAsResponseAsync(
            string? directory = default,
            string? search = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}