using OmopTransformer.Annotations;
using OmopTransformer.Omop.Death;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.OP.Death;

internal class SusOPDeath : OmopDeath<SusOPDeathRecord>
{
    [CopyValue(nameof(Source.nhs_number))]
    public override string? NhsNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.death_date))]
    public override DateTime? death_date { get; set; }
}