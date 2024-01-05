namespace OmopTransformer.RTDS.Parser;

internal class RtdsParser
{
    private readonly RtdsRawData _data;

    public RtdsParser(RtdsRawData data)
    {
        _data = data ?? throw new ArgumentNullException(nameof(data));
    }
        
    public RtdsRecords Parse()
    {
        return
            new RtdsRecords(
                demographics: new Rtds1DemographicsParser(_data.Demographics).Parse().ToList(),
                attendances: new Rtds2AAttendancesParser(_data.Attendances).Parse().ToList(),
                plans: new Rtds2BPlanParser(_data.Plans).Parse().ToList(),
                prescriptions: new Rtds3PrescriptionParser(_data.Prescriptions).Parse().ToList(),
                exposures: new Rtds4ExposuresParser(_data.Exposures).Parse().ToList(),
                diagnosesCourses: new Rtds5DiagnosisCourseParser(_data.Diagnoses_Courses).Parse().ToList(),
                pasData: _data.PasData == null ? null : new RtdsPasDataParser(_data.PasData).Parse().ToList(),
                sourceFileName: _data.SourceFileName);
    }
}