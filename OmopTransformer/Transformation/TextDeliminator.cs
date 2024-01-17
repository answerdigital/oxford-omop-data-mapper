using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Separates text with newlines. Trim whitespace.")]
internal class TextDeliminator : ISelector
{
    private readonly IReadOnlyCollection<string> _textParts;

    public TextDeliminator(params object[] textParts)
    {
        if (textParts == null) 
            throw new ArgumentNullException(nameof(textParts));

        _textParts = 
            textParts
                .Cast<string>()
                .Select(text => text.TrimWhitespace())
                .Where(text => string.IsNullOrEmpty(text) == false)
                .Cast<string>()
                .ToList();
    }

    public object? GetValue() => _textParts.Count == 0 ? null : string.Join("\r\n", _textParts);
}