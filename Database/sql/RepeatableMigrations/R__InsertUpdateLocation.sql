if object_id ('cdm.InsertUpdateLocation') is not null
begin
	drop procedure cdm.InsertUpdateLocation;
end

go

create procedure cdm.InsertUpdateLocation
	@Locations cdm.[Location] readonly
as
begin
	
	set nocount on;

	;with LocationWithRow as (
		select 
			address_1,
			address_2,
			city,
			state,
			zip,
			county,
			location_source_value,
			country_concept_id,
			country_source_value,
			latitude,
			longitude,
			row_number() over (
				partition by address_1,
					address_2,
					city,
					state,
					zip,
					county,
					country_concept_id,
					country_source_value,
					latitude,
					longitude order by (select null)
			) as RowNumber
		from @Locations l
	)
	insert into cdm.LOCATION
	(
		address_1,
		address_2,
		city,
		state,
		zip,
		county,
		location_source_value,
		country_concept_id,
		country_source_value,
		latitude,
		longitude
	)
	select 
		l.address_1,
		l.address_2,
		l.city,
		l.state,
		l.zip,
		l.county,
		l.location_source_value,
		l.country_concept_id,
		l.country_source_value,
		l.latitude,
		l.longitude
	from LocationWithRow l
	where not exists (
		select *
		from cdm.LOCATION
		where (address_1 = l.address_1 or (address_1 is null and l.address_1 is null))
			and (address_2 = l.address_2 or (address_2 is null and l.address_2 is null))
			and (city = l.city or (city is null and l.city is null))
			and (state = l.state or (state is null and l.state is null))
			and (zip = l.zip or (zip is null and l.zip is null))
			and (county = l.county or (county is null and l.county is null))
			and (country_concept_id = l.country_concept_id or (country_concept_id is null and l.country_concept_id is null))
			and (country_source_value = l.country_source_value or (country_source_value is null and l.country_source_value is null))
			and (latitude = l.latitude or (latitude is null and l.latitude is null))
			and (longitude = l.longitude or (longitude is null and l.longitude is null))
	)
		and l.RowNumber = 1;

	update p
		set location_id = cdm.location_id
	from cdm.person p
		inner join @Locations l
			on p.person_source_value = l.NhsNumber
		inner join CDM.location cdm
			on
				(l.address_1 = cdm.address_1 or (l.address_1 is null and cdm.address_1 is null))
				and (l.address_2 = cdm.address_2 or (l.address_2 is null and cdm.address_2 is null))
				and (l.city = cdm.city or (l.city is null and cdm.city is null))
				and (l.state = cdm.state or (l.state is null and cdm.state is null))
				and (l.zip = cdm.zip or (l.zip is null and cdm.zip is null))
				and (l.county = cdm.county or (l.county is null and cdm.county is null))
				and (l.location_source_value = cdm.location_source_value or (l.location_source_value is null and cdm.location_source_value is null))
				and (l.country_concept_id = cdm.country_concept_id or (l.country_concept_id is null and cdm.country_concept_id is null))
				and (l.country_source_value = cdm.country_source_value or (l.country_source_value is null and cdm.country_source_value is null))
				and (l.latitude = cdm.latitude or (l.latitude is null and cdm.latitude is null))
				and (l.longitude = cdm.longitude or (l.longitude is null and cdm.longitude is null));

end