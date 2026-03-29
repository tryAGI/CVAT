#nullable enable

namespace CVAT
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        /// Method provides user agreements that the user must accept to register
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.UserAgreement> UserAgreementsRetrieveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}