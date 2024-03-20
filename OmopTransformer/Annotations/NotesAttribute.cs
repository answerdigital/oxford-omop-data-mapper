namespace OmopTransformer.Annotations;

internal class NotesAttribute : Attribute
{
    public NotesAttribute(string title, params string[] textLine)
    {
        TextLine = textLine;
        Title = title;
    }

    public string[] TextLine { get; }
    public string Title { get; }
}