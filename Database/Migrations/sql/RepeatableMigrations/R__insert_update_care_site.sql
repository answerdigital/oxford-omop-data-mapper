if object_id ('cdm.insert_update_care_site') is not null
begin
drop procedure cdm.insert_update_care_site;
end
go

create procedure cdm.insert_update_care_site
	@rows cdm.care_site_row readonly,
	@DataSource varchar(100)
as
begin

declare @NewCareSite table
(
	[care_site_id] [int] not null
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
where not exists (select * from cdm.care_site p where p.care_site_name = up.care_site_name);

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
	cl.name,
	@DataSource
from @NewCareSite np
cross apply (select Name from @ColumnList) cl;

end
