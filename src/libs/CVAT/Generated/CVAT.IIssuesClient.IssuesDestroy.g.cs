#nullable enable

namespace CVAT
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Delete an issue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task IssuesDestroyAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}