using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Converts text to integers.")]
internal class NumberParser(string? text) : ISelector
{
    public object? GetValue()
    {
        if (int.TryParse(text, out var number))
        {
            return number;
        }

        return null;
    }
}