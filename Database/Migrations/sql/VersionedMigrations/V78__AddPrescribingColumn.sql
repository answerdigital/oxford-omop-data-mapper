alter table omop_staging.oxford_prescribing
	add 
		EVENT_ID varchar(max) null

go

drop type omop_staging.oxford_prescribing_row;

go

create type omop_staging.oxford_prescribing_row as table
(
	patient_identifier_value varchar(max),
	WAREHOUSE_IDENTIFIER varchar(max),
	ORDER_ID varchar(max),
	BEG_DT_TM varchar(max),
	END_DT_TM varchar(max),
	SCHEDULED_DT_TM varchar(max),
	VERIFICATION_DT_TM varchar(max),
	UPDT_DT_TM varchar(max),
	CURRENT_START_DT_TM varchar(max),
	PROJECTED_STOP_DT_TM varchar(max),
	MED_ADMIN_EVENT_ID varchar(max),
	EVENT_TYPE_DISPLAY varchar(max),
	REFERENCESTARTDTTM varchar(max),
	STRENGTHDOSE varchar(max),
	DIFFINMIN varchar(max),
	CONSTANTIND varchar(max),
	RXPRIORITY varchar(max),
	PHARMORDERTYPE varchar(max),
	ADHOCFREQINSTANCE varchar(max),
	FREQSCHEDID varchar(max),
	WEIGHT varchar(max),
	DRUGFORM varchar(max),
	REQSTARTDTTM varchar(max),
	STRENGTHDOSEUNIT varchar(max),
	RXROUTE varchar(max),
	CATALOG_CD varchar(max),
	CATALOG varchar(max),
	ORDER_MNEMONIC varchar(max),
	ORDER_DETAIL_DISPLAY_LINE nvarchar(max),
	DEPT_MISC_LINE varchar(max),
    concept_identifier varchar(max) null, 
    concept_name varchar(max) null,
    CONCEPT_CKI varchar(max) null,
    cki varchar(max) null,
	EVENT_ID varchar(max)
);
