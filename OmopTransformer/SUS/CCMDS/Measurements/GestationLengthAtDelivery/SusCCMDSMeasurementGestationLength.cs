﻿using OmopTransformer.Annotations;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.CCMDS.Measurements.GestationLengthAtDelivery;

internal class SusCCMDSMeasurementGestationLength : OmopMeasurement<SusCCMDSMeasurementGestationLengthRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }
    
    [CopyValue(nameof(Source.GeneratedRecordIdentifier))]
    public override string? RecordConnectionIdentifier {get;set;}

    [Transform(typeof(DateConverter), nameof(Source.MeasurementDate))]
    public override DateTime? measurement_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.MeasurementDate), nameof(Source.MeasurementDateTime))]
    public override DateTime? measurement_datetime { get; set; }

    [ConstantValue(32828, "EHR episode record")]
    public override int? measurement_type_concept_id { get; set; }

    [Transform(typeof(DoubleParser), nameof(Source.ValueAsNumber))]
    public override double? value_as_number { get; set; }

    [ConstantValue(8511, "Week")]
    public override int? unit_concept_id { get; set; }

    [ConstantValue(4260747, "Length of gestation at birth")]
    public override int[]? measurement_concept_id { get; set; }

    public override bool IsValid => base.IsValid && value_as_number != null;
}