using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Convert text to uppercase. Trim whitespace.")]
internal class UppercaseAndTrimWhitespace : ISelector
{
    private readonly string? _text;

    public UppercaseAndTrimWhitespace(string? text)
    {
        _text = text;
    }

    public string? GetValue()
    {
        return _text?.ToUpper().TrimStart(' ').TrimEnd(' ');
    }
}