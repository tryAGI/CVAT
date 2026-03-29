#nullable enable

namespace CVAT
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Update an issue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.IssueRead> IssuesPartialUpdateAsync(
            int id,

            global::CVAT.PatchedIssueWriteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an issue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="position"></param>
        /// <param name="assignee"></param>
        /// <param name="resolved"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.IssueRead> IssuesPartialUpdateAsync(
            int id,
            global::System.Collections.Generic.IList<double>? position = default,
            int? assignee = default,
            bool? resolved = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}