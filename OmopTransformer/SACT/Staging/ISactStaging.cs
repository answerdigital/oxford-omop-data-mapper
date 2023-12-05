namespace OmopTransformer.SACT.Staging;

internal interface ISactStaging
{
    Task StageData(CancellationToken cancellationToken);
}