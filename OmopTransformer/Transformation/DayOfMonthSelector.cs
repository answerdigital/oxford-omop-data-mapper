using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Selects the day of the month or null if the date is null.")]
internal class DayOfMonthSelector(string? date) : ISelector
{
    public object? GetValue() => new DateParser(date).GetAsDate()?.Day;
}