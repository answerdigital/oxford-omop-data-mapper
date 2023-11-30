namespace OmopTransformer.Omop;

internal interface ILocationRecorder
{
    Task InsertUpdateLocations<T>(IReadOnlyCollection<OmopLocation<T>> locations, CancellationToken cancellationToken);
}