using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Selects the year from a date or null of the date is null.")]
internal class YearSelector(string? date) : ISelector
{
    public object? GetValue() => new DateParser(date).GetAsDate()?.Year;
}