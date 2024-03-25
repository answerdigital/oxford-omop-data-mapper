using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Observation.CosdV9HistoryOfAlcoholPast;

[DataOrigin("COSD")]
[Description("CosdV9HistoryOfAlcoholPast")]
[SourceQuery("CosdV9HistoryOfAlcoholPast.xml")]
internal class CosdV9HistoryOfAlcoholPastRecord
{
    public string? NhsNumber { get; set; }
    public string? Date { get; set; }
    public string? HistoryOfAlcoholPast { get; set; }
}
