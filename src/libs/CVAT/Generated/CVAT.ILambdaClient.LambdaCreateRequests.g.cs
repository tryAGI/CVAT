#nullable enable

namespace CVAT
{
    public partial interface ILambdaClient
    {
        /// <summary>
        /// Method calls the function
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.FunctionCall> LambdaCreateRequestsAsync(

            global::CVAT.FunctionCallRequest request,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Method calls the function
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="function">
        /// The name of the function to execute
        /// </param>
        /// <param name="task">
        /// The id of the task to be annotated
        /// </param>
        /// <param name="job">
        /// The id of the job to be annotated
        /// </param>
        /// <param name="maxDistance"></param>
        /// <param name="threshold"></param>
        /// <param name="cleanup">
        /// Whether existing annotations should be removed<br/>
        /// Default Value: false
        /// </param>
        /// <param name="convMaskToPoly">
        /// Deprecated; use conv_mask_to_poly instead<br/>
        /// Included only in requests
        /// </param>
        /// <param name="convMaskToPoly2">
        /// Convert mask shapes to polygons
        /// </param>
        /// <param name="mapping">
        /// Label mapping from the model to the task labels
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.FunctionCall> LambdaCreateRequestsAsync(
            string function,
            int task,
            bool convMaskToPoly,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            int? job = default,
            int? maxDistance = default,
            double? threshold = default,
            bool? cleanup = default,
            bool? convMaskToPoly2 = default,
            global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntryRequest>? mapping = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}