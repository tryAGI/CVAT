#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Update task annotations
        /// </summary>
        /// <param name="action"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.LabeledData> TasksPartialUpdateAnnotationsAsync(
            global::CVAT.TasksPartialUpdateAnnotationsAction action,
            int id,

            global::CVAT.PatchedLabeledDataRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update task annotations
        /// </summary>
        /// <param name="action"></param>
        /// <param name="id"></param>
        /// <param name="version">
        /// Default Value: 0
        /// </param>
        /// <param name="tags">
        /// Default Value: []
        /// </param>
        /// <param name="shapes">
        /// Default Value: []
        /// </param>
        /// <param name="tracks">
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.LabeledData> TasksPartialUpdateAnnotationsAsync(
            global::CVAT.TasksPartialUpdateAnnotationsAction action,
            int id,
            int? version = default,
            global::System.Collections.Generic.IList<global::CVAT.LabeledImageRequest>? tags = default,
            global::System.Collections.Generic.IList<global::CVAT.LabeledShapeRequest>? shapes = default,
            global::System.Collections.Generic.IList<global::CVAT.LabeledTrackRequest>? tracks = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}