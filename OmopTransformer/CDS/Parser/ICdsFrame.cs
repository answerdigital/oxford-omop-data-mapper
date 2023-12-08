namespace OmopTransformer.CDS.Parser;

internal interface ICdsFrame
{
    string? LineId { get; }
    string? RecordConnectionIdentifier { get; }

    string SourceText { get; }
}