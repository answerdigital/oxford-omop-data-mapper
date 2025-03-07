using OmopTransformer.Annotations;
using OmopTransformer.Omop.VisitDetail;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.CCMDS.VisitDetails;

internal class SusCCMDSVisitDetail : OmopVisitDetail<SusCCMDSVisitDetailsRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }
    
    [CopyValue(nameof(Source.HospitalProviderSpellNumber))]
    public override string? HospitalProviderSpellNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.VisitStartDate))]
    public override DateTime? visit_detail_start_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.VisitStartDate), nameof(Source.VisitStartTime))]
    public override DateTime? visit_detail_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.VisitEndDate))]
    public override DateTime? visit_detail_end_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.VisitEndDate), nameof(Source.VisitEndTime))]
    public override DateTime? visit_detail_end_datetime { get; set; }

    [ConstantValue(581379, "`Inpatient Critical Care Facility`")] 
    public override int? visit_detail_concept_id { get; set; }

    [ConstantValue(32818, "`EHR administration record`")]
    public override int? visit_detail_type_concept_id { get; set; }
}