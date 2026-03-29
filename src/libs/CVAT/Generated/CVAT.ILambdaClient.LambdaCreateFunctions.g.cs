#nullable enable

namespace CVAT
{
    public partial interface ILambdaClient
    {
        /// <summary>
        /// Allows to execute a function for immediate computation.<br/>
        /// Intended for short-lived executions, useful for interactive calls.<br/>
        /// When executed for interactive annotation, the job id must be specified<br/>
        /// in the 'job' input field. The task id is not required in this case,<br/>
        /// but if it is specified, it must match the job task id.
        /// </summary>
        /// <param name="funcId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task LambdaCreateFunctionsAsync(
            string funcId,

            global::CVAT.OnlineFunctionCallRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Allows to execute a function for immediate computation.<br/>
        /// Intended for short-lived executions, useful for interactive calls.<br/>
        /// When executed for interactive annotation, the job id must be specified<br/>
        /// in the 'job' input field. The task id is not required in this case,<br/>
        /// but if it is specified, it must match the job task id.
        /// </summary>
        /// <param name="funcId"></param>
        /// <param name="job"></param>
        /// <param name="task"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task LambdaCreateFunctionsAsync(
            string funcId,
            int? job = default,
            int? task = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}