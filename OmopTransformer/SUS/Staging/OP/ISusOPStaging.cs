namespace OmopTransformer.SUS.Staging.OP;

internal interface ISusOPStaging
{
    Task StageData(CancellationToken cancellationToken);
}