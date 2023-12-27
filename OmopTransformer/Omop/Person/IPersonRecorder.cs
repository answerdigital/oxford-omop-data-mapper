namespace OmopTransformer.Omop.Person;

internal interface IPersonRecorder
{
    Task InsertUpdatePersons<T>(IReadOnlyCollection<OmopPerson<T>> persons, CancellationToken cancellationToken);
}