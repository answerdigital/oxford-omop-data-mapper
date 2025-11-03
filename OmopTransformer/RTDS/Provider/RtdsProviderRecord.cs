using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.Provider;

[DataOrigin("RTDS")]
[Description("RTDS Provider")]
[SourceQuery("RtdsProvider.xml")]
internal class RtdsProviderRecord
{
    public string? DoctorId { get; set; }
}