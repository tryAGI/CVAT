#nullable enable

namespace CVAT
{
    public partial interface IMembershipsClient
    {
        /// <summary>
        /// Delete a membership
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task MembershipsDestroyAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}