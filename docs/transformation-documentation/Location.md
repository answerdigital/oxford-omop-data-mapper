---
layout: default
title: Location
has_children: true
parent: Transformation Documentation
has_toc: false
---

# Location
* [zip]({% link docs/transformation-documentation/Location_zip.md %})
* [location_source_value]({% link docs/transformation-documentation/Location_location_source_value.md %})
* [nhs_number]({% link docs/transformation-documentation/Location_nhs_number.md %})
* [address_1]({% link docs/transformation-documentation/Location_address_1.md %})
* [address_2]({% link docs/transformation-documentation/Location_address_2.md %})
* [city]({% link docs/transformation-documentation/Location_city.md %})
* [county]({% link docs/transformation-documentation/Location_county.md %})

## SactLocation
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
    block:zip_container:1
        columns 4
        block:zip:1
        columns 1
            postcode_0["POSTCODE<br/> <br/> <br/> "]
            class postcode_0 sourceItem
        end
        
        space
        
        zip-->zip_target_0["zip"]

        zip_label(["Uppercase the postcode<br/> then insert the<br/> space in the<br/> correct location, if<br/> needed."])
    end
   class zip_container container1
   class zip container1
   class zip_target_0 targetItem
   class zip_label targetItem
    columns 1
    block:location_source_value_container:1
        columns 4
        block:location_source_value:1
        columns 1
            postcode_1["POSTCODE<br/> <br/> <br/> "]
            class postcode_1 sourceItem
        end
        
        space
        
        location_source_value-->location_source_value_target_1["location_source_value"]

        location_source_value_label(["Copy value"])
    end
   class location_source_value_container container1
   class location_source_value container1
   class location_source_value_target_1 targetItem
   class location_source_value_label targetItem
    columns 1
    block:nhs_number_container:1
        columns 4
        block:nhs_number:1
        columns 1
            nhs_number_2["NHS NUMBER<br/> <br/> <br/> "]
            class nhs_number_2 sourceItem
        end
        
        space
        
        nhs_number-->nhs_number_target_2["nhs_number"]

        nhs_number_label(["Copy value"])
    end
   class nhs_number_container container1
   class nhs_number container1
   class nhs_number_target_2 targetItem
   class nhs_number_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=SactLocation%20mapping){: .btn }
## RtdsLocation
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
    block:zip_container:1
        columns 4
        block:zip:1
        columns 1
            postcode_0["POSTCODE<br/> <br/> <br/> "]
            class postcode_0 sourceItem
        end
        
        space
        
        zip-->zip_target_0["zip"]

        zip_label(["Uppercase the postcode<br/> then insert the<br/> space in the<br/> correct location, if<br/> needed."])
    end
   class zip_container container1
   class zip container1
   class zip_target_0 targetItem
   class zip_label targetItem
    columns 1
    block:location_source_value_container:1
        columns 4
        block:location_source_value:1
        columns 1
            nhs_number_1["NHS NUMBER<br/> <br/> <br/> "]
            class nhs_number_1 sourceItem
        end
        
        space
        
        location_source_value-->location_source_value_target_1["location_source_value"]

        location_source_value_label(["Copy value"])
    end
   class location_source_value_container container1
   class location_source_value container1
   class location_source_value_target_1 targetItem
   class location_source_value_label targetItem
    columns 1
    block:nhs_number_container:1
        columns 4
        block:nhs_number:1
        columns 1
            nhs_number_2["NHS NUMBER<br/> <br/> <br/> "]
            class nhs_number_2 sourceItem
        end
        
        space
        
        nhs_number-->nhs_number_target_2["nhs_number"]

        nhs_number_label(["Copy value"])
    end
   class nhs_number_container container1
   class nhs_number container1
   class nhs_number_target_2 targetItem
   class nhs_number_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=RtdsLocation%20mapping){: .btn }
## CosdLocation
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
    block:zip_container:1
        columns 4
        block:zip:1
        columns 1
            postcode_of_usual_address_at_diagnosis_0["POSTCODE OF USUAL<br/> ADDRESS (AT DIAGNOSIS)<br/> <br/> "]
            class postcode_of_usual_address_at_diagnosis_0 sourceItem
        end
        
        space
        
        zip-->zip_target_0["zip"]

        zip_label(["Uppercase the postcode<br/> then insert the<br/> space in the<br/> correct location, if<br/> needed."])
    end
   class zip_container container1
   class zip container1
   class zip_target_0 targetItem
   class zip_label targetItem
    columns 1
    block:location_source_value_container:1
        columns 4
        block:location_source_value:1
        columns 1
            patient_usual_address_at_diagnosis_1["PATIENT USUAL ADDRESS<br/> (AT DIAGNOSIS)<br/> <br/> "]
            class patient_usual_address_at_diagnosis_1 sourceItem
            patient_usual_address_at_diagnosis_1["PATIENT USUAL ADDRESS<br/> (AT DIAGNOSIS)<br/> <br/> "]
            class patient_usual_address_at_diagnosis_1 sourceItem
            patient_usual_address_at_diagnosis_1["PATIENT USUAL ADDRESS<br/> (AT DIAGNOSIS)<br/> <br/> "]
            class patient_usual_address_at_diagnosis_1 sourceItem
            patient_usual_address_at_diagnosis_1["PATIENT USUAL ADDRESS<br/> (AT DIAGNOSIS)<br/> <br/> "]
            class patient_usual_address_at_diagnosis_1 sourceItem
            postcode_of_usual_address_at_diagnosis_1["POSTCODE OF USUAL<br/> ADDRESS (AT DIAGNOSIS)<br/> <br/> "]
            class postcode_of_usual_address_at_diagnosis_1 sourceItem
        end
        
        space
        
        location_source_value-->location_source_value_target_1["location_source_value"]

        location_source_value_label(["Separates text with<br/> newlines. Trim whitespace."])
    end
   class location_source_value_container container1
   class location_source_value container1
   class location_source_value_target_1 targetItem
   class location_source_value_label targetItem
    columns 1
    block:nhs_number_container:1
        columns 4
        block:nhs_number:1
        columns 1
            nhs_number_2["NHS NUMBER<br/> <br/> <br/> "]
            class nhs_number_2 sourceItem
        end
        
        space
        
        nhs_number-->nhs_number_target_2["nhs_number"]

        nhs_number_label(["Copy value"])
    end
   class nhs_number_container container1
   class nhs_number container1
   class nhs_number_target_2 targetItem
   class nhs_number_label targetItem
    columns 1
    block:address_1_container:1
        columns 4
        block:address_1:1
        columns 1
            patient_usual_address_at_diagnosis_3["PATIENT USUAL ADDRESS<br/> (AT DIAGNOSIS)<br/> <br/> "]
            class patient_usual_address_at_diagnosis_3 sourceItem
        end
        
        space
        
        address_1-->address_1_target_3["address_1"]

        address_1_label(["Convert text to<br/> uppercase. Trim whitespace."])
    end
   class address_1_container container1
   class address_1 container1
   class address_1_target_3 targetItem
   class address_1_label targetItem
    columns 1
    block:address_2_container:1
        columns 4
        block:address_2:1
        columns 1
            patient_usual_address_at_diagnosis_4["PATIENT USUAL ADDRESS<br/> (AT DIAGNOSIS)<br/> <br/> "]
            class patient_usual_address_at_diagnosis_4 sourceItem
        end
        
        space
        
        address_2-->address_2_target_4["address_2"]

        address_2_label(["Convert text to<br/> uppercase. Trim whitespace."])
    end
   class address_2_container container1
   class address_2 container1
   class address_2_target_4 targetItem
   class address_2_label targetItem
    columns 1
    block:city_container:1
        columns 4
        block:city:1
        columns 1
            patient_usual_address_at_diagnosis_5["PATIENT USUAL ADDRESS<br/> (AT DIAGNOSIS)<br/> <br/> "]
            class patient_usual_address_at_diagnosis_5 sourceItem
        end
        
        space
        
        city-->city_target_5["city"]

        city_label(["Convert text to<br/> uppercase. Trim whitespace."])
    end
   class city_container container1
   class city container1
   class city_target_5 targetItem
   class city_label targetItem
    columns 1
    block:county_container:1
        columns 4
        block:county:1
        columns 1
            patient_usual_address_at_diagnosis_6["PATIENT USUAL ADDRESS<br/> (AT DIAGNOSIS)<br/> <br/> "]
            class patient_usual_address_at_diagnosis_6 sourceItem
        end
        
        space
        
        county-->county_target_6["county"]

        county_label(["Convert text to<br/> uppercase. Trim whitespace."])
    end
   class county_container container1
   class county container1
   class county_target_6 targetItem
   class county_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdLocation%20mapping){: .btn }
## CdsStructuredLocation
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
    block:zip_container:1
        columns 4
        block:zip:1
        columns 1
            postcode_0["POSTCODE<br/> <br/> <br/> "]
            class postcode_0 sourceItem
        end
        
        space
        
        zip-->zip_target_0["zip"]

        zip_label(["Uppercase the postcode<br/> then insert the<br/> space in the<br/> correct location, if<br/> needed."])
    end
   class zip_container container1
   class zip container1
   class zip_target_0 targetItem
   class zip_label targetItem
    columns 1
    block:location_source_value_container:1
        columns 4
        block:location_source_value:1
        columns 1
            patient_usual_address_structured_1["PATIENT USUAL ADDRESS<br/> (STRUCTURED)<br/> <br/> "]
            class patient_usual_address_structured_1 sourceItem
            patient_usual_address_structured_1["PATIENT USUAL ADDRESS<br/> (STRUCTURED)<br/> <br/> "]
            class patient_usual_address_structured_1 sourceItem
            patient_usual_address_structured_1["PATIENT USUAL ADDRESS<br/> (STRUCTURED)<br/> <br/> "]
            class patient_usual_address_structured_1 sourceItem
            patient_usual_address_structured_1["PATIENT USUAL ADDRESS<br/> (STRUCTURED)<br/> <br/> "]
            class patient_usual_address_structured_1 sourceItem
            patient_usual_address_structured_1["PATIENT USUAL ADDRESS<br/> (STRUCTURED)<br/> <br/> "]
            class patient_usual_address_structured_1 sourceItem
            postcode_1["POSTCODE<br/> <br/> <br/> "]
            class postcode_1 sourceItem
        end
        
        space
        
        location_source_value-->location_source_value_target_1["location_source_value"]

        location_source_value_label(["Separates text with<br/> newlines. Trim whitespace."])
    end
   class location_source_value_container container1
   class location_source_value container1
   class location_source_value_target_1 targetItem
   class location_source_value_label targetItem
    columns 1
    block:nhs_number_container:1
        columns 4
        block:nhs_number:1
        columns 1
            nhs_number_2["NHS NUMBER<br/> <br/> <br/> "]
            class nhs_number_2 sourceItem
        end
        
        space
        
        nhs_number-->nhs_number_target_2["nhs_number"]

        nhs_number_label(["Copy value"])
    end
   class nhs_number_container container1
   class nhs_number container1
   class nhs_number_target_2 targetItem
   class nhs_number_label targetItem
    columns 1
    block:address_1_container:1
        columns 4
        block:address_1:1
        columns 1
            patient_usual_address_structured_3["PATIENT USUAL ADDRESS<br/> (STRUCTURED)<br/> <br/> "]
            class patient_usual_address_structured_3 sourceItem
            patient_usual_address_structured_3["PATIENT USUAL ADDRESS<br/> (STRUCTURED)<br/> <br/> "]
            class patient_usual_address_structured_3 sourceItem
        end
        
        space
        
        address_1-->address_1_target_3["address_1"]

        address_1_label(["Separates text with<br/> newlines. Trim whitespace."])
    end
   class address_1_container container1
   class address_1 container1
   class address_1_target_3 targetItem
   class address_1_label targetItem
    columns 1
    block:address_2_container:1
        columns 4
        block:address_2:1
        columns 1
            patient_usual_address_structured_4["PATIENT USUAL ADDRESS<br/> (STRUCTURED)<br/> <br/> "]
            class patient_usual_address_structured_4 sourceItem
        end
        
        space
        
        address_2-->address_2_target_4["address_2"]

        address_2_label(["Copy value"])
    end
   class address_2_container container1
   class address_2 container1
   class address_2_target_4 targetItem
   class address_2_label targetItem
    columns 1
    block:city_container:1
        columns 4
        block:city:1
        columns 1
            patient_usual_address_structured_5["PATIENT USUAL ADDRESS<br/> (STRUCTURED)<br/> <br/> "]
            class patient_usual_address_structured_5 sourceItem
        end
        
        space
        
        city-->city_target_5["city"]

        city_label(["Copy value"])
    end
   class city_container container1
   class city container1
   class city_target_5 targetItem
   class city_label targetItem
    columns 1
    block:county_container:1
        columns 4
        block:county:1
        columns 1
            patient_usual_address_structured_6["PATIENT USUAL ADDRESS<br/> (STRUCTURED)<br/> <br/> "]
            class patient_usual_address_structured_6 sourceItem
        end
        
        space
        
        county-->county_target_6["county"]

        county_label(["Copy value"])
    end
   class county_container container1
   class county container1
   class county_target_6 targetItem
   class county_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CdsStructuredLocation%20mapping){: .btn }
## CdsUnstructuredLocation
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
    block:zip_container:1
        columns 4
        block:zip:1
        columns 1
            postcode_0["POSTCODE<br/> <br/> <br/> "]
            class postcode_0 sourceItem
        end
        
        space
        
        zip-->zip_target_0["zip"]

        zip_label(["Uppercase the postcode<br/> then insert the<br/> space in the<br/> correct location, if<br/> needed."])
    end
   class zip_container container1
   class zip container1
   class zip_target_0 targetItem
   class zip_label targetItem
    columns 1
    block:location_source_value_container:1
        columns 4
        block:location_source_value:1
        columns 1
            postcode_1["POSTCODE<br/> <br/> <br/> "]
            class postcode_1 sourceItem
        end
        
        space
        
        location_source_value-->location_source_value_target_1["location_source_value"]

        location_source_value_label(["Copy value"])
    end
   class location_source_value_container container1
   class location_source_value container1
   class location_source_value_target_1 targetItem
   class location_source_value_label targetItem
   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;
   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;
   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;
end
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CdsUnstructuredLocation%20mapping){: .btn }
