#nullable enable

namespace CVAT
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// OpenApi3 schema for this API. Format can be selected via content negotiation.<br/>
        /// - YAML: application/vnd.oai.openapi<br/>
        /// - JSON: application/vnd.oai.openapi+json
        /// </summary>
        /// <param name="lang"></param>
        /// <param name="scheme"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SchemaRetrieveAsync(
            global::CVAT.SchemaRetrieveLang? lang = default,
            global::CVAT.SchemaRetrieveScheme? scheme = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}