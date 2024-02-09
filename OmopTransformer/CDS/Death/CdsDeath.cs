using OmopTransformer.Omop.Death;
using OmopTransformer.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS.Death;

internal class CdsDeath : OmopDeath<CdsDeathRecord>
{
    [CopyValue(nameof(Source.nhs_number))]
    public override string? NhsNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.death_date))]
    public override DateTime? death_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.death_date))]
    public override DateTime? death_datetime { get; set; }

    [ConstantValue(32818, "EHR Administration record")]
    public override int? death_type_concept_id { get; set; }

    [ConstantValue(32510, "EHR record patient status Deceased")]
    public override int? cause_source_concept_id { get; set; } 
}