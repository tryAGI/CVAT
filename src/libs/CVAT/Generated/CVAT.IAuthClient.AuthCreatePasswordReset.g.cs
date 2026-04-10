#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Calls Django Auth PasswordResetForm save method.<br/>
        /// Accepts the following POST parameters: email<br/>
        /// Returns the success/fail message.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RestAuthDetail> AuthCreatePasswordResetAsync(

            global::CVAT.PasswordResetSerializerExRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calls Django Auth PasswordResetForm save method.<br/>
        /// Accepts the following POST parameters: email<br/>
        /// Returns the success/fail message.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RestAuthDetail> AuthCreatePasswordResetAsync(
            string email,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}