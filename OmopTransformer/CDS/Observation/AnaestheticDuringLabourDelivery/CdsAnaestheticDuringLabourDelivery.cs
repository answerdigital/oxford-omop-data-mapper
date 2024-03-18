using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS.Observation.AnaestheticDuringLabourDelivery;

internal class CdsAnaestheticDuringLabourDelivery : OmopObservation<CdsAnaestheticDuringLabourDeliveryRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [CopyValue(nameof(Source.RecordConnectionIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }

    [Transform(typeof(NumberParser), nameof(Source.HospitalProviderSpellNumber))]
    public override int? HospitalProviderSpellNumber { get; set; }

    [ConstantValue(4163264, "Type of anesthetic")]
    public override int? observation_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.observation_date))]
    public override DateTime? observation_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.observation_date))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(38000281, "Observation recorded from EHR with text result")]
    public override int? observation_type_concept_id { get; set; }

    [CopyValue(nameof(Source.AnaestheticDuringLabourDelivery))]
    public override string? value_as_string { get; set; }

    [ConstantValue(2000500001, "ANAESTHETIC GIVEN DURING LABOUR OR DELIVERY CODE")]
    public override int? observation_source_concept_id { get; set; }
}