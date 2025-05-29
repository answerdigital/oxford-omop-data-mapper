using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Converts text to floating-point numbers.")]
internal class FloatParser(string? text) : ISelector
{
    public object? GetValue()
    {
        if (float.TryParse(text, out var number))
        {
            return number;
        }

        return null;
    }
}