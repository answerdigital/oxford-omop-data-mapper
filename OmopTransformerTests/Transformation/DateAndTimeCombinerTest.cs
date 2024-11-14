using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmopTransformer.Transformation;
using System;

namespace OmopTransformerTests.Transformation;

[TestClass]
[TestSubject(typeof(DateAndTimeCombiner))]
public class DateAndTimeCombinerTests
{
	[TestMethod]
	public void GetValue_ValidDateAndTime_ReturnsCombinedDateTime()
	{
		// Arrange
		var combiner = new DateAndTimeCombiner("2022-01-01", "123456");

		// Act
		var result = combiner.GetValue();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsInstanceOfType(result, typeof(DateTime));
		Assert.AreEqual(new DateTime(2022, 1, 1, 12, 34, 56), result);
	}

	[TestMethod]
	public void GetValue_NullDate_ReturnsNull()
	{
		// Arrange
		var combiner = new DateAndTimeCombiner(null, "123456");

		// Act
		var result = combiner.GetValue();

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetValue_EmptyDate_ReturnsNull()
	{
		// Arrange
		var combiner = new DateAndTimeCombiner("", "123456");

		// Act
		var result = combiner.GetValue();

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetValue_InvalidDate_ReturnsNull()
	{
		// Arrange
		var combiner = new DateAndTimeCombiner("invalid-date", "123456");

		// Act
		var result = combiner.GetValue();

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetValue_NullTime_ReturnsNull()
	{
		// Arrange
		var combiner = new DateAndTimeCombiner("2022-01-01", null!);

		// Act
		var result = combiner.GetValue();

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetValue_EmptyTime_ReturnsNull()
	{
		// Arrange
		var combiner = new DateAndTimeCombiner("2022-01-01", "");

		// Act
		var result = combiner.GetValue();

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetValue_InvalidTime_ReturnsNull()
	{
		// Arrange
		var combiner = new DateAndTimeCombiner("2022-01-01", "invalid-time");

		// Act
		var result = combiner.GetValue();

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetValue_BothDateAndTimeNull_ReturnsNull()
	{
		// Arrange
		var combiner = new DateAndTimeCombiner(null, null!);

		// Act
		var result = combiner.GetValue();

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetValue_BothDateAndTimeValidWithLeadingZero_ReturnsCombinedDateTime()
	{
		// Arrange
		var combiner = new DateAndTimeCombiner("2022-01-01", "011234");

		// Act
		var result = combiner.GetValue();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsInstanceOfType(result, typeof(DateTime));
		Assert.AreEqual(new DateTime(2022, 1, 1, 1, 12, 34), result);
	}
}
