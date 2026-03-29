#nullable enable

namespace CVAT
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Log client events<br/>
        /// Sends logs to the Clickhouse if it is connected
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.ClientEvents> EventsCreateAsync(

            global::CVAT.ClientEventsRequest request,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Log client events<br/>
        /// Sends logs to the Clickhouse if it is connected
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="events">
        /// Default Value: []
        /// </param>
        /// <param name="previousEvent">
        /// Included only in requests
        /// </param>
        /// <param name="timestamp"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.ClientEvents> EventsCreateAsync(
            global::CVAT.EventRequest previousEvent,
            global::System.DateTime timestamp,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::System.Collections.Generic.IList<global::CVAT.EventRequest>? events = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}