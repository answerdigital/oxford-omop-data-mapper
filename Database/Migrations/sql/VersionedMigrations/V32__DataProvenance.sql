create table provenance_table_type
(
	TypeId int not null,
	Name varchar(255),
	constraint PK_provenance_table_type_TypeId primary key (TypeId),
	constraint UQ_provenance_table_type_Name unique (Name)
);

insert into provenance_table_type
(
	TypeId,
	Name
)
values
(1, 'care_site'),
(2, 'cdm_source'),
(3, 'cohort'),
(4, 'cohort_definition'),
(5, 'concept'),
(6, 'concept_ancestor'),
(7, 'concept_class'),
(8, 'concept_relationship'),
(9, 'concept_synonym'),
(10, 'condition_era'),
(11, 'condition_occurrence'),
(12, 'cost'),
(13, 'death'),
(14, 'device_exposure'),
(15, 'domain'),
(16, 'dose_era'),
(17, 'drug_era'),
(18, 'drug_exposure'),
(19, 'drug_strength'),
(20, 'episode'),
(21, 'episode_event'),
(22, 'fact_relationship'),
(23, 'location'),
(24, 'measurement'),
(25, 'metadata'),
(26, 'note'),
(27, 'note_nlp'),
(28, 'observation'),
(29, 'observation_period'),
(30, 'payer_plan_period'),
(31, 'person'),
(32, 'procedure_occurrence'),
(33, 'provider'),
(34, 'relationship'),
(35, 'source_to_concept_map'),
(36, 'specimen'),
(37, 'visit_detail'),
(38, 'visit_occurrence'),
(39, 'vocabulary');

create table provenance
(
	table_type_id int not null,
	table_key int not null,
	column_name varchar(100) not null,
	[data_source] varchar(20) not null,
	constraint PK_provenance_table_type_id_table_key_column_name
		primary key (
			table_type_id,
			table_key,
			column_name
		),
	constraint FK_provenance_table_type_id
		foreign key (
			table_type_id
		) references provenance_table_type (
			TypeId
		)			
);