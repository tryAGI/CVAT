#nullable enable

namespace CVAT
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Update a label<br/>
        /// To modify a sublabel, please use the PATCH method of the parent label.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Label> LabelsPartialUpdateAsync(
            int id,

            global::CVAT.PatchedLabelRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a label<br/>
        /// To modify a sublabel, please use the PATCH method of the parent label.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="name"></param>
        /// <param name="color">
        /// The hex value for the RGB color. Will be generated automatically, unless specified explicitly.
        /// </param>
        /// <param name="attributes">
        /// The list of attributes. If you want to remove an attribute, you need to recreate the label and specify the remaining attributes.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="deleted">
        /// Delete the label. Only applicable in the PATCH methods of a project or a task.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="type">
        /// Associated annotation type for this label<br/>
        /// * `any` - ANY<br/>
        /// * `cuboid` - CUBOID<br/>
        /// * `ellipse` - ELLIPSE<br/>
        /// * `mask` - MASK<br/>
        /// * `points` - POINTS<br/>
        /// * `polygon` - POLYGON<br/>
        /// * `polyline` - POLYLINE<br/>
        /// * `rectangle` - RECTANGLE<br/>
        /// * `skeleton` - SKELETON<br/>
        /// * `tag` - TAG
        /// </param>
        /// <param name="svg"></param>
        /// <param name="sublabels"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Label> LabelsPartialUpdateAsync(
            int id,
            bool deleted,
            int? requestId = default,
            string? name = default,
            string? color = default,
            global::System.Collections.Generic.IList<global::CVAT.AttributeRequest>? attributes = default,
            global::CVAT.LabelType? type = default,
            string? svg = default,
            global::System.Collections.Generic.IList<global::CVAT.SublabelRequest>? sublabels = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}