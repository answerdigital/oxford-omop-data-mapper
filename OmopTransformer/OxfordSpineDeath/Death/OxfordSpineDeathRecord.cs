using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordSpineDeath.Death;

[DataOrigin("Oxford Spine Death")]
[Description("Oxford Spine Death")]
[SourceQuery("OxfordSpineDeath.xml")]
internal class OxfordSpineDeathRecord
{
    public string? patient_identifier_Value { get; set; }
    public string? DECEASED_DT_TM { get; set; }
}