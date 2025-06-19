using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.CCMDS.Observation.HighCostDrugs.SusCCMDSHighCostDrugs;

internal class SusCCMDSHighCostDrugs : OmopObservation<SusCCMDSHighCostDrugsRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [CopyValue(nameof(Source.HospitalProviderSpellNumber))]
    public override string? HospitalProviderSpellNumber { get; set; }

    [Transform(typeof(StandardConceptSelector), useOmopTypeAsSource: true, nameof(observation_source_concept_id))]
    public override int[]? observation_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.ObservationDate))]
    public override DateTime? observation_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.ObservationDate), nameof(Source.ObservationDateTime))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(38000280, "Observation recorded from EHR")]
    public override int? observation_type_concept_id { get; set; }

    [CopyValue(nameof(Source.ObservationSourceValue))]
    public override string? observation_source_value { get; set; }
    
    [Transform(typeof(Opcs4Selector), nameof(Source.ObservationSourceValue))]
    public override int? observation_source_concept_id { get; set; }
}