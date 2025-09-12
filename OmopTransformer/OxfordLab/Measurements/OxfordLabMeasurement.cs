using OmopTransformer.Annotations;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordLab.Measurements.OxfordLabMeasurement;

internal class OxfordLabMeasurement : OmopMeasurement<OxfordLabMeasurementRecord>
{
    [CopyValue(nameof(Source.nhs_number))]
    public override string? nhs_number { get; set; }
    
    // [CopyValue(nameof(Source.GeneratedRecordIdentifier))]
    // public override string? RecordConnectionIdentifier {get;set;}

    [Transform(typeof(DateConverter), nameof(Source.event_start_dt_tm))]
    public override DateTime? measurement_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_start_dt_tm))]
    public override DateTime? measurement_datetime { get; set; }

    [ConstantValue(32828, "EHR episode record")]
    public override int? measurement_type_concept_id { get; set; }

    // [Transform(typeof(Icd10StandardNonStandardSelector), nameof(Source.event))]
    // public override int? measurement_source_concept_id { get; set; }

    // [Transform(typeof(RelationshipSelector), nameof(Source.event))]
    // public override string? value_source_value { get; set; }

    // [Transform(typeof(StandardMeasurementConceptSelector), useOmopTypeAsSource: true, nameof(measurement_source_concept_id))]
    // public override int[]? measurement_concept_id { get; set; }
}