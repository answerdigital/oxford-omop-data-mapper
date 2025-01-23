namespace OmopTransformer.SUS.Staging.AE;

internal class AERecord
{
    public AERecord(AERow opRow, List<SusAEInvestigation> susAeInvestigation, List<SusAEDiagnosis> susAeDiagnosis, List<SusAETreatment> susAeTreatment)
    {
        AERow = opRow;
        SusAEInvestigation = susAeInvestigation;
        SusAEDiagnosis = susAeDiagnosis;
        SusAETreatment = susAeTreatment;
    }

    public AERow AERow { get; init; }

    public List<SusAEInvestigation> SusAEInvestigation { get; init; }
    public List<SusAEDiagnosis> SusAEDiagnosis { get; init; }
    public List<SusAETreatment> SusAETreatment { get; init; }
}