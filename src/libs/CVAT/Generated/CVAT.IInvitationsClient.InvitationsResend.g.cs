#nullable enable

namespace CVAT
{
    public partial interface IInvitationsClient
    {
        /// <summary>
        /// Resend an invitation
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task InvitationsResendAsync(
            string key,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}