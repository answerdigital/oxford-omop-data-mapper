using OmopTransformer.Annotations;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.OP.Measurements.SusOPMeasurement;

internal class SusOPMeasurement : OmopMeasurement<SusOPMeasurementRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? measurement_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? measurement_datetime { get; set; }

    [ConstantValue(32828, "EHR episode record")]
    public override int? measurement_type_concept_id { get; set; }

    [Transform(typeof(Icd10Selector), nameof(Source.DiagnosisICD))]
    public override int? measurement_source_concept_id { get; set; }

    [Transform(typeof(RelationshipSelector), nameof(Source.DiagnosisICD))]
    public override string? value_source_value { get; set; }

    [Transform(typeof(StandardMeasurementConceptSelector), useOmopTypeAsSource: true, nameof(measurement_source_concept_id))]
    public override int? measurement_concept_id { get; set; }

    public override bool IsValid => base.IsValid && value_source_value != null;
}