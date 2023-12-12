using System.Diagnostics;
using Microsoft.Extensions.Logging;
using OmopTransformer.CDS.Parser;

namespace OmopTransformer.CDS.Staging;

internal class CdsStaging : ICdsStaging
{
    private readonly ILogger<CdsStaging> _logger;
    private readonly StagingOptions _options;
    private readonly ICdsInserter _cdsInserter;
    private readonly ICdsNhs62Parser _cdsParser;

    public CdsStaging(ILogger<CdsStaging> logger, StagingOptions options, ICdsInserter cdsInserter, ICdsNhs62Parser cdsParser)
    {
        _logger = logger;
        _options = options;
        _cdsInserter = cdsInserter;
        _cdsParser = cdsParser;
    }

    public async Task StageData(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Staging Cds data.");

        if (!File.Exists(_options.FileName))
        {
            _logger.LogError("File does not exist or is inaccessible. {0}", _options.FileName);
            Environment.ExitCode = (int)ExitCodes.FileDoesNotExist;
            return;
        }

        _logger.LogInformation("Reading {0}", _options.FileName);

        Stopwatch stopwatch = Stopwatch.StartNew();

        var records = _cdsParser.ReadFile(_options.FileName, cancellationToken);

        stopwatch.Stop();

        _logger.LogInformation("{0} records read in {1}ms.", records.Count, stopwatch.ElapsedMilliseconds);

        await _cdsInserter.Insert(records, cancellationToken);

        _logger.LogInformation("Staging complete.");
    }
}