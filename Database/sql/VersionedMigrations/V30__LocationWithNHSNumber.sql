drop procedure cdm.InsertUpdateLocation;

drop type cdm.Location;

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
    longitude float,
	NhsNumber varchar(500)
);