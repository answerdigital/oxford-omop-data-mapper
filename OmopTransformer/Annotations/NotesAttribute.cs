namespace OmopTransformer.Annotations;

internal class NotesAttribute : Attribute
{
    public NotesAttribute(string value, CalloutType calloutType = CalloutType.none)
    {
        Value = value;
        CalloutType = calloutType;
    }

    public string Value { get; }
    public CalloutType CalloutType { get; }
}