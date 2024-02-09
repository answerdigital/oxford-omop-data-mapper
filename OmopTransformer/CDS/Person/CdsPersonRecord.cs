using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.Person;

[DataOrigin("CDS")]
[Description("CDS Person")]
[SourceQuery("CdsPerson.xml")]
internal class CdsPersonRecord
{
    public string? NHSNumber { get; set; }
    public string? DateOfBirth { get; set; }
    public string? EthnicCategory { get; set; }
    public string? PersonCurrentGenderCode { get; set; }
}