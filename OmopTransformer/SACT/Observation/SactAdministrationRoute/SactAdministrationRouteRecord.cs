using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.Observation;

[DataOrigin("SACT")]
[Description("SACT Administration Route")]
[SourceQuery("SactAdministrationRoute.xml")]
internal class SactAdministrationRouteRecord
{
    public string? NHSNumber { get; set; }
    public string? Administration_Date { get; set; }
    public string? Administration_Route { get; set; }
}