alter table cdm.drug_exposure
	drop constraint xpk_drug_exposure;

go

alter table cdm.drug_exposure
	drop column drug_exposure_id;

go

alter table cdm.drug_exposure
	add drug_exposure_id int not null identity;

alter table cdm.drug_exposure
	add constraint PK_cdm_drug_exposure_drug_exposure_id
		primary key (
			drug_exposure_id
		);