namespace OmopTransformer.COSD.Staging;

internal interface ICosdStagingSchema
{
    Task CreateStagingTablesIfTheyDoNotExist(CancellationToken cancellationToken);
    Task DropStagingTables(CancellationToken cancellationToken);
    Task<bool> StagingTablesExist(CancellationToken cancellationToken);
}