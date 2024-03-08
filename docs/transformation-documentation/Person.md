---
layout: default
title: Person
has_children: true
parent: Transformation Documentation
has_toc: false
---

# Person
* [person_source_value]({% link docs/transformation-documentation/Person_person_source_value.md %})
* [year_of_birth]({% link docs/transformation-documentation/Person_year_of_birth.md %})
* [month_of_birth]({% link docs/transformation-documentation/Person_month_of_birth.md %})
* [day_of_birth]({% link docs/transformation-documentation/Person_day_of_birth.md %})
* [birth_datetime]({% link docs/transformation-documentation/Person_birth_datetime.md %})
* [ethnicity_concept_id]({% link docs/transformation-documentation/Person_ethnicity_concept_id.md %})
* [gender_concept_id]({% link docs/transformation-documentation/Person_gender_concept_id.md %})
* [gender_source_value]({% link docs/transformation-documentation/Person_gender_source_value.md %})
* [race_concept_id]({% link docs/transformation-documentation/Person_race_concept_id.md %})
* [race_source_value]({% link docs/transformation-documentation/Person_race_source_value.md %})
* [race_source_concept_id]({% link docs/transformation-documentation/Person_race_source_concept_id.md %})

## SactPerson
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
    block:person_source_value_container:1
        columns 4
        block:person_source_value:1
        columns 1
            nhs_number_0["NHS NUMBER<br/> <br/> <br/> "]
            class nhs_number_0 sourceItem
        end
        
        space
        
        person_source_value-->person_source_value_target_0["person_source_value"]

        person_source_value_label(["Copy value"])
    end
   class person_source_value_container container1
   class person_source_value container1
   class person_source_value_target_0 targetItem
   class person_source_value_label targetItem
    columns 1
    block:year_of_birth_container:1
        columns 4
        block:year_of_birth:1
        columns 1
            person_birth_date_1["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_1 sourceItem
        end
        
        space
        
        year_of_birth-->year_of_birth_target_1["year_of_birth"]

        year_of_birth_label(["Selects the year<br/> from a date<br/> or null of<br/> the date is<br/> null."])
    end
   class year_of_birth_container container1
   class year_of_birth container1
   class year_of_birth_target_1 targetItem
   class year_of_birth_label targetItem
    columns 1
    block:month_of_birth_container:1
        columns 4
        block:month_of_birth:1
        columns 1
            person_birth_date_2["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_2 sourceItem
        end
        
        space
        
        month_of_birth-->month_of_birth_target_2["month_of_birth"]

        month_of_birth_label(["Selects the month<br/> of the year<br/> or null if<br/> the date is<br/> null."])
    end
   class month_of_birth_container container1
   class month_of_birth container1
   class month_of_birth_target_2 targetItem
   class month_of_birth_label targetItem
    columns 1
    block:day_of_birth_container:1
        columns 4
        block:day_of_birth:1
        columns 1
            person_birth_date_3["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_3 sourceItem
        end
        
        space
        
        day_of_birth-->day_of_birth_target_3["day_of_birth"]

        day_of_birth_label(["Selects the day<br/> of the month<br/> or null if<br/> the date is<br/> null."])
    end
   class day_of_birth_container container1
   class day_of_birth container1
   class day_of_birth_target_3 targetItem
   class day_of_birth_label targetItem
    columns 1
    block:birth_datetime_container:1
        columns 4
        block:birth_datetime:1
        columns 1
            person_birth_date_4["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_4 sourceItem
        end
        
        space
        
        birth_datetime-->birth_datetime_target_4["birth_datetime"]

        birth_datetime_label(["Converts text to<br/> dates."])
    end
   class birth_datetime_container container1
   class birth_datetime container1
   class birth_datetime_target_4 targetItem
   class birth_datetime_label targetItem
    columns 1
    block:gender_concept_id_container:1
        columns 4
        block:gender_concept_id:1
        columns 1
            person_gender_code_current_5["PERSON GENDER CODE<br/> CURRENT<br/> <br/> "]
            class person_gender_code_current_5 sourceItem
        end
        
        space
        
        gender_concept_id-->gender_concept_id_target_5["gender_concept_id"]

        gender_concept_id_label(["Lookup gender concept."])
    end
   class gender_concept_id_container container1
   class gender_concept_id container1
   class gender_concept_id_target_5 targetItem
   class gender_concept_id_label targetItem
    columns 1
    block:gender_source_value_container:1
        columns 4
        block:gender_source_value:1
        columns 1
            person_gender_code_current_6["PERSON GENDER CODE<br/> CURRENT<br/> <br/> "]
            class person_gender_code_current_6 sourceItem
        end
        
        space
        
        gender_source_value-->gender_source_value_target_6["gender_source_value"]

        gender_source_value_label(["Copy value"])
    end
   class gender_source_value_container container1
   class gender_source_value container1
   class gender_source_value_target_6 targetItem
   class gender_source_value_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=SactPerson%20mapping){: .btn }
## RtdsPerson
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
    block:person_source_value_container:1
        columns 4
        block:person_source_value:1
        columns 1
            nhs_number_0["NHS NUMBER<br/> <br/> <br/> "]
            class nhs_number_0 sourceItem
        end
        
        space
        
        person_source_value-->person_source_value_target_0["person_source_value"]

        person_source_value_label(["Copy value"])
    end
   class person_source_value_container container1
   class person_source_value container1
   class person_source_value_target_0 targetItem
   class person_source_value_label targetItem
    columns 1
    block:year_of_birth_container:1
        columns 4
        block:year_of_birth:1
        columns 1
            person_birth_date_1["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_1 sourceItem
        end
        
        space
        
        year_of_birth-->year_of_birth_target_1["year_of_birth"]

        year_of_birth_label(["Selects the year<br/> from a date<br/> or null of<br/> the date is<br/> null."])
    end
   class year_of_birth_container container1
   class year_of_birth container1
   class year_of_birth_target_1 targetItem
   class year_of_birth_label targetItem
    columns 1
    block:month_of_birth_container:1
        columns 4
        block:month_of_birth:1
        columns 1
            person_birth_date_2["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_2 sourceItem
        end
        
        space
        
        month_of_birth-->month_of_birth_target_2["month_of_birth"]

        month_of_birth_label(["Selects the month<br/> of the year<br/> or null if<br/> the date is<br/> null."])
    end
   class month_of_birth_container container1
   class month_of_birth container1
   class month_of_birth_target_2 targetItem
   class month_of_birth_label targetItem
    columns 1
    block:day_of_birth_container:1
        columns 4
        block:day_of_birth:1
        columns 1
            person_birth_date_3["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_3 sourceItem
        end
        
        space
        
        day_of_birth-->day_of_birth_target_3["day_of_birth"]

        day_of_birth_label(["Selects the day<br/> of the month<br/> or null if<br/> the date is<br/> null."])
    end
   class day_of_birth_container container1
   class day_of_birth container1
   class day_of_birth_target_3 targetItem
   class day_of_birth_label targetItem
    columns 1
    block:birth_datetime_container:1
        columns 4
        block:birth_datetime:1
        columns 1
            person_birth_date_4["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_4 sourceItem
        end
        
        space
        
        birth_datetime-->birth_datetime_target_4["birth_datetime"]

        birth_datetime_label(["Converts text to<br/> dates."])
    end
   class birth_datetime_container container1
   class birth_datetime container1
   class birth_datetime_target_4 targetItem
   class birth_datetime_label targetItem
    columns 1
    block:gender_concept_id_container:1
        columns 4
        block:gender_concept_id:1
        columns 1
            person_gender_code_current_5["PERSON GENDER CODE<br/> CURRENT<br/> <br/> "]
            class person_gender_code_current_5 sourceItem
        end
        
        space
        
        gender_concept_id-->gender_concept_id_target_5["gender_concept_id"]

        gender_concept_id_label(["Lookup gender concept."])
    end
   class gender_concept_id_container container1
   class gender_concept_id container1
   class gender_concept_id_target_5 targetItem
   class gender_concept_id_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=RtdsPerson%20mapping){: .btn }
## CosdPerson
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
    block:person_source_value_container:1
        columns 4
        block:person_source_value:1
        columns 1
            nhs_number_0["NHS NUMBER<br/> <br/> <br/> "]
            class nhs_number_0 sourceItem
        end
        
        space
        
        person_source_value-->person_source_value_target_0["person_source_value"]

        person_source_value_label(["Copy value"])
    end
   class person_source_value_container container1
   class person_source_value container1
   class person_source_value_target_0 targetItem
   class person_source_value_label targetItem
    columns 1
    block:year_of_birth_container:1
        columns 4
        block:year_of_birth:1
        columns 1
            person_birth_date_1["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_1 sourceItem
        end
        
        space
        
        year_of_birth-->year_of_birth_target_1["year_of_birth"]

        year_of_birth_label(["Selects the year<br/> from a date<br/> or null of<br/> the date is<br/> null."])
    end
   class year_of_birth_container container1
   class year_of_birth container1
   class year_of_birth_target_1 targetItem
   class year_of_birth_label targetItem
    columns 1
    block:month_of_birth_container:1
        columns 4
        block:month_of_birth:1
        columns 1
            person_birth_date_2["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_2 sourceItem
        end
        
        space
        
        month_of_birth-->month_of_birth_target_2["month_of_birth"]

        month_of_birth_label(["Selects the month<br/> of the year<br/> or null if<br/> the date is<br/> null."])
    end
   class month_of_birth_container container1
   class month_of_birth container1
   class month_of_birth_target_2 targetItem
   class month_of_birth_label targetItem
    columns 1
    block:day_of_birth_container:1
        columns 4
        block:day_of_birth:1
        columns 1
            person_birth_date_3["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_3 sourceItem
        end
        
        space
        
        day_of_birth-->day_of_birth_target_3["day_of_birth"]

        day_of_birth_label(["Selects the day<br/> of the month<br/> or null if<br/> the date is<br/> null."])
    end
   class day_of_birth_container container1
   class day_of_birth container1
   class day_of_birth_target_3 targetItem
   class day_of_birth_label targetItem
    columns 1
    block:birth_datetime_container:1
        columns 4
        block:birth_datetime:1
        columns 1
            person_birth_date_4["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_4 sourceItem
        end
        
        space
        
        birth_datetime-->birth_datetime_target_4["birth_datetime"]

        birth_datetime_label(["Converts text to<br/> dates."])
    end
   class birth_datetime_container container1
   class birth_datetime container1
   class birth_datetime_target_4 targetItem
   class birth_datetime_label targetItem
    columns 1
    block:race_concept_id_container:1
        columns 4
        block:race_concept_id:1
        columns 1
            ethnic_category_5["ETHNIC CATEGORY<br/> <br/> <br/> "]
            class ethnic_category_5 sourceItem
        end
        
        space
        
        race_concept_id-->race_concept_id_target_5["race_concept_id"]

        race_concept_id_label(["Lookup race concept."])
    end
   class race_concept_id_container container1
   class race_concept_id container1
   class race_concept_id_target_5 targetItem
   class race_concept_id_label targetItem
    columns 1
    block:race_source_value_container:1
        columns 4
        block:race_source_value:1
        columns 1
            ethnic_category_6["ETHNIC CATEGORY<br/> <br/> <br/> "]
            class ethnic_category_6 sourceItem
        end
        
        space
        
        race_source_value-->race_source_value_target_6["race_source_value"]

        race_source_value_label(["Copy value"])
    end
   class race_source_value_container container1
   class race_source_value container1
   class race_source_value_target_6 targetItem
   class race_source_value_label targetItem
    columns 1
    block:race_source_concept_id_container:1
        columns 4
        block:race_source_concept_id:1
        columns 1
            ethnic_category_7["ETHNIC CATEGORY<br/> <br/> <br/> "]
            class ethnic_category_7 sourceItem
        end
        
        space
        
        race_source_concept_id-->race_source_concept_id_target_7["race_source_concept_id"]

        race_source_concept_id_label(["Lookup race source<br/> concept."])
    end
   class race_source_concept_id_container container1
   class race_source_concept_id container1
   class race_source_concept_id_target_7 targetItem
   class race_source_concept_id_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdPerson%20mapping){: .btn }
## CdsPerson
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
    block:person_source_value_container:1
        columns 4
        block:person_source_value:1
        columns 1
            nhs_number_0["NHS NUMBER<br/> <br/> <br/> "]
            class nhs_number_0 sourceItem
        end
        
        space
        
        person_source_value-->person_source_value_target_0["person_source_value"]

        person_source_value_label(["Copy value"])
    end
   class person_source_value_container container1
   class person_source_value container1
   class person_source_value_target_0 targetItem
   class person_source_value_label targetItem
    columns 1
    block:year_of_birth_container:1
        columns 4
        block:year_of_birth:1
        columns 1
            person_birth_date_1["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_1 sourceItem
        end
        
        space
        
        year_of_birth-->year_of_birth_target_1["year_of_birth"]

        year_of_birth_label(["Selects the year<br/> from a date<br/> or null of<br/> the date is<br/> null."])
    end
   class year_of_birth_container container1
   class year_of_birth container1
   class year_of_birth_target_1 targetItem
   class year_of_birth_label targetItem
    columns 1
    block:month_of_birth_container:1
        columns 4
        block:month_of_birth:1
        columns 1
            person_birth_date_2["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_2 sourceItem
        end
        
        space
        
        month_of_birth-->month_of_birth_target_2["month_of_birth"]

        month_of_birth_label(["Selects the month<br/> of the year<br/> or null if<br/> the date is<br/> null."])
    end
   class month_of_birth_container container1
   class month_of_birth container1
   class month_of_birth_target_2 targetItem
   class month_of_birth_label targetItem
    columns 1
    block:day_of_birth_container:1
        columns 4
        block:day_of_birth:1
        columns 1
            person_birth_date_3["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_3 sourceItem
        end
        
        space
        
        day_of_birth-->day_of_birth_target_3["day_of_birth"]

        day_of_birth_label(["Selects the day<br/> of the month<br/> or null if<br/> the date is<br/> null."])
    end
   class day_of_birth_container container1
   class day_of_birth container1
   class day_of_birth_target_3 targetItem
   class day_of_birth_label targetItem
    columns 1
    block:birth_datetime_container:1
        columns 4
        block:birth_datetime:1
        columns 1
            person_birth_date_4["PERSON BIRTH DATE<br/> <br/> <br/> "]
            class person_birth_date_4 sourceItem
        end
        
        space
        
        birth_datetime-->birth_datetime_target_4["birth_datetime"]

        birth_datetime_label(["Converts text to<br/> dates."])
    end
   class birth_datetime_container container1
   class birth_datetime container1
   class birth_datetime_target_4 targetItem
   class birth_datetime_label targetItem
    columns 1
    block:gender_concept_id_container:1
        columns 4
        block:gender_concept_id:1
        columns 1
            person_gender_code_current_5["PERSON GENDER CODE<br/> CURRENT<br/> <br/> "]
            class person_gender_code_current_5 sourceItem
        end
        
        space
        
        gender_concept_id-->gender_concept_id_target_5["gender_concept_id"]

        gender_concept_id_label(["Lookup gender concept."])
    end
   class gender_concept_id_container container1
   class gender_concept_id container1
   class gender_concept_id_target_5 targetItem
   class gender_concept_id_label targetItem
    columns 1
    block:gender_source_value_container:1
        columns 4
        block:gender_source_value:1
        columns 1
            person_gender_code_current_6["PERSON GENDER CODE<br/> CURRENT<br/> <br/> "]
            class person_gender_code_current_6 sourceItem
        end
        
        space
        
        gender_source_value-->gender_source_value_target_6["gender_source_value"]

        gender_source_value_label(["Copy value"])
    end
   class gender_source_value_container container1
   class gender_source_value container1
   class gender_source_value_target_6 targetItem
   class gender_source_value_label targetItem
    columns 1
    block:race_concept_id_container:1
        columns 4
        block:race_concept_id:1
        columns 1
            ethnic_category_7["ETHNIC CATEGORY<br/> <br/> <br/> "]
            class ethnic_category_7 sourceItem
        end
        
        space
        
        race_concept_id-->race_concept_id_target_7["race_concept_id"]

        race_concept_id_label(["Lookup race concept."])
    end
   class race_concept_id_container container1
   class race_concept_id container1
   class race_concept_id_target_7 targetItem
   class race_concept_id_label targetItem
    columns 1
    block:race_source_value_container:1
        columns 4
        block:race_source_value:1
        columns 1
            ethnic_category_8["ETHNIC CATEGORY<br/> <br/> <br/> "]
            class ethnic_category_8 sourceItem
        end
        
        space
        
        race_source_value-->race_source_value_target_8["race_source_value"]

        race_source_value_label(["Copy value"])
    end
   class race_source_value_container container1
   class race_source_value container1
   class race_source_value_target_8 targetItem
   class race_source_value_label targetItem
    columns 1
    block:race_source_concept_id_container:1
        columns 4
        block:race_source_concept_id:1
        columns 1
            ethnic_category_9["ETHNIC CATEGORY<br/> <br/> <br/> "]
            class ethnic_category_9 sourceItem
        end
        
        space
        
        race_source_concept_id-->race_source_concept_id_target_9["race_source_concept_id"]

        race_source_concept_id_label(["Lookup race source<br/> concept."])
    end
   class race_source_concept_id_container container1
   class race_source_concept_id container1
   class race_source_concept_id_target_9 targetItem
   class race_source_concept_id_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CdsPerson%20mapping){: .btn }
