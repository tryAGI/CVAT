#nullable enable

namespace CVAT
{
    public partial interface ICloudstoragesClient
    {
        /// <summary>
        /// Get cloud storage content
        /// </summary>
        /// <param name="id"></param>
        /// <param name="manifestPath"></param>
        /// <param name="nextToken"></param>
        /// <param name="pageSize"></param>
        /// <param name="prefix"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.CloudStorageContent> CloudstoragesRetrieveContentV2Async(
            int id,
            string? manifestPath = default,
            string? nextToken = default,
            int? pageSize = default,
            string? prefix = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}