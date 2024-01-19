namespace OmopTransformer.Omop.ConditionOccurrence;

internal interface IConditionOccurrenceRecorder
{
    Task InsertUpdateConditionOccurrence<T>(IReadOnlyCollection<OmopConditionOccurrence<T>> records, string dataSource, CancellationToken cancellationToken);
}