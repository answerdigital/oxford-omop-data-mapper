using OmopTransformer.Annotations;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordLab.Measurements.OxfordLabMeasurement;

internal class OxfordLabMeasurement : OmopMeasurement<OxfordLabMeasurementRecord>
{
    [CopyValue(nameof(Source.NHS_NUMBER))]
    public override string? nhs_number { get; set; }
    
    // [CopyValue(nameof(Source.GeneratedRecordIdentifier))]
    // public override string? RecordConnectionIdentifier {get;set;}

    [Transform(typeof(DateConverter), nameof(Source.EVENT_START_DT_TM))]
    public override DateTime? measurement_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EVENT_START_DT_TM))]
    public override DateTime? measurement_datetime { get; set; }

    [ConstantValue(32828, "EHR episode record")]
    public override int? measurement_type_concept_id { get; set; }

    [Transform(typeof(LabTestLookup), nameof(Source.@EVENT))]
    public override int? measurement_source_concept_id { get; set; }

    [CopyValue(nameof(Source.@EVENT))]
    public override string? value_source_value { get; set; }

    [Transform(typeof(StandardMeasurementConceptSelector), useOmopTypeAsSource: true, nameof(measurement_source_concept_id))]
    public override int[]? measurement_concept_id { get; set; }
}