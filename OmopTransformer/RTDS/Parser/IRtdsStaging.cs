namespace OmopTransformer.RTDS.Parser;

internal interface IRtdsStaging
{
    Task StageData(CancellationToken cancellationToken);
}