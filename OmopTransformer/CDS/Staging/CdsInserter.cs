using System.Data;
using System.Diagnostics;
using Dapper;
using Microsoft.Data.SqlClient;
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

        await using var connection = new SqlConnection(_configuration.OmopConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = rows.Batch(1000);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

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
                 row.Line01.LineId,
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
                Rows = dataTable.AsTableValuedParameter("[cds_line01_row]")
            };

            await connection.ExecuteAsync("insert_cds_line01", parameter, commandType: CommandType.StoredProcedure);
        }

        stopwatch.Stop();

        _logger.LogTrace("Inserting rows took {0}ms.", stopwatch.ElapsedMilliseconds);
    }
}