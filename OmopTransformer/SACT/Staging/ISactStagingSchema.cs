namespace OmopTransformer.SACT.Staging;

internal interface ISactStagingSchema
{
    Task ClearStagingTables(CancellationToken cancellationToken);
}