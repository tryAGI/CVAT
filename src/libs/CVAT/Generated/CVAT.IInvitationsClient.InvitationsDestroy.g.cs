#nullable enable

namespace CVAT
{
    public partial interface IInvitationsClient
    {
        /// <summary>
        /// Delete an invitation
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task InvitationsDestroyAsync(
            string key,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}