namespace OmopTransformer.SUS.Staging.Inpatient.CCMDS;

internal interface ISusCCMDSStaging
{
    Task StageData(CancellationToken cancellationToken);
}