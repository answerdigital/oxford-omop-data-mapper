using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Converts text to number.")]
internal class DoubleParser(string? text) : ISelector
{
    public object? GetValue()
    {
        if (double.TryParse(text, out var number))
        {
            return number;
        }

        return null;
    }
}