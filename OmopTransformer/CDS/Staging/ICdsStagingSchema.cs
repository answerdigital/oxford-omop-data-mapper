namespace OmopTransformer.CDS.Staging;

internal interface ICdsStagingSchema
{
    Task CreateStagingTablesIfTheyDoNotExist(CancellationToken cancellationToken);
    Task DropStagingTables(CancellationToken cancellationToken);
    Task<bool> StagingTablesExist(CancellationToken cancellationToken);
}