namespace OmopTransformer.RTDS.Parser;

internal class RtdsRecords
{
    public RtdsRecords(
        IReadOnlyCollection<Rtds1Demographics> demographics,
        IReadOnlyCollection<Rtds2AAttendances> attendances, 
        IReadOnlyCollection<Rtds2BPlan> plans,
        IReadOnlyCollection<Rtds3Prescription> prescriptions, 
        IReadOnlyCollection<Rtds4Exposures> exposures,
        IReadOnlyCollection<RtdsPasData>? pasData, 
        IReadOnlyCollection<Rtds5DiagnosisCourse> diagnosesCourses, 
        string sourceFileName)
    {
        Demographics = demographics ?? throw new ArgumentNullException(nameof(demographics));
        Attendances = attendances ?? throw new ArgumentNullException(nameof(attendances));
        Plans = plans ?? throw new ArgumentNullException(nameof(plans));
        Prescriptions = prescriptions ?? throw new ArgumentNullException(nameof(prescriptions));
        Exposures = exposures ?? throw new ArgumentNullException(nameof(exposures));
        PasData = pasData;
        Diagnoses_Courses = diagnosesCourses ?? throw new ArgumentNullException(nameof(diagnosesCourses));
        SourceFileName = sourceFileName ?? throw new ArgumentNullException(nameof(sourceFileName));
    }
    
    public string SourceFileName { get; }
    public IReadOnlyCollection<Rtds1Demographics> Demographics { get; }
    public IReadOnlyCollection<Rtds2AAttendances> Attendances { get; }
    public IReadOnlyCollection<Rtds2BPlan> Plans { get; }
    public IReadOnlyCollection<Rtds3Prescription> Prescriptions { get; }
    public IReadOnlyCollection<Rtds4Exposures> Exposures { get; }
    public IReadOnlyCollection<Rtds5DiagnosisCourse> Diagnoses_Courses { get; }
    public IReadOnlyCollection<RtdsPasData>? PasData { get; }
}