/*********************************************************************************
# Copyright 2014 Observational Health Data Sciences and Informatics
#
# 
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# 
#     http://www.apache.org/licenses/LICENSE-2.0
# 
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
********************************************************************************/

/************************

 ####### #     # ####### ######      #####  ######  #     #           ####### 
 #     # ##   ## #     # #     #    #     # #     # ##   ##    #    # #       
 #     # # # # # #     # #     #    #       #     # # # # #    #    # #       
 #     # #  #  # #     # ######     #       #     # #  #  #    #    # ######  
 #     # #     # #     # #          #       #     # #     #    #    #       # 
 #     # #     # #     # #          #     # #     # #     #     #  #  #     # 
 ####### #     # ####### #           #####  ######  #     #      ##    #####  
                                                                              

Script to load the common data model, version 5.0 vocabulary tables for SQL Server database

Notes

1) There is no data file load for the SOURCE_TO_CONCEPT_MAP TABLE CDM.because that TABLE CDM.is deprecated in CDM version 5.0
2) This script assumes the CDM version 5 vocabulary zip file has been unzipped into the "C:\Code\vocabularyulary" directory. 
3) If you unzipped your CDM version 5 vocabulary files into a different directory then replace all file paths below, with your directory path.
4) Run this SQL query script in the database where you created your CDM Version 5 tables

last revised: 26 Nov 2014

author:  Lee Evans


*************************/

BULK INSERT CDM.DRUG_STRENGTH 
FROM 'C:\Code\vocabulary\DRUG_STRENGTH.csv' 
WITH (
FIRSTROW = 2,
FIELDTERMINATOR = '\t',
ROWTERMINATOR = '0x0a',
ERRORFILE = 'C:\Code\vocabulary\DRUG_STRENGTH.bad',
TABLOCK
);


BULK INSERT CDM.CONCEPT 
FROM 'C:\Code\vocabulary\CONCEPT.csv' 
WITH (
FIRSTROW = 2,
FIELDTERMINATOR = '\t',
ROWTERMINATOR = '0x0a',
ERRORFILE = 'C:\Code\vocabulary\CONCEPT.bad',
CODEPAGE = '65001',
TABLOCK
);

BULK INSERT CDM.CONCEPT_RELATIONSHIP 
FROM 'C:\Code\vocabulary\CONCEPT_RELATIONSHIP.csv' 
WITH (
FIRSTROW = 2,
FIELDTERMINATOR = '\t',
ROWTERMINATOR = '0x0a',
ERRORFILE = 'C:\Code\vocabulary\CONCEPT_RELATIONSHIP.bad',
TABLOCK
);

BULK INSERT CDM.CONCEPT_ANCESTOR 
FROM 'C:\Code\vocabulary\CONCEPT_ANCESTOR.csv' 
WITH (
FIRSTROW = 2,
FIELDTERMINATOR = '\t',
ROWTERMINATOR = '0x0a',
ERRORFILE = 'C:\Code\vocabulary\CONCEPT_ANCESTOR.bad',
TABLOCK
);

BULK INSERT CDM.CONCEPT_SYNONYM 
FROM 'C:\Code\vocabulary\CONCEPT_SYNONYM.csv' 
WITH (
FIRSTROW = 2,
FIELDTERMINATOR = '\t',
ROWTERMINATOR = '0x0a',
ERRORFILE = 'C:\Code\vocabulary\CONCEPT_SYNONYM.bad',
CODEPAGE = '65001',
TABLOCK
);

BULK INSERT CDM.VOCABULARY 
FROM 'C:\Code\vocabulary\VOCABULARY.csv' 
WITH (
FIRSTROW = 2,
FIELDTERMINATOR = '\t',
ROWTERMINATOR = '0x0a',
ERRORFILE = 'C:\Code\vocabulary\VOCABULARY.bad',
TABLOCK
);

BULK INSERT CDM.RELATIONSHIP 
FROM 'C:\Code\vocabulary\RELATIONSHIP.csv' 
WITH (
FIRSTROW = 2,
FIELDTERMINATOR = '\t',
ROWTERMINATOR = '0x0a',
ERRORFILE = 'C:\Code\vocabulary\RELATIONSHIP.bad',
TABLOCK
);

BULK INSERT CDM.CONCEPT_CLASS 
FROM 'C:\Code\vocabulary\CONCEPT_CLASS.csv' 
WITH (
FIRSTROW = 2,
FIELDTERMINATOR = '\t',
ROWTERMINATOR = '0x0a',
ERRORFILE = 'C:\Code\vocabulary\CONCEPT_CLASS.bad',
TABLOCK
);

BULK INSERT CDM.DOMAIN 
FROM 'C:\Code\vocabulary\DOMAIN.csv' 
WITH (
FIRSTROW = 2,
FIELDTERMINATOR = '\t',
ROWTERMINATOR = '0x0a',
ERRORFILE = 'C:\Code\vocabulary\DOMAIN.bad',
TABLOCK
);