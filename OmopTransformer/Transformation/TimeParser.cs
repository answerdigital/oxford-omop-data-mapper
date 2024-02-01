using System.Globalization;

namespace OmopTransformer.Transformation;

internal class TimeParser (string? text)
{
    public TimeSpan? GetAsTime()
    {
        if (text == null)
            return null;

        if (TimeSpan.TryParseExact(text, "hhmmss", CultureInfo.InvariantCulture, out var time))
        {
            return time;
        }

        return null;
    }
}