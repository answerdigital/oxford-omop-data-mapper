using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC;

[DataOrigin("SUS")]
[Description("SUS Inpatient Person")]
[SourceQuery("SusAPCPerson.xml")]
internal class SusAPCPersonRecord
{
    public string? NHSNumber { get; set; }
    public string? DateOfBirth { get; set; }
    public string? EthnicCategory { get; set; }
    public string? PersonCurrentGenderCode { get; set; }
}