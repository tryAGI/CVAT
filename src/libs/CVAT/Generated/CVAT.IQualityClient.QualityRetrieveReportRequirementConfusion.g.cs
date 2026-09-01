#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// Get a quality report requirement confusion matrix
        /// </summary>
        /// <param name="format">
        /// Default Value: json
        /// </param>
        /// <param name="id"></param>
        /// <param name="requirement"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.QualityReportConfusionMatrix> QualityRetrieveReportRequirementConfusionAsync(
            int id,
            int requirement,
            global::CVAT.QualityRetrieveReportRequirementConfusionFormat? format = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a quality report requirement confusion matrix
        /// </summary>
        /// <param name="format">
        /// Default Value: json
        /// </param>
        /// <param name="id"></param>
        /// <param name="requirement"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.QualityReportConfusionMatrix>> QualityRetrieveReportRequirementConfusionAsResponseAsync(
            int id,
            int requirement,
            global::CVAT.QualityRetrieveReportRequirementConfusionFormat? format = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}