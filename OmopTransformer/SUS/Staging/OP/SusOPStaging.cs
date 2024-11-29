using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.OP;

internal class SusOPStaging : ISusOPStaging
{
    private readonly ILogger<SusOPStaging> _logger;
    private readonly StagingOptions _options;
    private readonly ISusOPInserter _susInserter;
    private readonly ISusOPParser _parser;

    public SusOPStaging(ILogger<SusOPStaging> logger, StagingOptions options, ISusOPInserter susInserter, ISusOPParser parser)
    {
        _logger = logger;
        _options = options;
        _susInserter = susInserter;
        _parser = parser;
    }

    public async Task StageData(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Staging OP SUS data.");

        if (!File.Exists(_options.FileName))
        {
            _logger.LogError("File does not exist or is inaccessible. {0}", _options.FileName);
            Environment.ExitCode = (int)ExitCodes.FileDoesNotExist;
            return;
        }

        _logger.LogInformation("Reading {0}", _options.FileName);

        IEnumerable<OPRecord> records = _parser.ReadFile(_options.FileName, cancellationToken);

        _logger.LogInformation("Streaming records...");

        await _susInserter.Insert(records, cancellationToken);

        _logger.LogInformation("Staging complete.");
    }
}