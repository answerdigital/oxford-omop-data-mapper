using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS.Observation.BirthWeight;

internal class CdsBirthWeight : OmopObservation<CdsBirthWeightRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [CopyValue(nameof(Source.RecordConnectionIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }

    [Transform(typeof(NumberParser), nameof(Source.HospitalProviderSpellNumber))]
    public override int? HospitalProviderSpellNumber { get; set; }

    [ConstantValue(3662222, "Weight of neonate at birth")]
    public override int? observation_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.observation_date))]
    public override DateTime? observation_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.observation_date))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(38000280, "Observation recorded from EHR")]
    public override int? observation_type_concept_id { get; set; }

    [CopyValue(nameof(Source.BirthWeight))]
    public override string? value_as_string { get; set; }

    [ConstantValue(9529, "kilogram")]
    public override int? unit_concept_id { get; set; }
}