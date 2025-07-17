using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.OxfordPrescribing.Staging;

internal class OxfordPrescribingRecordInserter : IOxfordPrescribingRecordInserter
{
    private readonly Configuration _configuration;
    private readonly ILogger<OxfordPrescribingRecordInserter> _logger;

    public OxfordPrescribingRecordInserter(IOptions<Configuration> configuration, ILogger<OxfordPrescribingRecordInserter> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task Insert(IEnumerable<OxfordPrescribingRecord> rows, CancellationToken cancellationToken)
    {
        if (rows == null) throw new ArgumentNullException(nameof(rows));

        _logger.LogInformation("Recording PrescribingRecord rows.");

        var batches = rows.Batch(_configuration.BatchSize!.Value);
        int batchNumber = 1;

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        foreach (var batch in batches)
        {
            _logger.LogInformation("Batch {0}.", batchNumber++);

            await InsertPrescribingRecord(batch.ToList(), connection);

            cancellationToken.ThrowIfCancellationRequested();
        }
    }

    private async Task InsertPrescribingRecord(IReadOnlyCollection<OxfordPrescribingRecord> rows, IDbConnection connection)
    {
        var dataTable = new DataTable();

        dataTable.Columns.Add("patient_identifier_value");
        dataTable.Columns.Add("EVENT_ID");
        dataTable.Columns.Add("WAREHOUSE_IDENTIFIER");
        dataTable.Columns.Add("ORDER_ID");
        dataTable.Columns.Add("BEG_DT_TM");
        dataTable.Columns.Add("END_DT_TM");
        dataTable.Columns.Add("SCHEDULED_DT_TM");
        dataTable.Columns.Add("VERIFICATION_DT_TM");
        dataTable.Columns.Add("UPDT_DT_TM");
        dataTable.Columns.Add("CURRENT_START_DT_TM");
        dataTable.Columns.Add("PROJECTED_STOP_DT_TM");
        dataTable.Columns.Add("MED_ADMIN_EVENT_ID");
        dataTable.Columns.Add("EVENT_TYPE_DISPLAY");
        dataTable.Columns.Add("REFERENCESTARTDTTM");
        dataTable.Columns.Add("STRENGTHDOSE");
        dataTable.Columns.Add("DIFFINMIN");
        dataTable.Columns.Add("CONSTANTIND");
        dataTable.Columns.Add("RXPRIORITY");
        dataTable.Columns.Add("PHARMORDERTYPE");
        dataTable.Columns.Add("ADHOCFREQINSTANCE");
        dataTable.Columns.Add("FREQSCHEDID");
        dataTable.Columns.Add("WEIGHT");
        dataTable.Columns.Add("DRUGFORM");
        dataTable.Columns.Add("REQSTARTDTTM");
        dataTable.Columns.Add("STRENGTHDOSEUNIT");
        dataTable.Columns.Add("RXROUTE");
        dataTable.Columns.Add("CATALOG_CD");
        dataTable.Columns.Add("CATALOG");
        dataTable.Columns.Add("ORDER_MNEMONIC");
        dataTable.Columns.Add("ORDER_DETAIL_DISPLAY_LINE");
        dataTable.Columns.Add("DEPT_MISC_LINE");
        dataTable.Columns.Add("concept_identifier");
        dataTable.Columns.Add("concept_name");
        dataTable.Columns.Add("CONCEPT_CKI");
        dataTable.Columns.Add("cki");

        foreach (var row in rows)
        {
            dataTable.Rows.Add(
                row.patient_identifier_value,
                row.EVENT_ID,
                row.WAREHOUSE_IDENTIFIER,
                row.ORDER_ID,
                row.BEG_DT_TM,
                row.END_DT_TM,
                row.SCHEDULED_DT_TM,
                row.VERIFICATION_DT_TM,
                row.UPDT_DT_TM,
                row.CURRENT_START_DT_TM,
                row.PROJECTED_STOP_DT_TM,
                row.MED_ADMIN_EVENT_ID,
                row.EVENT_TYPE_DISPLAY,
                row.REFERENCESTARTDTTM,
                row.STRENGTHDOSE,
                row.DIFFINMIN,
                row.CONSTANTIND,
                row.RXPRIORITY,
                row.PHARMORDERTYPE,
                row.ADHOCFREQINSTANCE,
                row.FREQSCHEDID,
                row.WEIGHT,
                row.DRUGFORM,
                row.REQSTARTDTTM,
                row.STRENGTHDOSEUNIT,
                row.RXROUTE,
                row.CATALOG_CD,
                row.CATALOG,
                row.ORDER_MNEMONIC,
                row.ORDER_DETAIL_DISPLAY_LINE,
                row.DEPT_MISC_LINE,
                row.concept_identifier,
                row.concept_name,
                row.CONCEPT_CKI,
                row.cki);
        }

        var parameter = new
        {
            Rows = dataTable.AsTableValuedParameter("omop_staging.oxford_prescribing_row")
        };

        await connection
            .ExecuteLongTimeoutAsync(
                "omop_staging.insert_oxford_prescribing_row",
                parameter,
                commandType: CommandType.StoredProcedure);
    }
}