using OmopTransformer.Annotations;
using OmopTransformer.Omop.Death;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.APC.Death;

internal class SusAPCDeath : OmopDeath<SusAPCDeathRecord>
{
    [CopyValue(nameof(Source.nhs_number))]
    public override string? NhsNumber { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.death_date), nameof(Source.death_time))]
    public override DateTime? death_datetime { get; set; }

    [Transform(typeof(Icd10Selector), nameof(Source.cause_concept_id))]
    public override int? cause_source_concept_id { get; set; }

    [Transform(typeof(SnomedSelector), useOmopTypeAsSource: true, nameof(cause_source_concept_id))]
    public override int[]? cause_concept_id { get; set; }
}