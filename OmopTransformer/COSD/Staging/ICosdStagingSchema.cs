namespace OmopTransformer.COSD.Staging;

internal interface ICosdStagingSchema
{
    Task ClearStagingTables(CancellationToken cancellationToken);
}