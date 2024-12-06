using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmopTransformer.Transformation;
using System.Collections.Generic;

namespace OmopTransformerTests.Transformation
{
	[TestClass]
	public class GradeDifferentiationLookupTests
	{
		private GradeDifferentiationLookup _lookup;

		[TestInitialize]
		public void Setup()
		{
			_lookup = new GradeDifferentiationLookup();
		}

		[TestMethod]
		public void GetMapping_ValidKey_ReturnsCorrectValueWithNote()
		{
			// Arrange
			var expectedValue = "36770626";
			var expectedNote = "Grade 2: Moderately differentiated";

			// Act
			var result = _lookup.Mappings["G2"];

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
		public void GetMapping_GX_ReturnsCorrectValueWithNote()
		{
			// Arrange
			var expectedValue = "4054711";
			var expectedNote = "GX grade";

			// Act
			var result = _lookup.Mappings["GX"];

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(expectedValue, result.Value);
			Assert.AreEqual(expectedNote, result.Notes);
		}

		[DataTestMethod]
		[DataRow("G1", "36768162", "Grade 1: Well differentiated")]
		[DataRow("G3", "36769666", "Grade 3: Poorly differentiated")]
		[DataRow("G4", "36769737", "Grade 4: Undifferentiated")]
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
			var expectedNotes = new[]
			{
				"[OMOP Grade Differentiation](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&conceptClass=Histopattern&page=1&pageSize=500&query=grade&boosts)",
				"[NHS - Grade of Differentiation (At Diagnosis)](https://www.datadictionary.nhs.uk/data_elements/grade_of_differentiation__at_diagnosis_.html?hl=grade%2Cdifferentiation)"
			};

			// Act
			var columnNotes = _lookup.ColumnNotes;

			// Assert
			Assert.IsNotNull(columnNotes);
			Assert.AreEqual(expectedNotes.Length, columnNotes.Length);
			CollectionAssert.AreEqual(expectedNotes, columnNotes);
		}
	}
}
