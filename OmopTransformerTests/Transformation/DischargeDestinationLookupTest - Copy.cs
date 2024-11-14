using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmopTransformer.Transformation;

namespace OmopTransformerTests
{
	[TestClass]
	public class DischargeDestinationLookupTests
	{
		private DischargeDestinationLookup _lookup;

		[TestInitialize]
		public void Setup()
		{
			_lookup = new DischargeDestinationLookup();
		}

		[TestMethod]
		public void GetMapping_ValidKey_ReturnsCorrectValueWithNote()
		{
			// Arrange
			var expectedValue = "38004284";
			var expectedNote = "Psychiatric Hospital";

			// Act
			var result = _lookup.Mappings["30"];

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(expectedValue, result.Value);
			Assert.AreEqual(expectedNote, result.Notes);
		}

		[TestMethod]
		public void GetMapping_InvalidKey_ReturnsNull()
		{
			// Arrange
			var key = "InvalidKey";

			// Act
			var exists = _lookup.Mappings.TryGetValue(key, out var result);

			// Assert
			Assert.IsFalse(exists);
			Assert.IsNull(result);
		}

		[TestMethod]
		public void GetMapping_EmptyValueKey_ReturnsEmptyValueWithNote()
		{
			// Arrange
			var expectedValue = "";
			var expectedNote = "No mapping possible";

			// Act
			var result = _lookup.Mappings["79"];

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(expectedValue, result.Value);
			Assert.AreEqual(expectedNote, result.Notes);
		}

		[DataTestMethod]
		[DataRow("48", "38004284", "Psychiatric Hospital")]
		[DataRow("49", "38004284", "Psychiatric Hospital")]
		public void GetMapping_MultipleKeys_ReturnConsistentValueWithNote(string key, string expectedValue, string expectedNote)
		{
			// Act
			var result = _lookup.Mappings[key];

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(expectedValue, result.Value);
			Assert.AreEqual(expectedNote, result.Notes);
		}

		[TestMethod]
		public void ColumnNotes_ReturnsExpectedArray()
		{
			// Arrange
			var expectedNote = "[Discharge Destination](https://www.datadictionary.nhs.uk/data_elements/discharge_destination_code__hospital_provider_spell_.html)";

			// Act
			var columnNotes = _lookup.ColumnNotes;

			// Assert
			Assert.IsNotNull(columnNotes);
			Assert.AreEqual(1, columnNotes.Length);
			Assert.AreEqual(expectedNote, columnNotes[0]);
		}
	}
}
