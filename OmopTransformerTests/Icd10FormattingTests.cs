using NUnit.Framework;
using OmopTransformer;

namespace OmopTransformerTests;

[TestFixture]
public class Icd10FormattingTests
{
    [TestCase("I10", ExpectedResult = "I10")]
    [TestCase("J449", ExpectedResult = "J449")]
    [TestCase("R51X", ExpectedResult = "R51")]
    [TestCase("E112D", ExpectedResult = "E112")]
    public object? TextIcd10CodeIsFormattedCorrectly(string code) => Icd10Resolver.TrimIcd10(code);
}
