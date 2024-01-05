namespace OmopTransformer.RTDS.Parser;

public class RtdsRawData(
    string demographics,
    string attendances,
    string plans,
    string prescriptions,
    string exposures,
    string diagnosesCourses,
    string? pasData,
    string sourceFileName)
{
    public string Demographics { get; } = demographics;
    public string Attendances { get; } = attendances;
    public string Plans { get; } = plans;
    public string Prescriptions { get; } = prescriptions;
    public string Exposures { get; } = exposures;
    public string Diagnoses_Courses { get; } = diagnosesCourses;
    public string? PasData { get; } = pasData;
    public string SourceFileName { get; } = sourceFileName;
}