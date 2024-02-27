namespace OmopTransformer.Omop.Death;

internal interface IDeathRecorder
{
    Task InsertUpdateDeaths<T>(IReadOnlyCollection<OmopDeath<T>> records, string dataSource, CancellationToken cancellationToken);
}