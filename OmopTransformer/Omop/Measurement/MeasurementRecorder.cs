﻿using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.Measurement;

internal class MeasurementRecorder : IMeasurementRecorder
{
    private readonly Configuration _configuration;

    public MeasurementRecorder(IOptions<Configuration> configuration)
    {
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateMeasurements<T>(IReadOnlyCollection<OmopMeasurement<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = records.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("nhs_number", typeof(string));
            dataTable.Columns.Add("measurement_concept_id", typeof(int));
            dataTable.Columns.Add("measurement_date", typeof(DateTime));
            dataTable.Columns.Add("measurement_datetime", typeof(DateTime));
            dataTable.Columns.Add("measurement_time", typeof(DateTime));
            dataTable.Columns.Add("measurement_type_concept_id", typeof(int));
            dataTable.Columns.Add("operator_concept_id", typeof(int));
            dataTable.Columns.Add("value_as_number", typeof(double));
            dataTable.Columns.Add("value_as_concept_id", typeof(int));
            dataTable.Columns.Add("unit_concept_id", typeof(int));
            dataTable.Columns.Add("range_low", typeof(double));
            dataTable.Columns.Add("range_high", typeof(double));
            dataTable.Columns.Add("provider_id", typeof(int));
            dataTable.Columns.Add("measurement_source_value", typeof(string));
            dataTable.Columns.Add("measurement_source_concept_id", typeof(int));
            dataTable.Columns.Add("unit_source_value", typeof(string));
            dataTable.Columns.Add("unit_source_concept_id", typeof(int));
            dataTable.Columns.Add("value_source_value", typeof(string));
            dataTable.Columns.Add("measurement_event_id", typeof(int));
            dataTable.Columns.Add("meas_event_field_concept_id", typeof(int));
            dataTable.Columns.Add("RecordConnectionIdentifier", typeof(string));
            dataTable.Columns.Add("HospitalProviderSpellNumber", typeof(string));

            foreach (var record in batch)
            {
                if (record.IsValid == false)
                    continue;

                foreach (var conceptId in record.measurement_concept_id!)
                {
                    dataTable.Rows.Add(
                        record.nhs_number,
                        conceptId,
                        record.measurement_date,
                        record.measurement_datetime,
                        record.measurement_time,
                        record.measurement_type_concept_id,
                        record.operator_concept_id,
                        record.value_as_number,
                        record.value_as_concept_id,
                        record.unit_concept_id,
                        record.range_low,
                        record.range_high,
                        record.provider_id,
                        record.measurement_source_value,
                        record.measurement_source_concept_id,
                        record.unit_source_value,
                        record.unit_source_concept_id,
                        record.value_source_value,
                        record.measurement_event_id,
                        record.meas_event_field_concept_id,
                        record.RecordConnectionIdentifier,
                        record.HospitalProviderSpellNumber);
                }
            }

            var parameter = new
            {
                @rows = dataTable.AsTableValuedParameter("cdm.measurement_row"),
                DataSource = dataSource
            };

            await connection.ExecuteLongTimeoutAsync("cdm.insert_update_measurement", parameter, commandType: CommandType.StoredProcedure);
        }
    }
}