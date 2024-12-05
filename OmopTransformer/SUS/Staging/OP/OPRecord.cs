namespace OmopTransformer.SUS.Staging.OP;

internal class OPRecord
{
    public OPRecord(OPRow opRow, List<IcdDiagnosis> icdDiagnoses, List<ReadDiagnosis> readDiagnoses, List<OPReadProcedure> opReadProcedures, List<OpcsProcedure> opcdProcedure)
    {
        OPRow = opRow;
        IcdDiagnoses = icdDiagnoses;
        ReadDiagnoses = readDiagnoses;
        OPReadProcedures = opReadProcedures;
        OpcdProcedure = opcdProcedure;
    }

    public OPRow OPRow { get; init; } 
    public List<IcdDiagnosis> IcdDiagnoses { get; init; }
    public List<ReadDiagnosis> ReadDiagnoses { get; init; }
    public List<OPReadProcedure> OPReadProcedures { get; init; }
    public List<OpcsProcedure> OpcdProcedure { get; init; }
      
}