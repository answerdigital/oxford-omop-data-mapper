using OmopTransformer.Annotations;
using OmopTransformer.Omop.VisitDetail;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS.VisitDetails;

internal class CdsVisitDetail : OmopVisitDetail<CdsVisitDetailsRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [CopyValue(nameof(Source.RecordConnectionIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }

    [CopyValue(nameof(Source.HospitalProviderSpellNumber))]
    public override int? HospitalProviderSpellNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.VisitStartDate))]
    public override DateTime? visit_detail_start_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.VisitStartDate), nameof(Source.VisitStartTime))]
    public override DateTime? visit_detail_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.VisitEndDate))]
    public override DateTime? visit_detail_end_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.VisitEndDate), nameof(Source.VisitEndTime))]
    public override DateTime? visit_detail_end_datetime { get; set; }

    [CopyValue(nameof(Source.VisitOccurenceConceptId))]
    public override int? visit_detail_concept_id { get; set; }

    [CopyValue(nameof(Source.VisitTypeConceptId))]
    public override int? visit_detail_type_concept_id { get; set; }
}