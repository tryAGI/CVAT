#nullable enable

namespace CVAT
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Delete a label<br/>
        /// To delete a sublabel, please use the PATCH method of the parent label.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task LabelsDestroyAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}