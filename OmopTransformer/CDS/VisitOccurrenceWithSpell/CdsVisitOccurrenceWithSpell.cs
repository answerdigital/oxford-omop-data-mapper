using OmopTransformer.Annotations;
using OmopTransformer.Omop.VisitOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS.VisitOccurrenceWithSpell;

internal class CdsVisitOccurrenceWithSpell : OmopVisitOccurrence<CdsVisitOccurrenceWithSpellRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? NhsNumber { get; set; }

    [Transform(typeof(NumberParser), nameof(Source.HospitalProviderSpellNumber))]
    public override int? HospitalProviderSpellNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EpisodeStartDate))]
    public override DateTime? visit_start_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.EpisodeStartDate), nameof(Source.EpisodeStartTime))]
    public override DateTime? visit_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EpisodeEndDate))]
    public override DateTime? visit_end_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.EpisodeEndDate), nameof(Source.EpisodeEndTime))]
    public override DateTime? visit_end_datetime { get; set; }

    [CopyValue(nameof(Source.VisitOccurenceConceptId))]
    public override int? visit_concept_id { get; set; }

    [CopyValue(nameof(Source.VisitTypeConceptId))]
    public override int? visit_type_concept_id { get; set; }
}