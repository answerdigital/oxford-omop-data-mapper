﻿namespace OmopTransformer.SUS.Staging.Inpatient.APC;

internal class APCRow
{
    public Guid MessageId { get; init; }
    public string? GeneratedRecordIdentifier { get; init; }
    public string? PBRSpellID { get; init; }
    public string? ReasonForAccess { get; init; }
    public string? CDSType { get; init; }
    public string? ProtocolIdentifier { get; init; }
    public string? UniqueCDSIdentifier { get; init; }
    public string? UpdateType { get; init; }
    public string? BulkReplacementCDSGroup { get; init; }
    public string? TestIndicator { get; init; }
    public string? ApplicableDatetime { get; init; }
    public string? CensusDate { get; init; }
    public string? ExtractDatetime { get; init; }
    public string? ReportPeriodStartDate { get; init; }
    public string? ReportPeriodEndDate { get; init; }
    public string? OrganisationCodeSenderOfTransaction { get; init; }
    public string? OrganisationCodeTypeofSender { get; init; }
    public string? SubmissionDate { get; init; }
    public string? CDSInterchangeID { get; init; }
    public string? LocalPatientIdentifier { get; init; }
    public string? OrganisationCodeLocalPatientIdentifier { get; init; }
    public string? OrganisationCodeTypeLocalPatientIdentifier { get; init; }
    public string? NHSNumber { get; init; }
    public string? DateofBirth { get; init; }
    public string? BirthWeight { get; init; }
    public string? LiveOrStillBirth { get; init; }
    public string? CarerSupportIndicator { get; init; }
    public string? LegalStatusClassificationOnAdmissionPsychiatricCensusOnly { get; init; }
    public string? EthnicGroup { get; init; }
    public string? MaritalStatusPsychiatricCensusOnly { get; init; }
    public string? NHSNumberTraceStatus { get; init; }
    public string? WithheldIdentityReason { get; init; }
    public string? Sex { get; init; }
    public string? PregnancyTotalPreviousPregnancies { get; init; }
    public string? NameFormatCode { get; init; }
    public string? PatientName { get; init; }
    public string? PersonTitle { get; init; }
    public string? PersonGivenName { get; init; }
    public string? PersonFamilyName { get; init; }
    public string? PersonNameSuffix { get; init; }
    public string? PersonInitials { get; init; }
    public string? AddressFormatCode { get; init; }
    public string? PatientUsualAddress { get; init; }
    public string? Postcode { get; init; }
    public string? OrganisationCodeResidenceResponsibility { get; init; }
    public string? PCTofResidence { get; init; }
    public string? OrganisationCodeTypePCTofResidence { get; init; }
    public string? OSVClassificationatCDSActivityDate { get; init; }
    public string? HospitalProviderSpellNumber { get; init; }
    public string? AdministrativeCategory { get; init; }
    public string? PatientClassification { get; init; }
    public string? AdmissionMethodHospitalProviderSpell { get; init; }
    public string? DischargeDestinationHospitalProviderSpell { get; init; }
    public string? DischargeMethodHospitalProviderSpell { get; init; }
    public string? SourceOfAdmissionHospitalProviderSpell { get; init; }
    public string? StartDateHospitalProviderSpell { get; init; }
    public string? StartTimeHospitalProviderSpell { get; init; }
    public string? DischargeDateFromHospitalProviderSpell { get; init; }
    public string? DischargeTimeHospitalProviderSpell { get; init; }
    public string? DischargeToHospitalAtHomeServiceIndicator { get; init; }
    public string? EpisodeNumber { get; init; }
    public string? FirstRegularDayNightAdmission { get; init; }
    public string? LastEpisodeInSpellIndicator { get; init; }
    public string? NeonatalLevelOfCare { get; init; }
    public string? OperationStatus { get; init; }
    public string? PsychiatricPatientStatus { get; init; }
    public string? StartDateConsultantEpisode { get; init; }
    public string? StartTimeEpisode { get; init; }
    public string? EndDateConsultantEpisode { get; init; }
    public string? EndTimeEpisode { get; init; }
    public string? LengthOfStayAdjustmentRehabilitation { get; init; }
    public string? LengthOfStayAdjustmentSpecialistPalliativeCare { get; init; }
    public string? CommissioningSerialNumber { get; init; }
    public string? NHSServiceAgreementLineNumber { get; init; }
    public string? ProviderReferenceNumber { get; init; }
    public string? CommissionerReferenceNumber { get; init; }
    public string? OrganisationCodeCodeOfProvider { get; init; }
    public string? OrganisationCodeTypeOfProvider { get; init; }
    public string? OrganisationCodeCodeOfCommissioner { get; init; }
    public string? OrganisationCodeTypeofCommissioner { get; init; }
    public string? ConsultantCode { get; init; }
    public string? MainSpecialtyCode { get; init; }
    public string? TreatmentFunctionCode { get; init; }
    public string? LocalSubSpecialtyCode { get; init; }
    public string? MultiProfessionalOrMultidisciplinaryIndCode { get; init; }
    public string? RehabilitationAssessmentTeamType { get; init; }
    public string? DiagnosisSchemeInUseICD { get; init; }
    public string? DiagnosisSchemeInUseRead { get; init; }
    public string? ProcedureSchemeInUseOPCS { get; init; }
    public string? ProcedureSchemeInUseREAD { get; init; }
    public string? WardCodeAtEpisodeStartDate { get; init; }
    public string? WardSecurityLevelAtEpisodeStartDate { get; init; }
    public string? LocationClassAtEpisodeStartDate { get; init; }
    public string? SiteCodeOfTreatmentAtEpisodeStartDate { get; init; }
    public string? OrganisationCodeTypeSiteCodeOfTreatmentAtStartOfEpisode { get; init; }
    public string? IntendedClinicalCareIntensityAtStartOfEpisode { get; init; }
    public string? AgeGroupIntendedAtStartOfEpisode { get; init; }
    public string? SexOfPatientsAtStartOfEpisode { get; init; }
    public string? WardDayPeriodAvailability { get; init; }
    public string? WardNightPeriodAvailability { get; init; }
    public string? WardCodeAtEpisodeEndDate { get; init; }
    public string? WardSecurityLevelAtEpisodeEndDate { get; init; }
    public string? LocationClassAtEpisodeEndDate { get; init; }
    public string? SiteCodeOfTreatmentAtEpisodeEndDate { get; init; }
    public string? OrganisationCodeTypeSiteCodeOfTreatmentAtEpisodeEndDate { get; init; }
    public string? IntendedClinicalCareIntensityAtEpisodeEndDate { get; init; }
    public string? AgeGroupIntendedAtEpisodeEndDate { get; init; }
    public string? SexOfPatientsAtEpisodeEndDate { get; init; }
    public string? WardDayPeriodAvailabilityAtEpisodeEndDate { get; init; }
    public string? WardNightPeriodAvailabilityAtEpisodeEndDate { get; init; }
    public string? GeneralMedicalPractitionerCodeofRegisteredGMP { get; init; }
    public string? PracticeCodeOfRegisteredGP { get; init; }
    public string? OrganisationCodeTypeofRegisteredGP { get; init; }
    public string? ReferrerCode { get; init; }
    public string? ReferringOrganisationCode { get; init; }
    public string? OrganisationCodeTypeofReferrer { get; init; }
    public string? DirectAccessReferralIndicator { get; init; }
    public string? AmbulanceIncidentNumber { get; init; }
    public string? OrganisationCodeConveyingAmbulanceTrust { get; init; }
    public string? DurationofElectiveWait { get; init; }
    public string? IntendedManagement { get; init; }
    public string? DecidedToAdmitDateForThisProvider { get; init; }
    public string? WaitingTimeMeasurementType { get; init; }
    public string? LocationTypeCodeAtStartOfEpisode { get; init; }
    public string? HRGCode { get; init; }
    public string? HRGVersionNumber { get; init; }
    public string? ProcedureSchemeInUse { get; init; }
    public string? DominantGroupingVariableProcedure { get; init; }
    public string? FCEHRG { get; init; }
    public string? EpisodeHRGVersionNumber { get; init; }
    public string? SpellCoreHRG { get; init; }
    public string? SpellHRGVersionNumber { get; init; }
    public string? NumberOfBabies { get; init; }
    public string? FirstAntenatalAssessmentDate { get; init; }
    public string? GMPCodeofGMPResponsibleforAntenatalCare { get; init; }
    public string? CodeofGPPracticeRegisteredGMPAntenatalCare { get; init; }
    public string? OrganisationCodeTypeGPPracticeRegisteredGMPAntenatalCare { get; init; }
    public string? LocationClassOfDeliveryPlaceIntended { get; init; }
    public string? LocationTypeofDeliveryPlaceIntended { get; init; }
    public string? DeliveryPlaceChangeReason { get; init; }
    public string? DeliveryPlaceTypeIntended { get; init; }
    public string? AnaestheticGivenDuringLabourDelivery { get; init; }
    public string? AnaestheticGivenPostDelivery { get; init; }
    public string? GestationLengthLabourOnset { get; init; }
    public string? LabourDeliveryOnsetMethod { get; init; }
    public string? DeliveryDate { get; init; }
    public string? GestationLengthAssessmentBaby { get; init; }
    public string? LocalPatientIdentifierMother { get; init; }
    public string? OrganisationCodeLocalPatientIdentifierMother { get; init; }
    public string? OrganisationCodeTypeMother { get; init; }
    public string? NHSNumberMother { get; init; }
    public string? NHSNumberStatusIndicatorMother { get; init; }
    public string? BirthDateMother { get; init; }
    public string? AddressFormatCodeMother { get; init; }
    public string? PatientUsualAddressMother { get; init; }
    public string? PostcodeOfUsualAddressMother { get; init; }
    public string? OrganisationCodePCTofResidenceMother { get; init; }
    public string? OrganisationCodeTypePCTofResidenceMother { get; init; }
    public string? UniqueBookingReferenceNumberConverted { get; init; }
    public string? PatientPathwayIdentifier { get; init; }
    public string? OrganisationCodePatientPathwayIdentifierIssuer { get; init; }
    public string? ReferralToTreatmentPeriodStatus { get; init; }
    public string? ReferralToTreatmentPeriodStartDate { get; init; }
    public string? ReferralToTreatmentPeriodEndDate { get; init; }
    public string? LeadCareActivityIndicator { get; init; }
    public string? AgeatCDSActivityDate { get; init; }
    public string? NHSServiceAgreementChangeDate { get; init; }
    public string? CDSActivityDate { get; init; }
    public string? AgeAsOnAdmission { get; init; }
    public string? AdminCategoryAtStart { get; init; }
    public string? HospitalProviderSpellDischargeReadyDate { get; init; }
    public string? LocationType { get; init; }
    public string? XMLVersion { get; init; }
    public string? ConfidentialityCategoryDerived { get; init; }
    public string? ReferralToTreatmentLengthDerived { get; init; }
    public string? AgeRangePatientdDerivedFromDOB { get; init; }
    public string? AgeRangeMotherDerivedFromDOB { get; init; }
    public string? AreaCodeDerivedFromPostcode { get; init; }
    public string? CDSGroup { get; init; }
    public string? FinishedIndicator { get; init; }
    public string? PCTDerivedfromGP { get; init; }
    public string? PCTTypeDerivedfromGP { get; init; }
    public string? GPPracticeDerived { get; init; }
    public string? GPPracticeMotherDerived { get; init; }
    public string? PCTDerivedfromderivedGPPractice { get; init; }
    public string? PCTMotherDerivedfromderivedGPPractice { get; init; }
    public string? SHAfromGPPractice { get; init; }
    public string? SHATypefromGPPractice { get; init; }
    public string? HospitalSpellDuration { get; init; }
    public string? MonthOfBirth { get; init; }
    public string? HomeBirthOrDelivery { get; init; }
    public string? ElectoralWardFromPostcode { get; init; }
    public string? PCTFromPostcode { get; init; }
    public string? PCTTypefromPostcode { get; init; }
    public string? SHAfromPostcode { get; init; }
    public string? SHATypefromPostcode { get; init; }
    public string? AreacodeFromProviderPostcode { get; init; }
    public string? AgeAtEndOfEpisode { get; init; }
    public string? AgeAtStartOfEpisode { get; init; }
    public string? YearOfBirth { get; init; }
    public string? YearOfBirthMother { get; init; }
    public string? MonthOfBirthMother { get; init; }
    public string? CensusArea { get; init; }
    public string? Country { get; init; }
    public string? CountyCode { get; init; }
    public string? CensusED { get; init; }
    public string? EDDistrictCode { get; init; }
    public string? ElectoralWardCode { get; init; }
    public string? GORCode { get; init; }
    public string? LocalUnitaryAuthority { get; init; }
    public string? OldSHACode { get; init; }
    public string? ElectoralArea { get; init; }
    public string? PrimeRecipient { get; init; }
    public string? CopyRecipients { get; init; }
}