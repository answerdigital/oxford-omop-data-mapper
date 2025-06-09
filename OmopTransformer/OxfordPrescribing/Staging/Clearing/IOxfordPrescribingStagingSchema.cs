namespace OmopTransformer.OxfordPrescribing.Staging.Clearing;

internal interface IOxfordPrescribingStagingSchema
{
    Task ClearStagingTables(CancellationToken cancellationToken);
}