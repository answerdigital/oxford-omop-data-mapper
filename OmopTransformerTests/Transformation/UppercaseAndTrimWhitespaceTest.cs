using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmopTransformer.Transformation;

namespace OmopTransformerTests.Transformation
{
	[TestClass]
	public class UppercaseAndTrimWhitespaceTests
	{
		[TestMethod]
		public void GetValue_NullInput_ReturnsNull()
		{
			// Arrange
			var transformer = new UppercaseAndTrimWhitespace(null);

			// Act
			var result = transformer.GetValue();

			// Assert
			Assert.IsNull(result);
		}

		[TestMethod]
		public void GetValue_EmptyInput_ReturnsEmptyString()
		{
			// Arrange
			var transformer = new UppercaseAndTrimWhitespace(string.Empty);

			// Act
			var result = transformer.GetValue();

			// Assert
			Assert.AreEqual(string.Empty, result);
		}

		[TestMethod]
		public void GetValue_WhitespaceInput_ReturnsEmptyString()
		{
			// Arrange
			var transformer = new UppercaseAndTrimWhitespace("    ");

			// Act
			var result = transformer.GetValue();

			// Assert
			Assert.AreEqual(string.Empty, result);
		}

		[TestMethod]
		public void GetValue_ValidInput_ReturnsTrimmedUppercaseString()
		{
			// Arrange
			var transformer = new UppercaseAndTrimWhitespace("  hello world  ");

			// Act
			var result = transformer.GetValue();

			// Assert
			Assert.AreEqual("HELLO WORLD", result);
		}

		[TestMethod]
		public void GetValue_InputWithMixedCase_ReturnsUppercaseTrimmedString()
		{
			// Arrange
			var transformer = new UppercaseAndTrimWhitespace("  TeStInG MiXeD CaSe  ");

			// Act
			var result = transformer.GetValue();

			// Assert
			Assert.AreEqual("TESTING MIXED CASE", result);
		}

		[TestMethod]
		public void GetValue_InputWithSpecialCharacters_ReturnsUppercaseTrimmedString()
		{
			// Arrange
			var transformer = new UppercaseAndTrimWhitespace("  !@#$%^&*()_+abcXYZ  ");

			// Act
			var result = transformer.GetValue();

			// Assert
			Assert.AreEqual("!@#$%^&*()_+ABCXYZ", result);
		}
	}
}
