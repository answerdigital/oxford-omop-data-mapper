using OmopTransformer.Annotations;
using OmopTransformer.Omop.Death;

namespace OmopTransformer.COSD.Death.v9DeathBasisOfDiagnosisCancer;

internal class CosdV9DeathBasisOfDiagnosisCancer : OmopDeath<CosdV9BasisOfDiagnosisCancerRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? NhsNumber { get; set; }

    [CopyValue(nameof(Source.DeathDate))]
    public override DateTime? death_date { get; set; }

    [CopyValue(nameof(Source.DeathDate))]
    public override DateTime? death_datetime { get; set; }

    [ConstantValue(32818, "EHR Administration record")]
    public override int? death_type_concept_id { get; set; }

    [ConstantValue(32510, "EHR record patient status Deceased")]
    public override int? cause_source_concept_id { get; set; } 
}