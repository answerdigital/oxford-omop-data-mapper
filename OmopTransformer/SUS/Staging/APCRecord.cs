namespace OmopTransformer.SUS.Staging;

internal class APCRecord
{
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