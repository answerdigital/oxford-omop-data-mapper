﻿namespace OmopTransformer.SUS.Staging.AE;

internal class AERow
{
    public Guid MessageId { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? ReasonForAccess { get; set; }
    public string? CDStype { get; set; }
    public string? ProtocolIdentifier { get; set; }
    public string? UniqueCDSidentifier { get; set; }
    public string? UpdateType { get; set; }
    public string? BulkreplacementCDSgroup { get; set; }
    public string? TestIndicator { get; set; }
    public string? ApplicableDatetime { get; set; }
    public string? CensusDate { get; set; }
    public string? ExtractDatetime { get; set; }
    public string? ReportPeriodStartDate { get; set; }
    public string? ReportPeriodEndDate { get; set; }
    public string? OrganisationCodeSenderOfTransaction { get; set; }
    public string? OrganisationCodeTypeofSender { get; set; }
    public string? CDSInterchangeID { get; set; }
    public string? LocalPatientIdentifier { get; set; }
    public string? OrganisationCodeLocalPatientIdentifier { get; set; }
    public string? OrganisationCodeTypeLocalPatientIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? DateOfBirth { get; set; }
    public string? CarerSupportIndicator { get; set; }
    public string? NHSNumberTraceStatus { get; set; }
    public string? WithheldIdentityReason { get; set; }
    public string? Sex { get; set; }
    public string? NameFormatCode { get; set; }
    public string? PatientName { get; set; }
    public string? PersonTitle { get; set; }
    public string? PersonGivenName { get; set; }
    public string? PersonFamilyName { get; set; }
    public string? PersonNameSuffix { get; set; }
    public string? PersonInitials { get; set; }
    public string? AddressFormatCode { get; set; }
    public string? PatientUsualAddress { get; set; }
    public string? Postcode { get; set; }
    public string? OrganisationCodeResidenceResponsibility { get; set; }
    public string? PCTofResidence { get; set; }
    public string? OrganisationCodeTypePCTofResidence { get; set; }
    public string? EthnicCategory { get; set; }
    public string? OSVClassificationatCDSActivityDate { get; set; }
    public string? GeneralMedicalPractitionerCodeofRegisteredGMP { get; set; }
    public string? PracticeCodeofRegisteredGP { get; set; }
    public string? OrganisationCodeTypeofRegisteredGP { get; set; }
    public string? AEAttendanceNumber { get; set; }
    public string? AEArrivalMode { get; set; }
    public string? AEAttendanceCategory { get; set; }
    public string? AEAttendanceDisposal { get; set; }
    public string? AEIncidentLocationType { get; set; }
    public string? AEPatientGroup { get; set; }
    public string? SourceofReferralForAE { get; set; }
    public string? ArrivalDate { get; set; }
    public string? ArrivalTime { get; set; }
    public string? AEAttendanceConclusionTime { get; set; }
    public string? AEAttendanceConclusionDate { get; set; }
    public string? AEDepartureTime { get; set; }
    public string? AEDepartureDate { get; set; }
    public string? AEInitialAssessmentTimefirstandunplannedfollowupattendancesonly { get; set; }
    public string? AEInitialAssessmentDate { get; set; }
    public string? AETimeSeenForTreatment { get; set; }
    public string? SiteCodeOfTreatment { get; set; }
    public string? WaitingTimeMeasurementType { get; set; }
    public string? AmbulanceIncidentNumber { get; set; }
    public string? OrganisationCodeConveyingAmbulanceTrust { get; set; }
    public string? CommissioningSerialNumber { get; set; }
    public string? NHSServiceAgreementLineNumber { get; set; }
    public string? ProviderReferenceNumber { get; set; }
    public string? CommissionerReferenceNumber { get; set; }
    public string? OrganisationCodeCodeOfProvider { get; set; }
    public string? OrganisationCodeTypeOfProvider { get; set; }
    public string? OrganisationCodeCodeOfCommissioner { get; set; }
    public string? OrganisationCodeTypeOfCommissioner { get; set; }
    public string? AEStaffMemberCode { get; set; }
    public string? DiagnosisSchemeInUse { get; set; }
    public string? InvestigationSchemeInUse { get; set; }
    public string? TreatmentSchemeInUse { get; set; }
    public string? HRGCode { get; set; }
    public string? HRGVersionNumber { get; set; }
    public string? ProcedureSchemeInUse { get; set; }
    public string? DominantGroupingVariableProcedure { get; set; }
    public string? FCEHRG { get; set; }
    public string? SpellCOREHRGVersionNo { get; set; }
    public string? PBRGeneratedCoreHRGforInformation { get; set; }
    public string? PBRGeneratedCoreHRGVersionforInformation { get; set; }
    public string? UniqueBookingReferenceNumberConverted { get; set; }
    public string? PatientPathwayIdentifier { get; set; }
    public string? OrganisationCodePatientPathwayIdentifierIssuer { get; set; }
    public string? ReferralToTreatmentPeriodStatus { get; set; }
    public string? ReferralToTreatmentPeriodStartDate { get; set; }
    public string? ReferralToTreatmentPeriodEndDate { get; set; }
    public string? LeadCareActivityIndicator { get; set; }
    public string? AgeatCDSActivityDate { get; set; }
    public string? NHSServiceAgreementChangeDate { get; set; }
    public string? CDSActivityDate { get; set; }
    public string? AEDepartmentType { get; set; }
    public string? XMLVersion { get; set; }
    public string? ConfidentialityCategoryDerived { get; set; }
    public string? ReferralToTreatmentLengthDerived { get; set; }
    public string? AEAssessmentWaitTime { get; set; }
    public string? AEConclusionWaitTime { get; set; }
    public string? AEDuration { get; set; }
    public string? AETreatmentWait { get; set; }
    public string? AgerangepatientderivedfromDOB { get; set; }
    public string? AreaCodeDerivedFromPostcode { get; set; }
    public string? CDSGroup { get; set; }
    public string? FinishedIndicator { get; set; }
    public string? PCTDerivedfromGP { get; set; }
    public string? PCTTypeDerivedfromGP { get; set; }
    public string? GPPracticeDerived { get; set; }
    public string? PCTDerivedfromderivedGPPractice { get; set; }
    public string? SHAfromGPPractice { get; set; }
    public string? SHATypefromGPPractice { get; set; }
    public string? MonthOfBirth { get; set; }
    public string? ElectoralWardFromPostcode { get; set; }
    public string? PCTfrompostcode { get; set; }
    public string? PCTTypefromPostcode { get; set; }
    public string? SHAfromPostcode { get; set; }
    public string? SHATypefromPostcode { get; set; }
    public string? AreaCodeFromProviderPostcode { get; set; }
    public string? AgeAtEndOfEpisode { get; set; }
    public string? AgeAtStartOfEpisode { get; set; }
    public string? YearOfBirth { get; set; }
    public string? CensusArea { get; set; }
    public string? Country { get; set; }
    public string? CountyCode { get; set; }
    public string? CensusED { get; set; }
    public string? EDDistrictCode { get; set; }
    public string? ElectoralWardCode { get; set; }
    public string? GORCode { get; set; }
    public string? LocalUnitaryAuthority { get; set; }
    public string? OldSHACode { get; set; }
    public string? ElectoralArea { get; set; }
    public string? PrimeRecipient { get; set; }
    public string? CopyRecipients { get; set; }
}