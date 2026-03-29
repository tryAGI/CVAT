#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Get task annotations
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.LabeledData> TasksRetrieveAnnotationsAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}