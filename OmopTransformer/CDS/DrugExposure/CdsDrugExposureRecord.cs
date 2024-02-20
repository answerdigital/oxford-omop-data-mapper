using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.DrugExposure;

[DataOrigin("CDS")]
[Description("CDS Drug Exposure")]
[SourceQuery("CdsDrugExposure.xml")]
internal class CdsDrugExposureRecord
{
    public string? RecordConnectionIdentifier { get; set; }
    public string? nhs_number { get; set; }
    public string? DrugSourceValue { get; set; }
    public string? ExposureStartDate { get; set; }
    public string? ExposureEndDate { get; set; }
    public int? DrugTypeConceptId { get; set; }
}   