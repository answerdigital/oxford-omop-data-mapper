using JetBrains.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformerTests.Transformation;

[TestClass]
[TestSubject(typeof(TimeParser))]
public class TimeParserTest
{
    [TestMethod]
    public void GetValue_NullTime_ReturnsNull()
    {
        // Arrange
        var dateConverter = new TimeParser(null);

        // Act
        var result = dateConverter.GetAsTime();

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void GetValue_EmptyTime_ReturnsNull()
    {
        // Arrange
        var dateConverter = new TimeParser(string.Empty);

        // Act
        var result = dateConverter.GetAsTime();

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void GetValue_ValidTime_ReturnsTime()
    {
        // Arrange
        var timeParser = new TimeParser("122233");

        // Act
        var result = timeParser.GetAsTime();

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(TimeSpan));
        Assert.AreEqual(new TimeSpan(12, 22, 33), result);
    }

    [TestMethod]
    public void GetValue_ValidColonSeparatedTime_ReturnsTime()
    {
        // Arrange
        var timeParser = new TimeParser("12:22:33");

        // Act
        var result = timeParser.GetAsTime();

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(TimeSpan));
        Assert.AreEqual(new TimeSpan(12, 22, 33), result);
    }

    [TestMethod]
    public void GetValue_InvalidDate_ReturnsNull()
    {
        // Arrange
        var timeParser = new TimeParser("invalid date");

        // Act
        var result = timeParser.GetAsTime();

        // Assert
        Assert.IsNull(result);
    }
}