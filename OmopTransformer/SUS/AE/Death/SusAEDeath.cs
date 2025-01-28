using OmopTransformer.Annotations;
using OmopTransformer.Omop.Death;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.AE.Death;

internal class SusAEDeath : OmopDeath<SusAEDeathRecord>
{
    [CopyValue(nameof(Source.nhs_number))]
    public override string? NhsNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.death_date))]
    public override DateTime? death_date { get; set; }
}