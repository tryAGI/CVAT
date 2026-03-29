#nullable enable

namespace CVAT
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Delete a job<br/>
        /// Related annotations will be deleted as well.<br/>
        /// Please note, that not every job can be removed. Currently,<br/>
        /// it is only available for Ground Truth jobs.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task JobsDestroyAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}