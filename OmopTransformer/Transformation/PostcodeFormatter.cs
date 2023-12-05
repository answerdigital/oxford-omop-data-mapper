using System.Text.RegularExpressions;
using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Uppercase the postcode then insert the space in the correct location, if needed.")]
internal class PostcodeFormatter : ISelector
{
    private readonly string? _value;

    public PostcodeFormatter(string? value)
    {
        _value = value;
    }

    public string? GetValue()
    {
        if (_value == null)
            return _value;

        var cleanPostcode = _value.Replace(" ", "").ToUpper();

        const string pattern = @"([A-Z]{1,2}[0-9][0-9A-Z]?)([0-9][A-Z]{2})";

        if (!Regex.IsMatch(cleanPostcode, pattern))
        {
            // If we can't format the postcode, just return it as it is, even if it is invalid.
            return _value;
        }

        return Regex.Replace(cleanPostcode, pattern, "$1 $2");
    }
}