namespace OmopTransformer.SUS.Staging;

internal interface ISusStaging
{
    Task StageData(CancellationToken cancellationToken);
}