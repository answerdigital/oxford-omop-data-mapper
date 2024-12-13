namespace OmopTransformer.Omop.CareSite;

internal interface ICareSiteRecorder
{
    Task InsertUpdateCareSite<T>(IReadOnlyCollection<OmopCareSite<T>> records, string dataSource, CancellationToken cancellationToken);
}
