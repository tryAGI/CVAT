#nullable enable

namespace CVAT
{
    public partial interface ILambdaClient
    {
        /// <summary>
        /// Method returns the status of the request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.FunctionCall> LambdaRetrieveRequestsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}