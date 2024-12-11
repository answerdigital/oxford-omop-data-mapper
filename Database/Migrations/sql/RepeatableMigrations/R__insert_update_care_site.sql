if object_id ('cdm.insert_update_care_site') is not null
begin
drop procedure cdm.insert_update_care_site;
end
go

create procedure cdm.insert_update_care_site
	@rows cdm.care_site_row readonly,
	@DataSource varchar(20)
as
begin

declare @NewCareSite table
(
	care_site_id int not null
);

-- Insert new care sites.
insert into cdm.care_site
(
	care_site_name,
	place_of_service_concept_id,
	location_id,
	care_site_source_value,
	place_of_service_source_value
)
output inserted.care_site_id
into @NewCareSite
select
	care_site_name,
	place_of_service_concept_id,
	location_id,
	care_site_source_value,
	place_of_service_source_value
from @rows up
where not exists (select * from cdm.care_site p where p.care_site_id = up.care_site_id);

declare @ColumnList table ([name] varchar(max));

insert into @ColumnList ([name])
values
('care_site_name'),
('place_of_service_concept_id'),
('location_id'),
('care_site_source_value'),
('place_of_service_source_value');

insert into provenance
(
	table_type_id,
	table_key,
	column_name,
	data_source
)
select
	1, -- Care Site,
	np.care_site_id,
	cl.care_site_name,
	@DataSource
from @NewCareSite np
cross apply (select Name from @ColumnList) cl;

-- Update existing patients.

declare @UpdatedPatients table
(
	[care_site_id] [int] NOT NULL,
	[care_site_name] [varchar](50) NULL,
	[place_of_service_concept_id] [int] NULL,
	[location_id] [int] NULL,
	[care_site_source_value] [varchar](50) NULL,
	[place_of_service_source_value] [varchar](50) NULL
);

update p
	set
		p.care_site_name = case when up.care_site_name is not null then up.care_site_name else p.care_site_name end, 
		p.place_of_service_concept_id = case when up.place_of_service_concept_id is not null then up.place_of_service_concept_id else p.place_of_service_concept_id end, 
		p.location_id = case when up.location_id is not null then up.location_id else p.location_id end, 
		p.care_site_source_value = case when up.care_site_source_value is not null then up.care_site_source_value else p.care_site_source_value end, 
		p.place_of_service_source_value = case when up.place_of_service_source_value is not null then up.place_of_service_source_value else p.place_of_service_source_value end
output
	inserted.care_site_id,
	(case when inserted.care_site_name != deleted.care_site_name then 1 else 0 end),
	(case when inserted.place_of_service_concept_id != deleted.place_of_service_concept_id then 1 else 0 end),
	(case when inserted.location_id != deleted.location_id then 1 else 0 end),
	(case when inserted.care_site_source_value != deleted.care_site_source_value then 1 else 0 end),
	(case when inserted.place_of_service_source_value != deleted.place_of_service_source_value then 1 else 0 end)
into @UpdatedCareSites
from cdm.care_site p
	inner join @rows up
		on p.care_site_name = up.care_site_name


;with ProvenanceData as ( 
	select 'care_site_name' as column_name, care_site_id from @UpdatedCareSites where care_site_name = 1 union
	select 'place_of_service_concept_id' as column_name, care_site_id from @UpdatedCareSites where place_of_service_concept_id = 1 union
	select 'location_id' as column_name, care_site_id from @UpdatedCareSites where location_id = 1 union
	select 'care_site_source_value' as column_name, care_site_id from @UpdatedCareSites where care_site_source_value = 1 union
	select 'place_of_service_source_value' as column_name, care_site_id from @UpdatedCareSites where place_of_service_source_value = 1
)
update p
set data_source = @DataSource
from provenance p
	inner join ProvenanceData pd
		on p.table_key = pd.care_site_id
		and p.column_name = pd.column_name;

end