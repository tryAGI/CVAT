#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Check the credentials and return the REST Token<br/>
        /// if the credentials are valid and authenticated.<br/>
        /// If email verification is enabled and the user has the unverified email,<br/>
        /// an email with a confirmation link will be sent.<br/>
        /// Calls Django Auth login method to register User ID<br/>
        /// in Django session framework.<br/>
        /// Accept the following POST parameters: username, email, password<br/>
        /// Return the REST Framework Token Object's key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Token> AuthCreateLoginAsync(

            global::CVAT.LoginSerializerExRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check the credentials and return the REST Token<br/>
        /// if the credentials are valid and authenticated.<br/>
        /// If email verification is enabled and the user has the unverified email,<br/>
        /// an email with a confirmation link will be sent.<br/>
        /// Calls Django Auth login method to register User ID<br/>
        /// in Django session framework.<br/>
        /// Accept the following POST parameters: username, email, password<br/>
        /// Return the REST Framework Token Object's key.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Token> AuthCreateLoginAsync(
            string password,
            string? username = default,
            string? email = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}