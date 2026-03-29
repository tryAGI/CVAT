#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Calls Django Auth SetPasswordForm save method.<br/>
        /// Accepts the following POST parameters: new_password1, new_password2<br/>
        /// Returns the success/fail message.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RestAuthDetail> AuthCreatePasswordChangeAsync(

            global::CVAT.PasswordChangeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calls Django Auth SetPasswordForm save method.<br/>
        /// Accepts the following POST parameters: new_password1, new_password2<br/>
        /// Returns the success/fail message.
        /// </summary>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword1"></param>
        /// <param name="newPassword2"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RestAuthDetail> AuthCreatePasswordChangeAsync(
            string oldPassword,
            string newPassword1,
            string newPassword2,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}