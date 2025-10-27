using OmopTransformer;

[TestClass]
public class StringExtensionsTests
{

    [TestMethod]
    public void SubstringOrNull_ValidInput_ReturnsCorrectSubstring()
    {
        string text = "Hello World";
        var result = text.SubstringOrNull(1, 5);
        Assert.AreEqual("ello", result);
    }

    [TestMethod]
    public void SubstringOrNull_WhitespaceOnly_ReturnsNull()
    {
        string text = "    ";
        var result = text.SubstringOrNull(1, 2);
        Assert.IsNull(result);
    }

    [TestMethod]
    public void SubstringOrNull_NullInput_ThrowsArgumentNullException()
    {
        string? text = null;

        Assert.ThrowsExactly<ArgumentNullException>(() => text!.SubstringOrNull(0, 1));
    }

    [TestMethod]
    [DataRow("", true)]
    [DataRow("   ", true)]
    [DataRow("hello", false)]
    [DataRow(" hello ", false)]
    public void IsEmpty_ReturnsExpectedResult(string input, bool expected)
    {
        Assert.AreEqual(expected, input.IsEmpty());
    }

    [TestMethod]
    [DataRow("  test  ", "test")]
    [DataRow(null, null)]
    [DataRow("", "")]
    public void TrimWhitespace_ReturnsExpectedResult(string input, string expected)
    {
        Assert.AreEqual(expected, input.TrimWhitespace());
    }

    [TestMethod]
    [DataRow("hello\r\n", "hello")]
    [DataRow("\r\nhello\r\n", "\r\nhello")]
    [DataRow("hello\r\nworld", "hello\r\nworld")]
    [DataRow(null, null)]
    [DataRow("", null)]
    [DataRow("\r\n", null)]
    public void GetTrimmedValueOrNull_ReturnsExpectedResult(string input, string expected)
    {
        Assert.AreEqual(expected, input.GetTrimmedValueOrNull());
    }
}