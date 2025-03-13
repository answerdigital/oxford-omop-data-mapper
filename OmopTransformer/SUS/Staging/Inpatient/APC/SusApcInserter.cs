using System.Data;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Data.SqlClient;

namespace OmopTransformer.SUS.Staging.Inpatient.APC;

internal class SusApcInserter : ISusAPCInserter
{
    private readonly Configuration _configuration;
    private readonly ILogger<SusApcInserter> _logger;

    public SusApcInserter(IOptions<Configuration> configuration, ILogger<SusApcInserter> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task Insert(IEnumerable<APCRecord> rows, CancellationToken cancellationToken)
    {
        if (rows == null) throw new ArgumentNullException(nameof(rows));

        _logger.LogInformation("Recording SUS rows.");

        var batches = rows.Batch(_configuration.BatchSize!.Value);
        int batchNumber = 1;

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        foreach (var batch in batches)
        {
            _logger.LogInformation("Batch {0}.", batchNumber++);

            await InsertBatch(batch, connection, cancellationToken);
        }
    }

    private async Task InsertBatch(IEnumerable<APCRecord> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var rowsList = rows.ToList();

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting APC.");
        await InsertAPC(rowsList.Select(row => row.ApcRow).ToList(), connection);
        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting APC CriticalCareItems.");
        await InsertCriticalCare(rowsList.SelectMany(row => row.CriticalCareItems).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting APC Births.");
        await InsertBirth(rowsList.SelectMany(row => row.Births).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting APC APCReadProcedure.");
        await InsertReadProcedure(rowsList.SelectMany(row => row.ReadProcedure).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting APC CriticalCaOpcdProcedurereItems.");
        await InsertOpcsProcedure(rowsList.SelectMany(row => row.OpcdProcedure).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting APC CareLocations.");
        await InsertCareLocation(rowsList.SelectMany(row => row.CareLocations).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting APC ReadDiagnoses.");
        await InsertReadDiagnosis(rowsList.SelectMany(row => row.ReadDiagnoses).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting APC IcdDiagnoses.");
        await InsertIcdDiagnosis(rowsList.SelectMany(row => row.IcdDiagnoses).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting APC OverseasVisitors.");
        await InsertOverseasVisitor(rowsList.SelectMany(row => row.OverseasVisitors).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();
    }

    private async Task InsertAPC(IReadOnlyCollection<APCRow> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("GeneratedRecordIdentifier");
        dataTable.Columns.Add("PBRSpellID");
        dataTable.Columns.Add("ReasonForAccess");
        dataTable.Columns.Add("CDSType");
        dataTable.Columns.Add("ProtocolIdentifier");
        dataTable.Columns.Add("UniqueCDSIdentifier");
        dataTable.Columns.Add("UpdateType");
        dataTable.Columns.Add("BulkReplacementCDSGroup");
        dataTable.Columns.Add("TestIndicator");
        dataTable.Columns.Add("ApplicableDatetime");
        dataTable.Columns.Add("CensusDate");
        dataTable.Columns.Add("ExtractDatetime");
        dataTable.Columns.Add("ReportPeriodStartDate");
        dataTable.Columns.Add("ReportPeriodEndDate");
        dataTable.Columns.Add("OrganisationCodeSenderOfTransaction");
        dataTable.Columns.Add("OrganisationCodeTypeofSender");
        dataTable.Columns.Add("SubmissionDate");
        dataTable.Columns.Add("CDSInterchangeID");
        dataTable.Columns.Add("LocalPatientIdentifier");
        dataTable.Columns.Add("OrganisationCodeLocalPatientIdentifier");
        dataTable.Columns.Add("OrganisationCodeTypeLocalPatientIdentifier");
        dataTable.Columns.Add("NHSNumber");
        dataTable.Columns.Add("DateofBirth");
        dataTable.Columns.Add("BirthWeight");
        dataTable.Columns.Add("LiveOrStillBirth");
        dataTable.Columns.Add("CarerSupportIndicator");
        dataTable.Columns.Add("LegalStatusClassificationOnAdmissionPsychiatricCensusOnly");
        dataTable.Columns.Add("EthnicGroup");
        dataTable.Columns.Add("MaritalStatusPsychiatricCensusOnly");
        dataTable.Columns.Add("NHSNumberTraceStatus");
        dataTable.Columns.Add("WithheldIdentityReason");
        dataTable.Columns.Add("Sex");
        dataTable.Columns.Add("PregnancyTotalPreviousPregnancies");
        dataTable.Columns.Add("NameFormatCode");
        dataTable.Columns.Add("PatientName");
        dataTable.Columns.Add("PersonTitle");
        dataTable.Columns.Add("PersonGivenName");
        dataTable.Columns.Add("PersonFamilyName");
        dataTable.Columns.Add("PersonNameSuffix");
        dataTable.Columns.Add("PersonInitials");
        dataTable.Columns.Add("AddressFormatCode");
        dataTable.Columns.Add("PatientUsualAddress");
        dataTable.Columns.Add("Postcode");
        dataTable.Columns.Add("OrganisationCodeResidenceResponsibility");
        dataTable.Columns.Add("PCTofResidence");
        dataTable.Columns.Add("OrganisationCodeTypePCTofResidence");
        dataTable.Columns.Add("OSVClassificationatCDSActivityDate");
        dataTable.Columns.Add("HospitalProviderSpellNumber");
        dataTable.Columns.Add("AdministrativeCategory");
        dataTable.Columns.Add("PatientClassification");
        dataTable.Columns.Add("AdmissionMethodHospitalProviderSpell");
        dataTable.Columns.Add("DischargeDestinationHospitalProviderSpell");
        dataTable.Columns.Add("DischargeMethodHospitalProviderSpell");
        dataTable.Columns.Add("SourceOfAdmissionHospitalProviderSpell");
        dataTable.Columns.Add("StartDateHospitalProviderSpell");
        dataTable.Columns.Add("StartTimeHospitalProviderSpell");
        dataTable.Columns.Add("DischargeDateFromHospitalProviderSpell");
        dataTable.Columns.Add("DischargeTimeHospitalProviderSpell");
        dataTable.Columns.Add("DischargeToHospitalAtHomeServiceIndicator");
        dataTable.Columns.Add("EpisodeNumber");
        dataTable.Columns.Add("FirstRegularDayNightAdmission");
        dataTable.Columns.Add("LastEpisodeInSpellIndicator");
        dataTable.Columns.Add("NeonatalLevelOfCare");
        dataTable.Columns.Add("OperationStatus");
        dataTable.Columns.Add("PsychiatricPatientStatus");
        dataTable.Columns.Add("StartDateConsultantEpisode");
        dataTable.Columns.Add("StartTimeEpisode");
        dataTable.Columns.Add("EndDateConsultantEpisode");
        dataTable.Columns.Add("EndTimeEpisode");
        dataTable.Columns.Add("LengthOfStayAdjustmentRehabilitation");
        dataTable.Columns.Add("LengthOfStayAdjustmentSpecialistPalliativeCare");
        dataTable.Columns.Add("CommissioningSerialNumber");
        dataTable.Columns.Add("NHSServiceAgreementLineNumber");
        dataTable.Columns.Add("ProviderReferenceNumber");
        dataTable.Columns.Add("CommissionerReferenceNumber");
        dataTable.Columns.Add("OrganisationCodeCodeOfProvider");
        dataTable.Columns.Add("OrganisationCodeTypeOfProvider");
        dataTable.Columns.Add("OrganisationCodeCodeOfCommissioner");
        dataTable.Columns.Add("OrganisationCodeTypeofCommissioner");
        dataTable.Columns.Add("ConsultantCode");
        dataTable.Columns.Add("MainSpecialtyCode");
        dataTable.Columns.Add("TreatmentFunctionCode");
        dataTable.Columns.Add("LocalSubSpecialtyCode");
        dataTable.Columns.Add("MultiProfessionalOrMultidisciplinaryIndCode");
        dataTable.Columns.Add("RehabilitationAssessmentTeamType");
        dataTable.Columns.Add("DiagnosisSchemeInUseICD");
        dataTable.Columns.Add("DiagnosisSchemeInUseRead");
        dataTable.Columns.Add("ProcedureSchemeInUseOPCS");
        dataTable.Columns.Add("ProcedureSchemeInUseREAD");
        dataTable.Columns.Add("WardCodeAtEpisodeStartDate");
        dataTable.Columns.Add("WardSecurityLevelAtEpisodeStartDate");
        dataTable.Columns.Add("LocationClassAtEpisodeStartDate");
        dataTable.Columns.Add("SiteCodeOfTreatmentAtEpisodeStartDate");
        dataTable.Columns.Add("OrganisationCodeTypeSiteCodeOfTreatmentAtStartOfEpisode");
        dataTable.Columns.Add("IntendedClinicalCareIntensityAtStartOfEpisode");
        dataTable.Columns.Add("AgeGroupIntendedAtStartOfEpisode");
        dataTable.Columns.Add("SexOfPatientsAtStartOfEpisode");
        dataTable.Columns.Add("WardDayPeriodAvailability");
        dataTable.Columns.Add("WardNightPeriodAvailability");
        dataTable.Columns.Add("WardCodeAtEpisodeEndDate");
        dataTable.Columns.Add("WardSecurityLevelAtEpisodeEndDate");
        dataTable.Columns.Add("LocationClassAtEpisodeEndDate");
        dataTable.Columns.Add("SiteCodeOfTreatmentAtEpisodeEndDate");
        dataTable.Columns.Add("OrganisationCodeTypeSiteCodeOfTreatmentAtEpisodeEndDate");
        dataTable.Columns.Add("IntendedClinicalCareIntensityAtEpisodeEndDate");
        dataTable.Columns.Add("AgeGroupIntendedAtEpisodeEndDate");
        dataTable.Columns.Add("SexOfPatientsAtEpisodeEndDate");
        dataTable.Columns.Add("WardDayPeriodAvailabilityAtEpisodeEndDate");
        dataTable.Columns.Add("WardNightPeriodAvailabilityAtEpisodeEndDate");
        dataTable.Columns.Add("GeneralMedicalPractitionerCodeofRegisteredGMP");
        dataTable.Columns.Add("PracticeCodeofRegisteredGP");
        dataTable.Columns.Add("OrganisationCodeTypeofRegisteredGP");
        dataTable.Columns.Add("ReferrerCode");
        dataTable.Columns.Add("ReferringOrganisationCode");
        dataTable.Columns.Add("OrganisationCodeTypeofReferrer");
        dataTable.Columns.Add("DirectAccessReferralIndicator");
        dataTable.Columns.Add("AmbulanceIncidentNumber");
        dataTable.Columns.Add("OrganisationCodeConveyingAmbulanceTrust");
        dataTable.Columns.Add("DurationofElectiveWait");
        dataTable.Columns.Add("IntendedManagement");
        dataTable.Columns.Add("DecidedToAdmitDateForThisProvider");
        dataTable.Columns.Add("WaitingTimeMeasurementType");
        dataTable.Columns.Add("LocationTypeCodeAtStartOfEpisode");
        dataTable.Columns.Add("HRGCode");
        dataTable.Columns.Add("HRGVersionNumber");
        dataTable.Columns.Add("ProcedureSchemeInUse");
        dataTable.Columns.Add("DominantGroupingVariableProcedure");
        dataTable.Columns.Add("FCEHRG");
        dataTable.Columns.Add("EpisodeHRGVersionNumber");
        dataTable.Columns.Add("SpellCoreHRG");
        dataTable.Columns.Add("SpellHRGVersionNumber");
        dataTable.Columns.Add("NumberOfBabies");
        dataTable.Columns.Add("FirstAntenatalAssessmentDate");
        dataTable.Columns.Add("GMPCodeofGMPResponsibleforAntenatalCare");
        dataTable.Columns.Add("CodeofGPPracticeRegisteredGMPAntenatalCare");
        dataTable.Columns.Add("OrganisationCodeTypeGPPracticeRegisteredGMPAntenatalCare");
        dataTable.Columns.Add("LocationClassOfDeliveryPlaceIntended");
        dataTable.Columns.Add("LocationTypeofDeliveryPlaceIntended");
        dataTable.Columns.Add("DeliveryPlaceChangeReason");
        dataTable.Columns.Add("DeliveryPlaceTypeIntended");
        dataTable.Columns.Add("AnaestheticGivenDuringLabourDelivery");
        dataTable.Columns.Add("AnaestheticGivenPostDelivery");
        dataTable.Columns.Add("GestationLengthLabourOnset");
        dataTable.Columns.Add("LabourDeliveryOnsetMethod");
        dataTable.Columns.Add("DeliveryDate");
        dataTable.Columns.Add("GestationLengthAssessmentBaby");
        dataTable.Columns.Add("LocalPatientIdentifierMother");
        dataTable.Columns.Add("OrganisationCodeLocalPatientIdentifierMother");
        dataTable.Columns.Add("OrganisationCodeTypeMother");
        dataTable.Columns.Add("NHSNumberMother");
        dataTable.Columns.Add("NHSNumberStatusIndicatorMother");
        dataTable.Columns.Add("BirthDateMother");
        dataTable.Columns.Add("AddressFormatCodeMother");
        dataTable.Columns.Add("PatientUsualAddressMother");
        dataTable.Columns.Add("PostcodeOfUsualAddressMother");
        dataTable.Columns.Add("OrganisationCodePCTofResidenceMother");
        dataTable.Columns.Add("OrganisationCodeTypePCTofResidenceMother");
        dataTable.Columns.Add("UniqueBookingReferenceNumberConverted");
        dataTable.Columns.Add("PatientPathwayIdentifier");
        dataTable.Columns.Add("OrganisationCodePatientPathwayIdentifierIssuer");
        dataTable.Columns.Add("ReferralToTreatmentPeriodStatus");
        dataTable.Columns.Add("ReferralToTreatmentPeriodStartDate");
        dataTable.Columns.Add("ReferralToTreatmentPeriodEndDate");
        dataTable.Columns.Add("LeadCareActivityIndicator");
        dataTable.Columns.Add("AgeatCDSActivityDate");
        dataTable.Columns.Add("NHSServiceAgreementChangeDate");
        dataTable.Columns.Add("CDSActivityDate");
        dataTable.Columns.Add("AgeAsOnAdmission");
        dataTable.Columns.Add("AdminCategoryAtStart");
        dataTable.Columns.Add("HospitalProviderSpellDischargeReadyDate");
        dataTable.Columns.Add("LocationType");
        dataTable.Columns.Add("XMLVersion");
        dataTable.Columns.Add("ConfidentialityCategoryDerived");
        dataTable.Columns.Add("ReferralToTreatmentLengthDerived");
        dataTable.Columns.Add("AgeRangePatientdDerivedFromDOB");
        dataTable.Columns.Add("AgeRangeMotherDerivedFromDOB");
        dataTable.Columns.Add("AreaCodeDerivedFromPostcode");
        dataTable.Columns.Add("CDSGroup");
        dataTable.Columns.Add("FinishedIndicator");
        dataTable.Columns.Add("PCTDerivedfromGP");
        dataTable.Columns.Add("PCTTypeDerivedfromGP");
        dataTable.Columns.Add("GPPracticeDerived");
        dataTable.Columns.Add("GPPracticeMotherDerived");
        dataTable.Columns.Add("PCTDerivedfromderivedGPPractice");
        dataTable.Columns.Add("PCTMotherDerivedfromderivedGPPractice");
        dataTable.Columns.Add("SHAfromGPPractice");
        dataTable.Columns.Add("SHATypefromGPPractice");
        dataTable.Columns.Add("HospitalSpellDuration");
        dataTable.Columns.Add("MonthOfBirth");
        dataTable.Columns.Add("HomeBirthOrDelivery");
        dataTable.Columns.Add("ElectoralWardFromPostcode");
        dataTable.Columns.Add("PCTFromPostcode");
        dataTable.Columns.Add("PCTTypefromPostcode");
        dataTable.Columns.Add("SHAfromPostcode");
        dataTable.Columns.Add("SHATypefromPostcode");
        dataTable.Columns.Add("AreacodeFromProviderPostcode");
        dataTable.Columns.Add("AgeAtEndOfEpisode");
        dataTable.Columns.Add("AgeAtStartOfEpisode");
        dataTable.Columns.Add("YearOfBirth");
        dataTable.Columns.Add("YearOfBirthMother");
        dataTable.Columns.Add("MonthOfBirthMother");
        dataTable.Columns.Add("CensusArea");
        dataTable.Columns.Add("Country");
        dataTable.Columns.Add("CountyCode");
        dataTable.Columns.Add("CensusED");
        dataTable.Columns.Add("EDDistrictCode");
        dataTable.Columns.Add("ElectoralWardCode");
        dataTable.Columns.Add("GORCode");
        dataTable.Columns.Add("LocalUnitaryAuthority");
        dataTable.Columns.Add("OldSHACode");
        dataTable.Columns.Add("ElectoralArea");
        dataTable.Columns.Add("PrimeRecipient");
        dataTable.Columns.Add("CopyRecipients");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.GeneratedRecordIdentifier,
                row.PBRSpellID,
                row.ReasonForAccess,
                row.CDSType,
                row.ProtocolIdentifier,
                row.UniqueCDSIdentifier,
                row.UpdateType,
                row.BulkReplacementCDSGroup,
                row.TestIndicator,
                row.ApplicableDatetime,
                row.CensusDate,
                row.ExtractDatetime,
                row.ReportPeriodStartDate,
                row.ReportPeriodEndDate,
                row.OrganisationCodeSenderOfTransaction,
                row.OrganisationCodeTypeofSender,
                row.SubmissionDate,
                row.CDSInterchangeID,
                row.LocalPatientIdentifier,
                row.OrganisationCodeLocalPatientIdentifier,
                row.OrganisationCodeTypeLocalPatientIdentifier,
                row.NHSNumber,
                row.DateofBirth,
                row.BirthWeight,
                row.LiveOrStillBirth,
                row.CarerSupportIndicator,
                row.LegalStatusClassificationOnAdmissionPsychiatricCensusOnly,
                row.EthnicGroup,
                row.MaritalStatusPsychiatricCensusOnly,
                row.NHSNumberTraceStatus,
                row.WithheldIdentityReason,
                row.Sex,
                row.PregnancyTotalPreviousPregnancies,
                row.NameFormatCode,
                row.PatientName,
                row.PersonTitle,
                row.PersonGivenName,
                row.PersonFamilyName,
                row.PersonNameSuffix,
                row.PersonInitials,
                row.AddressFormatCode,
                row.PatientUsualAddress,
                row.Postcode,
                row.OrganisationCodeResidenceResponsibility,
                row.PCTofResidence,
                row.OrganisationCodeTypePCTofResidence,
                row.OSVClassificationatCDSActivityDate,
                row.HospitalProviderSpellNumber,
                row.AdministrativeCategory,
                row.PatientClassification,
                row.AdmissionMethodHospitalProviderSpell,
                row.DischargeDestinationHospitalProviderSpell,
                row.DischargeMethodHospitalProviderSpell,
                row.SourceOfAdmissionHospitalProviderSpell,
                row.StartDateHospitalProviderSpell,
                row.StartTimeHospitalProviderSpell,
                row.DischargeDateFromHospitalProviderSpell,
                row.DischargeTimeHospitalProviderSpell,
                row.DischargeToHospitalAtHomeServiceIndicator,
                row.EpisodeNumber,
                row.FirstRegularDayNightAdmission,
                row.LastEpisodeInSpellIndicator,
                row.NeonatalLevelOfCare,
                row.OperationStatus,
                row.PsychiatricPatientStatus,
                row.StartDateConsultantEpisode,
                row.StartTimeEpisode,
                row.EndDateConsultantEpisode,
                row.EndTimeEpisode,
                row.LengthOfStayAdjustmentRehabilitation,
                row.LengthOfStayAdjustmentSpecialistPalliativeCare,
                row.CommissioningSerialNumber,
                row.NHSServiceAgreementLineNumber,
                row.ProviderReferenceNumber,
                row.CommissionerReferenceNumber,
                row.OrganisationCodeCodeOfProvider,
                row.OrganisationCodeTypeOfProvider,
                row.OrganisationCodeCodeOfCommissioner,
                row.OrganisationCodeTypeofCommissioner,
                row.ConsultantCode,
                row.MainSpecialtyCode,
                row.TreatmentFunctionCode,
                row.LocalSubSpecialtyCode,
                row.MultiProfessionalOrMultidisciplinaryIndCode,
                row.RehabilitationAssessmentTeamType,
                row.DiagnosisSchemeInUseICD,
                row.DiagnosisSchemeInUseRead,
                row.ProcedureSchemeInUseOPCS,
                row.ProcedureSchemeInUseREAD,
                row.WardCodeAtEpisodeStartDate,
                row.WardSecurityLevelAtEpisodeStartDate,
                row.LocationClassAtEpisodeStartDate,
                row.SiteCodeOfTreatmentAtEpisodeStartDate,
                row.OrganisationCodeTypeSiteCodeOfTreatmentAtStartOfEpisode,
                row.IntendedClinicalCareIntensityAtStartOfEpisode,
                row.AgeGroupIntendedAtStartOfEpisode,
                row.SexOfPatientsAtStartOfEpisode,
                row.WardDayPeriodAvailability,
                row.WardNightPeriodAvailability,
                row.WardCodeAtEpisodeEndDate,
                row.WardSecurityLevelAtEpisodeEndDate,
                row.LocationClassAtEpisodeEndDate,
                row.SiteCodeOfTreatmentAtEpisodeEndDate,
                row.OrganisationCodeTypeSiteCodeOfTreatmentAtEpisodeEndDate,
                row.IntendedClinicalCareIntensityAtEpisodeEndDate,
                row.AgeGroupIntendedAtEpisodeEndDate,
                row.SexOfPatientsAtEpisodeEndDate,
                row.WardDayPeriodAvailabilityAtEpisodeEndDate,
                row.WardNightPeriodAvailabilityAtEpisodeEndDate,
                row.GeneralMedicalPractitionerCodeofRegisteredGMP,
                row.PracticeCodeOfRegisteredGP,
                row.OrganisationCodeTypeofRegisteredGP,
                row.ReferrerCode,
                row.ReferringOrganisationCode,
                row.OrganisationCodeTypeofReferrer,
                row.DirectAccessReferralIndicator,
                row.AmbulanceIncidentNumber,
                row.OrganisationCodeConveyingAmbulanceTrust,
                row.DurationofElectiveWait,
                row.IntendedManagement,
                row.DecidedToAdmitDateForThisProvider,
                row.WaitingTimeMeasurementType,
                row.LocationTypeCodeAtStartOfEpisode,
                row.HRGCode,
                row.HRGVersionNumber,
                row.ProcedureSchemeInUse,
                row.DominantGroupingVariableProcedure,
                row.FCEHRG,
                row.EpisodeHRGVersionNumber,
                row.SpellCoreHRG,
                row.SpellHRGVersionNumber,
                row.NumberOfBabies,
                row.FirstAntenatalAssessmentDate,
                row.GMPCodeofGMPResponsibleforAntenatalCare,
                row.CodeofGPPracticeRegisteredGMPAntenatalCare,
                row.OrganisationCodeTypeGPPracticeRegisteredGMPAntenatalCare,
                row.LocationClassOfDeliveryPlaceIntended,
                row.LocationTypeofDeliveryPlaceIntended,
                row.DeliveryPlaceChangeReason,
                row.DeliveryPlaceTypeIntended,
                row.AnaestheticGivenDuringLabourDelivery,
                row.AnaestheticGivenPostDelivery,
                row.GestationLengthLabourOnset,
                row.LabourDeliveryOnsetMethod,
                row.DeliveryDate,
                row.GestationLengthAssessmentBaby,
                row.LocalPatientIdentifierMother,
                row.OrganisationCodeLocalPatientIdentifierMother,
                row.OrganisationCodeTypeMother,
                row.NHSNumberMother,
                row.NHSNumberStatusIndicatorMother,
                row.BirthDateMother,
                row.AddressFormatCodeMother,
                row.PatientUsualAddressMother,
                row.PostcodeOfUsualAddressMother,
                row.OrganisationCodePCTofResidenceMother,
                row.OrganisationCodeTypePCTofResidenceMother,
                row.UniqueBookingReferenceNumberConverted,
                row.PatientPathwayIdentifier,
                row.OrganisationCodePatientPathwayIdentifierIssuer,
                row.ReferralToTreatmentPeriodStatus,
                row.ReferralToTreatmentPeriodStartDate,
                row.ReferralToTreatmentPeriodEndDate,
                row.LeadCareActivityIndicator,
                row.AgeatCDSActivityDate,
                row.NHSServiceAgreementChangeDate,
                row.CDSActivityDate,
                row.AgeAsOnAdmission,
                row.AdminCategoryAtStart,
                row.HospitalProviderSpellDischargeReadyDate,
                row.LocationType,
                row.XMLVersion,
                row.ConfidentialityCategoryDerived,
                row.ReferralToTreatmentLengthDerived,
                row.AgeRangePatientdDerivedFromDOB,
                row.AgeRangeMotherDerivedFromDOB,
                row.AreaCodeDerivedFromPostcode,
                row.CDSGroup,
                row.FinishedIndicator,
                row.PCTDerivedfromGP,
                row.PCTTypeDerivedfromGP,
                row.GPPracticeDerived,
                row.GPPracticeMotherDerived,
                row.PCTDerivedfromderivedGPPractice,
                row.PCTMotherDerivedfromderivedGPPractice,
                row.SHAfromGPPractice,
                row.SHATypefromGPPractice,
                row.HospitalSpellDuration,
                row.MonthOfBirth,
                row.HomeBirthOrDelivery,
                row.ElectoralWardFromPostcode,
                row.PCTFromPostcode,
                row.PCTTypefromPostcode,
                row.SHAfromPostcode,
                row.SHATypefromPostcode,
                row.AreacodeFromProviderPostcode,
                row.AgeAtEndOfEpisode,
                row.AgeAtStartOfEpisode,
                row.YearOfBirth,
                row.YearOfBirthMother,
                row.MonthOfBirthMother,
                row.CensusArea,
                row.Country,
                row.CountyCode,
                row.CensusED,
                row.EDDistrictCode,
                row.ElectoralWardCode,
                row.GORCode,
                row.LocalUnitaryAuthority,
                row.OldSHACode,
                row.ElectoralArea,
                row.PrimeRecipient,
                row.CopyRecipients
            );
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_APC_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_APC_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertOverseasVisitor(IReadOnlyCollection<OverseasVisitor> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("OverseasVisitorStatusClassification");
        dataTable.Columns.Add("OverseasVisitorStatusStartDate");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.OverseasVisitorStatusClassification,
                row.OverseasVisitorStatusStartDate);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_OverseasVisitor_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_OverseasVisitor_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertIcdDiagnosis(IReadOnlyCollection<IcdDiagnosis> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("DiagnosisICD");
        dataTable.Columns.Add("PresentOnAdmissionIndicatorDiagnosis");
        dataTable.Columns.Add("IsPrimaryDiagnosis");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.DiagnosisICD,
                row.PresentOnAdmissionIndicatorDiagnosis,
                row.IsPrimaryDiagnosis);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_ICDDiagnosis_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_ICDDiagnosis_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertReadDiagnosis(IReadOnlyCollection<ReadDiagnosis> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("DiagnosisRead");
        dataTable.Columns.Add("IsPrimaryDiagnosis");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.DiagnosisRead,
                row.IsPrimaryDiagnosis);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_ReadDiagnosis_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_ReadDiagnosis_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertCareLocation(IReadOnlyCollection<APCCareLocation> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("WardCode");
        dataTable.Columns.Add("WardSecurityLevel");
        dataTable.Columns.Add("LocationClass");
        dataTable.Columns.Add("SiteCodeOfTreatment");
        dataTable.Columns.Add("OrganisationCodeTypeSiteCodeOfTreatment");
        dataTable.Columns.Add("IntendedClinicalCareIntensity");
        dataTable.Columns.Add("AgeGroupIntended");
        dataTable.Columns.Add("SexOfPatients");
        dataTable.Columns.Add("WardDayPeriodAvailability");
        dataTable.Columns.Add("WardNightPeriodAvailability");
        dataTable.Columns.Add("StartDate");
        dataTable.Columns.Add("StartTimeWardStay");
        dataTable.Columns.Add("EndDate");
        dataTable.Columns.Add("EndTimeWardStay");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.WardCode,
                row.WardSecurityLevel,
                row.LocationClass,
                row.SiteCodeOfTreatment,
                row.OrganisationCodeTypeSiteCodeOfTreatment,
                row.IntendedClinicalCareIntensity,
                row.AgeGroupIntended,
                row.SexOfPatients,
                row.WardDayPeriodAvailability,
                row.WardNightPeriodAvailability,
                row.StartDate,
                row.StartTimeWardStay,
                row.EndDate,
                row.EndTimeWardStay);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_CareLocation_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_CareLocation_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertOpcsProcedure(IReadOnlyCollection<SusAPCOpcsProcedure> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("ProcedureOPCS");
        dataTable.Columns.Add("ProcedureDateOPCS");
        dataTable.Columns.Add("MainOperatingHealthcareProfessionalCodeOpcs");
        dataTable.Columns.Add("ProfessionalRegistrationIssuerCodeOpcs");
        dataTable.Columns.Add("ResponsibleAnaesthetistCodeOpcs");
        dataTable.Columns.Add("ResponsibleAnaesthetistRegBodyOpcs");
        dataTable.Columns.Add("IsPrimaryProcedure");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.ProcedureOPCS,
                row.ProcedureDateOPCS,
                row.MainOperatingHealthcareProfessionalCodeOpcs,
                row.ProfessionalRegistrationIssuerCodeOpcs,
                row.ResponsibleAnaesthetistCodeOpcs,
                row.ResponsibleAnaesthetistRegBodyOpcs,
                row.IsPrimaryProcedure);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_OPCSProcedure_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_OPCSProcedure_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertReadProcedure(IReadOnlyCollection<APCReadProcedure> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("ProcedureRead");
        dataTable.Columns.Add("ProcedureDateRead");
        dataTable.Columns.Add("IsPrimaryProcedure");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.ProcedureRead,
                row.ProcedureDateRead,
                row.IsPrimaryProcedure);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_ReadProcedure_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_ReadProcedure_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertBirth(IReadOnlyCollection<APCBirth> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("BirthOrderBaby");
        dataTable.Columns.Add("DeliveryMethodBaby");
        dataTable.Columns.Add("GestationLengthAssessmentBaby");
        dataTable.Columns.Add("ResuscitationMethodBaby");
        dataTable.Columns.Add("StatusOfPersonConductingDeliveryBaby");
        dataTable.Columns.Add("LocalPatientIdentifierBaby");
        dataTable.Columns.Add("OrganisationCodeLocalPatientIDBaby");
        dataTable.Columns.Add("OrganisationCodeTypeLocalPatientIDBaby");
        dataTable.Columns.Add("NHSNumberBaby");
        dataTable.Columns.Add("NHSNumberStatusIndicatorBaby");
        dataTable.Columns.Add("BirthDateBabyBaby");
        dataTable.Columns.Add("BirthWeightBaby");
        dataTable.Columns.Add("LiveOrStillBirthBaby");
        dataTable.Columns.Add("SexBaby");
        dataTable.Columns.Add("BirthLocationType");
        dataTable.Columns.Add("LocationClassDeliveryPlaceActual");
        dataTable.Columns.Add("DeliveryPlaceTypeActual");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.BirthOrderBaby,
                row.DeliveryMethodBaby,
                row.GestationLengthAssessmentBaby,
                row.ResuscitationMethodBaby,
                row.StatusOfPersonConductingDeliveryBaby,
                row.LocalPatientIdentifierBaby,
                row.OrganisationCodeLocalPatientIDBaby,
                row.OrganisationCodeTypeLocalPatientIDBaby,
                row.NHSNumberBaby,
                row.NHSNumberStatusIndicatorBaby,
                row.BirthDateBabyBaby,
                row.BirthWeightBaby,
                row.LiveOrStillBirthBaby,
                row.SexBaby,
                row.BirthLocationType,
                row.LocationClassDeliveryPlaceActual,
                row.DeliveryPlaceTypeActual);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_Birth_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_Birth_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertCriticalCare(IReadOnlyCollection<APCCriticalCare> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("CriticalCareLocalIdentifier");
        dataTable.Columns.Add("CriticalCareStartDate");
        dataTable.Columns.Add("CriticalCareUnitFunction");
        dataTable.Columns.Add("AdvancedRespiratorySupportDays");
        dataTable.Columns.Add("BasicRespiratorySupportDays");
        dataTable.Columns.Add("AdvancedCardiovascularSupportDays");
        dataTable.Columns.Add("BasicCardiovascularSupportDays");
        dataTable.Columns.Add("RenalSupportDays");
        dataTable.Columns.Add("NeurologicalSupportDays");
        dataTable.Columns.Add("DermatologicalSupportDays");
        dataTable.Columns.Add("LiverSupportDays");
        dataTable.Columns.Add("CriticalCareLevel2Days");
        dataTable.Columns.Add("CriticalCareLevel3Days");
        dataTable.Columns.Add("CriticalCareDischargeDate");
        dataTable.Columns.Add("CriticalCareUnitBedConfiguration");
        dataTable.Columns.Add("CriticalCareAdmissionSource");
        dataTable.Columns.Add("CriticalCareSourceLocation");
        dataTable.Columns.Add("CriticalCareAdmissionType");
        dataTable.Columns.Add("GastroIntestinalSupportDays");
        dataTable.Columns.Add("OrganSupportMaximum");
        dataTable.Columns.Add("CriticalCareDischargeReadyDate");
        dataTable.Columns.Add("CriticalCareDischargeReadyTime");
        dataTable.Columns.Add("CriticalCareDischargeStatus");
        dataTable.Columns.Add("CriticalCareDischargeDestination");
        dataTable.Columns.Add("CriticalCareDischargeLocation");
        dataTable.Columns.Add("CriticalCareDischargeTime");
        dataTable.Columns.Add("CriticalCareActivityToEpisodeRelationshipDerived");
        dataTable.Columns.Add("CriticalCarePeriodSequenceNumber");
        dataTable.Columns.Add("CriticalCareStartTime");
        dataTable.Columns.Add("CriticalCarePeriodType");


        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.CriticalCareLocalIdentifier,
                row.CriticalCareStartDate,
                row.CriticalCareUnitFunction,
                row.AdvancedRespiratorySupportDays,
                row.BasicRespiratorySupportDays,
                row.AdvancedCardiovascularSupportDays,
                row.BasicCardiovascularSupportDays,
                row.RenalSupportDays,
                row.NeurologicalSupportDays,
                row.DermatologicalSupportDays,
                row.LiverSupportDays,
                row.CriticalCareLevel2Days,
                row.CriticalCareLevel3Days,
                row.CriticalCareDischargeDate,
                row.CriticalCareUnitBedConfiguration,
                row.CriticalCareAdmissionSource,
                row.CriticalCareSourceLocation,
                row.CriticalCareAdmissionType,
                row.GastroIntestinalSupportDays,
                row.OrganSupportMaximum,
                row.CriticalCareDischargeReadyDate,
                row.CriticalCareDischargeReadyTime,
                row.CriticalCareDischargeStatus,
                row.CriticalCareDischargeDestination,
                row.CriticalCareDischargeLocation,
                row.CriticalCareDischargeTime,
                row.CriticalCareActivityToEpisodeRelationshipDerived,
                row.CriticalCarePeriodSequenceNumber,
                row.CriticalCareStartTime,
                row.CriticalCarePeriodType);

        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_CriticalCare_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_CriticalCare_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }
}