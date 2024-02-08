namespace OmopTransformer.Omop.VisitDetail;

internal interface IVisitDetailRecorder
{
    Task InsertUpdateVisitDetail<T>(IReadOnlyCollection<OmopVisitDetail<T>> records, string dataSource, CancellationToken cancellationToken);
}