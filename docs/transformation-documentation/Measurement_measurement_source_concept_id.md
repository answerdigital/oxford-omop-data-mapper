---
layout: default
title: measurement_source_concept_id
parent: Measurement
grand_parent: Transformation Documentation
has_toc: false
---
# measurement_source_concept_id
### Sus OP  Measurement
Source column  `DiagnosisICD`.
Resolve ICD10 codes to standard or non standard OMOP concepts. If code cannot be mapped, map using the parent code.

* `DiagnosisICD` ICD10 diagnosis code [PRIMARY DIAGNOSIS (ICD)](https://www.datadictionary.nhs.uk/data_elements/primary_diagnosis__icd_.html)

```sql
select
    distinct
        d.DiagnosisICD,
        op.GeneratedRecordIdentifier,
        op.NHSNumber,
        op.CDSActivityDate
from omop_staging.sus_OP_ICDDiagnosis d
    inner join omop_staging.sus_OP op
        on d.MessageId = op.MessageId
where op.NHSNumber is not null
	and AttendedorDidNotAttend in ('5','6')
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20Sus%20OP%20%20Measurement%20mapping){: .btn }
### Sus APC  Measurement
Source column  `DiagnosisICD`.
Resolve ICD10 codes to standard or non standard OMOP concepts. If code cannot be mapped, map using the parent code.

* `DiagnosisICD` ICD10 diagnosis code [PRIMARY DIAGNOSIS (ICD)](https://www.datadictionary.nhs.uk/data_elements/primary_diagnosis__icd_.html)

```sql
select
    distinct
        d.DiagnosisICD,
        apc.GeneratedRecordIdentifier,
        apc.NHSNumber,
        apc.CDSActivityDate
from omop_staging.sus_ICDDiagnosis d
    inner join omop_staging.sus_APC apc
        on d.MessageId = apc.MessageId
where apc.NHSNumber is not null
order by
	d.DiagnosisICD,
    apc.GeneratedRecordIdentifier,
    apc.NHSNumber,
    apc.CDSActivityDate
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20Sus%20APC%20%20Measurement%20mapping){: .btn }
### Oxford Lab Measurement
Source column  `EVENT`.
OXford Lab Test Lookup lookup


|EVENT|measurement_source_concept_id|notes|
|------|-----|-----|
|Osmolality, urine|40780701|Osmolality | Urine|
|Amylase:creatinine ratio, urine|40655930|Amylase/Creatinine|Ratio|Urine|
|Volume, 24hr urine|3012565|Volume of 24 hour Urine|
|Immunofixation, urine|3017704|Immunofixation for Urine|
|KFRE 2-year risk of kidney failure|36203453|Kidney failure 2-year risk [Likelihood] by KFRE|
|KFRE 5-year risk of kidney failure|36203454|Kidney failure 5-year risk [Likelihood] by KFRE|
|Protein:creatinine ratio, urine|40656423|Protein/Creatinine|Ratio|Urine|
|Thrombin time, blood|37047420|Thrombin time | Blood | Coagulation|
|Volume, urine|3036603|Volume of Urine|
|Red Blood Cell Distribution Width|40773752|Erythrocyte Distribution Width | Red Blood Cells|
|Reducing substance, urine|40778733|Reducing substances | Urine|
|Porphobilinogen:creatinine ratio, urine|40656381|Porphobilinogen/Creatinine|Substance Ratio|Urine|
|Galactose-1-P Uridyl Transferase, blood|3004179|Galactose 1 phosphate uridyl transferase [Presence] in Blood|
|3-methoxytyramine excretion, 24hr urine|40654219|3-Methoxytyramine|24 hours|Urine|
|Beta trace protein, Fluid|40778693|Beta-trace protein | Body fluid|
|Albumin:creatinine ratio, urine|40655886|Albumin/Creatinine|Ratio|Urine|
|O_Volume, 24hr urine|3012565|Volume of 24 hour Urine|
|pH, urine|40790554|pH | Urine|
|O_Osmolality, urine|40780701|Osmolality | Urine|
|Red blood cell folate, blood|40783461|Folate | Red Blood Cells|
|Porphyrin:creatinine ratio, urine|40656386|Porphyrins/Creatinine|Mass Ratio|Urine|
|3-methoxytyramine:creat ratio, urine|40655860|3-Methoxytyramine/Creatinine|Substance Ratio|Urine|
|Amylase output, 24hr urine|3043288|Amylase [Presence] in 24 hour Urine|
|Amphetamine screen, urine|3000144|Amphetamine [Presence] in Urine by Screen method|
|Cannabinoids screen, urine|3006932|Cannabinoids [Presence] in Urine by Screen method|
|Porphyrins comment, urine|40785125|Porphyrins | Urine|
|Citrate output, 24hr urine|40654599|Citrate|24 hours|Urine|
|Amylase level, urine|40796528|Amylase | Urine|
|Ganglioside GQ1b Ab, CSF|36208943|Ganglioside GQ1b | Cerebral spinal fluid|
|Oxalate output, 24hr urine|40655231|Oxalate|24 hours|Urine|
|Amphiphysin, CSF|36205822|Amphiphysin | Cerebral spinal fluid|
|Porphobilinogen level, urine|3034719|Porphobilinogen [Presence] in Urine|
|3-Methoxytyramine, plasma|3030408|3-Methoxytyramine [Moles/volume] in Serum or Plasma|
|Ganglioside GM1 Ab, CSF|40791379|Ganglioside GM1 Ab | Cerebral spinal fluid|
|Methadone level, urine|40790125|Methadone | Urine|
|Mean platelet volume, blood|37071701|Platelet mean volume | Blood | Hematology and Cell counts|
|Beta-2 microglobulin level, serum|3047079|Beta-2-Microglobulin [Presence] in Serum|
|Citrate:creatinine ratio, urine|40656019|Citrate/Creatinine|Mass Ratio|Urine|
|Iohexol clearance|3966002|Iohexol renal clearance in Serum or Plasma or Urine|
|CD16+ CD56+ count, blood|3020358|CD16+CD56+ cells [#/volume] in Blood|
|O_Albumin:creatinine ratio, urine|40655886|Albumin/Creatinine|Ratio|Urine|
|Myoglobin level, urine|40793068|Myoglobin | Urine|
|Urobilinogen level, urine|40776585|Urobilinogen | Urine|
|Aldosterone:renin ratio, blood|3011145|Aldosterone/Renin [Ratio] in Plasma|
|Reptilase time, blood|3005308|Reptilase time|
|Isocyanate TDI IgE level, blood|40764039|Isocyanate TDI IgE Ab/IgE total in Serum|
|Cardiolipin IgM Ab level, blood|3004874|Cardiolipin IgM Ab [Interpretation] in Serum|
|Immature Granulocytes count, blood|37042766|Immature granulocytes | Blood | Hematology and Cell counts|
|KRAS Mutation Analysis|1260454|KRAS Somatic mutation analysis | Tumor | Mutations|
|Chloride, sweat|40780474|Chloride | Sweat|
|Isocyanate HDI IgE level, blood|40764038|Isocyanate HDI IgE Ab/IgE total in Serum|
|Fibroblast growth factor 23, plasma|3052200|Fibroblast growth factor 23 [Units/volume] in Plasma|
|Lysozyme level, urine|3008343|Lysozyme [Mass/volume] in Urine|
|O_Red blood cell folate, blood|40783461|Folate | Red Blood Cells|
|Glucose level, urine|40773470|Glucose | Urine|
|Magnesium output, 24hr urine|3006828|Magnesium [Mass/volume] in 24 hour Urine|
|Liver and kidney microsomal Ab|40786590|Liver Kidney Microsomal Ab | Bld-Ser-Plas|
|Tissue transglutaminase IgG Ab, blood|3041421|Tissue transglutaminase IgG Ab [Presence] in Serum|
|Calcium output, 24hr urine|3017730|Calcium [Mass/volume] in 24 hour Urine|
|Warfarin Dose|37070265|Warfarin | Dose | Drug doses|
|Urea output, 24hr urine|3008071|Urine output 24 hour|
|Bilirubin level, urine|40796873|Bilirubin | Urine|
|Bicarbonate level, urine|40790307|Bicarbonate | Urine|
|CD16+ CD56+ % NK cells, blood|3027831|CD3-CD16+CD56+ (Natural killer) cells/cells in Blood|
|APTT, blood|37037324|aPTT | Blood | Coagulation|
|Mi-2 antibody by Immunoblot|40759862|Mi-2 Ab [Presence] in Serum by Immunoblot|
|Viscosity level, blood|3028652|Viscosity of Blood|
|Chloride level, urine|40776710|Chloride | Urine|
|Potassium output, 24hr urine|3040170|Potassium [Mass/time] in 24 hour Urine|
|Phosphate output, 24hr urine|3025776|Phosphate [Mass/volume] in 24 hour Urine|
|Budgerigar serum protein IgE, blood|37042826|Budgerigar serum proteins IgE | Serum | Allergy|
|Citrulline level, plasma|3034087|Citrulline [Presence] in Serum or Plasma|
|Benzodiazepine level, urine|40786759|Benzodiazepines | Urine|
|Cortisol level, urine|40773225|Cortisol | Urine|
|Vancomycin timing, serum|40655618|Vancomycin|Moment in time|Serum or Plasma|
|Creatinine output, 24hr urine|3001349|Creatinine [Mass/volume] in 24 hour Urine|
|Tissue transglutaminase IgA Ab, blood|3030555|Tissue transglutaminase IgA Ab [Presence] in Serum|
|O_Isocyanate TDI IgE level, blood|40764039|Isocyanate TDI IgE Ab/IgE total in Serum|
|O_Oxalate output, 24hr urine|40655231|Oxalate|24 hours|Urine|
|CD8 CD27-CD28- T Cells, blood|21493670|CD27- cells/CD3+CD8+ (T8 suppressor cells) cells in Blood|
|11-Deoxycortisol level, serum|40758596|11-Deoxycortisol [Moles/volume] in Serum or Plasma --baseline|
|O_pH, urine|3015736|pH of Urine|
|Creatinine level, urine|40773228|Creatinine | Urine|
|Urobilin level, urine|40787391|Urobilin | Urine|
|CD8 CD27+CD28- T Cells, blood|21493670|CD27- cells/CD3+CD8+ (T8 suppressor cells) cells in Blood|
|Protein output, 24hr urine|3011705|Protein [Mass/volume] in 24 hour Urine|
|Collection period, urine|3016750|Collection duration of Urine|
|O_Urobilinogen level, urine|40776585|Urobilinogen | Urine|
|O_Isocyanate HDI IgE level, blood|40764038|Isocyanate HDI IgE Ab/IgE total in Serum|
|Amino acids level, urine|40779951|Amino Acids | Urine|
|Candida albicans IgE level, blood|40763999|Candida albicans IgE Ab/IgE total in Serum|
|O_Citrate output, 24hr urine|40654599|Citrate|24 hours|Urine|
|Penicillin V IgE level, blood|3039829|Penicillin V IgE Ab/IgE total in Serum|
|Thiopurine methyltransferase, blood|40773777|Thiopurine Methyltransferase | Red Blood Cells|
|Cardiolipin IgG Ab level, blood|3018499|Cardiolipin IgG Ab [Interpretation] in Serum|
|Androstenedione level, serum|3044426|Androstenedione [Presence] in Serum or Plasma|
|CD8 CD27+CD28+ T Cells, blood|21493670|CD27- cells/CD3+CD8+ (T8 suppressor cells) cells in Blood|
|Urate output, 24hr urine|3008071|Urine output 24 hour|
|Sodium output, 24hr urine|3004907|Sodium [Mass/volume] in 24 hour Urine|
|Chloride output, 24hr urine|3041519|Chloride [Mass/time] in 24 hour Urine|
|Osmolality, fluid|40773474|Osmolality | Body Fluid|
|Thrombin time reference|3036489|Thrombin time|
|O_Urea output, 24hr urine|3008071|Urine output 24 hour|
|Biotinidase level, plasma|3046027|Biotinidase [Presence] in Serum or Plasma|
|Magnesium level, urine|40793199|Magnesium | Urine|
|PML antibody by Immunoblot|40759872|PML Ab [Presence] in Serum by Immunoblot|
|Phenylalanine level, blood|3030135|Phenylalanine [Presence] in Blood|
|Opiate level, urine|40773635|Opiates | Urine|
|Thyroglobulin Ab level, serum|3024857|Thyroglobulin Ab [Presence] in Serum|
|Haemoglobin|40793300|Hemoglobin | Blood arterial|
|Chromium level, plasma|3008269|Chromium [Mass/volume] in Serum or Plasma|
|Protein electrophoresis, urine|3044927|Protein electrophoresis panel - Urine|
|Citrate level, urine|40796531|Citrate | Urine|
|Potassium level, urine|40773224|Potassium | Urine|
|Urine Metanephrine comment|40793066|Metanephrine | Urine|
|Everolimus level, blood|3030703|Everolimus [Mass/volume] in Blood|
|Lobster IgE level, blood|3041475|Lobster IgE Ab/IgE total in Serum|
|O_Thrombin time, blood|37047420|Thrombin time | Blood | Coagulation|
|O_Creatinine output, 24hr urine|3008071|Urine output 24 hour|
|Helicobacter pylori urea breath test|3011630|Helicobacter pylori [Presence] in Stomach by urea breath test|
|Ethanol level, urine|3010109|Ethanol [Presence] in Urine|
|Clobazam level, blood|40762688|cloBAZam [Mass/volume] in Blood|
|Sex hormone binding globulin, blood|3011099|Sex hormone binding globulin [Mass/volume] in Serum or Plasma|
|Guinea pig epithelium IgE level, blood|3041346|Guinea pig epithelium IgE Ab/IgE total in Serum|
|Baker's yeast IgE level, blood|3039011|Baker's yeast IgE Ab/IgE total in Serum|
|O_Porphyrins, faeces|3035602|Porphyrins [Presence] in Stool|
|Brazil nut IgE level, blood|3042333|Brazil Nut IgE Ab/IgE total in Serum|
|Parsley IgE level, blood|40764056|Parsley IgE Ab/IgE total in Serum|
|O_Potassium output, 24hr urine|3040170|Potassium [Mass/time] in 24 hour Urine|
|O_Budgerigar serum protein IgE, blood|37042826|Budgerigar serum proteins IgE | Serum | Allergy|
|O_Chromium level, blood|3005962|Chromium [Moles/volume] in Blood|
|Adenosine deaminase level, fluid|40794411|Adenosine Deaminase | Body Fluid|
|O_Magnesium output, 24hr urine|3006828|Magnesium [Mass/volume] in 24 hour Urine|
|Acylcarnitine profile, blood|3046449|Acylcarnitine [Presence] in Blood|
|O_Candida albicans IgE level, blood|40763999|Candida albicans IgE Ab/IgE total in Serum|
|O_Ganglioside GQ1b Ab, blood|3021365|Ganglioside GQ1b Ab [Presence] in Serum|
|O_Calcium output, 24hr urine|3017730|Calcium [Mass/volume] in 24 hour Urine|
|Lettuce IgE level, blood|40764041|Lettuce IgE Ab/IgE total in Serum|
|Barbiturate level, urine|40776928|Barbiturates | Urine|
|O_Urate output, 24hr urine|3008071|Urine output 24 hour|
|Cobalt level, plasma|3028447|Cobalt [Mass/volume] in Serum or Plasma|
|Albumin level, urine|40773229|Albumin | Urine|
|Urea level, urine|40773808|Urea | Urine|
|CD18 expression, blood|36660405|CD18 cells [Presence] in Blood|
|Latex IgE level, blood|37021598|Latex Ige | Blood | Allergy|
|CD4 CD27+CD28+ T Cells, blood|3034246|CD4+CD28+ cells/cells in Blood|
|CD21 Low B Cells, blood|3024645|CD21 cells/cells in Blood|
|Spinach IgE level, blood|40764078|Spinach IgE Ab/IgE total in Serum|
|Avocado IgE level, blood|40764055|Avocado IgE Ab/IgE total in Serum|
|Walnut IgE level, blood|3041778|Walnut IgE Ab/IgE total in Serum|
|Specific Gravity Urine Dipstick|3033543|Specific gravity of Urine|
|CD4 CD27-CD28+ T Cells, blood|21493678|CD27-CD45RA+ cells/CD3+CD4+ (T4 helper) cells in Blood|
|Cocaine metabolite level, urine|40794979|Cocaine metabolites.other | Urine|
|Vacuolated lymphocytes, blood|40763527|Lymphocytes.vacuolated [Presence] in Blood by Light microscopy|
|Blue mussel IgE level, blood|3038242|Blue mussel IgE Ab/IgE total in Serum|
|Serum viscosity, blood|3010493|Viscosity of Serum|
|Pine nut IgE level, blood|40764091|Pine Nut IgE Ab/IgE total in Serum|
|Sesame seed IgE level, blood|40764074|Sesame Seed IgE Ab/IgE total in Serum|
|Promyelocyte count, blood|37023259|Promyelocytes | Blood | Hematology and Cell counts|
|Sirolimus level, blood|3021374|Sirolimus [Mass/volume] in Blood|
|Hamster epithelium IgE level, blood|3044511|Hamster epithelium IgE Ab/IgE total in Serum|
|O_Bilirubin level, urine|40796873|Bilirubin | Urine|
|Ganglioside GQ1b antibody, blood|3021365|Ganglioside GQ1b Ab [Presence] in Serum|
|O_Porphyrin screen, urine|40785125|Porphyrins | Urine|
|CD34 level, blood|3023256|CD34 cells/cells in Blood|
|Lambda light chain level, blood|3004640|Lambda light chains [Mass/volume] in Serum or Plasma|
|O_Drugs of abuse screen, urine|42870589|Drugs of abuse panel - Urine by Screen method|
|O_Organic acids level, urine|3018363|Organic acids [Presence] in Urine|
|Aspergillus fumigatus IgE level, blood|3047468|Aspergillus fumigatus IgE Ab/IgE total in Serum|
|Pyruvate kinase assay, blood|3015478|Pyruvate kinase [Presence] in Blood|
|O_Lymphocyte proliferation screen, blood|40762156|Lymphocyte proliferation panel - Blood|
|Urine volume collected|3036603|Volume of Urine|
|Cheddar cheese IgE level, blood|40761038|Cheese cheddar type IgE Ab/IgE total in Serum|
|Osmolality, blood|40773474|Osmolality | Body Fluid|
|O_Viscosity level, blood|3028652|Viscosity of Blood|
|PL-7 antibody (immunoblot), blood|40759863|PL-7 Ab [Presence] in Serum by Immunoblot|
|O_Penicillin V IgE level, blood|3039829|Penicillin V IgE Ab/IgE total in Serum|
|Very Long Chain Fatty Acids Comment|40789858|Fatty Acids.Very Long Chain | Bld-Ser-Plas|
|Zinc level, plasma|3044223|Zinc [Presence] in Serum or Plasma|
|O_Reducing substance, urine|40778733|Reducing substances | Urine|
|Transferrin Saturation|3007987|Deprecated Transferrin saturation in Serum or Plasma|
|Beta trace protein, Serum|3052056|Beta-trace protein [Mass/volume] in Serum or Plasma|
|Cyclic citrullinated peptide Ab, blood|3041391|Cyclic citrullinated peptide Ab [Presence] in Serum|
|IGLON5 Antibodies, CSF|36032743|IgLON5 IgG | Cerebral spinal fluid | Serology - non-micro|
|Seminal fluid IgE level, blood|37062039|Seminal fluid IgE | Serum | Allergy|
|CD4 CD27-CD28- T Cells, blood|21493678|CD27-CD45RA+ cells/CD3+CD4+ (T4 helper) cells in Blood|
|Oxalate level, urine|40776688|Oxalate | Urine|
|Carrot IgE level, blood|3035253|Carrot IgE Ab/IgE total in Serum|
|Ammonia level, blood|3030942|Ammonia [Mass/volume] in Blood|
|Cashew nut IgE level, blood|3052099|Cashew nut IgE Ab/IgE total in Serum|
|Beta-hydroxybutyrate level, blood|1092084|Beta hydroxybutyrate [Moles/volume] in Blood|
|Gastrin level,plasma|3009927|Gastrin [Mass/volume] in Serum or Plasma|
|Pancreatic polypeptide level, plasma|3023589|Pancreatic polypeptide [Mass/volume] in Serum or Plasma|
|Lactate dehydrogenase level, fluid|40783464|Lactate Dehydrogenase | Body Fluid|
|O_11-Deoxycortisol level, blood|3007719|11-Deoxycortisol [Mass/volume] in Serum or Plasma|
|Intrinsic factor Ab level, blood|3022194|Intrinsic factor Ab [Presence] in Serum|
|PL-12 antibody (immunoblot), blood|40759864|PL-12 Ab [Presence] in Serum by Immunoblot|
|Scallop IgE level, blood|3041779|Scallop IgE Ab/IgE total in Serum|
|IgG:albumin ratio, CSF|3007798|IgG/Albumin [Mass Ratio] in Cerebral spinal fluid|
|Oysters IgE level, blood|40764053|Oyster IgE Ab/IgE total in Serum|
|Smooth muscle IgG Ab level, blood|3017391|Smooth muscle IgG Ab [Presence] in Serum|
|Prostate specific Ag, blood|40784703|Prostate Specific Ag | Body Fluid|
|Chromogranin A level, plasma|3014702|Chromogranin A [Moles/volume] in Serum or Plasma|
|Penicillin G IgE level, blood|37039743|Penicillin G IgE | Serum | Allergy|
|O_Guinea pig epithelium IgE level, blood|3041346|Guinea pig epithelium IgE Ab/IgE total in Serum|
|Pineapple IgE level, blood|40763977|Pineapple IgE Ab/IgE total in Serum|
|Chromium level, serum|3000321|Chromium [Moles/volume] in Serum or Plasma|
|O_Sodium output, 24hr urine|3004907|Sodium [Mass/volume] in 24 hour Urine|
|Centromere Ab level, blood|3033099|Centromere Ab [Titer] in Serum|
|Calcium level, urine|40789884|Calcium | Urine|
|Myeloperoxidase Ab level, blood|3016080|Myeloperoxidase Ab [Presence] in Serum|
|Cryofibrinogen, blood|37034712|Cryofibrinogen | Blood | Chemistry - non-challenge|
|Voltage-gated K channel Ab, CSF|40792304|Voltage-gated potassium channel Ab | Cerebral spinal fluid|
|O_Amylase level, urine|40796528|Amylase | Urine|
|Phenobarbitone screen, blood|1091947|Mephobarbital and PHENobarbital panel - Blood|
|Mushroom IgE level, blood|40763970|Mushroom IgE Ab/IgE total in Serum|
|O_Protein:creatinine ratio, urine|40656423|Protein/Creatinine|Ratio|Urine|
|Molybdenum level, blood|40758684|Molybdenum [Moles/volume] in Blood|
|O_Budgerigar (serum) IgG Ab, blood|1988811|Budgerigar droppings IgG Ab [Mass/volume] in Serum|
|Celery IgE level, blood|40763979|Celery IgE Ab/IgE total in Serum|
|Free kappa:lambda light chain ratio|3053209|Kappa light chains.free/Lambda light chains.free [Mass Ratio] in Serum|
|Rabbit epithelium IgE level, blood|3038805|Rabbit epithelium IgE Ab/IgE total in Serum|
|OJ antibody (immunoblot), blood|42870556|OJ Ab [Presence] in Serum by Immunoblot|
|Ethanol level, blood|3025643|Ethanol [Mass/volume] in Blood|
|Renin level, plasma|3037310|Renin [Mass/volume] in Plasma|
|Urobilinogen (dipstick), urine|37034848|Urobilinogen | Urine | Urinalysis|
|Pistachio IgE level, blood|3039295|Pistachio IgE Ab/IgE total in Serum|
|Sodium level, urine|40783249|Sodium | Urine|
|Promyelocyte %, blood|3022709|Promyelocytes [#/volume] in Blood|
|Manganese level, blood|3020923|Manganese [Mass/volume] in Blood|
|Lamotrigine level, plasma|3023261|lamoTRIgine [Mass/volume] in Serum or Plasma|
|Normetadrenaline output, 24hr urine|3003700|Normetanephrine [Mass/volume] in 24 hour Urine|
|Nucleated red blood cell count, blood|37040514|Nucleated erythrocytes | Blood | Hematology and Cell counts|
|Pigeon serum proteins IgG antibodies|37076646|Pigeon serum IgG | Serum | Allergy|
|Trout IgE level, blood|40764050|Trout IgE Ab/IgE total in Serum|
|Turkey serum proteins IgG Ab|40763466|Turkey IgG Ab [Mass/volume] in Serum|
|Glucagon level, plasma|3023436|Glucagon [Mass/volume] in Serum or Plasma|
|Calcium level, blood|3027495|Calcium [Presence] in Blood|
|Fructosamine level serum|3019839|Fructosamine [Moles/volume] in Serum or Plasma|
|Rat urine IgE level, blood|40764107|Rat urine proteins IgE Ab/IgE total in Serum|
|Kappa light chain level, blood|3019812|Kappa light chains [Mass/volume] in Serum or Plasma|
|Isocyanate MDI IgE level, blood|37058807|Isocyanate MDI IgE | Serum | Allergy|
|O_Vacuolated lymphocytes, blood|40782169|Lymphocytes.vacuolated | Bld-Ser-Plas|
|O_Blue mussel IgE level, blood|3038242|Blue mussel IgE Ab/IgE total in Serum|
|O_Lettuce IgE level, blood|40764041|Lettuce IgE Ab/IgE total in Serum|
|CD3 level, blood|3011412|CD3 cells [#/volume] in Blood|
|Collection volume, urine|3036603|Volume of Urine|
|Aspartate aminotransferase level, blood|3010587|Aspartate aminotransferase [Presence] in Serum or Plasma|
|Oxalate comment, urine|40776688|Oxalate | Urine|
|O_Ethanol level, urine|3010109|Ethanol [Presence] in Urine|
|Angiotensin-converting enzyme, blood|3036335|Angiotensin converting enzyme [Enzymatic activity/volume] in Blood|
|O_Biotinidase level, blood|3024509|Biotinidase [Presence] in Blood|
|Mugwort w6 IgE level, blood|3040902|Mugwort IgE Ab/IgE total in Serum|
|Inhibin B level, blood|3038854|Inhibin B [Presence] in Serum or Plasma|
|Jak-2 Exon 12 by sequencing, blood|1988162|JAK2 gene exon 12 full mutation analysis in Blood or Tissue by Sequencing|
|TCR delta and gamma %, blood|3029686|TCR gamma delta cells [#/volume] in Blood|
|Caffeine level, plasma|3022695|Caffeine [Mass/volume] in Serum or Plasma|
|Prothrombin time, blood|37044890|Prothrombin time (PT) | Blood | Coagulation|
|Lemon IgE level, blood|40764007|Lemon IgE Ab/IgE total in Serum|
|Lactate level, CSF|40655009|Lactate|Moment in time|CSF|
|Aldosterone level, plasma|3011337|Aldosterone [Mass/volume] in Serum or Plasma|
|Hazelnut IgE level, blood|3041451|Hazelnut IgE Ab/IgE total in Serum|
|Amylase level, fluid|3043024|Amylase [Presence] in Body fluid|
|Magnesium level, blood|3003341|Magnesium [Presence] in Blood|
|Ketones (dipstick), urine|37077567|Ketones | Urine | Urinalysis|
|pH, fluid|40793843|pH | Body Fluid|
|Sp100antibody by Immunoblot|40759873|sp100 Ab [Presence] in Serum by Immunoblot|
|Urine cortisol comment|40773225|Cortisol | Urine|
|O_Isocyanate MDI IgE level, blood|37058807|Isocyanate MDI IgE | Serum | Allergy|
|Metadrenaline output, 24hr urine|40655092|Metanephrines|24 hours|Urine|
|Ku antibody (immunoblot), blood|42870555|Ku Ab [Presence] in Serum by Immunoblot|
|O_Spinach IgE level, blood|40764078|Spinach IgE Ab/IgE total in Serum|
|O_Avocado IgE level, blood|40764055|Avocado IgE Ab/IgE total in Serum|
|O_Bicarbonate level, urine|40790307|Bicarbonate | Urine|
|Grape IgE level, blood|3044470|Grape IgE Ab/IgE total in Serum|
|O_Lobster IgE level, blood|3041475|Lobster IgE Ab/IgE total in Serum|
|O_Seminal fluid IgE level, blood|37062039|Seminal fluid IgE | Serum | Allergy|
|O_Thiopurine methyltransferase, blood|40773777|Thiopurine Methyltransferase | Red Blood Cells|
|Volume (referral lab), urine|40656452|Specimen volume|Volume|Urine|
|Inhibin A level, blood|3007745|Inhibin A [Presence] in Serum or Plasma|
|Plasma cell count, blood|37073669|Plasma cells | Blood | Hematology and Cell counts|
|Plum IgE level, blood|3046172|Plum IgE Ab/IgE total in Serum|
|O_Parsley IgE level, blood|40764056|Parsley IgE Ab/IgE total in Serum|
|Sunflower seed IgE level, blood|40764033|Sunflower Seed IgE Ab/IgE total in Serum|
|Salmon IgE level, blood|3039263|Salmon IgE Ab/IgE total in Serum|
|Reticulocyte count, blood|3023520|Reticulocytes [#/volume] in Blood|
|Bicarbonate level, blood|40790303|Bicarbonate | Blood mixed venous|
|Haemoglobin A2 level, blood|3017572|Hemoglobin A2 [Presence] in Blood|
|Basophil count, blood|3006315|Basophils [#/volume] in Blood|
|O_Prostate specific Ag, blood|40784703|Prostate Specific Ag | Body Fluid|
|Pumpkin seed IgE level, blood|40764013|Pumpkin Seed IgE Ab/IgE total in Serum|
|Budgerigar serum IgG Ab level, blood|1988811|Budgerigar droppings IgG Ab [Mass/volume] in Serum|
|O_Chloride output, 24hr urine|3008071|Urine output 24 hour|
|O_Cortisol level, urine|40773225|Cortisol | Urine|
|Platelet glycoprotein IIb/IIIa, blood|3048550|Platelet glycoprotein IIb/IIIa Ab [Presence] in Blood by Immunoassay|
|Chloride level, blood|3018572|Chloride [Moles/volume] in Blood|
|Mouse urine IgE level, blood|40764103|Mouse urine proteins IgE Ab/IgE total in Serum|
|Creatine kinase level, blood|3030170|Creatine kinase [Mass/volume] in Blood|
|O_Phosphate output, 24hr urine|3021916|Phosphate [Moles/volume] in 24 hour Urine|
|Gelatin IgE level, blood|40764030|Gelatin IgE Ab/IgE total in Serum|
|Rye IgE level, blood|40761129|Cultivated Rye IgE Ab/IgE total in Serum|
|Coconut IgE level, blood|3041601|Coconut IgE Ab/IgE total in Serum|
|Goats milk IgE level, blood|40764096|Goat milk IgE Ab/IgE total in Serum|
|O_Protein output, 24hr urine|3011705|Protein [Mass/volume] in 24 hour Urine|
|D-dimer, blood|1470777|Fibrin D-dimer | Blood | Coagulation|
|Platelet glycoprotein Ia/IIa, blood|40766209|Platelet glycoprotein Ia/IIa Ab [Presence] in Blood by Immunoassay|
|Copper level, serum|3027126|Copper [Mass/volume] in Serum or Plasma|
|Erythrocyte sedimentation rate, blood|3015183|Erythrocyte sedimentation rate [Velocity] in Red Blood Cells|
|O_Pineapple IgE level, blood|40763977|Pineapple IgE Ab/IgE total in Serum|
|O_Osmolality, blood|40773474|Osmolality | Body Fluid|
|Platelet function comment|40776243|Platelet Function|
|Tyrosine level, blood|3033602|Tyrosine [Presence] in Blood|
|O_Pine nut IgE level, blood|40764091|Pine Nut IgE Ab/IgE total in Serum|
|Reducing substance, faeces|40783241|Reducing Substances | Stool|
|O_Aspergillus fumigatus IgE level,blood|3047468|Aspergillus fumigatus IgE Ab/IgE total in Serum|
|Glycine receptor antibody, serum|36033508|Glycine receptor Ab | Serum or Plasma | Serology - non-micro|
|Metamyelocyte count, blood|37055488|Metamyelocytes | Blood | Hematology and Cell counts|
|Tobramycin level, blood|3000444|Tobramycin [Moles/volume] in Serum or Plasma --peak|
|Strawberry IgE level, blood|40764027|Strawberry IgE Ab/IgE total in Serum|
|Cryofibrinogen comment, blood|37034712|Cryofibrinogen | Blood | Chemistry - non-challenge|
|O_Penicillin G IgE level, blood|3037297|Penicillin G IgE Ab [Units/volume] in Serum|
|Reticulocyte %, blood|3023520|Reticulocytes [#/volume] in Blood|
|Glycosaminoglycans screen, urine|3011208|Glycosaminoglycans [Presence] in Urine|
|Buckwheat IgE level, blood|40764023|Buckwheat IgE Ab/IgE total in Serum|
|Pigeon droppings IgE level, blood|37067404|Pigeon droppings IgE | Serum | Allergy|
|Zinc transporter 8 (ZnT8) Ab, blood|46235190|Zinc transporter 8 Ab [Units/volume] in Serum or Plasma by Immunoassay|
|Selenium level, blood|3011306|Selenium [Mass/volume] in Blood|
|European hornet venom IgE level, blood|40764086|European Hornet IgE Ab/IgE total in Serum|
|Mi-2 alpha antibody (immunoblot), blood|40759862|Mi-2 Ab [Presence] in Serum by Immunoblot|
|O_Creatinine level, urine|40773228|Creatinine | Urine|
|Complement C4 level, blood|3052973|Complement C4 [Presence] in Serum or Plasma|
|O_Sex hormone binding globulin, blood|3011099|Sex hormone binding globulin [Mass/volume] in Serum or Plasma|
|Somatostatin level, plasma|3004468|Somatostatin [Presence] in Plasma|
|Pigeon feathers IgE level, blood|3017801|Pigeon feather IgE Ab [Presence] in Serum|
|PM/Scl-100 antibody (immunoblot), blood|21494114|PM-SCL-100 Ab [Presence] in Serum by Line blot|
|Protein level, urine|40775079|Protein | Urine|
|O_Hamster epithelium IgE level, blood|3044511|Hamster epithelium IgE Ab/IgE total in Serum|
|Lime IgE level, blood|40761047|Lime IgE Ab/IgE total in Serum|
|Voltage-gated Ca channel Ab, blood|3021115|Voltage-gated calcium channel Ab [Presence] in Serum|
|Complement C3 level, blood|3049668|Complement C3 [Presence] in Serum or Plasma|
|O_Serum viscosity, blood|3010493|Viscosity of Serum|
|Clam IgE level, blood|3042203|Clam IgE Ab/IgE total in Serum|
|Protein:creatinine index, urine|37054642|Protein/Creatinine | Urine | Urinalysis|
|Bilirubin level, fluid|40790311|Bilirubin | Body Fluid|
|Mi-2 beta antibody (immunoblot), blood|40759862|Mi-2 Ab [Presence] in Serum by Immunoblot|
|Xanthochromia detection, CSF|3027572|Xanthochromia [Presence] of Cerebral spinal fluid Qualitative|
|Garlic IgE level, blood|40763972|Garlic IgE Ab/IgE total in Serum|
|Pear IgE level, blood|40764068|Pear IgE Ab/IgE total in Serum|
|Mitotane level, blood|3005578|Mitotane [Mass/volume] in Serum or Plasma|
|O_Angiotensin-converting enzyme, blood|3036335|Angiotensin converting enzyme [Enzymatic activity/volume] in Blood|
|Urate level, urine|40789966|Urate | Urine|
|Macadamia Nut IgE level, blood|40764044|Macadamia IgE Ab/IgE total in Serum|
|Urea level, plasma|3034204|Urea [Mass/volume] in Serum or Plasma|
|O_Scallop IgE level, blood|3041779|Scallop IgE Ab/IgE total in Serum|
|Proteinase 3 Ab level, blood|40766042|Proteinase 3 Ab [Presence] in Serum by Immunoassay|
|Peach IgE level, blood|3046343|Peach IgE Ab/IgE total in Serum|
|Glucose level 30min, plasma|36660135|Glucose [Mass/volume] in Serum or Plasma --30 min post meal|
|Creatinine clearance, urine|3047148|Creatinine renal clearance in Urine and Serum or Plasma collected for unspecified duration|
|O_Reptilase time, blood|3005308|Reptilase time|
|Procollagen 1 amino peptide|40779599|Procollagen peptide|
|O_Brazil nut IgE level, blood|3042333|Brazil Nut IgE Ab/IgE total in Serum|
|O_Oysters IgE level, blood|40764053|Oyster IgE Ab/IgE total in Serum|
|C3 nephritic factor level, blood|3048069|C3 nephritic factor [Presence] in Serum or Plasma|
|Tuna fish IgE level, blood|3042626|Tuna IgE Ab/IgE total in Serum|
|Apolipoprotein A-I level, plasma|3008364|Apolipoprotein A-I [Mass/volume] in Serum or Plasma|
|Homocysteine level, plasma|3046382|Homocysteine [Presence] in Serum or Plasma|
|Myelin associated glycoprotein Ab, blood|40785533|Myelin associated glycoprotein Ab | Body fluid|
|O_Pistachio IgE level, blood|3039295|Pistachio IgE Ab/IgE total in Serum|
|Paprika IgE level, blood|40764000|Paprika IgE Ab/IgE total in Serum|
|O_Cheddar cheese IgE level, blood|40761038|Cheese cheddar type IgE Ab/IgE total in Serum|
|O_Cashew nut IgE level, blood|3052099|Cashew nut IgE Ab/IgE total in Serum|
|O_Lactate dehydrogenase level, fluid|40783464|Lactate Dehydrogenase | Body Fluid|
|O_Platelet function, blood|40776243|Platelet Function|
|Glucose (BG)|40776614|Glucose | Bld-Ser-Plas|
|Amino acids level, plasma|3048820|Alanine/Amino acids.total in Serum or Plasma|
|Haemoglobin D level, blood|3013179|Hemoglobin D/Hemoglobin.total in Blood|
|Haemoglobin S level, blood|3010418|Hemoglobin S [Presence] in Blood|
|Crab IgE level, blood|3044567|Crab IgE Ab/IgE total in Serum|
|Alanine aminotransferase level, blood|46235106|Alanine aminotransferase [Enzymatic activity/volume] in Blood|
|Wheat IgE level, blood|3039291|Wheat IgE Ab/IgE total in Serum|
|Apricot IgE level, blood|37042132|Apricot (Prunus armeniaca) IgE | Serum | Allergy|
|Monocyte %, blood|3001604|Monocytes [#/volume] in Blood|
|O_Sirolimus level, blood|3021374|Sirolimus [Mass/volume] in Blood|
|Chromogranin A level, serum|3014702|Chromogranin A [Moles/volume] in Serum or Plasma|
|Theophylline level, blood|3009072|Theophylline [Mass/volume] in Blood|
|O_Intrinsic factor Ab level, blood|3022194|Intrinsic factor Ab [Presence] in Serum|
|Lipase level, fluid|3026286|Lipase [Enzymatic activity/volume] in Body fluid|
|O_Phenylalanine level, blood|3030135|Phenylalanine [Presence] in Blood|
|O_Pyruvate kinase assay, blood|3015478|Pyruvate kinase [Presence] in Blood|
|O_European hornet venom IgE level, blood|40764086|European Hornet IgE Ab/IgE total in Serum|
|Reference laboratory comment|21498098|Laboratory comment | Report|
|Creatinine level, fluid|40779952|Creatinine | Body Fluid|
|O_Procollagen 1 amino peptide|40779599|Procollagen peptide|
|Kiwi fruit IgE level, blood|3046124|Kiwifruit IgE Ab/IgE total in Serum|
|Salicylate level, blood|3024989|Salicylates [Presence] in Blood|
|O_Beta-hydroxybutyrate level, blood|1092084|Beta hydroxybutyrate [Moles/volume] in Blood|
|O_Haemosiderin level, urine|40773657|Hemosiderin | Urine|
|O_Aspartate aminotransferase level,blood|3010587|Aspartate aminotransferase [Presence] in Serum or Plasma|
|Basophil %, blood|3006315|Basophils [#/volume] in Blood|
|See CSF for oligoclonal band results|3002182|Oligoclonal bands [Presence] in Cerebral spinal fluid|
|C1 esterase inhibitor level, blood|3049801|Complement C1 esterase inhibitor actual/normal in Serum or Plasma|
|C24 long chain fatty acid level, plasma|3039491|Fatty acids.very long chain C24:0 (Tetracosanoate) [Mass/volume] in Serum or Plasma|
|AMPA1/2 receptor antibody, serum|37042855|AMPAR2 IgG | Serum or Plasma | Serology - non-micro|
|Common ragweed IgE level, blood|40763975|Common Ragweed IgE Ab/IgE total in Serum|
|Protein per day, urine|40656426|Protein|Mass Rate|Urine|
|Basil IgE level, blood|40764049|Basil IgE Ab/IgE total in Serum|
|Glycine receptor antibody, CSF|36033306|Glycine receptor Ab | Cerebral spinal fluid | Serology - non-micro|
|Voltage-gated K channel Ab, blood|3031103|Voltage-gated potassium channel Ab [Moles/volume] in Serum|
|Tacrolimus level, blood|3026250|Tacrolimus [Mass/volume] in Blood|
|Glucose (dipstick), urine|37062148|Glucose | Urine | Urinalysis|
|O_Sesame seed IgE level, blood|40764074|Sesame Seed IgE Ab/IgE total in Serum|
|Potassium level, fluid|40784012|Potassium | Body Fluid|
|IgM Kappa/ Lambda Heavy Chain Ratio|44816762|IgM.kappa/IgM.lambda [Mass Ratio] in Serum or Plasma|
|O_Celery IgE level, blood|40763979|Celery IgE Ab/IgE total in Serum|
|High molecular weight kininogen, blood|37078009|Kininogen.high molecular weight actual/Normal | Platelet poor plasma | Coagulation|
|Glomerular basement membrane Ab, blood|40653074|Glomerular basement membrane Ab|Arbitrary Concentration|Moment in time|Blood, Serum or Plasma|
|IgG Kappa/ Lambda Heavy Chain Ratio|44816760|IgG.kappa/IgG.lambda [Mass Ratio] in Serum or Plasma|
|Amylase level, blood|46235169|Amylase [Enzymatic activity/volume] in Blood|
|O_Citrate level, urine|40796531|Citrate | Urine|
|Adalimumab Serum-Drug level, blood|37058114|Adalimumab | Serum or Plasma | Drug toxicology|
|O_Magnesium level, urine|40793199|Magnesium | Urine|
|Almond IgE level, blood|3041042|Almond IgE Ab/IgE total in Serum|
|Mean cell volume, blood|40788209|Mean sphered cell volume | Red Blood Cells|
|Lactate level, plasma|3020138|Lactate [Mass/volume] in Serum or Plasma|
|Urine Dipstick Clarity|3008204|Clarity of Urine|
|O_Ethanol level, blood|3025643|Ethanol [Mass/volume] in Blood|
|O_Metadrenaline output, 24hr urine|40655092|Metanephrines|24 hours|Urine|
|Squid IgE level, blood|40764042|Squid IgE Ab/IgE total in Serum|
|IgG, CSF|40783423|IgG | Cerebral spinal fluid|
|Orange IgE level, blood|40764009|Orange IgE Ab/IgE total in Serum|
|Platelet ATP:ADP ratio, blood|43533700|Adenosine triphosphate/Adenosine diphosphate [Entitic molar ratio] in Platelets|
|O_Albumin level, urine|40773229|Albumin | Urine|
|APTT reference, blood|37037324|aPTT | Blood | Coagulation|
|rCor a 1 hazelnut f428 IgE level, blood|40767668|Hazelnut recombinant (rCor a) 1.0101 IgE Ab [Units/volume] in Serum|
|Monocyte count, blood|3001604|Monocytes [#/volume] in Blood|
|Anti-neutrophil cytoplasmic Ab, blood|3009628|Neutrophil cytoplasmic Ab [Presence] in Serum|
|Raspberry IgE level, blood|3965432|Raspberry IgE Ab [Presence] in Serum by Radioallergosorbent test (RAST)|
|O_Inhibin B level, blood|3038854|Inhibin B [Presence] in Serum or Plasma|
|O_Walnut IgE level, blood|3041778|Walnut IgE Ab/IgE total in Serum|
|Poultry feathers IgE level, blood|40764098|Chicken feather IgE Ab/IgE total in Serum|
|Anchovy IgE level, blood|3024613|Anchovy IgE Ab [Units/volume] in Serum|
|O_5-HIAA output, 24hr urine|3008071|Urine output 24 hour|
|Vasoactive intestinal polypeptide,plasma|3028054|Vasoactive intestinal peptide [Mass/volume] in Serum or Plasma|
|Mustard IgE level, blood|3029844|Mustard IgE Ab/IgE total in Serum|
|Immunofixation, blood|3037756|Immunofixation for Serum or Plasma|
|O_Urea level, urine|40773808|Urea | Urine|
|C26 long chain fatty acid level, plasma|3044876|Fatty acids.very long chain C26:0 (Hexacosanoate) [Mass/volume] in Serum or Plasma|
|Beef IgE level, blood|40764092|Beef IgE Ab/IgE total in Serum|
|O_Hazelnut IgE level, blood|3041451|Hazelnut IgE Ab/IgE total in Serum|
|Haemoglobin C level, blood|3042060|Hemoglobin C [Presence] in Blood|
|O_Strawberry IgE level, blood|40764027|Strawberry IgE Ab/IgE total in Serum|
|Rice IgE level, blood|40764052|Rice IgE Ab/IgE total in Serum|
|White bean IgE level, blood|40761022|White Bean IgE Ab/IgE total in Serum|
|O_Macadamia Nut IgE level, blood|40764044|Macadamia IgE Ab/IgE total in Serum|
|Banana IgE level, blood|40764048|Banana IgE Ab/IgE total in Serum|
|Sodium level, sweat|40780768|Sodium | Sweat|
|Macroprolactin level, blood|43055514|Macroprolactin [Presence] in Serum or Plasma|
|Haemoglobin F level, blood|3015745|Hemoglobin F [Presence] in Blood|
|IgG subclass 4 level, blood|3024980|IgG subclass 4 [Mass/volume] in Serum|
|O_Manganese level, blood|3022475|Manganese [Moles/volume] in Blood|
|Manganese level, serum|3013059|Manganese [Moles/volume] in Serum or Plasma|
|Chick pea IgE level, blood|40764005|Chick Pea IgE Ab/IgE total in Serum|
|Barley IgE level, blood|40764034|Barley IgE Ab/IgE total in Serum|
|O_Rabbit epithelium IgE level, blood|3038805|Rabbit epithelium IgE Ab/IgE total in Serum|
|Naive B cells IgD+ CD27-, blood|21493675|CD27+IgD- cells/Cells.CD19+CD20+ in Blood|
|O_Anchovy IgE level, blood|3024613|Anchovy IgE Ab [Units/volume] in Serum|
|O_Myeloperoxidase Ab level, blood|3016080|Myeloperoxidase Ab [Presence] in Serum|
|5-HIAA output, 24hr urine|3008071|Urine output 24 hour|
|O_Carrot IgE level, blood|3035253|Carrot IgE Ab/IgE total in Serum|
|O_Rat urine IgE level, blood|40764107|Rat urine proteins IgE Ab/IgE total in Serum|
|O_Androstenedione level, blood|3044426|Androstenedione [Presence] in Serum or Plasma|
|Anti-beta2-glycoprotein 1 IgM, blood|3043181|Beta 2 glycoprotein 1 IgM Ab [Presence] in Serum|
|O_Pigeon droppings IgE level, blood|37067404|Pigeon droppings IgE | Serum | Allergy|
|rCor a 14 hazelnut f439 IgE level, blood|21494261|Hazelnut recombinant (rCor a) 14 IgE Ab [Units/volume] in Serum|
|SRP antibody (immunoblot), blood|40766285|Signal Recognition Particle (SRP) Ab [Presence] in Serum or Plasma by Immunoblot|
|O_Pigeon (serum) antibodies, blood|3037047|Pigeon antibody panel - Serum|
|Hen serum proteins IgG antibodies|37040479|Chicken serum proteins IgG | Serum | Allergy|
|O_Sunflower seed IgE level, blood|40764033|Sunflower Seed IgE Ab/IgE total in Serum|
|vWF multimers, blood|40794980|von Willebrand factor (vWf) multimers | Platelet poor plasma|
|O_Coconut IgE level, blood|3041601|Coconut IgE Ab/IgE total in Serum|
|5-HIAA:creatinine ratio, urine|40655868|5-Hydroxyindoleacetate/Creatinine|Mass Ratio|Urine|
|CD21- CD38- %, blood|36659842|CD21lowCD38- cells [#/volume] in Blood|
|Triglycerides level, fluid|40655549|Triglyceride|Moment in time|Body fluid, unspecified|
|Pork IgE level, blood|40764108|Pork IgE Ab/IgE total in Serum|
|Cheese mould IgE level, blood|40761039|Cheese mold type IgE Ab/IgE total in Serum|
|O_Latex IgE level, blood|3009841|Latex IgE Ab [Units/volume] in Blood|
|Glutamic acid decarboxylase Ab, CSF|37037855|Glutamate decarboxylase Ab | Cerebral spinal fluid | Chemistry - non-challenge|
|Haddock IgE level, blood|3023863|Haddock IgE Ab [Units/volume] in Serum|
|O_Xanthochromia detection, CSF|3027572|Xanthochromia [Presence] of Cerebral spinal fluid Qualitative|
|O_Erythrocyte sedimentation rate, blood|3015183|Erythrocyte sedimentation rate [Velocity] in Red Blood Cells|
|O_Inhibin A level, blood|3007745|Inhibin A [Presence] in Serum or Plasma|
|O_Haemoglobin H inclusions screen, blood|40762276|Hemoglobin H inclusion bodies [Presence] in Blood|
|Egg yolk IgE level, blood|40764100|Egg yolk IgE Ab/IgE total in Serum|
|O_Liver kidney microsomal Abs, blood|40786590|Liver Kidney Microsomal Ab | Bld-Ser-Plas|
|O_Pigeon feathers IgE level, blood|3017801|Pigeon feather IgE Ab [Presence] in Serum|
|Prothrombin time and INR, blood|37074906|INR | Blood | Coagulation|
|Blood (dipstick), urine|37042473|Blood | Urine | Urinalysis|
|Protein level, fluid|3005029|Protein [Mass/volume] in Body fluid|
|Kaolin clotting ratio, blood|1990353|Clot formation.kaolin induced | Blood | Coagulation|
|O_Ammonia level, blood|3030942|Ammonia [Mass/volume] in Blood|
|O_Zinc level, blood|3026103|Zinc [Presence] in Blood|
|O_APTT, blood|37037324|aPTT | Blood | Coagulation|
|Amino acids level, CSF|40777458|Amino Acids | Cerebral spinal fluid|
|Cherry IgE level, blood|40764067|Cherry IgE Ab/IgE total in Serum|
|Apple IgE level, blood|3043254|Apple IgE Ab/IgE total in Serum|
|C1 esterase inhibitor function, blood|3000391|Complement C1 esterase inhibitor.functional [Presence] in Serum or Plasma|
|Sodium level, blood|3000285|Sodium [Moles/volume] in Blood|
|MDA5 antibody (immunoblot), blood|42529582|MDA5 Ab [Presence] in Serum by Line blot|
|Pea IgE level, blood|40764061|Pea IgE Ab/IgE total in Serum|
|Aldosterone level 240min, plasma|40654277|Aldosterone|Moment in time|Serum or Plasma|360.45 g/mole|
|C22 long chain fatty acid level, plasma|40654793|Fatty acids.very long chain.C22:0|Moment in time|Serum or Plasma|
|Neurotensin level, blood|3002061|Neurotensin [Mass/volume] in Plasma|
|Onion IgE level, blood|40763971|Onion IgE Ab/IgE total in Serum|
|O_Tuna fish IgE level, blood|3042626|Tuna IgE Ab/IgE total in Serum|
|Aldosterone:Renin ratio 0min|3011145|Aldosterone/Renin [Ratio] in Plasma|
|rCor a 8 hazelnut f425 IgE level, blood|40761847|Hazelnut recombinant (rCor a) 8 IgE Ab [Units/volume] in Serum|
|1,25-Dihydroxy Vitamin D3 level, plasma|3024390|25-hydroxyvitamin D3 [Moles/volume] in Serum or Plasma|
|Birch IgE level, blood|40763988|White Birch IgE Ab/IgE total in Serum|
|Glucose level, fluid|3019210|Glucose [Mass/volume] in Body fluid|
|Vancomycin level, serum|3005715|Vancomycin [Mass/volume] in Serum or Plasma|
|Galactose-1-phosphate level, blood|3042819|Galactose 1 phosphate [Mass/mass] in Red Blood Cells|
|IgG subclass 1 level, blood|3027135|IgG subclass 1 [Mass/volume] in Serum|
|Paraneoplastic immunoblots CSF Comments|3051230|Paraneoplastic Ab [Presence] in Cerebral spinal fluid by Immunoblot|
|O_Lactate level, CSF|40655009|Lactate|Moment in time|CSF|
|Creatinine level, blood|3051825|Creatinine [Mass/volume] in Blood|
|Cryoglobulin, blood|3028490|Cryoglobulin [Mass/volume] in Blood|
|Eosinophil count, blood|37060474|Eosinophils | Blood | Hematology and Cell counts|
|O_Goats milk IgE level, blood|40764096|Goat milk IgE Ab/IgE total in Serum|
|O_Tobramycin level, blood|3000444|Tobramycin [Moles/volume] in Serum or Plasma --peak|
|IgG subclass 3 level, blood|3024139|IgG subclass 3 [Mass/volume] in Serum|
|Urate level, blood|1989097|Urate [Mass/volume] in Blood|
|O_Calcium level, urine|3012065|Calcium [Presence] in Urine|
|IgG subclass 2 level, blood|3028192|IgG subclass 2 [Mass/volume] in Serum|
|O_Heinz bodies screen, blood|3049436|Heinz bodies [Presence] in Blood|
|Insulin level, serum|40765155|Glucose/Insulin [Ratio] in Serum or Plasma|
|Sodium level, fluid|40780766|Sodium | Body Fluid|
|IgD level, blood|3031696|IgD [Mass/volume] in Urine|
|Lithium level, blood|3001823|Lithium, [Moles/volume] in Blood|
|O_Raspberry IgE level, blood|3965432|Raspberry IgE Ab [Presence] in Serum by Radioallergosorbent test (RAST)|
|O_Beta-2 microglobulin, blood|40797445|Beta-2-microglobulin | Body Fluid|
|O_Alanine aminotransferase level, blood|46235106|Alanine aminotransferase [Enzymatic activity/volume] in Blood|
|O_Calcium level, blood|3027495|Calcium [Presence] in Blood|
|Potassium level, blood|21490733|Potassium [Mass/volume] in Blood|
|Fibrinogen level, blood|1618662|Fibrinogen | Blood | Coagulation|
|Dehydroepiandrosterone sulphate, blood|40773449|Dehydroepiandrosterone Sulfate | Bld-Ser-Plas|
|O_Copper level, urine|40773375|Copper | Urine|
|CXCR5+CD4 T Cells, blood|3036131|CD4+CD95+ cells/cells in Blood|
|Gastric parietal cell Ab level,blood|40778857|Parietal cell Ab | Gastric fluid|
|O_Oxalate level, urine|40776688|Oxalate | Urine|
|O_Amylase level, fluid|3043024|Amylase [Presence] in Body fluid|
|Cod IgE level, blood|3043915|Codfish IgE Ab/IgE total in Serum|
|Cockatiel serum proteins IgG antibodies|37076425|Cockatiel serum IgE | Serum | Allergy|
|Protein level, CSF|3010719|Protein in CSF/Protein in serum|
|Glucose level, dialysate|40783312|Glucose | Dialysis fluid|
|Direct antiglobulin test baby, blood|1260449|Direct antiglobulin test.polyspecific reagent | Fetus | Red Blood Cells | Blood bank|
|Insulin IgG Ab level, blood|40759653|Insulin IgG Ab [Units/volume] in Serum|
|Haptoglobin level, serum|3040752|Haptoglobin [Presence] in Serum or Plasma|
|O_Haddock IgE level, blood|3023863|Haddock IgE Ab [Units/volume] in Serum|
|Voltage-gated Ca channel Ab, CSF|1990750|Voltage-gated calcium channel Ab | Cerebral spinal fluid | Serology - non-micro|
|O_Glomerular basement membrane Ab, blood|40653074|Glomerular basement membrane Ab|Arbitrary Concentration|Moment in time|Blood, Serum or Plasma|
|CD4RO+ Memory CD4 T Cells, blood|3034660|CD4+CD45RO+ cells/cells in Blood|
|O_Cyclic citrullinated peptide Ab, blood|3041391|Cyclic citrullinated peptide Ab [Presence] in Serum|
|O_Reticulocyte count, blood|3023520|Reticulocytes [#/volume] in Blood|
|Triglycerides level, blood|3022038|Triglyceride [Mass/volume] in Blood|
|O_Glycosaminoglycans screen, urine|3011208|Glycosaminoglycans [Presence] in Urine|
|Light chain output per day, urine|3017831|Lambda light chains [Mass/volume] in 24 hour Urine|
|Acylcarnitine profile, blood spot|3046449|Acylcarnitine [Presence] in Blood|
|O_Prothrombin time and INR, blood|37074906|INR | Blood | Coagulation|
|Phenytoin level, blood|3021595|Phenytoin [Presence] in Serum or Plasma|
|Ganglioside GM1 antibody, blood|40778854|Ganglioside GM1 IgG | Body fluid|
|Mango IgE level, blood|3037381|Mango IgE Ab [Units/volume] in Serum|
|O_Creatinine clearance, urine|3035532|Creatinine renal clearance/1.73 sq M in Urine and Serum or Plasma collected for unspecified duration|
|Cholesterol level, fluid|40789856|Cholesterol | Body Fluid|
|O_Buckwheat IgE level, blood|40764023|Buckwheat IgE Ab/IgE total in Serum|
|IgA Kappa/ Lambda Heavy Chain Ratio|44816761|IgA.kappa/IgA.lambda [Mass Ratio] in Serum or Plasma|
|Normetadrenaline level, plasma|3016851|Normetanephrine [Mass/volume] in Serum or Plasma|
|Metamyelocyte %, blood|3024507|Metamyelocytes [#/volume] in Blood|
|Ecarin clotting time, blood|37042598|Coagulation ecarin induced | Blood | Coagulation|
|Aspergillus fumigatus IgG, blood|37054714|Aspergillus fumigatus IgG | Serum | Microbiology|
|O_Aluminium level, blood|42528608|Aluminum [Moles/volume] in Blood|
|pH, faeces|40793845|pH | Stool|
|Eosinophil %, blood|3013115|Eosinophils [#/volume] in Blood|
|Pristanate level, blood|3003547|Pristanate (C15:0(CH3)4) [Mass/volume] in Serum or Plasma|
|Non-HDL cholesterol, blood|40797515|Cholesterol non HDL | Bld-Ser-Plas|
|Natalizumab antibodies, blood|40761116|Natalizumab Ab [Presence] in Serum|
|Methotrexate level, CSF|40655116|Methotrexate|Moment in time|CSF|
|O_Mushroom IgE level, blood|40763970|Mushroom IgE Ab/IgE total in Serum|
|Parrot serum proteins IgG antibodies|37071592|Parrot feather IgG | Serum | Allergy|
|O_Peach IgE level, blood|3046343|Peach IgE Ab/IgE total in Serum|
|O_Mouse urine IgE level, blood|40764103|Mouse urine proteins IgE Ab/IgE total in Serum|
|Inorganic phosphate level, urine|3025766|Phosphate [Presence] in Urine|
|Cows milk IgE level, blood|40764093|Cow milk IgE Ab/IgE total in Serum|
|O_Gelatin IgE level, blood|40764030|Gelatin IgE Ab/IgE total in Serum|
|Blast cell count, blood|37044426|Blasts | Blood | Hematology and Cell counts|
|Complement C1q level, blood|40780187|Complement C1q | Body Fluid|
|CD4RA+ Naïve CD4 T Cells, blood|3033943|CD4+CD45RA+ cells/cells in Blood|
|Cortisol pre-15min, serum|37079795|Cortisol^15M pre 1 ug/kg CRH IV|Moment in time|Serum or Plasma|
|Finch serum proteins IgG Abs, blood|3042317|Finch droppings IgG Ab [Presence] in Serum|
|O_Bilirubin level, fluid|40790311|Bilirubin | Body Fluid|
|Vitamin B12 level, serum|3031790|Cobalamin (Vitamin B12) [Mass or Moles/volume] in Serum|
|Egg white IgE level, blood|40764099|Egg white IgE Ab/IgE total in Serum|
|O_Common ragweed IgE level, blood|40763975|Common Ragweed IgE Ab/IgE total in Serum|
|ACTH pre-15min, plasma|37079720|Corticotropin^15M pre 1 ug/kg CRH IV|Moment in time|Plasma|
|O_Serum free light chains, blood|40759246|Immunoglobulin light chains.free [Presence] in Serum|
|Glucose level, CSF|3004378|Glucose in CSF/Glucose plas|
|Poppy seed IgE level, blood|3010495|Poppy Seed IgE Ab [Units/volume] in Serum|
|Anti-beta2-glycoprotein 1 IgG, blood|3045355|Beta 2 glycoprotein 1 IgG Ab [Presence] in Serum|
|Oat IgE level, blood|40763987|Oat IgE Ab/IgE total in Serum|
|CD8RA+ Naïve CD8 T Cells, blood|36204492|CD8+CD45RA+ cells/CD8 Cells in Blood|
|rTri a 14 wheat f433 IgE level, blood|40767666|Wheat recombinant (rTri a) 14 IgE Ab [Units/volume] in Serum|
|pH (BG)|40789846|pH | Bld-Ser-Plas|
|Alpha-1-antitrypsin level, blood|3031800|Alpha 1 antitrypsin actual/normal in Serum or Plasma|
|Aluminium level, serum|3000578|Aluminum [Moles/volume] in Serum or Plasma|
|O_Apricot IgE level, blood|3012180|Apricot IgE Ab [Units/volume] in Serum|
|GABAB antibody, serum|37045704|GABABR Ab | Serum | Serology - non-micro|
|O_Creatine kinase level, blood|3030170|Creatine kinase [Mass/volume] in Blood|
|IGF-1 level, blood|3007922|Insulin-like growth factor-I [Mass/volume] in Blood|
|Alpha-1-antitrypsin Pi phenotype, blood|40652551|Alpha 1 antitrypsin phenotype|Impression/interpretation of study|Moment in time|Blood, Serum or Plasma|
|Acetylcholine receptor Ab level, blood|3042927|Acetylcholine receptor Ab [Presence] in Serum|
|CD4 Effector T Cells, blood|3014037|CD3+CD4+ (T4 helper) cells/cells in Blood|
|O_Triglycerides level, fluid|40655549|Triglyceride|Moment in time|Body fluid, unspecified|
|O_Amino acids level, urine|40779951|Amino Acids | Urine|
|Albumin level, CSF|3013247|Albumin in CSF/Albumin in Serum or Plasma|
|O_Dehydroepiandrosterone sulphate, blood|40773449|Dehydroepiandrosterone Sulfate | Bld-Ser-Plas|
|O_Magnesium level, blood|3033836|Magnesium [Moles/volume] in Blood|
|Adrenocorticotrophic hormone, plasma|3038090|Corticotropin Canine [Mass/volume] in Plasma|
|Protein C level, blood|3004923|Protein C [Mass/volume] in Plasma|
|Tomato IgE level, blood|3040762|Tomato IgE Ab/IgE total in Serum|
|Leucocytes dipstick, urine|3045414|Leukocytes [Presence] in Urine|
|O_Clam IgE level, blood|3042203|Clam IgE Ab/IgE total in Serum|
|Cat dander IgE level, blood|3035514|Cat dander IgE Ab/IgE total in Serum|
|Lipase level, blood|3004905|Lipase [Enzymatic activity/volume] in Serum or Plasma|
|O_Rye IgE level, blood|40761129|Cultivated Rye IgE Ab/IgE total in Serum|
|CD3 T cell count|3022533|CD3 cells/cells in Blood|
|Candida Ab level, blood|3031997|Candida albicans Ab [Titer] in Serum|
|O_Platelet aggregation, blood|40777133|Platelet Aggregation | Platelet poor plasma|
|O_Prothrombin time, blood|37044890|Prothrombin time (PT) | Blood | Coagulation|
|O_Salmon IgE level, blood|3039263|Salmon IgE Ab/IgE total in Serum|
|Adrenal cortex Ab level, blood|3043763|Adrenal cortex Ab [Presence] in Serum|
|O_Orange IgE level, blood|40764009|Orange IgE Ab/IgE total in Serum|
|Protein (dipstick), urine|37062605|Protein | Urine | Urinalysis|
|Organic acids report and comment|40796354|Organic Acids | Bld-Ser-Plas|
|O_Voltage-gated K channel Ab, blood|3031103|Voltage-gated potassium channel Ab [Moles/volume] in Serum|
|O_Selenium level, blood|3011306|Selenium [Mass/volume] in Blood|
|O_Homocysteine level, blood|3042985|Homocysteine [Presence] in Blood|
|O_Immunodeficiency panel, blood|37063513|Immunodeficiency panel | Blood | Cellmarker Panels|
|O_Voltage-gated Ca channel Ab, blood|3021115|Voltage-gated calcium channel Ab [Presence] in Serum|
|Free protein S level, blood|40774474|Protein S Free | Platelet poor plasma|
|O_Theophylline level, blood|3009072|Theophylline [Mass/volume] in Blood|
|O_Grape IgE level, blood|3044470|Grape IgE Ab/IgE total in Serum|
|O_Folate level, blood|3005794|Folate [Presence] in Blood|
|Islet cell Ab level, blood|3005593|Pancreatic islet cell Ab [Titer] in Serum|
|O_Ganglioside GM1 Ab, blood|40653047|Ganglioside GM1 Ab|Presence or Threshold|Moment in time|Blood, Serum or Plasma|
|Mackerel IgE level, blood|3014946|Mackerel IgE Ab [Units/volume] in Serum|
|O_Kiwi fruit IgE level, blood|3046124|Kiwifruit IgE Ab/IgE total in Serum|
|O_Cardiolipin Ab level, blood|3021583|Cardiolipin Ab [Presence] in Serum|
|Haemoglobin A level, blood|3020428|Hemoglobin A/Hemoglobin.total in Blood|
|Galactose-1-phosphate/Hb level, blood|3042819|Galactose 1 phosphate [Mass/mass] in Red Blood Cells|
|Dexamethasone level, serum|3002440|Dexamethasone [Mass/volume] in Serum or Plasma|
|O_Paprika IgE level, blood|40764000|Paprika IgE Ab/IgE total in Serum|
|O_Lemon IgE level, blood|40764007|Lemon IgE Ab/IgE total in Serum|
|% Hypochromic Red Cells|37025824|Hypochromia | Blood | Hematology and Cell counts|
|Classical complement pathway function|44817426|Complement functional activity.classical pathway | Bld-Ser-Plas|
|O_Almond IgE level, blood|3041042|Almond IgE Ab/IgE total in Serum|
|Myelocyte count, blood|37076267|Myelocytes | Blood | Hematology and Cell counts|
|O_Sodium level, blood|3000285|Sodium [Moles/volume] in Blood|
|Iron level, serum|3046728|Iron [Presence] in Serum or Plasma|
|Protein electrophoresis (urine) comment|3044927|Protein electrophoresis panel - Urine|
|TIF1 gamma antibody (immunoblot), blood|42528593|TIF1-gamma Ab [Presence] in Serum by Line blot|
|Folate level, serum|3033201|Folate [Mass or Moles/volume] in Serum or Plasma|
|O_Lime IgE level, blood|40761047|Lime IgE Ab/IgE total in Serum|
|C-peptide level 120min, blood|36660671|C peptide [Mass/volume] in Serum or Plasma --4.5 hours post meal|
|Glucose level, plasma|44816672|Glucose [Mass/volume] in Serum, Plasma or Blood|
|Lead level, blood|3016252|Lead [Presence] in Blood|
|Sweet Chestnut IgE level, blood|40761034|Chestnut IgE Ab/IgE total in Serum|
|Thyroglobulin level, serum|3036535|Thyroglobulin [Mass/volume] in Serum or Plasma|
|Specimen type (BG)|40769406|Specimen type|
|Urea level, dialysate|40790851|Urea | Dialysis fluid|
|Glutamic acid decarboxylase Ab, blood|42528825|Glutamate decarboxylase Ab [Presence] in Serum or Plasma by Immunofluorescence|
|O_Salicylate level, blood|3024989|Salicylates [Presence] in Blood|
|O_Citrulline level, blood|3034087|Citrulline [Presence] in Serum or Plasma|
|Coffee IgE level, blood|40764011|Coffee IgE Ab/IgE total in Serum|
|Pumpkin IgE level, blood|3041898|Pumpkin IgE Ab/IgE total in Serum|
|Blackberry IgE level, blood|3046813|Blackberry IgE Ab/IgE total in Serum|
|O_Vitamin B12 level, blood|3009438|Cobalamin (Vitamin B12) [Presence] in Blood|
|Cryoglobulin immunofixation comment|3048538|Cryoglobulin type [Identifier] in Serum by Immunofixation|
|O_Chloride level, blood|3018572|Chloride [Moles/volume] in Blood|
|IGLON5 Antibodies, Blood|36031929|IgLON5 IgG Ab [Presence] in Serum by Immunofluorescence|
|Carboxyhaemoglobin level, blood|3023081|Carboxyhemoglobin/Hemoglobin.total in Blood|
|C-peptide level, blood|3010084|C peptide [Mass/volume] in Serum or Plasma|
|Memory B cells CD19+ CD27+, blood|36303676|CD27 cells/Cells.CD19 in Blood|
|O_Poppy seed IgE level, blood|3010495|Poppy Seed IgE Ab [Units/volume] in Serum|
|O_Chloride level, urine|40776710|Chloride | Urine|
|Myelin oligodendrocyte (MOG) ab, serum|3005139|Myelin IgG Ab [Titer] in Serum|
|Calprotectin level, faeces|40787599|Calprotectin | Stool|
|Endomysial IgA Ab level, blood|3020961|Endomysium IgA Ab [Titer] in Serum|
|Alder pollen IgE, blood|37071041|White Alder (Alnus rhombifolia) IgE | Serum | Allergy|
|Pecan nut IgE level, blood|3039563|Pecan or Hickory Nut IgE Ab/IgE total in Serum|
|APTT inhibitor screen,blood|3013466|aPTT in Blood by Coagulation assay|
|Prothrombin time reference|3034426|Prothrombin time (PT)|
|Platelet glycoprotein Ib, blood|37067138|Platelet glycoprotein Ib/Ix Ab | Blood | Serology - non-micro|
|Ferritin level, serum|3001122|Ferritin [Mass/volume] in Serum or Plasma|
|O_Haemoglobin A1c level, blood|3004410|Hemoglobin A1c/Hemoglobin.total in Blood|
|Mosquito IgE level, blood|40763969|Aedes mosquito IgE Ab/IgE total in Serum|
|O_Gastric parietal cell Abs, blood|40778857|Parietal cell Ab | Gastric fluid|
|O_Garlic IgE level, blood|40763972|Garlic IgE Ab/IgE total in Serum|
|Albumin level, blood|40786515|Albumin concentration | patient|
|CD8RO+ Memory  CD8  T Cells, blood|36304873|CD45RO cells/CD3+CD8+ (T8 suppressor cells) cells in Blood|
|O_Mustard IgE level, blood|3029844|Mustard IgE Ab/IgE total in Serum|
|O_Egg yolk IgE level, blood|40764100|Egg yolk IgE Ab/IgE total in Serum|
|Troponin I level, serum|37063873|Troponin I.cardiac | Serum or Plasma | Chemistry - non-challenge|
|O_Lactate level, blood|40762125|Lactate [Mass/volume] in Blood|
|Carbamazepine level, blood|3028415|carBAMazepine [Presence] in Serum or Plasma|
|Sugar chromatography, urine|37062148|Glucose | Urine | Urinalysis|
|O_Copper level, blood|3051339|Copper [Moles/volume] in Blood|
|O_Yeast IgE level, blood|3039011|Baker's yeast IgE Ab/IgE total in Serum|
|Platelet count, blood|3007461|Platelets [#/volume] in Blood|
|Infliximab Serum-Drug level, blood|37025150|inFLIXimab | Serum or Plasma | Drug toxicology|
|Horse dander IgE level, blood|3040612|Horse dander IgE Ab/IgE total in Serum|
|Red Cell Distribution width - POC|40773752|Erythrocyte Distribution Width | Red Blood Cells|
|O_Mango IgE level, blood|3037381|Mango IgE Ab [Units/volume] in Serum|
|Albumin level, fluid|40796413|Albumin | Body Fluid|
|O_D-dimer, blood|1470777|Fibrin D-dimer | Blood | Coagulation|
|Oligoclonal band screen, CSF|3002182|Oligoclonal bands [Presence] in Cerebral spinal fluid|
|O_Serum for Oligoclonal banding|3034248|Oligoclonal bands [#] in Serum or Plasma|
|O_Urea level, blood|3009810|Urea [Mass/volume] in Blood|
|Striated muscle Ab level, blood|3021117|Striated muscle Ab [Presence] in Serum|
|O_Proinsulin level, blood|3046058|Proinsulin/Insulin [Ratio] in Serum or Plasma|
|Neutrophil count, blood|37045722|Neutrophils | Blood | Hematology and Cell counts|
|Adjusted calcium level, blood|3048816|Calcium.ionized [Moles/volume] adjusted to pH 7.4 in Blood|
|O_Trout IgE level, blood|40764050|Trout IgE Ab/IgE total in Serum|
|O_Tacrolimus level, blood|3026250|Tacrolimus [Mass/volume] in Blood|
|25-hydroxy vitamin D3 level, serum|3024390|25-hydroxyvitamin D3 [Moles/volume] in Serum or Plasma|
|O_Creatinine level, fluid|40779952|Creatinine | Body Fluid|
|O_Pork IgE level, blood|40764108|Pork IgE Ab/IgE total in Serum|
|Free fatty acid level, serum|37027992|Fatty acids | Serum or Plasma | Chemistry - non-challenge|
|Thyroid stimulating hormone, blood|3011450|Thyrotropin [Presence] in Blood|
|O_Aspergillus fumigatus IgG, blood|37054714|Aspergillus fumigatus IgG | Serum | Microbiology|
|7-alpha cholestenone level, blood|37021300|7-Alpha hydroxy-4-cholesten-3-one [Moles/volume] in Blood|
|Chlorhexidine c8 IgE level, blood|40769377|Chlorhexidine IgE Ab [Units/volume] in Serum|
|Peanut IgE level, blood|40763980|Peanut IgE Ab/IgE total in Serum|
|Urea level, fluid|40760504|Urea [Mass/volume] in Body fluid|
|Total Protein level, urine|3037121|Protein [Mass/volume] in Urine|
|rCor a 9 hazelnut f440 IgE level, blood|40767664|Hazelnut recombinant (rCor a) 1.0401 IgE Ab [Units/volume] in Serum|
|Lactate dehydrogenase level, blood|46235370|Lactate dehydrogenase in body fluid/Lactate dehydrogenase in serum|
|O_Urine Metadrenalines|40780074|Metanephrines | Urine|
|Orexin level, CSF|37021200|Orexin-A [Mass/volume] in Cerebral spinal fluid|
|O_Potassium level, fluid|40784012|Potassium | Body Fluid|
|Ginger IgE level, blood|40764089|Ginger IgE Ab/IgE total in Serum|
|Urea level 240min, blood|3038227|Urea [Moles/time] in 24 hour Body fluid|
|Maize/Corn IgE level, blood|40764088|Corn IgE Ab/IgE total in Serum|
|Influenza B Ag POCT|40781119|Influenza virus B Ag | Bronchial|
|O_Glucose level, fluid|3019210|Glucose [Mass/volume] in Body fluid|
|Soya bean IgE level, blood|40764032|Soybean IgE Ab/IgE total in Serum|
|O_Squid IgE level, blood|40764042|Squid IgE Ab/IgE total in Serum|
|O_Fructosamine level, blood|3038305|Fructosamine/Protein [Ratio] in Serum or Plasma|
|TCR alpha and beta %, blood|3030679|TCR alpha beta cells [#/volume] in Blood|
|O_Thyroglobulin Ab level, blood|3024857|Thyroglobulin Ab [Presence] in Serum|
|O_White bean IgE level, blood|40761022|White Bean IgE Ab/IgE total in Serum|
|Inhibin comment|40780639|Inhibin | Bld-Ser-Plas|
|Aquaporin-4 Ab level, blood|40764191|Aquaporin 4 water channel Ab [Units/volume] in Serum or Plasma by Immunoassay|
|Folate level, whole blood|3005794|Folate [Presence] in Blood|
|O_Complement C3 level, blood|3049668|Complement C3 [Presence] in Serum or Plasma|
|Chicken IgE level, blood|3047420|Chicken IgE Ab/IgE total in Serum|
|O_Banana IgE level, blood|40764048|Banana IgE Ab/IgE total in Serum|
|Platelet ATP, blood|36208792|Adenosine triphosphate | Platelets|
|POC -  CALC Anion Gap|40780881|Anion gap | Bld-Ser-Plas|
|Chromogranin A level|40793781|Chromogranin A | Bld-Ser-Plas|
|O_Haptoglobin level, serum|3040752|Haptoglobin [Presence] in Serum or Plasma|
|O_vWF multimers, blood|40794980|von Willebrand factor (vWf) multimers | Platelet poor plasma|
|O_Poultry feathers IgE level, blood|40764098|Chicken feather IgE Ab/IgE total in Serum|
|O_Cherry IgE level, blood|40764067|Cherry IgE Ab/IgE total in Serum|
|O_Sweet Chestnut IgE level, blood|40761034|Chestnut IgE Ab/IgE total in Serum|
|Leucocyte Immunophenotyping Analysis|40758359|Immunophenotyping study|
|IGLON5 Titre, CSF|36031890|IgLON5 IgG Ab [Titer] in Cerebral spinal fluid by Immunofluorescence|
|O_Beef IgE level, blood|40764092|Beef IgE Ab/IgE total in Serum|
|Osteocalcin level, blood|3028772|Osteocalcin [Mass/volume] in Serum or Plasma|
|17-alphahydroxyprogesterone level, blood|40652474|17-Hydroxyprogesterone|Mass Concentration|Moment in time|Blood, Serum or Plasma|
|O_Acetylcholine receptor Ab level, blood|3006257|Acetylcholine receptor Ab [Moles/volume] in Serum|
|Granulocyte %, blood|3035715|Granulocytes [#/volume] in Blood|
|Wasp venom IgE level, blood|37054989|Wasp venom IgE | Serum | Allergy|
|O_Mackerel IgE level, blood|3014946|Mackerel IgE Ab [Units/volume] in Serum|
|O_Galactose-1-phosphate level, blood|3042819|Galactose 1 phosphate [Mass/mass] in Red Blood Cells|
|Urine Dipstick Colour|3027162|Color of Urine|
|Jo-1 antibody (immunoblot), blood|40759850|Jo-1 extractable nuclear Ab [Presence] in Serum by Immunoblot|
|O_Lithium level, blood|3001823|Lithium, [Moles/volume] in Blood|
|O_Onion IgE level, blood|40763971|Onion IgE Ab/IgE total in Serum|
|CD8 Effector T Cells, blood|3037816|CD4+CD8+ cells/cells in Blood|
|Alpha-galactosidase enzyme level, blood|3004671|Alpha galactosidase A [Enzymatic activity/volume] in Serum or Plasma|
|rAra h 8 peanut f352 IgE level, blood|40766207|Peanut recombinant (rAra h) 8 IgE Ab [Units/volume] in Serum|
|O_Crab IgE level, blood|3044567|Crab IgE Ab/IgE total in Serum|
|O_Aldosterone level, blood|3013915|Aldosterone [Mass/volume] in Blood|
|O_Wheat IgE level, blood|3039291|Wheat IgE Ab/IgE total in Serum|
|Ma2, CSF|3967623|Ma2 Antibody | Cerebral spinal fluid | Serology - non-micro|
|O_Pear IgE level, blood|40764068|Pear IgE Ab/IgE total in Serum|
|Jo-1 Ab level, blood|1092250|Jo sup(a) Ab [Titer] in Serum or Plasma|
|O_Rice IgE level, blood|40764052|Rice IgE Ab/IgE total in Serum|
|Calcitonin level, blood|3018840|Calcitonin [Moles/volume] in Serum or Plasma|
|O_Proteinase 3 Ab level, blood|40766042|Proteinase 3 Ab [Presence] in Serum by Immunoassay|
|O_Calprotectin level, faeces|40787599|Calprotectin | Stool|
|PM/Scl-75antibody by Immunoblot|21494115|PM-SCL-75 Ab [Presence] in Serum by Line blot|
|Influenza A Ag POCT|40793950|Influenza virus A Ag | Throat|
|Cryoglobulin immunofixation, blood|3048538|Cryoglobulin type [Identifier] in Serum by Immunofixation|
|IGLON5 Titre, Blood|36032064|IgLON5 IgG Ab [Titer] in Serum by Immunofluorescence|
|AMPA2 receptor antibody, CSF|42529118|AMPAR2 IgG Ab [Presence] in Cerebral spinal fluid by Immunofluorescence|
|O_Basil IgE level, blood|40764049|Basil IgE Ab/IgE total in Serum|
|Cacao (chocolate) IgE level, blood|37043696|Cocoa (Theobroma cacao) IgE | Serum | Allergy|
|O_Complement C4 level, blood|3052973|Complement C4 [Presence] in Serum or Plasma|
|O_Actual bicarbonate level, blood|3006576|Bicarbonate [Moles/volume] in Blood|
|O_Pecan nut IgE level, blood|3039563|Pecan or Hickory Nut IgE Ab/IgE total in Serum|
|IgA Ab level, blood|3044169|IgA Ab [Presence] in Serum or Plasma|
|Gentamicin timing,blood|40654846|Gentamicin|Moment in time|Serum or Plasma|
|Creatinine level, dialysate|40796640|Creatinine | Dialysis fluid|
|Prolactin level, serum|3004722|Prolactin [Mass/volume] in Serum or Plasma|
|Biotinidase comment|36209687|Biotinidase | DBS|
|vWF Protease Inhibitor, blood|40781824|von Willebrand factor (vWf) cleaving protease inhibitor | Platelet poor plasma|
|O_IGF-1 level, blood|3007922|Insulin-like growth factor-I [Mass/volume] in Blood|
|O_Protein electrophoresis, urine|3044927|Protein electrophoresis panel - Urine|
|Risk of AKI|36306780|Acute kidney injury risk | Patient|
|Cholesterol:HDL ratio, blood|3027939|Cholesterol in HDL/Cholesterol in LDL [Mass Ratio] in Serum or Plasma|
|Pepper IgE level, blood|3032718|Black Pepper IgE Ab/IgE total in Serum|
|O_Alder tree IgE level, blood|40652459|(Alnus incana+Corylus avellana+Ulmus americana+Salix caprea+Populus deltoides) Ab.IgE|Arbitrary Concentration|Moment in time|Blood, Serum or Plasma|
|IgG Kappa Heavy Chain Measurement, blood|3019812|Kappa light chains [Mass/volume] in Serum or Plasma|
|O_Cheese mould IgE level, blood|40761039|Cheese mold type IgE Ab/IgE total in Serum|
|Rapeseed IgE level, blood|3005379|Rapeseed IgE Ab [Units/volume] in Serum|
|Bilirubin Urine Dipstick|37034025|Bilirubin | Urine | Urinalysis|
|O_Oat IgE level, blood|40763987|Oat IgE Ab/IgE total in Serum|
|C-reactive protein level, blood|3000965|C reactive protein [Presence] in Serum or Plasma|
|Haematocrit level, blood|40784124|Hematocrit | Blood arterial|
|O_Aquaporin-4 Ab level, blood|40764191|Aquaporin 4 water channel Ab [Units/volume] in Serum or Plasma by Immunoassay|
|NPM1, blood|37026138|NPM1 gene targeted mutation analysis | Blood or Tissue | Mutations|
|Cucumber IgE, blood|37034420|Cucumber (Cucumis sativus) IgE | Serum | Allergy|
|Mannose binding lectin level, blood|3021997|Mannose-binding protein [Mass/volume] in Serum|
|Creatinine level (referral lab), urine|40773228|Creatinine | Urine|
|O_Islet cell Ab level, blood|3005593|Pancreatic islet cell Ab [Titer] in Serum|
|O_Chick pea IgE level, blood|40764005|Chick Pea IgE Ab/IgE total in Serum|
|vWF sequence, blood|36660444|VWF gene full mutation analysis in Blood or Tissue by Sequencing|
|O_Plum IgE level, blood|3046172|Plum IgE Ab/IgE total in Serum|
|Cryofibrinogen immunofixation, blood|3023504|Cryofibrinogen [Presence] in Plasma|
|1,25-dihydroxy Vitamin D level, serum|40765038|1,25-Dihydroxyvitamin D [Mass/volume] in Serum or Plasma|
|Factor IX level, blood|40796340|Factor IX | patient|
|Total bilirubin level, blood|3028833|Bilirubin.total [Mass/volume] in Blood|
|AMPA1 receptor antibody, CSF|42528892|AMPAR1 IgG Ab [Presence] in Cerebral spinal fluid by Immunofluorescence|
|O_IgA Ab level, blood|3044169|IgA Ab [Presence] in Serum or Plasma|
|Transferrin level, blood|3004789|Transferrin [Mass/volume] in Serum or Plasma|
|Creatinine level 240min, blood|3040071|Creatinine [Moles/time] in 24 hour Body fluid|
|O_Horse dander IgE level, blood|3040612|Horse dander IgE Ab/IgE total in Serum|
|Ciclosporin level, blood|3010375|cycloSPORINE [Mass/volume] in Blood|
|Ovarian Ab level, blood|3044866|Ovary Ab [Titer] in Serum|
|CD62L shedding|3004188|CD62L cells/cells in Blood|
|pH Urine Dipstick|3015736|pH of Urine|
|O_Carboxyhaemoglobin level, blood|3023081|Carboxyhemoglobin/Hemoglobin.total in Blood|
|rAra h 1 peanut f422 IgE level, blood|40766207|Peanut recombinant (rAra h) 8 IgE Ab [Units/volume] in Serum|
|O_Cat dander IgE level, blood|3035514|Cat dander IgE Ab/IgE total in Serum|
|GABA(b)R antibody, CSF|42529115|GABABR IgG Ab [Presence] in Cerebral spinal fluid by Immunofluorescence|
|rAra h 3 peanut f424 IgE level, blood|40761871|Peanut recombinant (rAra h) 3 IgE Ab [Units/volume] in Serum|
|Potato IgE level, blood|3009883|Potato IgE Ab [Units/volume] in Serum|
|O_Rapeseed IgE level, blood|3005379|Rapeseed IgE Ab [Units/volume] in Serum|
|O_5-HIAA:creatinine ratio, urine|3052031|4,5-Dihydroxyhexanoate/Creatinine [Molar ratio] in Urine|
|O_Inorganic phosphate level, urine|3025766|Phosphate [Presence] in Urine|
|O_Haemoglobin electrophoresis, blood|3032868|Hemoglobin electrophoresis panel in Blood|
|Melon IgE level, blood|37028712|Melon (Cucumis melo spp) IgE | Serum | Allergy|
|Gentamicin level, CSF|3041593|Gentamicin [Mass/volume] in Cerebral spinal fluid --peak|
|Phenobarbitone level, blood|37078797|PHENobarbital | Blood | Drug toxicology|
|rAra h 9 peanut f427 IgE level, blood|40767665|Peanut recombinant (rAra h) 9 IgE Ab [Units/volume] in Serum|
|Rape pollen IgE level, blood|3021944|Rape Pollen IgE Ab [Units/volume] in Serum|
|O_Cows milk IgE level, blood|40764093|Cow milk IgE Ab/IgE total in Serum|
|O_Cryoglobulin, blood|3028490|Cryoglobulin [Mass/volume] in Blood|
|Inorganic phosphate level, blood|3018913|Phosphate [Moles/volume] in Blood|
|Total metadrenalines:creat ratio, urine|40656297|Metanephrine/Creatinine|Mass Ratio|Urine|
|Shrimp IgE level, blood|3021226|Shrimp IgE Ab [Units/volume] in Serum|
|O_Amylase level, blood|46235169|Amylase [Enzymatic activity/volume] in Blood|
|Neutrophil %, blood|3017732|Neutrophils [#/volume] in Blood|
|O_Paraneoplastic Ab level, blood|40653493|Paraneoplastic Ab|Presence or Threshold|Moment in time|Blood, Serum or Plasma|
|O_Barley IgE level, blood|40764034|Barley IgE Ab/IgE total in Serum|
|Levetiracetam level, blood|3020666|levETIRAcetam [Mass/volume] in Serum or Plasma|
|O_Differential white cell count, blood|3053331|Differential cell count method - Blood|
|O_Egg white IgE level, blood|40764099|Egg white IgE Ab/IgE total in Serum|
|Insulin IgG Ab comment|40759653|Insulin IgG Ab [Units/volume] in Serum|
|O_Urea level, fluid|40760504|Urea [Mass/volume] in Body fluid|
|O_Tomato IgE level, blood|3040762|Tomato IgE Ab/IgE total in Serum|
|O_Orexin level, CSF|37021200|Orexin-A [Mass/volume] in Cerebral spinal fluid|
|Desmethylclobazam level, blood|40762688|cloBAZam [Mass/volume] in Blood|
|Cortisol level 45min, serum|37079829|Cortisol^45M post XXX challenge|Moment in time|Serum or Plasma|
|ACTH level 45min, plasma|37079754|Corticotropin^45M post 1 ug/kg CRH IV|Moment in time|Plasma|
|Gentamicin level, blood|37044915|Gentamicin | Dose | Drug doses|
|Blood Ketones, POC|37023146|Ketones | Blood | Chemistry - non-challenge|
|O_Creatinine level, Blood|3051825|Creatinine [Mass/volume] in Blood|
|Bile acid level, blood|40787500|Bile Acid | Body Fluid|
|O_Reducing substance, faeces|3001683|Reducing substances [Presence] in Stool|
|Factor VIII level chromogenic, blood|3032768|Coagulation factor VIII activity actual/normal in Platelet poor plasma by Chromogenic method|
|O_Cholesterol level, fluid|3015232|Cholesterol [Mass/volume] in Body fluid|
|O_Blackberry IgE level, blood|3046813|Blackberry IgE Ab/IgE total in Serum|
|rGly m 4 soy f353 IgE level, blood|40766206|Soybean recombinant (rGly m) 4 IgE Ab [Units/volume] in Serum|
|Fructosamine comment|40786818|Fructosamine | Bld-Ser-Plas|
|Paraneoplastic immunoblots blood Comment|3044609|Paraneoplastic Ab [Presence] in Serum by Immunoblot|
|Anti-nuclear Ab level (Hep-2), blood|40762162|Nuclear Ab [Presence] in Serum by Hep2 substrate|
|zzzOxalate:creatinine ratio, urine|3026806|Azelate/Creatinine [Molar ratio] in Urine|
|O_Coffee IgE level, blood|40764011|Coffee IgE Ab/IgE total in Serum|
|Rheumatoid factor, blood|40786825|Rheumatoid Factor | Body Fluid|
|O_Endomysial IgA Ab level, blood|3020961|Endomysium IgA Ab [Titer] in Serum|
|EJ antibody (immunoblot), blood|42529529|Ej Ab [Presence] in Serum by Line blot|
|Oligoclonal band (CSF) comment|3002182|Oligoclonal bands [Presence] in Cerebral spinal fluid|
|O_Cod IgE level, blood|3043915|Codfish IgE Ab/IgE total in Serum|
|Testosterone level, serum|37049505|Testosterone | Serum or Plasma | Chemistry - non-challenge|
|Glucose level 90min, plasma|3020260|Glucose [Mass/volume] in Serum or Plasma --45 minutes post 100 g glucose PO|
|Cortisol level 30min, serum|37079815|Cortisol^30M post dose corticotropin|Moment in time|Serum or Plasma|
|Fondaparinux level, blood|3053342|Fondaparinux [Mass/volume] in Serum or Plasma|
|O_Oligoclonal band screen, CSF|3002182|Oligoclonal bands [Presence] in Cerebral spinal fluid|
|Sodium level 240min, blood|3000285|Sodium [Moles/volume] in Blood|
|O_Alpha-1-antitrypsin Pi phenotype,blood|40652551|Alpha 1 antitrypsin phenotype|Impression/interpretation of study|Moment in time|Blood, Serum or Plasma|
|Gluten IgE level, blood|40764031|Gluten IgE Ab/IgE total in Serum|
|Cortisol level 15min, serum|37079793|Cortisol^15M post XXX challenge|Moment in time|Serum or Plasma|
|Methotrexate level, blood|37027181|Methotrexate | Dose | Drug doses|
|O_Lactate dehydrogenase level, CSF|40793766|Lactate Dehydrogenase | Cerebral spinal fluid|
|Endomysial IgG Ab level, blood|3032773|Endomysium IgG Ab [Titer] in Serum|
|Vancomycin level, CSF|3040396|Vancomycin [Mass/volume] in Cerebral spinal fluid --peak|
|O_Adrenal cortex Ab level, blood|3043763|Adrenal cortex Ab [Presence] in Serum|
|Haemophilus influenzae B Ab level, blood|3020047|Haemophilus influenzae B Ab [Mass/volume] in Serum|
|Scl-70 Ab level, blood|3014568|SCL-70 extractable nuclear Ab [Presence] in Serum|
|Free T3 level, blood|3026925|Triiodothyronine (T3) Free [Mass/volume] in Serum or Plasma|
|Tubular reabsorption phosphate|3964988|Tubular reabsorption of phosphorus/Glomerular filtration rate [Mass/volume] in Urine and Serum or Plasma|
|O_Glucose level, dialysate|40783312|Glucose | Dialysis fluid|
|POC - Gamma glutamyl transferase|40783849|Gamma Glutamyl Transferase | Bld-Ser-Plas|
|TSH receptor Ab level, blood|42528824|Thyrotropin receptor Ab [Presence] in Serum|
|Lymphocyte count by flow cytometry|3026710|Lymphocytes [#/volume] in Blood by Flow cytometry (FC)|
|C-peptide level 0min, blood|36659681|C peptide [Mass/volume] in Serum or Plasma --15 min post meal|
|O_Phenytoin level, blood|3021595|Phenytoin [Presence] in Serum or Plasma|
|O_Triglycerides level, blood|3022038|Triglyceride [Mass/volume] in Blood|
|O_Urea level, dialysate|40790851|Urea | Dialysis fluid|
|O_Striated muscle Ab level, blood|3023296|Striated muscle Ab [Titer] in Serum|
|O_Albumin level, fluid|40796413|Albumin | Body Fluid|
|Acylcarnitine profile, comments|40778487|Acylcarnitine pattern | XXX|
|O_Myelin associated glycoprotein Abblood|40785533|Myelin associated glycoprotein Ab | Body fluid|
|Amikacin level, blood|37038269|Amikacin | Dose | Drug doses|
|Platelet ADP level, blood|40759127|Platelet aggregation ADP induced in Blood --10 umol/L|
|Digoxin level, blood|37051483|Digoxin | Dose | Drug doses|
|ACTH level 15min, plasma|37079717|Corticotropin^15M post 1 ug/kg CRH IV|Moment in time|Plasma|
|ACTH level 30min, plasma|37079739|Corticotropin^30M post 1 ug/kg CRH IV|Moment in time|Plasma|
|Amoxycilloyl IgE level, blood|3031955|Amoxicillin IgE Ab/IgE total in Serum|
|O_Potassium level, blood|21490733|Potassium [Mass/volume] in Blood|
|O_Insulin IgG Ab level, blood|40759653|Insulin IgG Ab [Units/volume] in Serum|
|Phospholipid Ab comment, blood|3021210|Phospholipid Ab [Presence] in Serum|
|O_C1 esterase inhibitor level, blood|3049801|Complement C1 esterase inhibitor actual/normal in Serum or Plasma|
|Lipoprotein (a) level, blood|40763399|Lipoprotein a/total Lipoprotein in Serum or Plasma|
|O_Ginger IgE level, blood|40764089|Ginger IgE Ab/IgE total in Serum|
|Glucose level 60min, serum|3023186|Glucose [Mass/volume] in Serum or Plasma --45 minutes post dose glucose|
|Canary Ab level, blood|40762010|Canary feather IgG Ab [Mass/volume] in Serum|
|O_Glutamic acid decarboxylase Ab, blood|42528825|Glutamate decarboxylase Ab [Presence] in Serum or Plasma by Immunofluorescence|
|CD4 Naïve T Cells, blood|3014037|CD3+CD4+ (T4 helper) cells/cells in Blood|
|Phospholipase A2 Ab, Blood|42529060|Phospholipase A2 receptor IgG Ab [Presence] in Serum by Line blot|
|O_Caged bird feathers IgE level, blood|40764098|Chicken feather IgE Ab/IgE total in Serum|
|Tryptase level, blood|40655567|Tryptase|Moment in time|Serum or Plasma|725.8 g/mole|
|Caged bird feathers IgE level, blood|40764098|Chicken feather IgE Ab/IgE total in Serum|
|O_Lamotrigine level, blood|3039052|lamoTRIgine [Presence] in Serum or Plasma|
|O_Cacao (chocolate) IgE level, blood|37043696|Cocoa (Theobroma cacao) IgE | Serum | Allergy|
|O_Total bilirubin level, blood|3028833|Bilirubin.total [Mass/volume] in Blood|
|O_Bilirubin level, blood|37046070|Bilirubin | Blood | Chemistry - non-challenge|
|O_Sodium level, fluid|3022810|Sodium [Moles/volume] in Body fluid|
|rAra h 2 peanut f423 IgE level, blood|40761872|Peanut recombinant (rAra h) 2 IgE Ab [Units/volume] in Serum|
|Dog dander IgE, blood|37064320|Dog dander IgE | Serum | Allergy|
|Lentil IgE level, blood|3011523|Lentils IgE Ab [Units/volume] in Serum|
|O_Vitamin B1 level, blood|3009438|Cobalamin (Vitamin B12) [Presence] in Blood|
|Meningococcal C Ab level, blood|3035677|Neisseria meningitidis serogroup C Ab [Units/volume] in Serum|
|IgA Kappa Heavy Chain Measurement, blood|44816756|IgA.kappa [Mass/volume] in Serum or Plasma|
|rVes v5 wasp i209 IgE level, blood|40763295|Common wasp recombinant (rVes v) 5 IgE Ab [Units/volume] in Serum|
|O_Alpha-1-antitrypsin level, blood|3031800|Alpha 1 antitrypsin actual/normal in Serum or Plasma|
|O_Urate level, urine|40789966|Urate | Urine|
|BRAF Mutation Analysis|3039156|BRAF gene targeted mutation analysis in Blood or Tissue by Molecular genetics method|
|House dust mite IgE level, blood|3018381|European house dust mite IgG Ab [Presence] in Blood|
|Rheumatoid factor activity, blood|3022120|Rheumatoid factor [Presence] in Body fluid|
|CD8 Naïve T Cells, blood|3020470|CD8+CD28+ cells/cells in Blood|
|O_Lead level, blood|3016252|Lead [Presence] in Blood|
|rVes v1 wasp i211 IgE level, blood|40769374|Common wasp recombinant (rVes v) 1 IgE Ab [Units/volume] in Serum|
|% APTT normal plasma correction|21495275|aPTT normal/actual | Platelet poor plasma|
|Calculated LDL cholesterol level, blood|3028288|Cholesterol in LDL [Mass/volume] in Serum or Plasma by calculation|
|O_Birch IgE level, blood|40763989|Silver Birch IgE Ab/IgE total in Serum|
|Collagen and ADP platelet func, blood|3027391|Platelet function (closure time) collagen+ADP induced [Time] in Blood|
|CD8 T cell count|37063092|CD8 cells | Blood | Cell markers|
|GABA(a)R antibody, CSF|1259910|GABAAR IgG Ab [Presence] in Cerebral spinal fluid by Cell binding immunofluorescent assay|
|Gamma-glutamyl transpeptidase, blood|40773660|Gamma Glutamyl Transferase | Body Fluid|
|Date IgE level, blood|3022086|Dates IgE Ab [Units/volume] in Serum|
|O_Ferritin level, blood|3011961|Ferritin [Mass/volume] in Blood|
|Edoxaban level, blood|42528613|Edoxaban [Mass/volume] in Serum or Plasma by LC/MS/MS|
|O_Calcitonin level, blood|3018840|Calcitonin [Moles/volume] in Serum or Plasma|
|BCR-ABL:ABL IS %|40788128|BCR/ABL|
|Glucose level 60min, plasma|36660135|Glucose [Mass/volume] in Serum or Plasma --30 min post meal|
|O_Inorganic phosphate level, blood|3018913|Phosphate [Moles/volume] in Blood|
|POC - CALC Base Excess|40789844|Base Excess | Bld-Ser-Plas|
|Egg IgE level, blood|40764099|Egg white IgE Ab/IgE total in Serum|
|r Gly m 5 soy f431 IgE level, blood|43533744|Soybean native (nGly m) 5 IgE Ab [Units/volume] in Serum|
|Protein electrophoresis, blood|3032868|Hemoglobin electrophoresis panel in Blood|
|Mixed trees IgE level, blood|40652457|(Acer negundo+Betula verrucosa+Quercus alba+Ulmus americana+Juglans californica) Ab.IgE|Arbitrary Concentration|Moment in time|Blood, Serum or Plasma|
|O_Rape pollen IgE level, blood|37034737|Rape Pollen (Brassica napus pollen) IgE | Serum | Allergy|
|O_Lipase level, blood|3004905|Lipase [Enzymatic activity/volume] in Serum or Plasma|
|Blast cell %, blood|3025159|Blasts/Leukocytes in Blood|
|Red blood cell count, blood|37059055|Erythrocytes | Blood | Hematology and Cell counts|
|O_Peanut IgE level, blood|40763980|Peanut IgE Ab/IgE total in Serum|
|POC - Aspartate aminotransferase|40787003|Aspartate Aminotransferase | Bld-Ser-Plas|
|O_Melon IgE level, blood|40761046|Watermelon IgE Ab/IgE total in Serum|
|HDL cholesterol level, blood|3011884|Cholesterol in HDL [Presence] in Serum or Plasma|
|O_Alpha-galactosidase enzyme level,blood|3004671|Alpha galactosidase A [Enzymatic activity/volume] in Serum or Plasma|
|O_Mosquito IgE level, blood|40763969|Aedes mosquito IgE Ab/IgE total in Serum|
|O_Apple IgE level, blood|3025646|Apple Tree IgE Ab [Units/volume] in Serum|
|Procalcitonin level, blood|3046279|Procalcitonin [Mass/volume] in Serum or Plasma|
|O_Urate level, blood|1989097|Urate [Mass/volume] in Blood|
|r Gly m 6 soy f432 IgE level, blood|40768460|Soybean native (nGly m) 6 IgE Ab [Units/volume] in Serum|
|NMDA receptor antibody, blood|42529112|NMDAR IgG Ab [Presence] in Serum or Plasma by Immunofluorescence|
|Serum transferrin receptor, blood|3046569|Transferrin receptor.soluble [Moles/volume] in Serum or Plasma|
|Cryoglobulin comment, blood|3028490|Cryoglobulin [Mass/volume] in Blood|
|CD3 T cell percentage|3011412|CD3 cells [#/volume] in Blood|
|Titin, CSF|1616984|Titin Ab [Units/volume] in Cerebral spinal fluid by Line blot|
|Elastase 1 level, faeces|3034965|Elastase.pancreatic [Presence] in Stool|
|O_Vitamin B12 and folate level, blood|3009438|Cobalamin (Vitamin B12) [Presence] in Blood|
|Factor VIII level, blood|40779886|Factor VIII | patient|
|O_Transferrin level, blood|40763571|Iron/Transferrin [Ratio] in Serum or Plasma|
|Cortisol level 240min, serum|37079814|Cortisol^30M post 250 ug corticotropin IM|Moment in time|Serum or Plasma|
|Hyaluronic acid level, serum|3009931|Hyaluronate [Mass/volume] in Serum or Plasma|
|Conjugated bilirubin level, blood|3005772|Bilirubin.conjugated [Moles/volume] in Serum or Plasma|
|O_Glucose level, CSF|40776788|Glucose | Cerebral spinal fluid|
|gp210 antibody by Immunoblot|40759835|Nuclear pore protein gp210 Ab [Presence] in Serum by Immunoblot|
|Lupine seed IgE level, blood|3029411|Lupin seed IgE Ab [Units/volume] in Serum|
|Leucocyte immunophenotyping, blood|40758359|Immunophenotyping study|
|Phytanic acid level, plasma|3003011|Phytanate (C16:0(CH3)4) [Mass/volume] in Serum or Plasma|
|Bet v 1 birch t215 IgE level, blood|40768464|Silver birch native (nBet v) 1 IgE Ab [Units/volume] in Serum|
|APTT 50:50 mix, blood|37037324|aPTT | Blood | Coagulation|
|O_Potato IgE level, blood|3009883|Potato IgE Ab [Units/volume] in Serum|
|Cystatin C level, blood|3051083|Cystatin C [Mass/volume] in Urine|
|O_Soya bean IgE level, blood|40764032|Soybean IgE Ab/IgE total in Serum|
|Lymphocyte %, blood|3019198|Lymphocytes [#/volume] in Blood|
|Holotranscobalamin, blood|3009438|Cobalamin (Vitamin B12) [Presence] in Blood|
|O_Chicken IgE level, blood|3047420|Chicken IgE Ab/IgE total in Serum|
|Aldosterone level 0min, plasma|40654277|Aldosterone|Moment in time|Serum or Plasma|360.45 g/mole|
|Iohexol half life|3032437|Iohexol renal clearance in Urine and Serum or Plasma|
|O_Pepper IgE level, blood|3032718|Black Pepper IgE Ab/IgE total in Serum|
|DRVVT correction, blood|21495301|dRVVT percent correction | Platelet poor plasma|
|Glucose level 0min, plasma|3004723|Glucose [Mass/volume] in Serum or Plasma --1 minute post 0.5 g/kg glucose IV|
|CD4 TReg Cells, blood|3014037|CD3+CD4+ (T4 helper) cells/cells in Blood|
|O_Maize/Corn IgE level, blood|40764088|Corn IgE Ab/IgE total in Serum|
|Bet v 2 birch t216 IgE level, blood|40763988|White Birch IgE Ab/IgE total in Serum|
|O_Cortisol level 45min, blood|40654660|Cortisol|24 hours|Urine|362.466 g/mole|
|CD19 B cells count|36303804|IgM cells/Cells.CD19 in Blood|
|IgM Kappa Heavy Chain Measurement, blood|44816758|IgM.kappa [Mass/volume] in Serum or Plasma|
|Day 3 Cortisol level, serum|3033285|Cortisol [Mass/volume] in Serum or Plasma --3 PM specimen|
|Rat mix IgE level, blood|37063168|Rat Ab.IgE | Serum | Allergy|
|Lymphocyte count, blood|3019198|Lymphocytes [#/volume] in Blood|
|Thiopentone level, blood|37030814|Thiopental | Dose | Drug doses|
|Fibrinogen alpha gene, blood|1618662|Fibrinogen | Blood | Coagulation|
|O_Protein level, urine|3037121|Protein [Mass/volume] in Urine|
|Timothy grass IgE level, blood|40764057|Timothy IgE Ab/IgE total in Serum|
|Growth hormone level 30min, serum|40760100|Somatotropin [Mass/volume] in Serum or Plasma --30 minutes post resting|
|O_Lentil IgE level, blood|3011523|Lentils IgE Ab [Units/volume] in Serum|
|Cortisol level 60min, serum|37079776|Cortisol^1.5H post 1 ug/kg CRH IV|Moment in time|Serum or Plasma|
|Cortisol level 90min, serum|37079776|Cortisol^1.5H post 1 ug/kg CRH IV|Moment in time|Serum or Plasma|
|Occult blood detection, faeces|3030153|Occult blood panel - Stool|
|Growth hormone level 90min, serum|40760101|Somatotropin [Mass/volume] in Serum or Plasma --90 minutes post resting|
|O_Amino acids level, CSF|3030371|Amino acids [Moles/volume] in Cerebral spinal fluid|
|Nitrites Urine Dipstick|3021601|Nitrite [Presence] in Urine by Test strip|
|THSD7A Ab, blood|1001604|THSD7A IgG Ab [Presence] in Serum or Plasma by Immunofluorescence|
|O_Wasp venom IgE level, blood|3004274|Wasp venom IgE Ab [Units/volume] in Serum|
|O_Thyroid stimulating hormone, blood|3011450|Thyrotropin [Presence] in Blood|
|ACTH level 60min, plasma|37079704|Corticotropin^1.5H post 1 ug/kg CRH IV|Moment in time|Plasma|
|Vitamin E:lipid ratio|40762341|Tocopherols/Cholesterol [Molar ratio] in Serum or Plasma|
|25 vitamin D comment|40775515|25-Hydroxyvitamin D | Bld-Ser-Plas|
|O_Protein level, fluid|3005029|Protein [Mass/volume] in Body fluid|
|O_Glucose level 30min, blood|36660135|Glucose [Mass/volume] in Serum or Plasma --30 min post meal|
|Bet v 6 birch t225 IgE level, blood|40763988|White Birch IgE Ab/IgE total in Serum|
|O_Anti-nuclear Ab level (Hep-2), blood|40762162|Nuclear Ab [Presence] in Serum by Hep2 substrate|
|Lipids comment|40797104|Lipids | Bld-Ser-Plas|
|Methaemoglobin level, blood|3005147|Methemoglobin [Mass/volume] in Blood|
|O_Pea IgE level, blood|40764061|Pea IgE Ab/IgE total in Serum|
|POC - Lactate|40773388|Lactate | Bld-Ser-Plas|
|O_Carbamazepine level, blood|3028415|carBAMazepine [Presence] in Serum or Plasma|
|O_Glycine receptor antibody, blood|36031870|Glycine receptor Ab [Presence] in Serum or Plasma by Immunofluorescence|
|O_Gamma-glutamyl transpeptidase, blood|40773660|Gamma Glutamyl Transferase | Body Fluid|
|vWF collagen binding level, blood|40778470|von Willebrand factor (vWf).collagen binding activity | Platelet poor plasma|
|O_Occult blood detection, faeces|3030153|Occult blood panel - Stool|
|O_Levetiracetam level, blood|3020666|levETIRAcetam [Mass/volume] in Serum or Plasma|
|G6PD level, blood|44787112|Glucose-6-Phosphate dehydrogenase/Pyruvate kinase [Ratio] in Blood|
|ACTH level 90min, plasma|37079704|Corticotropin^1.5H post 1 ug/kg CRH IV|Moment in time|Plasma|
|O_Farm birds feather mix IgE level,blood|40764098|Chicken feather IgE Ab/IgE total in Serum|
|Estimated Osmolality (BG)|40790260|Osmolality | Bld-Ser-Plas|
|Valproate level, blood|3009466|Valproate [Moles/volume] in Serum or Plasma|
|O_C1 esterase inhibitor function, blood|3000391|Complement C1 esterase inhibitor.functional [Presence] in Serum or Plasma|
|O_Cucumber IgE, blood|37034420|Cucumber (Cucumis sativus) IgE | Serum | Allergy|
|O_vWF collagen binding level, blood|40778470|von Willebrand factor (vWf).collagen binding activity | Platelet poor plasma|
|O_Urea and electrolytes, blood|3009810|Urea [Mass/volume] in Blood|
|ACTH level 120min, plasma|37079704|Corticotropin^1.5H post 1 ug/kg CRH IV|Moment in time|Plasma|
|Amphiphysin Abs, blood|3045706|Amphiphysin Ab [Presence] in Serum|
|Apixaban level, blood|43055442|Apixaban [Mass/volume] in Serum or Plasma|
|O_Renin level, blood|3037310|Renin [Mass/volume] in Plasma|
|Mouse IgE level, blood|3012904|Mouse multi IgE Ab [Units/volume] in Serum|
|CD4 T cell count|37044455|CD4 cells | Blood | Cell markers|
|O_17alphahydroxyprogesterone level,blood|3028718|17-Hydroxyprogesterone [Mass/volume] in Serum or Plasma|
|O_Smooth muscle antibodies level, blood|3053270|Smooth muscle IgG Ab [Titer] in Serum|
|O_Albumin level, blood|40786515|Albumin concentration | patient|
|Bcr-abl:abl ratio, blood|40788128|BCR/ABL|
|Alpha-fetoprotein level, blood|3025053|Alpha-1-Fetoprotein [Presence] in Serum or Plasma|
|O_Gastrin level, blood|3009927|Gastrin [Mass/volume] in Serum or Plasma|
|PML-RARA gene screen, blood|3022546|t(15;17)(q24.1;q21.1)(PML,RARA) cells/Cells.total in Blood or Tissue by Molecular genetics method|
|Factor VIII genetics, blood|40779886|Factor VIII | patient|
|Liver immunoblot comment|40759838|Liver cytosol Ab [Presence] in Serum by Immunoblot|
|O_Conjugated bilirubin level, blood|3005772|Bilirubin.conjugated [Moles/volume] in Serum or Plasma|
|Renin level 0min, plasma|3037310|Renin [Mass/volume] in Plasma|
|Recoverin, CSF|36208146|Recoverin | Bld-Ser-Plas|
|Glucose level 120min, plasma|36660183|Glucose [Mass/volume] in Serum or Plasma --15 min post meal|
|rApi m1 bee i208 IgE level, blood|42528783|Honey bee recombinant (rApi m) 10 IgE Ab [Units/volume] in Serum|
|O_Thyroglobulin level, blood|3036535|Thyroglobulin [Mass/volume] in Serum or Plasma|
|O_Fibrinogen level, blood|1618662|Fibrinogen | Blood | Coagulation|
|O_Glucagon level, blood|40769394|Glucagon [Mass or Moles/volume] in Serum or Plasma|
|Alpha-1-antitrypsin genotype, blood|40652551|Alpha 1 antitrypsin phenotype|Impression/interpretation of study|Moment in time|Blood, Serum or Plasma|
|Dabigatran level, blood|43055459|Dabigatran [Mass/volume] in Serum or Plasma|
|Factor XIII level, blood|40791728|Coagulation factor XIII | Platelet poor plasma|
|Cryoglobulin type, blood|3000429|Cryoglobulin type [Identifier] in Serum by Electrophoresis|
|Hu Ab (blot), blood|42529573|Ha Ab [Presence] in Serum by Line blot|
|Alternative complement pathway function|44817515|Complement functional activity.alternative pathway | Bld-Ser-Plas|
|O_C3 nephritic factor level, blood|3048069|C3 nephritic factor [Presence] in Serum or Plasma|
|O_House dust mite IgE level, blood|3018381|European house dust mite IgG Ab [Presence] in Blood|
|O_PML-RARA gene screen, blood|3022546|t(15;17)(q24.1;q21.1)(PML,RARA) cells/Cells.total in Blood or Tissue by Molecular genetics method|
|O_Cortisol level 240min, blood|40654660|Cortisol|24 hours|Urine|362.466 g/mole|
|O_Lactate dehydrogenase level, blood|3016436|Lactate dehydrogenase [Enzymatic activity/volume] in Serum or Plasma|
|Adalimumab Anti-Drug Ab, blood|36304052|Adalimumab Ab [Units/volume] in Serum or Plasma|
|Neutrophil function by flow cytometry|36203200|Neutrophils [#/volume] in Control Blood by Flow cytometry (FC)|
|Total IgE level, blood|40786727|Total IgE | Bld-Ser-Plas|
|Day 1 Cortisol level, serum|40757367|Cortisol [Mass/volume] in Serum or Plasma --9 AM 2nd day specimen|
|O_NMDA receptor antibody, blood|42529112|NMDAR IgG Ab [Presence] in Serum or Plasma by Immunofluorescence|
|Bet v 4 birch t220 IgE level, blood|40763988|White Birch IgE Ab/IgE total in Serum|
|Insulin level 0min, blood|3029871|Glucose [Mass/volume] in Serum or Plasma --15 minutes post 0.1 U/kg insulin|
|O_Haemophilus influenzae B Ab levelblood|3019830|Haemophilus influenzae B Ab [Units/volume] in Serum|
|O_Creatinine level, dialysate|40796640|Creatinine | Dialysis fluid|
|O_vWF Ag, blood|37030250|Wr^a Ag | Red Blood Cells | Blood bank|
|Day 1 ACTH level, plasma|40757368|Corticotropin [Mass/volume] in Plasma --9 AM 2nd day specimen|
|Apolipoprotein B level, blood|3014791|Apolipoprotein B [Mass/volume] in Serum or Plasma|
|O_Shrimp IgE level, blood|3021226|Shrimp IgE Ab [Units/volume] in Serum|
|O_Prolactin level, blood|40653604|Prolactin|Arbitrary Concentration|Moment in time|Blood, Serum or Plasma|
|O_Platelet nucleotides, blood|36205738|Adenosine diphosphate | Platelets|
|Factor VIII inhibitor porcine, blood|40780833|Coagulation Factor VIII Inhibitor | Platelet poor plasma|
|Cortisol level, serum|37079848|Cortisol^baseline|Moment in time|Serum or Plasma|
|O_Lupine seed IgE level, blood|3029411|Lupin seed IgE Ab [Units/volume] in Serum|
|Haemoglobinopathy screen, blood|1989112|Hemoglobinopathy panel|
|Chilli pepper IgE level, blood|3966718|Chili Pepper IgE Ab [Presence] in Serum by Radioallergosorbent test (RAST)|
|O_Lupus anticoagulant screen, blood|37075803|Lupus anticoagulant three screening tests W Reflex panel | Platelet poor plasma | Coagulation Panels|
|O_Glucose level, blood|3020491|Glucose [Moles/volume] in Blood|
|Malaria Ag screen, blood|37065629|Plasmodium falciparum Ag | Blood | Microbiology|
|Mitochondrial Ab level, blood|3034770|Mitochondria Ab [Titer] in Serum|
|Total protein level, blood|1469680|Protein [Mass/volume] in Blood|
|Black olive IgE level, blood|40761121|Olive Pollen IgE Ab/IgE total in Serum|
|O_Factor IX level, blood|40796340|Factor IX | patient|
|Dexamethasone level(Overnight Dex Supp)|37079850|Cortisol^post 1 mg dexamethasone PO overnight|Moment in time|Serum or Plasma|
|Vitamin E level, serum|3006398|Tocopherols [Moles/volume] in Serum or Plasma|
|Cortisol level 0min, serum|37079776|Cortisol^1.5H post 1 ug/kg CRH IV|Moment in time|Serum or Plasma|
|O_Elastase 1 level, faeces|3034965|Elastase.pancreatic [Presence] in Stool|
|dsDNA Ab level, blood|3007916|DNA double strand Ab [Titer] in Serum|
|O_Tryptase level, blood|40655567|Tryptase|Moment in time|Serum or Plasma|725.8 g/mole|
|O_Gluten IgE level, blood|40764031|Gluten IgE Ab/IgE total in Serum|
|CA-19-9 level, fluid|40783961|Cancer Ag 19-9 | Body Fluid|
|Urea level 0min, blood|40655587|Urea nitrogen|Moment in time|Blood|
|O_Amikacin level, blood|3030247|Amikacin [Moles/volume] in Serum or Plasma --trough|
|O_Factor VIII level, blood|40779886|Factor VIII | patient|
|O_ACTH pre-15min, blood|37079720|Corticotropin^15M pre 1 ug/kg CRH IV|Moment in time|Plasma|
|pO2 (BG)|40774072|Oxygen | Gas|
|Iohexol GFR|3966002|Iohexol renal clearance in Serum or Plasma or Urine|
|Plasma Metadrenaline comments|3050154|Catecholamines [Interpretation] in Plasma Narrative|
|CD8 Central Memory T Cells, blood|37063092|CD8 cells | Blood | Cell markers|
|O_Dog dander IgE, blood|37038362|Dog dander Ab.IgE/IgE.total | Serum | Allergy|
|Live cell NMDA receptor antibody, blood|42529112|NMDAR IgG Ab [Presence] in Serum or Plasma by Immunofluorescence|
|vWF Ag, blood|40793851|von Willebrand Factor (vWf) Ag | Platelet poor plasma|
|O_Ciclosporin level, blood|3010375|cycloSPORINE [Mass/volume] in Blood|
|O_HDL cholesterol level, blood|3011884|Cholesterol in HDL [Presence] in Serum or Plasma|
|Potassium level 240min, blood|3040170|Potassium [Mass/time] in 24 hour Urine|
|U-snRNP Ab level, blood|1094468|U1 small nuclear ribonucleoprotein Ab|Arbitrary Concentration|Moment in time|Blood, Serum or Plasma|
|O_Mitochondrial Abs, blood|40653338|Mitochondria Ab|Presence or Threshold|Moment in time|Blood, Serum or Plasma|
|Parathyroid hormone level, plasma|37022114|Parathyroid Hormones-|
|Coagulation sample comment|45876003|Coagulation study|
|Nut mix FX22 IgE level, blood|3052099|Cashew nut IgE Ab/IgE total in Serum|
|CD4 Central Memory T Cells, blood|3014037|CD3+CD4+ (T4 helper) cells/cells in Blood|
|Mixed moulds IgE level, blood|3002073|Dry-rot Fungus IgE Ab [Units/volume] in Serum|
|O_Lipoprotein (a) level, blood|40763399|Lipoprotein a/total Lipoprotein in Serum or Plasma|
|O_Amoxycilloyl IgE level, blood|3031955|Amoxicillin IgE Ab/IgE total in Serum|
|Other bird serum proteins IgG antibodies|37040479|Chicken serum proteins IgG | Serum | Allergy|
|O_Leucocyte immunophenotyping, blood|40758359|Immunophenotyping study|
|Metadrenaline level, plasma|3046750|Metanephrine and Normetanephrine [Interpretation] in Serum or Plasma|
|Fat level, faeces|3016508|Fat [Mass/volume] in Stool|
|Rivaroxaban level, blood|43055458|Rivaroxaban [Mass/volume] in Serum or Plasma|
|Quail serum proteins IgG antibodies|1618776|Quail meat IgE | Serum | Allergy|
|O_Pristanic acid level, blood|3003547|Pristanate (C15:0(CH3)4) [Mass/volume] in Serum or Plasma|
|IgH gene rearrangement screen, blood|21492159|IGH gene rearrangements [Presence] in Blood or Tissue by FISH|
|O_Caffeine level, blood|3028609|Caffeine [Moles/volume] in Serum or Plasma|
|O_CA-19-9 level, fluid|40783961|Cancer Ag 19-9 | Body Fluid|
|O_Troponin I level, blood|3033745|Troponin I.cardiac [Mass/volume] in Blood|
|O_Chilli pepper IgE level, blood|3966718|Chili Pepper IgE Ab [Presence] in Serum by Radioallergosorbent test (RAST)|
|Fixed cell NMDA receptor antibody, CSF|21497395|N-methyl-D-aspartate receptor IgG | Cerebral spinal fluid|
|O_Timothy grass IgE level, blood|40764057|Timothy IgE Ab/IgE total in Serum|
|Omega-5 Gliadin IgE level, blood|40784882|Omega 5 gliadin | Bld-Ser-Plas|
|Honey IgE level, blood|3043963|Honey bee IgE Ab/IgE total in Serum|
|O_Protein level, CSF|3010719|Protein in CSF/Protein in serum|
|Pituitary Ab comment|40788874|Pituitary Ab | Bld-Ser-Plas|
|C26:C22 ratio serum level, blood|36305043|Palmitoylcarnitine (C16)/Acetylcarnitine (C2) [Molar ratio] in Serum or Plasma|
|Vitamin D2 level, blood|36031776|25-hydroxyvitamin D2 [Mass/volume] in Capillary blood|
|O_Cockatiel Ab level, blood|40764110|Cockatiel feather IgE Ab/IgE total in Serum|
|Brain natriuretic peptide level, blood|3031569|Natriuretic peptide B [Mass/volume] in Blood|
|Myositis immunoblot blood comment|43055089|Myosin Ab [Presence] in Serum or Plasma by Immunoblot|
|Other haematology Special comments|37073373|Other observations | Bone marrow | Hematology and Cell counts|
|POC - CALC Saturated O2|40775902|Oxygen saturation.calculated from oxygen partial pressure|
|O_Gentamicin level, blood|3053140|Gentamicin [Moles/volume] in Serum or Plasma|
|O_Black olive IgE level, blood|3036474|Olive IgE Ab [Units/volume] in Serum|
|Ferret IgE level, blood|40764104|Ferret epithelium IgE Ab/IgE total in Serum|
|Factor XII level, blood|40798286|Coagulation factor XII | Platelet poor plasma|
|O_Cortisol level 30min, blood|3007363|Cortisol [Mass/volume] in Serum or Plasma --30 minutes post XXX challenge|
|GABA(a)R antibody, blood|42529108|GABABR IgG Ab [Presence] in Serum or Plasma by Immunofluorescence|
|O_Amino acids level, blood|3011743|Amino acids [Identifier] in Blood|
|O_Date IgE level, blood|3022086|Dates IgE Ab [Units/volume] in Serum|
|O_Cystatin C level, blood|3030366|Cystatin C [Mass/volume] in Serum or Plasma|
|Total bile acids comment|1259500|Chenodeoxycholate+Cholate/Bile acid.total in Stool|
|Thyroid peroxidase Ab level, blood|3043429|Thyroperoxidase Ab [Titer] in Serum or Plasma|
|O_Apolipoprotein B level, blood|3014791|Apolipoprotein B [Mass/volume] in Serum or Plasma|
|Free T4 level, blood|3008598|Thyroxine (T4) free [Mass/volume] in Serum or Plasma|
|Vitamin D level, blood|36031776|25-hydroxyvitamin D2 [Mass/volume] in Capillary blood|
|O_IgG subclasses level, blood|3024139|IgG subclass 3 [Mass/volume] in Serum|
|Amyloid level, Serum|37078640|Amyloid A | Serum or Plasma | Chemistry - non-challenge|
|Live cell NMDA receptor antibody, CSF|42529991|NMDAR IgG | Cerebral spinal fluid|
|IGF-1 level 0min, blood|3007922|Insulin-like growth factor-I [Mass/volume] in Blood|
|Iohexol comments|1002425|Iohexol [Mass/volume] in Urine|
|Hepcidin level, serum|3052622|Pro-hepcidin [Mass/volume] in Serum or Plasma|
|O_CD4 immune monitoring, blood|3007622|Deprecated CD4 in Blood|
|O_Methotrexate level, blood|3017115|Methotrexate [Moles/volume] in Serum or Plasma|
|F-Actin antibody by Immunoblot|43055089|Myosin Ab [Presence] in Serum or Plasma by Immunoblot|
|Sodium level 0min, blood|3000285|Sodium [Moles/volume] in Blood|
|Switched memory (IgD- CD27+) - % B cells|21493679|CD27-IgD+ cells/Cells.CD19+CD20+ in Blood|
|O_Vancomycin level, blood|3039257|Vancomycin [Moles/volume] in Serum or Plasma --trough|
|Additional Paraneoplastic Abs, CSF|40794971|Paraneoplastic Ab | Cerebral spinal fluid|
|Cortisol level 120min, serum|37079786|Cortisol^12 AM specimen|Moment in time|Serum or Plasma|
|Fish mix FX2 IgE level, blood|3043915|Codfish IgE Ab/IgE total in Serum|
|Antithrombin III activity, blood|40788038|Prothrombin activity | Platelet poor plasma|
|O_Factor XIII level, blood|37069778|Coagulation factor XIII Ag actual/Normal | Platelet poor plasma | Coagulation|
|Bee venom IgE level, blood|3043963|Honey bee IgE Ab/IgE total in Serum|
|O_Haemoglobin S genotype screen, blood|37065325|Hemoglobin S inferred phenotype | Blood or Tissue | Blood bank genotyping|
|General urine comment|3014315|Urine output|
|O_Interferon gamma release, blood|3010105|Interferon gamma [Mass/volume] in Serum or Plasma|
|O_Cortisol level 60min, blood|40654660|Cortisol|24 hours|Urine|362.466 g/mole|
|O_TSH receptor Ab level, blood|42528824|Thyrotropin receptor Ab [Presence] in Serum|
|EGFR Mutation Analysis|37035345|EGFR gene targeted mutation analysis | Blood or Tissue | Mutations|
|SLA/LP antibody by Immunoblot|40759864|PL-12 Ab [Presence] in Serum by Immunoblot|
|Food mix FX5 IgE level, blood|3007307|Food Allergen Mix fx73 (Beef+Chicken+Pork) IgE Ab [Presence] in Serum by Multidisk|
|POC - Ionised calcium|40786636|Calcium.ionized | Bld-Ser-Plas|
|Warfarin comment|40778780|Warfarin | XXX|
|O_Alpha-fetoprotein level, blood|3025053|Alpha-1-Fetoprotein [Presence] in Serum or Plasma|
|O_Rheumatoid factor, blood|40653668|Rheumatoid factor|Titer|Moment in time|Blood, Serum or Plasma|
|O_Fat level, faeces|3016508|Fat [Mass/volume] in Stool|
|O_Free T3 level, blood|3030886|Triiodothyronine (T3) Free [Mass or Moles/volume] in Serum or Plasma|
|Growth hormone level 60min, serum|3052612|Somatotropin [Units/volume] in Serum or Plasma --45 minutes post dose growth hormone releasing factor|
|7-alpha cholestenone level comment|37025470|7-Alpha hydroxy-4-cholesten-3-one | Blood | Chemistry - non-challenge|
|Pemphigoid Ab level, blood|1470029|P200 pemphigoid IgG Ab [Presence] in Serum or Plasma by Immunofluorescence|
|50:50 normal plasma DRVVT, blood|37024754|dRVVT actual/Normal | Platelet poor plasma | Coagulation|
|Salmonella typhi IgG antibodies|40777217|Salmonella enteritidis IgG | Egg Yolk|
|Infliximab Anti-Drug Ab, blood|43055457|inFLIXimab Ab [Mass/volume] in Serum or Plasma|
|Vitamin A level, blood|3006352|Retinol [Mass/volume] in Blood|
|O_Cortisol level 90min, blood|37079778|Cortisol^10 AM specimen|Moment in time|Serum or Plasma|
|Prothrombin time 50:50 mix, blood|3034426|Prothrombin time (PT)|
|ACTH level 0min, plasma|37079776|Cortisol^1.5H post 1 ug/kg CRH IV|Moment in time|Serum or Plasma|
|O_G6PD level, blood|44787112|Glucose-6-Phosphate dehydrogenase/Pyruvate kinase [Ratio] in Blood|
|Titin Abs, blood|3967180|Titin Ab|Presence or Threshold|Moment in time|Blood, Serum or Plasma|
|Vancomycin timing, CSF|3040396|Vancomycin [Mass/volume] in Cerebral spinal fluid --peak|
|Ristocetin cofactor assay, blood|36306070|von Willebrand factor.ristocetin cofactor inhibitor [Units/volume] in Platelet poor plasma by Coagulation assay|
|Platelet genetics full sequencing Band 3|1761870|Platelet disorders multigene analysis in Blood or Tissue by Sequencing|
|Mutton IgE level, blood|3041637|Turkey meat IgE Ab/IgE total in Serum|
|Coriander IgE level, blood|37077005|Cilantro (Coriandrum sativum) IgE | Serum | Allergy|
|Alpha-galactosidase enzyme comment|37055387|Alpha galactosidase A | White blood cells | Chemistry - non-challenge|
|IgG Lambda Heavy Chain Measurement, bloo|3004640|Lambda light chains [Mass/volume] in Serum or Plasma|
|ADP platelet agglutination, blood|3017055|Platelet aggregation ADP induced in Platelet rich plasma|
|Gentamicin timing, CSF|3000160|Gentamicin [Mass/volume] in Cerebral spinal fluid|
|Paracetamol level, blood|40763107|Acetaminophen [Mass/volume] in Blood|
|vWF activity level, blood|40792298|von Willebrand factor (vWf).activity | Platelet poor plasma|
|Insulin level 120min, blood|36660450|Insulin [Units/volume] in Serum or Plasma --15 min post meal|
|O_Mutton IgE level, blood|3011777|Horse meat IgE Ab [Units/volume] in Serum|
|C24:C22 ratio serum level, blood|36303549|Tetradecenoylcarnitine (C14:1)/Acetylcarnitine (C2) [Molar ratio] in Serum or Plasma|
|Hb (BG)|40789986|Hemoglobin | Bld-Ser-Plas|
|Platelet nucleotides comment|36208792|Adenosine triphosphate | Platelets|
|Troponin I - POC|40783217|Troponin I.cardiac | Bld-Ser-Plas|
|Bcr-abl multiplex, blood|40788128|BCR/ABL|
|Red blood cell vitamin B2, blood|40784483|Boron | Red Blood Cells|
|Red blood cell vitamin B1, blood|3009438|Cobalamin (Vitamin B12) [Presence] in Blood|
|Urine 5-HIAA comment|40780068|5-hydroxyhexanoate | Urine|
|O_Pneumococcal serotype antibodies, bloo|40774373|Streptococcus pneumoniae serotype IgG | Bld-Ser-Plas|
|Suxamethonium IgE level, blood|3005103|Succinylcholine IgE Ab [Units/volume] in Serum|
|Growth hormone level, serum|3023709|Somatotropin [Mass/volume] in Serum or Plasma|
|O_Suxamethonium IgE level, blood|3005103|Succinylcholine IgE Ab [Units/volume] in Serum|
|Growth hormone level 150min, serum|40760101|Somatotropin [Mass/volume] in Serum or Plasma --90 minutes post resting|
|Band forms count, blood|3018199|Band form neutrophils [#/volume] in Blood|
|POC - Albumin|40785508|Albumin | fetus|
|O_Glucose level 90min, blood|3020260|Glucose [Mass/volume] in Serum or Plasma --45 minutes post 100 g glucose PO|
|O_Other specific IgE (RAST) test|3966278|Miscellaneous allergen IgE Ab [Presence] in Serum by Radioallergosorbent test (RAST)|
|P3NP level, serum|3038143|Amylase.P3/Amylase.total in Serum or Plasma|
|Chromogranin B level, blood|3014702|Chromogranin A [Moles/volume] in Serum or Plasma|
|O_Honey IgE level, blood|3043963|Honey bee IgE Ab/IgE total in Serum|
|Xanthochromia comments|3025217|Xanthochromia [Presence] of Body fluid Qualitative|
|O_Valproate level, blood|3009466|Valproate [Moles/volume] in Serum or Plasma|
|O_Bile acid level, blood|3043231|Bile acid [Presence] in Bile fluid|
|nGal d 1 ovomucoid f233 IgE level, blood|40761901|Conalbumin native (nGal d) 3 IgE Ab [Units/volume] in Serum|
|POC - Non-HDL|40797515|Cholesterol non HDL | Bld-Ser-Plas|
|O_Factor V level, blood|36206748|V | Red Blood Cells|
|Platelet genetics full sequencing Band 1|1761870|Platelet disorders multigene analysis in Blood or Tissue by Sequencing|
|Creatinine level 0min, blood|3040510|Creatinine [Moles/time] in 1 hour Urine|
|AMPA2 receptor antibody|42529111|AMPAR2 IgG Ab [Presence] in Serum or Plasma by Immunofluorescence|
|Platelet genetics full sequencing Band 2|1761870|Platelet disorders multigene analysis in Blood or Tissue by Sequencing|
|Factor VIII inhibitor level, blood|3011699|Coagulation factor VIII inhibitor [Presence] in Platelet poor plasma by Coagulation assay|
|O_Growth hormone level 90min, blood|40760101|Somatotropin [Mass/volume] in Serum or Plasma --90 minutes post resting|
|Progesterone screen, blood|37080188|Progesterone^10th specimen post XXX challenge|Moment in time|Serum or Plasma|
|Urine period|3007876|Appearance of Urine|
|Arachidonic acid plat agg, blood|37065491|Arachidonate/Eicosapentaenoate | Blood | Chemistry - non-challenge|
|Cortisol level (Overnight Dex Supp Test|37079850|Cortisol^post 1 mg dexamethasone PO overnight|Moment in time|Serum or Plasma|
|O_Growth hormone level 30min, blood|3048799|Somatotropin [Units/volume] in Serum or Plasma --30 minutes post dose glucose PO|
|Anti-Mullerian hormone level, serum|3049799|Mullerian inhibiting substance [Moles/volume] in Serum or Plasma|
|O_Mixed moulds IgE level, blood|3002073|Dry-rot Fungus IgE Ab [Units/volume] in Serum|
|O_C-reactive protein level, blood|3051387|C reactive protein [Mass/volume] in Capillary blood|
|Myeloid panel|37069265|Hematology and Cell Count Panels|
|Acetylcholine receptor abs IIF, blood|1472299|Acetylcholine receptor Ab|Presence or Threshold|Moment in time|Blood, Serum or Plasma|
|O_Digoxin level, blood|3027456|Digoxin [Moles/volume] in Serum or Plasma|
|La Ab level, blood|3015788|Le Ab [Presence] in Serum or Plasma from Blood product unit|
|O_PNH cell marker analysis, blood|37037219|PNH GPI-Linked WBC and RBC Ag | Blood | Cell markers|
|Lymphocyte function test, flow cytometry|3012323|Lymphocytes/Leukocytes in Blood by Flow cytometry (FC)|
|O_Factor VIII inhibitor level, blood|3011699|Coagulation factor VIII inhibitor [Presence] in Platelet poor plasma by Coagulation assay|
|CD8 T cell percentage|37063092|CD8 cells | Blood | Cell markers|
|Nut mix IgE level, blood|3052099|Cashew nut IgE Ab/IgE total in Serum|
|50:50 NP DRVVT correction, blood|21495301|dRVVT percent correction | Platelet poor plasma|
|Absolute Monocytes - POC|3001604|Monocytes [#/volume] in Blood|
|Growth hormone level 120min, serum|40760101|Somatotropin [Mass/volume] in Serum or Plasma --90 minutes post resting|
|Factor V level, blood|36208909|V | Blood product unit|
|O_ACTH level 60min,blood|37079704|Corticotropin^1.5H post 1 ug/kg CRH IV|Moment in time|Plasma|
|O_Antithrombin III activity, blood|40788038|Prothrombin activity | Platelet poor plasma|
|POC - Bilirubin|40790676|Bilirubin | XXX|
|Growth hormone level 240min, serum|40760100|Somatotropin [Mass/volume] in Serum or Plasma --30 minutes post resting|
|Factor XI level, blood|37059036|Coagulation factor XI Ag actual/Normal | Platelet poor plasma | Coagulation|
|Factor IX sequencing, blood|1002139|F9 gene full mutation analysis in Blood or Tissue by Sequencing|
|Plasmablasts %, blood|3001362|Plasma cells [#/volume] in Blood|
|O_Aubergine IgE level, blood|40763994|Cabbage IgE Ab/IgE total in Serum|
|POC - Creatinine|40773228|Creatinine | Urine|
|Oestradiol level, serum|40654774|Estrogen|Moment in time|Serum or Plasma|
|O_Bee venom IgE level, blood|3013598|Hornet venom IgE Ab [Units/volume] in Serum|
|CA-15-3 level, blood|3006742|Cancer Ag 15-3 [Presence] in Serum or Plasma|
|O_Nut mix IgE level, blood|3052099|Cashew nut IgE Ab/IgE total in Serum|
|ADAMTS13 activity, blood|1989260|ADAMTS13 gene full mutation analysis in Blood or Tissue by Sequencing|
|CD8 Term. Diff. T Cells, blood|37063092|CD8 cells | Blood | Cell markers|
|Fixed cell NMDA receptor antibody, blood|42529112|NMDAR IgG Ab [Presence] in Serum or Plasma by Immunofluorescence|
|O_Haemoglobinopathy screen, blood|1989112|Hemoglobinopathy panel|
|O_Factor VIII Inhibitor screen, blood|3011699|Coagulation factor VIII inhibitor [Presence] in Platelet poor plasma by Coagulation assay|
|POC - Potassium|40798013|Potassium | Hair|
|Factor assay comments|21498098|Laboratory comment | Report|
|Specific IgE referred B|40789994|IgE | Bld-Ser-Plas|
|Warfarin Dose Next Test|37070265|Warfarin | Dose | Drug doses|
|Hu Ab level, blood|36304862|HuD Ab [Units/volume] in Serum or Plasma by Immunoassay|
|Factor VIII Inhibitor screen, blood|3011699|Coagulation factor VIII inhibitor [Presence] in Platelet poor plasma by Coagulation assay|
|Free cortisol comment|40654659|Cortisol.free|Moment in time|Urine|
|O_Phytanic acid level, blood|3003011|Phytanate (C16:0(CH3)4) [Mass/volume] in Serum or Plasma|
|Factor VIII Timed level|40779886|Factor VIII | patient|
|IgA Lambda Heavy Chain Measurement, bloo|21493214|Lambda light chains.free [Mass/volume] in Serum by Nephelometry|
|Total cholesterol level, blood|40780291|Cholesterol.total | Bld-Ser-Plas|
|O_Cortisol level 120min, blood|40654660|Cortisol|24 hours|Urine|362.466 g/mole|
|Pituitary Ab level, blood|40788874|Pituitary Ab | Bld-Ser-Plas|
|Rare Inherited Anaemia panel|1989577|Hemolytic anemia panel|
|Red blood cell vitamin B6, blood|40784483|Boron | Red Blood Cells|
|ELF Score, serum|36305723|Liver fibrosis score in Serum or Plasma by Calculated by ELF|
|Bcr-abl gene level, blood|36031192|ABL1 gene c.944C>T [Presence] in Blood or Marrow by Molecular genetics method|
|O_Bone marrow aspirate exam|3048879|Bone marrow aspiration report|
|O_Ovarian antibodies, blood|40790520|Ovary IgG | Bld-Ser-Plas|
|CV2/CRMP5, CSF|36208936|CV2 | Cerebral spinal fluid|
|Sample comment, CSF|46235436|Manual differential comment [Interpretation] in Cerebral spinal fluid Narrative|
|O_Progesterone screen, blood|37080188|Progesterone^10th specimen post XXX challenge|Moment in time|Serum or Plasma|
|O_dsDNA Ab level, blood|3007916|DNA double strand Ab [Titer] in Serum|
|BP230 Antibodies, Blood|42870951|Basement membrane zone BP230 IgG | Bld-Ser-Plas|
|Factor IX carrier sequence, blood|40796340|Factor IX | patient|
|Platelets - POC|40774642|Platelets | Blood cord|
|Growth hormone level 0min, serum|40655445|Somatotropin|Moment in time|Serum or Plasma|
|Grass pollen IgE level, blood|40761121|Olive Pollen IgE Ab/IgE total in Serum|
|nGal d 2 ovalbumin f232 IgE level, blood|40761901|Conalbumin native (nGal d) 3 IgE Ab [Units/volume] in Serum|
|Oxalate citrate comment|40796531|Citrate | Urine|
|Aubergine IgE level, blood|40763994|Cabbage IgE Ab/IgE total in Serum|
|O_Factor XII level, blood|40798286|Coagulation factor XII | Platelet poor plasma|
|POC - Urea|40796995|Urea | XXX|
|Immunoglobulin G level, blood|3040832|Hemoglobin G/Hemoglobin.total in Blood|
|O_Protein electrophoresis, blood|3020111|Hemoglobin O - Arab [Presence] in Blood by Electrophoresis alkaline (pH 8.9)|
|P53 sequencing, blood|37058240|TP53 gene targeted mutation analysis | Blood or Tissue | Mutations|
|Tree mix tx8 IgE level, blood|40764065|Cottonwood IgE Ab/IgE total in Serum|
|PRP platelet count, blood|1092269|Platelets [Presence] in Blood|
|O_Parrot Ab level, blood|40762007|Parrot feather IgG Ab [Mass/volume] in Serum|
|Factor XIII sequencing, blood|42870548|TNFRSF13B gene full mutation analysis in Blood or Tissue by Sequencing|
|Mean cell haemoglobin level, blood|40777347|Erythrocyte Mean Corpuscular Hemoglobin Concentration | Red Blood Cells|
|CD40L (Hyper IgM) Assay|37040171|CD40 cells | Blood | Cell markers|
|POC - CALC Bicarbonate|37029701|Bicarbonate | XXX | Chemistry - non-challenge|
|THSD7A Ab comment|1001604|THSD7A IgG Ab [Presence] in Serum or Plasma by Immunofluorescence|
|Factor XI full sequence, blood|40781844|Coagulation factor XI | Platelet poor plasma|
|Diphtheria Ab level, blood|3035832|Corynebacterium diphtheriae Ab [Titer] in Serum|
|Glycated haemoglobin reference, blood|3039720|Glucose mean value [Moles/volume] in Blood Estimated from glycated hemoglobin|
|Linseed IgE level, blood|1617718|Flaxseed IgE Ab [Units/volume] in Serum|
|Collagen platelet agg, whole blood|40759129|Platelet aggregation collagen induced in Blood --1 ug/mL|
|O_ACTH level 120min,blood|37079704|Corticotropin^1.5H post 1 ug/kg CRH IV|Moment in time|Plasma|
|O_Thyroid peroxidase Ab level, blood|3043429|Thyroperoxidase Ab [Titer] in Serum or Plasma|
|BP180 Antibodies, Blood|40791733|Basement membrane zone BP180 IgG | Bld-Ser-Plas|
|O_Vitamin B6 level, blood|21494411|Vitamin B6 intake 24 hour Measured|
|O_APTT 50:50 mix, blood|37037324|aPTT | Blood | Coagulation|
|Factor IX Post dose level|3021326|Factor IX given [Volume]|
|O_Insulin level, blood|40653190|Insulin^1.5H post 75 g glucose PO|Arbitrary Concentration|Moment in time|Blood, Serum or Plasma|
|IgM Lambda Heavy Chain Measurement, bloo|3002067|Lambda light chains [Mass/time] in 24 hour Urine|
|O_Bcr-abl gene level, blood|36031192|ABL1 gene c.944C>T [Presence] in Blood or Marrow by Molecular genetics method|
|Dihydrotestosterone, blood|40793927|Dehydrochlormethyltestosterone | Urine|
|Jak-2 Exon 12 by HRM, blood|37040275|JAK2 gene exon 12 mutations tested for | Blood or Tissue | Mutations|
|Factor IX Timed level|40796340|Factor IX | patient|
|Factor IX prenatal diagnosis, blood|40796340|Factor IX | patient|
|Grass mix GX1 IgE level, blood|3032672|Canary grass IgE Ab/IgE total in Serum|
|O_Factor XIII screen, blood|36210082|Coagulation factor XIII | Tissue and Smears|
|CD19 B cells percentage|3010503|CD19 cells [#/volume] in Blood|
|Heparin Assay|3024856|Heparin unfractionated [Units/volume] in Platelet poor plasma by Coagulation assay|
|O_Brain natriuretic peptide level, blood|3031569|Natriuretic peptide B [Mass/volume] in Blood|
|O_Coriander IgE level, blood|37077005|Cilantro (Coriandrum sativum) IgE | Serum | Allergy|
|O_Free T4 level, blood|3008598|Thyroxine (T4) free [Mass/volume] in Serum or Plasma|
|Leucocyte immunophenotyping interp|40758359|Immunophenotyping study|
|O_Glucose level 60min, blood|3034530|Glucose [Mass/volume] in Blood --2 hours post meal|
|O_Complement function, blood|37022053|Complement functional activity | Serum or Plasma | Hematology and Cell counts|
|Recoverin Abs, blood|36208146|Recoverin | Bld-Ser-Plas|
|CD4 T cell percentage|37044455|CD4 cells | Blood | Cell markers|
|Potassium level 0min, blood|40794207|Potassium | Blood mixed venous|
|O_Ferret IgE level, blood|40764104|Ferret epithelium IgE Ab/IgE total in Serum|
|Factor VIII binding level, blood|40779886|Factor VIII | patient|
|Unswitched memory (IgD+ CD27+), blood|21493675|CD27+IgD- cells/Cells.CD19+CD20+ in Blood|
|O_Hen (serum) antibodies, blood|3036472|Blood group antibodies identified in Serum or Plasma|
|Mitotane Comments|40783376|Mitotane | Bld-Ser-Plas|
|O_Porphyrin screen, blood|37026009|Protoporphyrin | Blood | Chemistry - non-challenge|
|POC - CALC Haemoglobin|3027484|Hemoglobin [Mass/volume] in Blood by calculation|
|AMA-M2 antibody by Immunoblot|40759839|Ma+Ta Ab [Presence] in Serum by Immunoblot|
|Cardiac muscle Ab level, blood|3021241|Myocardium Ab [Presence] in Serum|
|O_Cholesterol level, blood|3009160|Cholesterol [Percentile]|
|O_Growth hormone level 150min, blood|40760003|Somatotropin [Mass/volume] in Serum or Plasma --160 minutes post exercise|
|O_Aminophylline level, blood|3009072|Theophylline [Mass/volume] in Blood|
|O_Linseed IgE level, blood|1617718|Flaxseed IgE Ab [Units/volume] in Serum|
|Iron panel|37040141|Iron panel | Serum or Plasma | Chemistry Panels|
|Heparin Induced Thrombocytopenia, Blood|43534586|Heparin induced platelet Ab | Bld-Ser-Plas|
|Parathyroid Ab level, blood|3028451|Parathyrin Ab [Units/volume] in Serum|
|Yo Ab level, blood|3023661|A Ab [Titer] in Serum or Plasma|
|Factor VII level, blood|37050480|Coagulation factor VII Ag actual/Normal | Platelet poor plasma | Coagulation|
|O_Vitamin A level, blood|3006352|Retinol [Mass/volume] in Blood|
|Free light chain (blood) comment|40759246|Immunoglobulin light chains.free [Presence] in Serum|
|Cytochemistry, specimen|3049361|Cytology report of Specimen Cyto stain|
|Homocysteine comment|40654925|Homocysteine|Moment in time|Urine|
|Cryocrit, blood|3037070|Cryocrit of Serum by Spun Westergren|
|CD4 Term. Diff. T Cells, blood|3014037|CD3+CD4+ (T4 helper) cells/cells in Blood|
|Transcript / ABL ratio, blood|40771901|t(9;22)(q34.1;q11)(ABL1,BCR) b2a2+b3a2 fusion transcript/control transcript (International Scale) [# Ratio] in Blood or Tissue by Molecular genetics method|
|O_Factor XI level, blood|37059036|Coagulation factor XI Ag actual/Normal | Platelet poor plasma | Coagulation|
|Emicizumab level, blood|1989376|Emicizumab [Mass/volume] in Platelet poor plasma by Coagulation assay|
|O_Vitamin E level, blood|21494526|Vitamin E intake 24 hour Measured|
|Growth hormone level 180min, serum|40760003|Somatotropin [Mass/volume] in Serum or Plasma --160 minutes post exercise|
|Mean cell volume - POC|40788209|Mean sphered cell volume | Red Blood Cells|
|Factor IX Inhibitor screen|36031637|Coagulation factor IX activity and inhibitor panel - Platelet poor plasma by Coagulation assay|
|O_vWF activity level, blood|40792298|von Willebrand factor (vWf).activity | Platelet poor plasma|
|Factor VIII full sequencing|21493137|IVD gene full mutation analysis in Blood or Tissue by Sequencing|
|Absolute Basophils - POC|3006315|Basophils [#/volume] in Blood|
|Fibrinogen gamma gene, blood|1618662|Fibrinogen | Blood | Coagulation|
|Ristocetin 1.2 mg/ml, blood|40759148|Platelet aggregation ristocetin induced in Blood --1.0 mg/mL|
|O_Growth hormone level 60min, blood|3048799|Somatotropin [Units/volume] in Serum or Plasma --30 minutes post dose glucose PO|
|O_Total cholesterol level, blood|40780291|Cholesterol.total | Bld-Ser-Plas|
|O_Testosterone level, blood|3031464|Testosterone [Mass or Moles/volume] in Serum or Plasma|
|O_Adrenocorticotrophic hormone, blood|3035637|Corticotropin [Mass/volume] in Plasma|
|Specific IgE referred A|40774428|IgE | XXX|
|Blood gases comment|44786790|Volatiles and gases [Presence] in Blood|
|Animal mix EX1 IgE level, blood|3011777|Horse meat IgE Ab [Units/volume] in Serum|
|O_Vitamin D level, blood|36031776|25-hydroxyvitamin D2 [Mass/volume] in Capillary blood|
|O_Sweat screen, sweat|1092143|Chloride [Presence] in Sweat by Screen method|
|Animal (rodent) mix EX70 IgE level|3020228|Rat muliialgro IgE Ab [Units/volume] in Serum|
|CEA level, blood|21494701|Cerium [Mass/volume] in Blood|
|O_Iron level, blood|3046728|Iron [Presence] in Serum or Plasma|
|Fibrinogen beta gene, blood|1618662|Fibrinogen | Blood | Coagulation|
|POC - Alkaline phosphatase|40795505|Alkaline phosphatase | Tissue and Smears|
|1 Lab Order Aliases|45876015|Laboratory order codes|
|POC - CALC LDL|3038988|Cholesterol in LDL [Moles/volume] in Serum or Plasma by calculation|
|O_Glucose level 120min, blood|3021525|Glucose [Moles/volume] in Capillary blood --2 hours post meal|
|Ristocetin 0.6 mg/ml, blood|40759131|Platelet aggregation ristocetin induced in Blood --250 ug/mL|
|% PT normal plasma correction, blood|21495301|dRVVT percent correction | Platelet poor plasma|
|O_Cortisol level 0min, blood|37079807|Cortisol^24H post 500 ug dexamethasone PO 2.5 day low dose q6h|Moment in time|Serum or Plasma|
|O_Dihydrotestosterone, blood|40793927|Dehydrochlormethyltestosterone | Urine|
|O_CA-15-3 level, blood|3006742|Cancer Ag 15-3 [Presence] in Serum or Plasma|
|O_Pneumococcal IgG level, blood|3045274|Streptococcus pneumoniae IgG Ab [Mass/volume] in Serum|
|Na+ (BG)|40774001|Sodium | Bld-Ser-Plas|
|CEA level, fluid|3966438|CE Ab [Presence] in Serum or Plasma|
|Transitional B cells %, blood|3000060|B lymphocytes [#/volume] in Blood|
|Estimated GFR, blood|37027780|Predicted Glomerular filtration rate | Blood | Chemistry - non-challenge|
|Temperature POCT|40781471|Temperature | Semen|
|Adrenaline 2 umol level, blood|40655195|Norepinephrine|24 hours|Urine|169.18 g/mole|
|Inversion 16 copy number, blood|37038959|inv(16)(p13.1;q22.1)(MYH11,CBFB) fusion transcript | Blood or Tissue | Inversions|
|O_Growth hormone level 120min, blood|40771483|Somatotropin [Mass/volume] in Serum or Plasma --130 minutes post exercise|
|O_Sickle cell screen, blood|1091979|Sickle cells [Presence] in Blood|
|Factor V sequencing, blood|21493137|IVD gene full mutation analysis in Blood or Tissue by Sequencing|
|Caeruloplasmin level, blood|3040880|Ceruloplasmin actual/normal in Serum or Plasma|
|O_Anti-factor Xa, blood|44787397|Factor Xa Inhibitors|
|O_Paracetamol level, blood|40763107|Acetaminophen [Mass/volume] in Blood|
|Ma2 Abs, blood|3036703|Ma+Ta Ab [Presence] in Serum|
|Factor X level, blood|1618677|Coagulation factor X activated actual/Normal | Platelet poor plasma | Coagulation|
|Mean cell haemoglobin conc, blood|3011550|Carboxyhemoglobin [Mass/volume] in Blood|
|Total white cell count, blood|3002317|Cells Counted Total [#] in Blood|
|Haemoglobin A1c DCCT aligned, blood|36304734|Hemoglobin A1c/Hemoglobin.total goal Blood|
|Ro52 Ab level, blood|1092250|Jo sup(a) Ab [Titer] in Serum or Plasma|
|Factor X sequencing, blood|36660693|F12 gene full mutation analysis in Blood or Tissue by Sequencing|
|Specific IgE referred D|40789994|IgE | Bld-Ser-Plas|
|Gastric hormones lab comment|40796117|Gastrointestinal Hormones-|
|O_Cytochemistry, specimen|3030078|Cell type in Specimen|
|Conductivity level, sweat|3008848|Chloride [Moles/volume] in Sweat|
|Factor IX MLPA, blood|40796340|Factor IX | patient|
|O_Factor VII level, blood|37050480|Coagulation factor VII Ag actual/Normal | Platelet poor plasma | Coagulation|
|Haematocrit - POC|40781063|Hematocrit | Blood mixed venous|
|Prekallikrein assay, blood|37029733|Prekallikrein activity actual/Normal | Platelet poor plasma | Coagulation|
|Tr, CSF|36205888|PCA-Tr | Cerebral spinal fluid|
|pO2(T)c|1617274|Carbon dioxide, total [Moles/volume] in Central venous blood|
|ANA Titre, Blood|3023661|A Ab [Titer] in Serum or Plasma|
|Ganglionic AChR antibody, blood|1617214|Acetylcholine receptor ganglionic neuronal IgG+IgM Ab [Moles/volume] in Serum by Immunoassay|
|O_Cortisol level, blood|3031802|Cortisol [Mass or Moles/volume] in Serum or Plasma|
|O_Other Immunology test|3967262|Immunologist review | XXX | Miscellaneous tests|
|Blood film microscopy|3041179|Nucleated erythrocytes [Presence] in Blood by Light microscopy|
|LKM-1 antibody by Immunoblot|42870557|Ma1 Ab [Presence] in Serum by Immunoblot|
|Growth hormone level 210min, serum|40760101|Somatotropin [Mass/volume] in Serum or Plasma --90 minutes post resting|
|INR Therapeutic range|40784503|INR | Platelet poor plasma|
|Galactosaemia comments|36209695|Galactosemias | DBS|
|O_Blood film microscopy|3040146|Normoblasts Orthochromic/cells in Blood by Microscopy|
|Comment - NGS Iron panel|37040141|Iron panel | Serum or Plasma | Chemistry Panels|
|O_Pituitary Ab level, blood|40788874|Pituitary Ab | Bld-Ser-Plas|
|O_C-peptide level, blood|3027923|C peptide [Moles/volume] in Serum or Plasma|
|Thyroglobulin antibodies comment|40776802|Thyroglobulin | Bld-Ser-Plas|
|O_Fat globules detection, faeces|3043695|Oval fat bodies (globules) [#/area] in Urine sediment by Automated count|
|Low Affinity Acetylcholine Receptor Anti|40793053|Acetylcholine Receptor Binding Ab | Bld-Ser-Plas|
|DRVVT ratio, blood|3032493|dRVVT/dRVVT W excess phospholipid (screen to confirm ratio)|
|Immunoglobulin M level, blood|3040240|Hemoglobin M/Hemoglobin.total in Blood|
|O_Erythropoetin level, blood|3011899|Erythropoietin (EPO) [Moles/volume] in Serum or Plasma|
|CA-125 level, blood|3027495|Calcium [Presence] in Blood|
|FLT3-ITD, blood|37071797|FLT3 gene internal tandem duplication | Blood or Tissue | Mutations|
|POC - Triglyceride|40796466|Triglyceride | Bld-Ser-Plas|
|POC - PO2|40774072|Oxygen | Gas|
|White blood cell count, blood|3010813|Leukocytes [#/volume] in Blood|


* `EVENT` Lab test event []()

```sql
select
	NHS_NUMBER,
	EVENT,
	EVENT_START_DT_TM,
	RESULT_VALUE,
	RESULT_UNITS,
	NORMAL_LOW,
	NORMAL_HIGH
from ##duckdb_source##
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20Oxford%20Lab%20Measurement%20mapping){: .btn }
### COSD V9 Measurement TNM Category Integrated Stage
* Constant value set to `2000500013`. TNMCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20TNM%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V9 Measurement TNM Category Final Pre Treatment Stage
* Constant value set to `2000500017`. TNMCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20TNM%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V9 Measurement T Category Integrated Stage
* Constant value set to `2000500012`. TCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20T%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V9 Measurement T Category Final Pre Treatment Stage
* Constant value set to `2000500016`. TCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20T%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V9 Measurement Primary Pathway Metastasis
* Constant value set to `2000500007`. PrimaryPathwayMetastasis

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20Primary%20Pathway%20Metastasis%20mapping){: .btn }
### COSD V9 Measurement Non Primary Pathway Recurrence Metastasis
* Constant value set to `2000500008`. NonPrimaryPathwayRecurrenceMetastasis

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20Non%20Primary%20Pathway%20Recurrence%20Metastasis%20mapping){: .btn }
### COSD V9 Measurement Non Primary Pathway Progression Metastasis
* Constant value set to `2000500009`. NonPrimaryPathwayProgressionMetastasis

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20Non%20Primary%20Pathway%20Progression%20Metastasis%20mapping){: .btn }
### COSD V9 Measurement N Category Integrated Stage
* Constant value set to `2000500011`. NCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20N%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V9 Measurement N Category Final Pre Treatment Stage
* Constant value set to `2000500015`. NCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20N%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V9 Measurement M Category Integrated Stage
* Constant value set to `2000500010`. MCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20M%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V9 Measurement M Category Final Pre Treatment Stage
* Constant value set to `2000500014`. MCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20M%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V8 Measurement TNM Category Integrated Stage
* Constant value set to `2000500013`. TNMCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20TNM%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V8 Measurement TNM Category Final Pre Treatment Stage
* Constant value set to `2000500017`. TNMCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20TNM%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V8 Measurement T Category Integrated Stage
* Constant value set to `2000500012`. TCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20T%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V8 Measurement T Category Final Pre Treatment Stage
* Constant value set to `2000500016`. TCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20T%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V8 Measurement N Category Integrated Stage
* Constant value set to `2000500011`. NCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20N%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V8 Measurement N Category Final Pre Treatment Stage
* Constant value set to `2000500015`. NCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20N%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V8 Measurement M Category Integrated Stage
* Constant value set to `2000500010`. MCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20M%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V8 Measurement M Category Final Pre Treatment Stage
* Constant value set to `2000500014`. MCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20M%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
