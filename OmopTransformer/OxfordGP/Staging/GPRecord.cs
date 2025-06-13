namespace OmopTransformer.OxfordGP.Staging;

internal class GPRecord
{
    public IEnumerable<GPMedication> Medications { get; init; } = new List<GPMedication>();
    public IEnumerable<GPEvent> Events { get; init; } = new List<GPEvent>();
    public IEnumerable<GPAppointment> Appointments { get; init; } = new List<GPAppointment>();
    public IEnumerable<GPDemographic> Demographics { get; init; } = new List<GPDemographic>();
}