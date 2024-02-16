namespace OmopTransformer.Transformation;

internal interface ILookup
{
    Dictionary<KeyWithName, ValueWithNote> Mappings { get; }

    string[] ColumnNotes { get; }
}