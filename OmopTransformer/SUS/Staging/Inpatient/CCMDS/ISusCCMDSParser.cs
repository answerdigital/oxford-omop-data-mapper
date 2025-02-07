namespace OmopTransformer.SUS.Staging.Inpatient.CCMDS;

internal interface ISusCCMDSParser
{
    IEnumerable<CCMDSRecord> ReadFile(string path, CancellationToken cancellationToken);
}