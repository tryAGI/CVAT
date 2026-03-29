#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Allows getting current validation configuration
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.TaskValidationLayoutRead> TasksRetrieveValidationLayoutAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}