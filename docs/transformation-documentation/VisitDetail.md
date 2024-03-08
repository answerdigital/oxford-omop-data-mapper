---
layout: default
title: VisitDetail
has_children: true
parent: Transformation Documentation
has_toc: false
---

# VisitDetail
* [nhs_number]({% link docs/transformation-documentation/VisitDetail_nhs_number.md %})
* [RecordConnectionIdentifier]({% link docs/transformation-documentation/VisitDetail_RecordConnectionIdentifier.md %})
* [HospitalProviderSpellNumber]({% link docs/transformation-documentation/VisitDetail_HospitalProviderSpellNumber.md %})
* [visit_detail_start_date]({% link docs/transformation-documentation/VisitDetail_visit_detail_start_date.md %})
* [visit_detail_start_datetime]({% link docs/transformation-documentation/VisitDetail_visit_detail_start_datetime.md %})
* [visit_detail_end_date]({% link docs/transformation-documentation/VisitDetail_visit_detail_end_date.md %})
* [visit_detail_end_datetime]({% link docs/transformation-documentation/VisitDetail_visit_detail_end_datetime.md %})
* [visit_detail_concept_id]({% link docs/transformation-documentation/VisitDetail_visit_detail_concept_id.md %})
* [visit_detail_type_concept_id]({% link docs/transformation-documentation/VisitDetail_visit_detail_type_concept_id.md %})
* [admitted_from_concept_id]({% link docs/transformation-documentation/VisitDetail_admitted_from_concept_id.md %})
* [admitted_from_source_value]({% link docs/transformation-documentation/VisitDetail_admitted_from_source_value.md %})
* [discharged_to_concept_id]({% link docs/transformation-documentation/VisitDetail_discharged_to_concept_id.md %})
* [discharged_to_source_value]({% link docs/transformation-documentation/VisitDetail_discharged_to_source_value.md %})

## CdsVisitDetail
```mermaid
%%{
  init: {
    'theme': 'base',
   'themeVariables': {
         'lineColor': '#Fff',
         'fontSize': '27px'
    }
  }
}%%

block-beta
  columns 1
  block:container:1
    columns 1
    block:nhs_number_container:1
        columns 4
        block:nhs_number:1
        columns 1
            nhs_number_0["NHS NUMBER<br/> <br/> <br/> "]
            class nhs_number_0 sourceItem
        end
        
        space
        
        nhs_number-->nhs_number_target_0["nhs_number"]

        nhs_number_label(["Copy value"])
    end
   class nhs_number_container container1
   class nhs_number container1
   class nhs_number_target_0 targetItem
   class nhs_number_label targetItem
    columns 1
    block:recordconnectionidentifier_container:1
        columns 4
        block:recordconnectionidentifier:1
        columns 1
            cds_record_identifier_1["CDS RECORD IDENTIFIER<br/> <br/> <br/> "]
            class cds_record_identifier_1 sourceItem
        end
        
        space
        
        recordconnectionidentifier-->recordconnectionidentifier_target_1["RecordConnectionIdentifier"]

        recordconnectionidentifier_label(["Copy value"])
    end
   class recordconnectionidentifier_container container1
   class recordconnectionidentifier container1
   class recordconnectionidentifier_target_1 targetItem
   class recordconnectionidentifier_label targetItem
    columns 1
    block:hospitalproviderspellnumber_container:1
        columns 4
        block:hospitalproviderspellnumber:1
        columns 1
            hospital_provider_spell_number_2["HOSPITAL PROVIDER SPELL<br/> NUMBER<br/> <br/> "]
            class hospital_provider_spell_number_2 sourceItem
        end
        
        space
        
        hospitalproviderspellnumber-->hospitalproviderspellnumber_target_2["HospitalProviderSpellNumber"]

        hospitalproviderspellnumber_label(["Copy value"])
    end
   class hospitalproviderspellnumber_container container1
   class hospitalproviderspellnumber container1
   class hospitalproviderspellnumber_target_2 targetItem
   class hospitalproviderspellnumber_label targetItem
    columns 1
    block:visit_detail_start_date_container:1
        columns 4
        block:visit_detail_start_date:1
        columns 1
            cds_activity_date_3["CDS ACTIVITY DATE<br/> <br/> <br/> "]
            class cds_activity_date_3 sourceItem
            start_date_hospital_provider_spell_3["START DATE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class start_date_hospital_provider_spell_3 sourceItem
            start_date_episode_3["START DATE (EPISODE)<br/> <br/> <br/> "]
            class start_date_episode_3 sourceItem
        end
        
        space
        
        visit_detail_start_date-->visit_detail_start_date_target_3["visit_detail_start_date"]

        visit_detail_start_date_label(["Converts text to<br/> dates."])
    end
   class visit_detail_start_date_container container1
   class visit_detail_start_date container1
   class visit_detail_start_date_target_3 targetItem
   class visit_detail_start_date_label targetItem
    columns 1
    block:visit_detail_start_datetime_container:1
        columns 4
        block:visit_detail_start_datetime:1
        columns 1
            cds_activity_date_4["CDS ACTIVITY DATE<br/> <br/> <br/> "]
            class cds_activity_date_4 sourceItem
            start_date_hospital_provider_spell_4["START DATE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class start_date_hospital_provider_spell_4 sourceItem
            start_date_episode_4["START DATE (EPISODE)<br/> <br/> <br/> "]
            class start_date_episode_4 sourceItem
            start_time_hospital_provider_spell_4["START TIME (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class start_time_hospital_provider_spell_4 sourceItem
            start_time_episode_4["START TIME (EPISODE)<br/> <br/> <br/> "]
            class start_time_episode_4 sourceItem
        end
        
        space
        
        visit_detail_start_datetime-->visit_detail_start_datetime_target_4["visit_detail_start_datetime"]

        visit_detail_start_datetime_label(["Combines a date<br/> with a time<br/> of day."])
    end
   class visit_detail_start_datetime_container container1
   class visit_detail_start_datetime container1
   class visit_detail_start_datetime_target_4 targetItem
   class visit_detail_start_datetime_label targetItem
    columns 1
    block:visit_detail_end_date_container:1
        columns 4
        block:visit_detail_end_date:1
        columns 1
            cds_activity_date_5["CDS ACTIVITY DATE<br/> <br/> <br/> "]
            class cds_activity_date_5 sourceItem
            end_date_episode_5["END DATE (EPISODE)<br/> <br/> <br/> "]
            class end_date_episode_5 sourceItem
            discharge_date_hospital_provider_spell_5["DISCHARGE DATE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class discharge_date_hospital_provider_spell_5 sourceItem
        end
        
        space
        
        visit_detail_end_date-->visit_detail_end_date_target_5["visit_detail_end_date"]

        visit_detail_end_date_label(["Converts text to<br/> dates."])
    end
   class visit_detail_end_date_container container1
   class visit_detail_end_date container1
   class visit_detail_end_date_target_5 targetItem
   class visit_detail_end_date_label targetItem
    columns 1
    block:visit_detail_end_datetime_container:1
        columns 4
        block:visit_detail_end_datetime:1
        columns 1
            cds_activity_date_6["CDS ACTIVITY DATE<br/> <br/> <br/> "]
            class cds_activity_date_6 sourceItem
            end_date_episode_6["END DATE (EPISODE)<br/> <br/> <br/> "]
            class end_date_episode_6 sourceItem
            discharge_date_hospital_provider_spell_6["DISCHARGE DATE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class discharge_date_hospital_provider_spell_6 sourceItem
            discharge_time_hospital_provider_spell_6["DISCHARGE TIME (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class discharge_time_hospital_provider_spell_6 sourceItem
            end_time_episode_6["END TIME (EPISODE)<br/> <br/> <br/> "]
            class end_time_episode_6 sourceItem
        end
        
        space
        
        visit_detail_end_datetime-->visit_detail_end_datetime_target_6["visit_detail_end_datetime"]

        visit_detail_end_datetime_label(["Combines a date<br/> with a time<br/> of day."])
    end
   class visit_detail_end_datetime_container container1
   class visit_detail_end_datetime container1
   class visit_detail_end_datetime_target_6 targetItem
   class visit_detail_end_datetime_label targetItem
    columns 1
    block:visit_detail_concept_id_container:1
        columns 4
        block:visit_detail_concept_id:1
        columns 1
            admission_method_code_hospital_provider_spell_7["ADMISSION METHOD CODE<br/> (HOSPITAL PROVIDER SPELL)<br/> <br/> "]
            class admission_method_code_hospital_provider_spell_7 sourceItem
            patient_classification_code_7["PATIENT CLASSIFICATION CODE<br/> <br/> <br/> "]
            class patient_classification_code_7 sourceItem
            location_class_7["LOCATION CLASS<br/> <br/> <br/> "]
            class location_class_7 sourceItem
        end
        
        space
        
        visit_detail_concept_id-->visit_detail_concept_id_target_7["visit_detail_concept_id"]

        visit_detail_concept_id_label(["Copy value"])
    end
   class visit_detail_concept_id_container container1
   class visit_detail_concept_id container1
   class visit_detail_concept_id_target_7 targetItem
   class visit_detail_concept_id_label targetItem
    columns 1
    block:visit_detail_type_concept_id_container:1
        columns 4
        block:visit_detail_type_concept_id:1
        columns 1
            end_date_episode_8["END DATE (EPISODE)<br/> <br/> <br/> "]
            class end_date_episode_8 sourceItem
            discharge_date_hospital_provider_spell_8["DISCHARGE DATE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class discharge_date_hospital_provider_spell_8 sourceItem
            patient_classification_code_8["PATIENT CLASSIFICATION CODE<br/> <br/> <br/> "]
            class patient_classification_code_8 sourceItem
        end
        
        space
        
        visit_detail_type_concept_id-->visit_detail_type_concept_id_target_8["visit_detail_type_concept_id"]

        visit_detail_type_concept_id_label(["Copy value"])
    end
   class visit_detail_type_concept_id_container container1
   class visit_detail_type_concept_id container1
   class visit_detail_type_concept_id_target_8 targetItem
   class visit_detail_type_concept_id_label targetItem
    columns 1
    block:admitted_from_concept_id_container:1
        columns 4
        block:admitted_from_concept_id:1
        columns 1
            admission_source_hospital_provider_spell_9["ADMISSION SOURCE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class admission_source_hospital_provider_spell_9 sourceItem
        end
        
        space
        
        admitted_from_concept_id-->admitted_from_concept_id_target_9["admitted_from_concept_id"]

        admitted_from_concept_id_label(["Lookup admission source<br/> concept."])
    end
   class admitted_from_concept_id_container container1
   class admitted_from_concept_id container1
   class admitted_from_concept_id_target_9 targetItem
   class admitted_from_concept_id_label targetItem
    columns 1
    block:admitted_from_source_value_container:1
        columns 4
        block:admitted_from_source_value:1
        columns 1
            admission_source_hospital_provider_spell_10["ADMISSION SOURCE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class admission_source_hospital_provider_spell_10 sourceItem
        end
        
        space
        
        admitted_from_source_value-->admitted_from_source_value_target_10["admitted_from_source_value"]

        admitted_from_source_value_label(["Copy value"])
    end
   class admitted_from_source_value_container container1
   class admitted_from_source_value container1
   class admitted_from_source_value_target_10 targetItem
   class admitted_from_source_value_label targetItem
    columns 1
    block:discharged_to_concept_id_container:1
        columns 4
        block:discharged_to_concept_id:1
        columns 1
            discharge_destination_code_hospital_provider_spell_11["DISCHARGE DESTINATION CODE<br/> (HOSPITAL PROVIDER SPELL)<br/> <br/> "]
            class discharge_destination_code_hospital_provider_spell_11 sourceItem
        end
        
        space
        
        discharged_to_concept_id-->discharged_to_concept_id_target_11["discharged_to_concept_id"]

        discharged_to_concept_id_label(["Lookup discharge destination<br/> concept."])
    end
   class discharged_to_concept_id_container container1
   class discharged_to_concept_id container1
   class discharged_to_concept_id_target_11 targetItem
   class discharged_to_concept_id_label targetItem
    columns 1
    block:discharged_to_source_value_container:1
        columns 4
        block:discharged_to_source_value:1
        columns 1
            discharge_destination_code_hospital_provider_spell_12["DISCHARGE DESTINATION CODE<br/> (HOSPITAL PROVIDER SPELL)<br/> <br/> "]
            class discharge_destination_code_hospital_provider_spell_12 sourceItem
        end
        
        space
        
        discharged_to_source_value-->discharged_to_source_value_target_12["discharged_to_source_value"]

        discharged_to_source_value_label(["Copy value"])
    end
   class discharged_to_source_value_container container1
   class discharged_to_source_value container1
   class discharged_to_source_value_target_12 targetItem
   class discharged_to_source_value_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CdsVisitDetail%20mapping){: .btn }
