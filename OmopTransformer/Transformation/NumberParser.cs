using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Converts text to integers.")]
internal class NumberParser(string? date) : ISelector
{
    public object? GetValue()
    {
        if (int.TryParse(date, out var number))
        {
            return number;
        }

        return null;
    }
}