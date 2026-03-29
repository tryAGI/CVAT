#nullable enable

namespace CVAT
{
    public partial interface IInvitationsClient
    {
        /// <summary>
        /// Accept an invitation
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AcceptInvitationRead> InvitationsAcceptAsync(
            string key,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}