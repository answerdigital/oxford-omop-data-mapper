using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Converts text to dates.")]
internal class DateConverter(string? date) : ISelector
{
    public object? GetValue()
    {
        return new DateParser(date).GetAsDate();
    }
}