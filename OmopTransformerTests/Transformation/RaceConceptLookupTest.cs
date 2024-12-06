using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmopTransformer.Transformation;
using System.Collections.Generic;

namespace OmopTransformerTests.Transformation
{
	[TestClass]
	public class RaceLookupTests
	{
		private RaceConceptLookup _raceConceptLookup;
		private RaceSourceConceptLookup _raceSourceConceptLookup;

		[TestInitialize]
		public void Setup()
		{
			_raceConceptLookup = new RaceConceptLookup();
			_raceSourceConceptLookup = new RaceSourceConceptLookup();
		}

		[TestMethod]
		public void RaceConceptLookup_ValidKey_ReturnsCorrectValueWithNote()
		{
			// Arrange
			const string key = "A"; // White - British
			const string expectedValue = "8527";
			const string expectedNote = "White - British";

			// Act
			var result = _raceConceptLookup.Mappings[key];

			// Assert
			Assert.AreEqual(expectedValue, result.Value);
			Assert.AreEqual(expectedNote, result.Notes);
		}

		[TestMethod]
		public void RaceConceptLookup_MissingKey_ThrowsKeyNotFoundException()
		{
			// Arrange
			const string invalidKey = "InvalidKey";

			// Act & Assert
			Assert.ThrowsException<KeyNotFoundException>(() => _ = _raceConceptLookup.Mappings[invalidKey]);
		}

		[TestMethod]
		public void RaceConceptLookup_EmptyMapping_ReturnsEmptyValueWithNote()
		{
			// Arrange
			const string key = "Z"; // Not stated
			const string expectedValue = "0";
			const string expectedNote = "Not stated";

			// Act
			var result = _raceConceptLookup.Mappings[key];

			// Assert
			Assert.AreEqual(expectedValue, result.Value);
			Assert.AreEqual(expectedNote, result.Notes);
		}

		[TestMethod]
		public void RaceSourceConceptLookup_EmptyMapping_ReturnsEmptyValueWithNote()
		{
			// Arrange
			const string key = "S"; // Other Ethnic Groups - Any other ethnic group
			const string expectedValue = "";
			const string expectedNote = "Other Ethnic Groups - Any other ethnic group";

			// Act
			var result = _raceSourceConceptLookup.Mappings[key];

			// Assert
			Assert.AreEqual(expectedValue, result.Value);
			Assert.AreEqual(expectedNote, result.Notes);
		}

		[TestMethod]
		public void RaceConceptLookup_CompareMappingsForAlignment()
		{
			// Arrange
			const string key = "A"; // White - British
			var raceConcept = _raceConceptLookup.Mappings[key];
			var raceSourceConcept = _raceSourceConceptLookup.Mappings[key];

			// Assert
			Assert.AreEqual(raceConcept.Notes, raceSourceConcept.Notes);
		}

		[TestMethod]
		public void RaceConceptLookup_ColumnNotes_ReturnsExpectedNotes()
		{
			// Arrange
			var expectedNotes = new[]
			{
				"[NHS Race (i.e.Ethnicity)](https://www.datadictionary.nhs.uk/data_elements/ethnic_category.html)",
				"[OMOP Race](https://athena.ohdsi.org/search-terms/terms?conceptClass=Race&invalidReason=Valid&vocabulary=Race&page=1&pageSize=50&query=)",
				@"[D, E, F, G Race mapping](https://forums.ohdsi.org/t/mapping-nhs-ethnic-category-to-omop-race/20883/2)"
			};

			// Act
			var result = _raceConceptLookup.ColumnNotes;

			// Assert
			CollectionAssert.AreEqual(expectedNotes, result);
		}

	}
}
