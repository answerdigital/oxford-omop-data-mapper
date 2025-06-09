namespace OmopTransformer.OxfordGP.Staging.Clearing;

internal interface IOxfordGPStagingSchema
{
    Task ClearStagingTables(CancellationToken cancellationToken);
}