using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Combines a date with a time of day.")]
internal class DateAndTimeCombiner(string? date, string time) : ISelector
{
    public object? GetValue()
    {
        var parsedDate = new DateParser(date).GetAsDate();

        var parsedTime = new TimeParser(time).GetAsTime();

        if (parsedDate == null || parsedTime == null)
            return null;

        return parsedDate.Value.Date + parsedTime;
    }
}