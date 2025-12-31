namespace OmopTransformer.Omop.Episode;

internal interface IEpisodeRecorder
{
    Task InsertUpdateEpisodes<T>(IReadOnlyCollection<OmopEpisode<T>> records, string dataSource, CancellationToken cancellationToken);
}