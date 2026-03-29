#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Password reset e-mail link is confirmed, therefore<br/>
        /// this resets the user's password.<br/>
        /// Accepts the following POST parameters: token, uid,<br/>
        ///     new_password1, new_password2<br/>
        /// Returns the success/fail message.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RestAuthDetail> AuthCreatePasswordResetConfirmAsync(

            global::CVAT.PasswordResetConfirmRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Password reset e-mail link is confirmed, therefore<br/>
        /// this resets the user's password.<br/>
        /// Accepts the following POST parameters: token, uid,<br/>
        ///     new_password1, new_password2<br/>
        /// Returns the success/fail message.
        /// </summary>
        /// <param name="newPassword1"></param>
        /// <param name="newPassword2"></param>
        /// <param name="uid"></param>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RestAuthDetail> AuthCreatePasswordResetConfirmAsync(
            string newPassword1,
            string newPassword2,
            string uid,
            string token,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}