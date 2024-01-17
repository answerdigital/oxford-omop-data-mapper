namespace OmopTransformer.Omop.Person;

internal interface IPersonRecorder
{
    Task InsertUpdatePersons<T>(IReadOnlyCollection<OmopPerson<T>> persons, string dataSource, CancellationToken cancellationToken);
}