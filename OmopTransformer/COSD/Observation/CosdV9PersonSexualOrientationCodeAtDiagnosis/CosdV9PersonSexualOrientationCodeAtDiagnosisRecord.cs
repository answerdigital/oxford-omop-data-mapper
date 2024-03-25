using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Observation.CosdV9PersonSexualOrientationCodeAtDiagnosis;

[DataOrigin("COSD")]
[Description("CosdV9PersonSexualOrientationCodeAtDiagnosis")]
[SourceQuery("CosdV9PersonSexualOrientationCodeAtDiagnosis.xml")]
internal class CosdV9PersonSexualOrientationCodeAtDiagnosisRecord
{
    public string? NhsNumber { get; set; }
    public string? Date { get; set; }
    public string? PersonSexualOrientationCodeAtDiagnosis { get; set; }
}
