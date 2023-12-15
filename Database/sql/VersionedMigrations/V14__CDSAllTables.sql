if object_id('omop_staging.insert_cds_line01') is not null
begin
	drop procedure omop_staging.insert_cds_line01;
end

drop type omop_staging.cds_line01_row ;
drop table omop_staging.cds_line01;

go

create table omop_staging.cds_line01
(
	MessageId uniqueidentifier not null,
	constraint PK_omop_staging_cds_line01_MessageId primary key (MessageId),
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	CdsVersion varchar(500) null,
	CdsRecordType varchar(500) null,
	CdsBulkReplacementGroup varchar(500) null,
	CdsProtocolIdentifier varchar(500) null,
	CdsUniqueIdentifier varchar(500) null,
	CDSUpdateType varchar(500) null,
	CdsApplicableDate varchar(500) null,
	CdsApplicableTime varchar(500) null,
	CDSExtractDate varchar(500) null,
	CDSExtractTime varchar(500) null,
	CDSReportPeriodStartDate varchar(500) null,
	CDSReportPeriodEndDate varchar(500) null,
	CDSCensusDate varchar(500) null,
	CDSActivityDate varchar(500) null,
	CDSSenderIdentity varchar(500) null,
	CDSPrimaryRecipientIdentity varchar(500) null,
	CDSCopyRecipientIdentity1 varchar(500) null,
	CDSCopyRecipientIdentity2 varchar(500) null,
	CDSCopyRecipientIdentity3 varchar(500) null,
	CDSCopyRecipientIdentity4 varchar(500) null,
	CDSCopyRecipientIdentity5 varchar(500) null,
	CDSCopyRecipientIdentity6 varchar(500) null,
	CDSCopyRecipientIdentity7 varchar(500) null,
	UniqueBookingReferenceNumberConverted varchar(500) null,
	PatientPathwayIdentifier varchar(500) null,
	OrganisationCodeofthePatientPathwayIdentifier varchar(500) null,
	ReferralToTreatmentPeriodStatus varchar(500) null,
	WaitingTimeMeasurementType varchar(500) null,
	ReferralToTreatmentPeriodStartDate varchar(500) null,
	ReferralToTreatmentPeriodEndDate varchar(500) null,
	LocalPatientID varchar(500) null,
	OrganisationCodeLocalPatientID varchar(500) null,
	NHSNumberStatusIndicator varchar(500) null,
	NHSNumber varchar(500) null,
	WithheldFlag varchar(500) null,
	WithheldIdentityReason varchar(500) null,
	DateofBirth varchar(500) null,
	PatientNameType varchar(500) null,
	PatientFullName varchar(500) null,
	PatientRequestedName varchar(500) null,
	PatientTitle varchar(500) null,
	PatientForename varchar(500) null,
	PatientSurname varchar(500) null,
	PatientNameSuffix varchar(500) null,
	PatientInitials varchar(500) null,
	PatientAddressType varchar(500) null,
	PatientUnstructuredAddress varchar(500) null,
	PatientAddressStructured1 varchar(500) null,
	PatientAddressStructured2 varchar(500) null,
	PatientAddressStructured3 varchar(500) null,
	PatientAddressStructured4 varchar(500) null,
	PatientAddressStructured5 varchar(500) null,
	Postcode varchar(500) null,
	OrganisationCodeResidenceResponsibility varchar(500) null,
	PersonCurrentGenderCode varchar(500) null,
	CarerSupportIndicator varchar(500) null,
	EthnicCategory varchar(500) null,
	PersonMaritalStatus varchar(500) null,
	BirthWeight varchar(500) null,
	LiveStillBirthIndicator varchar(500) null,
	TotalPreviousPregnancies varchar(500) null,
	CommissioningSerialNumber varchar(500) null,
	NHSServiceAgreementLineNumber varchar(500) null,
	ProvidersReferenceNumber varchar(500) null,
	CommissionersReferenceNumber varchar(500) null,
	OrganisationCodeCodeofProvider varchar(500) null,
	OrganisationCodeCodeofCommissioner varchar(500) null,
	NHSServiceAgreementChangeDate varchar(500) null,
	GeneralMedicalPractitionerSpecified varchar(500) null,
	GPPracticeRegistered varchar(500) null,
	ReferrerCode varchar(500) null,
	ReferringOrganisationCode varchar(500) null,
	DirectAccessReferralIndicator varchar(500) null,
	ConsultantCode varchar(500) null,
	CareProfessionalMainSpecialtyCode varchar(500) null,
	ActivityTreatmentFunctionCode varchar(500) null,
	LocalSubSpecialtyCode varchar(500) null
);

create table omop_staging.cds_diagnosis
(
	DiagnosisId int not null identity,
	MessageId uniqueidentifier not null,
	DiagnosisCode varchar(500) null,
	PresentOnAdmissionIndicator varchar(500) null,
	IsPrimaryDiagnosis bit not null,
	constraint PK_omop_staging_cds_diagnosis_DiagnosisId primary key (DiagnosisId),
	constraint FK_omop_staging_cds_diagnosis_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_line02
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	LineCount varchar(500) not null,
	DiagnosisSchemeInUse varchar(500) null,
	constraint PK_omop_staging_cds_line02_MessageId_LineCount primary key (MessageId, LineCount),
	constraint FK_omop_staging_cds_line02_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_procedure
(
	ProcedureId int not null identity,
	MessageId uniqueidentifier not null,
	IsPrimaryProcedure bit not null,
	PrimaryProcedure varchar(500) null,
	PrimaryProcedureDate varchar(500) null,
	MainOperatingHealthcareProfessionalRegistrationIssuerCode varchar(500) null,
	MainOperatingHealthcareProfessionalRegistrationEntryIdentifier varchar(500) null,
	ResponsibleAnaesthetistProfessionalRegistrationIssuerCode varchar(500) null,
	ResponsibleAnaesthetistProfessionalRegistrationEntryIdentifier varchar(500) null,
	constraint PK_omop_staging_cds_procedure_ProcedureId primary key (ProcedureId)
);

create table omop_staging.cds_line03
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	LineCount varchar(500) not null,
	ProcedureSchemeInUse varchar(500),
	constraint PK_omop_staging_cds_line03_MessageId_LineCount primary key (MessageId, LineCount),
	constraint FK_omop_staging_cds_line03_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_line04
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	LineCount varchar(500) not null,
	LocationClass varchar(500) null,
	SiteCodeofTreatment varchar(500) null,
	ActivityLocationType varchar(500) null,
	IntendedClinicalCareIntensityCode varchar(500) null,
	AgeGroupIntended varchar(500) null,
	SexofPatientsCode varchar(500) null,
	WardNightPeriodAvailabilityCode varchar(500) null,
	WardDayPeriodAvailabilityCode varchar(500) null,
	StartDateWardStay varchar(500) null,
	StartTimeWardStay varchar(500) null,
	EndDateWardStay varchar(500) null,
	EndTimeWardStay varchar(500) null,
	WardSecurityLevel varchar(500) null,
	WardCode varchar(500) null,
	ClinicCode varchar(500) null,
	DetainedandorLongTermPsychiatricCensusDate varchar(500) null,
	constraint PK_omop_staging_cds_line04_MessageId_LineCount primary key (MessageId, LineCount),
	constraint FK_omop_staging_cds_line04_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_overseas_visitors
(
	OverseasVisitorId int not null identity,
	MessageId uniqueidentifier not null,
	constraint PK_omop_staging_cds_overseas_visitors_OverseasVisitorId primary key (OverseasVisitorId),
	constraint FK_omop_staging_cds_overseas_visitors_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId),
	OverseasVisitorsClassification varchar(500) null,
	OverseasVisitorsStatusStartDate varchar(500) null,
	OverseasVisitorsStatusEndDate varchar(500) null
);

create table omop_staging.cds_line05
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	HospitalProviderSpellNumber varchar(500) null,
	AdministrativeCategoryCode varchar(500) null,
	PatientClassification varchar(500) null,
	AdmissionMethodCode varchar(500) null,
	SourceofAdmissionCode varchar(500) null,
	StartDateHospitalProviderSpell varchar(500) null,
	StartTimeHospitalProviderSpell varchar(500) null,
	AgeOnAdmission varchar(500) null,
	AmbulanceIncidentNumber varchar(500) null,
	OrganisationCodeConveyingAmbulanceTrust varchar(500) null,
	DischargeDestinationCode varchar(500) null,
	DischargeMethod varchar(500) null,
	DischargeReadyDateHospitalProviderSpell varchar(500) null,
	DischargeDateHospitalProviderSpell varchar(500) null,
	DischargeTimeHospitalProviderSpell varchar(500) null,
	DischargetoHospitalatHomeServiceIndicator varchar(500) null,
	MentalHealthActLegalClassificationCodeonAdmission varchar(500) null,
	MentalHealthActLegalStatusClassificationCodeAtCensusDate varchar(500) null,
	DateDetentionCommenced varchar(500) null,
	AgeAtCensus varchar(500) null,
	DurationOfCareToPsychiatricCensusDate varchar(500) null,
	DurationOfDetention varchar(500) null,
	MentalHealthAct2007MentalCategory varchar(500) null,
	StatusOfPatientIncludedInThePsychiatricCensusCode varchar(500) null,
	EpisodeNumber varchar(500) null,
	LastEpisodeinSpellIndicator varchar(500) null,
	OperationStatusCode varchar(500) null,
	NeonatalLevelofCare varchar(500) null,
	FirstRegularDayNightAdmission varchar(500) null,
	PsychiatricPatientStatus varchar(500) null,
	EpisodeStartDate varchar(500) null,
	EpisodeStartTime varchar(500) null,
	EpisodeEndDate varchar(500) null,
	EpisodeEndTime varchar(500) null,
	AgeAtCDSActivityDate varchar(500) null,
	MultiProfessionalorMultidisciplinaryConsultationIndicationCode varchar(500) null,
	RehabilitationAssessmentTeamType varchar(500) null,
	LengthofStayAdjustmentRehabilitation varchar(500) null,
	LengthOfStayAdjustmentSpecialistPalliativeCare varchar(500) null,
	DurationofElectiveWait varchar(500) null,
	IntendedManagement varchar(500) null,
	DecidedtoAdmitDate varchar(500) null,
	EarliestReasonableOfferDate varchar(500) null,
	constraint PK_omop_staging_cds_line05_MessageId_LineId primary key (MessageId, LineId),
	constraint FK_omop_staging_cds_line05_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_line06
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	LineCount varchar(500) not null,
	CriticalCareTypeID varchar(500) null,
	CriticalCareLocalIdentifier varchar(500) null,
	CriticalCareStartDate varchar(500) null,
	CriticalCareStartTime varchar(500) null,
	CriticalCareUnitFunction varchar(500) null,
	GestationLengthAtDelivery varchar(500) null,
	UnitBedConfiguration varchar(500) null,
	CriticalCareAdmissionSource varchar(500) null,
	CriticalCareSourceLocation varchar(500) null,
	CriticalCareAdmissionType varchar(500) null,
	AdvancedRespiratorySupportDays varchar(500) null,
	BasicRespiratorySupportsDays varchar(500) null,
	AdvancedCardiovascularSupportDays varchar(500) null,
	BasicCardiovascularSupportDays varchar(500) null,
	RenalSupportDays varchar(500) null,
	NeurologicalSupportDays varchar(500) null,
	GastroIntestinalSupportDays varchar(500) null,
	DermatologicalSupportDays varchar(500) null,
	LiverSupportDays varchar(500) null,
	OrganSupportMaximum varchar(500) null,
	CriticalCareLevel2Days varchar(500) null,
	CriticalCareLevel3Days varchar(500) null,
	CriticalCareDischargeDate varchar(500) null,
	CriticalCareDischargeTime varchar(500) null,
	CriticalCareDischargeReadyDate varchar(500) null,
	CriticalCareDischargeReadyTime varchar(500) null,
	CriticalCareDischargeStatus varchar(500) null,
	CriticalCareDischargeDestination varchar(500) null,
	CriticalCareDischargeLocation varchar(500) null,
	constraint PK_omop_staging_cds_line06_MessageId_LineCount primary key (MessageId, LineCount),
	constraint FK_omop_staging_cds_line06_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_critial_care_activity_codes
(
	Id int not null identity,
	MessageId uniqueidentifier not null,
	Code varchar(500) not null,
	constraint PK_omop_staging_cds_critial_care_activity_codes_Id primary key (Id),
	constraint FK_omop_staging_cds_critial_care_activity_codes_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_high_cost_drugs
(
	Id int not null identity,
	MessageId uniqueidentifier not null,
	Code varchar(500) not null,
	constraint PK_omop_staging_cds_high_cost_drugs_Id primary key (Id),
	constraint FK_omop_staging_cds_high_cost_drugs_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_line07
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	CriticalCareCount varchar(500) null,
	LineCount varchar(500) not null,
	ActivityDateCriticalCare varchar(500) null,
	PersonWeight varchar(500) null,
	constraint PK_omop_staging_cds_line07_MessageId_LineCount primary key (MessageId, LineCount),
	constraint FK_omop_staging_cds_line07_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_birth_details
(
	BirthDetailsId int not null identity,
	MessageId uniqueidentifier not null,
	BirthOrder varchar(500) null,
	DeliveryMethod varchar(500) null,
	GestationLengthAssessment varchar(500) null,
	ResuscitationMethod varchar(500) null,
	StatusofPersonConductingDelivery varchar(500) null,
	LocationClass varchar(500) null,
	DeliveryPlaceTypeActual varchar(500) null,
	ActivityLocationType varchar(500) null,
	LocalPatientID varchar(500) null,
	OrganisationCodeLocalPatientID varchar(500) null,
	NHSNumber varchar(500) null,
	NHSNumberStatusIndicator varchar(500) null,
	WithheldFlag varchar(500) null,
	WithheldIdentityReason varchar(500) null,
	BabyBirthDate varchar(500) null,
	BirthWeight varchar(500) null,
	LiveStillBirth varchar(500) null,
	PersonGenderCurrent varchar(500) null,
	OverseasVisitorStatusClassificationAtCDSActivityDate varchar(500) null,
	constraint PK_omop_staging_cds_birth_details_BirthDetailsId primary key (BirthDetailsId),
	constraint FK_omop_staging_cds_birth_details_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_line08
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	NumberofBabies varchar(500) null,
	FirstAntenatalAssessmentDate varchar(500) null,
	GeneralMedicalPractitionerAntenatalCare varchar(500) null,
	GeneralMedicalPractitionerPracticeAntenatalCare varchar(500) null,
	LocationClass varchar(500) null,
	ActivityLocationType varchar(500) null,
	DeliveryPlaceTypeIntended varchar(500) null,
	DeliveryPlaceChangeReason varchar(500) null,
	AnaestheticDuringLabourDelivery varchar(500) null,
	AnaestheticGivenPostLabourDelivery varchar(500) null,
	GestationLengthLabourOnset varchar(500) null,
	LabourDeliveryOnsetMethod varchar(500) null,
	DeliveryDate varchar(500) null,
	AgeAtCDSActivityDate varchar(500) null,
	LocalPatientID varchar(500) null,
	OrganisationCodeLocalPatientID varchar(500) null,
	NHSNumberStatusIndicator varchar(500) null,
	NHSNumber varchar(500) null,
	WithheldFlag varchar(500) null,
	WithheldIdentityReason varchar(500) null,
	MotherBirthDate varchar(500) null,
	OverseasVisitorStatusAtCDSActivityDate varchar(500) null,
	PatientAddressType varchar(500) null,
	PatientUnstructuredAddress varchar(500) null,
	PatientStructured1 varchar(500) null,
	PatientStructured2 varchar(500) null,
	PatientStructured3 varchar(500) null,
	PatientStructured4 varchar(500) null,
	PatientStructured5 varchar(500) null,
	Postcode varchar(500) null,
	OrganisationCodeResidenceResponsibility varchar(500) null,
	constraint PK_omop_staging_cds_line08_MessageId_LineId primary key (MessageId, LineId),
	constraint FK_omop_staging_cds_line08_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_line09
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	AttendanceIdentifier varchar(500) null,
	AdministrativeCategoryCode varchar(500) null,
	AttendedOrDidNotAttendCode varchar(500) null,
	FirstAttendanceCode varchar(500) null,
	MedicalStaffTypeSeeingPatient varchar(500) null,
	OperationStatusCode varchar(500) null,
	OutcomeofAttendanceCode varchar(500) null,
	AppointmentDate varchar(500) null,
	AppointmentTime varchar(500) null,
	ExpectedDurationOfAppointment varchar(500) null,
	AgeAtCDSActivityDate varchar(500) null,
	OverseasVisitorStatusClassificationAtCDSActivityDate varchar(500) null,
	EarliestReasonableOfferDate varchar(500) null,
	EarliestClinicallyAppropriateDate varchar(500) null,
	ConsultationMediumUsed varchar(500) null,
	MultiProfessionalorMultidisciplinaryConsultationIndicationCode varchar(500) null,
	RehabilitationAssessmentTeamType varchar(500) null,
	PriorityTypeCode varchar(500) null,
	ServiceTypeRequestedCode varchar(500) null,
	SourceofReferralforOutpatients varchar(500) null,
	ReferralRequestReceivedDate varchar(500) null,
	LastDNAorPatientCancelledDate varchar(500) null,
	constraint PK_omop_staging_cds_line09_MessageId_LineId primary key (MessageId, LineId),
	constraint FK_omop_staging_cds_line09_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_line10
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	EALAdmissionEntryNumber varchar(500) null,
	AdministrativeCategoryCode varchar(500) null,
	CountofDaysSuspended varchar(500) null,
	ElectiveAdmissionListStatus varchar(500) null,
	ElectiveAdmissionTypeCode varchar(500) null,
	IntendedManagementCode varchar(500) null,
	PriorityTypeCode varchar(500) null,
	IntendedProcedureStatusCode varchar(500) null,
	DecidedtoAdmitDate varchar(500) null,
	AgeAtCDSActivityDate varchar(500) null,
	OverseasVisitorStatusClassificationAtCDSActivityDate varchar(500) null,
	GuaranteedAdmissionDate varchar(500) null,
	LastDNAorCancelledDate varchar(500) null,
	WaitingListEntryLastReviewedDate varchar(500) null,
	AdmissionOfferOutcome varchar(500) null,
	OfferedforAdmissionDate varchar(500) null,
	EarliestReasonableOfferDate varchar(500) null,
	OriginalDecidedtoAdmitDate varchar(500) null,
	RemovalReasonCode varchar(500) null,
	RemovalDate varchar(500) null,
	SuspensionStartDate varchar(500) null,
	SuspensionEndDate varchar(500) null,
	constraint PK_omop_staging_cds_line10_MessageId_LineId primary key (MessageId, LineId),
	constraint FK_omop_staging_cds_line10_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_line11
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	AttendanceNumber varchar(500) null,
	ArrivalModeCode varchar(500) null,
	AttendanceCategoryCode varchar(500) null,
	AttendanceDisposal varchar(500) null,
	IncidentLocationType varchar(500) null,
	PatientGroup varchar(500) null,
	SourceofReferral varchar(500) null,
	AEDepartmentType varchar(500) null,
	ArrivalDate varchar(500) null,
	ArrivalTime varchar(500) null,
	AgeAtCDSActivityDate varchar(500) null,
	OverseasVisitorStatusClassificationAtCDSActivityDate varchar(500) null,
	InitialAssessmentDate varchar(500) null,
	InitialAssessmentTime varchar(500) null,
	DateSeenforTreatment varchar(500) null,
	TimeSeenforTreatment varchar(500) null,
	AttendanceConclusionDate varchar(500) null,
	AttendanceConclusionTime varchar(500) null,
	DepartureDate varchar(500) null,
	DepartureTime varchar(500) null,
	AmbulanceIncidentNumber varchar(500) null,
	OrganisationCodeConveyingAmbulanceTrust varchar(500) null,
	AEStaffMemberCode varchar(500) null,
	constraint PK_omop_staging_cds_line11_MessageId_LineId primary key (MessageId, LineId),
	constraint FK_omop_staging_cds_line11_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_secondary_investigations
(
	SecondaryInvestigationId int not null identity,
	MessageId uniqueidentifier not null,
	Code varchar(500) not null,
	constraint PK_omop_staging_cds_secondary_investigations_SecondaryInvestigationId primary key (SecondaryInvestigationId),
	constraint FK_omop_staging_cds_secondary_investigations_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create table omop_staging.cds_line12
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	LineCount varchar(500) not null,
	InvestigationSchemeinUse varchar(500) null,
	PrimaryInvestigation varchar(500) null,
	constraint PK_omop_staging_cds_line12_MessageId_LineCount primary key (MessageId, LineCount),
	constraint FK_omop_staging_cds_line12_MessageId foreign key (MessageId) references omop_staging.cds_line01 (MessageId)
);

create type omop_staging.cds_line01_row as table
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	CdsVersion varchar(500) null,
	CdsRecordType varchar(500) null,
	CdsBulkReplacementGroup varchar(500) null,
	CdsProtocolIdentifier varchar(500) null,
	CdsUniqueIdentifier varchar(500) null,
	CDSUpdateType varchar(500) null,
	CdsApplicableDate varchar(500) null,
	CdsApplicableTime varchar(500) null,
	CDSExtractDate varchar(500) null,
	CDSExtractTime varchar(500) null,
	CDSReportPeriodStartDate varchar(500) null,
	CDSReportPeriodEndDate varchar(500) null,
	CDSCensusDate varchar(500) null,
	CDSActivityDate varchar(500) null,
	CDSSenderIdentity varchar(500) null,
	CDSPrimaryRecipientIdentity varchar(500) null,
	CDSCopyRecipientIdentity1 varchar(500) null,
	CDSCopyRecipientIdentity2 varchar(500) null,
	CDSCopyRecipientIdentity3 varchar(500) null,
	CDSCopyRecipientIdentity4 varchar(500) null,
	CDSCopyRecipientIdentity5 varchar(500) null,
	CDSCopyRecipientIdentity6 varchar(500) null,
	CDSCopyRecipientIdentity7 varchar(500) null,
	UniqueBookingReferenceNumberConverted varchar(500) null,
	PatientPathwayIdentifier varchar(500) null,
	OrganisationCodeofthePatientPathwayIdentifier varchar(500) null,
	ReferralToTreatmentPeriodStatus varchar(500) null,
	WaitingTimeMeasurementType varchar(500) null,
	ReferralToTreatmentPeriodStartDate varchar(500) null,
	ReferralToTreatmentPeriodEndDate varchar(500) null,
	LocalPatientID varchar(500) null,
	OrganisationCodeLocalPatientID varchar(500) null,
	NHSNumberStatusIndicator varchar(500) null,
	NHSNumber varchar(500) null,
	WithheldFlag varchar(500) null,
	WithheldIdentityReason varchar(500) null,
	DateofBirth varchar(500) null,
	PatientNameType varchar(500) null,
	PatientFullName varchar(500) null,
	PatientRequestedName varchar(500) null,
	PatientTitle varchar(500) null,
	PatientForename varchar(500) null,
	PatientSurname varchar(500) null,
	PatientNameSuffix varchar(500) null,
	PatientInitials varchar(500) null,
	PatientAddressType varchar(500) null,
	PatientUnstructuredAddress varchar(500) null,
	PatientAddressStructured1 varchar(500) null,
	PatientAddressStructured2 varchar(500) null,
	PatientAddressStructured3 varchar(500) null,
	PatientAddressStructured4 varchar(500) null,
	PatientAddressStructured5 varchar(500) null,
	Postcode varchar(500) null,
	OrganisationCodeResidenceResponsibility varchar(500) null,
	PersonCurrentGenderCode varchar(500) null,
	CarerSupportIndicator varchar(500) null,
	EthnicCategory varchar(500) null,
	PersonMaritalStatus varchar(500) null,
	BirthWeight varchar(500) null,
	LiveStillBirthIndicator varchar(500) null,
	TotalPreviousPregnancies varchar(500) null,
	CommissioningSerialNumber varchar(500) null,
	NHSServiceAgreementLineNumber varchar(500) null,
	ProvidersReferenceNumber varchar(500) null,
	CommissionersReferenceNumber varchar(500) null,
	OrganisationCodeCodeofProvider varchar(500) null,
	OrganisationCodeCodeofCommissioner varchar(500) null,
	NHSServiceAgreementChangeDate varchar(500) null,
	GeneralMedicalPractitionerSpecified varchar(500) null,
	GPPracticeRegistered varchar(500) null,
	ReferrerCode varchar(500) null,
	ReferringOrganisationCode varchar(500) null,
	DirectAccessReferralIndicator varchar(500) null,
	ConsultantCode varchar(500) null,
	CareProfessionalMainSpecialtyCode varchar(500) null,
	ActivityTreatmentFunctionCode varchar(500) null,
	LocalSubSpecialtyCode varchar(500) null
);

create type omop_staging.cds_diagnosis_row  as table
(
	MessageId uniqueidentifier not null,
	DiagnosisCode varchar(500) null,
	PresentOnAdmissionIndicator varchar(500) null,
	IsPrimaryDiagnosis bit not null
);

create type omop_staging.cds_line02_row  as table
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	LineCount varchar(500) not null,
	DiagnosisSchemeInUse varchar(500) null
);

create type omop_staging.cds_procedure_row  as table
(
	MessageId uniqueidentifier not null,
	IsPrimaryProcedure bit not null,
	PrimaryProcedure varchar(500) null,
	PrimaryProcedureDate varchar(500) null,
	MainOperatingHealthcareProfessionalRegistrationIssuerCode varchar(500) null,
	MainOperatingHealthcareProfessionalRegistrationEntryIdentifier varchar(500) null,
	ResponsibleAnaesthetistProfessionalRegistrationIssuerCode varchar(500) null,
	ResponsibleAnaesthetistProfessionalRegistrationEntryIdentifier varchar(500) null
);

create type omop_staging.cds_line03_row  as table
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	LineCount varchar(500) not null,
	ProcedureSchemeInUse varchar(500)
);

create type omop_staging.cds_line04_row  as table
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	LineCount varchar(500) null,
	LocationClass varchar(500) null,
	SiteCodeofTreatment varchar(500) null,
	ActivityLocationType varchar(500) null,
	IntendedClinicalCareIntensityCode varchar(500) null,
	AgeGroupIntended varchar(500) null,
	SexofPatientsCode varchar(500) null,
	WardNightPeriodAvailabilityCode varchar(500) null,
	WardDayPeriodAvailabilityCode varchar(500) null,
	StartDateWardStay varchar(500) null,
	StartTimeWardStay varchar(500) null,
	EndDateWardStay varchar(500) null,
	EndTimeWardStay varchar(500) null,
	WardSecurityLevel varchar(500) null,
	WardCode varchar(500) null,
	ClinicCode varchar(500) null,
	DetainedandorLongTermPsychiatricCensusDate varchar(500) null
);

create type omop_staging.cds_overseas_visitors_row  as table
(
	MessageId uniqueidentifier not null,
	OverseasVisitorsClassification varchar(500) null,
	OverseasVisitorsStatusStartDate varchar(500) null,
	OverseasVisitorsStatusEndDate varchar(500) null
);

create type omop_staging.cds_line05_row  as table
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	HospitalProviderSpellNumber varchar(500) null,
	AdministrativeCategoryCode varchar(500) null,
	PatientClassification varchar(500) null,
	AdmissionMethodCode varchar(500) null,
	SourceofAdmissionCode varchar(500) null,
	StartDateHospitalProviderSpell varchar(500) null,
	StartTimeHospitalProviderSpell varchar(500) null,
	AgeOnAdmission varchar(500) null,
	AmbulanceIncidentNumber varchar(500) null,
	OrganisationCodeConveyingAmbulanceTrust varchar(500) null,
	DischargeDestinationCode varchar(500) null,
	DischargeMethod varchar(500) null,
	DischargeReadyDateHospitalProviderSpell varchar(500) null,
	DischargeDateHospitalProviderSpell varchar(500) null,
	DischargeTimeHospitalProviderSpell varchar(500) null,
	DischargetoHospitalatHomeServiceIndicator varchar(500) null,
	MentalHealthActLegalClassificationCodeonAdmission varchar(500) null,
	MentalHealthActLegalStatusClassificationCodeAtCensusDate varchar(500) null,
	DateDetentionCommenced varchar(500) null,
	AgeAtCensus varchar(500) null,
	DurationOfCareToPsychiatricCensusDate varchar(500) null,
	DurationOfDetention varchar(500) null,
	MentalHealthAct2007MentalCategory varchar(500) null,
	StatusOfPatientIncludedInThePsychiatricCensusCode varchar(500) null,
	EpisodeNumber varchar(500) null,
	LastEpisodeinSpellIndicator varchar(500) null,
	OperationStatusCode varchar(500) null,
	NeonatalLevelofCare varchar(500) null,
	FirstRegularDayNightAdmission varchar(500) null,
	PsychiatricPatientStatus varchar(500) null,
	EpisodeStartDate varchar(500) null,
	EpisodeStartTime varchar(500) null,
	EpisodeEndDate varchar(500) null,
	EpisodeEndTime varchar(500) null,
	AgeAtCDSActivityDate varchar(500) null,
	MultiProfessionalorMultidisciplinaryConsultationIndicationCode varchar(500) null,
	RehabilitationAssessmentTeamType varchar(500) null,
	LengthofStayAdjustmentRehabilitation varchar(500) null,
	LengthOfStayAdjustmentSpecialistPalliativeCare varchar(500) null,
	DurationofElectiveWait varchar(500) null,
	IntendedManagement varchar(500) null,
	DecidedtoAdmitDate varchar(500) null,
	EarliestReasonableOfferDate varchar(500) null
);

create type omop_staging.cds_line06_row  as table
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	LineCount varchar(500) null,
	CriticalCareTypeID varchar(500) null,
	CriticalCareLocalIdentifier varchar(500) null,
	CriticalCareStartDate varchar(500) null,
	CriticalCareStartTime varchar(500) null,
	CriticalCareUnitFunction varchar(500) null,
	GestationLengthAtDelivery varchar(500) null,
	UnitBedConfiguration varchar(500) null,
	CriticalCareAdmissionSource varchar(500) null,
	CriticalCareSourceLocation varchar(500) null,
	CriticalCareAdmissionType varchar(500) null,
	AdvancedRespiratorySupportDays varchar(500) null,
	BasicRespiratorySupportsDays varchar(500) null,
	AdvancedCardiovascularSupportDays varchar(500) null,
	BasicCardiovascularSupportDays varchar(500) null,
	RenalSupportDays varchar(500) null,
	NeurologicalSupportDays varchar(500) null,
	GastroIntestinalSupportDays varchar(500) null,
	DermatologicalSupportDays varchar(500) null,
	LiverSupportDays varchar(500) null,
	OrganSupportMaximum varchar(500) null,
	CriticalCareLevel2Days varchar(500) null,
	CriticalCareLevel3Days varchar(500) null,
	CriticalCareDischargeDate varchar(500) null,
	CriticalCareDischargeTime varchar(500) null,
	CriticalCareDischargeReadyDate varchar(500) null,
	CriticalCareDischargeReadyTime varchar(500) null,
	CriticalCareDischargeStatus varchar(500) null,
	CriticalCareDischargeDestination varchar(500) null,
	CriticalCareDischargeLocation varchar(500) null
);

create type omop_staging.cds_critial_care_activity_codes_row  as table
(
	MessageId uniqueidentifier not null,
	Code varchar(500) not null
);

create type omop_staging.cds_high_cost_drugs_row  as table
(
	MessageId uniqueidentifier not null,
	Code varchar(500) not null
);

create type omop_staging.cds_line07_row  as table
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	CriticalCareCount varchar(500) null,
	LineCount varchar(500) null,
	ActivityDateCriticalCare varchar(500) null,
	PersonWeight varchar(500) null
);

create type omop_staging.cds_birth_details_row  as table
(
	MessageId uniqueidentifier not null,
	BirthOrder varchar(500) null,
	DeliveryMethod varchar(500) null,
	GestationLengthAssessment varchar(500) null,
	ResuscitationMethod varchar(500) null,
	StatusofPersonConductingDelivery varchar(500) null,
	LocationClass varchar(500) null,
	DeliveryPlaceTypeActual varchar(500) null,
	ActivityLocationType varchar(500) null,
	LocalPatientID varchar(500) null,
	OrganisationCodeLocalPatientID varchar(500) null,
	NHSNumber varchar(500) null,
	NHSNumberStatusIndicator varchar(500) null,
	WithheldFlag varchar(500) null,
	WithheldIdentityReason varchar(500) null,
	BabyBirthDate varchar(500) null,
	BirthWeight varchar(500) null,
	LiveStillBirth varchar(500) null,
	PersonGenderCurrent varchar(500) null,
	OverseasVisitorStatusClassificationAtCDSActivityDate varchar(500) null
);

create type omop_staging.cds_line08_row  as table
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	NumberofBabies varchar(500) null,
	FirstAntenatalAssessmentDate varchar(500) null,
	GeneralMedicalPractitionerAntenatalCare varchar(500) null,
	GeneralMedicalPractitionerPracticeAntenatalCare varchar(500) null,
	LocationClass varchar(500) null,
	ActivityLocationType varchar(500) null,
	DeliveryPlaceTypeIntended varchar(500) null,
	DeliveryPlaceChangeReason varchar(500) null,
	AnaestheticDuringLabourDelivery varchar(500) null,
	AnaestheticGivenPostLabourDelivery varchar(500) null,
	GestationLengthLabourOnset varchar(500) null,
	LabourDeliveryOnsetMethod varchar(500) null,
	DeliveryDate varchar(500) null,
	AgeAtCDSActivityDate varchar(500) null,
	LocalPatientID varchar(500) null,
	OrganisationCodeLocalPatientID varchar(500) null,
	NHSNumberStatusIndicator varchar(500) null,
	NHSNumber varchar(500) null,
	WithheldFlag varchar(500) null,
	WithheldIdentityReason varchar(500) null,
	MotherBirthDate varchar(500) null,
	OverseasVisitorStatusAtCDSActivityDate varchar(500) null,
	PatientAddressType varchar(500) null,
	PatientUnstructuredAddress varchar(500) null,
	PatientStructured1 varchar(500) null,
	PatientStructured2 varchar(500) null,
	PatientStructured3 varchar(500) null,
	PatientStructured4 varchar(500) null,
	PatientStructured5 varchar(500) null,
	Postcode varchar(500) null,
	OrganisationCodeResidenceResponsibility varchar(500) null
);

create type omop_staging.cds_line09_row  as table
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	AttendanceIdentifier varchar(500) null,
	AdministrativeCategoryCode varchar(500) null,
	AttendedOrDidNotAttendCode varchar(500) null,
	FirstAttendanceCode varchar(500) null,
	MedicalStaffTypeSeeingPatient varchar(500) null,
	OperationStatusCode varchar(500) null,
	OutcomeofAttendanceCode varchar(500) null,
	AppointmentDate varchar(500) null,
	AppointmentTime varchar(500) null,
	ExpectedDurationOfAppointment varchar(500) null,
	AgeAtCDSActivityDate varchar(500) null,
	OverseasVisitorStatusClassificationAtCDSActivityDate varchar(500) null,
	EarliestReasonableOfferDate varchar(500) null,
	EarliestClinicallyAppropriateDate varchar(500) null,
	ConsultationMediumUsed varchar(500) null,
	MultiProfessionalorMultidisciplinaryConsultationIndicationCode varchar(500) null,
	RehabilitationAssessmentTeamType varchar(500) null,
	PriorityTypeCode varchar(500) null,
	ServiceTypeRequestedCode varchar(500) null,
	SourceofReferralforOutpatients varchar(500) null,
	ReferralRequestReceivedDate varchar(500) null,
	LastDNAorPatientCancelledDate varchar(500) null
);

create type omop_staging.cds_line10_row  as table
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	EALAdmissionEntryNumber varchar(500) null,
	AdministrativeCategoryCode varchar(500) null,
	CountofDaysSuspended varchar(500) null,
	ElectiveAdmissionListStatus varchar(500) null,
	ElectiveAdmissionTypeCode varchar(500) null,
	IntendedManagementCode varchar(500) null,
	PriorityTypeCode varchar(500) null,
	IntendedProcedureStatusCode varchar(500) null,
	DecidedtoAdmitDate varchar(500) null,
	AgeAtCDSActivityDate varchar(500) null,
	OverseasVisitorStatusClassificationAtCDSActivityDate varchar(500) null,
	GuaranteedAdmissionDate varchar(500) null,
	LastDNAorCancelledDate varchar(500) null,
	WaitingListEntryLastReviewedDate varchar(500) null,
	AdmissionOfferOutcome varchar(500) null,
	OfferedforAdmissionDate varchar(500) null,
	EarliestReasonableOfferDate varchar(500) null,
	OriginalDecidedtoAdmitDate varchar(500) null,
	RemovalReasonCode varchar(500) null,
	RemovalDate varchar(500) null,
	SuspensionStartDate varchar(500) null,
	SuspensionEndDate varchar(500) null
);

create type omop_staging.cds_line11_row  as table
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	AttendanceNumber varchar(500) null,
	ArrivalModeCode varchar(500) null,
	AttendanceCategoryCode varchar(500) null,
	AttendanceDisposal varchar(500) null,
	IncidentLocationType varchar(500) null,
	PatientGroup varchar(500) null,
	SourceofReferral varchar(500) null,
	AEDepartmentType varchar(500) null,
	ArrivalDate varchar(500) null,
	ArrivalTime varchar(500) null,
	AgeAtCDSActivityDate varchar(500) null,
	OverseasVisitorStatusClassificationAtCDSActivityDate varchar(500) null,
	InitialAssessmentDate varchar(500) null,
	InitialAssessmentTime varchar(500) null,
	DateSeenforTreatment varchar(500) null,
	TimeSeenforTreatment varchar(500) null,
	AttendanceConclusionDate varchar(500) null,
	AttendanceConclusionTime varchar(500) null,
	DepartureDate varchar(500) null,
	DepartureTime varchar(500) null,
	AmbulanceIncidentNumber varchar(500) null,
	OrganisationCodeConveyingAmbulanceTrust varchar(500) null,
	AEStaffMemberCode varchar(500) null
);

create type omop_staging.cds_secondary_investigations_row  as table
(
	MessageId uniqueidentifier not null,
	Code varchar(500) not null
);

create type omop_staging.cds_line12_row  as table
(
	MessageId uniqueidentifier not null,
	LineId varchar(500) not null,
	RecordConnectionIdentifier varchar(500) null,
	LineCount varchar(500) null,
	InvestigationSchemeinUse varchar(500) null,
	PrimaryInvestigation varchar(500) null
);