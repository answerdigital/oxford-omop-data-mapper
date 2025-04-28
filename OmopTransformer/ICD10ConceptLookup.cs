using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal abstract class Icd10ConceptLookup : ConceptLookup
{
    protected Icd10ConceptLookup(IOptions<Configuration> configuration, ILogger<ConceptLookup> logger) : base(configuration, logger)
    {
    }

    public override string LoadingLoggerMessage => "Loading ICD10 codes.";

    public override string FormatCode(string code) => TrimIcd10(code);

    internal static string TrimIcd10(string code)
    {
        if (code.Length <= 2)
            throw new ArgumentException($"Code is too short. Code is {code}.", nameof(code));

        code = code.Replace(".", "");

        char firstCharOfCode = code[0];

        var remainder = code[1..];

        return firstCharOfCode + TrimAtFirstNonNumericChar(remainder);
    }

    private static string TrimAtFirstNonNumericChar(string text)
    {
        var firstNonNumericIndex =
            text
                .Select((c, index) => new { c, index })
                .FirstOrDefault(charAndIndex => char.IsNumber(charAndIndex.c) == false);

        if (firstNonNumericIndex == null)
            return text;

        return text[..firstNonNumericIndex.index];
    }
}