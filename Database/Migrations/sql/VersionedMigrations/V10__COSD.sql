create schema omop_staging;

go

create table omop_staging.cosd_staging                                                                   
(                                                                                           
    SubmissionName varchar(200) not null,                                                   
	FileName varchar(200) not null,                                                          
	Content xml not null,                                                                    
	constraint PK_cosd_staging_SubmissionName_FileName primary key(SubmissionName, FileName) 
);