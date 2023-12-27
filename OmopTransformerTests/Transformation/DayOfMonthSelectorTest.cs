using JetBrains.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformerTests.Transformation
{
    [TestClass]
    [TestSubject(typeof(DayOfMonthSelector))]
    public class DayOfMonthSelectorTest
    {
        [TestMethod]
        public void GetValue_ValidDateFormat_ReturnsDay()
        {
            // Arrange
            var daySelector = new DayOfMonthSelector("2022-03-01");

            // Act
            var result = daySelector.GetValue();

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetValue_ValidDateFormatWithTime_ReturnsDay()
        {
            // Arrange
            var daySelector = new DayOfMonthSelector("2022-03-01T12:00:00");

            // Act
            var result = daySelector.GetValue();

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetValue_ValidExactDateFormat_ReturnsDay()
        {
            // Arrange
            var daySelector = new DayOfMonthSelector("20220301");

            // Act
            var result = daySelector.GetValue();

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetValue_InvalidDateFormat_ReturnsNull()
        {
            // Arrange
            var daySelector = new DayOfMonthSelector("invalid date");

            // Act
            var result = daySelector.GetValue();

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetValue_NullDate_ReturnsNull()
        {
            // Arrange
            var daySelector = new DayOfMonthSelector(null);

            // Act
            var result = daySelector.GetValue();

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetValue_EmptyDate_ReturnsNull()
        {
            // Arrange
            var daySelector = new DayOfMonthSelector(string.Empty);

            // Act
            var result = daySelector.GetValue();

            // Assert
            Assert.IsNull(result);
        }
    }
}