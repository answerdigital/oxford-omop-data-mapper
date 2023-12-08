namespace OmopTransformer.CDS.Parser;

internal class Procedure
{
    private Procedure()
    {
    }

    public string? PrimaryProcedure { get; set; }
    public string? PrimaryProcedureDate { get; set; }
    public string? MainOperatingHealthcareProfessionalRegistrationIssuerCode { get; set; }
    public string? MainOperatingHealthcareProfessionalRegistrationEntryIdentifier { get; set; }
    public string? ResponsibleAnaesthetistProfessionalRegistrationIssuerCode { get; set; }
    public string? ResponsibleAnaesthetistProfessionalRegistrationEntryIdentifier { get; set; }

    public static Procedure? FromText(string text)
    {
        if (text == null) throw new ArgumentNullException(nameof(text));

        if (text.IsEmpty())
            return null;

        int index = 0;

        var procedure = new Procedure();

        procedure.PrimaryProcedure = text.SubstringOrNull(index, 6);
        index += 6;

        procedure.PrimaryProcedureDate = text.SubstringOrNull(index, 8);
        index += 8;

        procedure.MainOperatingHealthcareProfessionalRegistrationIssuerCode = text.SubstringOrNull(index, 2);
        index += 2;

        procedure.MainOperatingHealthcareProfessionalRegistrationEntryIdentifier = text.SubstringOrNull(index, 12);
        index += 12;

        procedure.ResponsibleAnaesthetistProfessionalRegistrationIssuerCode = text.SubstringOrNull(index, 2);
        index += 2;

        procedure.ResponsibleAnaesthetistProfessionalRegistrationEntryIdentifier = text.SubstringOrNull(index, 12);

        return procedure;
    }
}