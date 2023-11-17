namespace OmopTransformer.Transformation;

internal class GenderLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            {
                "m", new ValueWithNote("123", "value notes can go here")
            },
            {
                "f", new ValueWithNote("345", "")
            },
            {
                "u", new ValueWithNote("567", "")
            }
        };

    public string[] ColumnNotes =>
        new
            []
            {
                "Overall gender notes can go here."
            };
}