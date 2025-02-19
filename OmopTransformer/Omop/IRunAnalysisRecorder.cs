namespace OmopTransformer.Omop;

internal interface IRunAnalysisRecorder
{
    Task InsertRunAnalysis(Guid runId, string tableType, string origin, int validCount, int invalidCount, CancellationToken cancellationToken);
}