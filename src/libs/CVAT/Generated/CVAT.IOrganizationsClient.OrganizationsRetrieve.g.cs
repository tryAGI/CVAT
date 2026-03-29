#nullable enable

namespace CVAT
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get organization details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.OrganizationRead> OrganizationsRetrieveAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}