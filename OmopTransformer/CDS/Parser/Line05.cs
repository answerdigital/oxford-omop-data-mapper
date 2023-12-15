namespace OmopTransformer.CDS.Parser;

internal class Line05 : ICdsFrame
{
    public Line05(string sourceText)
    {
        SourceText = sourceText ?? throw new ArgumentNullException(nameof(sourceText));
    }

    public string? LineId { get; init; }
    public string? RecordConnectionIdentifier { get; init; }
    public string SourceText { get; }
    public string? HospitalProviderSpellNumber { get; init; }
    public string? AdministrativeCategoryCode { get; init; }
    public string? PatientClassification { get; init; }
    public string? AdmissionMethodCode { get; init; }
    public string? SourceofAdmissionCode { get; init; }
    public string? StartDateHospitalProviderSpell { get; init; }
    public string? StartTimeHospitalProviderSpell { get; init; }
    public string? AgeOnAdmission { get; init; }
    public string? AmbulanceIncidentNumber { get; init; }
    public string? OrganisationCodeConveyingAmbulanceTrust { get; init; }
    public string? DischargeDestinationCode { get; init; }
    public string? DischargeMethod { get; init; }
    public string? DischargeReadyDateHospitalProviderSpell { get; init; }
    public string? DischargeDateHospitalProviderSpell { get; init; }
    public string? DischargeTimeHospitalProviderSpell { get; init; }
    public string? DischargetoHospitalatHomeServiceIndicator { get; init; }
    public string? MentalHealthActLegalClassificationCodeonAdmission { get; init; }
    public string? MentalHealthActLegalStatusClassificationCodeAtCensusDate { get; init; }
    public string? DateDetentionCommenced { get; init; }
    public string? AgeAtCensus { get; init; }
    public string? DurationOfCareToPsychiatricCensusDate { get; init; }
    public string? DurationOfDetention { get; init; }
    public string? MentalHealthAct2007MentalCategory { get; init; }
    public string? StatusOfPatientIncludedInThePsychiatricCensusCode { get; init; }
    public string? EpisodeNumber { get; init; }
    public string? LastEpisodeinSpellIndicator { get; init; }
    public string? OperationStatusCode { get; init; }
    public string? NeonatalLevelofCare { get; init; }
    public string? FirstRegularDayNightAdmission { get; init; }
    public string? PsychiatricPatientStatus { get; init; }
    public string? EpisodeStartDate { get; init; }
    public string? EpisodeStartTime { get; init; }
    public string? EpisodeEndDate { get; init; }
    public string? EpisodeEndTime { get; init; }
    public string? AgeAtCDSActivityDate { get; init; }
    public string? MultiProfessionalorMultidisciplinaryConsultationIndicationCode { get; init; }
    public string? RehabilitationAssessmentTeamType { get; init; }
    public string? LengthofStayAdjustmentRehabilitation { get; init; }
    public string? LengthOfStayAdjustmentSpecialistPalliativeCare { get; init; }
    public string? DurationofElectiveWait { get; init; }
    public string? IntendedManagement { get; init; }
    public string? DecidedtoAdmitDate { get; init; }
    public string? EarliestReasonableOfferDate { get; init; }

    public List<OverseasVisitor> OverseasVisitors { get; set; } = new();
}