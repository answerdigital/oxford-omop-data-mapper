namespace OmopTransformer.SUS.Staging.Clearing;

internal interface ISusStagingSchema
{
    Task ClearStagingTables(CancellationToken cancellationToken);
}