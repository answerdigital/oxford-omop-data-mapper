namespace OmopTransformer.SUS.Staging.Inpatient.CCMDS;

internal interface ISusCCMDSInserter
{
    Task Insert(IEnumerable<CCMDSRecord> rows, CancellationToken cancellationToken);
}