﻿using OmopTransformer.Annotations;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Measurements.CosdV9MeasurementGradeOfDifferentiation;

internal class CosdV9MeasurementGradeOfDifferentiation : OmopMeasurement<CosdV9MeasurementGradeOfDifferentiationRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DateOfPrimaryDiagnosisClinicallyAgreed))]
    public override DateTime? measurement_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DateOfPrimaryDiagnosisClinicallyAgreed))]
    public override DateTime? measurement_datetime { get; set; }

    [ConstantValue(32828, "EHR episode record")]
    public override int? measurement_type_concept_id { get; set; }

    [CopyValue(nameof(Source.GradeOfDifferentiationAtDiagnosis))]
    public override string? measurement_source_value { get; set; }

    [Transform(typeof(GradeDifferentiationLookup), nameof(Source.GradeOfDifferentiationAtDiagnosis))]
    public override int[]? measurement_concept_id { get; set; }
}