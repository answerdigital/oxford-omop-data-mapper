namespace OmopTransformer.SUS.Staging.APC.Clearing;

internal interface ISusAPCStagingSchema
{
    Task ClearStagingTables(CancellationToken cancellationToken);
}