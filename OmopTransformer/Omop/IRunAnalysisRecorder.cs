namespace OmopTransformer.Omop;

internal interface IRunAnalysisRecorder
{
    void InsertRunAnalysis(Guid runId, string tableType, string origin, int validCount, int invalidCount);
}