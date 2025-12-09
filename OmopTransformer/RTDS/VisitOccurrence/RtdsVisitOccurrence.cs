using OmopTransformer.Annotations;
using OmopTransformer.Omop.VisitOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS.VisitOccurrence;

internal class RtdsVisitOccurrence : OmopVisitOccurrence<RtdsVisitOccurrenceRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? NhsNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_start_date))]
    public override DateTime? visit_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_start_date))]
    public override DateTime? visit_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_end_date))]
    public override DateTime? visit_end_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_end_date))]
    public override DateTime? visit_end_datetime { get; set; }

    [ConstantValue(9201, "`Inpatient Visit`")]
    public override int? visit_concept_id { get; set; }

    [ConstantValue(32818, "`EHR administration record`")]
    public override int? visit_type_concept_id { get; set; }

}