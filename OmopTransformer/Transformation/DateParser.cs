using System.Globalization;

namespace OmopTransformer.Transformation;

internal class DateParser (string? text)
{
    public DateTime? GetAsDate()
    {
        if (string.IsNullOrEmpty(text))
            return null;
        
        if (DateTime.TryParse(text, out DateTime parsedDate))
        {
            return parsedDate;
        }

        if (DateTime.TryParseExact(text, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime exactParsedDate))
        {
            return exactParsedDate;
        }

        return null;
    }
}