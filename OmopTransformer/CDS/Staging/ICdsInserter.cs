using OmopTransformer.CDS.Parser;

namespace OmopTransformer.CDS.Staging;

internal interface ICdsInserter
{
    Task Insert(IReadOnlyCollection<Message> rows, CancellationToken cancellationToken);
}