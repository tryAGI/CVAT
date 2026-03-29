#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Get metainformation for media files in a task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.DataMetaRead> TasksRetrieveDataMetaAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}