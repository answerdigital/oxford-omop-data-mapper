namespace OmopTransformer.SUS.Staging;

public class OpcsProcedure
{
    public Guid MessageId { get; init; }
    public string? ProcedureOPCS { get; init; }
    public string? ProcedureDateOPCS { get; init; }
    public string? MainOperatingHealthcareProfessionalCodeOpcs { get; init; }
    public string? ProfessionalRegistrationIssuerCodeOpcs { get; init; }
    public string? ResponsibleAnaesthetistCodeOpcs { get; init; }
    public string? ResponsibleAnaesthetistRegBodyOpcs { get; init; }

    public bool IsPrimaryProcedure { get; init; }

    public bool IsEmpty =>
        ProcedureOPCS == null &&
        ProcedureDateOPCS == null &&
        MainOperatingHealthcareProfessionalCodeOpcs == null &&
        ProfessionalRegistrationIssuerCodeOpcs == null &&
        ResponsibleAnaesthetistCodeOpcs == null &&
        ResponsibleAnaesthetistRegBodyOpcs == null;
}