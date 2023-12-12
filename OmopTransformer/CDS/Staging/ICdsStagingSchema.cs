namespace OmopTransformer.CDS.Staging;

internal interface ICdsStagingSchema
{
    Task ClearStagingTables(CancellationToken cancellationToken);
}