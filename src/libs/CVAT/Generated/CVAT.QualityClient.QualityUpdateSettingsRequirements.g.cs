
#nullable enable

namespace CVAT
{
    public partial class QualityClient
    {


        private static readonly global::CVAT.EndPointSecurityRequirement s_QualityUpdateSettingsRequirementsSecurityRequirement0 =
            new global::CVAT.EndPointSecurityRequirement
            {
                Authorizations = new global::CVAT.EndPointAuthorizationRequirement[]
                {                    new global::CVAT.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::CVAT.EndPointSecurityRequirement[] s_QualityUpdateSettingsRequirementsSecurityRequirements =
            new global::CVAT.EndPointSecurityRequirement[]
            {                s_QualityUpdateSettingsRequirementsSecurityRequirement0,
            };
        partial void PrepareQualityUpdateSettingsRequirementsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id,
            global::CVAT.QualityRequirementRequest request);
        partial void PrepareQualityUpdateSettingsRequirementsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id,
            global::CVAT.QualityRequirementRequest request);
        partial void ProcessQualityUpdateSettingsRequirementsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQualityUpdateSettingsRequirementsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Replace a quality requirement
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.QualityRequirement> QualityUpdateSettingsRequirementsAsync(
            int id,

            global::CVAT.QualityRequirementRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await QualityUpdateSettingsRequirementsAsResponseAsync(
                id: id,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Replace a quality requirement
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.QualityRequirement>> QualityUpdateSettingsRequirementsAsResponseAsync(
            int id,

            global::CVAT.QualityRequirementRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareQualityUpdateSettingsRequirementsArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);


            var __authorizations = global::CVAT.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_QualityUpdateSettingsRequirementsSecurityRequirements,
                operationName: "QualityUpdateSettingsRequirementsAsync");

            using var __timeoutCancellationTokenSource = global::CVAT.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::CVAT.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::CVAT.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::CVAT.PathBuilder(
                                path: $"/api/quality/settings/requirements/{id}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::CVAT.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Put,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::CVAT.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareQualityUpdateSettingsRequirementsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    id: id!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::CVAT.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::CVAT.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QualityUpdateSettingsRequirements",
                                methodName: "QualityUpdateSettingsRequirementsAsync",
                                pathTemplate: "$\"/api/quality/settings/requirements/{id}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::CVAT.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::CVAT.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::CVAT.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QualityUpdateSettingsRequirements",
                                methodName: "QualityUpdateSettingsRequirementsAsync",
                                pathTemplate: "$\"/api/quality/settings/requirements/{id}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::CVAT.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::CVAT.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::CVAT.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::CVAT.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::CVAT.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QualityUpdateSettingsRequirements",
                                methodName: "QualityUpdateSettingsRequirementsAsync",
                                pathTemplate: "$\"/api/quality/settings/requirements/{id}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::CVAT.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessQualityUpdateSettingsRequirementsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::CVAT.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::CVAT.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QualityUpdateSettingsRequirements",
                                methodName: "QualityUpdateSettingsRequirementsAsync",
                                pathTemplate: "$\"/api/quality/settings/requirements/{id}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::CVAT.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::CVAT.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QualityUpdateSettingsRequirements",
                                methodName: "QualityUpdateSettingsRequirementsAsync",
                                pathTemplate: "$\"/api/quality/settings/requirements/{id}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessQualityUpdateSettingsRequirementsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::CVAT.QualityRequirement.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::CVAT.AutoSDKHttpResponse<global::CVAT.QualityRequirement>(
                                        statusCode: __response.StatusCode,
                                        headers: global::CVAT.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::CVAT.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::CVAT.QualityRequirement.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::CVAT.AutoSDKHttpResponse<global::CVAT.QualityRequirement>(
                                        statusCode: __response.StatusCode,
                                        headers: global::CVAT.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::CVAT.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Replace a quality requirement
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settingsId"></param>
        /// <param name="name"></param>
        /// <param name="sortOrder"></param>
        /// <param name="filter"></param>
        /// <param name="enabled"></param>
        /// <param name="annotationType"></param>
        /// <param name="metric">
        /// The primary metric used for quality estimation<br/>
        /// * `accuracy` - ACCURACY<br/>
        /// * `precision` - PRECISION<br/>
        /// * `recall` - RECALL
        /// </param>
        /// <param name="requiredScore">
        /// Defines the minimal quality requirements in terms of the selected target metric.
        /// </param>
        /// <param name="parentRequirement">
        /// The parent requirement. Child requirements inherit comparison settings from it.
        /// </param>
        /// <param name="iouThreshold">
        /// Used for distinction between matched / unmatched shapes
        /// </param>
        /// <param name="pointSize">
        /// Like IoU threshold, but for points.<br/>
        /// The percent of the bbox side, used as the radius of the circle around the GT point,<br/>
        /// where the checked point is expected to be. For boxes with different width and<br/>
        /// height, the "side" is computed as a geometric mean of the width and height.<br/>
        /// Read more: https://cocodataset.org/#keypoints-eval
        /// </param>
        /// <param name="pointSizeBase">
        /// When comparing point annotations (including both separate points and point groups),<br/>
        /// the point size parameter defines matching area for each GT point based to the<br/>
        /// object size. The point size base parameter allows to configure how to determine<br/>
        /// the object size.<br/>
        /// If image_size, the image size is used. Useful if each point<br/>
        /// annotation represents a separate object or boxes grouped with points do not<br/>
        /// represent object boundaries.<br/>
        /// If group_bbox_size, the object size is based on<br/>
        /// the point group bbox size. Useful if each point group represents an object<br/>
        /// or there is a bbox grouped with points, representing the object size.<br/>
        /// * `image_size` - IMAGE_SIZE<br/>
        /// * `group_bbox_size` - GROUP_BBOX_SIZE
        /// </param>
        /// <param name="lineThickness">
        /// Thickness of polylines, relatively to the (image area) ^ 0.5.<br/>
        /// The distance to the boundary around the GT line,<br/>
        /// inside of which the checked line points should be
        /// </param>
        /// <param name="matchOrientation">
        /// Enables or disables polyline orientation comparison
        /// </param>
        /// <param name="lineOrientationThreshold">
        /// The minimal gain in the GT IoU between the given and reversed line directions<br/>
        /// to consider the line inverted.<br/>
        /// Only used when the 'match_orientation' parameter is true
        /// </param>
        /// <param name="matchGroups">
        /// Enables or disables annotation group checks. Only annotations of the same shape type can form matching groups.
        /// </param>
        /// <param name="groupMatchThreshold">
        /// Minimal IoU for groups to be considered matching.<br/>
        /// Only used when the 'match_groups' parameter is true
        /// </param>
        /// <param name="checkCoveredAnnotations">
        /// Check for partially-covered annotations, useful in segmentation tasks
        /// </param>
        /// <param name="objectVisibilityThreshold">
        /// Minimal visible area percent of the spatial annotations (polygons, masks)<br/>
        /// for reporting covered annotations.<br/>
        /// Only used when the 'object_visibility_threshold' parameter is true
        /// </param>
        /// <param name="panopticComparison">
        /// Use only the visible part of the masks and polygons in comparisons
        /// </param>
        /// <param name="attributeComparison">
        /// Incremental attribute comparison settings. The default rule applies to attributes without an override; rules override behavior for individual AttributeSpec ids.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.QualityRequirement> QualityUpdateSettingsRequirementsAsync(
            int id,
            int? settingsId = default,
            string? name = default,
            int? sortOrder = default,
            string? filter = default,
            bool? enabled = default,
            global::CVAT.OneOf<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? annotationType = default,
            global::CVAT.OneOf<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>? metric = default,
            double? requiredScore = default,
            int? parentRequirement = default,
            double? iouThreshold = default,
            double? pointSize = default,
            global::CVAT.OneOf<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>? pointSizeBase = default,
            double? lineThickness = default,
            bool? matchOrientation = default,
            double? lineOrientationThreshold = default,
            bool? matchGroups = default,
            double? groupMatchThreshold = default,
            bool? checkCoveredAnnotations = default,
            double? objectVisibilityThreshold = default,
            bool? panopticComparison = default,
            global::CVAT.AttributeComparisonRequest? attributeComparison = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::CVAT.QualityRequirementRequest
            {
                SettingsId = settingsId,
                Name = name,
                SortOrder = sortOrder,
                Filter = filter,
                Enabled = enabled,
                AnnotationType = annotationType,
                Metric = metric,
                RequiredScore = requiredScore,
                ParentRequirement = parentRequirement,
                IouThreshold = iouThreshold,
                PointSize = pointSize,
                PointSizeBase = pointSizeBase,
                LineThickness = lineThickness,
                MatchOrientation = matchOrientation,
                LineOrientationThreshold = lineOrientationThreshold,
                MatchGroups = matchGroups,
                GroupMatchThreshold = groupMatchThreshold,
                CheckCoveredAnnotations = checkCoveredAnnotations,
                ObjectVisibilityThreshold = objectVisibilityThreshold,
                PanopticComparison = panopticComparison,
                AttributeComparison = attributeComparison,
            };

            return await QualityUpdateSettingsRequirementsAsync(
                id: id,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}