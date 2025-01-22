using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.AE;

internal class SusAEStaging : ISusAEStaging
{
    private readonly ILogger<SusAEStaging> _logger;
    private readonly StagingOptions _options;
    private readonly ISusAEInserter _susInserter;
    private readonly ISusAEParser _parser;

    public SusAEStaging(ILogger<SusAEStaging> logger, StagingOptions options, ISusAEInserter susInserter, ISusAEParser parser)
    {
        _logger = logger;
        _options = options;
        _susInserter = susInserter;
        _parser = parser;
    }

    public async Task StageData(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Staging AE SUS data.");

        if (!File.Exists(_options.FileName))
        {
            _logger.LogError("File does not exist or is inaccessible. {0}", _options.FileName);
            Environment.ExitCode = (int)ExitCodes.FileDoesNotExist;
            return;
        }

        _logger.LogInformation("Reading {0}", _options.FileName);

        IEnumerable<AERecord> records = _parser.ReadFile(_options.FileName, cancellationToken);

        _logger.LogInformation("Streaming records...");

        await _susInserter.Insert(records, cancellationToken);

        _logger.LogInformation("Staging complete.");
    }
}