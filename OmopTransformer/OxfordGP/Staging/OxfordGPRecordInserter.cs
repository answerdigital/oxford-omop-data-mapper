using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.OxfordGP.Staging;

internal class OxfordGPRecordInserter : IOxfordGPRecordInserter
{
    private readonly Configuration _configuration;
    private readonly ILogger<OxfordGPRecordInserter> _logger;

    public OxfordGPRecordInserter(IOptions<Configuration> configuration, ILogger<OxfordGPRecordInserter> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task Insert(GPRecord records, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        await InsertBatch(records.Demographics, "Recording GP Demographics rows", InsertGPDemographics, cancellationToken);
        await InsertBatch(records.Appointments, "Recording GP Appointment rows", InsertGPAppointments, cancellationToken);
        await InsertBatch(records.Events, "Recording GP Events rows", InsertGPEvents, cancellationToken);
        await InsertBatch(records.Medications, "Recording GP Medications rows", InsertGPMedications, cancellationToken);
    }

    private async Task InsertBatch<T>(
        IEnumerable<T> rows, 
        string name, 
        Func<IReadOnlyCollection<T>, IDbConnection, Task> record, 
        CancellationToken cancellationToken)
    {
        if (rows == null) throw new ArgumentNullException(nameof(rows));

        _logger.LogInformation(name);

        var batches = rows.Batch(_configuration.BatchSize!.Value);
        int batchNumber = 1;

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        foreach (var batch in batches)
        {
            _logger.LogInformation("Batch {0}.", batchNumber++);

            await record(batch.ToList(), connection);

            cancellationToken.ThrowIfCancellationRequested();
        }
    }

    private async Task InsertGPAppointments(IReadOnlyCollection<GPAppointment> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("GPAppointmentsPrimaryKey");
        dataTable.Columns.Add("PatientIdentifier ");
        dataTable.Columns.Add("AppointmentDate");
        dataTable.Columns.Add("AppointmentStatus");
        dataTable.Columns.Add("AppointmentBookedDate");
        dataTable.Columns.Add("ClinicianCode");
        dataTable.Columns.Add("AppointmentCancelledDate");
        dataTable.Columns.Add("OrganisationName");
        dataTable.Columns.Add("SourceName");
        dataTable.Columns.Add("StatusDescription");
        dataTable.Columns.Add("DNAFlag");
        dataTable.Columns.Add("OrganisationNationalCode");
        dataTable.Columns.Add("ClinicianType");
        dataTable.Columns.Add("OrganisationIdentifier");
        dataTable.Columns.Add("Location");
        dataTable.Columns.Add("LocationType");
        dataTable.Columns.Add("Specialty");
        dataTable.Columns.Add("ClinicName");
        dataTable.Columns.Add("BookingSource");
        dataTable.Columns.Add("BookingMethod");
        dataTable.Columns.Add("PatientArrivedDateTime");
        dataTable.Columns.Add("PatientSeenDateTime");
        dataTable.Columns.Add("DeliveryMethodText");
        dataTable.Columns.Add("PlannedMinutesDuration");
        dataTable.Columns.Add("ActualMinutesDuration");
        dataTable.Columns.Add("NationalSlotDesc");
        dataTable.Columns.Add("NationalSlotName");
        dataTable.Columns.Add("NationalContext");
        dataTable.Columns.Add("NationalService");
        dataTable.Columns.Add("UrgentFlag");
        dataTable.Columns.Add("FollowUp");
        dataTable.Columns.Add("ExternalPatient");
        dataTable.Columns.Add("ExternalPatientOrganisationIdentifierSystem");
        dataTable.Columns.Add("ExternalPatientOrganisationIdentifierValue");
        dataTable.Columns.Add("ExternalPatientOrganisationDisplay");
        dataTable.Columns.Add("CancellationReasonText");
        dataTable.Columns.Add("SessionIdentifierValue");
        dataTable.Columns.Add("ClinicianIdentifierValue");
        dataTable.Columns.Add("SlotEndDateTime");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.GPAppointmentsPrimaryKey,
                row.PatientIdentifier,
                row.AppointmentDate,
                row.AppointmentStatus,
                row.AppointmentBookedDate,
                row.ClinicianCode,
                row.AppointmentCancelledDate,
                row.OrganisationName,
                row.SourceName,
                row.StatusDescription,
                row.DNAFlag,
                row.OrganisationNationalCode,
                row.ClinicianType,
                row.OrganisationIdentifier,
                row.Location,
                row.LocationType,
                row.Specialty,
                row.ClinicName,
                row.BookingSource,
                row.BookingMethod,
                row.PatientArrivedDateTime,
                row.PatientSeenDateTime,
                row.DeliveryMethodText,
                row.PlannedMinutesDuration,
                row.ActualMinutesDuration,
                row.NationalSlotDesc,
                row.NationalSlotName,
                row.NationalContext,
                row.NationalService,
                row.UrgentFlag,
                row.FollowUp,
                row.ExternalPatient,
                row.ExternalPatientOrganisationIdentifierSystem,
                row.ExternalPatientOrganisationIdentifierValue,
                row.ExternalPatientOrganisationDisplay,
                row.CancellationReasonText,
                row.SessionIdentifierValue,
                row.ClinicianIdentifierValue,
                row.SlotEndDateTime);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.oxford_gp_appointment_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_oxford_gp_appointment_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertGPDemographics(IReadOnlyCollection<GPDemographic> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("PatientIdentifier");
        dataTable.Columns.Add("NHSNumber");
        dataTable.Columns.Add("Forename");
        dataTable.Columns.Add("Surname");
        dataTable.Columns.Add("DOB");
        dataTable.Columns.Add("Postcode");
        dataTable.Columns.Add("DateofDeath");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.PatientIdentifier,
                row.NHSNumber,
                row.Forename,
                row.Surname,
                row.DOB,
                row.Postcode,
                row.DateofDeath);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.oxford_gp_demographic_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_oxford_gp_demographic_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertGPEvents(IReadOnlyCollection<GPEvent> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("GPEventsPrimaryKey");
        dataTable.Columns.Add("PatientIdentifier");
        dataTable.Columns.Add("GeneralPractitionerCode");
        dataTable.Columns.Add("RegisteredGP");
        dataTable.Columns.Add("GPPracticeCode");
        dataTable.Columns.Add("EventDate");
        dataTable.Columns.Add("SuppliedCode");
        dataTable.Columns.Add("CodeSet");
        dataTable.Columns.Add("EventDescription");
        dataTable.Columns.Add("Episodicity");
        dataTable.Columns.Add("Units");
        dataTable.Columns.Add("Value");
        dataTable.Columns.Add("SensitivityDormant");
        dataTable.Columns.Add("EventNo");
        dataTable.Columns.Add("AlternateReadEMISCode");
        dataTable.Columns.Add("JournalUpdateFlag");
        dataTable.Columns.Add("UpdateKey");
        dataTable.Columns.Add("UniqueKey");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.GPEventsPrimaryKey,
                row.PatientIdentifier,
                row.GeneralPractitionerCode,
                row.RegisteredGP,
                row.GPPracticeCode,
                row.EventDate,
                row.SuppliedCode,
                row.CodeSet,
                row.EventDescription,
                row.Episodicity,
                row.Units,
                row.Value,
                row.SensitivityDormant,
                row.EventNo,
                row.AlternateReadEMISCode,
                row.JournalUpdateFlag,
                row.UpdateKey,
                row.UniqueKey);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.oxford_gp_event_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_oxford_gp_event_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertGPMedications(IReadOnlyCollection<GPMedication> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("GPMedicationsPrimaryKey");
        dataTable.Columns.Add("PatientIdentifier");
        dataTable.Columns.Add("GeneralPracticeCode");
        dataTable.Columns.Add("RegisteredGP");
        dataTable.Columns.Add("GPPracticeCode");
        dataTable.Columns.Add("SuppliedCode");
        dataTable.Columns.Add("CodeSet");
        dataTable.Columns.Add("MedicationDescription");
        dataTable.Columns.Add("Quantity");
        dataTable.Columns.Add("Dosage");
        dataTable.Columns.Add("LastIssueDate");
        dataTable.Columns.Add("MixtureID");
        dataTable.Columns.Add("Constituent");
        dataTable.Columns.Add("Units");
        dataTable.Columns.Add("RepeatMedicationFlag");
        dataTable.Columns.Add("MedicationNo");
        dataTable.Columns.Add("MaxIssues");
        dataTable.Columns.Add("UpdateKey");
        dataTable.Columns.Add("UniqueKey");
        dataTable.Columns.Add("AuthorisingUserDisplay");
        dataTable.Columns.Add("CourseLengthPerIssue");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.GPMedicationsPrimaryKey,
                row.PatientIdentifier,
                row.GeneralPracticeCode,
                row.RegisteredGP,
                row.GPPracticeCode,
                row.SuppliedCode,
                row.CodeSet,
                row.MedicationDescription,
                row.Quantity,
                row.Dosage,
                row.LastIssueDate,
                row.MixtureID,
                row.Constituent,
                row.Units,
                row.RepeatMedicationFlag,
                row.MedicationNo,
                row.MaxIssues,
                row.UpdateKey,
                row.UniqueKey,
                row.AuthorisingUserDisplay,
                row.CourseLengthPerIssue);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.oxford_gp_medication_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_oxford_gp_medication_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }
}