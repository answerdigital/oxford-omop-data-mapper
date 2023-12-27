using JetBrains.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformerTests.Transformation;

[TestClass]
[TestSubject(typeof(MonthOfYearSelector))]
public class MonthOfYearSelectorTests
{
    [TestMethod]
    public void GetValue_ValidDate_ReturnsMonth()
    {
        // Arrange
        var selector = new MonthOfYearSelector("2022-12-31");

        // Act
        var result = selector.GetValue();

        // Assert
        Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void GetValue_NullDate_ReturnsNull()
    {
        // Arrange
        var selector = new MonthOfYearSelector(null);

        // Act
        var result = selector.GetValue();

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void GetValue_EmptyDate_ReturnsNull()
    {
        // Arrange
        var selector = new MonthOfYearSelector(string.Empty);

        // Act
        var result = selector.GetValue();

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void GetValue_InvalidDate_ReturnsNull()
    {
        // Arrange
        var selector = new MonthOfYearSelector("invalid-date");

        // Act
        var result = selector.GetValue();

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void GetValue_LeapYearFebruary29_Returns2()
    {
        // Arrange
        var selector = new MonthOfYearSelector("2020-02-29");

        // Act
        var result = selector.GetValue();

        // Assert
        Assert.AreEqual(2, result);
    }
}