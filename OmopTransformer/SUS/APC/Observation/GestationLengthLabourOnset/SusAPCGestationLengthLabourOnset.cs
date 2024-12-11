using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.APC.Observation.GestationLengthLabourOnset;

[Notes(
    "Notes",
    "Observations do not require a standardized test or other activity to generate clinical fact. Typical observations are medical history, family history, lifestyle choices, healthcare utilization patterns, social circumstances etc",
    "Valid Observation Concepts are not enforced to be from any domain.  They should still be standard concepts and typically belong to the Observation or Measurement domain.",
    "Observations can be stored as attribute value pairs, with the attribute as the Observation Concept and the value representing the clinical fact. This fact can be stored as a Concept (value_as_concept), a numerical value (value_as_number) or a verbatim string (value_as_string)")]
internal class SusAPCGestationLengthLabourOnset : OmopObservation<SusAPCGestationLengthLabourOnsetRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [CopyValue(nameof(Source.GeneratedRecordIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }

    [Transform(typeof(NumberParser), nameof(Source.HospitalProviderSpellNumber))]
    public override int? HospitalProviderSpellNumber { get; set; }

    [ConstantValue(40493181, "Length of gestation at time of procedure")]
    public override int? observation_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.observation_date))]
    public override DateTime? observation_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.observation_date))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(38000280, "Observation recorded from EHR")]
    public override int? observation_type_concept_id { get; set; }

    [Transform(typeof(NumberParser), nameof(Source.GestationLengthLabourOnset))]
    public override int? value_as_number { get; set; }

    [ConstantValue(8511, "week")]
    public override int? unit_concept_id { get; set; }
}