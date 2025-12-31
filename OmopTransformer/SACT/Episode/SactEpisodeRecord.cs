using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.Episode;

[DataOrigin("SACT")]
[Description("SACT Episode")]
[SourceQuery("SactEpisode.xml")]
internal class SactEpisodeRecord
{
    public string? NHS_Number { get; set; }
    public string? Start_Date_Of_Regimen { get; set; }
    public string? Regimen { get; set; }
}