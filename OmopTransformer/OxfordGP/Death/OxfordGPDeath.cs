using OmopTransformer.Annotations;
using OmopTransformer.Omop.Death;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordGP.Death;

internal class OxfordGPDeath : OmopDeath<OxfordGPDeathRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? NhsNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DateofDeath))]
    public override DateTime? death_date { get; set; }
}