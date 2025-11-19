using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Converts text to decimal")]
internal class DecimalParser(string? text) : ISelector
{
    public object? GetValue()
    {
        if (decimal.TryParse(text, out var number))
        {
            return number;
        }

        return null;
    }
}