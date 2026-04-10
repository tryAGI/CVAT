#nullable enable

namespace CVAT
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Create a job
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.JobRead> JobsCreateAsync(

            global::CVAT.JobWriteRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a job
        /// </summary>
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
        /// <param name="type">
        /// * `annotation` - ANNOTATION<br/>
        /// * `ground_truth` - GROUND_TRUTH<br/>
        /// * `consensus_replica` - CONSENSUS_REPLICA
        /// </param>
        /// <param name="taskId"></param>
        /// <param name="frameSelectionMethod">
        /// * `random_uniform` - RANDOM_UNIFORM<br/>
        /// * `random_per_job` - RANDOM_PER_JOB<br/>
        /// * `manual` - MANUAL
        /// </param>
        /// <param name="frameCount">
        /// The number of frames included in the GT job.<br/>
        /// Applicable only to the "random_uniform" frame selection method
        /// </param>
        /// <param name="frameShare">
        /// The share of frames included in the GT job.<br/>
        /// Applicable only to the "random_uniform" frame selection method
        /// </param>
        /// <param name="framesPerJobCount">
        /// The number of frames included in the GT job from each annotation job.<br/>
        /// Applicable only to the "random_per_job" frame selection method
        /// </param>
        /// <param name="framesPerJobShare">
        /// The share of frames included in the GT job from each annotation job.<br/>
        /// Applicable only to the "random_per_job" frame selection method
        /// </param>
        /// <param name="randomSeed">
        /// The seed value for the random number generator.<br/>
        /// The same value will produce the same frame sets.<br/>
        /// Applicable only to random frame selection methods.<br/>
        /// By default, a random value is used.
        /// </param>
        /// <param name="frames">
        /// The list of frame ids. Applicable only to the "manual" frame selection method
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.JobRead> JobsCreateAsync(
            global::CVAT.JobType type,
            int taskId,
            int? assignee = default,
            global::CVAT.JobStage? stage = default,
            global::CVAT.OperationStatus? state = default,
            global::CVAT.FrameSelectionMethod? frameSelectionMethod = default,
            int? frameCount = default,
            double? frameShare = default,
            int? framesPerJobCount = default,
            double? framesPerJobShare = default,
            int? randomSeed = default,
            global::System.Collections.Generic.IList<int>? frames = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}