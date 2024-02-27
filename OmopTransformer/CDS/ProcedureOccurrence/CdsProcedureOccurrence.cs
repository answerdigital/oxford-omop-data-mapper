using OmopTransformer.Annotations;
using OmopTransformer.Omop.ProcedureOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS.ProcedureOccurrence;

internal class CdsProcedureOccurrence : OmopProcedureOccurrence<CdsProcedureOccurrenceRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(SnomedSelector), useOmopTypeAsSource: true, nameof(procedure_source_concept_id))]
    public override int[]? procedure_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.PrimaryProcedureDate))]
    public override DateTime? procedure_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.PrimaryProcedureDate))]
    public override DateTime? procedure_datetime { get; set; }

    [ConstantValue(32818, "`EHR Administration record`")]
    public override int? procedure_type_concept_id { get; set; }

    [CopyValue(nameof(Source.PrimaryProcedure))]
    public override string? procedure_source_value { get; set; }

    [Transform(typeof(Opcs4Selector), nameof(Source.PrimaryProcedure))]
    public override int? procedure_source_concept_id { get; set; }

    [CopyValue(nameof(Source.RecordConnectionIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }
}