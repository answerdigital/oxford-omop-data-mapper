namespace OmopTransformer.SUS.Staging.Inpatient;

internal interface ISusInpatientStaging
{
    Task StageData(CancellationToken cancellationToken);
}