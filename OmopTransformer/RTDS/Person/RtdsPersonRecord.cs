using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.Person;

[DataOrigin("RTDS")]
[Description("Rtds Person")]
[SourceQuery("RtdsPerson.xml")]
internal class RtdsPersonRecord
{
    public string? PatientId { get; set; }
    public string? DateOfBirth { get; set; }
    public string? Sex { get; set; }
}