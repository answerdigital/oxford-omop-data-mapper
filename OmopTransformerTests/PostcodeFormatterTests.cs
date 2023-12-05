using NUnit.Framework;
using OmopTransformer.Transformation;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace OmopTransformerTests;

[TestFixture]
public class PostcodeFormatterTests
{
    [Test]
    public void GetValue_WithNullValue_ReturnsNull()
    {
        var formatter = new PostcodeFormatter(null);
        Assert.IsNull(formatter.GetValue());
    }

    [TestCase("EC1A1BB", ExpectedResult = "EC1A 1BB")]
    [TestCase("M11AE", ExpectedResult = "M1 1AE")]
    [TestCase("B338TH", ExpectedResult = "B33 8TH")]
    [TestCase("CR26XH", ExpectedResult = "CR2 6XH")]
    [TestCase("DN551PT", ExpectedResult = "DN55 1PT")]
    public string? GetValue_WithValidPostcodeWithoutSpace_ReturnsFormattedPostcode(string postcode)
    {
        var formatter = new PostcodeFormatter(postcode);
        return formatter.GetValue();
    }

    [TestCase("EC1A 1BB", ExpectedResult = "EC1A 1BB")]
    [TestCase("M1 1AE", ExpectedResult = "M1 1AE")]
    public string? GetValue_WithValidPostcodeWithSpace_ReturnsFormattedPostcode(string postcode)
    {
        var formatter = new PostcodeFormatter(postcode);
        return formatter.GetValue();
    }

    [TestCase("ABCDE", ExpectedResult = "ABCDE")]
    [TestCase("12345", ExpectedResult = "12345")]
    public string? GetValue_WithInvalidPostcode_ReturnsNull(string postcode)
    {
        var formatter = new PostcodeFormatter(postcode);
        return formatter.GetValue();
    }

    [TestCase("ZZZ999", ExpectedResult = "ZZZ999")]
    public string? GetValue_WithNonUKFormatPostcode_ReturnsNull(string postcode)
    {
        var formatter = new PostcodeFormatter(postcode);
        return formatter.GetValue();
    }
}