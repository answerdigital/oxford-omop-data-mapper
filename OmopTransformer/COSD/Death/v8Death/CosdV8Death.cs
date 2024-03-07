using OmopTransformer.Annotations;
using OmopTransformer.Omop.Death;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Death.v8Death;

internal class CosdV8Death : OmopDeath<CosdV8DeathRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? NhsNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DeathDate))]
    public override DateTime? death_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DeathDate))]
    public override DateTime? death_datetime { get; set; }

    [ConstantValue(32818, "EHR Administration record")]
    public override int? death_type_concept_id { get; set; }

    [ConstantValue(32510, "EHR record patient status Deceased")]
    public override int? cause_source_concept_id { get; set; } 
}