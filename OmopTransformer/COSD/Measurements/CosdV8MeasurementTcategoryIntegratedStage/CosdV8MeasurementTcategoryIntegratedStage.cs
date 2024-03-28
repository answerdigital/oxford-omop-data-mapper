﻿using OmopTransformer.Annotations;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Measurements.CosdV8MeasurementTcategoryIntegratedStage;

internal class CosdV8MeasurementTcategoryIntegratedStage : OmopMeasurement<CosdV8MeasurementTcategoryIntegratedStageRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.MeasurementDate))]
    public override DateTime? measurement_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.MeasurementDate))]
    public override DateTime? measurement_datetime { get; set; }

    [ConstantValue(32828, "EHR episode record")]
    public override int? measurement_type_concept_id { get; set; }

    [CopyValue(nameof(Source.TCategoryIntegratedStage))]
    public override string? measurement_source_value { get; set; }

    [Transform(typeof(TCategoryLookup), nameof(Source.TCategoryIntegratedStage))]
    public override int? measurement_concept_id { get; set; }

    [ConstantValue(2000500012, "TCategoryIntegratedStage")]
    public override int? measurement_source_concept_id { get; set; }
}