namespace OmopTransformer.SUS.Staging.APC;

internal class APCRecord
{
    public APCRecord(APCRow apcRow, List<OverseasVisitor> overseasVisitors, List<IcdDiagnosis> icdDiagnoses, List<ReadDiagnosis> readDiagnoses, List<SusAPCOpcsProcedure> opcdProcedure, List<APCReadProcedure> readProcedure, List<APCCareLocation> careLocations, List<APCBirth> births, List<APCCriticalCare> criticalCareItems)
    {
        ApcRow = apcRow;
        OverseasVisitors = overseasVisitors;
        IcdDiagnoses = icdDiagnoses;
        ReadDiagnoses = readDiagnoses;
        OpcdProcedure = opcdProcedure;
        ReadProcedure = readProcedure;
        CareLocations = careLocations;
        Births = births;
        CriticalCareItems = criticalCareItems;
    }

    public APCRow ApcRow { get; init; }
    public List<OverseasVisitor> OverseasVisitors { get; init; }
    public List<IcdDiagnosis> IcdDiagnoses { get; init; }
    public List<ReadDiagnosis> ReadDiagnoses { get; init; }
    public List<SusAPCOpcsProcedure> OpcdProcedure { get; init; }
    public List<APCReadProcedure> ReadProcedure { get; init; }
    public List<APCCareLocation> CareLocations { get; init; }
    public List<APCBirth> Births { get; init; }
    public List<APCCriticalCare> CriticalCareItems { get; init; }
}