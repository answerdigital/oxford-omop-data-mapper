create table omop_staging.RTDS_1_Demographics
(
	Id int not null identity (1, 1),
	SourceFileName varchar(100) not null,
	PatientSer varchar(255) null,
	PatientId varchar(255) null,
	PatientId2 varchar(255) null,
	UniversalPatientId varchar(255) null,
	SSN varchar(255) null,
	FirstName varchar(255) null,
	LastName varchar(255) null,
	DateOfBirth varchar(255) null,
	Sex varchar(255) null,
	DoctorId varchar(255) null,
	CourseSer varchar(255) null,
	Expression1 varchar(255) null,
	StartDateTime varchar(255) null,
	CompletedDateTime varchar(255) null,
	End_date varchar(255) null,
	Start_date varchar(255) null,
	constraint PK_RTDS_1_Demographics_Id primary key (Id)
);

create table omop_staging.RTDS_2a_Attendances
(
	Id int not null identity (1, 1),
	SourceFileName varchar(100) not null,
	ScheduledActivitySer varchar(255) null,
	ScheduledStartTime varchar(255) null,
	AttributeValue varchar(255) null,
	CourseSer varchar(255) null,
	ProcedureCode varchar(255) null,
	PatientSer varchar(255) null,
	ScheduledActivityCode varchar(255) null,
	Description varchar(255) null,
	ActualStartDateTime_s varchar(255) null,
	ActualEndDateTime_s varchar(255) null,
	Start_date varchar(255) null,
	End_date varchar(255) null,
	constraint PK_RTDS_2a_Attendances_Id primary key (Id)
);

create table omop_staging.RTDS_2b_Plan
(
	Id int not null identity (1, 1),
	SourceFileName varchar(100) not null,
	ProcedureCode varchar(255) null,
	AttributeValue varchar(255) null,
	PatientSer varchar(255) null,
	DueDateTime varchar(255) null,
	NonScheduledActivityCode varchar(255) null,
	CourseSer varchar(255) null,
	NonScheduledActivitySer varchar(255) null,
	ActivityName varchar(255) null,
	Description varchar(255) null,
	Start_date varchar(255) null,
	End_date varchar(255) null,
	ProcedureCodeSer varchar(255) null,
	constraint PK_RTDS_2b_Plan_Id primary key (Id)
);

create table omop_staging.RTDS_3_Prescription
(
	Id int not null identity (1, 1),
	SourceFileName varchar(100) not null,
	PatientSer varchar(255) null,
	CourseSer varchar(255) null,
	TreatmentType varchar(255) null,
	NoFields varchar(255) null,
	PreDescribedDose varchar(255) null,
	PlanSetupSer varchar(255) null,
	StartDateTime varchar(255) null,
	TotDeliveredActualDose varchar(255) null,
	NoFracs varchar(255) null,
	PlanNameUpper varchar(255) null,
	Start_date varchar(255) null,
	End_date varchar(255) null,
	Expression1 varchar(255) null,
	constraint PK_RTDS_3_Prescription_Id primary key (Id)
);

create table omop_staging.RTDS_4_Exposures
(
	Id int not null identity (1, 1),
	SourceFileName varchar(100) not null,
	PatientSer varchar(255) null,
	CourseSer varchar(255) null,
	RadiationSer varchar(255) null,
	NominalEnergy varchar(255) null,
	RadiationType varchar(255) null,
	PlanSetupSer varchar(255) null,
	EventNumber varchar(255) null,
	MachineId varchar(255) null,
	PlanName varchar(255) null,
	Start_date varchar(255) null,
	End_date varchar(255) null,
	TreatmentDateTime varchar(255) null,
	storedprocedure_version varchar(255) null,
	constraint PK_RTDS_4_Exposures_Id primary key (Id)
);

create table omop_staging.RTDS_5_Diagnosis_Course
(
	Id int not null identity (1, 1),
	SourceFileName varchar(100) not null,
	PatientSer varchar(255) null,
	CourseSer varchar(255) null,
	DateStamp varchar(255) null,
	DiagnosisCode varchar(255) null,
	DiagnosisTableName varchar(255) null,
	DiagnosisType varchar(255) null,
	End_date varchar(255) null,
	Start_date varchar(255) null,
	constraint PK_RTDS_5_Diagnosis_Course_Id primary key (Id)
);

create table omop_staging.RTDS_PASDATA
(
	Id int not null identity (1, 1),
	SourceFileName varchar(100) not null,
	Expr1 varchar(255) null,
	Expr2 varchar(255) null,
	Expr3 varchar(255) null,
	Expr4 varchar(255) null,
	Expr5 varchar(255) null,
	Expr6 varchar(255) null,
	PatientID2 varchar(255) null,
	FirstOfNHSNUMBER varchar(255) null,
	NHSNUMBERTRACESTATUS varchar(255) null,
	Expr7 varchar(255) null,
	Expr8 varchar(255) null,
	FirstOfPOSTCODE varchar(255) null,
	Expr9 varchar(255) null,
	BIRTHDATE varchar(255) null,
	GENDER varchar(255) null,
	Expr10 varchar(255) null,
	Expr11 varchar(255) null,
	Expr12 varchar(255) null,
	Expr13 varchar(255) null,
	Expr14 varchar(255) null,
	FirstOfGPNATIONALCODE varchar(255) null,
	FirstOfPRACTICECODE varchar(255) null,
	constraint PK_RTDS_PASSDATA_Id primary key (Id)
);



create type omop_staging.RTDS_1_Demographics_row as table
(
	SourceFileName varchar(100) not null,
	PatientSer varchar(255) null,
	PatientId varchar(255) null,
	PatientId2 varchar(255) null,
	UniversalPatientId varchar(255) null,
	SSN varchar(255) null,
	FirstName varchar(255) null,
	LastName varchar(255) null,
	DateOfBirth varchar(255) null,
	Sex varchar(255) null,
	DoctorId varchar(255) null,
	CourseSer varchar(255) null,
	Expression1 varchar(255) null,
	StartDateTime varchar(255) null,
	CompletedDateTime varchar(255) null,
	End_date varchar(255) null,
	Start_date varchar(255) null
);

create type omop_staging.RTDS_2a_Attendances_row as table
(
	SourceFileName varchar(100) not null,
	ScheduledActivitySer varchar(255) null,
	ScheduledStartTime varchar(255) null,
	AttributeValue varchar(255) null,
	CourseSer varchar(255) null,
	ProcedureCode varchar(255) null,
	PatientSer varchar(255) null,
	ScheduledActivityCode varchar(255) null,
	Description varchar(255) null,
	ActualStartDateTime_s varchar(255) null,
	ActualEndDateTime_s varchar(255) null,
	Start_date varchar(255) null,
	End_date varchar(255) null
);

create type omop_staging.RTDS_2b_Plan_row as table
(
	SourceFileName varchar(100) not null,
	ProcedureCode varchar(255) null,
	AttributeValue varchar(255) null,
	PatientSer varchar(255) null,
	DueDateTime varchar(255) null,
	NonScheduledActivityCode varchar(255) null,
	CourseSer varchar(255) null,
	NonScheduledActivitySer varchar(255) null,
	ActivityName varchar(255) null,
	Description varchar(255) null,
	Start_date varchar(255) null,
	End_date varchar(255) null,
	ProcedureCodeSer varchar(255) null
);

create type omop_staging.RTDS_3_Prescription_row as table
(
	SourceFileName varchar(100) not null,
	PatientSer varchar(255) null,
	CourseSer varchar(255) null,
	TreatmentType varchar(255) null,
	NoFields varchar(255) null,
	PreDescribedDose varchar(255) null,
	PlanSetupSer varchar(255) null,
	StartDateTime varchar(255) null,
	TotDeliveredActualDose varchar(255) null,
	NoFracs varchar(255) null,
	PlanNameUpper varchar(255) null,
	Start_date varchar(255) null,
	End_date varchar(255) null,
	Expression1 varchar(255) null
);

create type omop_staging.RTDS_4_Exposures_row as table
(
	SourceFileName varchar(100) not null,
	PatientSer varchar(255) null,
	CourseSer varchar(255) null,
	RadiationSer varchar(255) null,
	NominalEnergy varchar(255) null,
	RadiationType varchar(255) null,
	PlanSetupSer varchar(255) null,
	EventNumber varchar(255) null,
	MachineId varchar(255) null,
	PlanName varchar(255) null,
	Start_date varchar(255) null,
	End_date varchar(255) null,
	TreatmentDateTime varchar(255) null,
	storedprocedure_version varchar(255) null
);

create type omop_staging.RTDS_5_Diagnosis_Course_row as table
(
	SourceFileName varchar(100) not null,
	PatientSer varchar(255) null,
	CourseSer varchar(255) null,
	DateStamp varchar(255) null,
	DiagnosisCode varchar(255) null,
	DiagnosisTableName varchar(255) null,
	DiagnosisType varchar(255) null,
	End_date varchar(255) null,
	Start_date varchar(255) null
);

create type omop_staging.RTDS_PASDATA_row as table
(
	SourceFileName varchar(100) not null,
	Expr1 varchar(255) null,
	Expr2 varchar(255) null,
	Expr3 varchar(255) null,
	Expr4 varchar(255) null,
	Expr5 varchar(255) null,
	Expr6 varchar(255) null,
	PatientID2 varchar(255) null,
	FirstOfNHSNUMBER varchar(255) null,
	NHSNUMBERTRACESTATUS varchar(255) null,
	Expr7 varchar(255) null,
	Expr8 varchar(255) null,
	FirstOfPOSTCODE varchar(255) null,
	Expr9 varchar(255) null,
	BIRTHDATE varchar(255) null,
	GENDER varchar(255) null,
	Expr10 varchar(255) null,
	Expr11 varchar(255) null,
	Expr12 varchar(255) null,
	Expr13 varchar(255) null,
	Expr14 varchar(255) null,
	FirstOfGPNATIONALCODE varchar(255) null,
	FirstOfPRACTICECODE varchar(255) null
);