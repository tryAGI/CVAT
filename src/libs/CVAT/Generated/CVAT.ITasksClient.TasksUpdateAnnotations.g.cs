#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Replace task annotations
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task TasksUpdateAnnotationsAsync(
            int id,

            global::CVAT.LabeledDataRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace task annotations
        /// </summary>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task TasksUpdateAnnotationsAsync(
            int id,
            int? version = default,
            global::System.Collections.Generic.IList<global::CVAT.LabeledImageRequest>? tags = default,
            global::System.Collections.Generic.IList<global::CVAT.LabeledShapeRequest>? shapes = default,
            global::System.Collections.Generic.IList<global::CVAT.LabeledTrackRequest>? tracks = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}