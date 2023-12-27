using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Selects the month of the year or null if the date is null.")]
internal class MonthOfYearSelector(string? date) : ISelector
{
    public object? GetValue() => new DateParser(date).GetAsDate()?.Month;
}