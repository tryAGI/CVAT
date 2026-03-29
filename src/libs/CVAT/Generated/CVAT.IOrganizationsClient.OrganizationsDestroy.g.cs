#nullable enable

namespace CVAT
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Delete an organization
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task OrganizationsDestroyAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}