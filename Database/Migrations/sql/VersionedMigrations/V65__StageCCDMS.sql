create table omop_staging.sus_CCMDS
(
	MessageId uniqueidentifier not null,
	constraint PK_omop_staging_sus_CCMDS_MessageId primary key (MessageId),
	GeneratedRecordID varchar(max) null,
	LoadStagingDate varchar(max) null,
	CriticalCarePeriodSequenceNumber varchar(max) null,
	CDSVersionontheepisodes varchar(max) null,
	HESEPITYPEoftheepisode varchar(max) null,
	CDSInterchangeID varchar(max) null,
	HESEPISTAToftheepisode varchar(max) null,
	EventDate varchar(max) null,
	ActivityDateCriticalCare varchar(max) null,
	CriticalCarePeriodType varchar(max) null,
	CriticalCareEpisodeRelationship varchar(max) null,
	CriticalCareUnitFunction varchar(max) null,
	CriticalCareStartDate varchar(max) null,
	CriticalCareStartTime varchar(max) null,
	CriticalCarePeriodDischargeDate varchar(max) null,
	CriticalCarePeriodDischargeTime varchar(max) null,
	CriticalCarePeriodLocalIdentifier varchar(max) null,
	GestationLengthAtDelivery varchar(max) null,
	CriticalCareSequenceNumberDerived varchar(max) null,
	TotalnumberofCriticalCareActivitiesDerived varchar(max) null,
	LastRecordforthisCriticalCarePeriodIndicatorDerived varchar(max) null,
	CriticalCareActivitytoEpisodeRelationshipDerived varchar(max) null,
	PersonWeight varchar(max) null
)

create type omop_staging.sus_CCMDS_row as table
(
	MessageId uniqueidentifier not null,
	GeneratedRecordID varchar(max) null,
	LoadStagingDate varchar(max) null,
	CriticalCarePeriodSequenceNumber varchar(max) null,
	CDSVersionontheepisodes varchar(max) null,
	HESEPITYPEoftheepisode varchar(max) null,
	CDSInterchangeID varchar(max) null,
	HESEPISTAToftheepisode varchar(max) null,
	EventDate varchar(max) null,
	ActivityDateCriticalCare varchar(max) null,
	CriticalCarePeriodType varchar(max) null,
	CriticalCareEpisodeRelationship varchar(max) null,
	CriticalCareUnitFunction varchar(max) null,
	CriticalCareStartDate varchar(max) null,
	CriticalCareStartTime varchar(max) null,
	CriticalCarePeriodDischargeDate varchar(max) null,
	CriticalCarePeriodDischargeTime varchar(max) null,
	CriticalCarePeriodLocalIdentifier varchar(max) null,
	GestationLengthAtDelivery varchar(max) null,
	CriticalCareSequenceNumberDerived varchar(max) null,
	TotalnumberofCriticalCareActivitiesDerived varchar(max) null,
	LastRecordforthisCriticalCarePeriodIndicatorDerived varchar(max) null,
	CriticalCareActivitytoEpisodeRelationshipDerived varchar(max) null,
	PersonWeight varchar(max) null
)

create table omop_staging.sus_CCMDS_CriticalCareActivityCode
(
    MessageId uniqueidentifier not null,
    CriticalCareActivityCode varchar(max) not null,
    constraint FK_omop_staging_sus_CCMDS_CriticalCareActivityCode foreign key (MessageId) references omop_staging.sus_CCMDS (MessageId)
);

create type omop_staging.sus_CCMDS_CriticalCareActivityCode_row as table
(
    MessageId uniqueidentifier not null,
    CriticalCareActivityCode varchar(max) not null
);

create table omop_staging.sus_CCMDS_CriticalCareHighCostDrugs
(
    MessageId uniqueidentifier not null,
    CriticalCareHighCostDrugs varchar(max) not null,
    constraint FK_omop_staging_sus_CCMDS_CriticalCareHighCostDrugs foreign key (MessageId) references omop_staging.sus_CCMDS (MessageId)
);

create type omop_staging.sus_CCMDS_CriticalCareHighCostDrugs_row as table
(
    MessageId uniqueidentifier not null,
    CriticalCareHighCostDrugs varchar(max) not null
);