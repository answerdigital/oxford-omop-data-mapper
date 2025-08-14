using OmopTransformer.Annotations;
using OmopTransformer.Omop.VisitDetail;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS.VisitDetails;

[Notes(
    "Assumptions",
    "* `Emergency` covers a visit to A&E within the given Hospital Provider, and hence covers Admission Code 21 and 24 only",
    "* `Location Class` ID 24 is a Consultant Clinic within the Health Care Provider.",
    "* `Patient Classification` ID 1 is the only entry that covers 24 hours or more with the use of a bed, and whilst others may be a day/night only, they will be discounted because they are less than 24 hours. Also, maternity is also not taken as an `Inpatient` visit.",
    "* No calculations to be made between Start and end visit date to try to calculate 24 hours, but instead the `Patient Classification` will be sufficient")]
internal class RtdsVisitDetail : OmopVisitDetail<RtdsVisitDetailsRecord>
{
    [CopyValue(nameof(Source.PatientId))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_start_date))]
    public override DateTime? visit_detail_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_start_date))]
    public override DateTime? visit_detail_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_end_date))]
    public override DateTime? visit_detail_end_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_end_date))]
    public override DateTime? visit_detail_end_datetime { get; set; }

    [ConstantValue(9201, "`Inpatient Visit`")] 
    public override int? visit_detail_concept_id { get; set; }

    [ConstantValue(32818, "`EHR administration record`")]
    public override int? visit_detail_type_concept_id { get; set; }

    // [Transform(typeof(AdmittedSourceLookup), nameof(Source.SourceofAdmissionCode))]
    // public override int? admitted_from_concept_id { get; set; }

    // [CopyValue(nameof(Source.SourceofAdmissionCode))]
    // public override string? admitted_from_source_value { get; set; }

    // [Transform(typeof(DischargeDestinationLookup), nameof(Source.DischargeDestinationCode))]
    // public override int? discharged_to_concept_id { get; set; }

    // [CopyValue(nameof(Source.DischargeDestinationCode))]
    // public override string? discharged_to_source_value { get; set; }
}