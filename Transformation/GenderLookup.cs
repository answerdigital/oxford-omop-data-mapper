namespace OmopTransformer.Transformation;

internal class GenderLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            {
                "m", new ValueWithNote() { Value = "123", Notes = "value notes can go here" }
            },
            {
                "f", new ValueWithNote() { Value = "345", Notes = "" }
            },
            {
                "u", new ValueWithNote() { Value = "567", Notes = "" }
            }
        };

    public string[] ColumnNotes =>
        new
            []
            {
                "Overall gender notes can go here."
            };
}