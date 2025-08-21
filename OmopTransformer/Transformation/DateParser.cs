using System.Globalization;

namespace OmopTransformer.Transformation;

internal class DateParser (string? text)
{
    private static readonly CultureInfo Culture = CultureInfo.GetCultureInfo("en-GB");

    public DateTime? GetAsDate()
    {
        if (string.IsNullOrEmpty(text))
            return null;
        
        if (DateTime.TryParse(text, Culture, out DateTime parsedDate))
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