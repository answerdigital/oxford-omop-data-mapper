using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE;

[DataOrigin("SUS")]
[Description("SUS A&E Person")]
[SourceQuery("SusAEPerson.xml")]
internal class SusAEPersonRecord
{
    public string? NHSNumber { get; set; }
    public string? DateOfBirth { get; set; }
    public string? EthnicCategory { get; set; }
    public string? PersonCurrentGenderCode { get; set; }
}