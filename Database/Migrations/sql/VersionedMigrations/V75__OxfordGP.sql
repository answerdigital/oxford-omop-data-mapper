CREATE TABLE omop_staging.oxford_gp_appointment
(
    GPAppointmentsPrimaryKey varchar(max)
    PatientIdentifier varchar(max) null,
    AppointmentDate varchar(max) null,
    AppointmentStatus varchar(max) null,
    AppointmentBookedDate varchar(max) null,
    ClinicianCode varchar(max) null,
    AppointmentCancelledDate varchar(max) null,
    OrganisationName varchar(max) null,
    SourceName varchar(max) null,
    StatusDescription varchar(max) null,
    DNAFlag varchar(max) null,
    OrganisationNationalCode varchar(max) null,
    ClinicianType varchar(max) null,
    OrganisationIdentifier varchar(max) null,
    Location varchar(max) null,
    LocationType varchar(max) null,
    Specialty varchar(max) null,
    ClinicName varchar(max) null,
    BookingSource varchar(max) null,
    BookingMethod varchar(max) null,
    PatientArrivedDateTime varchar(max) null,
    PatientSeenDateTime varchar(max) null,
    DeliveryMethodText varchar(max) null,
    PlannedMinutesDuration varchar(max) null,
    ActualMinutesDuration varchar(max) null,
    NationalSlotDesc varchar(max) null,
    NationalSlotName varchar(max) null,
    NationalContext varchar(max) null,
    NationalService varchar(max) null,
    UrgentFlag varchar(max) null,
    FollowUp varchar(max) null,
    ExternalPatient varchar(max) null,
    ExternalPatientOrganisationIdentifierSystem varchar(max) null,
    ExternalPatientOrganisationIdentifierValue varchar(max) null,
    ExternalPatientOrganisationDisplay varchar(max) null,
    CancellationReasonText varchar(max) null,
    SessionIdentifierValue varchar(max) null,
    ClinicianIdentifierValue varchar(max) null,
    SlotEndDateTime varchar(max) null
);

create index IDX_oxford_gp_appointment_GPAppointmentsPrimaryKey on omop_staging.oxford_gp_appointment (GPAppointmentsPrimaryKey);

CREATE type omop_staging.oxford_gp_appointment_row as table
(
    GPAppointmentsPrimaryKey varchar(max)
    PatientIdentifier varchar(max) null,
    AppointmentDate varchar(max) null,
    AppointmentStatus varchar(max) null,
    AppointmentBookedDate varchar(max) null,
    ClinicianCode varchar(max) null,
    AppointmentCancelledDate varchar(max) null,
    OrganisationName varchar(max) null,
    SourceName varchar(max) null,
    StatusDescription varchar(max) null,
    DNAFlag varchar(max) null,
    OrganisationNationalCode varchar(max) null,
    ClinicianType varchar(max) null,
    OrganisationIdentifier varchar(max) null,
    Location varchar(max) null,
    LocationType varchar(max) null,
    Specialty varchar(max) null,
    ClinicName varchar(max) null,
    BookingSource varchar(max) null,
    BookingMethod varchar(max) null,
    PatientArrivedDateTime varchar(max) null,
    PatientSeenDateTime varchar(max) null,
    DeliveryMethodText varchar(max) null,
    PlannedMinutesDuration varchar(max) null,
    ActualMinutesDuration varchar(max) null,
    NationalSlotDesc varchar(max) null,
    NationalSlotName varchar(max) null,
    NationalContext varchar(max) null,
    NationalService varchar(max) null,
    UrgentFlag varchar(max) null,
    FollowUp varchar(max) null,
    ExternalPatient varchar(max) null,
    ExternalPatientOrganisationIdentifierSystem varchar(max) null,
    ExternalPatientOrganisationIdentifierValue varchar(max) null,
    ExternalPatientOrganisationDisplay varchar(max) null,
    CancellationReasonText varchar(max) null,
    SessionIdentifierValue varchar(max) null,
    ClinicianIdentifierValue varchar(max) null,
    SlotEndDateTime varchar(max) null
);

CREATE TABLE omop_staging.oxford_gp_demographic
(
    PatientIdentifier varchar(max) null,
    NHSNumber varchar(max) null,
    Forename varchar(max) null,
    Surname varchar(max) null,
    DOB varchar(max) null,
    Postcode varchar(max) null,
    DateofDeath varchar(max) null
);

create index IDX_oxford_gp_demographic_PatientIdentifier on omop_staging.oxford_gp_demographic (PatientIdentifier);

CREATE type omop_staging.oxford_gp_demographic_row table
(
    PatientIdentifier varchar(max) null,
    NHSNumber varchar(max) null,
    Forename varchar(max) null,
    Surname varchar(max) null,
    DOB varchar(max) null,
    Postcode varchar(max) null,
    DateofDeath varchar(max) null
);

CREATE TABLE omop_staging.oxford_gp_event
(
    GPEventsPrimaryKey varchar(max) null,
    PatientIdentifier varchar(max) null,
    GeneralPractitionerCode varchar(max) null,
    RegisteredGP varchar(max) null,
    GPPracticeCode varchar(max) null,
    EventDate varchar(max) null,
    SuppliedCode varchar(max) null,
    CodeSet varchar(max) null,
    EventDescription varchar(max) null,
    Episodicity varchar(max) null,
    Units varchar(max) null,
    Value varchar(max) null,
    SensitivityDormant varchar(max) null,
    EventNo varchar(max) null,
    AlternateReadEMISCode varchar(max) null,
    JournalUpdateFlag varchar(max) null,
    UpdateKey varchar(max) null,
    UniqueKey varchar(max) null
);

create index IDX_oxford_gp_event_PatientIdentifier on omop_staging.oxford_gp_event (PatientIdentifier);

CREATE type omop_staging.oxford_gp_event_row table
(
    GPEventsPrimaryKey varchar(max) null,
    PatientIdentifier varchar(max) null,
    GeneralPractitionerCode varchar(max) null,
    RegisteredGP varchar(max) null,
    GPPracticeCode varchar(max) null,
    EventDate varchar(max) null,
    SuppliedCode varchar(max) null,
    CodeSet varchar(max) null,
    EventDescription varchar(max) null,
    Episodicity varchar(max) null,
    Units varchar(max) null,
    Value varchar(max) null,
    SensitivityDormant varchar(max) null,
    EventNo varchar(max) null,
    AlternateReadEMISCode varchar(max) null,
    JournalUpdateFlag varchar(max) null,
    UpdateKey varchar(max) null,
    UniqueKey varchar(max) null
);


CREATE TABLE omop_staging.oxford_gp_medication
(
    GPMedicationsPrimaryKey varchar(max) null,
    PatientIdentifier varchar(max) null,
    GeneralPracticeCode varchar(max) null,
    RegisteredGP varchar(max) null,
    GPPracticeCode varchar(max) null,
    SuppliedCode varchar(max) null,
    CodeSet varchar(max) null,
    MedicationDescription varchar(max) null,
    Quantity varchar(max) null,
    Dosage varchar(max) null,
    LastIssueDate varchar(max) null,
    MixtureID varchar(max) null,
    Constituent varchar(max) null,
    Units varchar(max) null,
    RepeatMedicationFlag varchar(max) null,
    MedicationNo varchar(max) null,
    MaxIssues varchar(max) null,
    UpdateKey varchar(max) null,
    UniqueKey varchar(max) null,
    AuthorisingUserDisplay varchar(max) null,
    CourseLengthPerIssue varchar(max) null
);

create index IDX_oxford_gp_medication_PatientIdentifier on omop_staging.oxford_gp_medication (PatientIdentifier);

CREATE type omop_staging.oxford_gp_medication_row table
(
    GPMedicationsPrimaryKey varchar(max) null,
    PatientIdentifier varchar(max) null,
    GeneralPracticeCode varchar(max) null,
    RegisteredGP varchar(max) null,
    GPPracticeCode varchar(max) null,
    SuppliedCode varchar(max) null,
    CodeSet varchar(max) null,
    MedicationDescription varchar(max) null,
    Quantity varchar(max) null,
    Dosage varchar(max) null,
    LastIssueDate varchar(max) null,
    MixtureID varchar(max) null,
    Constituent varchar(max) null,
    Units varchar(max) null,
    RepeatMedicationFlag varchar(max) null,
    MedicationNo varchar(max) null,
    MaxIssues varchar(max) null,
    UpdateKey varchar(max) null,
    UniqueKey varchar(max) null,
    AuthorisingUserDisplay varchar(max) null,
    CourseLengthPerIssue varchar(max) null
);