﻿using System.IO.Compression;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.COSD;

internal class CosdStaging : ICosdStaging
{
    private readonly ILogger<CosdStaging> _logger;
    private readonly StagingOptions _options;
    private readonly Configuration _configuration;

    public CosdStaging(ILogger<CosdStaging> logger, StagingOptions options, IOptions<Configuration> configuration)
    {
        _logger = logger;
        _options = options;
        _configuration = configuration.Value;
    }

    public async Task StageData(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Staging COSD data.");

        if (!File.Exists(_options.FileName))
        {
            _logger.LogError("File does not exist or is inaccessible. {0}", _options.FileName);
            Environment.ExitCode = (int)ExitCodes.FileDoesNotExist;
            return;
        }

        var connection = new SqlConnection(_configuration.StagingConnectionString);
        await connection.OpenAsync(cancellationToken);

        using var archive = ZipFile.OpenRead(_options.FileName);

        _logger.LogInformation("Found {0} entries.", archive.Entries.Count);

        foreach (var entry in archive.Entries)
        {
            cancellationToken.ThrowIfCancellationRequested();

            await using var stream = entry.Open();
            using var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream, cancellationToken);
                
            _logger.LogInformation("Staging {0}.", entry.Name);

            await connection
                .ExecuteAsync(
                    "insert into cosd_staging values (@SubmissionName, @FileName, @Content)",
                    param:
                    new
                    {
                        SubmissionName = Path.GetFileName(_options.FileName),
                        FileName = entry.Name,
                        Content = memoryStream.ToArray()
                    });
        }

        _logger.LogInformation("Staging complete.");
    }
}