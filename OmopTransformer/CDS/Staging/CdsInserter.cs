using System.Data;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OmopTransformer.CDS.Parser;

namespace OmopTransformer.CDS.Staging;

internal class CdsInserter : ICdsInserter
{
    private readonly Configuration _configuration;
    private readonly ILogger<CdsInserter> _logger;

    public CdsInserter(IOptions<Configuration> configuration, ILogger<CdsInserter> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task Insert(IReadOnlyCollection<Message> rows, CancellationToken cancellationToken)
    {
        if (rows == null) throw new ArgumentNullException(nameof(rows));

        _logger.LogInformation("Recording {0} Cds rows.", rows.Count);

        var stopwatch = Stopwatch.StartNew();

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        _logger.LogInformation("Inserting line01.");
        await InsertLine01(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting birth details.");
        await InsertBirthDetails(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting critical care activities.");
        await InsertCriticalCareActivities(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting high cost drugs.");
        await InsertHighCostDrugs(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting overseas visitors.");
        await InsertOverseasVisitors(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting secondary investigations.");
        await InsertSecondaryInvestigations(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting diagnoses.");
        await InsertDiagnoses(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting line02.");
        await InsertLine02(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting line03.");
        await InsertLine03(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting procedures.");
        await InsertProcedures(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting line04.");
        await InsertLine04(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting line05.");
        await InsertLine05(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting line06.");
        await InsertLine06(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting line07.");
        await InsertLine07(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting line08.");
        await InsertLine08(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting line09.");
        await InsertLine09(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting line10.");
        await InsertLine10(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting line11.");
        await InsertLine11(rows, connection, cancellationToken);

        _logger.LogInformation("Inserting line12.");
        await InsertLine12(rows, connection, cancellationToken);
        
        stopwatch.Stop();

        _logger.LogTrace("Inserting rows took {0}ms.", stopwatch.ElapsedMilliseconds);
    }

    private async Task InsertDiagnoses(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var diagnoses =
            rows
            .SelectMany(
                row =>
                    row
                    .Line02
                    .SelectMany(
                        line02 =>
                            line02
                            .SecondaryDiagnoses
                            .Select(overseasVisitor => new { row.MessageId, IsPrimaryDiagnosis = false, Diagnosis = (Diagnosis?)overseasVisitor })
                            .Concat(new[] { new { row.MessageId, IsPrimaryDiagnosis = true, Diagnosis = line02.PrimaryDiagnosis } })))
            .Where(diagnosis => diagnosis.Diagnosis != null);

        var batches = diagnoses.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("DiagnosisCode");
            dataTable.Columns.Add("PresentOnAdmissionIndicator");
            dataTable.Columns.Add("IsPrimaryDiagnosis");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.Diagnosis!.DiagnosisCode,
                    row.Diagnosis.PresentOnAdmissionIndicator,
                    row.IsPrimaryDiagnosis);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("omop_staging.cds_diagnosis_row")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_diagnosis",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertOverseasVisitors(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var overseasVisitors =
            rows
            .SelectMany(
                row =>
                    row
                    .Line05
                    .SelectMany(
                        line05 =>
                            line05
                            .OverseasVisitors
                            .Select(overseasVisitor => new { row.MessageId, OverseasVisitors = overseasVisitor })));

        var batches = overseasVisitors.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("OverseasVisitorsClassification");
            dataTable.Columns.Add("OverseasVisitorsStatusStartDate");
            dataTable.Columns.Add("OverseasVisitorsStatusEndDate");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.OverseasVisitors.OverseasVisitorsClassification,
                    row.OverseasVisitors.OverseasVisitorsStatusStartDate,
                    row.OverseasVisitors.OverseasVisitorsStatusEndDate);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("omop_staging.cds_high_cost_drugs_row")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_high_cost_drugs",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertSecondaryInvestigations(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var secondaryInvestigations =
            rows
            .SelectMany(
                row =>
                    row
                    .Line12
                    .SelectMany(
                        line12 =>
                            line12
                            .SecondaryInvestigations
                            .Select(code => new { row.MessageId, code })));

        var batches = secondaryInvestigations.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("Code");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.code);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("omop_staging.cds_secondary_investigations_row")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_secondary_investigations",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertHighCostDrugs(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var highCostDrugs =
            rows
            .SelectMany(
                row =>
                    row
                    .Line07
                    .SelectMany(
                        line07 =>
                            line07
                            .HighCostDrugsOPCSCodes
                            .Select(code => new { row.MessageId, code })));

        var batches = highCostDrugs.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("Code");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.code);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("omop_staging.cds_high_cost_drugs_row")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_high_cost_drugs",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertCriticalCareActivities(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var careActivities =
            rows
            .SelectMany(
                row =>
                    row
                    .Line07
                    .SelectMany(
                        line07 =>
                            line07
                            .CriticalCareActivityCodes
                            .Select(code => new { row.MessageId, code })));

        var batches = careActivities.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("Code");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.code);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("omop_staging.cds_critial_care_activity_codes_row")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_critial_care_activity_codes",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertBirthDetails(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var birthDetails = 
            rows
            .SelectMany(
                row => 
                    row
                    .Line08
                    .SelectMany(
                        line08 => 
                            line08
                            .BirthDetails
                            .Select(birthDetail => new { row.MessageId, birthDetail })));

        var batches = birthDetails.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("BirthOrder");
            dataTable.Columns.Add("DeliveryMethod");
            dataTable.Columns.Add("GestationLengthAssessment");
            dataTable.Columns.Add("ResuscitationMethod");
            dataTable.Columns.Add("StatusofPersonConductingDelivery");
            dataTable.Columns.Add("LocationClass");
            dataTable.Columns.Add("DeliveryPlaceTypeActual");
            dataTable.Columns.Add("ActivityLocationType");
            dataTable.Columns.Add("LocalPatientID");
            dataTable.Columns.Add("OrganisationCodeLocalPatientID");
            dataTable.Columns.Add("NHSNumber");
            dataTable.Columns.Add("NHSNumberStatusIndicator");
            dataTable.Columns.Add("WithheldFlag");
            dataTable.Columns.Add("WithheldIdentityReason");
            dataTable.Columns.Add("BabyBirthDate");
            dataTable.Columns.Add("BirthWeight");
            dataTable.Columns.Add("LiveStillBirth");
            dataTable.Columns.Add("PersonGenderCurrent");
            dataTable.Columns.Add("OverseasVisitorStatusClassificationAtCDSActivityDate");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.birthDetail.BirthOrder,
                    row.birthDetail.DeliveryMethod,
                    row.birthDetail.GestationLengthAssessment,
                    row.birthDetail.ResuscitationMethod,
                    row.birthDetail.StatusofPersonConductingDelivery,
                    row.birthDetail.LocationClass,
                    row.birthDetail.DeliveryPlaceTypeActual,
                    row.birthDetail.ActivityLocationType,
                    row.birthDetail.LocalPatientID,
                    row.birthDetail.OrganisationCodeLocalPatientID,
                    row.birthDetail.NHSNumber,
                    row.birthDetail.NHSNumberStatusIndicator,
                    row.birthDetail.WithheldFlag,
                    row.birthDetail.WithheldIdentityReason,
                    row.birthDetail.BabyBirthDate,
                    row.birthDetail.BirthWeight,
                    row.birthDetail.LiveStillBirth,
                    row.birthDetail.PersonGenderCurrent,
                    row.birthDetail.OverseasVisitorStatusClassificationAtCDSActivityDate);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("omop_staging.cds_birth_details_row")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_birth_details",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertProcedures(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var line03s =
            rows
            .SelectMany(
                row =>
                    row
                    .Line03
                    .Select(line03 => new { row.MessageId, line03 }));

        var batches = line03s.Batch(_configuration.BatchSize!.Value);
        
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("IsPrimaryProcedure");
            dataTable.Columns.Add("PrimaryProcedure");
            dataTable.Columns.Add("PrimaryProcedureDate");
            dataTable.Columns.Add("MainOperatingHealthcareProfessionalRegistrationIssuerCode");
            dataTable.Columns.Add("MainOperatingHealthcareProfessionalRegistrationEntryIdentifier");
            dataTable.Columns.Add("ResponsibleAnaesthetistProfessionalRegistrationIssuerCode");
            dataTable.Columns.Add("ResponsibleAnaesthetistProfessionalRegistrationEntryIdentifier");

            foreach (var message in batch)
            {
                if (message.line03.PrimaryProcedure != null)
                {
                    dataTable.Rows.Add(
                        message.MessageId,
                        true,
                        message.line03.PrimaryProcedure.PrimaryProcedure,
                        message.line03.PrimaryProcedure.PrimaryProcedureDate,
                        message.line03.PrimaryProcedure.MainOperatingHealthcareProfessionalRegistrationIssuerCode,
                        message.line03.PrimaryProcedure.MainOperatingHealthcareProfessionalRegistrationEntryIdentifier,
                        message.line03.PrimaryProcedure.ResponsibleAnaesthetistProfessionalRegistrationIssuerCode,
                        message.line03.PrimaryProcedure.ResponsibleAnaesthetistProfessionalRegistrationEntryIdentifier);
                }

                if (message.line03.SecondaryProcedures != null)
                {
                    foreach (var procedure in message.line03.SecondaryProcedures)
                    {
                        dataTable.Rows.Add(
                            message.MessageId,
                            false,
                            procedure.PrimaryProcedure,
                            procedure.PrimaryProcedureDate,
                            procedure.MainOperatingHealthcareProfessionalRegistrationIssuerCode,
                            procedure.MainOperatingHealthcareProfessionalRegistrationEntryIdentifier,
                            procedure.ResponsibleAnaesthetistProfessionalRegistrationIssuerCode,
                            procedure.ResponsibleAnaesthetistProfessionalRegistrationEntryIdentifier);
                    }
                }
            }

            var parameter = new
                {
                    Rows = dataTable.AsTableValuedParameter("omop_staging.cds_procedure_row")
                };

                await connection
                    .ExecuteLongTimeoutAsync(
                        "omop_staging.insert_cds_procedure",
                        parameter,
                        commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertLine01(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var batches = rows.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("LineId");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("CdsVersion");
            dataTable.Columns.Add("CdsRecordType");
            dataTable.Columns.Add("CdsBulkReplacementGroup");
            dataTable.Columns.Add("CdsProtocolIdentifier");
            dataTable.Columns.Add("CdsUniqueIdentifier");
            dataTable.Columns.Add("CDSUpdateType");
            dataTable.Columns.Add("CdsApplicableDate");
            dataTable.Columns.Add("CdsApplicableTime");
            dataTable.Columns.Add("CDSExtractDate");
            dataTable.Columns.Add("CDSExtractTime");
            dataTable.Columns.Add("CDSReportPeriodStartDate");
            dataTable.Columns.Add("CDSReportPeriodEndDate");
            dataTable.Columns.Add("CDSCensusDate");
            dataTable.Columns.Add("CDSActivityDate");
            dataTable.Columns.Add("CDSSenderIdentity");
            dataTable.Columns.Add("CDSPrimaryRecipientIdentity");
            dataTable.Columns.Add("CDSCopyRecipientIdentity1");
            dataTable.Columns.Add("CDSCopyRecipientIdentity2");
            dataTable.Columns.Add("CDSCopyRecipientIdentity3");
            dataTable.Columns.Add("CDSCopyRecipientIdentity4");
            dataTable.Columns.Add("CDSCopyRecipientIdentity5");
            dataTable.Columns.Add("CDSCopyRecipientIdentity6");
            dataTable.Columns.Add("CDSCopyRecipientIdentity7");
            dataTable.Columns.Add("UniqueBookingReferenceNumberConverted");
            dataTable.Columns.Add("PatientPathwayIdentifier");
            dataTable.Columns.Add("OrganisationCodeofthePatientPathwayIdentifier");
            dataTable.Columns.Add("ReferralToTreatmentPeriodStatus");
            dataTable.Columns.Add("WaitingTimeMeasurementType");
            dataTable.Columns.Add("ReferralToTreatmentPeriodStartDate");
            dataTable.Columns.Add("ReferralToTreatmentPeriodEndDate");
            dataTable.Columns.Add("LocalPatientID");
            dataTable.Columns.Add("OrganisationCodeLocalPatientID");
            dataTable.Columns.Add("NHSNumberStatusIndicator");
            dataTable.Columns.Add("NHSNumber");
            dataTable.Columns.Add("WithheldFlag");
            dataTable.Columns.Add("WithheldIdentityReason");
            dataTable.Columns.Add("DateofBirth");
            dataTable.Columns.Add("PatientNameType");
            dataTable.Columns.Add("PatientFullName");
            dataTable.Columns.Add("PatientRequestedName");
            dataTable.Columns.Add("PatientTitle");
            dataTable.Columns.Add("PatientForename");
            dataTable.Columns.Add("PatientSurname");
            dataTable.Columns.Add("PatientNameSuffix");
            dataTable.Columns.Add("PatientInitials");
            dataTable.Columns.Add("PatientAddressType");
            dataTable.Columns.Add("PatientUnstructuredAddress");
            dataTable.Columns.Add("PatientAddressStructured1");
            dataTable.Columns.Add("PatientAddressStructured2");
            dataTable.Columns.Add("PatientAddressStructured3");
            dataTable.Columns.Add("PatientAddressStructured4");
            dataTable.Columns.Add("PatientAddressStructured5");
            dataTable.Columns.Add("Postcode");
            dataTable.Columns.Add("OrganisationCodeResidenceResponsibility");
            dataTable.Columns.Add("PersonCurrentGenderCode");
            dataTable.Columns.Add("CarerSupportIndicator");
            dataTable.Columns.Add("EthnicCategory");
            dataTable.Columns.Add("PersonMaritalStatus");
            dataTable.Columns.Add("BirthWeight");
            dataTable.Columns.Add("LiveStillBirthIndicator");
            dataTable.Columns.Add("TotalPreviousPregnancies");
            dataTable.Columns.Add("CommissioningSerialNumber");
            dataTable.Columns.Add("NHSServiceAgreementLineNumber");
            dataTable.Columns.Add("ProvidersReferenceNumber");
            dataTable.Columns.Add("CommissionersReferenceNumber");
            dataTable.Columns.Add("OrganisationCodeCodeofProvider");
            dataTable.Columns.Add("OrganisationCodeCodeofCommissioner");
            dataTable.Columns.Add("NHSServiceAgreementChangeDate");
            dataTable.Columns.Add("GeneralMedicalPractitionerSpecified");
            dataTable.Columns.Add("GPPracticeRegistered");
            dataTable.Columns.Add("ReferrerCode");
            dataTable.Columns.Add("ReferringOrganisationCode");
            dataTable.Columns.Add("DirectAccessReferralIndicator");
            dataTable.Columns.Add("ConsultantCode");
            dataTable.Columns.Add("CareProfessionalMainSpecialtyCode");
            dataTable.Columns.Add("ActivityTreatmentFunctionCode");
            dataTable.Columns.Add("LocalSubSpecialtyCode");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.Line01!.LineId,
                    row.Line01.RecordConnectionIdentifier,
                    row.Line01.CdsVersion,
                    row.Line01.CdsRecordType,
                    row.Line01.CdsBulkReplacementGroup,
                    row.Line01.CdsProtocolIdentifier,
                    row.Line01.CdsUniqueIdentifier,
                    row.Line01.CDSUpdateType,
                    row.Line01.CdsApplicableDate,
                    row.Line01.CdsApplicableTime,
                    row.Line01.CDSExtractDate,
                    row.Line01.CDSExtractTime,
                    row.Line01.CDSReportPeriodStartDate,
                    row.Line01.CDSReportPeriodEndDate,
                    row.Line01.CDSCensusDate,
                    row.Line01.CDSActivityDate,
                    row.Line01.CDSSenderIdentity,
                    row.Line01.CDSPrimaryRecipientIdentity,
                    row.Line01.CDSCopyRecipientIdentity1,
                    row.Line01.CDSCopyRecipientIdentity2,
                    row.Line01.CDSCopyRecipientIdentity3,
                    row.Line01.CDSCopyRecipientIdentity4,
                    row.Line01.CDSCopyRecipientIdentity5,
                    row.Line01.CDSCopyRecipientIdentity6,
                    row.Line01.CDSCopyRecipientIdentity7,
                    row.Line01.UniqueBookingReferenceNumberConverted,
                    row.Line01.PatientPathwayIdentifier,
                    row.Line01.OrganisationCodeofthePatientPathwayIdentifier,
                    row.Line01.ReferralToTreatmentPeriodStatus,
                    row.Line01.WaitingTimeMeasurementType,
                    row.Line01.ReferralToTreatmentPeriodStartDate,
                    row.Line01.ReferralToTreatmentPeriodEndDate,
                    row.Line01.LocalPatientID,
                    row.Line01.OrganisationCodeLocalPatientID,
                    row.Line01.NHSNumberStatusIndicator,
                    row.Line01.NHSNumber,
                    row.Line01.WithheldFlag,
                    row.Line01.WithheldIdentityReason,
                    row.Line01.DateofBirth,
                    row.Line01.PatientNameType,
                    row.Line01.PatientFullName,
                    row.Line01.PatientRequestedName,
                    row.Line01.PatientTitle,
                    row.Line01.PatientForename,
                    row.Line01.PatientSurname,
                    row.Line01.PatientNameSuffix,
                    row.Line01.PatientInitials,
                    row.Line01.PatientAddressType,
                    row.Line01.PatientUnstructuredAddress,
                    row.Line01.PatientAddressStructured1,
                    row.Line01.PatientAddressStructured2,
                    row.Line01.PatientAddressStructured3,
                    row.Line01.PatientAddressStructured4,
                    row.Line01.PatientAddressStructured5,
                    row.Line01.Postcode,
                    row.Line01.OrganisationCodeResidenceResponsibility,
                    row.Line01.PersonCurrentGenderCode,
                    row.Line01.CarerSupportIndicator,
                    row.Line01.EthnicCategory,
                    row.Line01.PersonMaritalStatus,
                    row.Line01.BirthWeight,
                    row.Line01.LiveStillBirthIndicator,
                    row.Line01.TotalPreviousPregnancies,
                    row.Line01.CommissioningSerialNumber,
                    row.Line01.NHSServiceAgreementLineNumber,
                    row.Line01.ProvidersReferenceNumber,
                    row.Line01.CommissionersReferenceNumber,
                    row.Line01.OrganisationCodeCodeofProvider,
                    row.Line01.OrganisationCodeCodeofCommissioner,
                    row.Line01.NHSServiceAgreementChangeDate,
                    row.Line01.GeneralMedicalPractitionerSpecified,
                    row.Line01.GPPracticeRegistered,
                    row.Line01.ReferrerCode,
                    row.Line01.ReferringOrganisationCode,
                    row.Line01.DirectAccessReferralIndicator,
                    row.Line01.ConsultantCode,
                    row.Line01.CareProfessionalMainSpecialtyCode,
                    row.Line01.ActivityTreatmentFunctionCode,
                    row.Line01.LocalSubSpecialtyCode);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[cds_line01_row]")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "[omop_staging].[insert_cds_line01]",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }

    }
    private async Task InsertLine02(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var line02s =
            rows
            .SelectMany(
                row =>
                    row
                    .Line02
                    .Select(line02 => new { row.MessageId, line02 }));

        var batches = line02s.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("LineId");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("LineCount");
            dataTable.Columns.Add("DiagnosisSchemeInUse");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.line02.LineId,
                    row.line02.RecordConnectionIdentifier,
                    row.line02.LineCount,
                    row.line02.DiagnosisSchemeInUse);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[cds_line02_row]")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_line02",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertLine03(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var line03s =
            rows
            .SelectMany(
                row =>
                    row
                    .Line03
                    .Select(line03 => new { row.MessageId, line03 }));

        var batches = line03s.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("LineId");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("LineCount");
            dataTable.Columns.Add("ProcedureSchemeInUse");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.line03.LineId,
                    row.line03.RecordConnectionIdentifier,
                    row.line03.LineCount,
                    row.line03.ProcedureSchemeInUse);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[cds_line03_row]")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_line03",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertLine04(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var line04s =
            rows
            .SelectMany(
                row =>
                    row
                    .Line04
                    .Select(line04 => new { row.MessageId, line04 = line04 }));

        var batches = line04s.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("LineId");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("LineCount");
            dataTable.Columns.Add("LocationClass");
            dataTable.Columns.Add("SiteCodeofTreatment");
            dataTable.Columns.Add("ActivityLocationType");
            dataTable.Columns.Add("IntendedClinicalCareIntensityCode");
            dataTable.Columns.Add("AgeGroupIntended");
            dataTable.Columns.Add("SexofPatientsCode");
            dataTable.Columns.Add("WardNightPeriodAvailabilityCode");
            dataTable.Columns.Add("WardDayPeriodAvailabilityCode");
            dataTable.Columns.Add("StartDateWardStay");
            dataTable.Columns.Add("StartTimeWardStay");
            dataTable.Columns.Add("EndDateWardStay");
            dataTable.Columns.Add("EndTimeWardStay");
            dataTable.Columns.Add("WardSecurityLevel");
            dataTable.Columns.Add("WardCode");
            dataTable.Columns.Add("ClinicCode");
            dataTable.Columns.Add("DetainedandorLongTermPsychiatricCensusDate");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.line04.LineId,
                    row.line04.RecordConnectionIdentifier,
                    row.line04.LineCount,
                    row.line04.LocationClass,
                    row.line04.SiteCodeofTreatment,
                    row.line04.ActivityLocationType,
                    row.line04.IntendedClinicalCareIntensityCode,
                    row.line04.AgeGroupIntended,
                    row.line04.SexofPatientsCode,
                    row.line04.WardNightPeriodAvailabilityCode,
                    row.line04.WardDayPeriodAvailabilityCode,
                    row.line04.StartDateWardStay,
                    row.line04.StartTimeWardStay,
                    row.line04.EndDateWardStay,
                    row.line04.EndTimeWardStay,
                    row.line04.WardSecurityLevel,
                    row.line04.WardCode,
                    row.line04.ClinicCode,
                    row.line04.DetainedandorLongTermPsychiatricCensusDate);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[cds_line04_row]")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_line04",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertLine05(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var line05s =
            rows
            .SelectMany(
                row =>
                    row
                    .Line05
                    .Select(line05 => new { row.MessageId, line05 }));

        var batches = line05s.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("LineId");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("HospitalProviderSpellNumber");
            dataTable.Columns.Add("AdministrativeCategoryCode");
            dataTable.Columns.Add("PatientClassification");
            dataTable.Columns.Add("AdmissionMethodCode");
            dataTable.Columns.Add("SourceofAdmissionCode");
            dataTable.Columns.Add("StartDateHospitalProviderSpell");
            dataTable.Columns.Add("StartTimeHospitalProviderSpell");
            dataTable.Columns.Add("AgeOnAdmission");
            dataTable.Columns.Add("AmbulanceIncidentNumber");
            dataTable.Columns.Add("OrganisationCodeConveyingAmbulanceTrust");
            dataTable.Columns.Add("DischargeDestinationCode");
            dataTable.Columns.Add("DischargeMethod");
            dataTable.Columns.Add("DischargeReadyDateHospitalProviderSpell");
            dataTable.Columns.Add("DischargeDateHospitalProviderSpell");
            dataTable.Columns.Add("DischargeTimeHospitalProviderSpell");
            dataTable.Columns.Add("DischargetoHospitalatHomeServiceIndicator");
            dataTable.Columns.Add("MentalHealthActLegalClassificationCodeonAdmission");
            dataTable.Columns.Add("MentalHealthActLegalStatusClassificationCodeAtCensusDate");
            dataTable.Columns.Add("DateDetentionCommenced");
            dataTable.Columns.Add("AgeAtCensus");
            dataTable.Columns.Add("DurationOfCareToPsychiatricCensusDate");
            dataTable.Columns.Add("DurationOfDetention");
            dataTable.Columns.Add("MentalHealthAct2007MentalCategory");
            dataTable.Columns.Add("StatusOfPatientIncludedInThePsychiatricCensusCode");
            dataTable.Columns.Add("EpisodeNumber");
            dataTable.Columns.Add("LastEpisodeinSpellIndicator");
            dataTable.Columns.Add("OperationStatusCode");
            dataTable.Columns.Add("NeonatalLevelofCare");
            dataTable.Columns.Add("FirstRegularDayNightAdmission");
            dataTable.Columns.Add("PsychiatricPatientStatus");
            dataTable.Columns.Add("EpisodeStartDate");
            dataTable.Columns.Add("EpisodeStartTime");
            dataTable.Columns.Add("EpisodeEndDate");
            dataTable.Columns.Add("EpisodeEndTime");
            dataTable.Columns.Add("AgeAtCDSActivityDate");
            dataTable.Columns.Add("MultiProfessionalorMultidisciplinaryConsultationIndicationCode");
            dataTable.Columns.Add("RehabilitationAssessmentTeamType");
            dataTable.Columns.Add("LengthofStayAdjustmentRehabilitation");
            dataTable.Columns.Add("LengthOfStayAdjustmentSpecialistPalliativeCare");
            dataTable.Columns.Add("DurationofElectiveWait");
            dataTable.Columns.Add("IntendedManagement");
            dataTable.Columns.Add("DecidedtoAdmitDate");
            dataTable.Columns.Add("EarliestReasonableOfferDate");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.line05.LineId,
                    row.line05.RecordConnectionIdentifier,
                    row.line05.HospitalProviderSpellNumber,
                    row.line05.AdministrativeCategoryCode,
                    row.line05.PatientClassification,
                    row.line05.AdmissionMethodCode,
                    row.line05.SourceofAdmissionCode,
                    row.line05.StartDateHospitalProviderSpell,
                    row.line05.StartTimeHospitalProviderSpell,
                    row.line05.AgeOnAdmission,
                    row.line05.AmbulanceIncidentNumber,
                    row.line05.OrganisationCodeConveyingAmbulanceTrust,
                    row.line05.DischargeDestinationCode,
                    row.line05.DischargeMethod,
                    row.line05.DischargeReadyDateHospitalProviderSpell,
                    row.line05.DischargeDateHospitalProviderSpell,
                    row.line05.DischargeTimeHospitalProviderSpell,
                    row.line05.DischargetoHospitalatHomeServiceIndicator,
                    row.line05.MentalHealthActLegalClassificationCodeonAdmission,
                    row.line05.MentalHealthActLegalStatusClassificationCodeAtCensusDate,
                    row.line05.DateDetentionCommenced,
                    row.line05.AgeAtCensus,
                    row.line05.DurationOfCareToPsychiatricCensusDate,
                    row.line05.DurationOfDetention,
                    row.line05.MentalHealthAct2007MentalCategory,
                    row.line05.StatusOfPatientIncludedInThePsychiatricCensusCode,
                    row.line05.EpisodeNumber,
                    row.line05.LastEpisodeinSpellIndicator,
                    row.line05.OperationStatusCode,
                    row.line05.NeonatalLevelofCare,
                    row.line05.FirstRegularDayNightAdmission,
                    row.line05.PsychiatricPatientStatus,
                    row.line05.EpisodeStartDate,
                    row.line05.EpisodeStartTime,
                    row.line05.EpisodeEndDate,
                    row.line05.EpisodeEndTime,
                    row.line05.AgeAtCDSActivityDate,
                    row.line05.MultiProfessionalorMultidisciplinaryConsultationIndicationCode,
                    row.line05.RehabilitationAssessmentTeamType,
                    row.line05.LengthofStayAdjustmentRehabilitation,
                    row.line05.LengthOfStayAdjustmentSpecialistPalliativeCare,
                    row.line05.DurationofElectiveWait,
                    row.line05.IntendedManagement,
                    row.line05.DecidedtoAdmitDate,
                    row.line05.EarliestReasonableOfferDate);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[cds_line05_row]")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_line05",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertLine06(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var line06s =
            rows
            .SelectMany(
                row =>
                    row
                    .Line06
                    .Select(line06 => new { row.MessageId, line06 }));

        var batches = line06s.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("LineId");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("LineCount");
            dataTable.Columns.Add("CriticalCareTypeID");
            dataTable.Columns.Add("CriticalCareLocalIdentifier");
            dataTable.Columns.Add("CriticalCareStartDate");
            dataTable.Columns.Add("CriticalCareStartTime");
            dataTable.Columns.Add("CriticalCareUnitFunction");
            dataTable.Columns.Add("GestationLengthAtDelivery");
            dataTable.Columns.Add("UnitBedConfiguration");
            dataTable.Columns.Add("CriticalCareAdmissionSource");
            dataTable.Columns.Add("CriticalCareSourceLocation");
            dataTable.Columns.Add("CriticalCareAdmissionType");
            dataTable.Columns.Add("AdvancedRespiratorySupportDays");
            dataTable.Columns.Add("BasicRespiratorySupportsDays");
            dataTable.Columns.Add("AdvancedCardiovascularSupportDays");
            dataTable.Columns.Add("BasicCardiovascularSupportDays");
            dataTable.Columns.Add("RenalSupportDays");
            dataTable.Columns.Add("NeurologicalSupportDays");
            dataTable.Columns.Add("GastroIntestinalSupportDays");
            dataTable.Columns.Add("DermatologicalSupportDays");
            dataTable.Columns.Add("LiverSupportDays");
            dataTable.Columns.Add("OrganSupportMaximum");
            dataTable.Columns.Add("CriticalCareLevel2Days");
            dataTable.Columns.Add("CriticalCareLevel3Days");
            dataTable.Columns.Add("CriticalCareDischargeDate");
            dataTable.Columns.Add("CriticalCareDischargeTime");
            dataTable.Columns.Add("CriticalCareDischargeReadyDate");
            dataTable.Columns.Add("CriticalCareDischargeReadyTime");
            dataTable.Columns.Add("CriticalCareDischargeStatus");
            dataTable.Columns.Add("CriticalCareDischargeDestination");
            dataTable.Columns.Add("CriticalCareDischargeLocation");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                   row.line06.LineId,
                    row.line06.RecordConnectionIdentifier,
                    row.line06.LineCount,
                    row.line06.CriticalCareTypeID,
                    row.line06.CriticalCareLocalIdentifier,
                    row.line06.CriticalCareStartDate,
                    row.line06.CriticalCareStartTime,
                    row.line06.CriticalCareUnitFunction,
                    row.line06.GestationLengthAtDelivery,
                    row.line06.UnitBedConfiguration,
                    row.line06.CriticalCareAdmissionSource,
                    row.line06.CriticalCareSourceLocation,
                    row.line06.CriticalCareAdmissionType,
                    row.line06.AdvancedRespiratorySupportDays,
                    row.line06.BasicRespiratorySupportsDays,
                    row.line06.AdvancedCardiovascularSupportDays,
                    row.line06.BasicCardiovascularSupportDays,
                    row.line06.RenalSupportDays,
                    row.line06.NeurologicalSupportDays,
                    row.line06.GastroIntestinalSupportDays,
                    row.line06.DermatologicalSupportDays,
                    row.line06.LiverSupportDays,
                    row.line06.OrganSupportMaximum,
                    row.line06.CriticalCareLevel2Days,
                    row.line06.CriticalCareLevel3Days,
                    row.line06.CriticalCareDischargeDate,
                    row.line06.CriticalCareDischargeTime,
                    row.line06.CriticalCareDischargeReadyDate,
                    row.line06.CriticalCareDischargeReadyTime,
                    row.line06.CriticalCareDischargeStatus,
                    row.line06.CriticalCareDischargeDestination,
                    row.line06.CriticalCareDischargeLocation);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[cds_line06_row]")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_line06",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertLine07(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var line07s =
            rows
            .SelectMany(
                row =>
                    row
                    .Line07
                    .Select(line07 => new { row.MessageId, line07 }));

        var batches = line07s.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("LineId");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("CriticalCareCount");
            dataTable.Columns.Add("LineCount");
            dataTable.Columns.Add("ActivityDateCriticalCare");
            dataTable.Columns.Add("PersonWeight");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.line07.LineId,
                    row.line07.RecordConnectionIdentifier,
                    row.line07.CriticalCareCount,
                    row.line07.LineCount,
                    row.line07.ActivityDateCriticalCare,
                    row.line07.PersonWeight);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[cds_line07_row]")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_line07",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertLine08(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var line08s =
            rows
            .SelectMany(
                row =>
                    row
                    .Line08
                    .Select(line08 => new { row.MessageId, line08 }));

        var batches = line08s.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("LineId");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("NumberofBabies");
            dataTable.Columns.Add("FirstAntenatalAssessmentDate");
            dataTable.Columns.Add("GeneralMedicalPractitionerAntenatalCare");
            dataTable.Columns.Add("GeneralMedicalPractitionerPracticeAntenatalCare");
            dataTable.Columns.Add("LocationClass");
            dataTable.Columns.Add("ActivityLocationType");
            dataTable.Columns.Add("DeliveryPlaceTypeIntended");
            dataTable.Columns.Add("DeliveryPlaceChangeReason");
            dataTable.Columns.Add("AnaestheticDuringLabourDelivery");
            dataTable.Columns.Add("AnaestheticGivenPostLabourDelivery");
            dataTable.Columns.Add("GestationLengthLabourOnset");
            dataTable.Columns.Add("LabourDeliveryOnsetMethod");
            dataTable.Columns.Add("DeliveryDate");
            dataTable.Columns.Add("AgeAtCDSActivityDate");
            dataTable.Columns.Add("LocalPatientID");
            dataTable.Columns.Add("OrganisationCodeLocalPatientID");
            dataTable.Columns.Add("NHSNumberStatusIndicator");
            dataTable.Columns.Add("NHSNumber");
            dataTable.Columns.Add("WithheldFlag");
            dataTable.Columns.Add("WithheldIdentityReason");
            dataTable.Columns.Add("MotherBirthDate");
            dataTable.Columns.Add("OverseasVisitorStatusAtCDSActivityDate");
            dataTable.Columns.Add("PatientAddressType");
            dataTable.Columns.Add("PatientUnstructuredAddress");
            dataTable.Columns.Add("PatientStructured1");
            dataTable.Columns.Add("PatientStructured2");
            dataTable.Columns.Add("PatientStructured3");
            dataTable.Columns.Add("PatientStructured4");
            dataTable.Columns.Add("PatientStructured5");
            dataTable.Columns.Add("Postcode");
            dataTable.Columns.Add("OrganisationCodeResidenceResponsibility");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.line08.LineId,
                    row.line08.RecordConnectionIdentifier,
                    row.line08.NumberofBabies,
                    row.line08.FirstAntenatalAssessmentDate,
                    row.line08.GeneralMedicalPractitionerAntenatalCare,
                    row.line08.GeneralMedicalPractitionerPracticeAntenatalCare,
                    row.line08.LocationClass,
                    row.line08.ActivityLocationType,
                    row.line08.DeliveryPlaceTypeIntended,
                    row.line08.DeliveryPlaceChangeReason,
                    row.line08.AnaestheticDuringLabourDelivery,
                    row.line08.AnaestheticGivenPostLabourDelivery,
                    row.line08.GestationLengthLabourOnset,
                    row.line08.LabourDeliveryOnsetMethod,
                    row.line08.DeliveryDate,
                    row.line08.AgeAtCDSActivityDate,
                    row.line08.LocalPatientID,
                    row.line08.OrganisationCodeLocalPatientID,
                    row.line08.NHSNumberStatusIndicator,
                    row.line08.NHSNumber,
                    row.line08.WithheldFlag,
                    row.line08.WithheldIdentityReason,
                    row.line08.MotherBirthDate,
                    row.line08.OverseasVisitorStatusAtCDSActivityDate,
                    row.line08.PatientAddressType,
                    row.line08.PatientUnstructuredAddress,
                    row.line08.PatientStructured1,
                    row.line08.PatientStructured2,
                    row.line08.PatientStructured3,
                    row.line08.PatientStructured4,
                    row.line08.PatientStructured5,
                    row.line08.Postcode,
                    row.line08.OrganisationCodeResidenceResponsibility);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[cds_line08_row]")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_line08",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertLine09(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var line09s =
            rows
            .SelectMany(
                row =>
                    row
                    .Line09
                    .Select(line09 => new { row.MessageId, line09 }));

        var batches = line09s.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("LineId");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("AttendanceIdentifier");
            dataTable.Columns.Add("AdministrativeCategoryCode");
            dataTable.Columns.Add("AttendedOrDidNotAttendCode");
            dataTable.Columns.Add("FirstAttendanceCode");
            dataTable.Columns.Add("MedicalStaffTypeSeeingPatient");
            dataTable.Columns.Add("OperationStatusCode");
            dataTable.Columns.Add("OutcomeofAttendanceCode");
            dataTable.Columns.Add("AppointmentDate");
            dataTable.Columns.Add("AppointmentTime");
            dataTable.Columns.Add("ExpectedDurationOfAppointment");
            dataTable.Columns.Add("AgeAtCDSActivityDate");
            dataTable.Columns.Add("OverseasVisitorStatusClassificationAtCDSActivityDate");
            dataTable.Columns.Add("EarliestReasonableOfferDate");
            dataTable.Columns.Add("EarliestClinicallyAppropriateDate");
            dataTable.Columns.Add("ConsultationMediumUsed");
            dataTable.Columns.Add("MultiProfessionalorMultidisciplinaryConsultationIndicationCode");
            dataTable.Columns.Add("RehabilitationAssessmentTeamType");
            dataTable.Columns.Add("PriorityTypeCode");
            dataTable.Columns.Add("ServiceTypeRequestedCode");
            dataTable.Columns.Add("SourceofReferralforOutpatients");
            dataTable.Columns.Add("ReferralRequestReceivedDate");
            dataTable.Columns.Add("LastDNAorPatientCancelledDate");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                row.MessageId,
                    row.line09.LineId,
                    row.line09.RecordConnectionIdentifier,
                    row.line09.AttendanceIdentifier,
                    row.line09.AdministrativeCategoryCode,
                    row.line09.AttendedOrDidNotAttendCode,
                    row.line09.FirstAttendanceCode,
                    row.line09.MedicalStaffTypeSeeingPatient,
                    row.line09.OperationStatusCode,
                    row.line09.OutcomeofAttendanceCode,
                    row.line09.AppointmentDate,
                    row.line09.AppointmentTime,
                    row.line09.ExpectedDurationOfAppointment,
                    row.line09.AgeAtCDSActivityDate,
                    row.line09.OverseasVisitorStatusClassificationAtCDSActivityDate,
                    row.line09.EarliestReasonableOfferDate,
                    row.line09.EarliestClinicallyAppropriateDate,
                    row.line09.ConsultationMediumUsed,
                    row.line09.MultiProfessionalorMultidisciplinaryConsultationIndicationCode,
                    row.line09.RehabilitationAssessmentTeamType,
                    row.line09.PriorityTypeCode,
                    row.line09.ServiceTypeRequestedCode,
                    row.line09.SourceofReferralforOutpatients,
                    row.line09.ReferralRequestReceivedDate,
                    row.line09.LastDNAorPatientCancelledDate);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[cds_line09_row]")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_line09",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertLine10(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var line10s =
            rows
            .SelectMany(
                row =>
                    row
                    .Line10
                    .Select(line10 => new { row.MessageId, line10 }));

        var batches = line10s.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("LineId");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("EALAdmissionEntryNumber");
            dataTable.Columns.Add("AdministrativeCategoryCode");
            dataTable.Columns.Add("CountofDaysSuspended");
            dataTable.Columns.Add("ElectiveAdmissionListStatus");
            dataTable.Columns.Add("ElectiveAdmissionTypeCode");
            dataTable.Columns.Add("IntendedManagementCode");
            dataTable.Columns.Add("PriorityTypeCode");
            dataTable.Columns.Add("IntendedProcedureStatusCode");
            dataTable.Columns.Add("DecidedtoAdmitDate");
            dataTable.Columns.Add("AgeAtCDSActivityDate");
            dataTable.Columns.Add("OverseasVisitorStatusClassificationAtCDSActivityDate");
            dataTable.Columns.Add("GuaranteedAdmissionDate");
            dataTable.Columns.Add("LastDNAorCancelledDate");
            dataTable.Columns.Add("WaitingListEntryLastReviewedDate");
            dataTable.Columns.Add("AdmissionOfferOutcome");
            dataTable.Columns.Add("OfferedforAdmissionDate");
            dataTable.Columns.Add("EarliestReasonableOfferDate");
            dataTable.Columns.Add("OriginalDecidedtoAdmitDate");
            dataTable.Columns.Add("RemovalReasonCode");
            dataTable.Columns.Add("RemovalDate");
            dataTable.Columns.Add("SuspensionStartDate");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.line10.LineId,
                    row.line10.RecordConnectionIdentifier,
                    row.line10.EALAdmissionEntryNumber,
                    row.line10.AdministrativeCategoryCode,
                    row.line10.CountofDaysSuspended,
                    row.line10.ElectiveAdmissionListStatus,
                    row.line10.ElectiveAdmissionTypeCode,
                    row.line10.IntendedManagementCode,
                    row.line10.PriorityTypeCode,
                    row.line10.IntendedProcedureStatusCode,
                    row.line10.DecidedtoAdmitDate,
                    row.line10.AgeAtCDSActivityDate,
                    row.line10.OverseasVisitorStatusClassificationAtCDSActivityDate,
                    row.line10.GuaranteedAdmissionDate,
                    row.line10.LastDNAorCancelledDate,
                    row.line10.WaitingListEntryLastReviewedDate,
                    row.line10.AdmissionOfferOutcome,
                    row.line10.OfferedforAdmissionDate,
                    row.line10.EarliestReasonableOfferDate,
                    row.line10.OriginalDecidedtoAdmitDate,
                    row.line10.RemovalReasonCode,
                    row.line10.RemovalDate,
                    row.line10.SuspensionStartDate);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[cds_line10_row]")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_line10",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertLine11(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var line11s =
            rows
            .SelectMany(
                row =>
                    row
                    .Line11
                    .Select(line11 => new { row.MessageId, line11 }));

        var batches = line11s.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("LineId");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("AttendanceNumber");
            dataTable.Columns.Add("ArrivalModeCode");
            dataTable.Columns.Add("AttendanceCategoryCode");
            dataTable.Columns.Add("AttendanceDisposal");
            dataTable.Columns.Add("IncidentLocationType");
            dataTable.Columns.Add("PatientGroup");
            dataTable.Columns.Add("SourceofReferral");
            dataTable.Columns.Add("AEDepartmentType");
            dataTable.Columns.Add("ArrivalDate");
            dataTable.Columns.Add("ArrivalTime");
            dataTable.Columns.Add("AgeAtCDSActivityDate");
            dataTable.Columns.Add("OverseasVisitorStatusClassificationAtCDSActivityDate");
            dataTable.Columns.Add("InitialAssessmentDate");
            dataTable.Columns.Add("InitialAssessmentTime");
            dataTable.Columns.Add("DateSeenforTreatment");
            dataTable.Columns.Add("TimeSeenforTreatment");
            dataTable.Columns.Add("AttendanceConclusionDate");
            dataTable.Columns.Add("AttendanceConclusionTime");
            dataTable.Columns.Add("DepartureDate");
            dataTable.Columns.Add("DepartureTime");
            dataTable.Columns.Add("AmbulanceIncidentNumber");
            dataTable.Columns.Add("OrganisationCodeConveyingAmbulanceTrust");
            dataTable.Columns.Add("AEStaffMemberCode");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.line11.LineId,
                    row.line11.RecordConnectionIdentifier,
                    row.line11.AttendanceNumber,
                    row.line11.ArrivalModeCode,
                    row.line11.AttendanceCategoryCode,
                    row.line11.AttendanceDisposal,
                    row.line11.IncidentLocationType,
                    row.line11.PatientGroup,
                    row.line11.SourceofReferral,
                    row.line11.AEDepartmentType,
                    row.line11.ArrivalDate,
                    row.line11.ArrivalTime,
                    row.line11.AgeAtCDSActivityDate,
                    row.line11.OverseasVisitorStatusClassificationAtCDSActivityDate,
                    row.line11.InitialAssessmentDate,
                    row.line11.InitialAssessmentTime,
                    row.line11.DateSeenforTreatment,
                    row.line11.TimeSeenforTreatment,
                    row.line11.AttendanceConclusionDate,
                    row.line11.AttendanceConclusionTime,
                    row.line11.DepartureDate,
                    row.line11.DepartureTime,
                    row.line11.AmbulanceIncidentNumber,
                    row.line11.OrganisationCodeConveyingAmbulanceTrust,
                    row.line11.AEStaffMemberCode);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[cds_line11_row]")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_line11",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertLine12(IReadOnlyCollection<Message> rows, IDbConnection connection, CancellationToken cancellationToken)
    {
        var line12s =
            rows
            .SelectMany(
                row =>
                    row
                    .Line12
                    .Select(line12 => new { row.MessageId, line12 }));

        var batches = line12s.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("MessageId");
            dataTable.Columns.Add("LineId");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("LineCount");
            dataTable.Columns.Add("InvestigationSchemeinUse");
            dataTable.Columns.Add("PrimaryInvestigation");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.MessageId,
                    row.line12.LineId,
                    row.line12.RecordConnectionIdentifier,
                    row.line12.LineCount,
                    row.line12.InvestigationSchemeinUse,
                    row.line12.PrimaryInvestigation);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[cds_line12_row]")
            };

            await connection
                .ExecuteLongTimeoutAsync(
                    "omop_staging.insert_cds_line12",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }
}
    