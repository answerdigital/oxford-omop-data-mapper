using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.APC.Observation.ProcedureObservations;

internal class SusAPCProcedureObservations : OmopObservation<SusAPCProcedureObservationsRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [CopyValue(nameof(Source.GeneratedRecordIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }

    [Transform(typeof(StandardObservationConceptSelector), useOmopTypeAsSource: true, nameof(observation_source_concept_id))]
    public override int[]? observation_concept_id { get; set; }

    [Transform(typeof(DateOnlyConverter), nameof(Source.PrimaryProcedureDate))]
    public override DateOnly? observation_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.PrimaryProcedureDate))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32818, "EHR administration record")]
    public override int? observation_type_concept_id { get; set; }

    [Transform(typeof(Opcs4Selector), nameof(Source.PrimaryProcedure))]
    public override int? observation_source_concept_id { get; set; }
}