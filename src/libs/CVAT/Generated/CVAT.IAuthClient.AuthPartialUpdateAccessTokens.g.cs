#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update a token
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AccessTokenRead> AuthPartialUpdateAccessTokensAsync(
            int id,

            global::CVAT.PatchedAccessTokenWriteRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a token
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// A free-form name for the token. Doesn't have to be unique
        /// </param>
        /// <param name="expiryDate">
        /// Once the token expires, clients cannot use it anymore.<br/>
        /// If not set, the token will not expire.
        /// </param>
        /// <param name="readOnly"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AccessTokenRead> AuthPartialUpdateAccessTokensAsync(
            int id,
            string? name = default,
            global::System.DateTime? expiryDate = default,
            bool? readOnly = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}