﻿namespace OmopTransformer.SUS.Staging;

internal interface ISusInserter
{
    Task Insert(IEnumerable<APCRecord> rows, CancellationToken cancellationToken);
}