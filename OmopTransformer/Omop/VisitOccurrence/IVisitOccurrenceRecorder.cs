namespace OmopTransformer.Omop.VisitOccurrence;

internal interface IVisitOccurrenceRecorder
{
    Task InsertUpdateVisitOccurrence<T>(IReadOnlyCollection<OmopVisitOccurrence<T>> records, string dataSource, CancellationToken cancellationToken);
}