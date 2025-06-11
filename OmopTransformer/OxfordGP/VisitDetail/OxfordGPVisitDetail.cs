using OmopTransformer.Annotations;
using OmopTransformer.Omop.VisitDetail;
using OmopTransformer.OxfordGP.VisitDetail;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordGP.VisitOccurrence;

internal class OxfordGPVisitDetails : OmopVisitDetail<OxfordGPVisitDetailRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EventDate))]
    public override DateTime? visit_detail_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EventDate))]
    public override DateTime? visit_detail_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EventDate))]
    public override DateTime? visit_detail_end_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EventDate))]
    public override DateTime? visit_detail_end_datetime { get; set; }

    [ConstantValue(9202, "`Outpatient Visit`")]
    public override int? visit_detail_concept_id { get; set; }

    [ConstantValue(32818, "`EHR administration record`")]
    public override int? visit_detail_type_concept_id { get; set; }

    [CopyValue(nameof(Source.GPEventsPrimaryKey))]
    public override string? RecordConnectionIdentifier { get; set; }
}