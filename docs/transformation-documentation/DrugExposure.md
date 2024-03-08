---
layout: default
title: DrugExposure
has_children: true
parent: Transformation Documentation
has_toc: false
---

# DrugExposure
* [nhs_number]({% link docs/transformation-documentation/DrugExposure_nhs_number.md %})
* [drug_concept_id]({% link docs/transformation-documentation/DrugExposure_drug_concept_id.md %})
* [drug_exposure_start_date]({% link docs/transformation-documentation/DrugExposure_drug_exposure_start_date.md %})
* [drug_exposure_end_date]({% link docs/transformation-documentation/DrugExposure_drug_exposure_end_date.md %})
* [drug_type_concept_id]({% link docs/transformation-documentation/DrugExposure_drug_type_concept_id.md %})
* [drug_source_value]({% link docs/transformation-documentation/DrugExposure_drug_source_value.md %})
* [drug_source_concept_id]({% link docs/transformation-documentation/DrugExposure_drug_source_concept_id.md %})
* [RecordConnectionIdentifier]({% link docs/transformation-documentation/DrugExposure_RecordConnectionIdentifier.md %})

## CdsDrugExposure
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
    block:drug_exposure_start_date_container:1
        columns 4
        block:drug_exposure_start_date:1
        columns 1
            cds_activity_date_1["CDS ACTIVITY DATE<br/> <br/> <br/> "]
            class cds_activity_date_1 sourceItem
            start_date_hospital_provider_spell_1["START DATE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class start_date_hospital_provider_spell_1 sourceItem
            start_date_episode_1["START DATE (EPISODE)<br/> <br/> <br/> "]
            class start_date_episode_1 sourceItem
        end
        
        space
        
        drug_exposure_start_date-->drug_exposure_start_date_target_1["drug_exposure_start_date"]

        drug_exposure_start_date_label(["Converts text to<br/> dates."])
    end
   class drug_exposure_start_date_container container1
   class drug_exposure_start_date container1
   class drug_exposure_start_date_target_1 targetItem
   class drug_exposure_start_date_label targetItem
    columns 1
    block:drug_exposure_end_date_container:1
        columns 4
        block:drug_exposure_end_date:1
        columns 1
            cds_activity_date_2["CDS ACTIVITY DATE<br/> <br/> <br/> "]
            class cds_activity_date_2 sourceItem
            end_date_episode_2["END DATE (EPISODE)<br/> <br/> <br/> "]
            class end_date_episode_2 sourceItem
            discharge_date_hospital_provider_spell_2["DISCHARGE DATE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class discharge_date_hospital_provider_spell_2 sourceItem
        end
        
        space
        
        drug_exposure_end_date-->drug_exposure_end_date_target_2["drug_exposure_end_date"]

        drug_exposure_end_date_label(["Converts text to<br/> dates."])
    end
   class drug_exposure_end_date_container container1
   class drug_exposure_end_date container1
   class drug_exposure_end_date_target_2 targetItem
   class drug_exposure_end_date_label targetItem
    columns 1
    block:drug_type_concept_id_container:1
        columns 4
        block:drug_type_concept_id:1
        columns 1
            end_date_episode_3["END DATE (EPISODE)<br/> <br/> <br/> "]
            class end_date_episode_3 sourceItem
            discharge_date_hospital_provider_spell_3["DISCHARGE DATE (HOSPITAL<br/> PROVIDER SPELL)<br/> <br/> "]
            class discharge_date_hospital_provider_spell_3 sourceItem
        end
        
        space
        
        drug_type_concept_id-->drug_type_concept_id_target_3["drug_type_concept_id"]

        drug_type_concept_id_label(["Copy value"])
    end
   class drug_type_concept_id_container container1
   class drug_type_concept_id container1
   class drug_type_concept_id_target_3 targetItem
   class drug_type_concept_id_label targetItem
    columns 1
    block:drug_source_value_container:1
        columns 4
        block:drug_source_value:1
        columns 1
            high_cost_drugs_opcs_4["HIGH COST DRUGS<br/> (OPCS)<br/> <br/> "]
            class high_cost_drugs_opcs_4 sourceItem
        end
        
        space
        
        drug_source_value-->drug_source_value_target_4["drug_source_value"]

        drug_source_value_label(["Copy value"])
    end
   class drug_source_value_container container1
   class drug_source_value container1
   class drug_source_value_target_4 targetItem
   class drug_source_value_label targetItem
    columns 1
    block:drug_source_concept_id_container:1
        columns 4
        block:drug_source_concept_id:1
        columns 1
            high_cost_drugs_opcs_5["HIGH COST DRUGS<br/> (OPCS)<br/> <br/> "]
            class high_cost_drugs_opcs_5 sourceItem
        end
        
        space
        
        drug_source_concept_id-->drug_source_concept_id_target_5["drug_source_concept_id"]

        drug_source_concept_id_label(["Resolve OPCS4 codes<br/> to OMOP concepts.<br/> If code cannot<br/> be mapped, map<br/> using the parent<br/> code."])
    end
   class drug_source_concept_id_container container1
   class drug_source_concept_id container1
   class drug_source_concept_id_target_5 targetItem
   class drug_source_concept_id_label targetItem
    columns 1
    block:recordconnectionidentifier_container:1
        columns 4
        block:recordconnectionidentifier:1
        columns 1
            cds_record_identifier_6["CDS RECORD IDENTIFIER<br/> <br/> <br/> "]
            class cds_record_identifier_6 sourceItem
        end
        
        space
        
        recordconnectionidentifier-->recordconnectionidentifier_target_6["RecordConnectionIdentifier"]

        recordconnectionidentifier_label(["Copy value"])
    end
   class recordconnectionidentifier_container container1
   class recordconnectionidentifier container1
   class recordconnectionidentifier_target_6 targetItem
   class recordconnectionidentifier_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CdsDrugExposure%20mapping){: .btn }
