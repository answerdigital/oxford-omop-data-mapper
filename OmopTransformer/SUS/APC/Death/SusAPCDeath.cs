using OmopTransformer.Annotations;
using OmopTransformer.Omop.Death;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.APC.Death;

internal class SusAPCDeath : OmopDeath<SusAPCDeathRecord>
{
    [CopyValue(nameof(Source.nhs_number))]
    public override string? NhsNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.death_date))]
    public override DateTime? death_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.death_date), nameof(Source.death_time))]
    public override DateTime? death_datetime { get; set; }

    [CopyValue(nameof(Source.DiagnosisICD))]
    public override string? cause_source_value { get; set; }

    [Transform(typeof(Icd10Selector), nameof(Source.DiagnosisICD))]
    public override int? cause_concept_id { get; set; }

}