namespace OmopTransformer.OxfordPrescribing.Staging;

internal interface IOxfordPrescribingStaging
{
    Task StageData(CancellationToken cancellationToken);
}