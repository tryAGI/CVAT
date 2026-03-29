#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Delete a task<br/>
        /// All attached jobs, annotations and data will be deleted as well.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task TasksDestroyAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}