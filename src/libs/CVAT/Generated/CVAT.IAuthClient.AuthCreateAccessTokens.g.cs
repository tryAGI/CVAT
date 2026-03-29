#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Create a token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AccessTokenRead> AuthCreateAccessTokensAsync(

            global::CVAT.AccessTokenWriteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a token
        /// </summary>
        /// <param name="name">
        /// A free-form name for the token. Doesn't have to be unique
        /// </param>
        /// <param name="expiryDate">
        /// Once the token expires, clients cannot use it anymore.<br/>
        /// If not set, the token will not expire.
        /// </param>
        /// <param name="readOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AccessTokenRead> AuthCreateAccessTokensAsync(
            string name,
            global::System.DateTime? expiryDate = default,
            bool? readOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}