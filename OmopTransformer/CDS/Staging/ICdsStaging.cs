namespace OmopTransformer.CDS.Staging;

internal interface ICdsStaging
{
    Task StageData(CancellationToken cancellationToken);
}