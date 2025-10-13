using OmopTransformer.Annotations;
using OmopTransformer.Omop.VisitOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT.VisitOccurrence;

[Notes(
    "Assumptions",
    "* SACT Data has the following definition for the Administration Timestamp:",
    "* i) For recording the date and time when the anti-cancer drug was administered to a patient (an infusion commenced)",
    "* ii) For recording continuous oral chemotherapy, the administration date will be the first day of the nominal cycle, or the date on which an oral drug was dispensed to the patient.",
    "* The assumption made is that all the drugs were administered in a Cancer clinic as we have no way of identifying if an oral drug was taken at home")]
internal class SactVisitOccurrence : OmopVisitOccurrence<SactVisitOccurrenceRecord>
{
    [CopyValue(nameof(Source.NHS_Number))]
    public override string? NhsNumber { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Administration_date))]
    public override DateTime? visit_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Administration_date))]
    public override DateTime? visit_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Administration_date))]
    public override DateTime? visit_end_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Administration_date))]
    public override DateTime? visit_end_datetime { get; set; }

    [ConstantValue(38004268, "`Oncology Clinic/Center`")]
    public override int? visit_concept_id { get; set; }

    [ConstantValue(32818, "`EHR administration record`")]
    public override int? visit_type_concept_id { get; set; }

}