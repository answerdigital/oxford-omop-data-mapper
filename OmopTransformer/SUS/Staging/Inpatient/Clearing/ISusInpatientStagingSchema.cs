namespace OmopTransformer.SUS.Staging.Inpatient.Clearing;

internal interface ISusInpatientStagingSchema
{
    Task ClearStagingTables(CancellationToken cancellationToken);
}