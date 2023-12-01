namespace OmopTransformer.Omop.Location;

internal interface ILocationRecorder
{
    Task InsertUpdateLocations<T>(IReadOnlyCollection<OmopLocation<T>> locations, CancellationToken cancellationToken);
}