using OmopTransformer.RTDS.Parser;

namespace OmopTransformer.RTDS.Staging;

internal interface IRtdsInserter
{
    Task Insert(RtdsRecords records, CancellationToken cancellationToken);
}