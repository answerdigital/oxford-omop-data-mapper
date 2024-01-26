if object_id ('cdm.InsertUpdateLocation') is not null
begin 
	drop procedure cdm.InsertUpdateLocation;
end

go

if object_id ('dbo.InsertUpdateLocation') is not null
begin 
	drop procedure dbo.InsertUpdateLocation;
end

go

drop type dbo.[Location];

go


create type cdm.[Location] as table
(
    address_1 varchar(255),
    address_2 varchar(255),
    city varchar(255),
    state varchar(2),
    zip varchar(9),
    county varchar(255),
    location_source_value varchar(255),
    country_concept_id int,
    country_source_value varchar(80),
    latitude float,
    longitude float
);