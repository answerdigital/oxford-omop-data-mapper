using System.Data;
using System.Diagnostics;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.Location;

internal class LocationRecorder : ILocationRecorder
{
    private readonly Configuration _configuration;
    private readonly ILogger<LocationRecorder> _logger;

    public LocationRecorder(IOptions<Configuration> configuration, ILogger<LocationRecorder> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateLocations<T>(IReadOnlyCollection<OmopLocation<T>> locations, CancellationToken cancellationToken)
    {
        if (locations == null) throw new ArgumentNullException(nameof(locations));

        _logger.LogInformation("Recording {0} locations.", locations.Count);

        var stopwatch = Stopwatch.StartNew();

        await using var connection = new SqlConnection(_configuration.OmopConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = locations.Batch(1000);
        foreach (var batch in batches)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("address_1");
            dataTable.Columns.Add("address_2");
            dataTable.Columns.Add("city");
            dataTable.Columns.Add("state");
            dataTable.Columns.Add("zip");
            dataTable.Columns.Add("county");
            dataTable.Columns.Add("location_source_value");
            dataTable.Columns.Add("country_concept_id");
            dataTable.Columns.Add("country_source_value");
            dataTable.Columns.Add("latitude");
            dataTable.Columns.Add("longitude");

            foreach (var omopLocation in batch)
            {
                dataTable.Rows.Add(
                    omopLocation.address_1,
                    omopLocation.address_2,
                    omopLocation.city,
                    omopLocation.state,
                    omopLocation.zip,
                    omopLocation.county,
                    omopLocation.location_source_value,
                    omopLocation.country_concept_id,
                    omopLocation.country_source_value,
                    omopLocation.latitude,
                    omopLocation.longitude);
            }

            var parameter = new
            {
                Locations = dataTable.AsTableValuedParameter("cdm.[Location]")
            };

            await connection.ExecuteAsync("cdm.InsertUpdateLocation", parameter, commandType: CommandType.StoredProcedure);
        }

        stopwatch.Stop();

        _logger.LogTrace("Inserting locations took {0}ms.", stopwatch.ElapsedMilliseconds);

    }
}