namespace OmopTransformer.Omop.ProcedureOccurrence;

internal interface IProcedureOccurrenceRecorder
{
    Task InsertUpdateProcedureOccurrence<T>(IReadOnlyCollection<OmopProcedureOccurrence<T>> records, string dataSource, CancellationToken cancellationToken);
}