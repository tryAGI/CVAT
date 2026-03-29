#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get current token details<br/>
        /// Get details of the token used for the current request.<br/>
        /// This endpoint is only allowed if the request is performed using an access token.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AccessTokenRead> AuthRetrieveAccessTokensSelfAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}