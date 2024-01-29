ALTER TABLE [cdm].[vocabulary] DROP CONSTRAINT [fpk_vocabulary_vocabulary_concept_id]
GO
ALTER TABLE [cdm].[visit_occurrence] DROP CONSTRAINT [fpk_visit_occurrence_visit_type_concept_id]
GO
ALTER TABLE [cdm].[visit_occurrence] DROP CONSTRAINT [fpk_visit_occurrence_visit_source_concept_id]
GO
ALTER TABLE [cdm].[visit_occurrence] DROP CONSTRAINT [fpk_visit_occurrence_visit_concept_id]
GO
ALTER TABLE [cdm].[visit_occurrence] DROP CONSTRAINT [fpk_visit_occurrence_provider_id]
GO
ALTER TABLE [cdm].[visit_occurrence] DROP CONSTRAINT [fpk_visit_occurrence_preceding_visit_occurrence_id]
GO
ALTER TABLE [cdm].[visit_occurrence] DROP CONSTRAINT [fpk_visit_occurrence_person_id]
GO
ALTER TABLE [cdm].[visit_occurrence] DROP CONSTRAINT [fpk_visit_occurrence_discharged_to_concept_id]
GO
ALTER TABLE [cdm].[visit_occurrence] DROP CONSTRAINT [fpk_visit_occurrence_care_site_id]
GO
ALTER TABLE [cdm].[visit_occurrence] DROP CONSTRAINT [fpk_visit_occurrence_admitted_from_concept_id]
GO
ALTER TABLE [cdm].[visit_detail] DROP CONSTRAINT [fpk_visit_detail_visit_occurrence_id]
GO
ALTER TABLE [cdm].[visit_detail] DROP CONSTRAINT [fpk_visit_detail_visit_detail_type_concept_id]
GO
ALTER TABLE [cdm].[visit_detail] DROP CONSTRAINT [fpk_visit_detail_visit_detail_source_concept_id]
GO
ALTER TABLE [cdm].[visit_detail] DROP CONSTRAINT [fpk_visit_detail_visit_detail_concept_id]
GO
ALTER TABLE [cdm].[visit_detail] DROP CONSTRAINT [fpk_visit_detail_provider_id]
GO
ALTER TABLE [cdm].[visit_detail] DROP CONSTRAINT [fpk_visit_detail_preceding_visit_detail_id]
GO
ALTER TABLE [cdm].[visit_detail] DROP CONSTRAINT [fpk_visit_detail_person_id]
GO
ALTER TABLE [cdm].[visit_detail] DROP CONSTRAINT [fpk_visit_detail_parent_visit_detail_id]
GO
ALTER TABLE [cdm].[visit_detail] DROP CONSTRAINT [fpk_visit_detail_discharged_to_concept_id]
GO
ALTER TABLE [cdm].[visit_detail] DROP CONSTRAINT [fpk_visit_detail_care_site_id]
GO
ALTER TABLE [cdm].[visit_detail] DROP CONSTRAINT [fpk_visit_detail_admitted_from_concept_id]
GO
ALTER TABLE [cdm].[specimen] DROP CONSTRAINT [fpk_specimen_unit_concept_id]
GO
ALTER TABLE [cdm].[specimen] DROP CONSTRAINT [fpk_specimen_specimen_type_concept_id]
GO
ALTER TABLE [cdm].[specimen] DROP CONSTRAINT [fpk_specimen_specimen_concept_id]
GO
ALTER TABLE [cdm].[specimen] DROP CONSTRAINT [fpk_specimen_person_id]
GO
ALTER TABLE [cdm].[specimen] DROP CONSTRAINT [fpk_specimen_disease_status_concept_id]
GO
ALTER TABLE [cdm].[specimen] DROP CONSTRAINT [fpk_specimen_anatomic_site_concept_id]
GO
ALTER TABLE [cdm].[source_to_concept_map] DROP CONSTRAINT [fpk_source_to_concept_map_target_vocabulary_id]
GO
ALTER TABLE [cdm].[source_to_concept_map] DROP CONSTRAINT [fpk_source_to_concept_map_target_concept_id]
GO
ALTER TABLE [cdm].[source_to_concept_map] DROP CONSTRAINT [fpk_source_to_concept_map_source_concept_id]
GO
ALTER TABLE [cdm].[relationship] DROP CONSTRAINT [fpk_relationship_relationship_concept_id]
GO
ALTER TABLE [cdm].[provider] DROP CONSTRAINT [fpk_provider_specialty_source_concept_id]
GO
ALTER TABLE [cdm].[provider] DROP CONSTRAINT [fpk_provider_specialty_concept_id]
GO
ALTER TABLE [cdm].[provider] DROP CONSTRAINT [fpk_provider_gender_source_concept_id]
GO
ALTER TABLE [cdm].[provider] DROP CONSTRAINT [fpk_provider_gender_concept_id]
GO
ALTER TABLE [cdm].[provider] DROP CONSTRAINT [fpk_provider_care_site_id]
GO
ALTER TABLE [cdm].[procedure_occurrence] DROP CONSTRAINT [fpk_procedure_occurrence_visit_occurrence_id]
GO
ALTER TABLE [cdm].[procedure_occurrence] DROP CONSTRAINT [fpk_procedure_occurrence_visit_detail_id]
GO
ALTER TABLE [cdm].[procedure_occurrence] DROP CONSTRAINT [fpk_procedure_occurrence_provider_id]
GO
ALTER TABLE [cdm].[procedure_occurrence] DROP CONSTRAINT [fpk_procedure_occurrence_procedure_type_concept_id]
GO
ALTER TABLE [cdm].[procedure_occurrence] DROP CONSTRAINT [fpk_procedure_occurrence_procedure_source_concept_id]
GO
ALTER TABLE [cdm].[procedure_occurrence] DROP CONSTRAINT [fpk_procedure_occurrence_procedure_concept_id]
GO
ALTER TABLE [cdm].[procedure_occurrence] DROP CONSTRAINT [fpk_procedure_occurrence_person_id]
GO
ALTER TABLE [cdm].[procedure_occurrence] DROP CONSTRAINT [fpk_procedure_occurrence_modifier_concept_id]
GO
ALTER TABLE [cdm].[person] DROP CONSTRAINT [fpk_person_race_source_concept_id]
GO
ALTER TABLE [cdm].[person] DROP CONSTRAINT [fpk_person_race_concept_id]
GO
ALTER TABLE [cdm].[person] DROP CONSTRAINT [fpk_person_provider_id]
GO
ALTER TABLE [cdm].[person] DROP CONSTRAINT [fpk_person_gender_source_concept_id]
GO
ALTER TABLE [cdm].[person] DROP CONSTRAINT [fpk_person_gender_concept_id]
GO
ALTER TABLE [cdm].[person] DROP CONSTRAINT [fpk_person_ethnicity_source_concept_id]
GO
ALTER TABLE [cdm].[person] DROP CONSTRAINT [fpk_person_ethnicity_concept_id]
GO
ALTER TABLE [cdm].[person] DROP CONSTRAINT [fpk_person_care_site_id]
GO
ALTER TABLE [cdm].[person] DROP CONSTRAINT [FK_cdm_person_location_id]
GO
ALTER TABLE [cdm].[payer_plan_period] DROP CONSTRAINT [fpk_payer_plan_period_stop_reason_source_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period] DROP CONSTRAINT [fpk_payer_plan_period_stop_reason_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period] DROP CONSTRAINT [fpk_payer_plan_period_sponsor_source_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period] DROP CONSTRAINT [fpk_payer_plan_period_sponsor_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period] DROP CONSTRAINT [fpk_payer_plan_period_plan_source_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period] DROP CONSTRAINT [fpk_payer_plan_period_plan_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period] DROP CONSTRAINT [fpk_payer_plan_period_person_id]
GO
ALTER TABLE [cdm].[payer_plan_period] DROP CONSTRAINT [fpk_payer_plan_period_payer_source_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period] DROP CONSTRAINT [fpk_payer_plan_period_payer_concept_id]
GO
ALTER TABLE [cdm].[observation_period] DROP CONSTRAINT [fpk_observation_period_person_id]
GO
ALTER TABLE [cdm].[observation_period] DROP CONSTRAINT [fpk_observation_period_period_type_concept_id]
GO
ALTER TABLE [cdm].[observation] DROP CONSTRAINT [fpk_observation_visit_occurrence_id]
GO
ALTER TABLE [cdm].[observation] DROP CONSTRAINT [fpk_observation_visit_detail_id]
GO
ALTER TABLE [cdm].[observation] DROP CONSTRAINT [fpk_observation_value_as_concept_id]
GO
ALTER TABLE [cdm].[observation] DROP CONSTRAINT [fpk_observation_unit_concept_id]
GO
ALTER TABLE [cdm].[observation] DROP CONSTRAINT [fpk_observation_qualifier_concept_id]
GO
ALTER TABLE [cdm].[observation] DROP CONSTRAINT [fpk_observation_provider_id]
GO
ALTER TABLE [cdm].[observation] DROP CONSTRAINT [fpk_observation_person_id]
GO
ALTER TABLE [cdm].[observation] DROP CONSTRAINT [fpk_observation_observation_type_concept_id]
GO
ALTER TABLE [cdm].[observation] DROP CONSTRAINT [fpk_observation_observation_source_concept_id]
GO
ALTER TABLE [cdm].[observation] DROP CONSTRAINT [fpk_observation_observation_concept_id]
GO
ALTER TABLE [cdm].[observation] DROP CONSTRAINT [fpk_observation_obs_event_field_concept_id]
GO
ALTER TABLE [cdm].[note_nlp] DROP CONSTRAINT [fpk_note_nlp_section_concept_id]
GO
ALTER TABLE [cdm].[note_nlp] DROP CONSTRAINT [fpk_note_nlp_note_nlp_source_concept_id]
GO
ALTER TABLE [cdm].[note_nlp] DROP CONSTRAINT [fpk_note_nlp_note_nlp_concept_id]
GO
ALTER TABLE [cdm].[note] DROP CONSTRAINT [fpk_note_visit_occurrence_id]
GO
ALTER TABLE [cdm].[note] DROP CONSTRAINT [fpk_note_visit_detail_id]
GO
ALTER TABLE [cdm].[note] DROP CONSTRAINT [fpk_note_provider_id]
GO
ALTER TABLE [cdm].[note] DROP CONSTRAINT [fpk_note_person_id]
GO
ALTER TABLE [cdm].[note] DROP CONSTRAINT [fpk_note_note_type_concept_id]
GO
ALTER TABLE [cdm].[note] DROP CONSTRAINT [fpk_note_note_event_field_concept_id]
GO
ALTER TABLE [cdm].[note] DROP CONSTRAINT [fpk_note_note_class_concept_id]
GO
ALTER TABLE [cdm].[note] DROP CONSTRAINT [fpk_note_language_concept_id]
GO
ALTER TABLE [cdm].[note] DROP CONSTRAINT [fpk_note_encoding_concept_id]
GO
ALTER TABLE [cdm].[metadata] DROP CONSTRAINT [fpk_metadata_value_as_concept_id]
GO
ALTER TABLE [cdm].[metadata] DROP CONSTRAINT [fpk_metadata_metadata_type_concept_id]
GO
ALTER TABLE [cdm].[metadata] DROP CONSTRAINT [fpk_metadata_metadata_concept_id]
GO
ALTER TABLE [cdm].[measurement] DROP CONSTRAINT [fpk_measurement_visit_occurrence_id]
GO
ALTER TABLE [cdm].[measurement] DROP CONSTRAINT [fpk_measurement_visit_detail_id]
GO
ALTER TABLE [cdm].[measurement] DROP CONSTRAINT [fpk_measurement_value_as_concept_id]
GO
ALTER TABLE [cdm].[measurement] DROP CONSTRAINT [fpk_measurement_unit_source_concept_id]
GO
ALTER TABLE [cdm].[measurement] DROP CONSTRAINT [fpk_measurement_unit_concept_id]
GO
ALTER TABLE [cdm].[measurement] DROP CONSTRAINT [fpk_measurement_provider_id]
GO
ALTER TABLE [cdm].[measurement] DROP CONSTRAINT [fpk_measurement_person_id]
GO
ALTER TABLE [cdm].[measurement] DROP CONSTRAINT [fpk_measurement_operator_concept_id]
GO
ALTER TABLE [cdm].[measurement] DROP CONSTRAINT [fpk_measurement_measurement_type_concept_id]
GO
ALTER TABLE [cdm].[measurement] DROP CONSTRAINT [fpk_measurement_measurement_source_concept_id]
GO
ALTER TABLE [cdm].[measurement] DROP CONSTRAINT [fpk_measurement_measurement_concept_id]
GO
ALTER TABLE [cdm].[measurement] DROP CONSTRAINT [fpk_measurement_meas_event_field_concept_id]
GO
ALTER TABLE [cdm].[location] DROP CONSTRAINT [fpk_location_country_concept_id]
GO
ALTER TABLE [cdm].[fact_relationship] DROP CONSTRAINT [fpk_fact_relationship_relationship_concept_id]
GO
ALTER TABLE [cdm].[fact_relationship] DROP CONSTRAINT [fpk_fact_relationship_domain_concept_id_2]
GO
ALTER TABLE [cdm].[fact_relationship] DROP CONSTRAINT [fpk_fact_relationship_domain_concept_id_1]
GO
ALTER TABLE [cdm].[episode_event] DROP CONSTRAINT [fpk_episode_event_episode_id]
GO
ALTER TABLE [cdm].[episode_event] DROP CONSTRAINT [fpk_episode_event_episode_event_field_concept_id]
GO
ALTER TABLE [cdm].[episode] DROP CONSTRAINT [fpk_episode_person_id]
GO
ALTER TABLE [cdm].[episode] DROP CONSTRAINT [fpk_episode_episode_type_concept_id]
GO
ALTER TABLE [cdm].[episode] DROP CONSTRAINT [fpk_episode_episode_source_concept_id]
GO
ALTER TABLE [cdm].[episode] DROP CONSTRAINT [fpk_episode_episode_object_concept_id]
GO
ALTER TABLE [cdm].[episode] DROP CONSTRAINT [fpk_episode_episode_concept_id]
GO
ALTER TABLE [cdm].[drug_strength] DROP CONSTRAINT [fpk_drug_strength_numerator_unit_concept_id]
GO
ALTER TABLE [cdm].[drug_strength] DROP CONSTRAINT [fpk_drug_strength_ingredient_concept_id]
GO
ALTER TABLE [cdm].[drug_strength] DROP CONSTRAINT [fpk_drug_strength_drug_concept_id]
GO
ALTER TABLE [cdm].[drug_strength] DROP CONSTRAINT [fpk_drug_strength_denominator_unit_concept_id]
GO
ALTER TABLE [cdm].[drug_strength] DROP CONSTRAINT [fpk_drug_strength_amount_unit_concept_id]
GO
ALTER TABLE [cdm].[drug_exposure] DROP CONSTRAINT [fpk_drug_exposure_visit_occurrence_id]
GO
ALTER TABLE [cdm].[drug_exposure] DROP CONSTRAINT [fpk_drug_exposure_visit_detail_id]
GO
ALTER TABLE [cdm].[drug_exposure] DROP CONSTRAINT [fpk_drug_exposure_route_concept_id]
GO
ALTER TABLE [cdm].[drug_exposure] DROP CONSTRAINT [fpk_drug_exposure_provider_id]
GO
ALTER TABLE [cdm].[drug_exposure] DROP CONSTRAINT [fpk_drug_exposure_person_id]
GO
ALTER TABLE [cdm].[drug_exposure] DROP CONSTRAINT [fpk_drug_exposure_drug_type_concept_id]
GO
ALTER TABLE [cdm].[drug_exposure] DROP CONSTRAINT [fpk_drug_exposure_drug_source_concept_id]
GO
ALTER TABLE [cdm].[drug_exposure] DROP CONSTRAINT [fpk_drug_exposure_drug_concept_id]
GO
ALTER TABLE [cdm].[drug_era] DROP CONSTRAINT [fpk_drug_era_person_id]
GO
ALTER TABLE [cdm].[drug_era] DROP CONSTRAINT [fpk_drug_era_drug_concept_id]
GO
ALTER TABLE [cdm].[dose_era] DROP CONSTRAINT [fpk_dose_era_unit_concept_id]
GO
ALTER TABLE [cdm].[dose_era] DROP CONSTRAINT [fpk_dose_era_person_id]
GO
ALTER TABLE [cdm].[dose_era] DROP CONSTRAINT [fpk_dose_era_drug_concept_id]
GO
ALTER TABLE [cdm].[domain] DROP CONSTRAINT [fpk_domain_domain_concept_id]
GO
ALTER TABLE [cdm].[device_exposure] DROP CONSTRAINT [fpk_device_exposure_visit_occurrence_id]
GO
ALTER TABLE [cdm].[device_exposure] DROP CONSTRAINT [fpk_device_exposure_visit_detail_id]
GO
ALTER TABLE [cdm].[device_exposure] DROP CONSTRAINT [fpk_device_exposure_unit_source_concept_id]
GO
ALTER TABLE [cdm].[device_exposure] DROP CONSTRAINT [fpk_device_exposure_unit_concept_id]
GO
ALTER TABLE [cdm].[device_exposure] DROP CONSTRAINT [fpk_device_exposure_provider_id]
GO
ALTER TABLE [cdm].[device_exposure] DROP CONSTRAINT [fpk_device_exposure_person_id]
GO
ALTER TABLE [cdm].[device_exposure] DROP CONSTRAINT [fpk_device_exposure_device_type_concept_id]
GO
ALTER TABLE [cdm].[device_exposure] DROP CONSTRAINT [fpk_device_exposure_device_source_concept_id]
GO
ALTER TABLE [cdm].[device_exposure] DROP CONSTRAINT [fpk_device_exposure_device_concept_id]
GO
ALTER TABLE [cdm].[death] DROP CONSTRAINT [fpk_death_person_id]
GO
ALTER TABLE [cdm].[death] DROP CONSTRAINT [fpk_death_death_type_concept_id]
GO
ALTER TABLE [cdm].[death] DROP CONSTRAINT [fpk_death_cause_source_concept_id]
GO
ALTER TABLE [cdm].[death] DROP CONSTRAINT [fpk_death_cause_concept_id]
GO
ALTER TABLE [cdm].[cost] DROP CONSTRAINT [fpk_cost_revenue_code_concept_id]
GO
ALTER TABLE [cdm].[cost] DROP CONSTRAINT [fpk_cost_drg_concept_id]
GO
ALTER TABLE [cdm].[cost] DROP CONSTRAINT [fpk_cost_currency_concept_id]
GO
ALTER TABLE [cdm].[cost] DROP CONSTRAINT [fpk_cost_cost_type_concept_id]
GO
ALTER TABLE [cdm].[cost] DROP CONSTRAINT [fpk_cost_cost_domain_id]
GO
ALTER TABLE [cdm].[condition_occurrence] DROP CONSTRAINT [fpk_condition_occurrence_visit_occurrence_id]
GO
ALTER TABLE [cdm].[condition_occurrence] DROP CONSTRAINT [fpk_condition_occurrence_visit_detail_id]
GO
ALTER TABLE [cdm].[condition_occurrence] DROP CONSTRAINT [fpk_condition_occurrence_provider_id]
GO
ALTER TABLE [cdm].[condition_occurrence] DROP CONSTRAINT [fpk_condition_occurrence_person_id]
GO
ALTER TABLE [cdm].[condition_occurrence] DROP CONSTRAINT [fpk_condition_occurrence_condition_type_concept_id]
GO
ALTER TABLE [cdm].[condition_occurrence] DROP CONSTRAINT [fpk_condition_occurrence_condition_status_concept_id]
GO
ALTER TABLE [cdm].[condition_occurrence] DROP CONSTRAINT [fpk_condition_occurrence_condition_source_concept_id]
GO
ALTER TABLE [cdm].[condition_occurrence] DROP CONSTRAINT [fpk_condition_occurrence_condition_concept_id]
GO
ALTER TABLE [cdm].[condition_era] DROP CONSTRAINT [fpk_condition_era_person_id]
GO
ALTER TABLE [cdm].[condition_era] DROP CONSTRAINT [fpk_condition_era_condition_concept_id]
GO
ALTER TABLE [cdm].[concept_synonym] DROP CONSTRAINT [fpk_concept_synonym_language_concept_id]
GO
ALTER TABLE [cdm].[concept_synonym] DROP CONSTRAINT [fpk_concept_synonym_concept_id]
GO
ALTER TABLE [cdm].[concept_relationship] DROP CONSTRAINT [fpk_concept_relationship_relationship_id]
GO
ALTER TABLE [cdm].[concept_relationship] DROP CONSTRAINT [fpk_concept_relationship_concept_id_2]
GO
ALTER TABLE [cdm].[concept_relationship] DROP CONSTRAINT [fpk_concept_relationship_concept_id_1]
GO
ALTER TABLE [cdm].[concept_class] DROP CONSTRAINT [fpk_concept_class_concept_class_concept_id]
GO
ALTER TABLE [cdm].[concept_ancestor] DROP CONSTRAINT [fpk_concept_ancestor_descendant_concept_id]
GO
ALTER TABLE [cdm].[concept_ancestor] DROP CONSTRAINT [fpk_concept_ancestor_ancestor_concept_id]
GO
ALTER TABLE [cdm].[concept] DROP CONSTRAINT [fpk_concept_vocabulary_id]
GO
ALTER TABLE [cdm].[concept] DROP CONSTRAINT [fpk_concept_domain_id]
GO
ALTER TABLE [cdm].[concept] DROP CONSTRAINT [fpk_concept_concept_class_id]
GO
ALTER TABLE [cdm].[cohort_definition] DROP CONSTRAINT [fpk_cohort_definition_subject_concept_id]
GO
ALTER TABLE [cdm].[cohort_definition] DROP CONSTRAINT [fpk_cohort_definition_definition_type_concept_id]
GO
ALTER TABLE [cdm].[cdm_source] DROP CONSTRAINT [fpk_cdm_source_cdm_version_concept_id]
GO
ALTER TABLE [cdm].[care_site] DROP CONSTRAINT [fpk_care_site_place_of_service_concept_id]
GO
ALTER TABLE [cdm].[care_site] DROP CONSTRAINT [FK_cdm_care_site_location_id]
GO
/****** Object:  Table [cdm].[vocabulary]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[vocabulary]') AND type in (N'U'))
DROP TABLE [cdm].[vocabulary]
GO
/****** Object:  Table [cdm].[visit_occurrence]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[visit_occurrence]') AND type in (N'U'))
DROP TABLE [cdm].[visit_occurrence]
GO
/****** Object:  Table [cdm].[visit_detail]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[visit_detail]') AND type in (N'U'))
DROP TABLE [cdm].[visit_detail]
GO
/****** Object:  Table [cdm].[specimen]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[specimen]') AND type in (N'U'))
DROP TABLE [cdm].[specimen]
GO
/****** Object:  Table [cdm].[source_to_concept_map]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[source_to_concept_map]') AND type in (N'U'))
DROP TABLE [cdm].[source_to_concept_map]
GO
/****** Object:  Table [cdm].[relationship]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[relationship]') AND type in (N'U'))
DROP TABLE [cdm].[relationship]
GO
/****** Object:  Table [cdm].[provider]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[provider]') AND type in (N'U'))
DROP TABLE [cdm].[provider]
GO
/****** Object:  Table [cdm].[procedure_occurrence]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[procedure_occurrence]') AND type in (N'U'))
DROP TABLE [cdm].[procedure_occurrence]
GO
/****** Object:  Table [cdm].[person]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[person]') AND type in (N'U'))
DROP TABLE [cdm].[person]
GO
/****** Object:  Table [cdm].[payer_plan_period]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[payer_plan_period]') AND type in (N'U'))
DROP TABLE [cdm].[payer_plan_period]
GO
/****** Object:  Table [cdm].[observation_period]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[observation_period]') AND type in (N'U'))
DROP TABLE [cdm].[observation_period]
GO
/****** Object:  Table [cdm].[observation]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[observation]') AND type in (N'U'))
DROP TABLE [cdm].[observation]
GO
/****** Object:  Table [cdm].[note_nlp]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[note_nlp]') AND type in (N'U'))
DROP TABLE [cdm].[note_nlp]
GO
/****** Object:  Table [cdm].[note]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[note]') AND type in (N'U'))
DROP TABLE [cdm].[note]
GO
/****** Object:  Table [cdm].[metadata]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[metadata]') AND type in (N'U'))
DROP TABLE [cdm].[metadata]
GO
/****** Object:  Table [cdm].[measurement]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[measurement]') AND type in (N'U'))
DROP TABLE [cdm].[measurement]
GO
/****** Object:  Table [cdm].[location]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[location]') AND type in (N'U'))
DROP TABLE [cdm].[location]
GO
/****** Object:  Table [cdm].[fact_relationship]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[fact_relationship]') AND type in (N'U'))
DROP TABLE [cdm].[fact_relationship]
GO
/****** Object:  Table [cdm].[episode_event]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[episode_event]') AND type in (N'U'))
DROP TABLE [cdm].[episode_event]
GO
/****** Object:  Table [cdm].[episode]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[episode]') AND type in (N'U'))
DROP TABLE [cdm].[episode]
GO
/****** Object:  Table [cdm].[drug_strength]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[drug_strength]') AND type in (N'U'))
DROP TABLE [cdm].[drug_strength]
GO
/****** Object:  Table [cdm].[drug_exposure]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[drug_exposure]') AND type in (N'U'))
DROP TABLE [cdm].[drug_exposure]
GO
/****** Object:  Table [cdm].[drug_era]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[drug_era]') AND type in (N'U'))
DROP TABLE [cdm].[drug_era]
GO
/****** Object:  Table [cdm].[dose_era]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[dose_era]') AND type in (N'U'))
DROP TABLE [cdm].[dose_era]
GO
/****** Object:  Table [cdm].[domain]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[domain]') AND type in (N'U'))
DROP TABLE [cdm].[domain]
GO
/****** Object:  Table [cdm].[device_exposure]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[device_exposure]') AND type in (N'U'))
DROP TABLE [cdm].[device_exposure]
GO
/****** Object:  Table [cdm].[death]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[death]') AND type in (N'U'))
DROP TABLE [cdm].[death]
GO
/****** Object:  Table [cdm].[cost]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[cost]') AND type in (N'U'))
DROP TABLE [cdm].[cost]
GO
/****** Object:  Table [cdm].[condition_occurrence]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[condition_occurrence]') AND type in (N'U'))
DROP TABLE [cdm].[condition_occurrence]
GO
/****** Object:  Table [cdm].[condition_era]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[condition_era]') AND type in (N'U'))
DROP TABLE [cdm].[condition_era]
GO
/****** Object:  Table [cdm].[concept_synonym]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[concept_synonym]') AND type in (N'U'))
DROP TABLE [cdm].[concept_synonym]
GO
/****** Object:  Table [cdm].[concept_relationship]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[concept_relationship]') AND type in (N'U'))
DROP TABLE [cdm].[concept_relationship]
GO
/****** Object:  Table [cdm].[concept_class]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[concept_class]') AND type in (N'U'))
DROP TABLE [cdm].[concept_class]
GO
/****** Object:  Table [cdm].[concept_ancestor]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[concept_ancestor]') AND type in (N'U'))
DROP TABLE [cdm].[concept_ancestor]
GO
/****** Object:  Table [cdm].[concept]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[concept]') AND type in (N'U'))
DROP TABLE [cdm].[concept]
GO
/****** Object:  Table [cdm].[cohort_definition]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[cohort_definition]') AND type in (N'U'))
DROP TABLE [cdm].[cohort_definition]
GO
/****** Object:  Table [cdm].[cohort]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[cohort]') AND type in (N'U'))
DROP TABLE [cdm].[cohort]
GO
/****** Object:  Table [cdm].[cdm_source]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[cdm_source]') AND type in (N'U'))
DROP TABLE [cdm].[cdm_source]
GO
/****** Object:  Table [cdm].[care_site]    Script Date: 29/01/2024 13:38:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[cdm].[care_site]') AND type in (N'U'))
DROP TABLE [cdm].[care_site]
GO
/****** Object:  Table [cdm].[care_site]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[care_site](
	[care_site_id] [int] NOT NULL,
	[care_site_name] [varchar](255) NULL,
	[place_of_service_concept_id] [int] NULL,
	[location_id] [int] NULL,
	[care_site_source_value] [varchar](50) NULL,
	[place_of_service_source_value] [varchar](50) NULL,
 CONSTRAINT [xpk_care_site] PRIMARY KEY NONCLUSTERED 
(
	[care_site_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[cdm_source]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[cdm_source](
	[cdm_source_name] [varchar](255) NOT NULL,
	[cdm_source_abbreviation] [varchar](25) NOT NULL,
	[cdm_holder] [varchar](255) NOT NULL,
	[source_description] [varchar](max) NULL,
	[source_documentation_reference] [varchar](255) NULL,
	[cdm_etl_reference] [varchar](255) NULL,
	[source_release_date] [date] NOT NULL,
	[cdm_release_date] [date] NOT NULL,
	[cdm_version] [varchar](10) NULL,
	[cdm_version_concept_id] [int] NOT NULL,
	[vocabulary_version] [varchar](20) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [cdm].[cohort]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[cohort](
	[cohort_definition_id] [int] NOT NULL,
	[subject_id] [int] NOT NULL,
	[cohort_start_date] [date] NOT NULL,
	[cohort_end_date] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[cohort_definition]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[cohort_definition](
	[cohort_definition_id] [int] NOT NULL,
	[cohort_definition_name] [varchar](255) NOT NULL,
	[cohort_definition_description] [varchar](max) NULL,
	[definition_type_concept_id] [int] NOT NULL,
	[cohort_definition_syntax] [varchar](max) NULL,
	[subject_concept_id] [int] NOT NULL,
	[cohort_initiation_date] [date] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [cdm].[concept]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[concept](
	[concept_id] [int] NOT NULL,
	[concept_name] [nvarchar](1000) NOT NULL,
	[domain_id] [varchar](20) NOT NULL,
	[vocabulary_id] [varchar](20) NOT NULL,
	[concept_class_id] [varchar](20) NOT NULL,
	[standard_concept] [varchar](1) NULL,
	[concept_code] [varchar](50) NOT NULL,
	[valid_start_date] [date] NOT NULL,
	[valid_end_date] [date] NOT NULL,
	[invalid_reason] [varchar](1) NULL,
 CONSTRAINT [xpk_concept] PRIMARY KEY NONCLUSTERED 
(
	[concept_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[concept_ancestor]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[concept_ancestor](
	[ancestor_concept_id] [int] NOT NULL,
	[descendant_concept_id] [int] NOT NULL,
	[min_levels_of_separation] [int] NOT NULL,
	[max_levels_of_separation] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[concept_class]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[concept_class](
	[concept_class_id] [varchar](20) NOT NULL,
	[concept_class_name] [varchar](255) NOT NULL,
	[concept_class_concept_id] [int] NOT NULL,
 CONSTRAINT [xpk_concept_class] PRIMARY KEY NONCLUSTERED 
(
	[concept_class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[concept_relationship]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[concept_relationship](
	[concept_id_1] [int] NOT NULL,
	[concept_id_2] [int] NOT NULL,
	[relationship_id] [varchar](20) NOT NULL,
	[valid_start_date] [date] NOT NULL,
	[valid_end_date] [date] NOT NULL,
	[invalid_reason] [varchar](1) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[concept_synonym]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[concept_synonym](
	[concept_id] [int] NOT NULL,
	[concept_synonym_name] [nvarchar](1000) NOT NULL,
	[language_concept_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[condition_era]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[condition_era](
	[condition_era_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[condition_concept_id] [int] NOT NULL,
	[condition_era_start_date] [date] NOT NULL,
	[condition_era_end_date] [date] NOT NULL,
	[condition_occurrence_count] [int] NULL,
 CONSTRAINT [xpk_condition_era] PRIMARY KEY NONCLUSTERED 
(
	[condition_era_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[condition_occurrence]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[condition_occurrence](
	[person_id] [int] NOT NULL,
	[condition_concept_id] [int] NOT NULL,
	[condition_start_date] [date] NOT NULL,
	[condition_start_datetime] [datetime] NULL,
	[condition_end_date] [date] NULL,
	[condition_end_datetime] [datetime] NULL,
	[condition_type_concept_id] [int] NOT NULL,
	[condition_status_concept_id] [int] NULL,
	[stop_reason] [varchar](20) NULL,
	[provider_id] [int] NULL,
	[visit_occurrence_id] [int] NULL,
	[visit_detail_id] [int] NULL,
	[condition_source_value] [varchar](50) NULL,
	[condition_source_concept_id] [int] NULL,
	[condition_status_source_value] [varchar](50) NULL,
	[condition_occurrence_id] [int] IDENTITY(1,1) NOT NULL,
	[cds_diagnosis_id] [int] NULL,
 CONSTRAINT [PK_cdm_condition_occurrence_condition_occurrence_id] PRIMARY KEY NONCLUSTERED 
(
	[condition_occurrence_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[cost]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[cost](
	[cost_id] [int] NOT NULL,
	[cost_event_id] [int] NOT NULL,
	[cost_domain_id] [varchar](20) NOT NULL,
	[cost_type_concept_id] [int] NOT NULL,
	[currency_concept_id] [int] NULL,
	[total_charge] [float] NULL,
	[total_cost] [float] NULL,
	[total_paid] [float] NULL,
	[paid_by_payer] [float] NULL,
	[paid_by_patient] [float] NULL,
	[paid_patient_copay] [float] NULL,
	[paid_patient_coinsurance] [float] NULL,
	[paid_patient_deductible] [float] NULL,
	[paid_by_primary] [float] NULL,
	[paid_ingredient_cost] [float] NULL,
	[paid_dispensing_fee] [float] NULL,
	[payer_plan_period_id] [int] NULL,
	[amount_allowed] [float] NULL,
	[revenue_code_concept_id] [int] NULL,
	[revenue_code_source_value] [varchar](50) NULL,
	[drg_concept_id] [int] NULL,
	[drg_source_value] [varchar](3) NULL,
 CONSTRAINT [xpk_cost] PRIMARY KEY NONCLUSTERED 
(
	[cost_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[death]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[death](
	[person_id] [int] NOT NULL,
	[death_date] [date] NOT NULL,
	[death_datetime] [datetime] NULL,
	[death_type_concept_id] [int] NULL,
	[cause_concept_id] [int] NULL,
	[cause_source_value] [varchar](50) NULL,
	[cause_source_concept_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[device_exposure]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[device_exposure](
	[device_exposure_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[device_concept_id] [int] NOT NULL,
	[device_exposure_start_date] [date] NOT NULL,
	[device_exposure_start_datetime] [datetime] NULL,
	[device_exposure_end_date] [date] NULL,
	[device_exposure_end_datetime] [datetime] NULL,
	[device_type_concept_id] [int] NOT NULL,
	[unique_device_id] [varchar](255) NULL,
	[production_id] [varchar](255) NULL,
	[quantity] [int] NULL,
	[provider_id] [int] NULL,
	[visit_occurrence_id] [int] NULL,
	[visit_detail_id] [int] NULL,
	[device_source_value] [varchar](50) NULL,
	[device_source_concept_id] [int] NULL,
	[unit_concept_id] [int] NULL,
	[unit_source_value] [varchar](50) NULL,
	[unit_source_concept_id] [int] NULL,
 CONSTRAINT [xpk_device_exposure] PRIMARY KEY NONCLUSTERED 
(
	[device_exposure_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[domain]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[domain](
	[domain_id] [varchar](20) NOT NULL,
	[domain_name] [varchar](255) NOT NULL,
	[domain_concept_id] [int] NOT NULL,
 CONSTRAINT [xpk_domain] PRIMARY KEY NONCLUSTERED 
(
	[domain_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[dose_era]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[dose_era](
	[dose_era_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[drug_concept_id] [int] NOT NULL,
	[unit_concept_id] [int] NOT NULL,
	[dose_value] [float] NOT NULL,
	[dose_era_start_date] [date] NOT NULL,
	[dose_era_end_date] [date] NOT NULL,
 CONSTRAINT [xpk_dose_era] PRIMARY KEY NONCLUSTERED 
(
	[dose_era_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[drug_era]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[drug_era](
	[drug_era_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[drug_concept_id] [int] NOT NULL,
	[drug_era_start_date] [date] NOT NULL,
	[drug_era_end_date] [date] NOT NULL,
	[drug_exposure_count] [int] NULL,
	[gap_days] [int] NULL,
 CONSTRAINT [xpk_drug_era] PRIMARY KEY NONCLUSTERED 
(
	[drug_era_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[drug_exposure]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[drug_exposure](
	[drug_exposure_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[drug_concept_id] [int] NOT NULL,
	[drug_exposure_start_date] [date] NOT NULL,
	[drug_exposure_start_datetime] [datetime] NULL,
	[drug_exposure_end_date] [date] NOT NULL,
	[drug_exposure_end_datetime] [datetime] NULL,
	[verbatim_end_date] [date] NULL,
	[drug_type_concept_id] [int] NOT NULL,
	[stop_reason] [varchar](20) NULL,
	[refills] [int] NULL,
	[quantity] [float] NULL,
	[days_supply] [int] NULL,
	[sig] [varchar](max) NULL,
	[route_concept_id] [int] NULL,
	[lot_number] [varchar](50) NULL,
	[provider_id] [int] NULL,
	[visit_occurrence_id] [int] NULL,
	[visit_detail_id] [int] NULL,
	[drug_source_value] [varchar](50) NULL,
	[drug_source_concept_id] [int] NULL,
	[route_source_value] [varchar](50) NULL,
	[dose_unit_source_value] [varchar](50) NULL,
 CONSTRAINT [xpk_drug_exposure] PRIMARY KEY NONCLUSTERED 
(
	[drug_exposure_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [cdm].[drug_strength]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[drug_strength](
	[drug_concept_id] [int] NOT NULL,
	[ingredient_concept_id] [int] NOT NULL,
	[amount_value] [float] NULL,
	[amount_unit_concept_id] [int] NULL,
	[numerator_value] [float] NULL,
	[numerator_unit_concept_id] [int] NULL,
	[denominator_value] [float] NULL,
	[denominator_unit_concept_id] [int] NULL,
	[box_size] [int] NULL,
	[valid_start_date] [date] NOT NULL,
	[valid_end_date] [date] NOT NULL,
	[invalid_reason] [varchar](1) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[episode]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[episode](
	[episode_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[episode_concept_id] [int] NOT NULL,
	[episode_start_date] [date] NOT NULL,
	[episode_start_datetime] [datetime] NULL,
	[episode_end_date] [date] NULL,
	[episode_end_datetime] [datetime] NULL,
	[episode_parent_id] [int] NULL,
	[episode_number] [int] NULL,
	[episode_object_concept_id] [int] NOT NULL,
	[episode_type_concept_id] [int] NOT NULL,
	[episode_source_value] [varchar](50) NULL,
	[episode_source_concept_id] [int] NULL,
 CONSTRAINT [xpk_episode] PRIMARY KEY NONCLUSTERED 
(
	[episode_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[episode_event]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[episode_event](
	[episode_id] [int] NOT NULL,
	[event_id] [int] NOT NULL,
	[episode_event_field_concept_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[fact_relationship]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[fact_relationship](
	[domain_concept_id_1] [int] NOT NULL,
	[fact_id_1] [int] NOT NULL,
	[domain_concept_id_2] [int] NOT NULL,
	[fact_id_2] [int] NOT NULL,
	[relationship_concept_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[location]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[location](
	[address_1] [varchar](255) NULL,
	[address_2] [varchar](255) NULL,
	[city] [varchar](255) NULL,
	[state] [varchar](2) NULL,
	[zip] [varchar](9) NULL,
	[county] [varchar](255) NULL,
	[location_source_value] [varchar](255) NULL,
	[country_concept_id] [int] NULL,
	[country_source_value] [varchar](80) NULL,
	[latitude] [float] NULL,
	[longitude] [float] NULL,
	[location_id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_cdm_location_location_id] PRIMARY KEY CLUSTERED 
(
	[location_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[measurement]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[measurement](
	[measurement_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[measurement_concept_id] [int] NOT NULL,
	[measurement_date] [date] NOT NULL,
	[measurement_datetime] [datetime] NULL,
	[measurement_time] [varchar](10) NULL,
	[measurement_type_concept_id] [int] NOT NULL,
	[operator_concept_id] [int] NULL,
	[value_as_number] [float] NULL,
	[value_as_concept_id] [int] NULL,
	[unit_concept_id] [int] NULL,
	[range_low] [float] NULL,
	[range_high] [float] NULL,
	[provider_id] [int] NULL,
	[visit_occurrence_id] [int] NULL,
	[visit_detail_id] [int] NULL,
	[measurement_source_value] [varchar](50) NULL,
	[measurement_source_concept_id] [int] NULL,
	[unit_source_value] [varchar](50) NULL,
	[unit_source_concept_id] [int] NULL,
	[value_source_value] [varchar](50) NULL,
	[measurement_event_id] [int] NULL,
	[meas_event_field_concept_id] [int] NULL,
 CONSTRAINT [xpk_measurement] PRIMARY KEY NONCLUSTERED 
(
	[measurement_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[metadata]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[metadata](
	[metadata_id] [int] NOT NULL,
	[metadata_concept_id] [int] NOT NULL,
	[metadata_type_concept_id] [int] NOT NULL,
	[name] [varchar](250) NOT NULL,
	[value_as_string] [varchar](250) NULL,
	[value_as_concept_id] [int] NULL,
	[value_as_number] [float] NULL,
	[metadata_date] [date] NULL,
	[metadata_datetime] [datetime] NULL,
 CONSTRAINT [xpk_metadata] PRIMARY KEY NONCLUSTERED 
(
	[metadata_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[note]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[note](
	[note_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[note_date] [date] NOT NULL,
	[note_datetime] [datetime] NULL,
	[note_type_concept_id] [int] NOT NULL,
	[note_class_concept_id] [int] NOT NULL,
	[note_title] [varchar](250) NULL,
	[note_text] [varchar](max) NOT NULL,
	[encoding_concept_id] [int] NOT NULL,
	[language_concept_id] [int] NOT NULL,
	[provider_id] [int] NULL,
	[visit_occurrence_id] [int] NULL,
	[visit_detail_id] [int] NULL,
	[note_source_value] [varchar](50) NULL,
	[note_event_id] [int] NULL,
	[note_event_field_concept_id] [int] NULL,
 CONSTRAINT [xpk_note] PRIMARY KEY NONCLUSTERED 
(
	[note_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [cdm].[note_nlp]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[note_nlp](
	[note_nlp_id] [int] NOT NULL,
	[note_id] [int] NOT NULL,
	[section_concept_id] [int] NULL,
	[snippet] [varchar](250) NULL,
	[offset] [varchar](50) NULL,
	[lexical_variant] [varchar](250) NOT NULL,
	[note_nlp_concept_id] [int] NULL,
	[note_nlp_source_concept_id] [int] NULL,
	[nlp_system] [varchar](250) NULL,
	[nlp_date] [date] NOT NULL,
	[nlp_datetime] [datetime] NULL,
	[term_exists] [varchar](1) NULL,
	[term_temporal] [varchar](50) NULL,
	[term_modifiers] [varchar](2000) NULL,
 CONSTRAINT [xpk_note_nlp] PRIMARY KEY NONCLUSTERED 
(
	[note_nlp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[observation]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[observation](
	[observation_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[observation_concept_id] [int] NOT NULL,
	[observation_date] [date] NOT NULL,
	[observation_datetime] [datetime] NULL,
	[observation_type_concept_id] [int] NOT NULL,
	[value_as_number] [float] NULL,
	[value_as_string] [varchar](60) NULL,
	[value_as_concept_id] [int] NULL,
	[qualifier_concept_id] [int] NULL,
	[unit_concept_id] [int] NULL,
	[provider_id] [int] NULL,
	[visit_occurrence_id] [int] NULL,
	[visit_detail_id] [int] NULL,
	[observation_source_value] [varchar](50) NULL,
	[observation_source_concept_id] [int] NULL,
	[unit_source_value] [varchar](50) NULL,
	[qualifier_source_value] [varchar](50) NULL,
	[value_source_value] [varchar](50) NULL,
	[observation_event_id] [int] NULL,
	[obs_event_field_concept_id] [int] NULL,
 CONSTRAINT [xpk_observation] PRIMARY KEY NONCLUSTERED 
(
	[observation_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[observation_period]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[observation_period](
	[observation_period_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[observation_period_start_date] [date] NOT NULL,
	[observation_period_end_date] [date] NOT NULL,
	[period_type_concept_id] [int] NOT NULL,
 CONSTRAINT [xpk_observation_period] PRIMARY KEY NONCLUSTERED 
(
	[observation_period_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[payer_plan_period]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[payer_plan_period](
	[payer_plan_period_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[payer_plan_period_start_date] [date] NOT NULL,
	[payer_plan_period_end_date] [date] NOT NULL,
	[payer_concept_id] [int] NULL,
	[payer_source_value] [varchar](50) NULL,
	[payer_source_concept_id] [int] NULL,
	[plan_concept_id] [int] NULL,
	[plan_source_value] [varchar](50) NULL,
	[plan_source_concept_id] [int] NULL,
	[sponsor_concept_id] [int] NULL,
	[sponsor_source_value] [varchar](50) NULL,
	[sponsor_source_concept_id] [int] NULL,
	[family_source_value] [varchar](50) NULL,
	[stop_reason_concept_id] [int] NULL,
	[stop_reason_source_value] [varchar](50) NULL,
	[stop_reason_source_concept_id] [int] NULL,
 CONSTRAINT [xpk_payer_plan_period] PRIMARY KEY NONCLUSTERED 
(
	[payer_plan_period_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[person]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[person](
	[person_id] [int] NOT NULL identity,
	[gender_concept_id] [int] NULL,
	[year_of_birth] [int] NULL,
	[month_of_birth] [int] NULL,
	[day_of_birth] [int] NULL,
	[birth_datetime] [datetime] NULL,
	[race_concept_id] [int] NULL,
	[ethnicity_concept_id] [int] NULL,
	[location_id] [int] NULL,
	[provider_id] [int] NULL,
	[care_site_id] [int] NULL,
	[person_source_value] [varchar](50) NOT NULL,
	[gender_source_value] [varchar](50) NULL,
	[gender_source_concept_id] [int] NULL,
	[race_source_value] [varchar](50) NULL,
	[race_source_concept_id] [int] NULL,
	[ethnicity_source_value] [varchar](50) NULL,
	[ethnicity_source_concept_id] [int] NULL,
 CONSTRAINT [xpk_person] PRIMARY KEY NONCLUSTERED 
(
	[person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_cdm_person_person_source_value] UNIQUE NONCLUSTERED 
(
	[person_source_value] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[procedure_occurrence]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[procedure_occurrence](
	[procedure_occurrence_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[procedure_concept_id] [int] NOT NULL,
	[procedure_date] [date] NOT NULL,
	[procedure_datetime] [datetime] NULL,
	[procedure_end_date] [date] NULL,
	[procedure_end_datetime] [datetime] NULL,
	[procedure_type_concept_id] [int] NOT NULL,
	[modifier_concept_id] [int] NULL,
	[quantity] [int] NULL,
	[provider_id] [int] NULL,
	[visit_occurrence_id] [int] NULL,
	[visit_detail_id] [int] NULL,
	[procedure_source_value] [varchar](50) NULL,
	[procedure_source_concept_id] [int] NULL,
	[modifier_source_value] [varchar](50) NULL,
 CONSTRAINT [xpk_procedure_occurrence] PRIMARY KEY NONCLUSTERED 
(
	[procedure_occurrence_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[provider]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[provider](
	[provider_id] [int] NOT NULL,
	[provider_name] [varchar](255) NULL,
	[npi] [varchar](20) NULL,
	[dea] [varchar](20) NULL,
	[specialty_concept_id] [int] NULL,
	[care_site_id] [int] NULL,
	[year_of_birth] [int] NULL,
	[gender_concept_id] [int] NULL,
	[provider_source_value] [varchar](50) NULL,
	[specialty_source_value] [varchar](50) NULL,
	[specialty_source_concept_id] [int] NULL,
	[gender_source_value] [varchar](50) NULL,
	[gender_source_concept_id] [int] NULL,
 CONSTRAINT [xpk_provider] PRIMARY KEY NONCLUSTERED 
(
	[provider_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[relationship]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[relationship](
	[relationship_id] [varchar](20) NOT NULL,
	[relationship_name] [varchar](255) NOT NULL,
	[is_hierarchical] [varchar](1) NOT NULL,
	[defines_ancestry] [varchar](1) NOT NULL,
	[reverse_relationship_id] [varchar](20) NOT NULL,
	[relationship_concept_id] [int] NOT NULL,
 CONSTRAINT [xpk_relationship] PRIMARY KEY NONCLUSTERED 
(
	[relationship_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[source_to_concept_map]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[source_to_concept_map](
	[source_code] [varchar](50) NOT NULL,
	[source_concept_id] [int] NOT NULL,
	[source_vocabulary_id] [varchar](20) NOT NULL,
	[source_code_description] [varchar](255) NULL,
	[target_concept_id] [int] NOT NULL,
	[target_vocabulary_id] [varchar](20) NOT NULL,
	[valid_start_date] [date] NOT NULL,
	[valid_end_date] [date] NOT NULL,
	[invalid_reason] [varchar](1) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[specimen]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[specimen](
	[specimen_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[specimen_concept_id] [int] NOT NULL,
	[specimen_type_concept_id] [int] NOT NULL,
	[specimen_date] [date] NOT NULL,
	[specimen_datetime] [datetime] NULL,
	[quantity] [float] NULL,
	[unit_concept_id] [int] NULL,
	[anatomic_site_concept_id] [int] NULL,
	[disease_status_concept_id] [int] NULL,
	[specimen_source_id] [varchar](50) NULL,
	[specimen_source_value] [varchar](50) NULL,
	[unit_source_value] [varchar](50) NULL,
	[anatomic_site_source_value] [varchar](50) NULL,
	[disease_status_source_value] [varchar](50) NULL,
 CONSTRAINT [xpk_specimen] PRIMARY KEY NONCLUSTERED 
(
	[specimen_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[visit_detail]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[visit_detail](
	[visit_detail_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[visit_detail_concept_id] [int] NOT NULL,
	[visit_detail_start_date] [date] NOT NULL,
	[visit_detail_start_datetime] [datetime] NULL,
	[visit_detail_end_date] [date] NOT NULL,
	[visit_detail_end_datetime] [datetime] NULL,
	[visit_detail_type_concept_id] [int] NOT NULL,
	[provider_id] [int] NULL,
	[care_site_id] [int] NULL,
	[visit_detail_source_value] [varchar](50) NULL,
	[visit_detail_source_concept_id] [int] NULL,
	[admitted_from_concept_id] [int] NULL,
	[admitted_from_source_value] [varchar](50) NULL,
	[discharged_to_source_value] [varchar](50) NULL,
	[discharged_to_concept_id] [int] NULL,
	[preceding_visit_detail_id] [int] NULL,
	[parent_visit_detail_id] [int] NULL,
	[visit_occurrence_id] [int] NOT NULL,
 CONSTRAINT [xpk_visit_detail] PRIMARY KEY NONCLUSTERED 
(
	[visit_detail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[visit_occurrence]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[visit_occurrence](
	[visit_occurrence_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
	[visit_concept_id] [int] NOT NULL,
	[visit_start_date] [date] NOT NULL,
	[visit_start_datetime] [datetime] NULL,
	[visit_end_date] [date] NOT NULL,
	[visit_end_datetime] [datetime] NULL,
	[visit_type_concept_id] [int] NOT NULL,
	[provider_id] [int] NULL,
	[care_site_id] [int] NULL,
	[visit_source_value] [varchar](50) NULL,
	[visit_source_concept_id] [int] NULL,
	[admitted_from_concept_id] [int] NULL,
	[admitted_from_source_value] [varchar](50) NULL,
	[discharged_to_concept_id] [int] NULL,
	[discharged_to_source_value] [varchar](50) NULL,
	[preceding_visit_occurrence_id] [int] NULL,
 CONSTRAINT [xpk_visit_occurrence] PRIMARY KEY NONCLUSTERED 
(
	[visit_occurrence_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [cdm].[vocabulary]    Script Date: 29/01/2024 13:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [cdm].[vocabulary](
	[vocabulary_id] [varchar](20) NOT NULL,
	[vocabulary_name] [varchar](255) NOT NULL,
	[vocabulary_reference] [varchar](255) NULL,
	[vocabulary_version] [varchar](255) NULL,
	[vocabulary_concept_id] [int] NOT NULL,
 CONSTRAINT [xpk_vocabulary] PRIMARY KEY NONCLUSTERED 
(
	[vocabulary_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [cdm].[care_site]  WITH CHECK ADD  CONSTRAINT [FK_cdm_care_site_location_id] FOREIGN KEY([location_id])
REFERENCES [cdm].[location] ([location_id])
GO
ALTER TABLE [cdm].[care_site] CHECK CONSTRAINT [FK_cdm_care_site_location_id]
GO
ALTER TABLE [cdm].[care_site]  WITH CHECK ADD  CONSTRAINT [fpk_care_site_place_of_service_concept_id] FOREIGN KEY([place_of_service_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[care_site] CHECK CONSTRAINT [fpk_care_site_place_of_service_concept_id]
GO
ALTER TABLE [cdm].[cdm_source]  WITH CHECK ADD  CONSTRAINT [fpk_cdm_source_cdm_version_concept_id] FOREIGN KEY([cdm_version_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[cdm_source] CHECK CONSTRAINT [fpk_cdm_source_cdm_version_concept_id]
GO
ALTER TABLE [cdm].[cohort_definition]  WITH CHECK ADD  CONSTRAINT [fpk_cohort_definition_definition_type_concept_id] FOREIGN KEY([definition_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[cohort_definition] CHECK CONSTRAINT [fpk_cohort_definition_definition_type_concept_id]
GO
ALTER TABLE [cdm].[cohort_definition]  WITH CHECK ADD  CONSTRAINT [fpk_cohort_definition_subject_concept_id] FOREIGN KEY([subject_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[cohort_definition] CHECK CONSTRAINT [fpk_cohort_definition_subject_concept_id]
GO
ALTER TABLE [cdm].[concept]  WITH NOCHECK ADD  CONSTRAINT [fpk_concept_concept_class_id] FOREIGN KEY([concept_class_id])
REFERENCES [cdm].[concept_class] ([concept_class_id])
GO
ALTER TABLE [cdm].[concept] CHECK CONSTRAINT [fpk_concept_concept_class_id]
GO
ALTER TABLE [cdm].[concept]  WITH NOCHECK ADD  CONSTRAINT [fpk_concept_domain_id] FOREIGN KEY([domain_id])
REFERENCES [cdm].[domain] ([domain_id])
GO
ALTER TABLE [cdm].[concept] CHECK CONSTRAINT [fpk_concept_domain_id]
GO
ALTER TABLE [cdm].[concept]  WITH NOCHECK ADD  CONSTRAINT [fpk_concept_vocabulary_id] FOREIGN KEY([vocabulary_id])
REFERENCES [cdm].[vocabulary] ([vocabulary_id])
GO
ALTER TABLE [cdm].[concept] CHECK CONSTRAINT [fpk_concept_vocabulary_id]
GO
ALTER TABLE [cdm].[concept_ancestor]  WITH NOCHECK ADD  CONSTRAINT [fpk_concept_ancestor_ancestor_concept_id] FOREIGN KEY([ancestor_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[concept_ancestor] CHECK CONSTRAINT [fpk_concept_ancestor_ancestor_concept_id]
GO
ALTER TABLE [cdm].[concept_ancestor]  WITH NOCHECK ADD  CONSTRAINT [fpk_concept_ancestor_descendant_concept_id] FOREIGN KEY([descendant_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[concept_ancestor] CHECK CONSTRAINT [fpk_concept_ancestor_descendant_concept_id]
GO
ALTER TABLE [cdm].[concept_class]  WITH NOCHECK ADD  CONSTRAINT [fpk_concept_class_concept_class_concept_id] FOREIGN KEY([concept_class_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[concept_class] CHECK CONSTRAINT [fpk_concept_class_concept_class_concept_id]
GO
ALTER TABLE [cdm].[concept_relationship]  WITH NOCHECK ADD  CONSTRAINT [fpk_concept_relationship_concept_id_1] FOREIGN KEY([concept_id_1])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[concept_relationship] CHECK CONSTRAINT [fpk_concept_relationship_concept_id_1]
GO
ALTER TABLE [cdm].[concept_relationship]  WITH NOCHECK ADD  CONSTRAINT [fpk_concept_relationship_concept_id_2] FOREIGN KEY([concept_id_2])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[concept_relationship] CHECK CONSTRAINT [fpk_concept_relationship_concept_id_2]
GO
ALTER TABLE [cdm].[concept_relationship]  WITH NOCHECK ADD  CONSTRAINT [fpk_concept_relationship_relationship_id] FOREIGN KEY([relationship_id])
REFERENCES [cdm].[relationship] ([relationship_id])
GO
ALTER TABLE [cdm].[concept_relationship] CHECK CONSTRAINT [fpk_concept_relationship_relationship_id]
GO
ALTER TABLE [cdm].[concept_synonym]  WITH NOCHECK ADD  CONSTRAINT [fpk_concept_synonym_concept_id] FOREIGN KEY([concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[concept_synonym] CHECK CONSTRAINT [fpk_concept_synonym_concept_id]
GO
ALTER TABLE [cdm].[concept_synonym]  WITH NOCHECK ADD  CONSTRAINT [fpk_concept_synonym_language_concept_id] FOREIGN KEY([language_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[concept_synonym] CHECK CONSTRAINT [fpk_concept_synonym_language_concept_id]
GO
ALTER TABLE [cdm].[condition_era]  WITH CHECK ADD  CONSTRAINT [fpk_condition_era_condition_concept_id] FOREIGN KEY([condition_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[condition_era] CHECK CONSTRAINT [fpk_condition_era_condition_concept_id]
GO
ALTER TABLE [cdm].[condition_era]  WITH CHECK ADD  CONSTRAINT [fpk_condition_era_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[condition_era] CHECK CONSTRAINT [fpk_condition_era_person_id]
GO
ALTER TABLE [cdm].[condition_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_condition_occurrence_condition_concept_id] FOREIGN KEY([condition_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[condition_occurrence] CHECK CONSTRAINT [fpk_condition_occurrence_condition_concept_id]
GO
ALTER TABLE [cdm].[condition_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_condition_occurrence_condition_source_concept_id] FOREIGN KEY([condition_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[condition_occurrence] CHECK CONSTRAINT [fpk_condition_occurrence_condition_source_concept_id]
GO
ALTER TABLE [cdm].[condition_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_condition_occurrence_condition_status_concept_id] FOREIGN KEY([condition_status_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[condition_occurrence] CHECK CONSTRAINT [fpk_condition_occurrence_condition_status_concept_id]
GO
ALTER TABLE [cdm].[condition_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_condition_occurrence_condition_type_concept_id] FOREIGN KEY([condition_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[condition_occurrence] CHECK CONSTRAINT [fpk_condition_occurrence_condition_type_concept_id]
GO
ALTER TABLE [cdm].[condition_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_condition_occurrence_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[condition_occurrence] CHECK CONSTRAINT [fpk_condition_occurrence_person_id]
GO
ALTER TABLE [cdm].[condition_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_condition_occurrence_provider_id] FOREIGN KEY([provider_id])
REFERENCES [cdm].[provider] ([provider_id])
GO
ALTER TABLE [cdm].[condition_occurrence] CHECK CONSTRAINT [fpk_condition_occurrence_provider_id]
GO
ALTER TABLE [cdm].[condition_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_condition_occurrence_visit_detail_id] FOREIGN KEY([visit_detail_id])
REFERENCES [cdm].[visit_detail] ([visit_detail_id])
GO
ALTER TABLE [cdm].[condition_occurrence] CHECK CONSTRAINT [fpk_condition_occurrence_visit_detail_id]
GO
ALTER TABLE [cdm].[condition_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_condition_occurrence_visit_occurrence_id] FOREIGN KEY([visit_occurrence_id])
REFERENCES [cdm].[visit_occurrence] ([visit_occurrence_id])
GO
ALTER TABLE [cdm].[condition_occurrence] CHECK CONSTRAINT [fpk_condition_occurrence_visit_occurrence_id]
GO
ALTER TABLE [cdm].[cost]  WITH CHECK ADD  CONSTRAINT [fpk_cost_cost_domain_id] FOREIGN KEY([cost_domain_id])
REFERENCES [cdm].[domain] ([domain_id])
GO
ALTER TABLE [cdm].[cost] CHECK CONSTRAINT [fpk_cost_cost_domain_id]
GO
ALTER TABLE [cdm].[cost]  WITH CHECK ADD  CONSTRAINT [fpk_cost_cost_type_concept_id] FOREIGN KEY([cost_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[cost] CHECK CONSTRAINT [fpk_cost_cost_type_concept_id]
GO
ALTER TABLE [cdm].[cost]  WITH CHECK ADD  CONSTRAINT [fpk_cost_currency_concept_id] FOREIGN KEY([currency_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[cost] CHECK CONSTRAINT [fpk_cost_currency_concept_id]
GO
ALTER TABLE [cdm].[cost]  WITH CHECK ADD  CONSTRAINT [fpk_cost_drg_concept_id] FOREIGN KEY([drg_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[cost] CHECK CONSTRAINT [fpk_cost_drg_concept_id]
GO
ALTER TABLE [cdm].[cost]  WITH CHECK ADD  CONSTRAINT [fpk_cost_revenue_code_concept_id] FOREIGN KEY([revenue_code_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[cost] CHECK CONSTRAINT [fpk_cost_revenue_code_concept_id]
GO
ALTER TABLE [cdm].[death]  WITH CHECK ADD  CONSTRAINT [fpk_death_cause_concept_id] FOREIGN KEY([cause_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[death] CHECK CONSTRAINT [fpk_death_cause_concept_id]
GO
ALTER TABLE [cdm].[death]  WITH CHECK ADD  CONSTRAINT [fpk_death_cause_source_concept_id] FOREIGN KEY([cause_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[death] CHECK CONSTRAINT [fpk_death_cause_source_concept_id]
GO
ALTER TABLE [cdm].[death]  WITH CHECK ADD  CONSTRAINT [fpk_death_death_type_concept_id] FOREIGN KEY([death_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[death] CHECK CONSTRAINT [fpk_death_death_type_concept_id]
GO
ALTER TABLE [cdm].[death]  WITH CHECK ADD  CONSTRAINT [fpk_death_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[death] CHECK CONSTRAINT [fpk_death_person_id]
GO
ALTER TABLE [cdm].[device_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_device_exposure_device_concept_id] FOREIGN KEY([device_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[device_exposure] CHECK CONSTRAINT [fpk_device_exposure_device_concept_id]
GO
ALTER TABLE [cdm].[device_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_device_exposure_device_source_concept_id] FOREIGN KEY([device_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[device_exposure] CHECK CONSTRAINT [fpk_device_exposure_device_source_concept_id]
GO
ALTER TABLE [cdm].[device_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_device_exposure_device_type_concept_id] FOREIGN KEY([device_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[device_exposure] CHECK CONSTRAINT [fpk_device_exposure_device_type_concept_id]
GO
ALTER TABLE [cdm].[device_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_device_exposure_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[device_exposure] CHECK CONSTRAINT [fpk_device_exposure_person_id]
GO
ALTER TABLE [cdm].[device_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_device_exposure_provider_id] FOREIGN KEY([provider_id])
REFERENCES [cdm].[provider] ([provider_id])
GO
ALTER TABLE [cdm].[device_exposure] CHECK CONSTRAINT [fpk_device_exposure_provider_id]
GO
ALTER TABLE [cdm].[device_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_device_exposure_unit_concept_id] FOREIGN KEY([unit_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[device_exposure] CHECK CONSTRAINT [fpk_device_exposure_unit_concept_id]
GO
ALTER TABLE [cdm].[device_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_device_exposure_unit_source_concept_id] FOREIGN KEY([unit_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[device_exposure] CHECK CONSTRAINT [fpk_device_exposure_unit_source_concept_id]
GO
ALTER TABLE [cdm].[device_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_device_exposure_visit_detail_id] FOREIGN KEY([visit_detail_id])
REFERENCES [cdm].[visit_detail] ([visit_detail_id])
GO
ALTER TABLE [cdm].[device_exposure] CHECK CONSTRAINT [fpk_device_exposure_visit_detail_id]
GO
ALTER TABLE [cdm].[device_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_device_exposure_visit_occurrence_id] FOREIGN KEY([visit_occurrence_id])
REFERENCES [cdm].[visit_occurrence] ([visit_occurrence_id])
GO
ALTER TABLE [cdm].[device_exposure] CHECK CONSTRAINT [fpk_device_exposure_visit_occurrence_id]
GO
ALTER TABLE [cdm].[domain]  WITH NOCHECK ADD  CONSTRAINT [fpk_domain_domain_concept_id] FOREIGN KEY([domain_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[domain] CHECK CONSTRAINT [fpk_domain_domain_concept_id]
GO
ALTER TABLE [cdm].[dose_era]  WITH CHECK ADD  CONSTRAINT [fpk_dose_era_drug_concept_id] FOREIGN KEY([drug_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[dose_era] CHECK CONSTRAINT [fpk_dose_era_drug_concept_id]
GO
ALTER TABLE [cdm].[dose_era]  WITH CHECK ADD  CONSTRAINT [fpk_dose_era_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[dose_era] CHECK CONSTRAINT [fpk_dose_era_person_id]
GO
ALTER TABLE [cdm].[dose_era]  WITH CHECK ADD  CONSTRAINT [fpk_dose_era_unit_concept_id] FOREIGN KEY([unit_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[dose_era] CHECK CONSTRAINT [fpk_dose_era_unit_concept_id]
GO
ALTER TABLE [cdm].[drug_era]  WITH CHECK ADD  CONSTRAINT [fpk_drug_era_drug_concept_id] FOREIGN KEY([drug_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[drug_era] CHECK CONSTRAINT [fpk_drug_era_drug_concept_id]
GO
ALTER TABLE [cdm].[drug_era]  WITH CHECK ADD  CONSTRAINT [fpk_drug_era_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[drug_era] CHECK CONSTRAINT [fpk_drug_era_person_id]
GO
ALTER TABLE [cdm].[drug_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_drug_exposure_drug_concept_id] FOREIGN KEY([drug_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[drug_exposure] CHECK CONSTRAINT [fpk_drug_exposure_drug_concept_id]
GO
ALTER TABLE [cdm].[drug_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_drug_exposure_drug_source_concept_id] FOREIGN KEY([drug_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[drug_exposure] CHECK CONSTRAINT [fpk_drug_exposure_drug_source_concept_id]
GO
ALTER TABLE [cdm].[drug_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_drug_exposure_drug_type_concept_id] FOREIGN KEY([drug_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[drug_exposure] CHECK CONSTRAINT [fpk_drug_exposure_drug_type_concept_id]
GO
ALTER TABLE [cdm].[drug_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_drug_exposure_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[drug_exposure] CHECK CONSTRAINT [fpk_drug_exposure_person_id]
GO
ALTER TABLE [cdm].[drug_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_drug_exposure_provider_id] FOREIGN KEY([provider_id])
REFERENCES [cdm].[provider] ([provider_id])
GO
ALTER TABLE [cdm].[drug_exposure] CHECK CONSTRAINT [fpk_drug_exposure_provider_id]
GO
ALTER TABLE [cdm].[drug_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_drug_exposure_route_concept_id] FOREIGN KEY([route_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[drug_exposure] CHECK CONSTRAINT [fpk_drug_exposure_route_concept_id]
GO
ALTER TABLE [cdm].[drug_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_drug_exposure_visit_detail_id] FOREIGN KEY([visit_detail_id])
REFERENCES [cdm].[visit_detail] ([visit_detail_id])
GO
ALTER TABLE [cdm].[drug_exposure] CHECK CONSTRAINT [fpk_drug_exposure_visit_detail_id]
GO
ALTER TABLE [cdm].[drug_exposure]  WITH CHECK ADD  CONSTRAINT [fpk_drug_exposure_visit_occurrence_id] FOREIGN KEY([visit_occurrence_id])
REFERENCES [cdm].[visit_occurrence] ([visit_occurrence_id])
GO
ALTER TABLE [cdm].[drug_exposure] CHECK CONSTRAINT [fpk_drug_exposure_visit_occurrence_id]
GO
ALTER TABLE [cdm].[drug_strength]  WITH NOCHECK ADD  CONSTRAINT [fpk_drug_strength_amount_unit_concept_id] FOREIGN KEY([amount_unit_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[drug_strength] CHECK CONSTRAINT [fpk_drug_strength_amount_unit_concept_id]
GO
ALTER TABLE [cdm].[drug_strength]  WITH NOCHECK ADD  CONSTRAINT [fpk_drug_strength_denominator_unit_concept_id] FOREIGN KEY([denominator_unit_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[drug_strength] CHECK CONSTRAINT [fpk_drug_strength_denominator_unit_concept_id]
GO
ALTER TABLE [cdm].[drug_strength]  WITH NOCHECK ADD  CONSTRAINT [fpk_drug_strength_drug_concept_id] FOREIGN KEY([drug_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[drug_strength] CHECK CONSTRAINT [fpk_drug_strength_drug_concept_id]
GO
ALTER TABLE [cdm].[drug_strength]  WITH NOCHECK ADD  CONSTRAINT [fpk_drug_strength_ingredient_concept_id] FOREIGN KEY([ingredient_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[drug_strength] CHECK CONSTRAINT [fpk_drug_strength_ingredient_concept_id]
GO
ALTER TABLE [cdm].[drug_strength]  WITH NOCHECK ADD  CONSTRAINT [fpk_drug_strength_numerator_unit_concept_id] FOREIGN KEY([numerator_unit_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[drug_strength] CHECK CONSTRAINT [fpk_drug_strength_numerator_unit_concept_id]
GO
ALTER TABLE [cdm].[episode]  WITH CHECK ADD  CONSTRAINT [fpk_episode_episode_concept_id] FOREIGN KEY([episode_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[episode] CHECK CONSTRAINT [fpk_episode_episode_concept_id]
GO
ALTER TABLE [cdm].[episode]  WITH CHECK ADD  CONSTRAINT [fpk_episode_episode_object_concept_id] FOREIGN KEY([episode_object_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[episode] CHECK CONSTRAINT [fpk_episode_episode_object_concept_id]
GO
ALTER TABLE [cdm].[episode]  WITH CHECK ADD  CONSTRAINT [fpk_episode_episode_source_concept_id] FOREIGN KEY([episode_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[episode] CHECK CONSTRAINT [fpk_episode_episode_source_concept_id]
GO
ALTER TABLE [cdm].[episode]  WITH CHECK ADD  CONSTRAINT [fpk_episode_episode_type_concept_id] FOREIGN KEY([episode_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[episode] CHECK CONSTRAINT [fpk_episode_episode_type_concept_id]
GO
ALTER TABLE [cdm].[episode]  WITH CHECK ADD  CONSTRAINT [fpk_episode_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[episode] CHECK CONSTRAINT [fpk_episode_person_id]
GO
ALTER TABLE [cdm].[episode_event]  WITH CHECK ADD  CONSTRAINT [fpk_episode_event_episode_event_field_concept_id] FOREIGN KEY([episode_event_field_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[episode_event] CHECK CONSTRAINT [fpk_episode_event_episode_event_field_concept_id]
GO
ALTER TABLE [cdm].[episode_event]  WITH CHECK ADD  CONSTRAINT [fpk_episode_event_episode_id] FOREIGN KEY([episode_id])
REFERENCES [cdm].[episode] ([episode_id])
GO
ALTER TABLE [cdm].[episode_event] CHECK CONSTRAINT [fpk_episode_event_episode_id]
GO
ALTER TABLE [cdm].[fact_relationship]  WITH CHECK ADD  CONSTRAINT [fpk_fact_relationship_domain_concept_id_1] FOREIGN KEY([domain_concept_id_1])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[fact_relationship] CHECK CONSTRAINT [fpk_fact_relationship_domain_concept_id_1]
GO
ALTER TABLE [cdm].[fact_relationship]  WITH CHECK ADD  CONSTRAINT [fpk_fact_relationship_domain_concept_id_2] FOREIGN KEY([domain_concept_id_2])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[fact_relationship] CHECK CONSTRAINT [fpk_fact_relationship_domain_concept_id_2]
GO
ALTER TABLE [cdm].[fact_relationship]  WITH CHECK ADD  CONSTRAINT [fpk_fact_relationship_relationship_concept_id] FOREIGN KEY([relationship_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[fact_relationship] CHECK CONSTRAINT [fpk_fact_relationship_relationship_concept_id]
GO
ALTER TABLE [cdm].[location]  WITH CHECK ADD  CONSTRAINT [fpk_location_country_concept_id] FOREIGN KEY([country_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[location] CHECK CONSTRAINT [fpk_location_country_concept_id]
GO
ALTER TABLE [cdm].[measurement]  WITH CHECK ADD  CONSTRAINT [fpk_measurement_meas_event_field_concept_id] FOREIGN KEY([meas_event_field_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[measurement] CHECK CONSTRAINT [fpk_measurement_meas_event_field_concept_id]
GO
ALTER TABLE [cdm].[measurement]  WITH CHECK ADD  CONSTRAINT [fpk_measurement_measurement_concept_id] FOREIGN KEY([measurement_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[measurement] CHECK CONSTRAINT [fpk_measurement_measurement_concept_id]
GO
ALTER TABLE [cdm].[measurement]  WITH CHECK ADD  CONSTRAINT [fpk_measurement_measurement_source_concept_id] FOREIGN KEY([measurement_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[measurement] CHECK CONSTRAINT [fpk_measurement_measurement_source_concept_id]
GO
ALTER TABLE [cdm].[measurement]  WITH CHECK ADD  CONSTRAINT [fpk_measurement_measurement_type_concept_id] FOREIGN KEY([measurement_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[measurement] CHECK CONSTRAINT [fpk_measurement_measurement_type_concept_id]
GO
ALTER TABLE [cdm].[measurement]  WITH CHECK ADD  CONSTRAINT [fpk_measurement_operator_concept_id] FOREIGN KEY([operator_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[measurement] CHECK CONSTRAINT [fpk_measurement_operator_concept_id]
GO
ALTER TABLE [cdm].[measurement]  WITH CHECK ADD  CONSTRAINT [fpk_measurement_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[measurement] CHECK CONSTRAINT [fpk_measurement_person_id]
GO
ALTER TABLE [cdm].[measurement]  WITH CHECK ADD  CONSTRAINT [fpk_measurement_provider_id] FOREIGN KEY([provider_id])
REFERENCES [cdm].[provider] ([provider_id])
GO
ALTER TABLE [cdm].[measurement] CHECK CONSTRAINT [fpk_measurement_provider_id]
GO
ALTER TABLE [cdm].[measurement]  WITH CHECK ADD  CONSTRAINT [fpk_measurement_unit_concept_id] FOREIGN KEY([unit_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[measurement] CHECK CONSTRAINT [fpk_measurement_unit_concept_id]
GO
ALTER TABLE [cdm].[measurement]  WITH CHECK ADD  CONSTRAINT [fpk_measurement_unit_source_concept_id] FOREIGN KEY([unit_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[measurement] CHECK CONSTRAINT [fpk_measurement_unit_source_concept_id]
GO
ALTER TABLE [cdm].[measurement]  WITH CHECK ADD  CONSTRAINT [fpk_measurement_value_as_concept_id] FOREIGN KEY([value_as_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[measurement] CHECK CONSTRAINT [fpk_measurement_value_as_concept_id]
GO
ALTER TABLE [cdm].[measurement]  WITH CHECK ADD  CONSTRAINT [fpk_measurement_visit_detail_id] FOREIGN KEY([visit_detail_id])
REFERENCES [cdm].[visit_detail] ([visit_detail_id])
GO
ALTER TABLE [cdm].[measurement] CHECK CONSTRAINT [fpk_measurement_visit_detail_id]
GO
ALTER TABLE [cdm].[measurement]  WITH CHECK ADD  CONSTRAINT [fpk_measurement_visit_occurrence_id] FOREIGN KEY([visit_occurrence_id])
REFERENCES [cdm].[visit_occurrence] ([visit_occurrence_id])
GO
ALTER TABLE [cdm].[measurement] CHECK CONSTRAINT [fpk_measurement_visit_occurrence_id]
GO
ALTER TABLE [cdm].[metadata]  WITH CHECK ADD  CONSTRAINT [fpk_metadata_metadata_concept_id] FOREIGN KEY([metadata_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[metadata] CHECK CONSTRAINT [fpk_metadata_metadata_concept_id]
GO
ALTER TABLE [cdm].[metadata]  WITH CHECK ADD  CONSTRAINT [fpk_metadata_metadata_type_concept_id] FOREIGN KEY([metadata_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[metadata] CHECK CONSTRAINT [fpk_metadata_metadata_type_concept_id]
GO
ALTER TABLE [cdm].[metadata]  WITH CHECK ADD  CONSTRAINT [fpk_metadata_value_as_concept_id] FOREIGN KEY([value_as_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[metadata] CHECK CONSTRAINT [fpk_metadata_value_as_concept_id]
GO
ALTER TABLE [cdm].[note]  WITH CHECK ADD  CONSTRAINT [fpk_note_encoding_concept_id] FOREIGN KEY([encoding_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[note] CHECK CONSTRAINT [fpk_note_encoding_concept_id]
GO
ALTER TABLE [cdm].[note]  WITH CHECK ADD  CONSTRAINT [fpk_note_language_concept_id] FOREIGN KEY([language_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[note] CHECK CONSTRAINT [fpk_note_language_concept_id]
GO
ALTER TABLE [cdm].[note]  WITH CHECK ADD  CONSTRAINT [fpk_note_note_class_concept_id] FOREIGN KEY([note_class_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[note] CHECK CONSTRAINT [fpk_note_note_class_concept_id]
GO
ALTER TABLE [cdm].[note]  WITH CHECK ADD  CONSTRAINT [fpk_note_note_event_field_concept_id] FOREIGN KEY([note_event_field_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[note] CHECK CONSTRAINT [fpk_note_note_event_field_concept_id]
GO
ALTER TABLE [cdm].[note]  WITH CHECK ADD  CONSTRAINT [fpk_note_note_type_concept_id] FOREIGN KEY([note_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[note] CHECK CONSTRAINT [fpk_note_note_type_concept_id]
GO
ALTER TABLE [cdm].[note]  WITH CHECK ADD  CONSTRAINT [fpk_note_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[note] CHECK CONSTRAINT [fpk_note_person_id]
GO
ALTER TABLE [cdm].[note]  WITH CHECK ADD  CONSTRAINT [fpk_note_provider_id] FOREIGN KEY([provider_id])
REFERENCES [cdm].[provider] ([provider_id])
GO
ALTER TABLE [cdm].[note] CHECK CONSTRAINT [fpk_note_provider_id]
GO
ALTER TABLE [cdm].[note]  WITH CHECK ADD  CONSTRAINT [fpk_note_visit_detail_id] FOREIGN KEY([visit_detail_id])
REFERENCES [cdm].[visit_detail] ([visit_detail_id])
GO
ALTER TABLE [cdm].[note] CHECK CONSTRAINT [fpk_note_visit_detail_id]
GO
ALTER TABLE [cdm].[note]  WITH CHECK ADD  CONSTRAINT [fpk_note_visit_occurrence_id] FOREIGN KEY([visit_occurrence_id])
REFERENCES [cdm].[visit_occurrence] ([visit_occurrence_id])
GO
ALTER TABLE [cdm].[note] CHECK CONSTRAINT [fpk_note_visit_occurrence_id]
GO
ALTER TABLE [cdm].[note_nlp]  WITH CHECK ADD  CONSTRAINT [fpk_note_nlp_note_nlp_concept_id] FOREIGN KEY([note_nlp_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[note_nlp] CHECK CONSTRAINT [fpk_note_nlp_note_nlp_concept_id]
GO
ALTER TABLE [cdm].[note_nlp]  WITH CHECK ADD  CONSTRAINT [fpk_note_nlp_note_nlp_source_concept_id] FOREIGN KEY([note_nlp_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[note_nlp] CHECK CONSTRAINT [fpk_note_nlp_note_nlp_source_concept_id]
GO
ALTER TABLE [cdm].[note_nlp]  WITH CHECK ADD  CONSTRAINT [fpk_note_nlp_section_concept_id] FOREIGN KEY([section_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[note_nlp] CHECK CONSTRAINT [fpk_note_nlp_section_concept_id]
GO
ALTER TABLE [cdm].[observation]  WITH CHECK ADD  CONSTRAINT [fpk_observation_obs_event_field_concept_id] FOREIGN KEY([obs_event_field_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[observation] CHECK CONSTRAINT [fpk_observation_obs_event_field_concept_id]
GO
ALTER TABLE [cdm].[observation]  WITH CHECK ADD  CONSTRAINT [fpk_observation_observation_concept_id] FOREIGN KEY([observation_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[observation] CHECK CONSTRAINT [fpk_observation_observation_concept_id]
GO
ALTER TABLE [cdm].[observation]  WITH CHECK ADD  CONSTRAINT [fpk_observation_observation_source_concept_id] FOREIGN KEY([observation_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[observation] CHECK CONSTRAINT [fpk_observation_observation_source_concept_id]
GO
ALTER TABLE [cdm].[observation]  WITH CHECK ADD  CONSTRAINT [fpk_observation_observation_type_concept_id] FOREIGN KEY([observation_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[observation] CHECK CONSTRAINT [fpk_observation_observation_type_concept_id]
GO
ALTER TABLE [cdm].[observation]  WITH CHECK ADD  CONSTRAINT [fpk_observation_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[observation] CHECK CONSTRAINT [fpk_observation_person_id]
GO
ALTER TABLE [cdm].[observation]  WITH CHECK ADD  CONSTRAINT [fpk_observation_provider_id] FOREIGN KEY([provider_id])
REFERENCES [cdm].[provider] ([provider_id])
GO
ALTER TABLE [cdm].[observation] CHECK CONSTRAINT [fpk_observation_provider_id]
GO
ALTER TABLE [cdm].[observation]  WITH CHECK ADD  CONSTRAINT [fpk_observation_qualifier_concept_id] FOREIGN KEY([qualifier_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[observation] CHECK CONSTRAINT [fpk_observation_qualifier_concept_id]
GO
ALTER TABLE [cdm].[observation]  WITH CHECK ADD  CONSTRAINT [fpk_observation_unit_concept_id] FOREIGN KEY([unit_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[observation] CHECK CONSTRAINT [fpk_observation_unit_concept_id]
GO
ALTER TABLE [cdm].[observation]  WITH CHECK ADD  CONSTRAINT [fpk_observation_value_as_concept_id] FOREIGN KEY([value_as_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[observation] CHECK CONSTRAINT [fpk_observation_value_as_concept_id]
GO
ALTER TABLE [cdm].[observation]  WITH CHECK ADD  CONSTRAINT [fpk_observation_visit_detail_id] FOREIGN KEY([visit_detail_id])
REFERENCES [cdm].[visit_detail] ([visit_detail_id])
GO
ALTER TABLE [cdm].[observation] CHECK CONSTRAINT [fpk_observation_visit_detail_id]
GO
ALTER TABLE [cdm].[observation]  WITH CHECK ADD  CONSTRAINT [fpk_observation_visit_occurrence_id] FOREIGN KEY([visit_occurrence_id])
REFERENCES [cdm].[visit_occurrence] ([visit_occurrence_id])
GO
ALTER TABLE [cdm].[observation] CHECK CONSTRAINT [fpk_observation_visit_occurrence_id]
GO
ALTER TABLE [cdm].[observation_period]  WITH CHECK ADD  CONSTRAINT [fpk_observation_period_period_type_concept_id] FOREIGN KEY([period_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[observation_period] CHECK CONSTRAINT [fpk_observation_period_period_type_concept_id]
GO
ALTER TABLE [cdm].[observation_period]  WITH CHECK ADD  CONSTRAINT [fpk_observation_period_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[observation_period] CHECK CONSTRAINT [fpk_observation_period_person_id]
GO
ALTER TABLE [cdm].[payer_plan_period]  WITH CHECK ADD  CONSTRAINT [fpk_payer_plan_period_payer_concept_id] FOREIGN KEY([payer_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[payer_plan_period] CHECK CONSTRAINT [fpk_payer_plan_period_payer_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period]  WITH CHECK ADD  CONSTRAINT [fpk_payer_plan_period_payer_source_concept_id] FOREIGN KEY([payer_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[payer_plan_period] CHECK CONSTRAINT [fpk_payer_plan_period_payer_source_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period]  WITH CHECK ADD  CONSTRAINT [fpk_payer_plan_period_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[payer_plan_period] CHECK CONSTRAINT [fpk_payer_plan_period_person_id]
GO
ALTER TABLE [cdm].[payer_plan_period]  WITH CHECK ADD  CONSTRAINT [fpk_payer_plan_period_plan_concept_id] FOREIGN KEY([plan_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[payer_plan_period] CHECK CONSTRAINT [fpk_payer_plan_period_plan_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period]  WITH CHECK ADD  CONSTRAINT [fpk_payer_plan_period_plan_source_concept_id] FOREIGN KEY([plan_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[payer_plan_period] CHECK CONSTRAINT [fpk_payer_plan_period_plan_source_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period]  WITH CHECK ADD  CONSTRAINT [fpk_payer_plan_period_sponsor_concept_id] FOREIGN KEY([sponsor_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[payer_plan_period] CHECK CONSTRAINT [fpk_payer_plan_period_sponsor_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period]  WITH CHECK ADD  CONSTRAINT [fpk_payer_plan_period_sponsor_source_concept_id] FOREIGN KEY([sponsor_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[payer_plan_period] CHECK CONSTRAINT [fpk_payer_plan_period_sponsor_source_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period]  WITH CHECK ADD  CONSTRAINT [fpk_payer_plan_period_stop_reason_concept_id] FOREIGN KEY([stop_reason_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[payer_plan_period] CHECK CONSTRAINT [fpk_payer_plan_period_stop_reason_concept_id]
GO
ALTER TABLE [cdm].[payer_plan_period]  WITH CHECK ADD  CONSTRAINT [fpk_payer_plan_period_stop_reason_source_concept_id] FOREIGN KEY([stop_reason_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[payer_plan_period] CHECK CONSTRAINT [fpk_payer_plan_period_stop_reason_source_concept_id]
GO
ALTER TABLE [cdm].[person]  WITH CHECK ADD  CONSTRAINT [FK_cdm_person_location_id] FOREIGN KEY([location_id])
REFERENCES [cdm].[location] ([location_id])
GO
ALTER TABLE [cdm].[person] CHECK CONSTRAINT [FK_cdm_person_location_id]
GO
ALTER TABLE [cdm].[person]  WITH CHECK ADD  CONSTRAINT [fpk_person_care_site_id] FOREIGN KEY([care_site_id])
REFERENCES [cdm].[care_site] ([care_site_id])
GO
ALTER TABLE [cdm].[person] CHECK CONSTRAINT [fpk_person_care_site_id]
GO
ALTER TABLE [cdm].[person]  WITH CHECK ADD  CONSTRAINT [fpk_person_ethnicity_concept_id] FOREIGN KEY([ethnicity_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[person] CHECK CONSTRAINT [fpk_person_ethnicity_concept_id]
GO
ALTER TABLE [cdm].[person]  WITH CHECK ADD  CONSTRAINT [fpk_person_ethnicity_source_concept_id] FOREIGN KEY([ethnicity_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[person] CHECK CONSTRAINT [fpk_person_ethnicity_source_concept_id]
GO
ALTER TABLE [cdm].[person]  WITH CHECK ADD  CONSTRAINT [fpk_person_gender_concept_id] FOREIGN KEY([gender_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[person] CHECK CONSTRAINT [fpk_person_gender_concept_id]
GO
ALTER TABLE [cdm].[person]  WITH CHECK ADD  CONSTRAINT [fpk_person_gender_source_concept_id] FOREIGN KEY([gender_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[person] CHECK CONSTRAINT [fpk_person_gender_source_concept_id]
GO
ALTER TABLE [cdm].[person]  WITH CHECK ADD  CONSTRAINT [fpk_person_provider_id] FOREIGN KEY([provider_id])
REFERENCES [cdm].[provider] ([provider_id])
GO
ALTER TABLE [cdm].[person] CHECK CONSTRAINT [fpk_person_provider_id]
GO
ALTER TABLE [cdm].[person]  WITH CHECK ADD  CONSTRAINT [fpk_person_race_concept_id] FOREIGN KEY([race_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[person] CHECK CONSTRAINT [fpk_person_race_concept_id]
GO
ALTER TABLE [cdm].[person]  WITH CHECK ADD  CONSTRAINT [fpk_person_race_source_concept_id] FOREIGN KEY([race_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[person] CHECK CONSTRAINT [fpk_person_race_source_concept_id]
GO
ALTER TABLE [cdm].[procedure_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_procedure_occurrence_modifier_concept_id] FOREIGN KEY([modifier_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[procedure_occurrence] CHECK CONSTRAINT [fpk_procedure_occurrence_modifier_concept_id]
GO
ALTER TABLE [cdm].[procedure_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_procedure_occurrence_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[procedure_occurrence] CHECK CONSTRAINT [fpk_procedure_occurrence_person_id]
GO
ALTER TABLE [cdm].[procedure_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_procedure_occurrence_procedure_concept_id] FOREIGN KEY([procedure_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[procedure_occurrence] CHECK CONSTRAINT [fpk_procedure_occurrence_procedure_concept_id]
GO
ALTER TABLE [cdm].[procedure_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_procedure_occurrence_procedure_source_concept_id] FOREIGN KEY([procedure_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[procedure_occurrence] CHECK CONSTRAINT [fpk_procedure_occurrence_procedure_source_concept_id]
GO
ALTER TABLE [cdm].[procedure_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_procedure_occurrence_procedure_type_concept_id] FOREIGN KEY([procedure_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[procedure_occurrence] CHECK CONSTRAINT [fpk_procedure_occurrence_procedure_type_concept_id]
GO
ALTER TABLE [cdm].[procedure_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_procedure_occurrence_provider_id] FOREIGN KEY([provider_id])
REFERENCES [cdm].[provider] ([provider_id])
GO
ALTER TABLE [cdm].[procedure_occurrence] CHECK CONSTRAINT [fpk_procedure_occurrence_provider_id]
GO
ALTER TABLE [cdm].[procedure_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_procedure_occurrence_visit_detail_id] FOREIGN KEY([visit_detail_id])
REFERENCES [cdm].[visit_detail] ([visit_detail_id])
GO
ALTER TABLE [cdm].[procedure_occurrence] CHECK CONSTRAINT [fpk_procedure_occurrence_visit_detail_id]
GO
ALTER TABLE [cdm].[procedure_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_procedure_occurrence_visit_occurrence_id] FOREIGN KEY([visit_occurrence_id])
REFERENCES [cdm].[visit_occurrence] ([visit_occurrence_id])
GO
ALTER TABLE [cdm].[procedure_occurrence] CHECK CONSTRAINT [fpk_procedure_occurrence_visit_occurrence_id]
GO
ALTER TABLE [cdm].[provider]  WITH CHECK ADD  CONSTRAINT [fpk_provider_care_site_id] FOREIGN KEY([care_site_id])
REFERENCES [cdm].[care_site] ([care_site_id])
GO
ALTER TABLE [cdm].[provider] CHECK CONSTRAINT [fpk_provider_care_site_id]
GO
ALTER TABLE [cdm].[provider]  WITH CHECK ADD  CONSTRAINT [fpk_provider_gender_concept_id] FOREIGN KEY([gender_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[provider] CHECK CONSTRAINT [fpk_provider_gender_concept_id]
GO
ALTER TABLE [cdm].[provider]  WITH CHECK ADD  CONSTRAINT [fpk_provider_gender_source_concept_id] FOREIGN KEY([gender_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[provider] CHECK CONSTRAINT [fpk_provider_gender_source_concept_id]
GO
ALTER TABLE [cdm].[provider]  WITH CHECK ADD  CONSTRAINT [fpk_provider_specialty_concept_id] FOREIGN KEY([specialty_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[provider] CHECK CONSTRAINT [fpk_provider_specialty_concept_id]
GO
ALTER TABLE [cdm].[provider]  WITH CHECK ADD  CONSTRAINT [fpk_provider_specialty_source_concept_id] FOREIGN KEY([specialty_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[provider] CHECK CONSTRAINT [fpk_provider_specialty_source_concept_id]
GO
ALTER TABLE [cdm].[relationship]  WITH NOCHECK ADD  CONSTRAINT [fpk_relationship_relationship_concept_id] FOREIGN KEY([relationship_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[relationship] CHECK CONSTRAINT [fpk_relationship_relationship_concept_id]
GO
ALTER TABLE [cdm].[source_to_concept_map]  WITH CHECK ADD  CONSTRAINT [fpk_source_to_concept_map_source_concept_id] FOREIGN KEY([source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[source_to_concept_map] CHECK CONSTRAINT [fpk_source_to_concept_map_source_concept_id]
GO
ALTER TABLE [cdm].[source_to_concept_map]  WITH CHECK ADD  CONSTRAINT [fpk_source_to_concept_map_target_concept_id] FOREIGN KEY([target_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[source_to_concept_map] CHECK CONSTRAINT [fpk_source_to_concept_map_target_concept_id]
GO
ALTER TABLE [cdm].[source_to_concept_map]  WITH CHECK ADD  CONSTRAINT [fpk_source_to_concept_map_target_vocabulary_id] FOREIGN KEY([target_vocabulary_id])
REFERENCES [cdm].[vocabulary] ([vocabulary_id])
GO
ALTER TABLE [cdm].[source_to_concept_map] CHECK CONSTRAINT [fpk_source_to_concept_map_target_vocabulary_id]
GO
ALTER TABLE [cdm].[specimen]  WITH CHECK ADD  CONSTRAINT [fpk_specimen_anatomic_site_concept_id] FOREIGN KEY([anatomic_site_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[specimen] CHECK CONSTRAINT [fpk_specimen_anatomic_site_concept_id]
GO
ALTER TABLE [cdm].[specimen]  WITH CHECK ADD  CONSTRAINT [fpk_specimen_disease_status_concept_id] FOREIGN KEY([disease_status_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[specimen] CHECK CONSTRAINT [fpk_specimen_disease_status_concept_id]
GO
ALTER TABLE [cdm].[specimen]  WITH CHECK ADD  CONSTRAINT [fpk_specimen_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[specimen] CHECK CONSTRAINT [fpk_specimen_person_id]
GO
ALTER TABLE [cdm].[specimen]  WITH CHECK ADD  CONSTRAINT [fpk_specimen_specimen_concept_id] FOREIGN KEY([specimen_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[specimen] CHECK CONSTRAINT [fpk_specimen_specimen_concept_id]
GO
ALTER TABLE [cdm].[specimen]  WITH CHECK ADD  CONSTRAINT [fpk_specimen_specimen_type_concept_id] FOREIGN KEY([specimen_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[specimen] CHECK CONSTRAINT [fpk_specimen_specimen_type_concept_id]
GO
ALTER TABLE [cdm].[specimen]  WITH CHECK ADD  CONSTRAINT [fpk_specimen_unit_concept_id] FOREIGN KEY([unit_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[specimen] CHECK CONSTRAINT [fpk_specimen_unit_concept_id]
GO
ALTER TABLE [cdm].[visit_detail]  WITH CHECK ADD  CONSTRAINT [fpk_visit_detail_admitted_from_concept_id] FOREIGN KEY([admitted_from_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[visit_detail] CHECK CONSTRAINT [fpk_visit_detail_admitted_from_concept_id]
GO
ALTER TABLE [cdm].[visit_detail]  WITH CHECK ADD  CONSTRAINT [fpk_visit_detail_care_site_id] FOREIGN KEY([care_site_id])
REFERENCES [cdm].[care_site] ([care_site_id])
GO
ALTER TABLE [cdm].[visit_detail] CHECK CONSTRAINT [fpk_visit_detail_care_site_id]
GO
ALTER TABLE [cdm].[visit_detail]  WITH CHECK ADD  CONSTRAINT [fpk_visit_detail_discharged_to_concept_id] FOREIGN KEY([discharged_to_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[visit_detail] CHECK CONSTRAINT [fpk_visit_detail_discharged_to_concept_id]
GO
ALTER TABLE [cdm].[visit_detail]  WITH CHECK ADD  CONSTRAINT [fpk_visit_detail_parent_visit_detail_id] FOREIGN KEY([parent_visit_detail_id])
REFERENCES [cdm].[visit_detail] ([visit_detail_id])
GO
ALTER TABLE [cdm].[visit_detail] CHECK CONSTRAINT [fpk_visit_detail_parent_visit_detail_id]
GO
ALTER TABLE [cdm].[visit_detail]  WITH CHECK ADD  CONSTRAINT [fpk_visit_detail_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[visit_detail] CHECK CONSTRAINT [fpk_visit_detail_person_id]
GO
ALTER TABLE [cdm].[visit_detail]  WITH CHECK ADD  CONSTRAINT [fpk_visit_detail_preceding_visit_detail_id] FOREIGN KEY([preceding_visit_detail_id])
REFERENCES [cdm].[visit_detail] ([visit_detail_id])
GO
ALTER TABLE [cdm].[visit_detail] CHECK CONSTRAINT [fpk_visit_detail_preceding_visit_detail_id]
GO
ALTER TABLE [cdm].[visit_detail]  WITH CHECK ADD  CONSTRAINT [fpk_visit_detail_provider_id] FOREIGN KEY([provider_id])
REFERENCES [cdm].[provider] ([provider_id])
GO
ALTER TABLE [cdm].[visit_detail] CHECK CONSTRAINT [fpk_visit_detail_provider_id]
GO
ALTER TABLE [cdm].[visit_detail]  WITH CHECK ADD  CONSTRAINT [fpk_visit_detail_visit_detail_concept_id] FOREIGN KEY([visit_detail_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[visit_detail] CHECK CONSTRAINT [fpk_visit_detail_visit_detail_concept_id]
GO
ALTER TABLE [cdm].[visit_detail]  WITH CHECK ADD  CONSTRAINT [fpk_visit_detail_visit_detail_source_concept_id] FOREIGN KEY([visit_detail_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[visit_detail] CHECK CONSTRAINT [fpk_visit_detail_visit_detail_source_concept_id]
GO
ALTER TABLE [cdm].[visit_detail]  WITH CHECK ADD  CONSTRAINT [fpk_visit_detail_visit_detail_type_concept_id] FOREIGN KEY([visit_detail_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[visit_detail] CHECK CONSTRAINT [fpk_visit_detail_visit_detail_type_concept_id]
GO
ALTER TABLE [cdm].[visit_detail]  WITH CHECK ADD  CONSTRAINT [fpk_visit_detail_visit_occurrence_id] FOREIGN KEY([visit_occurrence_id])
REFERENCES [cdm].[visit_occurrence] ([visit_occurrence_id])
GO
ALTER TABLE [cdm].[visit_detail] CHECK CONSTRAINT [fpk_visit_detail_visit_occurrence_id]
GO
ALTER TABLE [cdm].[visit_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_visit_occurrence_admitted_from_concept_id] FOREIGN KEY([admitted_from_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[visit_occurrence] CHECK CONSTRAINT [fpk_visit_occurrence_admitted_from_concept_id]
GO
ALTER TABLE [cdm].[visit_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_visit_occurrence_care_site_id] FOREIGN KEY([care_site_id])
REFERENCES [cdm].[care_site] ([care_site_id])
GO
ALTER TABLE [cdm].[visit_occurrence] CHECK CONSTRAINT [fpk_visit_occurrence_care_site_id]
GO
ALTER TABLE [cdm].[visit_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_visit_occurrence_discharged_to_concept_id] FOREIGN KEY([discharged_to_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[visit_occurrence] CHECK CONSTRAINT [fpk_visit_occurrence_discharged_to_concept_id]
GO
ALTER TABLE [cdm].[visit_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_visit_occurrence_person_id] FOREIGN KEY([person_id])
REFERENCES [cdm].[person] ([person_id])
GO
ALTER TABLE [cdm].[visit_occurrence] CHECK CONSTRAINT [fpk_visit_occurrence_person_id]
GO
ALTER TABLE [cdm].[visit_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_visit_occurrence_preceding_visit_occurrence_id] FOREIGN KEY([preceding_visit_occurrence_id])
REFERENCES [cdm].[visit_occurrence] ([visit_occurrence_id])
GO
ALTER TABLE [cdm].[visit_occurrence] CHECK CONSTRAINT [fpk_visit_occurrence_preceding_visit_occurrence_id]
GO
ALTER TABLE [cdm].[visit_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_visit_occurrence_provider_id] FOREIGN KEY([provider_id])
REFERENCES [cdm].[provider] ([provider_id])
GO
ALTER TABLE [cdm].[visit_occurrence] CHECK CONSTRAINT [fpk_visit_occurrence_provider_id]
GO
ALTER TABLE [cdm].[visit_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_visit_occurrence_visit_concept_id] FOREIGN KEY([visit_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[visit_occurrence] CHECK CONSTRAINT [fpk_visit_occurrence_visit_concept_id]
GO
ALTER TABLE [cdm].[visit_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_visit_occurrence_visit_source_concept_id] FOREIGN KEY([visit_source_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[visit_occurrence] CHECK CONSTRAINT [fpk_visit_occurrence_visit_source_concept_id]
GO
ALTER TABLE [cdm].[visit_occurrence]  WITH CHECK ADD  CONSTRAINT [fpk_visit_occurrence_visit_type_concept_id] FOREIGN KEY([visit_type_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[visit_occurrence] CHECK CONSTRAINT [fpk_visit_occurrence_visit_type_concept_id]
GO
ALTER TABLE [cdm].[vocabulary]  WITH NOCHECK ADD  CONSTRAINT [fpk_vocabulary_vocabulary_concept_id] FOREIGN KEY([vocabulary_concept_id])
REFERENCES [cdm].[concept] ([concept_id])
GO
ALTER TABLE [cdm].[vocabulary] CHECK CONSTRAINT [fpk_vocabulary_vocabulary_concept_id]
GO