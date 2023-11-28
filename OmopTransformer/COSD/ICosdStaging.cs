namespace OmopTransformer.COSD;

internal interface ICosdStaging
{
    Task StageData(CancellationToken cancellationToken);
}