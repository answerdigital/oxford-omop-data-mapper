using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.DeviceExposure;

internal class DeviceExposureRecorder : IDeviceExposureRecorder
{
    private readonly Configuration _configuration;
    private readonly ILogger<DeviceExposureRecorder> _logger;

    public DeviceExposureRecorder(IOptions<Configuration> configuration, ILogger<DeviceExposureRecorder> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateDeviceExposure<T>(IReadOnlyCollection<OmopDeviceExposure<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        _logger.LogInformation("Recording {0} Device Exposure(s).", records.Count);
        Logger.LogNonValid(_logger, records);

        var batchLogger = new BatchTimingLogger<DeviceExposureRecorder>(_configuration.BatchSize!.Value, records.Count, "device exposure", _logger);

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = records.Batch(_configuration.BatchSize.Value);
        foreach (var batch in batches)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("nhs_number");
            dataTable.Columns.Add("device_concept_id");
            dataTable.Columns.Add("device_exposure_start_date", typeof(DateTime));
            dataTable.Columns.Add("device_exposure_start_datetime", typeof(DateTime));
            dataTable.Columns.Add("device_exposure_end_date", typeof(DateTime));
            dataTable.Columns.Add("device_exposure_end_datetime", typeof(DateTime));
            dataTable.Columns.Add("device_type_concept_id");
            dataTable.Columns.Add("unique_device_id");
            dataTable.Columns.Add("production_id");
            dataTable.Columns.Add("quantity");
            dataTable.Columns.Add("provider_id");
            dataTable.Columns.Add("visit_occurrence_id");
            dataTable.Columns.Add("visit_detail_id");
            dataTable.Columns.Add("device_source_value");
            dataTable.Columns.Add("device_source_concept_id");
            dataTable.Columns.Add("unit_concept_id");
            dataTable.Columns.Add("unit_source_value");
            dataTable.Columns.Add("unit_source_concept_id");
            dataTable.Columns.Add("RecordConnectionIdentifier");

            foreach (var record in batch)
            {
                if (record.IsValid == false)
                    continue;

                dataTable.Rows.Add(
                    record.nhs_number,
                    record.device_concept_id,
                    record.device_exposure_start_date,
                    record.device_exposure_start_datetime,
                    record.device_exposure_end_date,
                    record.device_exposure_end_datetime,
                    record.device_type_concept_id,
                    record.unique_device_id,
                    record.production_id,
                    record.quantity,
                    record.provider_id,
                    record.visit_occurrence_id,
                    record.visit_detail_id,
                    record.device_source_value,
                    record.device_source_concept_id,
                    record.unit_concept_id,
                    record.unit_source_value,
                    record.unit_source_concept_id,
                    record.RecordConnectionIdentifier);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("cdm.device_exposure_row"),
                DataSource = dataSource
            };

            await connection.ExecuteLongTimeoutAsync("cdm.insert_update_device_exposure", parameter, commandType: CommandType.StoredProcedure);

            batchLogger.LogNext();
        }

        batchLogger.LogSummary();

    }
}