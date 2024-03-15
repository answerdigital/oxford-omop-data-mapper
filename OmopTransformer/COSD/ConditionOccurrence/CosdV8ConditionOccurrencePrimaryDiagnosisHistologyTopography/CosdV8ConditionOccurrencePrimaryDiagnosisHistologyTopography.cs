using OmopTransformer.Annotations;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.ConditionOccurrence.CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopography;

internal class CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopography : OmopConditionOccurrence<CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopographyRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DiagnosisDate))]
    public override DateTime? condition_start_date { get; set; }

    [ConstantValue(32828, "`EHR episode record`")]
    public override int? condition_type_concept_id { get; set; }

    [Transform(typeof(DataDictionaryBasisOfDiagnosisCancerLookup), nameof(Source.BasisOfDiagnosisCancer))]
    public override int? condition_status_concept_id { get; set; }

    [CopyValue(nameof(Source.BasisOfDiagnosisCancer))]
    public override string? condition_status_source_value { get; set; }

    [Transform(typeof(Icdo3Selector), nameof(Source.CancerHistology), nameof(Source.CancerTopography))]
    public override int? condition_source_concept_id { get; set; }

    [Transform(typeof(Icdo3Selector), nameof(Source.CancerHistology), nameof(Source.CancerTopography))]
    public override int[]? condition_concept_id { get; set; }

    [Transform(typeof(TextDeliminator), nameof(Source.CancerHistology), nameof(Source.CancerTopography))]
    public override string? condition_source_value { get; set; }
}