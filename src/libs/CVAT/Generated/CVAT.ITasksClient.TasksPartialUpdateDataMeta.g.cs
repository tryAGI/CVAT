#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Update metainformation for media files in a task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.DataMetaRead> TasksPartialUpdateDataMetaAsync(
            int id,

            global::CVAT.PatchedDataMetaWriteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update metainformation for media files in a task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deletedFrames"></param>
        /// <param name="cloudStorageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.DataMetaRead> TasksPartialUpdateDataMetaAsync(
            int id,
            global::System.Collections.Generic.IList<int>? deletedFrames = default,
            int? cloudStorageId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}