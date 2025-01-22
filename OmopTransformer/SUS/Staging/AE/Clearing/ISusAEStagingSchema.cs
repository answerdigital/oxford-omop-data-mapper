namespace OmopTransformer.SUS.Staging.AE.Clearing;

internal interface ISusAEStagingSchema
{
    Task ClearStagingTables(CancellationToken cancellationToken);
}