namespace OmopTransformer.SUS.Staging.AE;

internal interface ISusAEStaging
{
    Task StageData(CancellationToken cancellationToken);
}