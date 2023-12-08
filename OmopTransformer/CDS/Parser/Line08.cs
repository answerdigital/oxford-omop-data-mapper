namespace OmopTransformer.CDS.Parser;

internal class Line08 : ICdsFrame
{
    public Line08(string sourceText)
    {
        SourceText = sourceText ?? throw new ArgumentNullException(nameof(sourceText));
    }

    public string? LineId { get; init; }
    public string? RecordConnectionIdentifier { get; init; }
    public string SourceText { get; }
    public string? NumberofBabies { get; init; }
    public string? FirstAntenatalAssessmentDate { get; init; }
    public string? GeneralMedicalPractitionerAntenatalCare { get; init; }
    public string? GeneralMedicalPractitionerPracticeAntenatalCare { get; init; }
    public string? LocationClass { get; init; }
    public string? ActivityLocationType { get; init; }
    public string? DeliveryPlaceTypeIntended { get; init; }
    public string? DeliveryPlaceChangeReason { get; init; }
    public string? AnaestheticDuringLabourDelivery { get; init; }
    public string? AnaestheticGivenPostLabourDelivery { get; init; }
    public string? GestationLengthLabourOnset { get; init; }
    public string? LabourDeliveryOnsetMethod { get; init; }
    public string? DeliveryDate { get; init; }
    public string? AgeAtCDSActivityDate { get; init; }
    public string? LocalPatientID { get; init; }
    public string? OrganisationCodeLocalPatientID { get; init; }
    public string? NHSNumberStatusIndicator { get; init; }
    public string? NHSNumber { get; init; }
    public string? WithheldFlag { get; init; }
    public string? WithheldIdentityReason { get; init; }
    public string? MotherBirthDate { get; init; }
    public string? OverseasVisitorStatusAtCDSActivityDate { get; init; }
    public string? PatientAddressType { get; init; }
    public string? PatientUnstructuredAddress { get; init; }
    public string? PatientStructured1 { get; init; }
    public string? PatientStructured2 { get; init; }
    public string? PatientStructured3 { get; init; }
    public string? PatientStructured4 { get; init; }
    public string? PatientStructured5 { get; init; }
    public string? Postcode { get; init; }
    public string? OrganisationCodeResidenceResponsibility { get; init; }
    public List<BirthDetails>? BirthDetails { get; set; }
}