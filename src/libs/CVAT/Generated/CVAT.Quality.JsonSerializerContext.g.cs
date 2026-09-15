
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.BasicUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AggregationEnum), TypeInfoPropertyName = "AggregationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportTarget), TypeInfoPropertyName = "QualityReportTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictType), TypeInfoPropertyName = "AnnotationConflictType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AnnotationId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictSeverity), TypeInfoPropertyName = "AnnotationConflictSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictAnnotationType), TypeInfoPropertyName = "AnnotationConflictAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ShapeType2?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfShapeType2NullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ShapeType2), TypeInfoPropertyName = "ShapeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.NullEnum), TypeInfoPropertyName = "NullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationTypeEnum), TypeInfoPropertyName = "AnnotationTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeComparison))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeComparisonDefaultRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeComparisonRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeComparisonRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfComparatorEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ComparatorEnum), TypeInfoPropertyName = "ComparatorEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeComparisonDefaultRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeComparisonRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AttributeComparisonRuleRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AttributeComparisonRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.BlankEnum), TypeInfoPropertyName = "BlankEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.RqId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityTargetMetric), TypeInfoPropertyName = "QualityTargetMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.JobValidationRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationStatusEnum), TypeInfoPropertyName = "JobValidationStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedAnnotationConflictList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.AnnotationConflict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedJobValidationList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.JobValidation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedQualityReportList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualityReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedQualityRequirementListItemList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRequirementListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PaginatedQualitySettingsList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualitySettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualitySettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedQualityRequirementRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfAnnotationTypeEnumBlankEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfQualityTargetMetricNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfQualityPointSizeBaseBlankEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityPointSizeBase), TypeInfoPropertyName = "QualityPointSizeBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.PatchedQualitySettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualityRequirementListItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRequirementListItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportConfusionMatrix))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportConfusionMatrixAxes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportTargetMetricSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportJobsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportRequirementCalculation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportRequirementCalculationStatusEnum), TypeInfoPropertyName = "QualityReportRequirementCalculationStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ReasonEnum?, global::CVAT.NullEnum?>), TypeInfoPropertyName = "OneOfReasonEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ReasonEnum), TypeInfoPropertyName = "ReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportRequirementSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportScoreComponents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportRequirementsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualityReportRequirementSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportTasksSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportTargetMetricSummaryMetricEnum), TypeInfoPropertyName = "QualityReportTargetMetricSummaryMetricEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportTargetMetricValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRequirementBulkCreateNodeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualityRequirementBulkCreateNodeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRequirementBulkCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRequirementRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualitySettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListConflictsSeverity), TypeInfoPropertyName = "QualityListConflictsSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListConflictsType), TypeInfoPropertyName = "QualityListConflictsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListJobValidationsStatus), TypeInfoPropertyName = "QualityListJobValidationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListReportsTarget), TypeInfoPropertyName = "QualityListReportsTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRetrieveReportRequirementConfusionFormat), TypeInfoPropertyName = "QualityRetrieveReportRequirementConfusionFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRetrieveReportDataFormat), TypeInfoPropertyName = "QualityRetrieveReportDataFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListSettingsParentType), TypeInfoPropertyName = "QualityListSettingsParentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListSettingsRequirementsAnnotationType), TypeInfoPropertyName = "QualityListSettingsRequirementsAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CVAT.QualityRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AggregationEnum?), TypeInfoPropertyName = "NullableAggregationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportTarget?), TypeInfoPropertyName = "NullableQualityReportTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictType?), TypeInfoPropertyName = "NullableAnnotationConflictType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictSeverity?), TypeInfoPropertyName = "NullableAnnotationConflictSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationConflictAnnotationType?), TypeInfoPropertyName = "NullableAnnotationConflictAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ShapeType2?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfShapeType2NullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ShapeType2?), TypeInfoPropertyName = "NullableShapeType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.NullEnum?), TypeInfoPropertyName = "NullableNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.AnnotationTypeEnum?), TypeInfoPropertyName = "NullableAnnotationTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfComparatorEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ComparatorEnum?), TypeInfoPropertyName = "NullableComparatorEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.BlankEnum?), TypeInfoPropertyName = "NullableBlankEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityTargetMetric?), TypeInfoPropertyName = "NullableQualityTargetMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.JobValidationStatusEnum?), TypeInfoPropertyName = "NullableJobValidationStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfAnnotationTypeEnumBlankEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfQualityTargetMetricNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfQualityPointSizeBaseBlankEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityPointSizeBase?), TypeInfoPropertyName = "NullableQualityPointSizeBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportRequirementCalculationStatusEnum?), TypeInfoPropertyName = "NullableQualityReportRequirementCalculationStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.OneOf<global::CVAT.ReasonEnum?, global::CVAT.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfReasonEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.ReasonEnum?), TypeInfoPropertyName = "NullableReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityReportTargetMetricSummaryMetricEnum?), TypeInfoPropertyName = "NullableQualityReportTargetMetricSummaryMetricEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListConflictsSeverity?), TypeInfoPropertyName = "NullableQualityListConflictsSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListConflictsType?), TypeInfoPropertyName = "NullableQualityListConflictsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListJobValidationsStatus?), TypeInfoPropertyName = "NullableQualityListJobValidationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListReportsTarget?), TypeInfoPropertyName = "NullableQualityListReportsTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRetrieveReportRequirementConfusionFormat?), TypeInfoPropertyName = "NullableQualityRetrieveReportRequirementConfusionFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityRetrieveReportDataFormat?), TypeInfoPropertyName = "NullableQualityRetrieveReportDataFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListSettingsParentType?), TypeInfoPropertyName = "NullableQualityListSettingsParentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CVAT.QualityListSettingsRequirementsAnnotationType?), TypeInfoPropertyName = "NullableQualityListSettingsRequirementsAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AnnotationId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeComparisonRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AttributeComparisonRuleRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.JobValidationRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.AnnotationConflict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.JobValidation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualityReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualityRequirementListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualitySettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualityRequirementListItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualityReportRequirementSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualityRequirementBulkCreateNodeRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CVAT.QualityRequirement>))]
    internal sealed partial class QualitySourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualitySourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static QualitySourceGenerationContext Default { get; } = new(DefaultOptions);

        private QualitySourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ShapeType2?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ComparatorEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ReasonEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.AnnotationTypeEnum?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityTargetMetric?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.QualityPointSizeBase?, global::CVAT.BlankEnum?, global::CVAT.NullEnum?>());
            options.Converters.Add(new global::CVAT.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::CVAT.AggregationEnum)

                    || typeToConvert == typeof(global::CVAT.AggregationEnum?)

                    || typeToConvert == typeof(global::CVAT.AnnotationConflictAnnotationType)

                    || typeToConvert == typeof(global::CVAT.AnnotationConflictAnnotationType?)

                    || typeToConvert == typeof(global::CVAT.AnnotationConflictSeverity)

                    || typeToConvert == typeof(global::CVAT.AnnotationConflictSeverity?)

                    || typeToConvert == typeof(global::CVAT.AnnotationConflictType)

                    || typeToConvert == typeof(global::CVAT.AnnotationConflictType?)

                    || typeToConvert == typeof(global::CVAT.AnnotationTypeEnum)

                    || typeToConvert == typeof(global::CVAT.AnnotationTypeEnum?)

                    || typeToConvert == typeof(global::CVAT.BlankEnum)

                    || typeToConvert == typeof(global::CVAT.BlankEnum?)

                    || typeToConvert == typeof(global::CVAT.ComparatorEnum)

                    || typeToConvert == typeof(global::CVAT.ComparatorEnum?)

                    || typeToConvert == typeof(global::CVAT.JobValidationStatusEnum)

                    || typeToConvert == typeof(global::CVAT.JobValidationStatusEnum?)

                    || typeToConvert == typeof(global::CVAT.NullEnum)

                    || typeToConvert == typeof(global::CVAT.NullEnum?)

                    || typeToConvert == typeof(global::CVAT.QualityPointSizeBase)

                    || typeToConvert == typeof(global::CVAT.QualityPointSizeBase?)

                    || typeToConvert == typeof(global::CVAT.QualityReportRequirementCalculationStatusEnum)

                    || typeToConvert == typeof(global::CVAT.QualityReportRequirementCalculationStatusEnum?)

                    || typeToConvert == typeof(global::CVAT.QualityReportTarget)

                    || typeToConvert == typeof(global::CVAT.QualityReportTarget?)

                    || typeToConvert == typeof(global::CVAT.QualityReportTargetMetricSummaryMetricEnum)

                    || typeToConvert == typeof(global::CVAT.QualityReportTargetMetricSummaryMetricEnum?)

                    || typeToConvert == typeof(global::CVAT.QualityTargetMetric)

                    || typeToConvert == typeof(global::CVAT.QualityTargetMetric?)

                    || typeToConvert == typeof(global::CVAT.ReasonEnum)

                    || typeToConvert == typeof(global::CVAT.ReasonEnum?)

                    || typeToConvert == typeof(global::CVAT.ShapeType2)

                    || typeToConvert == typeof(global::CVAT.ShapeType2?)

                    || typeToConvert == typeof(global::CVAT.QualityListConflictsSeverity)

                    || typeToConvert == typeof(global::CVAT.QualityListConflictsSeverity?)

                    || typeToConvert == typeof(global::CVAT.QualityListConflictsType)

                    || typeToConvert == typeof(global::CVAT.QualityListConflictsType?)

                    || typeToConvert == typeof(global::CVAT.QualityListJobValidationsStatus)

                    || typeToConvert == typeof(global::CVAT.QualityListJobValidationsStatus?)

                    || typeToConvert == typeof(global::CVAT.QualityListReportsTarget)

                    || typeToConvert == typeof(global::CVAT.QualityListReportsTarget?)

                    || typeToConvert == typeof(global::CVAT.QualityRetrieveReportRequirementConfusionFormat)

                    || typeToConvert == typeof(global::CVAT.QualityRetrieveReportRequirementConfusionFormat?)

                    || typeToConvert == typeof(global::CVAT.QualityRetrieveReportDataFormat)

                    || typeToConvert == typeof(global::CVAT.QualityRetrieveReportDataFormat?)

                    || typeToConvert == typeof(global::CVAT.QualityListSettingsParentType)

                    || typeToConvert == typeof(global::CVAT.QualityListSettingsParentType?)

                    || typeToConvert == typeof(global::CVAT.QualityListSettingsRequirementsAnnotationType)

                    || typeToConvert == typeof(global::CVAT.QualityListSettingsRequirementsAnnotationType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::CVAT.AggregationEnum))
                {
                    return new global::CVAT.JsonConverters.AggregationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AggregationEnum?))
                {
                    return new global::CVAT.JsonConverters.AggregationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationConflictAnnotationType))
                {
                    return new global::CVAT.JsonConverters.AnnotationConflictAnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationConflictAnnotationType?))
                {
                    return new global::CVAT.JsonConverters.AnnotationConflictAnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationConflictSeverity))
                {
                    return new global::CVAT.JsonConverters.AnnotationConflictSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationConflictSeverity?))
                {
                    return new global::CVAT.JsonConverters.AnnotationConflictSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationConflictType))
                {
                    return new global::CVAT.JsonConverters.AnnotationConflictTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationConflictType?))
                {
                    return new global::CVAT.JsonConverters.AnnotationConflictTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationTypeEnum))
                {
                    return new global::CVAT.JsonConverters.AnnotationTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.AnnotationTypeEnum?))
                {
                    return new global::CVAT.JsonConverters.AnnotationTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.BlankEnum))
                {
                    return new global::CVAT.JsonConverters.BlankEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.BlankEnum?))
                {
                    return new global::CVAT.JsonConverters.BlankEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ComparatorEnum))
                {
                    return new global::CVAT.JsonConverters.ComparatorEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ComparatorEnum?))
                {
                    return new global::CVAT.JsonConverters.ComparatorEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobValidationStatusEnum))
                {
                    return new global::CVAT.JsonConverters.JobValidationStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.JobValidationStatusEnum?))
                {
                    return new global::CVAT.JsonConverters.JobValidationStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.NullEnum))
                {
                    return new global::CVAT.JsonConverters.NullEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.NullEnum?))
                {
                    return new global::CVAT.JsonConverters.NullEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityPointSizeBase))
                {
                    return new global::CVAT.JsonConverters.QualityPointSizeBaseJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityPointSizeBase?))
                {
                    return new global::CVAT.JsonConverters.QualityPointSizeBaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityReportRequirementCalculationStatusEnum))
                {
                    return new global::CVAT.JsonConverters.QualityReportRequirementCalculationStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityReportRequirementCalculationStatusEnum?))
                {
                    return new global::CVAT.JsonConverters.QualityReportRequirementCalculationStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityReportTarget))
                {
                    return new global::CVAT.JsonConverters.QualityReportTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityReportTarget?))
                {
                    return new global::CVAT.JsonConverters.QualityReportTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityReportTargetMetricSummaryMetricEnum))
                {
                    return new global::CVAT.JsonConverters.QualityReportTargetMetricSummaryMetricEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityReportTargetMetricSummaryMetricEnum?))
                {
                    return new global::CVAT.JsonConverters.QualityReportTargetMetricSummaryMetricEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityTargetMetric))
                {
                    return new global::CVAT.JsonConverters.QualityTargetMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityTargetMetric?))
                {
                    return new global::CVAT.JsonConverters.QualityTargetMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ReasonEnum))
                {
                    return new global::CVAT.JsonConverters.ReasonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ReasonEnum?))
                {
                    return new global::CVAT.JsonConverters.ReasonEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ShapeType2))
                {
                    return new global::CVAT.JsonConverters.ShapeType2JsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.ShapeType2?))
                {
                    return new global::CVAT.JsonConverters.ShapeType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListConflictsSeverity))
                {
                    return new global::CVAT.JsonConverters.QualityListConflictsSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListConflictsSeverity?))
                {
                    return new global::CVAT.JsonConverters.QualityListConflictsSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListConflictsType))
                {
                    return new global::CVAT.JsonConverters.QualityListConflictsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListConflictsType?))
                {
                    return new global::CVAT.JsonConverters.QualityListConflictsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListJobValidationsStatus))
                {
                    return new global::CVAT.JsonConverters.QualityListJobValidationsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListJobValidationsStatus?))
                {
                    return new global::CVAT.JsonConverters.QualityListJobValidationsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListReportsTarget))
                {
                    return new global::CVAT.JsonConverters.QualityListReportsTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListReportsTarget?))
                {
                    return new global::CVAT.JsonConverters.QualityListReportsTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityRetrieveReportRequirementConfusionFormat))
                {
                    return new global::CVAT.JsonConverters.QualityRetrieveReportRequirementConfusionFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityRetrieveReportRequirementConfusionFormat?))
                {
                    return new global::CVAT.JsonConverters.QualityRetrieveReportRequirementConfusionFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityRetrieveReportDataFormat))
                {
                    return new global::CVAT.JsonConverters.QualityRetrieveReportDataFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityRetrieveReportDataFormat?))
                {
                    return new global::CVAT.JsonConverters.QualityRetrieveReportDataFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListSettingsParentType))
                {
                    return new global::CVAT.JsonConverters.QualityListSettingsParentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListSettingsParentType?))
                {
                    return new global::CVAT.JsonConverters.QualityListSettingsParentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListSettingsRequirementsAnnotationType))
                {
                    return new global::CVAT.JsonConverters.QualityListSettingsRequirementsAnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::CVAT.QualityListSettingsRequirementsAnnotationType?))
                {
                    return new global::CVAT.JsonConverters.QualityListSettingsRequirementsAnnotationTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new QualitySourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}