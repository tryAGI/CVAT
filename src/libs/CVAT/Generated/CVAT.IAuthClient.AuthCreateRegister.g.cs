#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RegisterSerializerWithSubscriptions> AuthCreateRegisterAsync(

            global::CVAT.RegisterSerializerWithSubscriptionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password1">
        /// Included only in requests
        /// </param>
        /// <param name="password2">
        /// Included only in requests
        /// </param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="confirmations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RegisterSerializerWithSubscriptions> AuthCreateRegisterAsync(
            string username,
            string email,
            string password1,
            string password2,
            string? firstName = default,
            string? lastName = default,
            global::System.Collections.Generic.IList<global::CVAT.UserAgreementRequest>? confirmations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}