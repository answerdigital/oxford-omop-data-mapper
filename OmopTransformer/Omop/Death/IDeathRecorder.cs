namespace OmopTransformer.Omop.Death;

internal interface IDeathRecorder
{
    Task InsertUpdateDeaths<T>(IReadOnlyCollection<OmopDeath<T>> deaths, string dataSource, CancellationToken cancellationToken);
}