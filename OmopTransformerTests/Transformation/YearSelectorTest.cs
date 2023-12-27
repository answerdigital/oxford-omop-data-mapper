using JetBrains.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformerTests.Transformation;

[TestClass]
[TestSubject(typeof(YearSelector))]
public class YearSelectorTest
{
    [TestMethod]
    public void GetValue_WithNullDate_ReturnsNull()
    {
        // Arrange
        var yearSelector = new YearSelector(null);

        // Act
        var result = yearSelector.GetValue();

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void GetValue_WithEmptyDate_ReturnsNull()
    {
        // Arrange
        var yearSelector = new YearSelector(string.Empty);

        // Act
        var result = yearSelector.GetValue();

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void GetValue_WithValidDate_ReturnsYear()
    {
        // Arrange
        var yearSelector = new YearSelector("2022-01-01");

        // Act
        var result = yearSelector.GetValue();

        // Assert
        Assert.AreEqual(2022, result);
    }

    [TestMethod]
    public void GetValue_WithValidDateNoDashes_ReturnsYear()
    {
        // Arrange
        var yearSelector = new YearSelector("20220101");

        // Act
        var result = yearSelector.GetValue();

        // Assert
        Assert.AreEqual(2022, result);
    }

    [TestMethod]
    public void GetValue_WithInvalidDate_IsNull()
    {
        // Arrange
        var yearSelector = new YearSelector("invalid-date");

        // Act
        Assert.IsNull(yearSelector.GetValue());
    }
}