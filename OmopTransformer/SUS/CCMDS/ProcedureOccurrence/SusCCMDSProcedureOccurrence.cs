using OmopTransformer.Annotations;
using OmopTransformer.Omop.ProcedureOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.CCMDS.ProcedureOccurrence;

internal class SusCCMDSProcedureOccurrence : OmopProcedureOccurrence<SusCCMDSProcedureOccurrenceRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(StandardProcedureConceptSelector), useOmopTypeAsSource: true, nameof(procedure_source_concept_id))]
    public override int? procedure_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.ProcedureOccurrenceStartDate))]
    public override DateTime? procedure_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.ProcedureOccurrenceStartDate), nameof(Source.ProcedureOccurrenceStartTime))]
    public override DateTime? procedure_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.ProcedureOccurrenceEndDate))]
    public override DateTime? procedure_end_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.ProcedureOccurrenceEndDate), nameof(Source.ProcedureOccurrenceEndTime))]
    public override DateTime? procedure_end_datetime { get; set; }

    [ConstantValue(32818, "`EHR Administration record`")]
    public override int? procedure_type_concept_id { get; set; }

    [CopyValue(nameof(Source.ProcedureSourceValue))]
    public override string? procedure_source_value { get; set; }

    [Transform(typeof(NhsCriticalCareActivityCodeLookup), nameof(Source.ProcedureSourceValue))]
    public override int? procedure_source_concept_id { get; set; }

    [CopyValue(nameof(Source.GeneratedRecordIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }
}