namespace OmopTransformer.Omop.Person;

internal interface IPersonRecorder
{
    Task InsertUpdatePersons<T>(IReadOnlyCollection<OmopPerson<T>> records, string dataSource, CancellationToken cancellationToken);
}