using System.Data;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Data.SqlClient;

namespace OmopTransformer.SUS.Staging.OP;

internal class SusOPInserter : ISusOPInserter
{
    private readonly Configuration _configuration;
    private readonly ILogger<SusOPInserter> _logger;

    public SusOPInserter(IOptions<Configuration> configuration, ILogger<SusOPInserter> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task Insert(IEnumerable<OPRecord> rows, CancellationToken cancellationToken)
    {
        if (rows == null) throw new ArgumentNullException(nameof(rows));

        _logger.LogInformation("Recording SUS rows.");

        var batches = rows.Batch(50000);
        int batchNumber = 1;

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        foreach (var batch in batches)
        {
            _logger.LogInformation("Batch {0}.", batchNumber++);

            await InsertBatch(batch, connection, cancellationToken);
        }
    }

    private async Task InsertBatch(IEnumerable<OPRecord> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var rowsList = rows.ToList();

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting OPRow.");
        await InsertOP(rowsList.Select(row => row.OPRow).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting OPRow ReadProcedure.");
        await InsertReadProcedure(rowsList.SelectMany(row => row.OPReadProcedures).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting OPRow OpcdProcedure.");
        await InsertOpcsProcedure(rowsList.SelectMany(row => row.OpcdProcedure).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting APCRow ReadDiagnoses.");
        await InsertReadDiagnosis(rowsList.SelectMany(row => row.ReadDiagnoses).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting OPRow IcdDiagnoses.");
        await InsertIcdDiagnosis(rowsList.SelectMany(row => row.IcdDiagnoses).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();
    }

    private async Task InsertOP(IReadOnlyCollection<OPRow> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("GeneratedRecordIdentifier");
        dataTable.Columns.Add("ReasonforAccess");
        dataTable.Columns.Add("CDStype");
        dataTable.Columns.Add("Protocolidentifier");
        dataTable.Columns.Add("UniqueCDSidentifier");
        dataTable.Columns.Add("SUSgeneratedspellID");
        dataTable.Columns.Add("Updatetype");
        dataTable.Columns.Add("BulkreplacementCDSgroup");
        dataTable.Columns.Add("Testindicator");
        dataTable.Columns.Add("Applicabledatetime");
        dataTable.Columns.Add("Censusdate");
        dataTable.Columns.Add("Extractdatetime");
        dataTable.Columns.Add("ReportperiodStartDate");
        dataTable.Columns.Add("ReportperiodEndDate");
        dataTable.Columns.Add("OrganisationcodeSenderoftransaction");
        dataTable.Columns.Add("OrganisationCodeTypeofSender");
        dataTable.Columns.Add("SubmissionDate");
        dataTable.Columns.Add("CDSInterchangeID");
        dataTable.Columns.Add("LocalPatientIdentifier");
        dataTable.Columns.Add("OrganisationCodeLocalPatientIdentifier");
        dataTable.Columns.Add("OrganisationCodeTypeLocalPatientIdentifier");
        dataTable.Columns.Add("NHSNumber");
        dataTable.Columns.Add("DateofBirth");
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
        dataTable.Columns.Add("ConsultantCode");
        dataTable.Columns.Add("MainSpecialtyCode");
        dataTable.Columns.Add("TreatmentFunctionCode");
        dataTable.Columns.Add("LocalSubSpecialtyCode");
        dataTable.Columns.Add("MultiProfessionalOrMultidisciplinaryIndCode");
        dataTable.Columns.Add("RehabilitationAssessmentTeamType");
        dataTable.Columns.Add("DiagnosisSchemeInUseICD");
        dataTable.Columns.Add("DiagnosisSchemeInUseRead");
        dataTable.Columns.Add("AttendanceIdentifier");
        dataTable.Columns.Add("AdministrativeCategory");
        dataTable.Columns.Add("AttendedorDidNotAttend");
        dataTable.Columns.Add("FirstAttendance");
        dataTable.Columns.Add("MedicalStaffTypeSeeingPatient");
        dataTable.Columns.Add("OperationStatusPerAttendance");
        dataTable.Columns.Add("OutcomeofAttendance");
        dataTable.Columns.Add("AppointmentDate");
        dataTable.Columns.Add("AppointmentTime");
        dataTable.Columns.Add("ExpectedDurationOfAppointment");
        dataTable.Columns.Add("ConsultationMediumUsed");
        dataTable.Columns.Add("WaitingTimeMeasurementType");
        dataTable.Columns.Add("ActivityLocationTypeCode");
        dataTable.Columns.Add("EarliestClinicallyAppropriateDate");
        dataTable.Columns.Add("ClinicCode");
        dataTable.Columns.Add("CommissioningSerialNumber");
        dataTable.Columns.Add("NHSServiceAgreementLineNumber");
        dataTable.Columns.Add("ProviderReferenceNumber");
        dataTable.Columns.Add("CommissionerReferenceNumber");
        dataTable.Columns.Add("OrganisationCodeCodeofProvider");
        dataTable.Columns.Add("OrganisationCodeTypeCodeofProvider");
        dataTable.Columns.Add("OrganisationCodeCodeofCommissioner");
        dataTable.Columns.Add("OrganisationCodeTypeCodeofCommissioner");
        dataTable.Columns.Add("ProcedureSchemeInUseOPCS");
        dataTable.Columns.Add("ProcedureSchemeInUseRead");
        dataTable.Columns.Add("LocationClassatAttendance");
        dataTable.Columns.Add("SiteCodeofTreatment");
        dataTable.Columns.Add("OrganisationCodeTypeSiteCodeofTreatmentAtAttendance");
        dataTable.Columns.Add("GeneralMedicalPractitionerCodeofRegisteredGMP");
        dataTable.Columns.Add("PracticeCodeofRegisteredGP");
        dataTable.Columns.Add("OrganisationCodeTypeofRegisteredGP");
        dataTable.Columns.Add("PriorityType");
        dataTable.Columns.Add("ServiceTypeRequested");
        dataTable.Columns.Add("SourceofReferralForOutpatients");
        dataTable.Columns.Add("ReferralRequestReceivedDate");
        dataTable.Columns.Add("DirectAccessReferralIndicator");
        dataTable.Columns.Add("ReferrerCode");
        dataTable.Columns.Add("ReferringOrganisationCode");
        dataTable.Columns.Add("OrganisationCodeTypeofReferrer");
        dataTable.Columns.Add("LastDNAOrPatientCancelledDate");
        dataTable.Columns.Add("HRGCode");
        dataTable.Columns.Add("HRGVersionNumber");
        dataTable.Columns.Add("ProcedureSchemeInUse");
        dataTable.Columns.Add("DominantGroupingVariableProcedure");
        dataTable.Columns.Add("CoreHRG");
        dataTable.Columns.Add("HRGVersionCalculated");
        dataTable.Columns.Add("SUSHRG");
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
        dataTable.Columns.Add("EarliestReasonableOfferedDate");
        dataTable.Columns.Add("LocationType");
        dataTable.Columns.Add("XMLVersion");
        dataTable.Columns.Add("ConfidentialityCategoryDerived");
        dataTable.Columns.Add("ReferralToTreatmentLengthDerived");
        dataTable.Columns.Add("AgerangepatientderivedfromDOB");
        dataTable.Columns.Add("Areacodederivedfrompostcode");
        dataTable.Columns.Add("AttenderTypeDerived");
        dataTable.Columns.Add("CDSGroup");
        dataTable.Columns.Add("FinishedIndicator");
        dataTable.Columns.Add("PCTDerivedfromGP");
        dataTable.Columns.Add("PCTTypeDerivedfromGP");
        dataTable.Columns.Add("GPPracticeDerived");
        dataTable.Columns.Add("PCTDerivedfromderivedGPPractice");
        dataTable.Columns.Add("SHAfromGPPractice");
        dataTable.Columns.Add("SHATypefromGPPractice");
        dataTable.Columns.Add("MonthofBirth");
        dataTable.Columns.Add("ElectoralWardfrompostcode");
        dataTable.Columns.Add("PCTfrompostcode");
        dataTable.Columns.Add("PCTTypefromPostcode");
        dataTable.Columns.Add("SHAfromPostcode");
        dataTable.Columns.Add("SHATypefromPostcode");
        dataTable.Columns.Add("AreacodefromProviderPostcode");
        dataTable.Columns.Add("AgeatEndofEpisode");
        dataTable.Columns.Add("AgeatStartofEpisode");
        dataTable.Columns.Add("YearofBirth");
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
        dataTable.Columns.Add("IsValidUBRN");
        dataTable.Columns.Add("UBRNOccurrenceCount");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                    row.GeneratedRecordIdentifier,
                    row.ReasonforAccess,
                    row.CDStype,
                    row.Protocolidentifier,
                    row.UniqueCDSidentifier,
                    row.SUSgeneratedspellID,
                    row.Updatetype,
                    row.BulkreplacementCDSgroup,
                    row.Testindicator,
                    row.Applicabledatetime,
                    row.Censusdate,
                    row.Extractdatetime,
                    row.ReportperiodStartDate,
                    row.ReportperiodEndDate,
                    row.OrganisationcodeSenderoftransaction,
                    row.OrganisationCodeTypeofSender,
                    row.SubmissionDate,
                    row.CDSInterchangeID,
                    row.LocalPatientIdentifier,
                    row.OrganisationCodeLocalPatientIdentifier,
                    row.OrganisationCodeTypeLocalPatientIdentifier,
                    row.NHSNumber,
                    row.DateofBirth,
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
                    row.ConsultantCode,
                    row.MainSpecialtyCode,
                    row.TreatmentFunctionCode,
                    row.LocalSubSpecialtyCode,
                    row.MultiProfessionalOrMultidisciplinaryIndCode,
                    row.RehabilitationAssessmentTeamType,
                    row.DiagnosisSchemeInUseICD,
                    row.DiagnosisSchemeInUseRead,
                    row.AttendanceIdentifier,
                    row.AdministrativeCategory,
                    row.AttendedorDidNotAttend,
                    row.FirstAttendance,
                    row.MedicalStaffTypeSeeingPatient,
                    row.OperationStatusPerAttendance,
                    row.OutcomeofAttendance,
                    row.AppointmentDate,
                    row.AppointmentTime,
                    row.ExpectedDurationOfAppointment,
                    row.ConsultationMediumUsed,
                    row.WaitingTimeMeasurementType,
                    row.ActivityLocationTypeCode,
                    row.EarliestClinicallyAppropriateDate,
                    row.ClinicCode,
                    row.CommissioningSerialNumber,
                    row.NHSServiceAgreementLineNumber,
                    row.ProviderReferenceNumber,
                    row.CommissionerReferenceNumber,
                    row.OrganisationCodeCodeofProvider,
                    row.OrganisationCodeTypeCodeofProvider,
                    row.OrganisationCodeCodeofCommissioner,
                    row.OrganisationCodeTypeCodeofCommissioner,
                    row.ProcedureSchemeInUseOPCS,
                    row.ProcedureSchemeInUseRead,
                    row.LocationClassatAttendance,
                    row.SiteCodeofTreatment,
                    row.OrganisationCodeTypeSiteCodeofTreatmentAtAttendance,
                    row.GeneralMedicalPractitionerCodeofRegisteredGMP,
                    row.PracticeCodeofRegisteredGP,
                    row.OrganisationCodeTypeofRegisteredGP,
                    row.PriorityType,
                    row.ServiceTypeRequested,
                    row.SourceofReferralForOutpatients,
                    row.ReferralRequestReceivedDate,
                    row.DirectAccessReferralIndicator,
                    row.ReferrerCode,
                    row.ReferringOrganisationCode,
                    row.OrganisationCodeTypeofReferrer,
                    row.LastDNAOrPatientCancelledDate,
                    row.HRGCode,
                    row.HRGVersionNumber,
                    row.ProcedureSchemeInUse,
                    row.DominantGroupingVariableProcedure,
                    row.CoreHRG,
                    row.HRGVersionCalculated,
                    row.SUSHRG,
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
                    row.EarliestReasonableOfferedDate,
                    row.LocationType,
                    row.XMLVersion,
                    row.ConfidentialityCategoryDerived,
                    row.ReferralToTreatmentLengthDerived,
                    row.AgerangepatientderivedfromDOB,
                    row.Areacodederivedfrompostcode,
                    row.AttenderTypeDerived,
                    row.CDSGroup,
                    row.FinishedIndicator,
                    row.PCTDerivedfromGP,
                    row.PCTTypeDerivedfromGP,
                    row.GPPracticeDerived,
                    row.PCTDerivedfromderivedGPPractice,
                    row.SHAfromGPPractice,
                    row.SHATypefromGPPractice,
                    row.MonthofBirth,
                    row.ElectoralWardfrompostcode,
                    row.PCTfrompostcode,
                    row.PCTTypefromPostcode,
                    row.SHAfromPostcode,
                    row.SHATypefromPostcode,
                    row.AreacodefromProviderPostcode,
                    row.AgeatEndofEpisode,
                    row.AgeatStartofEpisode,
                    row.YearofBirth,
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
                    row.CopyRecipients,
                    row.IsValidUBRN,
                    row.UBRNOccurrenceCount
            );
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_OP_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_OP_row",
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
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_OP_ICDDiagnosis_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_OP_ICDDiagnosis_row",
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
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_OP_ReadDiagnosis_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_OP_ReadDiagnosis_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }
    
    private async Task InsertOpcsProcedure(IReadOnlyCollection<OpcsProcedure> rows, IDbConnection connection)
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
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_OP_OPCSProcedure_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_OP_OPCSProcedure_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertReadProcedure(IReadOnlyCollection<OPReadProcedure> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("ProcedureRead");
        dataTable.Columns.Add("IsPrimaryProcedure");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.ProcedureRead,
                row.IsPrimaryProcedure);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_OP_ReadProcedure_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_OP_ReadProcedure_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }
}