#nullable enable

namespace CVAT
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Submit a batch annotation request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AnnotationRequest> FunctionsCreateRequestsAsync(

            global::CVAT.FunctionIdAndArParamsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a batch annotation request
        /// </summary>
        /// <param name="type">
        /// * `annotate_task` - annotate_task<br/>
        /// * `annotate_frame` - annotate_frame<br/>
        /// * `init_tracking` - init_tracking<br/>
        /// * `track` - track
        /// </param>
        /// <param name="task"></param>
        /// <param name="frame"></param>
        /// <param name="threshold"></param>
        /// <param name="cleanup"></param>
        /// <param name="convMaskToPoly"></param>
        /// <param name="mapping"></param>
        /// <param name="shapes"></param>
        /// <param name="states"></param>
        /// <param name="function"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AnnotationRequest> FunctionsCreateRequestsAsync(
            int task,
            int function,
            global::CVAT.TypeCcbEnum? type = default,
            int? frame = default,
            double? threshold = default,
            bool? cleanup = default,
            bool? convMaskToPoly = default,
            global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntryRequest>? mapping = default,
            global::System.Collections.Generic.IList<global::CVAT.ShapeRequest>? shapes = default,
            global::System.Collections.Generic.IList<string>? states = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}