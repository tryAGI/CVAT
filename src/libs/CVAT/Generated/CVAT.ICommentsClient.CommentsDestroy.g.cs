#nullable enable

namespace CVAT
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Delete a comment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task CommentsDestroyAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}