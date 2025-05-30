using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.Person;

[DataOrigin("SACT")]
[Description("SACT Person")]
[SourceQuery("SactPerson.xml")]
internal class SactPersonRecord
{
    public string? NHS_Number { get; set; }
    public string? Patient_Postcode { get; set; }
    public string? Date_Of_Birth { get; init; }
    public string? Person_Stated_Gender_Code { get; init; }
}