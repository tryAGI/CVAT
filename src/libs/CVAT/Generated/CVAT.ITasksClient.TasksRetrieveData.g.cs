#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Get data of a task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="quality"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task TasksRetrieveDataAsync(
            int id,
            global::CVAT.TasksRetrieveDataType type,
            int? number = default,
            global::CVAT.TasksRetrieveDataQuality? quality = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}