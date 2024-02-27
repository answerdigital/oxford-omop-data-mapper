namespace OmopTransformer.Omop.Location;

internal interface ILocationRecorder
{
    Task InsertUpdateLocations<T>(IReadOnlyCollection<OmopLocation<T>> records, string dataSource, CancellationToken cancellationToken);
}