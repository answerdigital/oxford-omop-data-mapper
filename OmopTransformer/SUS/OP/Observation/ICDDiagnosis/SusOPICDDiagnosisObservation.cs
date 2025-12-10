using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.OP.Observation.ICDDiagnosis;

internal class SusOPICDDiagnosisObservation : OmopObservation<SusOPICDDiagnosisObservationRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [CopyValue(nameof(Source.GeneratedRecordIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }

    [Transform(typeof(StandardObservationConceptSelector), useOmopTypeAsSource: true, nameof(observation_source_concept_id))]
    public override int[]? observation_concept_id { get; set; }

    [Transform(typeof(DateOnlyConverter), nameof(Source.CDSActivityDate))]
    public override DateOnly? observation_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32818, "EHR administration record")]
    public override int? observation_type_concept_id { get; set; }

    [Transform(typeof(Icd10StandardNonStandardSelector), nameof(Source.DiagnosisICD))]
    public override int? observation_source_concept_id { get; set; }
}