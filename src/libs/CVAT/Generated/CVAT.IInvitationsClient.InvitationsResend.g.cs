#nullable enable

namespace CVAT
{
    public partial interface IInvitationsClient
    {
        /// <summary>
        /// Resend an invitation
        /// </summary>
        /// <param name="key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task InvitationsResendAsync(
            string key,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}