namespace OmopTransformer.OxfordGP.Staging;

internal interface IOxfordGPParser
{
    IEnumerable<GPAppointment> ReadAppointmentFile(string path, CancellationToken cancellationToken);
    IEnumerable<GPMedication> ReadMedicationFile(string path, CancellationToken cancellationToken);
    IEnumerable<GPDemographic> ReadDemographicFile(string path, CancellationToken cancellationToken);
    IEnumerable<GPEvent> ReadEventFile(string path, CancellationToken cancellationToken);
}