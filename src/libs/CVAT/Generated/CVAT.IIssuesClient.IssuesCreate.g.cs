#nullable enable

namespace CVAT
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Create an issue
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.IssueRead> IssuesCreateAsync(

            global::CVAT.IssueWriteRequest request,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an issue
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="frame"></param>
        /// <param name="position"></param>
        /// <param name="job"></param>
        /// <param name="assignee"></param>
        /// <param name="message"></param>
        /// <param name="resolved"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.IssueRead> IssuesCreateAsync(
            int frame,
            global::System.Collections.Generic.IList<double> position,
            int job,
            string message,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            int? assignee = default,
            bool? resolved = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}