using OmopTransformer.Transformation;

namespace OmopTransformerTests;

[TestClass]
public class MonthOfYearSelectorTests
{
    [TestMethod]
    public void Constructor_WithNullDateTime_ShouldSetMonthOfYearToNull()
    {
        // Arrange & Act
        var selector = new MonthOfYearSelector(null);

        // Assert
        Assert.IsNull(selector.MonthOfYear);
    }

    [TestMethod]
    public void Constructor_WithValidDateTime_ShouldSetMonthOfYearCorrectly()
    {
        // Arrange
        var dateTime = new DateTime(2023, 4, 15); // Example date

        // Act
        var selector = new MonthOfYearSelector(dateTime);

        // Assert
        Assert.AreEqual(4, selector.MonthOfYear);
    }
}