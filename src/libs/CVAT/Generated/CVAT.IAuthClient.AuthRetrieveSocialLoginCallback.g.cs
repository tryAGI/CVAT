#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Checks the authentication response from specified provider, redirects to the CVAT client if successful.<br/>
        /// Accepts a request from provider with code and state query parameters. In case of successful authentication on the provider side, it will redirect to the CVAT client
        /// </summary>
        /// <param name="code"></param>
        /// <param name="id"></param>
        /// <param name="state"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task AuthRetrieveSocialLoginCallbackAsync(
            string id,
            string? code = default,
            string? state = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}