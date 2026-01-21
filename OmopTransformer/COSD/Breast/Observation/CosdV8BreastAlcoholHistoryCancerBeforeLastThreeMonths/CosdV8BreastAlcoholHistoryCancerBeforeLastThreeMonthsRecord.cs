using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Breast.Observation.CosdV8BreastAlcoholHistoryCancerBeforeLastThreeMonths;

[DataOrigin("COSD")]
[Description("COSD V8 Breast Alcohol History Cancer Before Last Three Months")]
[SourceQuery("CosdV8BreastAlcoholHistoryCancerBeforeLastThreeMonths.xml")]
internal class CosdV8BreastAlcoholHistoryCancerBeforeLastThreeMonthsRecord
{
    public string? NhsNumber { get; set; }
    public DateOnly? Date { get; set; }
    public string? AlcoholHistoryCancerBeforeLastThreeMonths { get; set; }
}
