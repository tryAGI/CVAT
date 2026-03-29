#nullable enable

namespace CVAT
{
    public partial interface ILambdaClient
    {
        /// <summary>
        /// Method returns the information about the function
        /// </summary>
        /// <param name="funcId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LambdaRetrieveFunctionsAsync(
            string funcId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}