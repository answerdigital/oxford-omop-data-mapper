﻿using OmopTransformer.Annotations;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Measurements.CosdV9MeasurementMcategoryIntegratedStage;

internal class CosdV9MeasurementMcategoryIntegratedStage : OmopMeasurement<CosdV9MeasurementMcategoryIntegratedStageRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.MeasurementDate))]
    public override DateTime? measurement_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.MeasurementDate))]
    public override DateTime? measurement_datetime { get; set; }

    [ConstantValue(32828, "EHR episode record")]
    public override int? measurement_type_concept_id { get; set; }

    [CopyValue(nameof(Source.MCategoryIntegratedStage))]
    public override string? measurement_source_value { get; set; }

    [Transform(typeof(MCategoryLookup), nameof(Source.MCategoryIntegratedStage))]
    public override int? measurement_concept_id { get; set; }
}