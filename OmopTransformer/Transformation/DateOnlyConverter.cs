using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Converts text to dates.")]
internal class DateOnlyConverter(string? date) : ISelector
{
    public object? GetValue()
    {
        DateTime? dateTime = new DateParser(date).GetAsDate();

        if (dateTime.HasValue)
        {
            return DateOnly.FromDateTime(dateTime.Value);
        }

        return null;
    }
}