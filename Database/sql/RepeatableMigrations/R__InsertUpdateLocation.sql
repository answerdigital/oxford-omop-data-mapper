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
	from @Locations l
	where not exists (
		select *
		from cdm.LOCATION
		where (address_1 = l.address_1 or (address_1 is null and l.address_1 is null))
			and (address_2 = l.address_2 or (address_2 is null and l.address_2 is null))
			and (city = l.city or (city is null and l.city is null))
			and (state = l.state or (state is null and l.state is null))
			and (zip = l.zip or (zip is null and l.zip is null))
			and (county = l.county or (county is null and l.county is null))
			and (location_source_value = l.location_source_value or (address_2 is null and l.location_source_value is null))
			and (country_concept_id = l.country_concept_id or (country_concept_id is null and l.country_concept_id is null))
			and (country_source_value = l.country_source_value or (country_source_value is null and l.country_source_value is null))
			and (latitude = l.latitude or (latitude is null and l.latitude is null))
			and (longitude = l.longitude or (longitude is null and l.longitude is null))
	);

end