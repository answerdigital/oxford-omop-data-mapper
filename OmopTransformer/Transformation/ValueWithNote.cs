namespace OmopTransformer.Transformation;

internal class ValueWithNote
{
    public ValueWithNote(string value, string notes)
    {
        Value = value ?? throw new ArgumentNullException(nameof(value));
        Notes = notes ?? throw new ArgumentNullException(nameof(notes));
    }

    public string Value { get; }
    public string Notes { get; }
}