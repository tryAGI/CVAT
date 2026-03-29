#nullable enable

namespace CVAT
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Allows updating current validation configuration<br/>
        /// WARNING: this operation is not protected from race conditions.<br/>
        /// It's up to the user to ensure no parallel calls to this operation happen.<br/>
        /// It affects image access, including exports with images, backups, chunk downloading etc.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.JobValidationLayoutRead> JobsPartialUpdateValidationLayoutAsync(
            int id,

            global::CVAT.PatchedJobValidationLayoutWriteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Allows updating current validation configuration<br/>
        /// WARNING: this operation is not protected from race conditions.<br/>
        /// It's up to the user to ensure no parallel calls to this operation happen.<br/>
        /// It affects image access, including exports with images, backups, chunk downloading etc.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="frameSelectionMethod">
        /// The method to use for frame selection of new real frames for honeypots in the job<br/>
        /// * `random_uniform` - RANDOM_UNIFORM<br/>
        /// * `random_per_job` - RANDOM_PER_JOB<br/>
        /// * `manual` - MANUAL
        /// </param>
        /// <param name="honeypotRealFrames">
        /// The list of frame ids. Applicable only to the "manual" frame selection method
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.JobValidationLayoutRead> JobsPartialUpdateValidationLayoutAsync(
            int id,
            global::CVAT.FrameSelectionMethod? frameSelectionMethod = default,
            global::System.Collections.Generic.IList<int>? honeypotRealFrames = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}