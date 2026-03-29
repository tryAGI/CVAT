#nullable enable

namespace CVAT
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Update a comment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.CommentRead> CommentsPartialUpdateAsync(
            int id,

            global::CVAT.PatchedCommentWriteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a comment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.CommentRead> CommentsPartialUpdateAsync(
            int id,
            string? message = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}