using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Core.Death.v8Death;

[DataOrigin("COSD")]
[Description("COSD v8 Death")]
[SourceQuery("CosdV8Death.xml")]
internal class CosdV8DeathRecord
{
    public string? NhsNumber { get; set; }
    public string? DeathDate { get; set; }
}