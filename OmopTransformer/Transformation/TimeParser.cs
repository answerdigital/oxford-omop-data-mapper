using System.Globalization;

namespace OmopTransformer.Transformation;

internal class TimeParser (string? text)
{
    public TimeSpan? GetAsTime()
    {
        if (text == null)
            return null;

        if (TimeSpan.TryParseExact(text, "hhmmss", CultureInfo.InvariantCulture, out var time))
            return time;

        if (TimeSpan.TryParseExact(text, @"hh\:mm\:ss", CultureInfo.InvariantCulture, out var timeWithColons))
            return timeWithColons;

        return null;
    }
}