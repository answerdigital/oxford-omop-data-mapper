using Dapper;
using OmopTransformer.RTDS.Parser;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.RTDS.Staging;

internal class RtdsInserter : IRtdsInserter
{
    private readonly Configuration _configuration;
    private readonly ILogger<RtdsInserter> _logger;

    public RtdsInserter(IOptions<Configuration> configuration, ILogger<RtdsInserter> logger)
    {
        if (configuration == null) throw new ArgumentNullException(nameof(configuration));
        
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _configuration = configuration.Value;
    }
    
    public async Task Insert(RtdsRecords records, CancellationToken cancellationToken)
    {
        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        _logger.LogInformation("Inserting {0} Rtds Demographics.", records.Demographics.Count);
        await InsertRTDS_1_Demographics(records.Demographics, records.SourceFileName, connection, cancellationToken);

        _logger.LogInformation("Inserting {0} Rtds Attendances.", records.Attendances.Count);
        await InsertRTDS_2a_Attendances(records.Attendances, records.SourceFileName, connection, cancellationToken);

        _logger.LogInformation("Inserting {0} Rtds Plans.", records.Plans.Count);
        await InsertRTDS_2b_Plan(records.Plans, records.SourceFileName, connection, cancellationToken);

        _logger.LogInformation("Inserting {0} Rtds Prescriptions.", records.Prescriptions.Count);
        await InsertRTDS_3_Prescription(records.Prescriptions, records.SourceFileName, connection, cancellationToken);

        _logger.LogInformation("Inserting {0} Rtds Exposures.", records.Exposures.Count);
        await InsertRTDS_4_Exposures(records.Exposures, records.SourceFileName, connection, cancellationToken);

        _logger.LogInformation("Inserting {0} Rtds Diagnosis/Course.", records.Diagnoses_Courses.Count);
        await InsertRTDS_5_Diagnosis_Course(records.Diagnoses_Courses, records.SourceFileName, connection, cancellationToken);

        if (records.PasData != null)
        {
            _logger.LogInformation("Inserting {0} Rtds PassData.", records.PasData.Count);
            await InsertRTDS_PASDATA(records.PasData, records.SourceFileName, connection, cancellationToken);
        }
    }
    
    private async Task InsertRTDS_1_Demographics(IReadOnlyCollection<Rtds1Demographics> rows, string sourceFileName, IDbConnection connection, CancellationToken cancellationToken)
    {
        var batches = rows.Batch(1000);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("SourceFileName");
            dataTable.Columns.Add("PatientSer");
            dataTable.Columns.Add("PatientId");
            dataTable.Columns.Add("PatientId2");
            dataTable.Columns.Add("UniversalPatientId");
            dataTable.Columns.Add("SSN");
            dataTable.Columns.Add("FirstName");
            dataTable.Columns.Add("LastName");
            dataTable.Columns.Add("DateOfBirth");
            dataTable.Columns.Add("Sex");
            dataTable.Columns.Add("DoctorId");
            dataTable.Columns.Add("CourseSer");
            dataTable.Columns.Add("Expression1");
            dataTable.Columns.Add("StartDateTime");
            dataTable.Columns.Add("CompletedDateTime");
            dataTable.Columns.Add("End_date");
            dataTable.Columns.Add("Start_date");
                
            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    sourceFileName,
                    row.PatientSer,
                    row.PatientId,
                    row.PatientId2,
                    row.UniversalPatientId,
                    row.SSN,
                    row.FirstName,
                    row.LastName,
                    row.DateOfBirth,
                    row.Sex,
                    row.DoctorId,
                    row.CourseSer,
                    row.Expression1,
                    row.StartDateTime,
                    row.CompletedDateTime,
                    row.End_date,
                    row.Start_date);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[RTDS_1_Demographics_row]")
            };

            await connection
                .ExecuteAsync(
                    "omop_staging.insert_RTDS_1_Demographics",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertRTDS_2a_Attendances(IReadOnlyCollection<Rtds2AAttendances> rows, string sourceFileName, IDbConnection connection, CancellationToken cancellationToken)
    {
        var batches = rows.Batch(1000);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("SourceFileName");
            dataTable.Columns.Add("ScheduledActivitySer");
            dataTable.Columns.Add("ScheduledStartTime");
            dataTable.Columns.Add("AttributeValue");
            dataTable.Columns.Add("CourseSer");
            dataTable.Columns.Add("ProcedureCode");
            dataTable.Columns.Add("PatientSer");
            dataTable.Columns.Add("ScheduledActivityCode");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("ActualStartDateTime_s");
            dataTable.Columns.Add("ActualEndDateTime_s");
            dataTable.Columns.Add("Start_date");
            dataTable.Columns.Add("End_date");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    sourceFileName,
                    row.ScheduledActivitySer,
                    row.ScheduledStartTime,
                    row.AttributeValue,
                    row.CourseSer,
                    row.ProcedureCode,
                    row.PatientSer,
                    row.ScheduledActivityCode,
                    row.Description,
                    row.ActualStartDateTime_s,
                    row.ActualEndDateTime_s,
                    row.Start_date,
                    row.End_date);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[RTDS_2a_Attendances_row]")
            };

            await connection
                .ExecuteAsync(
                    "omop_staging.insert_RTDS_2a_Attendances",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertRTDS_2b_Plan(IReadOnlyCollection<Rtds2BPlan> rows, string sourceFileName, IDbConnection connection, CancellationToken cancellationToken)
    {
        var batches = rows.Batch(1000);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("SourceFileName");
            dataTable.Columns.Add("ProcedureCode");
            dataTable.Columns.Add("AttributeValue");
            dataTable.Columns.Add("PatientSer");
            dataTable.Columns.Add("DueDateTime");
            dataTable.Columns.Add("NonScheduledActivityCode");
            dataTable.Columns.Add("CourseSer");
            dataTable.Columns.Add("NonScheduledActivitySer");
            dataTable.Columns.Add("ActivityName");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Start_date");
            dataTable.Columns.Add("End_date");
            dataTable.Columns.Add("ProcedureCodeSer");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    sourceFileName,
                    row.ProcedureCode,
                    row.AttributeValue,
                    row.PatientSer,
                    row.DueDateTime,
                    row.NonScheduledActivityCode,
                    row.CourseSer,
                    row.NonScheduledActivitySer,
                    row.ActivityName,
                    row.Description,
                    row.Start_date,
                    row.End_date,
                    row.ProcedureCodeSer);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[RTDS_2b_Plan_row]")
            };

            await connection
                .ExecuteAsync(
                    "omop_staging.insert_RTDS_2b_Plan",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }
    
    private async Task InsertRTDS_3_Prescription(IReadOnlyCollection<Rtds3Prescription> rows, string sourceFileName, IDbConnection connection, CancellationToken cancellationToken)
    {
        var batches = rows.Batch(1000);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("SourceFileName");
            dataTable.Columns.Add("PatientSer");
            dataTable.Columns.Add("CourseSer");
            dataTable.Columns.Add("TreatmentType");
            dataTable.Columns.Add("NoFields");
            dataTable.Columns.Add("PreDescribedDose");
            dataTable.Columns.Add("PlanSetupSer");
            dataTable.Columns.Add("StartDateTime");
            dataTable.Columns.Add("TotDeliveredActualDose");
            dataTable.Columns.Add("NoFracs");
            dataTable.Columns.Add("PlanNameUpper");
            dataTable.Columns.Add("Start_date");
            dataTable.Columns.Add("End_date");
            dataTable.Columns.Add("Expression1");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    sourceFileName,
                    row.PatientSer,
                    row.CourseSer,
                    row.TreatmentType,
                    row.NoFields,
                    row.PreDescribedDose,
                    row.PlanSetupSer,
                    row.StartDateTime,
                    row.TotDeliveredActualDose,
                    row.NoFracs,
                    row.PlanNameUpper,
                    row.Start_date,
                    row.End_date,
                    row.Expression1);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[RTDS_3_Prescription_row]")
            };

            await connection
                .ExecuteAsync(
                    "omop_staging.insert_RTDS_3_Prescription",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertRTDS_4_Exposures(IReadOnlyCollection<Rtds4Exposures> rows, string sourceFileName, IDbConnection connection, CancellationToken cancellationToken)
    {
        var batches = rows.Batch(1000);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("SourceFileName");
            dataTable.Columns.Add("PatientSer");
            dataTable.Columns.Add("CourseSer");
            dataTable.Columns.Add("RadiationSer");
            dataTable.Columns.Add("NominalEnergy");
            dataTable.Columns.Add("RadiationType");
            dataTable.Columns.Add("PlanSetupSer");
            dataTable.Columns.Add("EventNumber");
            dataTable.Columns.Add("MachineId");
            dataTable.Columns.Add("PlanName");
            dataTable.Columns.Add("Start_date");
            dataTable.Columns.Add("End_date");
            dataTable.Columns.Add("TreatmentDateTime");
            dataTable.Columns.Add("storedprocedure_version");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    sourceFileName,
                    row.PatientSer,
                    row.CourseSer,
                    row.RadiationSer,
                    row.NominalEnergy,
                    row.RadiationType,
                    row.PlanSetupSer,
                    row.EventNumber,
                    row.MachineId,
                    row.PlanName,
                    row.Start_date,
                    row.End_date,
                    row.TreatmentDateTime,
                    row.storedprocedure_version);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[RTDS_4_Exposures_row]")
            };

            await connection
                .ExecuteAsync(
                    "omop_staging.insert_RTDS_4_Exposures",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertRTDS_5_Diagnosis_Course(IReadOnlyCollection<Rtds5DiagnosisCourse> rows, string sourceFileName, IDbConnection connection, CancellationToken cancellationToken)
    {
        var batches = rows.Batch(1000);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("SourceFileName");
            dataTable.Columns.Add("PatientSer");
            dataTable.Columns.Add("CourseSer");
            dataTable.Columns.Add("DateStamp");
            dataTable.Columns.Add("DiagnosisCode");
            dataTable.Columns.Add("DiagnosisTableName");
            dataTable.Columns.Add("DiagnosisType");
            dataTable.Columns.Add("End_date");
            dataTable.Columns.Add("Start_date");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    sourceFileName,
                    row.PatientSer,
                    row.CourseSer,
                    row.DateStamp,
                    row.DiagnosisCode,
                    row.DiagnosisTableName,
                    row.DiagnosisType,
                    row.End_date,
                    row.Start_date);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[RTDS_5_Diagnosis_Course_row]")
            };

            await connection
                .ExecuteAsync(
                    "omop_staging.insert_RTDS_5_Diagnosis_Course",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }

    private async Task InsertRTDS_PASDATA(IReadOnlyCollection<RtdsPasData> rows, string sourceFileName, IDbConnection connection, CancellationToken cancellationToken)
    {
        var batches = rows.Batch(1000);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("SourceFileName");
            dataTable.Columns.Add("Expr1");
            dataTable.Columns.Add("Expr2");
            dataTable.Columns.Add("Expr3");
            dataTable.Columns.Add("Expr4");
            dataTable.Columns.Add("Expr5");
            dataTable.Columns.Add("Expr6");
            dataTable.Columns.Add("PatientID2");
            dataTable.Columns.Add("FirstOfNHSNUMBER");
            dataTable.Columns.Add("NHSNUMBERTRACESTATUS");
            dataTable.Columns.Add("Expr7");
            dataTable.Columns.Add("Expr8");
            dataTable.Columns.Add("FirstOfPOSTCODE");
            dataTable.Columns.Add("Expr9");
            dataTable.Columns.Add("BIRTHDATE");
            dataTable.Columns.Add("GENDER");
            dataTable.Columns.Add("Expr10");
            dataTable.Columns.Add("Expr11");
            dataTable.Columns.Add("Expr12");
            dataTable.Columns.Add("Expr13");
            dataTable.Columns.Add("Expr14");
            dataTable.Columns.Add("FirstOfGPNATIONALCODE");
            dataTable.Columns.Add("FirstOfPRACTICECODE");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    sourceFileName,
                    row.Expr1,
                    row.Expr2,
                    row.Expr3,
                    row.Expr4,
                    row.Expr5,
                    row.Expr6,
                    row.PatientID2,
                    row.FirstOfNHSNUMBER,
                    row.NHSNUMBERTRACESTATUS,
                    row.Expr7,
                    row.Expr8,
                    row.FirstOfPOSTCODE,
                    row.Expr9,
                    row.BIRTHDATE,
                    row.GENDER,
                    row.Expr10,
                    row.Expr11,
                    row.Expr12,
                    row.Expr13,
                    row.Expr14,
                    row.FirstOfGPNATIONALCODE,
                    row.FirstOfPRACTICECODE);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("[omop_staging].[RTDS_PASDATA_row]")
            };

            await connection
                .ExecuteAsync(
                    "omop_staging.insert_RTDS_PASDATA",
                    parameter,
                    commandType: CommandType.StoredProcedure);
        }
    }
}