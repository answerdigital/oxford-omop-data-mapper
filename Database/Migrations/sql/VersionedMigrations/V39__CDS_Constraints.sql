alter table omop_staging.cds_line02 drop constraint PK_omop_staging_cds_line02_MessageId_LineCount;
alter table omop_staging.cds_line02 add constraint PK_omop_staging_cds_line02_MessageId_LineId primary key (MessageId, LineId);

alter table omop_staging.cds_line03 drop constraint PK_omop_staging_cds_line03_MessageId_LineCount;
alter table omop_staging.cds_line03 add constraint PK_omop_staging_cds_line03_MessageId_LineId primary key (MessageId, LineId);

alter table omop_staging.cds_line04 drop constraint PK_omop_staging_cds_line04_MessageId_LineCount;
alter table omop_staging.cds_line04 add constraint PK_omop_staging_cds_line04_MessageId_LineId primary key (MessageId, LineId);

alter table omop_staging.cds_line06 drop constraint PK_omop_staging_cds_line06_MessageId_LineCount;
alter table omop_staging.cds_line06 add constraint PK_omop_staging_cds_line06_MessageId_LineId primary key (MessageId, LineId);

alter table omop_staging.cds_line07 drop constraint PK_omop_staging_cds_line07_MessageId_LineCount
alter table omop_staging.cds_line07 add constraint PK_omop_staging_cds_line07_MessageId_LineId primary key (MessageId, LineId);

alter table omop_staging.cds_line12 drop constraint PK_omop_staging_cds_line12_MessageId_LineCount
alter table omop_staging.cds_line12 add constraint PK_omop_staging_cds_line12_MessageId_LineId primary key (MessageId, LineId);
