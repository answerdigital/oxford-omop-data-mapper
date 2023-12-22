using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Separates text with newlines.")]
internal class TextDeliminator : ISelector
{
    private readonly IReadOnlyCollection<string> _textParts;

    public TextDeliminator(params object[] textParts)
    {
        if (textParts == null) 
            throw new ArgumentNullException(nameof(textParts));

        _textParts = textParts.Cast<string>().ToList();
    }

    public object GetValue() => string.Join("\r\n", _textParts);
}