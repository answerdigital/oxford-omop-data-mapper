using System.Data;
using DuckDB.NET.Data;
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
        Action<IReadOnlyCollection<T>, DuckDBConnection> record, 
        CancellationToken cancellationToken)
    {
        if (rows == null) throw new ArgumentNullException(nameof(rows));

        _logger.LogInformation(name);

        var connection = new DuckDBConnection(_configuration.ConnectionString!);
        await connection.OpenAsync(cancellationToken);

        using IDbTransaction transaction = connection.BeginTransaction();

        try
        {
            record(rows.ToList(), connection);

            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();

            throw;
        }
    }

    private static void InsertGPAppointments(IReadOnlyCollection<GPAppointment> rows, DuckDBConnection connection)
    {
        using var appender = connection.CreateAppender("omop_staging", "oxford_gp_appointment");
        {
            foreach (var row in rows)
            {
                var dbRow = appender.CreateRow();

                dbRow
                    .AppendValue(row.GPAppointmentsPrimaryKey)
                    .AppendValue(row.PatientIdentifier)
                    .AppendValue(row.AppointmentDate)
                    .AppendValue(row.AppointmentStatus)
                    .AppendValue(row.AppointmentBookedDate)
                    .AppendValue(row.ClinicianCode)
                    .AppendValue(row.AppointmentCancelledDate)
                    .AppendValue(row.OrganisationName)
                    .AppendValue(row.SourceName)
                    .AppendValue(row.StatusDescription)
                    .AppendValue(row.DNAFlag)
                    .AppendValue(row.OrganisationNationalCode)
                    .AppendValue(row.ClinicianType)
                    .AppendValue(row.OrganisationIdentifier)
                    .AppendValue(row.Location)
                    .AppendValue(row.LocationType)
                    .AppendValue(row.Specialty)
                    .AppendValue(row.ClinicName)
                    .AppendValue(row.BookingSource)
                    .AppendValue(row.BookingMethod)
                    .AppendValue(row.PatientArrivedDateTime)
                    .AppendValue(row.PatientSeenDateTime)
                    .AppendValue(row.DeliveryMethodText)
                    .AppendValue(row.PlannedMinutesDuration)
                    .AppendValue(row.ActualMinutesDuration)
                    .AppendValue(row.NationalSlotDesc)
                    .AppendValue(row.NationalSlotName)
                    .AppendValue(row.NationalContext)
                    .AppendValue(row.NationalService)
                    .AppendValue(row.UrgentFlag)
                    .AppendValue(row.FollowUp)
                    .AppendValue(row.ExternalPatient)
                    .AppendValue(row.ExternalPatientOrganisationIdentifierSystem)
                    .AppendValue(row.ExternalPatientOrganisationIdentifierValue)
                    .AppendValue(row.ExternalPatientOrganisationDisplay)
                    .AppendValue(row.CancellationReasonText)
                    .AppendValue(row.SessionIdentifierValue)
                    .AppendValue(row.ClinicianIdentifierValue)
                    .AppendValue(row.SlotEndDateTime)
                    .EndRow();
            }
        }
    }

    private static void InsertGPDemographics(IReadOnlyCollection<GPDemographic> rows, DuckDBConnection connection)
    {
        using var appender = connection.CreateAppender("omop_staging", "oxford_gp_demographic");
        {
            foreach (var row in rows)
            {
                var dbRow = appender.CreateRow();

                dbRow
                    .AppendValue(row.PatientIdentifier)
                    .AppendValue(row.NHSNumber)
                    .AppendValue(row.Forename)
                    .AppendValue(row.Surname)
                    .AppendValue(row.DOB)
                    .AppendValue(row.Postcode)
                    .AppendValue(row.DateofDeath)
                    .EndRow();
            }
        }
    }

    private static void InsertGPEvents(IReadOnlyCollection<GPEvent> rows, DuckDBConnection connection)
    {
        using var appender = connection.CreateAppender("omop_staging", "oxford_gp_event");
        {
            foreach (var row in rows)
            {
                var dbRow = appender.CreateRow();

                dbRow
                    .AppendValue(row.GPEventsPrimaryKey)
                    .AppendValue(row.PatientIdentifier)
                    .AppendValue(row.GeneralPractitionerCode)
                    .AppendValue(row.RegisteredGP)
                    .AppendValue(row.GPPracticeCode)
                    .AppendValue(row.EventDate)
                    .AppendValue(row.SuppliedCode)
                    .AppendValue(row.CodeSet)
                    .AppendValue(row.EventDescription)
                    .AppendValue(row.Episodicity)
                    .AppendValue(row.Units)
                    .AppendValue(row.Value)
                    .AppendValue(row.SensitivityDormant)
                    .AppendValue(row.EventNo)
                    .AppendValue(row.AlternateReadEMISCode)
                    .AppendValue(row.JournalUpdateFlag)
                    .AppendValue(row.UpdateKey)
                    .AppendValue(row.UniqueKey)
                    .EndRow();
            }
        }
    }

    private static void InsertGPMedications(IReadOnlyCollection<GPMedication> rows, DuckDBConnection connection)
    {
        using var appender = connection.CreateAppender("omop_staging", "oxford_gp_medication");
        {
            foreach (var row in rows)
            {
                var dbRow = appender.CreateRow();

                dbRow
                    .AppendValue(row.GPMedicationsPrimaryKey)
                    .AppendValue(row.PatientIdentifier)
                    .AppendValue(row.GeneralPracticeCode)
                    .AppendValue(row.RegisteredGP)
                    .AppendValue(row.GPPracticeCode)
                    .AppendValue(row.SuppliedCode)
                    .AppendValue(row.CodeSet)
                    .AppendValue(row.MedicationDescription)
                    .AppendValue(row.Quantity)
                    .AppendValue(row.Dosage)
                    .AppendValue(row.LastIssueDate)
                    .AppendValue(row.MixtureID)
                    .AppendValue(row.Constituent)
                    .AppendValue(row.Units)
                    .AppendValue(row.RepeatMedicationFlag)
                    .AppendValue(row.MedicationNo)
                    .AppendValue(row.MaxIssues)
                    .AppendValue(row.UpdateKey)
                    .AppendValue(row.UniqueKey)
                    .AppendValue(row.AuthorisingUserDisplay)
                    .AppendValue(row.CourseLengthPerIssue)
                    .EndRow();
            }
        }
    }
}