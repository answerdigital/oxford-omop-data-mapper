---
layout: default
title: VisitOccurrence
has_children: true
parent: Transformation Documentation
has_toc: false
---

# VisitOccurrence
* [NhsNumber]({% link docs/transformation-documentation/VisitOccurrence_NhsNumber.md %})
* [HospitalProviderSpellNumber]({% link docs/transformation-documentation/VisitOccurrence_HospitalProviderSpellNumber.md %})
* [visit_start_date]({% link docs/transformation-documentation/VisitOccurrence_visit_start_date.md %})
* [visit_start_datetime]({% link docs/transformation-documentation/VisitOccurrence_visit_start_datetime.md %})
* [visit_end_date]({% link docs/transformation-documentation/VisitOccurrence_visit_end_date.md %})
* [visit_end_datetime]({% link docs/transformation-documentation/VisitOccurrence_visit_end_datetime.md %})
* [visit_concept_id]({% link docs/transformation-documentation/VisitOccurrence_visit_concept_id.md %})
* [visit_type_concept_id]({% link docs/transformation-documentation/VisitOccurrence_visit_type_concept_id.md %})
* [admitted_from_concept_id]({% link docs/transformation-documentation/VisitOccurrence_admitted_from_concept_id.md %})
* [admitted_from_source_value]({% link docs/transformation-documentation/VisitOccurrence_admitted_from_source_value.md %})
* [discharged_to_concept_id]({% link docs/transformation-documentation/VisitOccurrence_discharged_to_concept_id.md %})
* [discharged_to_source_value]({% link docs/transformation-documentation/VisitOccurrence_discharged_to_source_value.md %})
* [RecordConnectionIdentifier]({% link docs/transformation-documentation/VisitOccurrence_RecordConnectionIdentifier.md %})

## CdsVisitOccurrenceWithSpell
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
    block:nhsnumber_container:1
        columns 4
        block:nhsnumber:1
        columns 1
            nhs_number_0["NHS NUMBER<br/> <br/> <br/> "]
            class nhs_number_0 sourceItem
        end
        
        space
        
        nhsnumber-->nhsnumber_target_0["NhsNumber"]

        nhsnumber_label(["Copy value"])
    end
   class nhsnumber_container container1
   class nhsnumber container1
   class nhsnumber_target_0 targetItem
   class nhsnumber_label targetItem
    columns 1
    block:hospitalproviderspellnumber_container:1
        columns 4
        block:hospitalproviderspellnumber:1
        columns 1
            hospital_provider_spell_number_1["HOSPITAL PROVIDER SPELL<br/> NUMBER<br/> <br/> "]
            class hospital_provider_spell_number_1 sourceItem
        end
        
        space
        
        hospitalproviderspellnumber-->hospitalproviderspellnumber_target_1["HospitalProviderSpellNumber"]

        hospitalproviderspellnumber_label(["Converts text to<br/> integers."])
    end
   class hospitalproviderspellnumber_container container1
   class hospitalproviderspellnumber container1
   class hospitalproviderspellnumber_target_1 targetItem
   class hospitalproviderspellnumber_label targetItem
    columns 1
    block:visit_start_date_container:1
        columns 4
        block:visit_start_date:1
        columns 1
            start_date_episode_2["START DATE (EPISODE)<br/> <br/> <br/> "]
            class start_date_episode_2 sourceItem
        end
        
        space
        
        visit_start_date-->visit_start_date_target_2["visit_start_date"]

        visit_start_date_label(["Converts text to<br/> dates."])
    end
   class visit_start_date_container container1
   class visit_start_date container1
   class visit_start_date_target_2 targetItem
   class visit_start_date_label targetItem
    columns 1
    block:visit_start_datetime_container:1
        columns 4
        block:visit_start_datetime:1
        columns 1
            start_date_episode_3["START DATE (EPISODE)<br/> <br/> <br/> "]
            class start_date_episode_3 sourceItem
            start_time_episode_3["START TIME (EPISODE)<br/> <br/> <br/> "]
            class start_time_episode_3 sourceItem
        end
        
        space
        
        visit_start_datetime-->visit_start_datetime_target_3["visit_start_datetime"]

        visit_start_datetime_label(["Combines a date<br/> with a time<br/> of day."])
    end
   class visit_start_datetime_container container1
   class visit_start_datetime container1
   class visit_start_datetime_target_3 targetItem
   class visit_start_datetime_label targetItem
    columns 1
    block:visit_end_date_container:1
        columns 4
        block:visit_end_date:1
        columns 1
            cds_activity_date_4["CDS ACTIVITY DATE<br/> <br/> <br/> "]
            class cds_activity_date_4 sourceItem
            end_date_episode_4["END DATE (EPISODE)<br/> <br/> <br/> "]
            class end_date_episode_4 sourceItem
        end
        
        space
        
        visit_end_date-->visit_end_date_target_4["visit_end_date"]

        visit_end_date_label(["Converts text to<br/> dates."])
    end
   class visit_end_date_container container1
   class visit_end_date container1
   class visit_end_date_target_4 targetItem
   class visit_end_date_label targetItem
    columns 1
    block:visit_end_datetime_container:1
        columns 4
        block:visit_end_datetime:1
        columns 1
            cds_activity_date_5["CDS ACTIVITY DATE<br/> <br/> <br/> "]
            class cds_activity_date_5 sourceItem
            end_date_episode_5["END DATE (EPISODE)<br/> <br/> <br/> "]
            class end_date_episode_5 sourceItem
            end_time_episode_5["END TIME (EPISODE)<br/> <br/> <br/> "]
            class end_time_episode_5 sourceItem
        end
        
        space
        
        visit_end_datetime-->visit_end_datetime_target_5["visit_end_datetime"]

        visit_end_datetime_label(["Combines a date<br/> with a time<br/> of day."])
    end
   class visit_end_datetime_container container1
   class visit_end_datetime container1
   class visit_end_datetime_target_5 targetItem
   class visit_end_datetime_label targetItem
    columns 1
    block:visit_concept_id_container:1
        columns 4
        block:visit_concept_id:1
        columns 1
            admission_method_code_hospital_provider_spell_6["ADMISSION METHOD CODE<br/> (HOSPITAL PROVIDER SPELL)<br/> <br/> "]
            class admission_method_code_hospital_provider_spell_6 sourceItem
            patient_classification_code_6["PATIENT CLASSIFICATION CODE<br/> <br/> <br/> "]
            class patient_classification_code_6 sourceItem
            location_class_6["LOCATION CLASS<br/> <br/> <br/> "]
            class location_class_6 sourceItem
        end
        
        space
        
        visit_concept_id-->visit_concept_id_target_6["visit_concept_id"]

        visit_concept_id_label(["Copy value"])
    end
   class visit_concept_id_container container1
   class visit_concept_id container1
   class visit_concept_id_target_6 targetItem
   class visit_concept_id_label targetItem
    columns 1
    block:visit_type_concept_id_container:1
        columns 4
        block:visit_type_concept_id:1
        columns 1
            end_date_episode_7["END DATE (EPISODE)<br/> <br/> <br/> "]
            class end_date_episode_7 sourceItem
            discharge_date_hospital_provider_spell_7["DISCHARGE DATE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class discharge_date_hospital_provider_spell_7 sourceItem
            patient_classification_code_7["PATIENT CLASSIFICATION CODE<br/> <br/> <br/> "]
            class patient_classification_code_7 sourceItem
        end
        
        space
        
        visit_type_concept_id-->visit_type_concept_id_target_7["visit_type_concept_id"]

        visit_type_concept_id_label(["Copy value"])
    end
   class visit_type_concept_id_container container1
   class visit_type_concept_id container1
   class visit_type_concept_id_target_7 targetItem
   class visit_type_concept_id_label targetItem
    columns 1
    block:admitted_from_concept_id_container:1
        columns 4
        block:admitted_from_concept_id:1
        columns 1
            admission_source_hospital_provider_spell_8["ADMISSION SOURCE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class admission_source_hospital_provider_spell_8 sourceItem
        end
        
        space
        
        admitted_from_concept_id-->admitted_from_concept_id_target_8["admitted_from_concept_id"]

        admitted_from_concept_id_label(["Lookup admission source<br/> concept."])
    end
   class admitted_from_concept_id_container container1
   class admitted_from_concept_id container1
   class admitted_from_concept_id_target_8 targetItem
   class admitted_from_concept_id_label targetItem
    columns 1
    block:admitted_from_source_value_container:1
        columns 4
        block:admitted_from_source_value:1
        columns 1
            admission_source_hospital_provider_spell_9["ADMISSION SOURCE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class admission_source_hospital_provider_spell_9 sourceItem
        end
        
        space
        
        admitted_from_source_value-->admitted_from_source_value_target_9["admitted_from_source_value"]

        admitted_from_source_value_label(["Copy value"])
    end
   class admitted_from_source_value_container container1
   class admitted_from_source_value container1
   class admitted_from_source_value_target_9 targetItem
   class admitted_from_source_value_label targetItem
    columns 1
    block:discharged_to_concept_id_container:1
        columns 4
        block:discharged_to_concept_id:1
        columns 1
            discharge_destination_code_hospital_provider_spell_10["DISCHARGE DESTINATION CODE<br/> (HOSPITAL PROVIDER SPELL)<br/> <br/> "]
            class discharge_destination_code_hospital_provider_spell_10 sourceItem
        end
        
        space
        
        discharged_to_concept_id-->discharged_to_concept_id_target_10["discharged_to_concept_id"]

        discharged_to_concept_id_label(["Lookup discharge destination<br/> concept."])
    end
   class discharged_to_concept_id_container container1
   class discharged_to_concept_id container1
   class discharged_to_concept_id_target_10 targetItem
   class discharged_to_concept_id_label targetItem
    columns 1
    block:discharged_to_source_value_container:1
        columns 4
        block:discharged_to_source_value:1
        columns 1
            discharge_destination_code_hospital_provider_spell_11["DISCHARGE DESTINATION CODE<br/> (HOSPITAL PROVIDER SPELL)<br/> <br/> "]
            class discharge_destination_code_hospital_provider_spell_11 sourceItem
        end
        
        space
        
        discharged_to_source_value-->discharged_to_source_value_target_11["discharged_to_source_value"]

        discharged_to_source_value_label(["Copy value"])
    end
   class discharged_to_source_value_container container1
   class discharged_to_source_value container1
   class discharged_to_source_value_target_11 targetItem
   class discharged_to_source_value_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CdsVisitOccurrenceWithSpell%20mapping){: .btn }
## CdsVisitOccurrenceWithoutSpell
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
    block:nhsnumber_container:1
        columns 4
        block:nhsnumber:1
        columns 1
            nhs_number_0["NHS NUMBER<br/> <br/> <br/> "]
            class nhs_number_0 sourceItem
        end
        
        space
        
        nhsnumber-->nhsnumber_target_0["NhsNumber"]

        nhsnumber_label(["Copy value"])
    end
   class nhsnumber_container container1
   class nhsnumber container1
   class nhsnumber_target_0 targetItem
   class nhsnumber_label targetItem
    columns 1
    block:visit_start_date_container:1
        columns 4
        block:visit_start_date:1
        columns 1
            cds_activity_date_1["CDS ACTIVITY DATE<br/> <br/> <br/> "]
            class cds_activity_date_1 sourceItem
        end
        
        space
        
        visit_start_date-->visit_start_date_target_1["visit_start_date"]

        visit_start_date_label(["Converts text to<br/> dates."])
    end
   class visit_start_date_container container1
   class visit_start_date container1
   class visit_start_date_target_1 targetItem
   class visit_start_date_label targetItem
    columns 1
    block:visit_start_datetime_container:1
        columns 4
        block:visit_start_datetime:1
        columns 1
            cds_activity_date_2["CDS ACTIVITY DATE<br/> <br/> <br/> "]
            class cds_activity_date_2 sourceItem
        end
        
        space
        
        visit_start_datetime-->visit_start_datetime_target_2["visit_start_datetime"]

        visit_start_datetime_label(["Combines a date<br/> with a time<br/> of day."])
    end
   class visit_start_datetime_container container1
   class visit_start_datetime container1
   class visit_start_datetime_target_2 targetItem
   class visit_start_datetime_label targetItem
    columns 1
    block:visit_end_date_container:1
        columns 4
        block:visit_end_date:1
        columns 1
            cds_activity_date_3["CDS ACTIVITY DATE<br/> <br/> <br/> "]
            class cds_activity_date_3 sourceItem
        end
        
        space
        
        visit_end_date-->visit_end_date_target_3["visit_end_date"]

        visit_end_date_label(["Converts text to<br/> dates."])
    end
   class visit_end_date_container container1
   class visit_end_date container1
   class visit_end_date_target_3 targetItem
   class visit_end_date_label targetItem
    columns 1
    block:visit_end_datetime_container:1
        columns 4
        block:visit_end_datetime:1
        columns 1
            cds_activity_date_4["CDS ACTIVITY DATE<br/> <br/> <br/> "]
            class cds_activity_date_4 sourceItem
        end
        
        space
        
        visit_end_datetime-->visit_end_datetime_target_4["visit_end_datetime"]

        visit_end_datetime_label(["Combines a date<br/> with a time<br/> of day."])
    end
   class visit_end_datetime_container container1
   class visit_end_datetime container1
   class visit_end_datetime_target_4 targetItem
   class visit_end_datetime_label targetItem
    columns 1
    block:admitted_from_concept_id_container:1
        columns 4
        block:admitted_from_concept_id:1
        columns 1
            admission_source_hospital_provider_spell_5["ADMISSION SOURCE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class admission_source_hospital_provider_spell_5 sourceItem
        end
        
        space
        
        admitted_from_concept_id-->admitted_from_concept_id_target_5["admitted_from_concept_id"]

        admitted_from_concept_id_label(["Lookup admission source<br/> concept."])
    end
   class admitted_from_concept_id_container container1
   class admitted_from_concept_id container1
   class admitted_from_concept_id_target_5 targetItem
   class admitted_from_concept_id_label targetItem
    columns 1
    block:admitted_from_source_value_container:1
        columns 4
        block:admitted_from_source_value:1
        columns 1
            admission_source_hospital_provider_spell_6["ADMISSION SOURCE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class admission_source_hospital_provider_spell_6 sourceItem
        end
        
        space
        
        admitted_from_source_value-->admitted_from_source_value_target_6["admitted_from_source_value"]

        admitted_from_source_value_label(["Copy value"])
    end
   class admitted_from_source_value_container container1
   class admitted_from_source_value container1
   class admitted_from_source_value_target_6 targetItem
   class admitted_from_source_value_label targetItem
    columns 1
    block:discharged_to_concept_id_container:1
        columns 4
        block:discharged_to_concept_id:1
        columns 1
            discharge_destination_code_hospital_provider_spell_7["DISCHARGE DESTINATION CODE<br/> (HOSPITAL PROVIDER SPELL)<br/> <br/> "]
            class discharge_destination_code_hospital_provider_spell_7 sourceItem
        end
        
        space
        
        discharged_to_concept_id-->discharged_to_concept_id_target_7["discharged_to_concept_id"]

        discharged_to_concept_id_label(["Lookup discharge destination<br/> concept."])
    end
   class discharged_to_concept_id_container container1
   class discharged_to_concept_id container1
   class discharged_to_concept_id_target_7 targetItem
   class discharged_to_concept_id_label targetItem
    columns 1
    block:discharged_to_source_value_container:1
        columns 4
        block:discharged_to_source_value:1
        columns 1
            discharge_destination_code_hospital_provider_spell_8["DISCHARGE DESTINATION CODE<br/> (HOSPITAL PROVIDER SPELL)<br/> <br/> "]
            class discharge_destination_code_hospital_provider_spell_8 sourceItem
        end
        
        space
        
        discharged_to_source_value-->discharged_to_source_value_target_8["discharged_to_source_value"]

        discharged_to_source_value_label(["Copy value"])
    end
   class discharged_to_source_value_container container1
   class discharged_to_source_value container1
   class discharged_to_source_value_target_8 targetItem
   class discharged_to_source_value_label targetItem
    columns 1
    block:recordconnectionidentifier_container:1
        columns 4
        block:recordconnectionidentifier:1
        columns 1
            cds_record_identifier_9["CDS RECORD IDENTIFIER<br/> <br/> <br/> "]
            class cds_record_identifier_9 sourceItem
        end
        
        space
        
        recordconnectionidentifier-->recordconnectionidentifier_target_9["RecordConnectionIdentifier"]

        recordconnectionidentifier_label(["Copy value"])
    end
   class recordconnectionidentifier_container container1
   class recordconnectionidentifier container1
   class recordconnectionidentifier_target_9 targetItem
   class recordconnectionidentifier_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CdsVisitOccurrenceWithoutSpell%20mapping){: .btn }
