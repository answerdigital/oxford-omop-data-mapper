using System.Data;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Data.SqlClient;

namespace OmopTransformer.SUS.Staging.Inpatient.CCMDS;

internal class SusCCMDSInserter : ISusCCMDSInserter
{
    private readonly Configuration _configuration;
    private readonly ILogger<SusCCMDSInserter> _logger;

    public SusCCMDSInserter(IOptions<Configuration> configuration, ILogger<SusCCMDSInserter> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task Insert(IEnumerable<CCMDSRecord> rows, CancellationToken cancellationToken)
    {
        if (rows == null) throw new ArgumentNullException(nameof(rows));

        _logger.LogInformation("Recording SUS rows.");

        var batches = rows.Batch(_configuration.BatchSize!.Value);
        int batchNumber = 1;

        var connection = RetryConnection.CreateSqlServer(_configuration.ConnectionString!);



        foreach (var batch in batches)
        {
            _logger.LogInformation("Batch {0}.", batchNumber++);

            await InsertBatch(batch, connection, cancellationToken);
        }
    }

    private async Task InsertBatch(IEnumerable<CCMDSRecord> rows, RetryConnection connection, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var rowsList = rows.ToList();

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting CCMDS.");
        await InsertCCMDS(rowsList.Select(row => row.Row).ToList(), connection);
        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting CCMDS CriticalCareActivityCode.");
        await InsertCriticalCareActivityCodes(rowsList.SelectMany(row => row.ActivityCodes).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation("Inserting CCMDS CriticalCareHighCostDrugs.");
        await InsertHighCostDrugs(rowsList.SelectMany(row => row.HighCostDrugs).ToList(), connection);

        cancellationToken.ThrowIfCancellationRequested();
    }

    private async Task InsertCCMDS(IReadOnlyCollection<CCMDSRow> rows, RetryConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("GeneratedRecordID");
        dataTable.Columns.Add("LoadStagingDate");
        dataTable.Columns.Add("CriticalCarePeriodSequenceNumber");
        dataTable.Columns.Add("CDSVersionontheepisodes");
        dataTable.Columns.Add("HESEPITYPEoftheepisode");
        dataTable.Columns.Add("CDSInterchangeID");
        dataTable.Columns.Add("HESEPISTAToftheepisode");
        dataTable.Columns.Add("EventDate");
        dataTable.Columns.Add("ActivityDateCriticalCare");
        dataTable.Columns.Add("CriticalCarePeriodType");
        dataTable.Columns.Add("CriticalCareEpisodeRelationship");
        dataTable.Columns.Add("CriticalCareUnitFunction");
        dataTable.Columns.Add("CriticalCareStartDate");
        dataTable.Columns.Add("CriticalCareStartTime");
        dataTable.Columns.Add("CriticalCarePeriodDischargeDate");
        dataTable.Columns.Add("CriticalCarePeriodDischargeTime");
        dataTable.Columns.Add("CriticalCarePeriodLocalIdentifier");
        dataTable.Columns.Add("GestationLengthAtDelivery");
        dataTable.Columns.Add("CriticalCareSequenceNumberDerived");
        dataTable.Columns.Add("TotalnumberofCriticalCareActivitiesDerived");
        dataTable.Columns.Add("LastRecordforthisCriticalCarePeriodIndicatorDerived");
        dataTable.Columns.Add("CriticalCareActivitytoEpisodeRelationshipDerived");
        dataTable.Columns.Add("PersonWeight");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.GeneratedRecordID,
                row.LoadStagingDate,
                row.CriticalCarePeriodSequenceNumber,
                row.CDSVersionontheepisodes,
                row.HESEPITYPEoftheepisode,
                row.CDSInterchangeID,
                row.HESEPISTAToftheepisode,
                row.EventDate,
                row.ActivityDateCriticalCare,
                row.CriticalCarePeriodType,
                row.CriticalCareEpisodeRelationship,
                row.CriticalCareUnitFunction,
                row.CriticalCareStartDate,
                row.CriticalCareStartTime,
                row.CriticalCarePeriodDischargeDate,
                row.CriticalCarePeriodDischargeTime,
                row.CriticalCarePeriodLocalIdentifier,
                row.GestationLengthAtDelivery,
                row.CriticalCareSequenceNumberDerived,
                row.TotalnumberofCriticalCareActivitiesDerived,
                row.LastRecordforthisCriticalCarePeriodIndicatorDerived,
                row.CriticalCareActivitytoEpisodeRelationshipDerived,
                row.PersonWeight
            );
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_CCMDS_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_CCMDS_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertHighCostDrugs(IReadOnlyCollection<CCMDSCriticalCareHighCostDrugs> rows, RetryConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("CriticalCareHighCostDrugs");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.CriticalCareHighCostDrugs);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_CCMDS_CriticalCareHighCostDrugs_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_CCMDS_CriticalCareHighCostDrugs_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }

    private async Task InsertCriticalCareActivityCodes(IReadOnlyCollection<CCMDSCriticalCareActivityCode> rows, RetryConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("MessageId");
        dataTable.Columns.Add("CriticalCareActivityCode");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.MessageId,
                row.CriticalCareActivityCode);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.sus_CCMDS_CriticalCareActivityCode_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_sus_CCMDS_CriticalCareActivityCode_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }
}