namespace OmopTransformer.RTDS.Staging;

internal interface IRtdsStagingSchema
{
    Task ClearStagingTables(CancellationToken cancellationToken);
}