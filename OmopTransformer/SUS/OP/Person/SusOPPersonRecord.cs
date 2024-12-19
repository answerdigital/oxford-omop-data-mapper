using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP;

[DataOrigin("SUS")]
[Description("SUS Outpatient Person")]
[SourceQuery("SusOPPerson.xml")]
internal class SusOPPersonRecord
{
    public string? NHSNumber { get; set; }
    public string? DateOfBirth { get; set; }
    public string? EthnicCategory { get; set; }
    public string? PersonCurrentGenderCode { get; set; }
}