namespace OmopTransformer.CDS.Parser;

internal class Line01 : ICdsFrame
{
    public Line01(string sourceText)
    {
        SourceText = sourceText ?? throw new ArgumentNullException(nameof(sourceText));
    }

    public string? LineId { get; init; }
    public string? RecordConnectionIdentifier { get; init; }
    public string SourceText { get; }
    public string? CdsVersion { get; init; }
    public string? CdsRecordType { get; init; }
    public string? CdsBulkReplacementGroup { get; init; }
    public string? CdsProtocolIdentifier { get; init; }
    public string? CdsUniqueIdentifier { get; init; }
    public string? CDSUpdateType { get; init; }
    public string? CdsApplicableDate { get; init; }
    public string? CdsApplicableTime { get; init; }
    public string? CDSExtractDate { get; init; }
    public string? CDSExtractTime { get; init; }
    public string? CDSReportPeriodStartDate { get; init; }
    public string? CDSReportPeriodEndDate { get; init; }
    public string? CDSCensusDate { get; init; }
    public string? CDSActivityDate { get; init; }
    public string? CDSSenderIdentity { get; init; }
    public string? CDSPrimaryRecipientIdentity { get; init; }
    public string? CDSCopyRecipientIdentity1 { get; init; }
    public string? CDSCopyRecipientIdentity2 { get; init; }
    public string? CDSCopyRecipientIdentity3 { get; init; }
    public string? CDSCopyRecipientIdentity4 { get; init; }
    public string? CDSCopyRecipientIdentity5 { get; init; }
    public string? CDSCopyRecipientIdentity6 { get; init; }
    public string? CDSCopyRecipientIdentity7 { get; init; }
    public string? UniqueBookingReferenceNumberConverted { get; init; }
    public string? PatientPathwayIdentifier { get; init; }
    public string? OrganisationCodeofthePatientPathwayIdentifier { get; init; }
    public string? ReferralToTreatmentPeriodStatus { get; init; }
    public string? WaitingTimeMeasurementType { get; init; }
    public string? ReferralToTreatmentPeriodStartDate { get; init; }
    public string? ReferralToTreatmentPeriodEndDate { get; init; }
    public string? LocalPatientID { get; init; }
    public string? OrganisationCodeLocalPatientID { get; init; }
    public string? NHSNumberStatusIndicator { get; init; }
    public string? NHSNumber { get; init; }
    public string? WithheldFlag { get; init; }
    public string? WithheldIdentityReason { get; init; }
    public string? DateofBirth { get; init; }
    public string? PatientNameType { get; init; }
    public string? PatientFullName { get; init; }
    public string? PatientRequestedName { get; init; }
    public string? PatientTitle { get; init; }
    public string? PatientForename { get; init; }
    public string? PatientSurname { get; init; }
    public string? PatientNameSuffix { get; init; }
    public string? PatientInitials { get; init; }
    public string? PatientAddressType { get; init; }
    public string? PatientUnstructuredAddress { get; init; }
    public string? PatientAddressStructured1 { get; init; }
    public string? PatientAddressStructured2 { get; init; }
    public string? PatientAddressStructured3 { get; init; }
    public string? PatientAddressStructured4 { get; init; }
    public string? PatientAddressStructured5 { get; init; }
    public string? Postcode { get; init; }
    public string? OrganisationCodeResidenceResponsibility { get; init; }
    public string? PersonCurrentGenderCode { get; init; }
    public string? CarerSupportIndicator { get; init; }
    public string? EthnicCategory { get; init; }
    public string? PersonMaritalStatus { get; init; }
    public string? BirthWeight { get; init; }
    public string? LiveStillBirthIndicator { get; init; }
    public string? TotalPreviousPregnancies { get; init; }
    public string? CommissioningSerialNumber { get; init; }
    public string? NHSServiceAgreementLineNumber { get; init; }
    public string? ProvidersReferenceNumber { get; init; }
    public string? CommissionersReferenceNumber { get; init; }
    public string? OrganisationCodeCodeofProvider { get; init; }
    public string? OrganisationCodeCodeofCommissioner { get; init; }
    public string? NHSServiceAgreementChangeDate { get; init; }
    public string? GeneralMedicalPractitionerSpecified { get; init; }
    public string? GPPracticeRegistered { get; init; }
    public string? ReferrerCode { get; init; }
    public string? ReferringOrganisationCode { get; init; }
    public string? DirectAccessReferralIndicator { get; init; }
    public string? ConsultantCode { get; init; }
    public string? CareProfessionalMainSpecialtyCode { get; init; }
    public string? ActivityTreatmentFunctionCode { get; init; }
    public string? LocalSubSpecialtyCode { get; init; }
}