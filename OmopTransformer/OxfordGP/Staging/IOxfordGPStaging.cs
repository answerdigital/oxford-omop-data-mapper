namespace OmopTransformer.OxfordGP.Staging;

internal interface IOxfordGPStaging
{
    Task StageData(CancellationToken cancellationToken);
}