
create table omop_staging.sus_OP
(
    MessageId uniqueidentifier NOT null,
	constraint PK_omop_staging_sus_OP_MessageId primary key (MessageId),
    GeneratedRecordIdentifier varchar(500) null,
    ReasonforAccess varchar(500) null,
    CDStype varchar(500) null,
    Protocolidentifier varchar(500) null,
    UniqueCDSidentifier varchar(500) null,
    SUSgeneratedspellID varchar(500) null,
    Updatetype varchar(500) null,
    BulkreplacementCDSgroup varchar(500) null,
    Testindicator varchar(500) null,
    Applicabledatetime varchar(500) null,
    Censusdate varchar(500) null,
    Extractdatetime varchar(500) null,
    ReportperiodStartDate varchar(500) null,
    ReportperiodEndDate varchar(500) null,
    OrganisationcodeSenderoftransaction varchar(500) null,
    OrganisationCodeTypeofSender varchar(500) null,
    SubmissionDate varchar(500) null,
    CDSInterchangeID varchar(500) null,
    LocalPatientIdentifier varchar(500) null,
    OrganisationCodeLocalPatientIdentifier varchar(500) null,
    OrganisationCodeTypeLocalPatientIdentifier varchar(500) null,
    NHSNumber varchar(500) null,
    DateofBirth varchar(500) null,
    CarerSupportIndicator varchar(500) null,
    NHSNumberTraceStatus varchar(500) null,
    WithheldIdentityReason varchar(500) null,
    Sex varchar(500) null,
    NameFormatCode varchar(500) null,
    PatientName varchar(500) null,
    PersonTitle varchar(500) null,
    PersonGivenName varchar(500) null,
    PersonFamilyName varchar(500) null,
    PersonNameSuffix varchar(500) null,
    PersonInitials varchar(500) null,
    AddressFormatCode varchar(500) null,
    PatientUsualAddress varchar(500) null,
    Postcode varchar(500) null,
    OrganisationCodeResidenceResponsibility varchar(500) null,
    PCTofResidence varchar(500) null,
    OrganisationCodeTypePCTofResidence varchar(500) null,
    EthnicCategory varchar(500) null,
    OSVClassificationatCDSActivityDate varchar(500) null,
    ConsultantCode varchar(500) null,
    MainSpecialtyCode varchar(500) null,
    TreatmentFunctionCode varchar(500) null,
    LocalSubSpecialtyCode varchar(500) null,
    MultiProfessionalOrMultidisciplinaryIndCode varchar(500) null,
    RehabilitationAssessmentTeamType varchar(500) null,
    DiagnosisSchemeInUseICD varchar(500) null,
    DiagnosisSchemeInUseRead varchar(500) null,
    AttendanceIdentifier varchar(500) null,
    AdministrativeCategory varchar(500) null,
    AttendedorDidNotAttend varchar(500) null,
    FirstAttendance varchar(500) null,
    MedicalStaffTypeSeeingPatient varchar(500) null,
    OperationStatusPerAttendance varchar(500) null,
    OutcomeofAttendance varchar(500) null,
    AppointmentDate varchar(500) null,
    AppointmentTime varchar(500) null,
    ExpectedDurationOfAppointment varchar(500) null,
    ConsultationMediumUsed varchar(500) null,
    WaitingTimeMeasurementType varchar(500) null,
    ActivityLocationTypeCode varchar(500) null,
    EarliestClinicallyAppropriateDate varchar(500) null,
    ClinicCode varchar(500) null,
    CommissioningSerialNumber varchar(500) null,
    NHSServiceAgreementLineNumber varchar(500) null,
    ProviderReferenceNumber varchar(500) null,
    CommissionerReferenceNumber varchar(500) null,
    OrganisationCodeCodeofProvider varchar(500) null,
    OrganisationCodeTypeCodeofProvider varchar(500) null,
    OrganisationCodeCodeofCommissioner varchar(500) null,
    OrganisationCodeTypeCodeofCommissioner varchar(500) null,
    ProcedureSchemeInUseOPCS varchar(500) null,
    ProcedureSchemeInUseRead varchar(500) null,
    LocationClassatAttendance varchar(500) null,
    SiteCodeofTreatment varchar(500) null,
    OrganisationCodeTypeSiteCodeofTreatmentAtAttendance varchar(500) null,
    GeneralMedicalPractitionerCodeofRegisteredGMP varchar(500) null,
    PracticeCodeofRegisteredGP varchar(500) null,
    OrganisationCodeTypeofRegisteredGP varchar(500) null,
    PriorityType varchar(500) null,
    ServiceTypeRequested varchar(500) null,
    SourceofReferralForOutpatients varchar(500) null,
    ReferralRequestReceivedDate varchar(500) null,
    DirectAccessReferralIndicator varchar(500) null,
    ReferrerCode varchar(500) null,
    ReferringOrganisationCode varchar(500) null,
    OrganisationCodeTypeofReferrer varchar(500) null,
    LastDNAOrPatientCancelledDate varchar(500) null,
    HRGCode varchar(500) null,
    HRGVersionNumber varchar(500) null,
    ProcedureSchemeInUse varchar(500) null,
    DominantGroupingVariableProcedure varchar(500) null,
    CoreHRG varchar(500) null,
    HRGVersionCalculated varchar(500) null,
    SUSHRG varchar(500) null,
    UniqueBookingReferenceNumberConverted varchar(500) null,
    PatientPathwayIdentifier varchar(500) null,
    OrganisationCodePatientPathwayIdentifierIssuer varchar(500) null,
    ReferralToTreatmentPeriodStatus varchar(500) null,
    ReferralToTreatmentPeriodStartDate varchar(500) null,
    ReferralToTreatmentPeriodEndDate varchar(500) null,
    LeadCareActivityIndicator varchar(500) null,
    AgeatCDSActivityDate varchar(500) null,
    NHSServiceAgreementChangeDate varchar(500) null,
    CDSActivityDate varchar(500) null,
    EarliestReasonableOfferedDate varchar(500) null,
    LocationType varchar(500) null,
    XMLVersion varchar(500) null,
    ConfidentialityCategoryDerived varchar(500) null,
    ReferralToTreatmentLengthDerived varchar(500) null,
    AgerangepatientderivedfromDOB varchar(500) null,
    Areacodederivedfrompostcode varchar(500) null,
    AttenderTypeDerived varchar(500) null,
    CDSGroup varchar(500) null,
    FinishedIndicator varchar(500) null,
    PCTDerivedfromGP varchar(500) null,
    PCTTypeDerivedfromGP varchar(500) null,
    GPPracticeDerived varchar(500) null,
    PCTDerivedfromderivedGPPractice varchar(500) null,
    SHAfromGPPractice varchar(500) null,
    SHATypefromGPPractice varchar(500) null,
    MonthofBirth varchar(500) null,
    ElectoralWardfrompostcode varchar(500) null,
    PCTfrompostcode varchar(500) null,
    PCTTypefromPostcode varchar(500) null,
    SHAfromPostcode varchar(500) null,
    SHATypefromPostcode varchar(500) null,
    AreacodefromProviderPostcode varchar(500) null,
    AgeatEndofEpisode varchar(500) null,
    AgeatStartofEpisode varchar(500) null,
    YearofBirth varchar(500) null,
    CensusArea varchar(500) null,
    Country varchar(500) null,
    CountyCode varchar(500) null,
    CensusED varchar(500) null,
    EDDistrictCode varchar(500) null,
    ElectoralWardCode varchar(500) null,
    GORCode varchar(500) null,
    LocalUnitaryAuthority varchar(500) null,
    OldSHACode varchar(500) null,
    ElectoralArea varchar(500) null,
    PrimeRecipient varchar(500) null,
    CopyRecipients varchar(500) null,
    IsValidUBRN varchar(500) null,
    UBRNOccurrenceCount varchar(500) null
);


create table omop_staging.sus_OP_ICDDiagnosis
(
    MessageId uniqueidentifier not null,
    constraint FK_omop_staging_sus_OP_ICDDiagnosis_MessageId foreign key (MessageId) references omop_staging.sus_OP (MessageId),
    DiagnosisICD varchar(500) null,
    PresentOnAdmissionIndicatorDiagnosis varchar(500) null,
    IsPrimaryDiagnosis bit not null
)

create clustered index IDX_omop_staging_sus_OP_ICDDiagnosis on omop_staging.sus_OP_ICDDiagnosis (MessageId);


create table omop_staging.sus_OP_ReadDiagnosis
(
    MessageId uniqueidentifier not null,
    constraint FK_omop_staging_sus_OP_ReadDiagnosis_MessageId foreign key (MessageId) references omop_staging.sus_OP (MessageId),
    DiagnosisRead varchar(500) not null,
    IsPrimaryDiagnosis bit not null
)

create clustered index IDX_omop_staging_sus_OP_ReadDiagnosis on omop_staging.sus_OP_ReadDiagnosis (MessageId);


create table omop_staging.sus_OP_OPCSProcedure
(
    MessageId uniqueidentifier not null,
    constraint FK_omop_staging_sus_OP_OPCSProcedure_MessageId foreign key (MessageId) references omop_staging.sus_OP (MessageId),
    ProcedureOPCS varchar(500) null,
    ProcedureDateOPCS varchar(500) null,
    MainOperatingHealthcareProfessionalCodeOpcs varchar(500) null,
    ProfessionalRegistrationIssuerCodeOpcs varchar(500) null,
    ResponsibleAnaesthetistCodeOpcs varchar(500) null,
    ResponsibleAnaesthetistRegBodyOpcs varchar(500) null,
    IsPrimaryProcedure bit not null
)

create clustered index IDX_omop_staging_sus_OP_OPCSProcedure on omop_staging.sus_OP_OPCSProcedure (MessageId);


create table omop_staging.sus_OP_ReadProcedure
(
    MessageId uniqueidentifier not null,
    constraint FK_omop_staging_sus_OP_ReadProcedure_MessageId foreign key (MessageId) references omop_staging.sus_OP (MessageId),
    ProcedureRead varchar(500) null,
    IsPrimaryProcedure bit not null
)

create clustered index IDX_omop_staging_sus_OP_ReadProcedure on omop_staging.sus_OP_ReadProcedure (MessageId);





create type omop_staging.sus_OP_row as table
(
    MessageId uniqueidentifier NOT null,
    GeneratedRecordIdentifier varchar(500) null,
    ReasonforAccess varchar(500) null,
    CDStype varchar(500) null,
    Protocolidentifier varchar(500) null,
    UniqueCDSidentifier varchar(500) null,
    SUSgeneratedspellID varchar(500) null,
    Updatetype varchar(500) null,
    BulkreplacementCDSgroup varchar(500) null,
    Testindicator varchar(500) null,
    Applicabledatetime varchar(500) null,
    Censusdate varchar(500) null,
    Extractdatetime varchar(500) null,
    ReportperiodStartDate varchar(500) null,
    ReportperiodEndDate varchar(500) null,
    OrganisationcodeSenderoftransaction varchar(500) null,
    OrganisationCodeTypeofSender varchar(500) null,
    SubmissionDate varchar(500) null,
    CDSInterchangeID varchar(500) null,
    LocalPatientIdentifier varchar(500) null,
    OrganisationCodeLocalPatientIdentifier varchar(500) null,
    OrganisationCodeTypeLocalPatientIdentifier varchar(500) null,
    NHSNumber varchar(500) null,
    DateofBirth varchar(500) null,
    CarerSupportIndicator varchar(500) null,
    NHSNumberTraceStatus varchar(500) null,
    WithheldIdentityReason varchar(500) null,
    Sex varchar(500) null,
    NameFormatCode varchar(500) null,
    PatientName varchar(500) null,
    PersonTitle varchar(500) null,
    PersonGivenName varchar(500) null,
    PersonFamilyName varchar(500) null,
    PersonNameSuffix varchar(500) null,
    PersonInitials varchar(500) null,
    AddressFormatCode varchar(500) null,
    PatientUsualAddress varchar(500) null,
    Postcode varchar(500) null,
    OrganisationCodeResidenceResponsibility varchar(500) null,
    PCTofResidence varchar(500) null,
    OrganisationCodeTypePCTofResidence varchar(500) null,
    EthnicCategory varchar(500) null,
    OSVClassificationatCDSActivityDate varchar(500) null,
    ConsultantCode varchar(500) null,
    MainSpecialtyCode varchar(500) null,
    TreatmentFunctionCode varchar(500) null,
    LocalSubSpecialtyCode varchar(500) null,
    MultiProfessionalOrMultidisciplinaryIndCode varchar(500) null,
    RehabilitationAssessmentTeamType varchar(500) null,
    DiagnosisSchemeInUseICD varchar(500) null,
    DiagnosisSchemeInUseRead varchar(500) null,
    AttendanceIdentifier varchar(500) null,
    AdministrativeCategory varchar(500) null,
    AttendedorDidNotAttend varchar(500) null,
    FirstAttendance varchar(500) null,
    MedicalStaffTypeSeeingPatient varchar(500) null,
    OperationStatusPerAttendance varchar(500) null,
    OutcomeofAttendance varchar(500) null,
    AppointmentDate varchar(500) null,
    AppointmentTime varchar(500) null,
    ExpectedDurationOfAppointment varchar(500) null,
    ConsultationMediumUsed varchar(500) null,
    WaitingTimeMeasurementType varchar(500) null,
    ActivityLocationTypeCode varchar(500) null,
    EarliestClinicallyAppropriateDate varchar(500) null,
    ClinicCode varchar(500) null,
    CommissioningSerialNumber varchar(500) null,
    NHSServiceAgreementLineNumber varchar(500) null,
    ProviderReferenceNumber varchar(500) null,
    CommissionerReferenceNumber varchar(500) null,
    OrganisationCodeCodeofProvider varchar(500) null,
    OrganisationCodeTypeCodeofProvider varchar(500) null,
    OrganisationCodeCodeofCommissioner varchar(500) null,
    OrganisationCodeTypeCodeofCommissioner varchar(500) null,
    ProcedureSchemeInUseOPCS varchar(500) null,
    ProcedureSchemeInUseRead varchar(500) null,
    LocationClassatAttendance varchar(500) null,
    SiteCodeofTreatment varchar(500) null,
    OrganisationCodeTypeSiteCodeofTreatmentAtAttendance varchar(500) null,
    GeneralMedicalPractitionerCodeofRegisteredGMP varchar(500) null,
    PracticeCodeofRegisteredGP varchar(500) null,
    OrganisationCodeTypeofRegisteredGP varchar(500) null,
    PriorityType varchar(500) null,
    ServiceTypeRequested varchar(500) null,
    SourceofReferralForOutpatients varchar(500) null,
    ReferralRequestReceivedDate varchar(500) null,
    DirectAccessReferralIndicator varchar(500) null,
    ReferrerCode varchar(500) null,
    ReferringOrganisationCode varchar(500) null,
    OrganisationCodeTypeofReferrer varchar(500) null,
    LastDNAOrPatientCancelledDate varchar(500) null,
    HRGCode varchar(500) null,
    HRGVersionNumber varchar(500) null,
    ProcedureSchemeInUse varchar(500) null,
    DominantGroupingVariableProcedure varchar(500) null,
    CoreHRG varchar(500) null,
    HRGVersionCalculated varchar(500) null,
    SUSHRG varchar(500) null,
    UniqueBookingReferenceNumberConverted varchar(500) null,
    PatientPathwayIdentifier varchar(500) null,
    OrganisationCodePatientPathwayIdentifierIssuer varchar(500) null,
    ReferralToTreatmentPeriodStatus varchar(500) null,
    ReferralToTreatmentPeriodStartDate varchar(500) null,
    ReferralToTreatmentPeriodEndDate varchar(500) null,
    LeadCareActivityIndicator varchar(500) null,
    AgeatCDSActivityDate varchar(500) null,
    NHSServiceAgreementChangeDate varchar(500) null,
    CDSActivityDate varchar(500) null,
    EarliestReasonableOfferedDate varchar(500) null,
    LocationType varchar(500) null,
    XMLVersion varchar(500) null,
    ConfidentialityCategoryDerived varchar(500) null,
    ReferralToTreatmentLengthDerived varchar(500) null,
    AgerangepatientderivedfromDOB varchar(500) null,
    Areacodederivedfrompostcode varchar(500) null,
    AttenderTypeDerived varchar(500) null,
    CDSGroup varchar(500) null,
    FinishedIndicator varchar(500) null,
    PCTDerivedfromGP varchar(500) null,
    PCTTypeDerivedfromGP varchar(500) null,
    GPPracticeDerived varchar(500) null,
    PCTDerivedfromderivedGPPractice varchar(500) null,
    SHAfromGPPractice varchar(500) null,
    SHATypefromGPPractice varchar(500) null,
    MonthofBirth varchar(500) null,
    ElectoralWardfrompostcode varchar(500) null,
    PCTfrompostcode varchar(500) null,
    PCTTypefromPostcode varchar(500) null,
    SHAfromPostcode varchar(500) null,
    SHATypefromPostcode varchar(500) null,
    AreacodefromProviderPostcode varchar(500) null,
    AgeatEndofEpisode varchar(500) null,
    AgeatStartofEpisode varchar(500) null,
    YearofBirth varchar(500) null,
    CensusArea varchar(500) null,
    Country varchar(500) null,
    CountyCode varchar(500) null,
    CensusED varchar(500) null,
    EDDistrictCode varchar(500) null,
    ElectoralWardCode varchar(500) null,
    GORCode varchar(500) null,
    LocalUnitaryAuthority varchar(500) null,
    OldSHACode varchar(500) null,
    ElectoralArea varchar(500) null,
    PrimeRecipient varchar(500) null,
    CopyRecipients varchar(500) null,
    IsValidUBRN varchar(500) null,
    UBRNOccurrenceCount varchar(500) null
);


create type omop_staging.sus_OP_ICDDiagnosis_row as table
(
    MessageId uniqueidentifier not null,
    DiagnosisICD varchar(500) null,
    PresentOnAdmissionIndicatorDiagnosis varchar(500) null,
    IsPrimaryDiagnosis bit not null
)

create type omop_staging.sus_OP_ReadDiagnosis_row as table
(
    MessageId uniqueidentifier not null,
    DiagnosisRead varchar(500) not null,
    IsPrimaryDiagnosis bit not null
)

create type omop_staging.sus_OP_OPCSProcedure_row as table
(
    MessageId uniqueidentifier not null,
    ProcedureOPCS varchar(500) null,
    ProcedureDateOPCS varchar(500) null,
    MainOperatingHealthcareProfessionalCodeOpcs varchar(500) null,
    ProfessionalRegistrationIssuerCodeOpcs varchar(500) null,
    ResponsibleAnaesthetistCodeOpcs varchar(500) null,
    ResponsibleAnaesthetistRegBodyOpcs varchar(500) null,
    IsPrimaryProcedure bit not null
)

create type omop_staging.sus_OP_ReadProcedure_row as table
(
    MessageId uniqueidentifier not null,
    ProcedureRead varchar(500) null,
    IsPrimaryProcedure bit not null
)