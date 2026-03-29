#nullable enable

namespace CVAT
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Create a comment
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.CommentRead> CommentsCreateAsync(

            global::CVAT.CommentWriteRequest request,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a comment
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="issue"></param>
        /// <param name="message"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.CommentRead> CommentsCreateAsync(
            int issue,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            string? message = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}