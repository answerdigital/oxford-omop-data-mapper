using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.Observation;

[DataOrigin("RTDS")]
[Description("RTDS External Beam Radiation Therapy Energy")]
[SourceQuery("RtdsExternalBeamEnergy.xml")]
internal class RtdsExternalBeamEnergyRecord
{
    public string? NhsNumber { get; set; }
    public string? Treatmentdatetime { get; set; }
    public string? NominalEnergy { get; set; }
    public string? CalculatedNominalEnergy { get; set; }
}