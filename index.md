---
title: Home
layout: home
nav_order: 1
---

[![.NET](https://github.com/answerdigital/oxford-omop-data-mapper/actions/workflows/dotnet.yml/badge.svg)](https://github.com/answerdigital/oxford-omop-data-mapper/actions/workflows/dotnet.yml)

# About the Project

Oxford University Hospitals NHS FT (OUH) is building the Thames Valley and Surrey Secure Data Environment (SDE),  and needs to ensure that the data are available in a structure that is readily consumable by researchers with standard clinical research tooling. Alongside the national initiative for SDEs, OUH will be implementing the Observational Medical Outcomes Partnership (OMOP) data model, to support the ultimate goal of ensuring researchers have seamless access to essential information, at a low cost. 

The objectives of the project are to:
- **Implement the OMOP Data Model:** Deploy the OMOP data model for a scoped set of data.
- **Develop a Scalable, Documentable Process:** Build a comprehensive, scalable solution for defining and documenting mappings and transforming data into the OMOP model. This will be used for future phases of the SDE development, ensuring efficiency and consistency in subsequent initiatives.
- **Provide Value for OUH & Researchers:** Ensure that the implemented data model and associated processes facilitate easy and efficient access to essential data for researchers, aiding in the advancement of healthcare research and the improvement of patient outcomes.

# About the Team

Oxford University Hospitals (OUH) is a world renowned centre of clinical excellence and one of the largest NHS teaching trusts in the UK. It became a Foundation Trust on 1 October 2015 in order to work more effectively in partnership with its patients and local community to provide high quality healthcare.

Answer Digital is an award winning full-service digital consultancy based in Leeds, operating across the UK. With experience in the health, finance and retail sectors, and beyond, Answer specialises in helping clients bring their ideas to life, accelerating growth and delighting users. From software, services and processes; Answer has been working with clients for over 20 years to deliver growth, creating customer-centred digitally-driven experiences.

Following a successful initial discovery and proof of concept with Answer Digital in early 2023, OUH is progressing the implementation of OMOP with Answer, building a scalable, practical solution for both defining and documenting mappings and transforming data. 

# Use Case - Requirements

The following business requirements summarise the use case for the project:

- Increase efficiency in how data requests are served, increasing team capacity
- Enable researchers to be able to directly access data, to reduce the number of bespoke data products required
- Utilise the OMOP Common Data Model to standardise data, so the platform for direct access to data is in a widely understood format
- Increase efficiency in providing core data sets, to prioritise serving more complex data requests
- Increase understanding of the OMOP data model and its uses, to increase use, expand the scope of the data mapping and advise researchers appropriately
- Understand the open-source transformation tools which are available for querying the OMOP model, to make a decision on how researchers can directly access data
- Define a reusable process for mapping data to the OMOP Common Data Model, so that the mapping can be extended across multiple data sets and sources
- Understand the cycle and iterative process for revising the OMOP mapping, so that it can be kept in line with changes to the OMOP Common Data Model
- Make the OMOP mapping process sustainable, so that data mapping over multiple sources can be continued long-term
- To have clear records of data mapping definitions, to understand the processing behind the OMOP data model
- Ensure an initial tightly-scoped functional area is mapped to the OMOP data model based on user (researcher) requirements, to understand the process, feasibility and outcomes
- Ensure the initial data mapping scope is as generic as possible, so that it can serve multiple research areas
- Ensure mapped data is de-identified, so that it is anonymous for research use, aligning with data protection regulations
- Ensure the OMOP mapping process considers how data can be mapped from multiple sources and locations, so that the common data model and query platform can include data from multiple sites, but that data can be traced back to its source
- To be able to re-identify records, to trace it back to its source to manage scenarios such as opt out
- Implement clear governance to validate data mapping definitions, so that the data provided to researchers is accurate with minimal loss of detail
- Understand the FlowEHR architecture model and how it could be implemented for OUH, to establish recommendations for implementing ETL processes to map data to the OMOP model
- Ensure access to clinical data is as pure as possible
- Implement clear guidance so that researchers can clearly understand how to directly access data
- Ensure researchers can directly obtain high-level figures for research data, to establish whether a research project is viable
- Make data standardised, so researchers can easily gather insight across multiple data sources
- Share data mappings with other OMOP research groups outside of our trust/SDE environment, so that they can benefit from the work already done

# Current Aims

The current scope for the transformation at source data level is as follows:

| Source Data Set                              | Version(s) Supported                                |
|----------------------------------------------|-----------------------------------------------------|
| CDS - Commissioning Data Sets                | EMIS Infoflex 6.2 fixed width multiline text format |
| COSD - Cancer Outcomes and Services Dataset  | v8-1 and v9-0-1 xml formats                         |
| SACT - Systemic Anti-Cancer Therapy Data Set | v3.0                                                |
| RTDS - Radiotherapy Data Set                 | James please add                                    |

The current scope for the transformation at table and field level is as follows:

<table>
<tbody>
<tr>
<td>
<p><strong>OMOP Table</strong></p>
</td>
<td>
<p><strong>In Scope Fields</strong></p>
</td>
</tr>
<tr>
<td>
<p><span style="font-weight: 400;">Condition Occurrence</span></p>
</td>
<td>
<ul>
<li style="font-weight: 400;"><span style="font-weight: 400;">condition_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">condition_occurrence_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">condition_start_date</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">condition_type_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">person_id</span></li>
</ul>
</td>
</tr>
<tr>
<td>
<p><span style="font-weight: 400;">Death</span></p>
</td>
<td>
<ul>
<li style="font-weight: 400;"><span style="font-weight: 400;">death_date</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">person_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">death_type_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">cause_concept_id</span></li>
</ul>
</td>
</tr>
<tr>
<td>
<p><span style="font-weight: 400;">Drug Exposure</span></p>
</td>
<td>
<ul>
<li style="font-weight: 400;"><span style="font-weight: 400;">drug_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">drug_exposure_end_date</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">drug_exposure_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">drug_exposure_start_date</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">drug_type_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">person_id</span></li>
</ul>
</td>
</tr>
<tr>
<td>
<p><span style="font-weight: 400;">Measurement</span></p>
</td>
<td>
<ul>
<li style="font-weight: 400;"><span style="font-weight: 400;">measurement_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">measurement_date</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">measurement_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">measurement_type_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">person_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">value_as_number</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">value_as_concept_id</span></li>
</ul>
</td>
</tr>
<tr>
<td>
<p><span style="font-weight: 400;">Observation</span></p>
</td>
<td>
<ul>
<li style="font-weight: 400;"><span style="font-weight: 400;">observation_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">observation_date</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">observation_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">observation_type_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">person_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">value_as_number</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">value_as_concept_id</span></li>
</ul>
</td>
</tr>
<tr>
<td>
<p><span style="font-weight: 400;">Person</span></p>
</td>
<td>
<ul>
<li style="font-weight: 400;"><span style="font-weight: 400;">ethnicity_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">gender_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">person_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">race_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">year_of_birth</span></li>
</ul>
</td>
</tr>
<tr>
<td>
<p><span style="font-weight: 400;">Procedure Occurrence</span></p>
</td>
<td>
<ul>
<li style="font-weight: 400;"><span style="font-weight: 400;">person_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">procedure_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">procedure_date</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">procedure_occurrence_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">procedure_type_concept_id</span></li>
</ul>
</td>
</tr>
<tr>
<td>
<p><span style="font-weight: 400;">Visit Occurrence</span></p>
</td>
<td>
<ul>
<li style="font-weight: 400;"><span style="font-weight: 400;">person_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">visit_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">visit_end_date</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">visit_occurrence_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">visit_start_date</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">visit_type_concept_id</span></li>
</ul>
</td>
</tr>
<tr>
<td>
<p><span style="font-weight: 400;">Visit Detail</span></p>
</td>
<td>
<ul>
<li style="font-weight: 400;"><span style="font-weight: 400;">visit_occurrence_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">person_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">visit_concept_id</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">visit_start_date</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">visit_end_date</span></li>
<li style="font-weight: 400;"><span style="font-weight: 400;">visit_type_concept_id</span></li>
</ul>
</td>
</tr>
</tbody>
</table>

# Supported Transformations

| OMOP Table           | CDS | COSD | RTDS | SACT |
|----------------------|-----|------|------|------|
| *Location*            |  ✔ | ✔   | ✔   | ✔   |
| *Person*              | ✔️  | ✔️   | ✔️   | ✔️   |
| *Condition*Occurrence | ✔️  | ✔️   | ✔️   | ✔️   |
| *Visit*Occurrence     | ✔️  |      |      |      |
| *Visit*Details        | ✔️  |      |      |      |
| *Measurement*         | ✔️ ❗ |      |      |      |
| *Death*               | ✔️ |      |      |      |
| *Procedure*Occurrence | ✔️  |      |      |      |
| *Drug*Exposure        | ✔  |      |      |      |
| *Observation*         | ✔  |      |      |      |


# Future Aims

The future aims for the project are to extend to include:

- Additional national datasets, made available in the OMOP schema with supporting documentation in the TVS SDE environment
- Relevant trust-specific datasets (e.g. EPR, chemotherapy prescribing system, cancer registries), made available in the OMOP schema with supporting documentation in the TVS SDE environment

# Methodology and Introduction to the Tooling

Answer Digital have built a custom tool for dynamically generating documentation, through code in an open source format. 

[Automatically Generated OMOP Data Transformation Documentation]({% link docs/transformation-documentation/transformation-documentation.md %}#prune-command){: .btn .btn-blue }

The tool has a heavy emphasis on the documentation in order to provide the highest level of data fidelity to researchers, enabling them to self-serve as much as possible.

After considering other off the shelf tooling such as White Rabbit, DBT, Rabbit in a Hat, it became clear that our requirement to tightly couple documentation with the respective mapping would not be met entirely. To ensure the requirement could be fully met, Answer recommended building a custom tool. The tool is:
- Self documenting
- Links each transform to its own documentation, and does not allow these to be separated
- Is fully testable through unit tests
