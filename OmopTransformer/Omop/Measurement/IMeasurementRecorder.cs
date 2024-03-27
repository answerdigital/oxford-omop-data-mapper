namespace OmopTransformer.Omop.Measurement;

internal interface IMeasurementRecorder
{
    Task InsertUpdateMeasurements<T>(IReadOnlyCollection<OmopMeasurement<T>> records, string dataSource, CancellationToken cancellationToken);
}