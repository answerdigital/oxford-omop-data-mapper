using System.Buffers;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection.Emit;
using CsvHelper;
using OmopTransformer.CDS.Parser;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace OmopTransformer.SUS.Staging.APC;

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
            var readProcedure = new List<APCReadProcedure>();
            var careLocations = new List<APCCareLocation>();
            var births = new List<APCBirth>();
            var criticalCareItems = new List<APCCriticalCare>();

            Guid messageId = Guid.NewGuid();

            var record = new APCRow
            {
                MessageId = messageId,
                GeneratedRecordIdentifier = csv.GetField<string>("Generated Record Identifier").GetTrimmedValueOrNull(),
                PBRSpellID = csv.GetField<string>("PBR Spell ID").GetTrimmedValueOrNull(),
                ReasonForAccess = csv.GetField<string>("Reason for Access").GetTrimmedValueOrNull(),
                CDSType = csv.GetField<string>("CDS type").GetTrimmedValueOrNull(),
                ProtocolIdentifier = csv.GetField<string>("Protocol identifier").GetTrimmedValueOrNull(),
                UniqueCDSIdentifier = csv.GetField<string>("Unique CDS identifier").GetTrimmedValueOrNull(),
                UpdateType = csv.GetField<string>("Update type").GetTrimmedValueOrNull(),
                BulkReplacementCDSGroup = csv.GetField<string>("Bulk replacement CDS group").GetTrimmedValueOrNull(),
                TestIndicator = csv.GetField<string>("Test indicator").GetTrimmedValueOrNull(),
                ApplicableDatetime = csv.GetField<string>("Applicable date/time").GetTrimmedValueOrNull(),
                CensusDate = csv.GetField<string>("Census date").GetTrimmedValueOrNull(),
                ExtractDatetime = csv.GetField<string>("Extract date/time").GetTrimmedValueOrNull(),
                ReportPeriodStartDate = csv.GetField<string>("Report period Start Date").GetTrimmedValueOrNull(),
                ReportPeriodEndDate = csv.GetField<string>("Report period End Date").GetTrimmedValueOrNull(),
                OrganisationCodeSenderOfTransaction = csv.GetField<string>("Organisation code: Sender of transaction").GetTrimmedValueOrNull(),
                OrganisationCodeTypeofSender = csv.GetField<string>("Organisation Code Type of Sender").GetTrimmedValueOrNull(),
                SubmissionDate = csv.GetField<string>("Submission Date").GetTrimmedValueOrNull(),
                CDSInterchangeID = csv.GetField<string>("CDS Interchange ID").GetTrimmedValueOrNull(),
                LocalPatientIdentifier = csv.GetField<string>("Local Patient Identifier").GetTrimmedValueOrNull(),
                OrganisationCodeLocalPatientIdentifier = csv.GetField<string>("Organisation Code (Local Patient Identifier)").GetTrimmedValueOrNull(),
                OrganisationCodeTypeLocalPatientIdentifier = csv.GetField<string>("Organisation Code Type (Local Patient Identifier)").GetTrimmedValueOrNull(),
                NHSNumber = csv.GetField<string>("NHS Number").GetTrimmedValueOrNull(),
                DateofBirth = csv.GetField<string>("Date of Birth").GetTrimmedValueOrNull(),
                BirthWeight = csv.GetField<string>("Birth Weight").GetTrimmedValueOrNull(),
                LiveOrStillBirth = csv.GetField<string>("Live or Still Birth").GetTrimmedValueOrNull(),
                CarerSupportIndicator = csv.GetField<string>("Carer Support Indicator").GetTrimmedValueOrNull(),
                LegalStatusClassificationOnAdmissionPsychiatricCensusOnly = csv.GetField<string>("Legal Status Classification on Admission (Psychiatric Census Only)").GetTrimmedValueOrNull(),
                EthnicGroup = csv.GetField<string>("Ethnic Group").GetTrimmedValueOrNull(),
                MaritalStatusPsychiatricCensusOnly = csv.GetField<string>("Marital Status (Psychiatric Census Only)").GetTrimmedValueOrNull(),
                NHSNumberTraceStatus = csv.GetField<string>("NHS Number Trace Status").GetTrimmedValueOrNull(),
                WithheldIdentityReason = csv.GetField<string>("Withheld Identity Reason").GetTrimmedValueOrNull(),
                Sex = csv.GetField<string>("Sex").GetTrimmedValueOrNull(),
                PregnancyTotalPreviousPregnancies = csv.GetField<string>("Pregnancy Total Previous Pregnancies").GetTrimmedValueOrNull(),
                NameFormatCode = csv.GetField<string>("Name Format Code").GetTrimmedValueOrNull(),
                PatientName = csv.GetField<string>("Patient Name").GetTrimmedValueOrNull(),
                PersonTitle = csv.GetField<string>("Person Title").GetTrimmedValueOrNull(),
                PersonGivenName = csv.GetField<string>("Person Given Name").GetTrimmedValueOrNull(),
                PersonFamilyName = csv.GetField<string>("Person Family Name").GetTrimmedValueOrNull(),
                PersonNameSuffix = csv.GetField<string>("Person Name Suffix").GetTrimmedValueOrNull(),
                PersonInitials = csv.GetField<string>("Person Initials").GetTrimmedValueOrNull(),
                AddressFormatCode = csv.GetField<string>("Address Format Code").GetTrimmedValueOrNull(),
                PatientUsualAddress = csv.GetField<string>("Patient Usual Address").GetTrimmedValueOrNull(),
                Postcode = csv.GetField<string>("Postcode").GetTrimmedValueOrNull(),
                OrganisationCodeResidenceResponsibility = csv.GetField<string>("Organisation Code (Residence Responsibility)").GetTrimmedValueOrNull(),
                PCTofResidence = csv.GetField<string>("PCT of Residence").GetTrimmedValueOrNull(),
                OrganisationCodeTypePCTofResidence = csv.GetField<string>("Organisation Code Type (PCT of Residence)").GetTrimmedValueOrNull(),
                OSVClassificationatCDSActivityDate = csv.GetField<string>("OSV Classification at CDS Activity Date").GetTrimmedValueOrNull(),
                HospitalProviderSpellNumber = csv.GetField<string>("Hospital Provider Spell Number").GetTrimmedValueOrNull(),
                AdministrativeCategory = csv.GetField<string>("Administrative Category").GetTrimmedValueOrNull(),
                PatientClassification = csv.GetField<string>("Patient Classification").GetTrimmedValueOrNull(),
                AdmissionMethodHospitalProviderSpell = csv.GetField<string>("Admission Method (Hospital Provider Spell)").GetTrimmedValueOrNull(),
                DischargeDestinationHospitalProviderSpell = csv.GetField<string>("Discharge Destination (Hospital Provider Spell)").GetTrimmedValueOrNull(),
                DischargeMethodHospitalProviderSpell = csv.GetField<string>("Discharge Method (Hospital Provider Spell)").GetTrimmedValueOrNull(),
                SourceOfAdmissionHospitalProviderSpell = csv.GetField<string>("Source of Admission (Hospital Provider Spell)").GetTrimmedValueOrNull(),
                StartDateHospitalProviderSpell = csv.GetField<string>("Start Date (Hospital Provider Spell)").GetTrimmedValueOrNull(),
                StartTimeHospitalProviderSpell = csv.GetField<string>("Start Time (Hospital Provider Spell)").GetTrimmedValueOrNull(),
                DischargeDateFromHospitalProviderSpell = csv.GetField<string>("Discharge Date (From Hospital Provider Spell)").GetTrimmedValueOrNull(),
                DischargeTimeHospitalProviderSpell = csv.GetField<string>("Discharge Time (Hospital Provider Spell)").GetTrimmedValueOrNull(),
                DischargeToHospitalAtHomeServiceIndicator = csv.GetField<string>("Discharge To Hospital At Home Service Indicator").GetTrimmedValueOrNull(),
                EpisodeNumber = csv.GetField<string>("Episode Number").GetTrimmedValueOrNull(),
                FirstRegularDayNightAdmission = csv.GetField<string>("First Regular Day Night Admission").GetTrimmedValueOrNull(),
                LastEpisodeInSpellIndicator = csv.GetField<string>("Last Episode In Spell Indicator").GetTrimmedValueOrNull(),
                NeonatalLevelOfCare = csv.GetField<string>("Neonatal Level of Care").GetTrimmedValueOrNull(),
                OperationStatus = csv.GetField<string>("Operation Status").GetTrimmedValueOrNull(),
                PsychiatricPatientStatus = csv.GetField<string>("Psychiatric Patient Status").GetTrimmedValueOrNull(),
                StartDateConsultantEpisode = csv.GetField<string>("Start Date (Consultant Episode)").GetTrimmedValueOrNull(),
                StartTimeEpisode = csv.GetField<string>("Start Time (Episode)").GetTrimmedValueOrNull(),
                EndDateConsultantEpisode = csv.GetField<string>("End Date (Consultant Episode)").GetTrimmedValueOrNull(),
                EndTimeEpisode = csv.GetField<string>("End Time (Episode)").GetTrimmedValueOrNull(),
                LengthOfStayAdjustmentRehabilitation = csv.GetField<string>("Length Of Stay Adjustment (Rehabilitation)").GetTrimmedValueOrNull(),
                LengthOfStayAdjustmentSpecialistPalliativeCare = csv.GetField<string>("Length Of Stay Adjustment (Specialist Palliative Care)").GetTrimmedValueOrNull(),
                CommissioningSerialNumber = csv.GetField<string>("Commissioning Serial Number").GetTrimmedValueOrNull(),
                NHSServiceAgreementLineNumber = csv.GetField<string>("NHS Service Agreement Line Number").GetTrimmedValueOrNull(),
                ProviderReferenceNumber = csv.GetField<string>("Provider Reference Number").GetTrimmedValueOrNull(),
                CommissionerReferenceNumber = csv.GetField<string>("Commissioner Reference Number").GetTrimmedValueOrNull(),
                OrganisationCodeCodeOfProvider = csv.GetField<string>("Organisation Code Code of Provider").GetTrimmedValueOrNull(),
                OrganisationCodeTypeOfProvider = csv.GetField<string>("Organisation Code Type of Provider").GetTrimmedValueOrNull(),
                OrganisationCodeCodeOfCommissioner = csv.GetField<string>("Organisation Code Code of Commissioner").GetTrimmedValueOrNull(),
                OrganisationCodeTypeofCommissioner = csv.GetField<string>("Organisation Code Type of Commissioner").GetTrimmedValueOrNull(),
                ConsultantCode = csv.GetField<string>("Consultant Code").GetTrimmedValueOrNull(),
                MainSpecialtyCode = csv.GetField<string>("Main Specialty Code").GetTrimmedValueOrNull(),
                TreatmentFunctionCode = csv.GetField<string>("Treatment Function Code").GetTrimmedValueOrNull(),
                LocalSubSpecialtyCode = csv.GetField<string>("Local Sub Specialty Code").GetTrimmedValueOrNull(),
                MultiProfessionalOrMultidisciplinaryIndCode = csv.GetField<string>("Multi-Professional Or Multidisciplinary Ind Code").GetTrimmedValueOrNull(),
                RehabilitationAssessmentTeamType = csv.GetField<string>("Rehabilitation Assessment Team Type").GetTrimmedValueOrNull(),
                DiagnosisSchemeInUseICD = csv.GetField<string>("Diagnosis Scheme In Use (ICD)").GetTrimmedValueOrNull(),
                DiagnosisSchemeInUseRead = csv.GetField<string>("Diagnosis Scheme In Use (Read)").GetTrimmedValueOrNull(),
                ProcedureSchemeInUseOPCS = csv.GetField<string>("Procedure Scheme In Use (OPCS)").GetTrimmedValueOrNull(),
                ProcedureSchemeInUseREAD = csv.GetField<string>("Procedure Scheme In Use (READ)").GetTrimmedValueOrNull(),
                WardCodeAtEpisodeStartDate = csv.GetField<string>("Ward Code at Episode Start Date").GetTrimmedValueOrNull(),
                WardSecurityLevelAtEpisodeStartDate = csv.GetField<string>("Ward Security Level at Episode Start Date").GetTrimmedValueOrNull(),
                LocationClassAtEpisodeStartDate = csv.GetField<string>("Location Class at Episode Start Date").GetTrimmedValueOrNull(),
                SiteCodeOfTreatmentAtEpisodeStartDate = csv.GetField<string>("Site Code (of Treatment) At Episode Start Date").GetTrimmedValueOrNull(),
                OrganisationCodeTypeSiteCodeOfTreatmentAtStartOfEpisode = csv.GetField<string>("Organisation Code Type (Site Code of Treatment) (At Start of Episode)").GetTrimmedValueOrNull(),
                IntendedClinicalCareIntensityAtStartOfEpisode = csv.GetField<string>("Intended Clinical Care Intensity(At Start of Episode)").GetTrimmedValueOrNull(),
                AgeGroupIntendedAtStartOfEpisode = csv.GetField<string>("Age Group Intended (At Start of Episode)").GetTrimmedValueOrNull(),
                SexOfPatientsAtStartOfEpisode = csv.GetField<string>("Sex of Patients (At Start of Episode)").GetTrimmedValueOrNull(),
                WardDayPeriodAvailability = csv.GetField<string>("Ward Day Period Availability").GetTrimmedValueOrNull(),
                WardNightPeriodAvailability = csv.GetField<string>("Ward Night Period Availability").GetTrimmedValueOrNull(),
                WardCodeAtEpisodeEndDate = csv.GetField<string>("Ward Code at Episode End Date").GetTrimmedValueOrNull(),
                WardSecurityLevelAtEpisodeEndDate = csv.GetField<string>("Ward Security Level at Episode End Date").GetTrimmedValueOrNull(),
                LocationClassAtEpisodeEndDate = csv.GetField<string>("Location Class at Episode End Date").GetTrimmedValueOrNull(),
                SiteCodeOfTreatmentAtEpisodeEndDate = csv.GetField<string>("Site Code (of Treatment) at Episode End Date").GetTrimmedValueOrNull(),
                OrganisationCodeTypeSiteCodeOfTreatmentAtEpisodeEndDate = csv.GetField<string>("Organisation Code Type Site Code (of Treatment) at Episode End Date").GetTrimmedValueOrNull(),
                IntendedClinicalCareIntensityAtEpisodeEndDate = csv.GetField<string>("Intended Clinical Care Intensity at Episode End Date").GetTrimmedValueOrNull(),
                AgeGroupIntendedAtEpisodeEndDate = csv.GetField<string>("Age Group Intended at Episode End Date").GetTrimmedValueOrNull(),
                SexOfPatientsAtEpisodeEndDate = csv.GetField<string>("Sex of Patients at Episode End Date").GetTrimmedValueOrNull(),
                WardDayPeriodAvailabilityAtEpisodeEndDate = csv.GetField<string>("Ward Day Period Availability at Episode End Date").GetTrimmedValueOrNull(),
                WardNightPeriodAvailabilityAtEpisodeEndDate = csv.GetField<string>("Ward Night Period Availability at Episode End Date").GetTrimmedValueOrNull(),
                GeneralMedicalPractitionerCodeofRegisteredGMP = csv.GetField<string>("General Medical Practitioner Code of Registered GMP").GetTrimmedValueOrNull(),
                PracticeCodeOfRegisteredGP = csv.GetField<string>("Practice Code of Registered GP").GetTrimmedValueOrNull(),
                OrganisationCodeTypeofRegisteredGP = csv.GetField<string>("Organisation Code Type of Registered GP").GetTrimmedValueOrNull(),
                ReferrerCode = csv.GetField<string>("Referrer Code").GetTrimmedValueOrNull(),
                ReferringOrganisationCode = csv.GetField<string>("Referring Organisation Code").GetTrimmedValueOrNull(),
                OrganisationCodeTypeofReferrer = csv.GetField<string>("Organisation Code Type of Referrer").GetTrimmedValueOrNull(),
                DirectAccessReferralIndicator = csv.GetField<string>("Direct Access Referral Indicator").GetTrimmedValueOrNull(),
                AmbulanceIncidentNumber = csv.GetField<string>("Ambulance Incident Number").GetTrimmedValueOrNull(),
                OrganisationCodeConveyingAmbulanceTrust = csv.GetField<string>("Organisation Code (Conveying Ambulance Trust)").GetTrimmedValueOrNull(),
                DurationofElectiveWait = csv.GetField<string>("Duration of Elective Wait").GetTrimmedValueOrNull(),
                IntendedManagement = csv.GetField<string>("Intended Management").GetTrimmedValueOrNull(),
                DecidedToAdmitDateForThisProvider = csv.GetField<string>("Decided To Admit Date (For This Provider)").GetTrimmedValueOrNull(),
                WaitingTimeMeasurementType = csv.GetField<string>("Waiting Time Measurement Type").GetTrimmedValueOrNull(),
                LocationTypeCodeAtStartOfEpisode = csv.GetField<string>("Location Type Code at Start of Episode").GetTrimmedValueOrNull(),
                HRGCode = csv.GetField<string>("HRG Code").GetTrimmedValueOrNull(),
                HRGVersionNumber = csv.GetField<string>("HRG Version Number").GetTrimmedValueOrNull(),
                ProcedureSchemeInUse = csv.GetField<string>("Procedure Scheme In Use").GetTrimmedValueOrNull(),
                DominantGroupingVariableProcedure = csv.GetField<string>("Dominant Grouping Variable - Procedure").GetTrimmedValueOrNull(),
                FCEHRG = csv.GetField<string>("FCE HRG").GetTrimmedValueOrNull(),
                EpisodeHRGVersionNumber = csv.GetField<string>("Episode HRG Version Number").GetTrimmedValueOrNull(),
                SpellCoreHRG = csv.GetField<string>("Spell Core HRG").GetTrimmedValueOrNull(),
                SpellHRGVersionNumber = csv.GetField<string>("Spell HRG Version Number").GetTrimmedValueOrNull(),
                NumberOfBabies = csv.GetField<string>("Number of Babies").GetTrimmedValueOrNull(),
                FirstAntenatalAssessmentDate = csv.GetField<string>("First Antenatal Assessment Date").GetTrimmedValueOrNull(),
                GMPCodeofGMPResponsibleforAntenatalCare = csv.GetField<string>("GMP (Code of GMP Responsible for Antenatal Care)").GetTrimmedValueOrNull(),
                CodeofGPPracticeRegisteredGMPAntenatalCare = csv.GetField<string>("Code of GP Practice (Registered GMP- Antenatal Care)").GetTrimmedValueOrNull(),
                OrganisationCodeTypeGPPracticeRegisteredGMPAntenatalCare = csv.GetField<string>("Organisation Code Type GP Practice (Registered GMP- Antenatal Care)").GetTrimmedValueOrNull(),
                LocationClassOfDeliveryPlaceIntended = csv.GetField<string>("Location Class of Delivery Place (Intended)").GetTrimmedValueOrNull(),
                LocationTypeofDeliveryPlaceIntended = csv.GetField<string>("Location Type of Delivery Place (Intended)").GetTrimmedValueOrNull(),
                DeliveryPlaceChangeReason = csv.GetField<string>("Delivery Place Change Reason").GetTrimmedValueOrNull(),
                DeliveryPlaceTypeIntended = csv.GetField<string>("Delivery Place Type (Intended)").GetTrimmedValueOrNull(),
                AnaestheticGivenDuringLabourDelivery = csv.GetField<string>("Anaesthetic Given During Labour/Delivery").GetTrimmedValueOrNull(),
                AnaestheticGivenPostDelivery = csv.GetField<string>("Anaesthetic Given Post Delivery").GetTrimmedValueOrNull(),
                GestationLengthLabourOnset = csv.GetField<string>("Gestation Length (Labour Onset)").GetTrimmedValueOrNull(),
                LabourDeliveryOnsetMethod = csv.GetField<string>("Labour/Delivery Onset Method").GetTrimmedValueOrNull(),
                DeliveryDate = csv.GetField<string>("Delivery Date").GetTrimmedValueOrNull(),
                GestationLengthAssessmentBaby = csv.GetField<string>("Gestation Length (Assessment) Baby").GetTrimmedValueOrNull(),
                LocalPatientIdentifierMother = csv.GetField<string>("Local Patient Identifier (Mother)").GetTrimmedValueOrNull(),
                OrganisationCodeLocalPatientIdentifierMother = csv.GetField<string>("Organisation Code (Local Patient Identifier (Mother))").GetTrimmedValueOrNull(),
                OrganisationCodeTypeMother = csv.GetField<string>("Organisation Code Type (Mother)").GetTrimmedValueOrNull(),
                NHSNumberMother = csv.GetField<string>("NHS Number (Mother)").GetTrimmedValueOrNull(),
                NHSNumberStatusIndicatorMother = csv.GetField<string>("NHS Number Status Indicator (Mother)").GetTrimmedValueOrNull(),
                BirthDateMother = csv.GetField<string>("Birth Date (Mother)").GetTrimmedValueOrNull(),
                AddressFormatCodeMother = csv.GetField<string>("Address Format Code (Mother)").GetTrimmedValueOrNull(),
                PatientUsualAddressMother = csv.GetField<string>("Patient Usual Address (Mother)").GetTrimmedValueOrNull(),
                PostcodeOfUsualAddressMother = csv.GetField<string>("Postcode of Usual Address (Mother)").GetTrimmedValueOrNull(),
                OrganisationCodePCTofResidenceMother = csv.GetField<string>("Organisation Code (PCT of Residence) (Mother)").GetTrimmedValueOrNull(),
                OrganisationCodeTypePCTofResidenceMother = csv.GetField<string>("Organisation Code Type (PCT of Residence) (Mother)").GetTrimmedValueOrNull(),
                UniqueBookingReferenceNumberConverted = csv.GetField<string>("Unique Booking Reference Number Converted").GetTrimmedValueOrNull(),
                PatientPathwayIdentifier = csv.GetField<string>("Patient Pathway Identifier").GetTrimmedValueOrNull(),
                OrganisationCodePatientPathwayIdentifierIssuer = csv.GetField<string>("Organisation Code Patient Pathway Identifier Issuer").GetTrimmedValueOrNull(),
                ReferralToTreatmentPeriodStatus = csv.GetField<string>("Referral To Treatment Period Status").GetTrimmedValueOrNull(),
                ReferralToTreatmentPeriodStartDate = csv.GetField<string>("Referral To Treatment Period Start Date").GetTrimmedValueOrNull(),
                ReferralToTreatmentPeriodEndDate = csv.GetField<string>("Referral To Treatment Period End Date").GetTrimmedValueOrNull(),
                LeadCareActivityIndicator = csv.GetField<string>("Lead Care Activity Indicator").GetTrimmedValueOrNull(),
                AgeatCDSActivityDate = csv.GetField<string>("Age at CDS Activity Date").GetTrimmedValueOrNull(),
                NHSServiceAgreementChangeDate = csv.GetField<string>("NHS Service Agreement Change Date").GetTrimmedValueOrNull(),
                CDSActivityDate = csv.GetField<string>("CDS Activity Date").GetTrimmedValueOrNull(),
                AgeAsOnAdmission = csv.GetField<string>("Age as on Admission").GetTrimmedValueOrNull(),
                AdminCategoryAtStart = csv.GetField<string>("Admin Category at Start").GetTrimmedValueOrNull(),
                HospitalProviderSpellDischargeReadyDate = csv.GetField<string>("Hospital Provider Spell Discharge Ready Date").GetTrimmedValueOrNull(),
                LocationType = csv.GetField<string>("Location Type").GetTrimmedValueOrNull(),
                XMLVersion = csv.GetField<string>("XML Version").GetTrimmedValueOrNull(),
                ConfidentialityCategoryDerived = csv.GetField<string>("Confidentiality Category (Derived)").GetTrimmedValueOrNull(),
                ReferralToTreatmentLengthDerived = csv.GetField<string>("Referral To Treatment Length (Derived)").GetTrimmedValueOrNull(),
                AgeRangePatientdDerivedFromDOB = csv.GetField<string>("Age range patient derived from DOB").GetTrimmedValueOrNull(),
                AgeRangeMotherDerivedFromDOB = csv.GetField<string>("Age range mother derived from DOB").GetTrimmedValueOrNull(),
                AreaCodeDerivedFromPostcode = csv.GetField<string>("Area code derived from postcode.").GetTrimmedValueOrNull(),
                CDSGroup = csv.GetField<string>("CDS Group").GetTrimmedValueOrNull(),
                FinishedIndicator = csv.GetField<string>("Finished Indicator").GetTrimmedValueOrNull(),
                PCTDerivedfromGP = csv.GetField<string>("PCT (Derived from GP)").GetTrimmedValueOrNull(),
                PCTTypeDerivedfromGP = csv.GetField<string>("PCT Type (Derived from GP)").GetTrimmedValueOrNull(),
                GPPracticeDerived = csv.GetField<string>("GP Practice (Derived)").GetTrimmedValueOrNull(),
                GPPracticeMotherDerived = csv.GetField<string>("GP Practice Mother (Derived)").GetTrimmedValueOrNull(),
                PCTDerivedfromderivedGPPractice = csv.GetField<string>("PCT (Derived from derived GP Practice)").GetTrimmedValueOrNull(),
                PCTMotherDerivedfromderivedGPPractice = csv.GetField<string>("PCT Mother (Derived from derived GP Practice)").GetTrimmedValueOrNull(),
                SHAfromGPPractice = csv.GetField<string>("SHA from GP Practice").GetTrimmedValueOrNull(),
                SHATypefromGPPractice = csv.GetField<string>("SHA Type from GP Practice").GetTrimmedValueOrNull(),
                HospitalSpellDuration = csv.GetField<string>("Hospital Spell Duration").GetTrimmedValueOrNull(),
                MonthOfBirth = csv.GetField<string>("Month of Birth").GetTrimmedValueOrNull(),
                HomeBirthOrDelivery = csv.GetField<string>("Home Birth or Delivery").GetTrimmedValueOrNull(),
                ElectoralWardFromPostcode = csv.GetField<string>("Electoral Ward from postcode").GetTrimmedValueOrNull(),
                PCTFromPostcode = csv.GetField<string>("PCT from postcode").GetTrimmedValueOrNull(),
                PCTTypefromPostcode = csv.GetField<string>("PCT Type from Postcode").GetTrimmedValueOrNull(),
                SHAfromPostcode = csv.GetField<string>("SHA from Postcode").GetTrimmedValueOrNull(),
                SHATypefromPostcode = csv.GetField<string>("SHA Type from Postcode").GetTrimmedValueOrNull(),
                AreacodeFromProviderPostcode = csv.GetField<string>("Area code from Provider Postcode").GetTrimmedValueOrNull(),
                AgeAtEndOfEpisode = csv.GetField<string>("Age at End of Episode").GetTrimmedValueOrNull(),
                AgeAtStartOfEpisode = csv.GetField<string>("Age at Start of Episode").GetTrimmedValueOrNull(),
                YearOfBirth = csv.GetField<string>("Year of Birth").GetTrimmedValueOrNull(),
                YearOfBirthMother = csv.GetField<string>("Year of Birth Mother").GetTrimmedValueOrNull(),
                MonthOfBirthMother = csv.GetField<string>("Month of Birth Mother").GetTrimmedValueOrNull(),
                CensusArea = csv.GetField<string>("2001 Census Area").GetTrimmedValueOrNull(),
                Country = csv.GetField<string>("Country").GetTrimmedValueOrNull(),
                CountyCode = csv.GetField<string>("County Code").GetTrimmedValueOrNull(),
                CensusED = csv.GetField<string>("1991 Census ED").GetTrimmedValueOrNull(),
                EDDistrictCode = csv.GetField<string>("ED District Code").GetTrimmedValueOrNull(),
                ElectoralWardCode = csv.GetField<string>("Electoral Ward Code").GetTrimmedValueOrNull(),
                GORCode = csv.GetField<string>("GOR Code").GetTrimmedValueOrNull(),
                LocalUnitaryAuthority = csv.GetField<string>("Local Unitary Authority").GetTrimmedValueOrNull(),
                OldSHACode = csv.GetField<string>("Old SHA Code").GetTrimmedValueOrNull(),
                ElectoralArea = csv.GetField<string>("1998 Electoral Area").GetTrimmedValueOrNull(),
                PrimeRecipient = csv.GetField<string>("Prime Recipient").GetTrimmedValueOrNull(),
                CopyRecipients = csv.GetField<string>("Copy Recipients").GetTrimmedValueOrNull(),
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
                var procedure = new APCReadProcedure
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
                var careLocation = new APCCareLocation
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
                var birth = new APCBirth
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
                var criticalCare = new APCCriticalCare
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