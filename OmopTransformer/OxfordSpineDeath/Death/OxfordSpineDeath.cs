using OmopTransformer.Annotations;
using OmopTransformer.Omop.Death;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordSpineDeath.Death;

internal class OxfordSpineDeath : OmopDeath<OxfordSpineDeathRecord>
{
    [CopyValue(nameof(Source.patient_identifier_Value))]
    public override string? NhsNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DECEASED_DT_TM))]
    public override DateTime? death_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DECEASED_DT_TM))]

    public override DateTime? death_datetime { get; set; }
}
