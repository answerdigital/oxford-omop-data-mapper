namespace OmopTransformer.SUS.Staging;

internal class APCRecord
{
    public APCRecord(APC apc, List<OverseasVisitor> overseasVisitors, List<IcdDiagnosis> icdDiagnoses, List<ReadDiagnosis> readDiagnoses, List<OpcsProcedure> opcdProcedure, List<ReadProcedure> readProcedure, List<CareLocation> careLocations, List<Birth> births, List<CriticalCare> criticalCareItems)
    {
        APC = apc;
        OverseasVisitors = overseasVisitors;
        IcdDiagnoses = icdDiagnoses;
        ReadDiagnoses = readDiagnoses;
        OpcdProcedure = opcdProcedure;
        ReadProcedure = readProcedure;
        CareLocations = careLocations;
        Births = births;
        CriticalCareItems = criticalCareItems;
    }

    public APC APC { get; init; }
    public List<OverseasVisitor> OverseasVisitors { get; init; }
    public List<IcdDiagnosis> IcdDiagnoses { get; init; }
    public List<ReadDiagnosis> ReadDiagnoses { get; init; }
    public List<OpcsProcedure> OpcdProcedure { get; init; }
    public List<ReadProcedure> ReadProcedure { get; init; }
    public List<CareLocation> CareLocations { get; init; }
    public List<Birth> Births { get; init; }
    public List<CriticalCare>  CriticalCareItems { get; init; }
}