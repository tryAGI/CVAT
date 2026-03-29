#nullable enable

namespace CVAT
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Create a function
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Function> FunctionsCreateAsync(

            global::CVAT.FunctionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a function
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="url"></param>
        /// <param name="apiKey">
        /// Included only in requests
        /// </param>
        /// <param name="name"></param>
        /// <param name="kind">
        /// * `detector` - Detector<br/>
        /// * `interactor` - Interactor<br/>
        /// * `reid` - Reid<br/>
        /// * `tracker` - Tracker
        /// </param>
        /// <param name="labelsV2"></param>
        /// <param name="supportedShapeTypes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Function> FunctionsCreateAsync(
            string provider,
            string apiKey,
            string? url = default,
            string? name = default,
            global::CVAT.KindEnum? kind = default,
            global::System.Collections.Generic.IList<global::CVAT.FunctionLabelRequest>? labelsV2 = default,
            global::System.Collections.Generic.IList<global::CVAT.ShapeType2>? supportedShapeTypes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}