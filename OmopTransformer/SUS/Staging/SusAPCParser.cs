using System.Globalization;
using CsvHelper;

namespace OmopTransformer.SUS.Staging;

internal class SusAPCParser : ISusAPCParser
{
    public IEnumerable<APCRecord> ReadFile(string path, CancellationToken cancellationToken)
    {
        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Read();
        csv.ReadHeader();
                
        while (csv.Read())
        {
            cancellationToken.ThrowIfCancellationRequested();
                    
            var visitors = new List<OverseasVisitor>();
            var icdDiagnoses = new List<IcdDiagnosis>();
            var readDiagnoses = new List<ReadDiagnosis>();
            var opcdProcedure = new List<OpcsProcedure>();
            var readProcedure = new List<ReadProcedure>();
            var careLocations = new List<CareLocation>();
            var births = new List<Birth>();
            var criticalCareItems = new List<CriticalCare>();

            Guid messageId = Guid.NewGuid();

            var record = new APC
            {
                MessageId = messageId,
                GeneratedRecordIdentifier = csv.GetField<string>("Generated Record Identifier"),
                PBRSpellID = csv.GetField<string>("PBR Spell ID"),
                ReasonForAccess = csv.GetField<string>("Reason for Access"),
                CDSType = csv.GetField<string>("CDS type"),
                ProtocolIdentifier = csv.GetField<string>("Protocol identifier"),
                UniqueCDSIdentifier = csv.GetField<string>("Unique CDS identifier"),
                UpdateType = csv.GetField<string>("Update type"),
                BulkReplacementCDSGroup = csv.GetField<string>("Bulk replacement CDS group"),
                TestIndicator = csv.GetField<string>("Test indicator"),
                ApplicableDatetime = csv.GetField<string>("Applicable date/time"),
                CensusDate = csv.GetField<string>("Census date"),
                ExtractDatetime = csv.GetField<string>("Extract date/time"),
                ReportPeriodStartDate = csv.GetField<string>("Report period Start Date"),
                ReportPeriodEndDate = csv.GetField<string>("Report period End Date"),
                OrganisationCodeSenderOfTransaction = csv.GetField<string>("Organisation code: Sender of transaction"),
                OrganisationCodeTypeofSender = csv.GetField<string>("Organisation Code Type of Sender"),
                SubmissionDate = csv.GetField<string>("Submission Date"),
                CDSInterchangeID = csv.GetField<string>("CDS Interchange ID"),
                LocalPatientIdentifier = csv.GetField<string>("Local Patient Identifier"),
                OrganisationCodeLocalPatientIdentifier = csv.GetField<string>("Organisation Code (Local Patient Identifier)"),
                OrganisationCodeTypeLocalPatientIdentifier = csv.GetField<string>("Organisation Code Type (Local Patient Identifier)"),
                NHSNumber = csv.GetField<string>("NHS Number"),
                DateofBirth = csv.GetField<string>("Date of Birth"),
                BirthWeight = csv.GetField<string>("Birth Weight"),
                LiveOrStillBirth = csv.GetField<string>("Live or Still Birth"),
                CarerSupportIndicator = csv.GetField<string>("Carer Support Indicator"),
                LegalStatusClassificationOnAdmissionPsychiatricCensusOnly = csv.GetField<string>("Legal Status Classification on Admission (Psychiatric Census Only)"),
                EthnicGroup = csv.GetField<string>("Ethnic Group"),
                MaritalStatusPsychiatricCensusOnly = csv.GetField<string>("Marital Status (Psychiatric Census Only)"),
                NHSNumberTraceStatus = csv.GetField<string>("NHS Number Trace Status"),
                WithheldIdentityReason = csv.GetField<string>("Withheld Identity Reason"),
                Sex = csv.GetField<string>("Sex"),
                PregnancyTotalPreviousPregnancies = csv.GetField<string>("Pregnancy Total Previous Pregnancies"),
                NameFormatCode = csv.GetField<string>("Name Format Code"),
                PatientName = csv.GetField<string>("Patient Name"),
                PersonTitle = csv.GetField<string>("Person Title"),
                PersonGivenName = csv.GetField<string>("Person Given Name"),
                PersonFamilyName = csv.GetField<string>("Person Family Name"),
                PersonNameSuffix = csv.GetField<string>("Person Name Suffix"),
                PersonInitials = csv.GetField<string>("Person Initials"),
                AddressFormatCode = csv.GetField<string>("Address Format Code"),
                PatientUsualAddress = csv.GetField<string>("Patient Usual Address"),
                Postcode = csv.GetField<string>("Postcode"),
                OrganisationCodeResidenceResponsibility = csv.GetField<string>("Organisation Code (Residence Responsibility)"),
                PCTofResidence = csv.GetField<string>("PCT of Residence"),
                OrganisationCodeTypePCTofResidence = csv.GetField<string>("Organisation Code Type (PCT of Residence)"),
                OSVClassificationatCDSActivityDate = csv.GetField<string>("OSV Classification at CDS Activity Date"),
                HospitalProviderSpellNumber = csv.GetField<string>("Hospital Provider Spell Number"),
                AdministrativeCategory = csv.GetField<string>("Administrative Category"),
                PatientClassification = csv.GetField<string>("Patient Classification"),
                AdmissionMethodHospitalProviderSpell = csv.GetField<string>("Admission Method (Hospital Provider Spell)"),
                DischargeDestinationHospitalProviderSpell = csv.GetField<string>("Discharge Destination (Hospital Provider Spell)"),
                DischargeMethodHospitalProviderSpell = csv.GetField<string>("Discharge Method (Hospital Provider Spell)"),
                SourceOfAdmissionHospitalProviderSpell = csv.GetField<string>("Source of Admission (Hospital Provider Spell)"),
                StartDateHospitalProviderSpell = csv.GetField<string>("Start Date (Hospital Provider Spell)"),
                StartTimeHospitalProviderSpell = csv.GetField<string>("Start Time (Hospital Provider Spell)"),
                DischargeDateFromHospitalProviderSpell = csv.GetField<string>("Discharge Date (From Hospital Provider Spell)"),
                DischargeTimeHospitalProviderSpell = csv.GetField<string>("Discharge Time (Hospital Provider Spell)"),
                DischargeToHospitalAtHomeServiceIndicator = csv.GetField<string>("Discharge To Hospital At Home Service Indicator"),
                EpisodeNumber = csv.GetField<string>("Episode Number"),
                FirstRegularDayNightAdmission = csv.GetField<string>("First Regular Day Night Admission"),
                LastEpisodeInSpellIndicator = csv.GetField<string>("Last Episode In Spell Indicator"),
                NeonatalLevelOfCare = csv.GetField<string>("Neonatal Level of Care"),
                OperationStatus = csv.GetField<string>("Operation Status"),
                PsychiatricPatientStatus = csv.GetField<string>("Psychiatric Patient Status"),
                StartDateConsultantEpisode = csv.GetField<string>("Start Date (Consultant Episode)"),
                StartTimeEpisode = csv.GetField<string>("Start Time (Episode)"),
                EndDateConsultantEpisode = csv.GetField<string>("End Date (Consultant Episode)"),
                EndTimeEpisode = csv.GetField<string>("End Time (Episode)"),
                LengthOfStayAdjustmentRehabilitation = csv.GetField<string>("Length Of Stay Adjustment (Rehabilitation)"),
                LengthOfStayAdjustmentSpecialistPalliativeCare = csv.GetField<string>("Length Of Stay Adjustment (Specialist Palliative Care)"),
                CommissioningSerialNumber = csv.GetField<string>("Commissioning Serial Number"),
                NHSServiceAgreementLineNumber = csv.GetField<string>("NHS Service Agreement Line Number"),
                ProviderReferenceNumber = csv.GetField<string>("Provider Reference Number"),
                CommissionerReferenceNumber = csv.GetField<string>("Commissioner Reference Number"),
                OrganisationCodeCodeOfProvider = csv.GetField<string>("Organisation Code Code of Provider"),
                OrganisationCodeTypeOfProvider = csv.GetField<string>("Organisation Code Type of Provider"),
                OrganisationCodeCodeOfCommissioner = csv.GetField<string>("Organisation Code Code of Commissioner"),
                OrganisationCodeTypeofCommissioner = csv.GetField<string>("Organisation Code Type of Commissioner"),
                ConsultantCode = csv.GetField<string>("Consultant Code"),
                MainSpecialtyCode = csv.GetField<string>("Main Specialty Code"),
                TreatmentFunctionCode = csv.GetField<string>("Treatment Function Code"),
                LocalSubSpecialtyCode = csv.GetField<string>("Local Sub Specialty Code"),
                MultiProfessionalOrMultidisciplinaryIndCode = csv.GetField<string>("Multi-Professional Or Multidisciplinary Ind Code"),
                RehabilitationAssessmentTeamType = csv.GetField<string>("Rehabilitation Assessment Team Type"),
                DiagnosisSchemeInUseICD = csv.GetField<string>("Diagnosis Scheme In Use (ICD)"),
                DiagnosisSchemeInUseRead = csv.GetField<string>("Diagnosis Scheme In Use (Read)"),
                ProcedureSchemeInUseOPCS = csv.GetField<string>("Procedure Scheme In Use (OPCS)"),
                ProcedureSchemeInUseREAD = csv.GetField<string>("Procedure Scheme In Use (READ)"),
                WardCodeAtEpisodeStartDate = csv.GetField<string>("Ward Code at Episode Start Date"),
                WardSecurityLevelAtEpisodeStartDate = csv.GetField<string>("Ward Security Level at Episode Start Date"),
                LocationClassAtEpisodeStartDate = csv.GetField<string>("Location Class at Episode Start Date"),
                SiteCodeOfTreatmentAtEpisodeStartDate = csv.GetField<string>("Site Code (of Treatment) At Episode Start Date"),
                OrganisationCodeTypeSiteCodeOfTreatmentAtStartOfEpisode = csv.GetField<string>("Organisation Code Type (Site Code of Treatment) (At Start of Episode)"),
                IntendedClinicalCareIntensityAtStartOfEpisode = csv.GetField<string>("Intended Clinical Care Intensity(At Start of Episode)"),
                AgeGroupIntendedAtStartOfEpisode = csv.GetField<string>("Age Group Intended (At Start of Episode)"),
                SexOfPatientsAtStartOfEpisode = csv.GetField<string>("Sex of Patients (At Start of Episode)"),
                WardDayPeriodAvailability = csv.GetField<string>("Ward Day Period Availability"),
                WardNightPeriodAvailability = csv.GetField<string>("Ward Night Period Availability"),
                WardCodeAtEpisodeEndDate = csv.GetField<string>("Ward Code at Episode End Date"),
                WardSecurityLevelAtEpisodeEndDate = csv.GetField<string>("Ward Security Level at Episode End Date"),
                LocationClassAtEpisodeEndDate = csv.GetField<string>("Location Class at Episode End Date"),
                SiteCodeOfTreatmentAtEpisodeEndDate = csv.GetField<string>("Site Code (of Treatment) at Episode End Date"),
                OrganisationCodeTypeSiteCodeOfTreatmentAtEpisodeEndDate = csv.GetField<string>("Organisation Code Type Site Code (of Treatment) at Episode End Date"),
                IntendedClinicalCareIntensityAtEpisodeEndDate = csv.GetField<string>("Intended Clinical Care Intensity at Episode End Date"),
                AgeGroupIntendedAtEpisodeEndDate = csv.GetField<string>("Age Group Intended at Episode End Date"),
                SexOfPatientsAtEpisodeEndDate = csv.GetField<string>("Sex of Patients at Episode End Date"),
                WardDayPeriodAvailabilityAtEpisodeEndDate = csv.GetField<string>("Ward Day Period Availability at Episode End Date"),
                WardNightPeriodAvailabilityAtEpisodeEndDate = csv.GetField<string>("Ward Night Period Availability at Episode End Date"),
                GeneralMedicalPractitionerCodeofRegisteredGMP = csv.GetField<string>("General Medical Practitioner Code of Registered GMP"),
                PracticeCodeOfRegisteredGP = csv.GetField<string>("Practice Code of Registered GP"),
                OrganisationCodeTypeofRegisteredGP = csv.GetField<string>("Organisation Code Type of Registered GP"),
                ReferrerCode = csv.GetField<string>("Referrer Code"),
                ReferringOrganisationCode = csv.GetField<string>("Referring Organisation Code"),
                OrganisationCodeTypeofReferrer = csv.GetField<string>("Organisation Code Type of Referrer"),
                DirectAccessReferralIndicator = csv.GetField<string>("Direct Access Referral Indicator"),
                AmbulanceIncidentNumber = csv.GetField<string>("Ambulance Incident Number"),
                OrganisationCodeConveyingAmbulanceTrust = csv.GetField<string>("Organisation Code (Conveying Ambulance Trust)"),
                DurationofElectiveWait = csv.GetField<string>("Duration of Elective Wait"),
                IntendedManagement = csv.GetField<string>("Intended Management"),
                DecidedToAdmitDateForThisProvider = csv.GetField<string>("Decided To Admit Date (For This Provider)"),
                WaitingTimeMeasurementType = csv.GetField<string>("Waiting Time Measurement Type"),
                LocationTypeCodeAtStartOfEpisode = csv.GetField<string>("Location Type Code at Start of Episode"),
                HRGCode = csv.GetField<string>("HRG Code"),
                HRGVersionNumber = csv.GetField<string>("HRG Version Number"),
                ProcedureSchemeInUse = csv.GetField<string>("Procedure Scheme In Use"),
                DominantGroupingVariableProcedure = csv.GetField<string>("Dominant Grouping Variable - Procedure"),
                FCEHRG = csv.GetField<string>("FCE HRG"),
                EpisodeHRGVersionNumber = csv.GetField<string>("Episode HRG Version Number"),
                SpellCoreHRG = csv.GetField<string>("Spell Core HRG"),
                SpellHRGVersionNumber = csv.GetField<string>("Spell HRG Version Number"),
                NumberOfBabies = csv.GetField<string>("Number of Babies"),
                FirstAntenatalAssessmentDate = csv.GetField<string>("First Antenatal Assessment Date"),
                GMPCodeofGMPResponsibleforAntenatalCare = csv.GetField<string>("GMP (Code of GMP Responsible for Antenatal Care)"),
                CodeofGPPracticeRegisteredGMPAntenatalCare = csv.GetField<string>("Code of GP Practice (Registered GMP- Antenatal Care)"),
                OrganisationCodeTypeGPPracticeRegisteredGMPAntenatalCare = csv.GetField<string>("Organisation Code Type GP Practice (Registered GMP- Antenatal Care)"),
                LocationClassOfDeliveryPlaceIntended = csv.GetField<string>("Location Class of Delivery Place (Intended)"),
                LocationTypeofDeliveryPlaceIntended = csv.GetField<string>("Location Type of Delivery Place (Intended)"),
                DeliveryPlaceChangeReason = csv.GetField<string>("Delivery Place Change Reason"),
                DeliveryPlaceTypeIntended = csv.GetField<string>("Delivery Place Type (Intended)"),
                AnaestheticGivenDuringLabourDelivery = csv.GetField<string>("Anaesthetic Given During Labour/Delivery"),
                AnaestheticGivenPostDelivery = csv.GetField<string>("Anaesthetic Given Post Delivery"),
                GestationLengthLabourOnset = csv.GetField<string>("Gestation Length (Labour Onset)"),
                LabourDeliveryOnsetMethod = csv.GetField<string>("Labour/Delivery Onset Method"),
                DeliveryDate = csv.GetField<string>("Delivery Date"),
                GestationLengthAssessmentBaby = csv.GetField<string>("Gestation Length (Assessment) Baby"),
                LocalPatientIdentifierMother = csv.GetField<string>("Local Patient Identifier (Mother)"),
                OrganisationCodeLocalPatientIdentifierMother = csv.GetField<string>("Organisation Code (Local Patient Identifier (Mother))"),
                OrganisationCodeTypeMother = csv.GetField<string>("Organisation Code Type (Mother)"),
                NHSNumberMother = csv.GetField<string>("NHS Number (Mother)"),
                NHSNumberStatusIndicatorMother = csv.GetField<string>("NHS Number Status Indicator (Mother)"),
                BirthDateMother = csv.GetField<string>("Birth Date (Mother)"),
                AddressFormatCodeMother = csv.GetField<string>("Address Format Code (Mother)"),
                PatientUsualAddressMother = csv.GetField<string>("Patient Usual Address (Mother)"),
                PostcodeOfUsualAddressMother = csv.GetField<string>("Postcode of Usual Address (Mother)"),
                OrganisationCodePCTofResidenceMother = csv.GetField<string>("Organisation Code (PCT of Residence) (Mother)"),
                OrganisationCodeTypePCTofResidenceMother = csv.GetField<string>("Organisation Code Type (PCT of Residence) (Mother)"),
                UniqueBookingReferenceNumberConverted = csv.GetField<string>("Unique Booking Reference Number Converted"),
                PatientPathwayIdentifier = csv.GetField<string>("Patient Pathway Identifier"),
                OrganisationCodePatientPathwayIdentifierIssuer = csv.GetField<string>("Organisation Code Patient Pathway Identifier Issuer"),
                ReferralToTreatmentPeriodStatus = csv.GetField<string>("Referral To Treatment Period Status"),
                ReferralToTreatmentPeriodStartDate = csv.GetField<string>("Referral To Treatment Period Start Date"),
                ReferralToTreatmentPeriodEndDate = csv.GetField<string>("Referral To Treatment Period End Date"),
                LeadCareActivityIndicator = csv.GetField<string>("Lead Care Activity Indicator"),
                AgeatCDSActivityDate = csv.GetField<string>("Age at CDS Activity Date"),
                NHSServiceAgreementChangeDate = csv.GetField<string>("NHS Service Agreement Change Date"),
                CDSActivityDate = csv.GetField<string>("CDS Activity Date"),
                AgeAsOnAdmission = csv.GetField<string>("Age as on Admission"),
                AdminCategoryAtStart = csv.GetField<string>("Admin Category at Start"),
                HospitalProviderSpellDischargeReadyDate = csv.GetField<string>("Hospital Provider Spell Discharge Ready Date"),
                LocationType = csv.GetField<string>("Location Type"),
                XMLVersion = csv.GetField<string>("XML Version"),
                ConfidentialityCategoryDerived = csv.GetField<string>("Confidentiality Category (Derived)"),
                ReferralToTreatmentLengthDerived = csv.GetField<string>("Referral To Treatment Length (Derived)"),
                AgeRangePatientdDerivedFromDOB = csv.GetField<string>("Age range patient derived from DOB"),
                AgeRangeMotherDerivedFromDOB = csv.GetField<string>("Age range mother derived from DOB"),
                AreaCodeDerivedFromPostcode = csv.GetField<string>("Area code derived from postcode."),
                CDSGroup = csv.GetField<string>("CDS Group"),
                FinishedIndicator = csv.GetField<string>("Finished Indicator"),
                PCTDerivedfromGP = csv.GetField<string>("PCT (Derived from GP)"),
                PCTTypeDerivedfromGP = csv.GetField<string>("PCT Type (Derived from GP)"),
                GPPracticeDerived = csv.GetField<string>("GP Practice (Derived)"),
                GPPracticeMotherDerived = csv.GetField<string>("GP Practice Mother (Derived)"),
                PCTDerivedfromderivedGPPractice = csv.GetField<string>("PCT (Derived from derived GP Practice)"),
                PCTMotherDerivedfromderivedGPPractice = csv.GetField<string>("PCT Mother (Derived from derived GP Practice)"),
                SHAfromGPPractice = csv.GetField<string>("SHA from GP Practice"),
                SHATypefromGPPractice = csv.GetField<string>("SHA Type from GP Practice"),
                HospitalSpellDuration = csv.GetField<string>("Hospital Spell Duration"),
                MonthOfBirth = csv.GetField<string>("Month of Birth"),
                HomeBirthOrDelivery = csv.GetField<string>("Home Birth or Delivery"),
                ElectoralWardFromPostcode = csv.GetField<string>("Electoral Ward from postcode"),
                PCTFromPostcode = csv.GetField<string>("PCT from postcode"),
                PCTTypefromPostcode = csv.GetField<string>("PCT Type from Postcode"),
                SHAfromPostcode = csv.GetField<string>("SHA from Postcode"),
                SHATypefromPostcode = csv.GetField<string>("SHA Type from Postcode"),
                AreacodeFromProviderPostcode = csv.GetField<string>("Area code from Provider Postcode"),
                AgeAtEndOfEpisode = csv.GetField<string>("Age at End of Episode"),
                AgeAtStartOfEpisode = csv.GetField<string>("Age at Start of Episode"),
                YearOfBirth = csv.GetField<string>("Year of Birth"),
                YearOfBirthMother = csv.GetField<string>("Year of Birth Mother"),
                MonthOfBirthMother = csv.GetField<string>("Month of Birth Mother"),
                CensusArea = csv.GetField<string>("2001 Census Area"),
                Country = csv.GetField<string>("Country"),
                CountyCode = csv.GetField<string>("County Code"),
                CensusED = csv.GetField<string>("1991 Census ED"),
                EDDistrictCode = csv.GetField<string>("ED District Code"),
                ElectoralWardCode = csv.GetField<string>("Electoral Ward Code"),
                GORCode = csv.GetField<string>("GOR Code"),
                LocalUnitaryAuthority = csv.GetField<string>("Local Unitary Authority"),
                OldSHACode = csv.GetField<string>("Old SHA Code"),
                ElectoralArea = csv.GetField<string>("1998 Electoral Area"),
                PrimeRecipient = csv.GetField<string>("Prime Recipient"),
                CopyRecipients = csv.GetField<string>("Copy Recipients"),
            };

            int index = 46;

            for (int i = 0; i < 5; i++)
            {
                var visitor = new OverseasVisitor
                {
                    MessageId = messageId,
                    OverseasVisitorStatusClassification = csv[++index].GetTrimmedValueOrNull(),
                    OverseasVisitorStatusStartDate = csv[++index].GetTrimmedValueOrNull()
                };

                if (visitor.IsEmpty)
                    break;

                visitors.Add(visitor);
            }

            index = 100;

            bool isPrimaryDiagnosis = true;

            for (int i = 0; i < 24; i++)
            {
                var icdDiagnosis = new IcdDiagnosis
                {
                    MessageId = messageId,
                    DiagnosisICD = csv[++index].GetTrimmedValueOrNull(),
                    PresentOnAdmissionIndicatorDiagnosis = csv[++index].GetTrimmedValueOrNull(),
                    IsPrimaryDiagnosis = isPrimaryDiagnosis
                };

                isPrimaryDiagnosis = false;

                if (icdDiagnosis.IsEmpty)
                    break;

                icdDiagnoses.Add(icdDiagnosis);
            }

            index = 149;

            isPrimaryDiagnosis = true;

            for (int i = 0; i < 24; i++)
            {
                var readDiagnosis = new ReadDiagnosis
                {
                    MessageId = messageId,
                    DiagnosisRead = csv[++index].GetTrimmedValueOrNull(),
                    IsPrimaryDiagnosis = isPrimaryDiagnosis
                };

                isPrimaryDiagnosis = false;

                if (readDiagnosis.IsEmpty)
                    break;

                readDiagnoses.Add(readDiagnosis);
            }

            index = 174;

            bool isPrimaryProcedure = true;

            for (int i = 0; i < 24; i++)
            {
                var procedure = new OpcsProcedure
                {
                    MessageId = messageId,
                    ProcedureOPCS = csv[++index].GetTrimmedValueOrNull(),
                    ProcedureDateOPCS = csv[++index].GetTrimmedValueOrNull(),
                    MainOperatingHealthcareProfessionalCodeOpcs = csv[++index].GetTrimmedValueOrNull(),
                    ProfessionalRegistrationIssuerCodeOpcs = csv[++index].GetTrimmedValueOrNull(),
                    ResponsibleAnaesthetistCodeOpcs = csv[++index].GetTrimmedValueOrNull(),
                    ResponsibleAnaesthetistRegBodyOpcs = csv[++index].GetTrimmedValueOrNull(),
                    IsPrimaryProcedure = isPrimaryProcedure
                };

                isPrimaryProcedure = false;

                if (procedure.IsEmpty)
                    break;

                opcdProcedure.Add(procedure);
            }

            index = 319;
            isPrimaryProcedure = true;

            for (int i = 0; i < 24; i++)
            {
                var procedure = new ReadProcedure
                {
                    MessageId = messageId,
                    ProcedureRead = csv[++index].GetTrimmedValueOrNull(),
                    ProcedureDateRead = csv[++index].GetTrimmedValueOrNull(),
                    IsPrimaryProcedure = isPrimaryProcedure
                };

                isPrimaryProcedure = false;

                if (procedure.IsEmpty)
                    break;

                readProcedure.Add(procedure);
            }

            index = 377;

            for (int i = 0; i < 24; i++)
            {
                var careLocation = new CareLocation
                {
                    MessageId = messageId,
                    WardCode = csv[++index].GetTrimmedValueOrNull(),
                    WardSecurityLevel = csv[++index].GetTrimmedValueOrNull(),
                    LocationClass = csv[++index].GetTrimmedValueOrNull(),
                    SiteCodeOfTreatment = csv[++index].GetTrimmedValueOrNull(),
                    OrganisationCodeTypeSiteCodeOfTreatment = csv[++index].GetTrimmedValueOrNull(),
                    IntendedClinicalCareIntensity = csv[++index].GetTrimmedValueOrNull(),
                    AgeGroupIntended = csv[++index].GetTrimmedValueOrNull(),
                    SexOfPatients = csv[++index].GetTrimmedValueOrNull(),
                    WardDayPeriodAvailability = csv[++index].GetTrimmedValueOrNull(),
                    WardNightPeriodAvailability = csv[++index].GetTrimmedValueOrNull(),
                    StartDate = csv[++index].GetTrimmedValueOrNull(),
                    StartTimeWardStay = csv[++index].GetTrimmedValueOrNull(),
                    EndDate = csv[++index].GetTrimmedValueOrNull(),
                    EndTimeWardStay = csv[++index].GetTrimmedValueOrNull()
                };

                if (careLocation.IsEmpty)
                    break;

                careLocations.Add(careLocation);
            }


            index = 759;

            for (int i = 0; i < 9; i++)
            {
                var birth = new Birth
                {
                    MessageId = messageId,
                    BirthOrderBaby = csv[++index].GetTrimmedValueOrNull(),
                    DeliveryMethodBaby = csv[++index].GetTrimmedValueOrNull(),
                    GestationLengthAssessmentBaby = csv[++index].GetTrimmedValueOrNull(),
                    ResuscitationMethodBaby = csv[++index].GetTrimmedValueOrNull(),
                    StatusOfPersonConductingDeliveryBaby = csv[++index].GetTrimmedValueOrNull(),
                    LocalPatientIdentifierBaby = csv[++index].GetTrimmedValueOrNull(),
                    OrganisationCodeLocalPatientIDBaby = csv[++index].GetTrimmedValueOrNull(),
                    OrganisationCodeTypeLocalPatientIDBaby = csv[++index].GetTrimmedValueOrNull(),
                    NHSNumberBaby = csv[++index].GetTrimmedValueOrNull(),
                    NHSNumberStatusIndicatorBaby = csv[++index].GetTrimmedValueOrNull(),
                    BirthDateBabyBaby = csv[++index].GetTrimmedValueOrNull(),
                    BirthWeightBaby = csv[++index].GetTrimmedValueOrNull(),
                    LiveOrStillBirthBaby = csv[++index].GetTrimmedValueOrNull(),
                    SexBaby = csv[++index].GetTrimmedValueOrNull(),
                    BirthLocationType = csv[++index].GetTrimmedValueOrNull(),
                    LocationClassDeliveryPlaceActual = csv[++index].GetTrimmedValueOrNull(),
                    DeliveryPlaceTypeActual = csv[++index].GetTrimmedValueOrNull(),
                };

                if (birth.IsEmpty)
                    break;

                births.Add(birth);
            }


            index = 978;

            for (int i = 0; i < 9; i++)
            {
                var criticalCare = new CriticalCare
                {
                    MessageId = messageId,
                    CriticalCareLocalIdentifier = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareStartDate = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareUnitFunction = csv[++index].GetTrimmedValueOrNull(),
                    AdvancedRespiratorySupportDays = csv[++index].GetTrimmedValueOrNull(),
                    BasicRespiratorySupportDays = csv[++index].GetTrimmedValueOrNull(),
                    AdvancedCardiovascularSupportDays = csv[++index].GetTrimmedValueOrNull(),
                    BasicCardiovascularSupportDays = csv[++index].GetTrimmedValueOrNull(),
                    RenalSupportDays = csv[++index].GetTrimmedValueOrNull(),
                    NeurologicalSupportDays = csv[++index].GetTrimmedValueOrNull(),
                    DermatologicalSupportDays = csv[++index].GetTrimmedValueOrNull(),
                    LiverSupportDays = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareLevel2Days = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareLevel3Days = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareDischargeDate = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareUnitBedConfiguration = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareAdmissionSource = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareSourceLocation = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareAdmissionType = csv[++index].GetTrimmedValueOrNull(),
                    GastroIntestinalSupportDays = csv[++index].GetTrimmedValueOrNull(),
                    OrganSupportMaximum = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareDischargeReadyDate = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareDischargeReadyTime = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareDischargeStatus = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareDischargeDestination = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareDischargeLocation = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareDischargeTime = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareActivityToEpisodeRelationshipDerived = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCarePeriodSequenceNumber = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCareStartTime = csv[++index].GetTrimmedValueOrNull(),
                    CriticalCarePeriodType = csv[++index].GetTrimmedValueOrNull()
                };

                if (criticalCare.IsEmpty)
                    break;

                criticalCareItems.Add(criticalCare);
            }

            yield return
                new APCRecord(
                    record,
                    visitors,
                    icdDiagnoses,
                    readDiagnoses,
                    opcdProcedure,
                    readProcedure,
                    careLocations,
                    births,
                    criticalCareItems);
        }
    }
}