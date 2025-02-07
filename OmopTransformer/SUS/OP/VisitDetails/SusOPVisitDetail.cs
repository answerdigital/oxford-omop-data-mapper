using OmopTransformer.Annotations;
using OmopTransformer.Omop.VisitDetail;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.OP.VisitDetails;

[Notes(
    "Assumptions",
    "* `Emergency` covers a visit to A&E within the given Hospital Provider, and hence covers Admission Code 21 and 24 only",
    "* `Location Class` ID 24 is a Consultant Clinic within the Health Care Provider.",
    "* `Patient Classification` ID 1 is the only entry that covers 24 hours or more with the use of a bed, and whilst others may be a day/night only, they will be discounted because they are less than 24 hours. Also, maternity is also not taken as an `Inpatient` visit.",
    "* No calculations to be made between Start and end visit date to try to calculate 24 hours, but instead the `Patient Classification` will be sufficient")]
internal class SusOPVisitDetail : OmopVisitDetail<SusOPVisitDetailsRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [CopyValue(nameof(Source.SUSgeneratedspellID))]
    public override string? HospitalProviderSpellNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.VisitStartDate))]
    public override DateTime? visit_detail_start_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.VisitStartDate), nameof(Source.VisitStartTime))]
    public override DateTime? visit_detail_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.VisitEndDate))]
    public override DateTime? visit_detail_end_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.VisitEndDate), nameof(Source.VisitEndTime))]
    public override DateTime? visit_detail_end_datetime { get; set; }

    [CopyValue(nameof(Source.VisitOccurrenceConceptId))]
    public override int? visit_detail_concept_id { get; set; }

    [CopyValue(nameof(Source.VisitTypeConceptId))]
    public override int? visit_detail_type_concept_id { get; set; }

    [CopyValue(nameof(Source.SourceofAdmissionCode))]
    public override string? admitted_from_source_value { get; set; }

}