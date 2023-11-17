namespace OmopTransformer.Transformation;

internal interface ILookup
{
    Dictionary<string, ValueWithNote> Mappings { get; }

    string[] ColumnNotes { get; }
}