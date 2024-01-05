using CsvHelper;

namespace OmopTransformer;

internal static class CsvReaderExtensions
{
    public static string? GetFieldOrNullWhenEmpty(this CsvReader reader, string name)
    {
        ArgumentNullException.ThrowIfNull(reader, nameof(reader));
        ArgumentNullException.ThrowIfNull(reader, nameof(name));
            
        var value = reader.GetField(name);

        if (value == null)
            return null;

        return value.IsEmpty() ? null : value;
    }

    public static string? GetFieldOrNullWhenEmptyIfExists(this CsvReader reader, string name)
    {
        ArgumentNullException.ThrowIfNull(reader, nameof(reader));
        ArgumentNullException.ThrowIfNull(reader, nameof(name));

        if (reader.TryGetField<string>(name, out _))
        {
            return reader.GetFieldOrNullWhenEmpty(name);
        }

        return null;
    }
}