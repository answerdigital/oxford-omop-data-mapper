using OmopTransformer.Annotations;
using OmopTransformer.Omop.VisitOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordGP.VisitOccurrence;

internal class OxfordGPVisitOccurrence : OmopVisitOccurrence<OxfordGPVisitOccurrenceRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? NhsNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EventDate))]
    public override DateTime? visit_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EventDate))]
    public override DateTime? visit_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EventDate))]
    public override DateTime? visit_end_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EventDate))]
    public override DateTime? visit_end_datetime { get; set; }

    [ConstantValue(9202, "`Outpatient Visit`")] 
    public override int? visit_concept_id { get; set; }

    [ConstantValue(32818, "`EHR administration record`")]
    public override int? visit_type_concept_id { get; set; }


    [CopyValue(nameof(Source.GPEventsPrimaryKey))]
    public override string? RecordConnectionIdentifier { get; set; }
}