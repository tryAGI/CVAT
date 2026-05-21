#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Method returns an authentication token based on code parameter<br/>
        /// After successful authentication on the provider side, the provider returns the 'code' parameter used to receive an authentication token required for CVAT authentication.
        /// </summary>
        /// <param name="authParams"></param>
        /// <param name="id"></param>
        /// <param name="process"></param>
        /// <param name="scope"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Token> AuthCreateSocialLoginTokenAsync(
            string id,

            global::CVAT.SocialLoginSerializerExRequest request,
            string? authParams = default,
            string? process = default,
            string? scope = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Method returns an authentication token based on code parameter<br/>
        /// After successful authentication on the provider side, the provider returns the 'code' parameter used to receive an authentication token required for CVAT authentication.
        /// </summary>
        /// <param name="authParams"></param>
        /// <param name="id"></param>
        /// <param name="process"></param>
        /// <param name="scope"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.Token>> AuthCreateSocialLoginTokenAsResponseAsync(
            string id,

            global::CVAT.SocialLoginSerializerExRequest request,
            string? authParams = default,
            string? process = default,
            string? scope = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Method returns an authentication token based on code parameter<br/>
        /// After successful authentication on the provider side, the provider returns the 'code' parameter used to receive an authentication token required for CVAT authentication.
        /// </summary>
        /// <param name="authParams"></param>
        /// <param name="id"></param>
        /// <param name="process"></param>
        /// <param name="scope"></param>
        /// <param name="accessToken"></param>
        /// <param name="code"></param>
        /// <param name="idToken"></param>
        /// <param name="requestAuthParams"></param>
        /// <param name="requestProcess">
        /// Default Value: login
        /// </param>
        /// <param name="requestScope"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Token> AuthCreateSocialLoginTokenAsync(
            string id,
            string? authParams = default,
            string? process = default,
            string? scope = default,
            string? accessToken = default,
            string? code = default,
            string? idToken = default,
            string? requestAuthParams = default,
            string? requestProcess = default,
            string? requestScope = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}