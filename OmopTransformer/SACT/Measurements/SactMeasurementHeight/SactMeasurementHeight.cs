using OmopTransformer.Annotations;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT.Measurements.SactMeasurementHeight;

internal class SactMeasurementHeight : OmopMeasurement<SactMeasurementHeightRecord>
{
    [CopyValue(nameof(Source.NHS_Number))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Start_Date_Of_Regimen))]
    public override DateTime? measurement_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Start_Date_Of_Regimen))]
    public override DateTime? measurement_datetime { get; set; }

    [ConstantValue(32828, "EHR episode record")]
    public override int? measurement_type_concept_id { get; set; }

    [Transform(typeof(DecimalParser), nameof(Source.Height_At_Start_Of_Regimen))]
    public override double? value_as_number { get; set; }

    [CopyValue(nameof(Source.Height_At_Start_Of_Regimen))]
    public override string? value_source_value { get; set; }

    [ConstantValue(8582, "cm")]
    public override int? unit_concept_id { get; set; }

    [ConstantValue(607590, "Body Height")]
    public override int[]? measurement_concept_id { get; set; }

    public override bool IsValid => base.IsValid && value_as_number != null;
}