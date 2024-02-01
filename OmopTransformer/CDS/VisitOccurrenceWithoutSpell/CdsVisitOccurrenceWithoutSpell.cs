using OmopTransformer.Annotations;
using OmopTransformer.Omop.VisitOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS.VisitOccurrenceWithoutSpell;

internal class CdsVisitOccurrenceWithoutSpell : OmopVisitOccurrence<CdsVisitOccurrenceWithoutSpellRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? NhsNumber { get; set; }

    [CopyValue(nameof(Source.RecordConnectionIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EpisodeStartDate))]
    public override DateTime? visit_start_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.EpisodeStartDate), nameof(Source.EpisodeStartTime))]
    public override DateTime? visit_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EpisodeStartDate))]
    public override DateTime? visit_end_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.EpisodeEndDate), nameof(Source.EpisodeEndTime))]
    public override DateTime? visit_end_datetime { get; set; }

    [ConstantValue(9202, "`Inpatient Visit`")]
    public override int? visit_concept_id { get; set; }

    [ConstantValue(32220, "`Still Patient`")]
    public override int? visit_type_concept_id { get; set; }
}