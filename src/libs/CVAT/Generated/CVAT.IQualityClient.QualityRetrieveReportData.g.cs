#nullable enable

namespace CVAT
{
    public partial interface IQualityClient
    {
        /// <summary>
        /// Get quality report contents
        /// </summary>
        /// <param name="format">
        /// Default Value: json
        /// </param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> QualityRetrieveReportDataAsync(
            int id,
            global::CVAT.QualityRetrieveReportDataFormat? format = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}