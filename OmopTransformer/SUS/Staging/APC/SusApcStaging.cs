using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.APC;

internal class SusApcStaging : ISusApcStaging
{
    private readonly ILogger<SusApcStaging> _logger;
    private readonly StagingOptions _options;
    private readonly ISusAPCInserter _susInserter;
    private readonly ISusAPCParser _parser;

    public SusApcStaging(ILogger<SusApcStaging> logger, StagingOptions options, ISusAPCInserter susInserter, ISusAPCParser parser)
    {
        _logger = logger;
        _options = options;
        _susInserter = susInserter;
        _parser = parser;
    }

    public async Task StageData(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Staging APC SUS data.");

        if (!File.Exists(_options.FileName))
        {
            _logger.LogError("File does not exist or is inaccessible. {0}", _options.FileName);
            Environment.ExitCode = (int)ExitCodes.FileDoesNotExist;
            return;
        }

        _logger.LogInformation("Reading {0}", _options.FileName);

        IEnumerable<APCRecord> records = _parser.ReadFile(_options.FileName, cancellationToken);

        _logger.LogInformation("Streaming records...");

        await _susInserter.Insert(records, cancellationToken);

        _logger.LogInformation("Staging complete.");
    }
}