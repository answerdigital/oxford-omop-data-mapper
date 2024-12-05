namespace OmopTransformer.SUS.Staging.OP.Clearing;

internal interface ISusOPStagingSchema
{
    Task ClearStagingTables(CancellationToken cancellationToken);
}