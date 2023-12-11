namespace OmopTransformer.COSD.Staging;

internal interface ICosdStaging
{
    Task StageData(CancellationToken cancellationToken);
}