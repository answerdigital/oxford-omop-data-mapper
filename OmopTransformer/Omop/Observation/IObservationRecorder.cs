namespace OmopTransformer.Omop.Observation;

internal interface IObservationRecorder
{
    Task InsertUpdateObservations<T>(IReadOnlyCollection<OmopObservation<T>> records, string dataSource, CancellationToken cancellationToken);
}