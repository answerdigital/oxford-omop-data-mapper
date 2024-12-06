using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmopTransformer.Transformation;

namespace OmopTransformerTests.Transformation;

[TestClass]
[TestSubject(typeof(DataDictionaryBasisOfDiagnosisCancerLookup))]
public class DataDictionaryBasisOfDiagnosisCancerLookupTests
{
	[TestMethod]
	public void GetMapping_ValidKey_ReturnsCorrectValueWithNote()
	{
		// Arrange
		var lookup = new DataDictionaryBasisOfDiagnosisCancerLookup();

		// Act
		var value = lookup.Mappings["1"]; // Preliminary diagnosis

		// Assert
		Assert.IsNotNull(value);
		Assert.AreEqual("32899", value.Value);
		Assert.AreEqual("Preliminary diagnosis", value.Notes);
	}

	[TestMethod]
	public void GetMapping_InvalidKey_ReturnsNull()
	{
		// Arrange
		var lookup = new DataDictionaryBasisOfDiagnosisCancerLookup();

		// Act
		var exists = lookup.Mappings.TryGetValue("InvalidKey", out var value);

		// Assert
		Assert.IsFalse(exists);
		Assert.IsNull(value);
	}

	[TestMethod]
	public void GetMapping_EmptyValueKey_ReturnsEmptyValueWithNote()
	{
		// Arrange
		var lookup = new DataDictionaryBasisOfDiagnosisCancerLookup();

		// Act
		var value = lookup.Mappings["9"]; // Empty ValueWithNote

		// Assert
		Assert.IsNotNull(value);
		Assert.AreEqual("", value.Value);
		Assert.AreEqual("", value.Notes);
	}

	[TestMethod]
	public void GetMapping_KeysWithSameValue_ReturnSameValueWithNote()
	{
		// Arrange
		var lookup = new DataDictionaryBasisOfDiagnosisCancerLookup();

		// Act
		var value1 = lookup.Mappings["1"]; // Preliminary diagnosis
		var value2 = lookup.Mappings["2"]; // Preliminary diagnosis

		// Assert
		Assert.IsNotNull(value1);
		Assert.IsNotNull(value2);
		Assert.AreEqual(value1.Value, value2.Value);
		Assert.AreEqual(value1.Notes, value2.Notes);
	}

	[TestMethod]
	public void ColumnNotes_ReturnsExpectedArray()
	{
		// Arrange
		var lookup = new DataDictionaryBasisOfDiagnosisCancerLookup();

		// Act
		var columnNotes = lookup.ColumnNotes;

		// Assert
		Assert.IsNotNull(columnNotes);
		Assert.AreEqual(2, columnNotes.Length);
		Assert.AreEqual("[OMOP Condition Status](https://athena.ohdsi.org/search-terms/terms?domain=Condition+Status&standardConcept=Standard&page=1&pageSize=50&query=)", columnNotes[0]);
		Assert.AreEqual("[NHS Basis of Diagnosis of Cancer](https://www.datadictionary.nhs.uk/attributes/basis_of_diagnosis_for_cancer.html?hl=basis%2Cdiagnosis%2Ccancer)", columnNotes[1]);
	}
}
