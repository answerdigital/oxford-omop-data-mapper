namespace OmopTransformer.SUS.Staging.APC;

internal interface ISusApcStaging
{
    Task StageData(CancellationToken cancellationToken);
}