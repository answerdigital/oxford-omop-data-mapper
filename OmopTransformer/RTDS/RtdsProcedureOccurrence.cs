using OmopTransformer.Annotations;
using OmopTransformer.Omop.ProcedureOccurrence;
using OmopTransformer.RTDS.Attendances;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS;

internal class RtdsProcedureOccurrence : OmopProcedureOccurrence<RtdsAttendances>
{
    [CopyValue(nameof(Source.PatientId))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(StandardProcedureConceptSelector), useOmopTypeAsSource: true, nameof(procedure_source_concept_id))]
    public override int[]? procedure_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.ActualStartDateTime_s))]
    public override DateTime? procedure_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.ActualEndDateTime_s))]
    public override DateTime? procedure_end_datetime { get; set; }

    [ConstantValue(32818, "`EHR Administration record`")]
    public override int? procedure_type_concept_id { get; set; }

    [CopyValue(nameof(Source.ProcedureCode))]
    public override string? procedure_source_value { get; set; }

    [Transform(typeof(Opcs4Selector), nameof(Source.ProcedureCode))]
    public override int? procedure_source_concept_id { get; set; }
}