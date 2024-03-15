using NUnit.Framework;
using OmopTransformer;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace OmopTransformerTests;

[TestFixture]
public class HistologyTopographyConverterTests
{
    [Test]
    public void ConvertHistologyTopographyToICDO3_BothInputsAreNull_ReturnsNull()
    {
        var result = Icdo3Resolver.CovertHistologyTopographyToICDO3(null, null);
        Assert.IsNull(result);
    }

    [Test]
    public void ConvertHistologyTopographyToICDO3_HistologyIsNull_ReturnsNull()
    {
        var result = Icdo3Resolver.CovertHistologyTopographyToICDO3(null, "C18.7");
        Assert.IsNull(result);
    }

    [Test]
    public void ConvertHistologyTopographyToICDO3_TopographyIsNull_ReturnsNull()
    {
        var result = Icdo3Resolver.CovertHistologyTopographyToICDO3("M84803", null);
        Assert.IsNull(result);
    }

    [Test]
    [TestCase("M84803", "C18.7", ExpectedResult = "8480/3-C18.7")]
    [TestCase("M80103", "C18.7", ExpectedResult = "8010/3-C18.7")]
    public string ConvertHistologyTopographyToICDO3_ValidInputs_ReturnsFormattedString(string histology, string topography)
    {
        return Icdo3Resolver.CovertHistologyTopographyToICDO3(histology, topography);
    }

    [Test]
    [TestCase("M80103", ExpectedResult = "8010/3")]
    [TestCase("M81403", ExpectedResult = "8140/3")]
    public string TrimHistology_ValidInput_ReturnsTrimmedHistology(string histology)
    {
        // Assuming TrimHistology is made internal or public for testing purposes
        return Icdo3Resolver.TrimHistology(histology);
    }
}