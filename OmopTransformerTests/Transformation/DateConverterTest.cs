using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmopTransformer.Transformation;
using System;

namespace OmopTransformerTests.Transformation;

[TestClass]
[TestSubject(typeof(DateConverter))]
public class DateConverterTest
{
    [TestMethod]
    public void GetValue_NullDate_ReturnsNull()
    {
        // Arrange
        var dateConverter = new DateConverter(null);

        // Act
        var result = dateConverter.GetValue();

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void GetValue_EmptyDate_ReturnsNull()
    {
        // Arrange
        var dateConverter = new DateConverter(string.Empty);

        // Act
        var result = dateConverter.GetValue();

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void GetValue_ValidDate_ReturnsDateTime()
    {
        // Arrange
        var dateConverter = new DateConverter("2022-01-01");

        // Act
        var result = dateConverter.GetValue();

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(DateTime));
        Assert.AreEqual(new DateTime(2022, 1, 1), result);
    }

    [TestMethod]
    public void GetValue_InvalidDate_ReturnsNull()
    {
        // Arrange
        var dateConverter = new DateConverter("invalid date");

        // Act
        var result = dateConverter.GetValue();

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void GetValue_DateInDifferentFormat_ReturnsDateTime()
    {
        // Arrange
        var dateConverter = new DateConverter("20220101");

        // Act
        var result = dateConverter.GetValue();

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(DateTime));
        Assert.AreEqual(new DateTime(2022, 1, 1), result);
    }

    [TestMethod]
    public void GetValue_DateInDDMMYYYYFormat_ReturnsDateTime()
    {
        // Arrange
        var dateConverter = new DateConverter("23/05/2023");

        // Act
        var result = dateConverter.GetValue();

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(DateTime));
        Assert.AreEqual(new DateTime(2023, 5, 23), result);
    }
}