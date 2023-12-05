namespace OmopTransformer.SACT.Staging;

internal interface ISactStagingSchema
{
    Task CreateStagingTablesIfTheyDoNotExist(CancellationToken cancellationToken);
    Task DropStagingTables(CancellationToken cancellationToken);
    Task<bool> StagingTablesExist(CancellationToken cancellationToken);
}