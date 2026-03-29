#nullable enable

namespace CVAT
{
    public partial interface ICloudstoragesClient
    {
        /// <summary>
        /// Get allowed actions for a cloud storage<br/>
        /// Method return allowed actions for cloud storage. It's required for reading/writing
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CloudstoragesRetrieveActionsAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}