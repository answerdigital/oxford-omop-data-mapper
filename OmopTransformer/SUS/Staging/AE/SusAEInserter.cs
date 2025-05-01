using System.Data;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Data.SqlClient;

namespace OmopTransformer.SUS.Staging.AE;

internal class SusAEInserter : ISusAEInserter
{
    private readonly Configuration _configuration;
    private readonly ILogger<SusAEInserter> _logger;
    private readonly DataOptOut _dataOptOut;

    public SusAEInserter(IOptions<Configuration> configuration, ILogger<SusAEInserter> logger, DataOptOut dataOptOut)
    {
        _logger = logger;
        _dataOptOut = dataOptOut;
        _configuration = configuration.Value;
    }

    public async Task Insert(IEnumerable<AERecord> rows, CancellationToken cancellationToken)
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

    private async Task InsertBatch(IEnumerable<AERecord> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var rowsList = rows.ToList();

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting AERow.");
        await InsertAE(rowsList.Select(row => row.AERow).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting AERow Diagnosis.");
        await InsertDiagnosis(rowsList.SelectMany(row => row.SusAEDiagnosis).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting AERow Investigation.");
        await InsertInvestigation(rowsList.SelectMany(row => row.SusAEInvestigation).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting AERow Treatment.");
        await InsertTreatment(rowsList.SelectMany(row => row.SusAETreatment).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _dataOptOut.PrintStats();
    }

    private async Task InsertAE(IReadOnlyCollection<AERow> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("GeneratedRecordIdentifier");
        dataTable.Columns.Add("ReasonForAccess");
        dataTable.Columns.Add("CDStype");
        dataTable.Columns.Add("ProtocolIdentifier");
        dataTable.Columns.Add("UniqueCDSidentifier");
        dataTable.Columns.Add("UpdateType");
        dataTable.Columns.Add("BulkreplacementCDSgroup");
        dataTable.Columns.Add("TestIndicator");
        dataTable.Columns.Add("ApplicableDatetime");
        dataTable.Columns.Add("CensusDate");
        dataTable.Columns.Add("ExtractDatetime");
        dataTable.Columns.Add("ReportPeriodStartDate");
        dataTable.Columns.Add("ReportPeriodEndDate");
        dataTable.Columns.Add("OrganisationCodeSenderOfTransaction");
        dataTable.Columns.Add("OrganisationCodeTypeofSender");
        dataTable.Columns.Add("CDSInterchangeID");
        dataTable.Columns.Add("LocalPatientIdentifier");
        dataTable.Columns.Add("OrganisationCodeLocalPatientIdentifier");
        dataTable.Columns.Add("OrganisationCodeTypeLocalPatientIdentifier");
        dataTable.Columns.Add("NHSNumber");
        dataTable.Columns.Add("DateOfBirth");
        dataTable.Columns.Add("CarerSupportIndicator");
        dataTable.Columns.Add("NHSNumberTraceStatus");
        dataTable.Columns.Add("WithheldIdentityReason");
        dataTable.Columns.Add("Sex");
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
        dataTable.Columns.Add("EthnicCategory");
        dataTable.Columns.Add("OSVClassificationatCDSActivityDate");
        dataTable.Columns.Add("GeneralMedicalPractitionerCodeofRegisteredGMP");
        dataTable.Columns.Add("PracticeCodeofRegisteredGP");
        dataTable.Columns.Add("OrganisationCodeTypeofRegisteredGP");
        dataTable.Columns.Add("AEAttendanceNumber");
        dataTable.Columns.Add("AEArrivalMode");
        dataTable.Columns.Add("AEAttendanceCategory");
        dataTable.Columns.Add("AEAttendanceDisposal");
        dataTable.Columns.Add("AEIncidentLocationType");
        dataTable.Columns.Add("AEPatientGroup");
        dataTable.Columns.Add("SourceofReferralForAE");
        dataTable.Columns.Add("ArrivalDate");
        dataTable.Columns.Add("ArrivalTime");
        dataTable.Columns.Add("AEAttendanceConclusionTime");
        dataTable.Columns.Add("AEAttendanceConclusionDate");
        dataTable.Columns.Add("AEDepartureTime");
        dataTable.Columns.Add("AEDepartureDate");
        dataTable.Columns.Add("AEInitialAssessmentTimefirstandunplannedfollowupattendancesonly");
        dataTable.Columns.Add("AEInitialAssessmentDate");
        dataTable.Columns.Add("AETimeSeenForTreatment");
        dataTable.Columns.Add("SiteCodeOfTreatment");
        dataTable.Columns.Add("WaitingTimeMeasurementType");
        dataTable.Columns.Add("AmbulanceIncidentNumber");
        dataTable.Columns.Add("OrganisationCodeConveyingAmbulanceTrust");
        dataTable.Columns.Add("CommissioningSerialNumber");
        dataTable.Columns.Add("NHSServiceAgreementLineNumber");
        dataTable.Columns.Add("ProviderReferenceNumber");
        dataTable.Columns.Add("CommissionerReferenceNumber");
        dataTable.Columns.Add("OrganisationCodeCodeOfProvider");
        dataTable.Columns.Add("OrganisationCodeTypeOfProvider");
        dataTable.Columns.Add("OrganisationCodeCodeOfCommissioner");
        dataTable.Columns.Add("OrganisationCodeTypeOfCommissioner");
        dataTable.Columns.Add("AEStaffMemberCode");
        dataTable.Columns.Add("DiagnosisSchemeInUse");
        dataTable.Columns.Add("InvestigationSchemeInUse");
        dataTable.Columns.Add("TreatmentSchemeInUse");
        dataTable.Columns.Add("HRGCode");
        dataTable.Columns.Add("HRGVersionNumber");
        dataTable.Columns.Add("ProcedureSchemeInUse");
        dataTable.Columns.Add("DominantGroupingVariableProcedure");
        dataTable.Columns.Add("FCEHRG");
        dataTable.Columns.Add("SpellCOREHRGVersionNo");
        dataTable.Columns.Add("PBRGeneratedCoreHRGforInformation");
        dataTable.Columns.Add("PBRGeneratedCoreHRGVersionforInformation");
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
        dataTable.Columns.Add("AEDepartmentType");
        dataTable.Columns.Add("XMLVersion");
        dataTable.Columns.Add("ConfidentialityCategoryDerived");
        dataTable.Columns.Add("ReferralToTreatmentLengthDerived");
        dataTable.Columns.Add("AEAssessmentWaitTime");
        dataTable.Columns.Add("AEConclusionWaitTime");
        dataTable.Columns.Add("AEDuration");
        dataTable.Columns.Add("AETreatmentWait");
        dataTable.Columns.Add("AgerangepatientderivedfromDOB");
        dataTable.Columns.Add("AreaCodeDerivedFromPostcode");
        dataTable.Columns.Add("CDSGroup");
        dataTable.Columns.Add("FinishedIndicator");
        dataTable.Columns.Add("PCTDerivedfromGP");
        dataTable.Columns.Add("PCTTypeDerivedfromGP");
        dataTable.Columns.Add("GPPracticeDerived");
        dataTable.Columns.Add("PCTDerivedfromderivedGPPractice");
        dataTable.Columns.Add("SHAfromGPPractice");
        dataTable.Columns.Add("SHATypefromGPPractice");
        dataTable.Columns.Add("MonthOfBirth");
        dataTable.Columns.Add("ElectoralWardFromPostcode");
        dataTable.Columns.Add("PCTfrompostcode");
        dataTable.Columns.Add("PCTTypefromPostcode");
        dataTable.Columns.Add("SHAfromPostcode");
        dataTable.Columns.Add("SHATypefromPostcode");
        dataTable.Columns.Add("AreaCodeFromProviderPostcode");
        dataTable.Columns.Add("AgeAtEndOfEpisode");
        dataTable.Columns.Add("AgeAtStartOfEpisode");
        dataTable.Columns.Add("YearOfBirth");
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
            if (_dataOptOut.PatientAllowed(row.NHSNumber) == false)
                continue;

            dataTable.Rows.Add(
                row.MessageId,
                row.GeneratedRecordIdentifier,
                row.ReasonForAccess,
                row.CDStype,
                row.ProtocolIdentifier,
                row.UniqueCDSidentifier,
                row.UpdateType,
                row.BulkreplacementCDSgroup,
                row.TestIndicator,
                row.ApplicableDatetime,
                row.CensusDate,
                row.ExtractDatetime,
                row.ReportPeriodStartDate,
                row.ReportPeriodEndDate,
                row.OrganisationCodeSenderOfTransaction,
                row.OrganisationCodeTypeofSender,
                row.CDSInterchangeID,
                row.LocalPatientIdentifier,
                row.OrganisationCodeLocalPatientIdentifier,
                row.OrganisationCodeTypeLocalPatientIdentifier,
                row.NHSNumber,
                row.DateOfBirth,
                row.CarerSupportIndicator,
                row.NHSNumberTraceStatus,
                row.WithheldIdentityReason,
                row.Sex,
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
                row.EthnicCategory,
                row.OSVClassificationatCDSActivityDate,
                row.GeneralMedicalPractitionerCodeofRegisteredGMP,
                row.PracticeCodeofRegisteredGP,
                row.OrganisationCodeTypeofRegisteredGP,
                row.AEAttendanceNumber,
                row.AEArrivalMode,
                row.AEAttendanceCategory,
                row.AEAttendanceDisposal,
                row.AEIncidentLocationType,
                row.AEPatientGroup,
                row.SourceofReferralForAE,
                row.ArrivalDate,
                row.ArrivalTime,
                row.AEAttendanceConclusionTime,
                row.AEAttendanceConclusionDate,
                row.AEDepartureTime,
                row.AEDepartureDate,
                row.AEInitialAssessmentTimefirstandunplannedfollowupattendancesonly,
                row.AEInitialAssessmentDate,
                row.AETimeSeenForTreatment,
                row.SiteCodeOfTreatment,
                row.WaitingTimeMeasurementType,
                row.AmbulanceIncidentNumber,
                row.OrganisationCodeConveyingAmbulanceTrust,
                row.CommissioningSerialNumber,
                row.NHSServiceAgreementLineNumber,
                row.ProviderReferenceNumber,
                row.CommissionerReferenceNumber,
                row.OrganisationCodeCodeOfProvider,
                row.OrganisationCodeTypeOfProvider,
                row.OrganisationCodeCodeOfCommissioner,
                row.OrganisationCodeTypeOfCommissioner,
                row.AEStaffMemberCode,
                row.DiagnosisSchemeInUse,
                row.InvestigationSchemeInUse,
                row.TreatmentSchemeInUse,
                row.HRGCode,
                row.HRGVersionNumber,
                row.ProcedureSchemeInUse,
                row.DominantGroupingVariableProcedure,
                row.FCEHRG,
                row.SpellCOREHRGVersionNo,
                row.PBRGeneratedCoreHRGforInformation,
                row.PBRGeneratedCoreHRGVersionforInformation,
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
                row.AEDepartmentType,
                row.XMLVersion,
                row.ConfidentialityCategoryDerived,
                row.ReferralToTreatmentLengthDerived,
                row.AEAssessmentWaitTime,
                row.AEConclusionWaitTime,
                row.AEDuration,
                row.AETreatmentWait,
                row.AgerangepatientderivedfromDOB,
                row.AreaCodeDerivedFromPostcode,
                row.CDSGroup,
                row.FinishedIndicator,
                row.PCTDerivedfromGP,
                row.PCTTypeDerivedfromGP,
                row.GPPracticeDerived,
                row.PCTDerivedfromderivedGPPractice,
                row.SHAfromGPPractice,
                row.SHATypefromGPPractice,
                row.MonthOfBirth,
                row.ElectoralWardFromPostcode,
                row.PCTfrompostcode,
                row.PCTTypefromPostcode,
                row.SHAfromPostcode,
                row.SHATypefromPostcode,
                row.AreaCodeFromProviderPostcode,
                row.AgeAtEndOfEpisode,
                row.AgeAtStartOfEpisode,
                row.YearOfBirth,
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
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_AE_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_AE_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertDiagnosis(IReadOnlyCollection<SusAEDiagnosis> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("AccidentAndEmergencyDiagnosis");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.AccidentAndEmergencyDiagnosis);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_AE_diagnosis_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_AE_diagnosis_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertInvestigation(IReadOnlyCollection<SusAEInvestigation> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("AccidentAndEmergencyInvestigation");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.AccidentAndEmergencyInvestigation);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_AE_investigation_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_AE_investigation_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertTreatment(IReadOnlyCollection<SusAETreatment> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("AccidentAndEmergencyTreatment");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.AccidentAndEmergencyTreatment);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_AE_treatment_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_AE_treatment_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }
}