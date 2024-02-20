namespace OmopTransformer.Omop.DrugExposure;

internal interface IDrugExposureRecorder
{
    Task InsertUpdateDrugExposure<T>(IReadOnlyCollection<OmopDrugExposure<T>> records, string dataSource, CancellationToken cancellationToken);
}