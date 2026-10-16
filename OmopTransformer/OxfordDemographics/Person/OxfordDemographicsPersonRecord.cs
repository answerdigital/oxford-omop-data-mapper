using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordDemographics.Person;

[DataOrigin("Oxford Demographics")]
[Description("Oxford demographics from databricks_demographics.parquet")]
[SourceQuery("OxfordDemographicsPerson.xml")]
internal class OxfordDemographicsPersonRecord
{
    public string? date_of_birth { get; set; }
    public string? ethnic_group { get; set; }
    public string? sex { get; set; }
    public string? nhs_number { get; set; }
}
