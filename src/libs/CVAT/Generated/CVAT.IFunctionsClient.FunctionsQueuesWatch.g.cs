#nullable enable

namespace CVAT
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Watch a queue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> FunctionsQueuesWatchAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}