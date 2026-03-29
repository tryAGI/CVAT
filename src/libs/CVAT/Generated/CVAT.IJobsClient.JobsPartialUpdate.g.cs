#nullable enable

namespace CVAT
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Update a job
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.JobRead> JobsPartialUpdateAsync(
            int id,

            global::CVAT.PatchedJobWriteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a job
        /// </summary>
        /// <param name="id"></param>
        /// <param name="assignee"></param>
        /// <param name="stage">
        /// * `annotation` - ANNOTATION<br/>
        /// * `validation` - VALIDATION<br/>
        /// * `acceptance` - ACCEPTANCE
        /// </param>
        /// <param name="state">
        /// * `new` - NEW<br/>
        /// * `in progress` - IN_PROGRESS<br/>
        /// * `completed` - COMPLETED<br/>
        /// * `rejected` - REJECTED
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.JobRead> JobsPartialUpdateAsync(
            int id,
            int? assignee = default,
            global::CVAT.JobStage? stage = default,
            global::CVAT.OperationStatus? state = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}