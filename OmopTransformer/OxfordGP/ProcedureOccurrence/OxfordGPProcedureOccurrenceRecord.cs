using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordGP.ProcedureOccurrence;

[DataOrigin("Oxford-GP")]
[Description("Oxford Procedure Occurrence")]
[SourceQuery("OxfordGPProcedureOccurrence.xml")]
internal class OxfordGPProcedureOccurrenceRecord
{
    public string? SuppliedCode { get; set; }
    public string? NHSNumber { get; set; }
    public string? EventDate { get; set; }
}