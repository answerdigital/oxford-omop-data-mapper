using OmopTransformer.Annotations;
using OmopTransformer.Omop.VisitDetail;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.AE.VisitDetails;

[Notes(
    "Assumptions",
    "* `Emergency` covers a visit to A&E within the given Hospital Provider, and hence covers Admission Code 21 and 24 only")]
internal class SusAEVisitDetail : OmopVisitDetail<SusAEVisitDetailsRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }
    
    [CopyValue(nameof(Source.AEAttendanceNumber))]
    public override string? HospitalProviderSpellNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.VisitStartDate))]
    public override DateTime? visit_detail_start_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.VisitStartDate), nameof(Source.VisitStartTime))]
    public override DateTime? visit_detail_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.VisitEndDate))]
    public override DateTime? visit_detail_end_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.VisitEndDate), nameof(Source.VisitEndTime))]
    public override DateTime? visit_detail_end_datetime { get; set; }

    [ConstantValue(9203, "`Emergency Room Visit`")] 
    public override int? visit_detail_concept_id { get; set; }

    [ConstantValue(32818, "`EHR administration record`")]
    public override int? visit_detail_type_concept_id { get; set; }

    [Transform(typeof(AdmittedSourceLookup), nameof(Source.SourceofAdmissionCode))]
    public override int? admitted_from_concept_id { get; set; }

    [CopyValue(nameof(Source.SourceofAdmissionCode))]
    public override string? admitted_from_source_value { get; set; }

    [Transform(typeof(DischargeDestinationLookup), nameof(Source.DischargeDestinationCode))]
    public override int? discharged_to_concept_id { get; set; }

    [CopyValue(nameof(Source.DischargeDestinationCode))]
    public override string? discharged_to_source_value { get; set; }
}