using System.Globalization;
using CsvHelper;

namespace OmopTransformer.SUS.Staging.OP;

internal class SusOPParser : ISusOPParser
{
    public IEnumerable<OPRecord> ReadFile(string path, CancellationToken cancellationToken)
    {
        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Read();
        csv.ReadHeader();

        while (csv.Read())
        {
            cancellationToken.ThrowIfCancellationRequested();

            var icdDiagnoses = new List<IcdDiagnosis>();
            var readDiagnoses = new List<ReadDiagnosis>();
            var opcdProcedure = new List<OpcsProcedure>();
            var readProcedure = new List<OPReadProcedure>();

            Guid messageId = Guid.NewGuid();

            var record = new OPRow
            {
                MessageId = messageId,
                GeneratedRecordIdentifier = csv.GetField<string>("Generated Record Identifier").GetTrimmedValueOrNull(),
                ReasonforAccess = csv.GetField<string>("Reason for Access").GetTrimmedValueOrNull(),
                CDStype = csv.GetField<string>("CDS type").GetTrimmedValueOrNull(),
                Protocolidentifier = csv.GetField<string>("Protocol identifier").GetTrimmedValueOrNull(),
                UniqueCDSidentifier = csv.GetField<string>("Unique CDS identifier").GetTrimmedValueOrNull(),
                SUSgeneratedspellID = csv.GetField<string>("SUS generated spell ID").GetTrimmedValueOrNull(),
                Updatetype = csv.GetField<string>("Update type").GetTrimmedValueOrNull(),
                BulkreplacementCDSgroup = csv.GetField<string>("Bulk replacement CDS group").GetTrimmedValueOrNull(),
                Testindicator = csv.GetField<string>("Test indicator").GetTrimmedValueOrNull(),
                Applicabledatetime = csv.GetField<string>("Applicable date/time").GetTrimmedValueOrNull(),
                Censusdate = csv.GetField<string>("Census date").GetTrimmedValueOrNull(),
                Extractdatetime = csv.GetField<string>("Extract date/time").GetTrimmedValueOrNull(),
                ReportperiodStartDate = csv.GetField<string>("Report period Start Date").GetTrimmedValueOrNull(),
                ReportperiodEndDate = csv.GetField<string>("Report period End Date").GetTrimmedValueOrNull(),
                OrganisationcodeSenderoftransaction = csv.GetField<string>("Organisation code: Sender of transaction").GetTrimmedValueOrNull(),
                OrganisationCodeTypeofSender = csv.GetField<string>("Organisation Code Type of Sender").GetTrimmedValueOrNull(),
                SubmissionDate = csv.GetField<string>("Submission Date").GetTrimmedValueOrNull(),
                CDSInterchangeID = csv.GetField<string>("CDS Interchange ID").GetTrimmedValueOrNull(),
                LocalPatientIdentifier = csv.GetField<string>("Local Patient Identifier").GetTrimmedValueOrNull(),
                OrganisationCodeLocalPatientIdentifier = csv.GetField<string>("Organisation Code (Local Patient Identifier)").GetTrimmedValueOrNull(),
                OrganisationCodeTypeLocalPatientIdentifier = csv.GetField<string>("Organisation Code Type (Local Patient Identifier)").GetTrimmedValueOrNull(),
                NHSNumber = csv.GetField<string>("NHS Number").GetTrimmedValueOrNull(),
                DateofBirth = csv.GetField<string>("Date of Birth").GetTrimmedValueOrNull(),
                CarerSupportIndicator = csv.GetField<string>("Carer Support Indicator").GetTrimmedValueOrNull(),
                NHSNumberTraceStatus = csv.GetField<string>("NHS Number Trace Status").GetTrimmedValueOrNull(),
                WithheldIdentityReason = csv.GetField<string>("Withheld Identity Reason").GetTrimmedValueOrNull(),
                Sex = csv.GetField<string>("Sex").GetTrimmedValueOrNull(),
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
                EthnicCategory = csv.GetField<string>("Ethnic Category").GetTrimmedValueOrNull(),
                OSVClassificationatCDSActivityDate = csv.GetField<string>("OSV Classification at CDS Activity Date").GetTrimmedValueOrNull(),
                ConsultantCode = csv.GetField<string>("Consultant Code").GetTrimmedValueOrNull(),
                MainSpecialtyCode = csv.GetField<string>("Main Specialty Code").GetTrimmedValueOrNull(),
                TreatmentFunctionCode = csv.GetField<string>("Treatment Function Code").GetTrimmedValueOrNull(),
                LocalSubSpecialtyCode = csv.GetField<string>("Local Sub Specialty Code").GetTrimmedValueOrNull(),
                MultiProfessionalOrMultidisciplinaryIndCode = csv.GetField<string>("Multi-Professional Or Multidisciplinary Ind Code").GetTrimmedValueOrNull(),
                RehabilitationAssessmentTeamType = csv.GetField<string>("Rehabilitation Assessment Team Type").GetTrimmedValueOrNull(),
                DiagnosisSchemeInUseICD = csv.GetField<string>("Diagnosis Scheme In Use (ICD)").GetTrimmedValueOrNull(),
                DiagnosisSchemeInUseRead = csv.GetField<string>("Diagnosis Scheme In Use (Read)").GetTrimmedValueOrNull(),
                AttendanceIdentifier = csv.GetField<string>("Attendance Identifier").GetTrimmedValueOrNull(),
                AdministrativeCategory = csv.GetField<string>("Administrative Category").GetTrimmedValueOrNull(),
                AttendedorDidNotAttend = csv.GetField<string>("Attended or Did Not Attend").GetTrimmedValueOrNull(),
                FirstAttendance = csv.GetField<string>("First Attendance").GetTrimmedValueOrNull(),
                MedicalStaffTypeSeeingPatient = csv.GetField<string>("Medical Staff Type Seeing Patient").GetTrimmedValueOrNull(),
                OperationStatusPerAttendance = csv.GetField<string>("Operation Status (Per Attendance)").GetTrimmedValueOrNull(),
                OutcomeofAttendance = csv.GetField<string>("Outcome of Attendance").GetTrimmedValueOrNull(),
                AppointmentDate = csv.GetField<string>("Appointment Date").GetTrimmedValueOrNull(),
                AppointmentTime = csv.GetField<string>("Appointment Time").GetTrimmedValueOrNull(),
                ExpectedDurationOfAppointment = csv.GetField<string>("Expected Duration Of Appointment").GetTrimmedValueOrNull(),
                ConsultationMediumUsed = csv.GetField<string>("Consultation Medium Used").GetTrimmedValueOrNull(),
                WaitingTimeMeasurementType = csv.GetField<string>("Waiting Time Measurement Type").GetTrimmedValueOrNull(),
                ActivityLocationTypeCode = csv.GetField<string>("Activity Location Type Code").GetTrimmedValueOrNull(),
                EarliestClinicallyAppropriateDate = csv.GetField<string>("Earliest Clinically Appropriate Date").GetTrimmedValueOrNull(),
                ClinicCode = csv.GetField<string>("Clinic Code").GetTrimmedValueOrNull(),
                CommissioningSerialNumber = csv.GetField<string>("Commissioning Serial Number").GetTrimmedValueOrNull(),
                NHSServiceAgreementLineNumber = csv.GetField<string>("NHS Service Agreement Line Number").GetTrimmedValueOrNull(),
                ProviderReferenceNumber = csv.GetField<string>("Provider Reference Number").GetTrimmedValueOrNull(),
                CommissionerReferenceNumber = csv.GetField<string>("Commissioner Reference Number").GetTrimmedValueOrNull(),
                OrganisationCodeCodeofProvider = csv.GetField<string>("Organisation Code (Code of Provider)").GetTrimmedValueOrNull(),
                OrganisationCodeTypeCodeofProvider = csv.GetField<string>("Organisation Code Type (Code of Provider)").GetTrimmedValueOrNull(),
                OrganisationCodeCodeofCommissioner = csv.GetField<string>("Organisation Code (Code of Commissioner)").GetTrimmedValueOrNull(),
                OrganisationCodeTypeCodeofCommissioner = csv.GetField<string>("Organisation Code Type (Code of Commissioner)").GetTrimmedValueOrNull(),
                ProcedureSchemeInUseOPCS = csv.GetField<string>("Procedure Scheme In Use (OPCS)").GetTrimmedValueOrNull(),
                ProcedureSchemeInUseRead = csv.GetField<string>("Procedure Scheme In Use (Read)").GetTrimmedValueOrNull(),
                LocationClassatAttendance = csv.GetField<string>("Location Class at Attendance").GetTrimmedValueOrNull(),
                SiteCodeofTreatment = csv.GetField<string>("Site Code (of Treatment)").GetTrimmedValueOrNull(),
                OrganisationCodeTypeSiteCodeofTreatmentAtAttendance = csv.GetField<string>("Organisation Code Type (Site Code of Treatment) (At Attendance)").GetTrimmedValueOrNull(),
                GeneralMedicalPractitionerCodeofRegisteredGMP = csv.GetField<string>("General Medical Practitioner Code of Registered GMP").GetTrimmedValueOrNull(),
                PracticeCodeofRegisteredGP = csv.GetField<string>("Practice Code of Registered GP").GetTrimmedValueOrNull(),
                OrganisationCodeTypeofRegisteredGP = csv.GetField<string>("Organisation Code Type of Registered GP").GetTrimmedValueOrNull(),
                PriorityType = csv.GetField<string>("Priority Type").GetTrimmedValueOrNull(),
                ServiceTypeRequested = csv.GetField<string>("Service Type Requested").GetTrimmedValueOrNull(),
                SourceofReferralForOutpatients = csv.GetField<string>("Source of Referral For Outpatients").GetTrimmedValueOrNull(),
                ReferralRequestReceivedDate = csv.GetField<string>("Referral Request Received Date").GetTrimmedValueOrNull(),
                DirectAccessReferralIndicator = csv.GetField<string>("Direct Access Referral Indicator").GetTrimmedValueOrNull(),
                ReferrerCode = csv.GetField<string>("Referrer Code").GetTrimmedValueOrNull(),
                ReferringOrganisationCode = csv.GetField<string>("Referring Organisation Code").GetTrimmedValueOrNull(),
                OrganisationCodeTypeofReferrer = csv.GetField<string>("Organisation Code Type of Referrer").GetTrimmedValueOrNull(),
                LastDNAOrPatientCancelledDate = csv.GetField<string>("Last DNA Or Patient Cancelled Date").GetTrimmedValueOrNull(),
                HRGCode = csv.GetField<string>("HRG Code").GetTrimmedValueOrNull(),
                HRGVersionNumber = csv.GetField<string>("HRG Version Number").GetTrimmedValueOrNull(),
                ProcedureSchemeInUse = csv.GetField<string>("Procedure Scheme In Use").GetTrimmedValueOrNull(),
                DominantGroupingVariableProcedure = csv.GetField<string>("Dominant Grouping Variable - Procedure").GetTrimmedValueOrNull(),
                CoreHRG = csv.GetField<string>("Core HRG").GetTrimmedValueOrNull(),
                HRGVersionCalculated = csv.GetField<string>("HRG Version (Calculated)").GetTrimmedValueOrNull(),
                SUSHRG = csv.GetField<string>("SUS HRG").GetTrimmedValueOrNull(),
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
                EarliestReasonableOfferedDate = csv.GetField<string>("Earliest Reasonable Offered Date").GetTrimmedValueOrNull(),
                LocationType = csv.GetField<string>("Location Type").GetTrimmedValueOrNull(),
                XMLVersion = csv.GetField<string>("XML Version").GetTrimmedValueOrNull(),
                ConfidentialityCategoryDerived = csv.GetField<string>("Confidentiality Category (Derived)").GetTrimmedValueOrNull(),
                ReferralToTreatmentLengthDerived = csv.GetField<string>("Referral To Treatment Length (Derived)").GetTrimmedValueOrNull(),
                AgerangepatientderivedfromDOB = csv.GetField<string>("Age range patient derived from DOB").GetTrimmedValueOrNull(),
                Areacodederivedfrompostcode = csv.GetField<string>("Area code derived from postcode").GetTrimmedValueOrNull(),
                AttenderTypeDerived = csv.GetField<string>("Attender Type (Derived)").GetTrimmedValueOrNull(),
                CDSGroup = csv.GetField<string>("CDS Group").GetTrimmedValueOrNull(),
                FinishedIndicator = csv.GetField<string>("Finished Indicator").GetTrimmedValueOrNull(),
                PCTDerivedfromGP = csv.GetField<string>("PCT (Derived from GP)").GetTrimmedValueOrNull(),
                PCTTypeDerivedfromGP = csv.GetField<string>("PCT Type (Derived from GP)").GetTrimmedValueOrNull(),
                GPPracticeDerived = csv.GetField<string>("GP Practice (Derived)").GetTrimmedValueOrNull(),
                PCTDerivedfromderivedGPPractice = csv.GetField<string>("PCT (Derived from derived GP Practice)").GetTrimmedValueOrNull(),
                SHAfromGPPractice = csv.GetField<string>("SHA from GP Practice").GetTrimmedValueOrNull(),
                SHATypefromGPPractice = csv.GetField<string>("SHA Type from GP Practice").GetTrimmedValueOrNull(),
                MonthofBirth = csv.GetField<string>("Month of Birth").GetTrimmedValueOrNull(),
                ElectoralWardfrompostcode = csv.GetField<string>("Electoral Ward from postcode").GetTrimmedValueOrNull(),
                PCTfrompostcode = csv.GetField<string>("PCT from postcode").GetTrimmedValueOrNull(),
                PCTTypefromPostcode = csv.GetField<string>("PCT Type from Postcode").GetTrimmedValueOrNull(),
                SHAfromPostcode = csv.GetField<string>("SHA from Postcode").GetTrimmedValueOrNull(),
                SHATypefromPostcode = csv.GetField<string>("SHA Type from Postcode").GetTrimmedValueOrNull(),
                AreacodefromProviderPostcode = csv.GetField<string>("Area code from Provider Postcode").GetTrimmedValueOrNull(),
                AgeatEndofEpisode = csv.GetField<string>("Age at End of Episode").GetTrimmedValueOrNull(),
                AgeatStartofEpisode = csv.GetField<string>("Age at Start of Episode").GetTrimmedValueOrNull(),
                YearofBirth = csv.GetField<string>("Year of Birth").GetTrimmedValueOrNull(),
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
                IsValidUBRN = csv.GetField<string>("Is Valid UBRN").GetTrimmedValueOrNull(),
                UBRNOccurrenceCount = csv.GetField<string>("UBRN Occurrence Count").GetTrimmedValueOrNull(),

            };

            int index = 48;

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

            index = 98;

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

            index = 145;

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

            index = 267;
            isPrimaryProcedure = true;

            for (int i = 0; i < 24; i++)
            {
                var procedure = new OPReadProcedure
                {
                    MessageId = messageId,
                    ProcedureRead = csv[++index].GetTrimmedValueOrNull(),
                    IsPrimaryProcedure = isPrimaryProcedure
                };

                isPrimaryProcedure = false;

                if (procedure.IsEmpty)
                    break;

                readProcedure.Add(procedure);
            }

            yield return
                new OPRecord(
                    record,
                    icdDiagnoses,
                    readDiagnoses,
                    readProcedure,
                    opcdProcedure);
        }
    }
}