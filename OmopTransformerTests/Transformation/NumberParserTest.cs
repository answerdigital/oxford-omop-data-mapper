using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmopTransformer.Transformation;
using System;

namespace OmopTransformerTests.Transformation;

[TestClass]
[TestSubject(typeof(NumberParser))]
public class NumberParserTest
{
    [TestMethod]
    public void GetValue_ValidIntegerText_ReturnsInteger()
    {
        // Arrange
        var numberParser = new NumberParser("123");

        // Act
        var result = numberParser.GetValue();

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(int));
        Assert.AreEqual(123, result);
    }

    [TestMethod]
    public void GetValue_NullText_ReturnsNull()
	{
		// Arrange
		var numberParser = new NumberParser(null);

		// Act
		var result = numberParser.GetValue();

		// Assert
		Assert.IsNull(result);
    }

    [TestMethod]
    public void GetValue_InvalidText_ReturnsNull()
	{
		// Arrange
		var numberParser = new NumberParser("abc");

		// Act
		var result = numberParser.GetValue();

		// Assert
		Assert.IsNull(result);
	}

    [TestMethod]
    public void GetValue_EmptyText_ReturnsNull()
	{
		// Arrange
		var numberParser = new NumberParser(string.Empty);

		// Act
		var result = numberParser.GetValue();

		// Assert
		Assert.IsNull(result);
    }

    [TestMethod]
    public void GetValue_ValidNegativeIntegerText_ReturnsInteger()
	{
		// Arrange
		var numberParser = new NumberParser("-456");

		// Act
		var result = numberParser.GetValue();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsInstanceOfType(result, typeof(int));
		Assert.AreEqual(-456, result);
	}


	[TestMethod]
	public void GetValue_ValidZeroText_ReturnsInteger()
	{
		// Arrange
		var numberParser = new NumberParser("0");

		// Act
		var result = numberParser.GetValue();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsInstanceOfType(result, typeof(int));
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void GetValue_ValidLargeIntegerText_ReturnsInteger()
	{
		// Arrange
		var numberParser = new NumberParser("2147483647"); // Max int value

		// Act
		var result = numberParser.GetValue();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsInstanceOfType(result, typeof(int));
		Assert.AreEqual(2147483647, result);
	}

	[TestMethod]
	public void GetValue_OverflowIntegerText_ReturnsNull()
	{
		// Arrange
		var numberParser = new NumberParser("2147483648"); // Overflow int value

		// Act
		var result = numberParser.GetValue();

		// Assert
		Assert.IsNull(result);
	}
}