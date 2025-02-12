using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.Inpatient.CCMDS;

internal class SusCCMDSStaging : ISusCCMDSStaging
{
    private readonly ILogger<SusCCMDSStaging> _logger;
    private readonly StagingOptions _options;
    private readonly ISusCCMDSInserter _susInserter;
    private readonly ISusCCMDSParser _parser;

    public SusCCMDSStaging(ILogger<SusCCMDSStaging> logger, StagingOptions options, ISusCCMDSInserter susInserter, ISusCCMDSParser parser)
    {
        _logger = logger;
        _options = options;
        _susInserter = susInserter;
        _parser = parser;
    }

    public async Task StageData(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Staging CCMDS SUS data.");

        if (!File.Exists(_options.FileName))
        {
            _logger.LogError("File does not exist or is inaccessible. {0}", _options.FileName);
            Environment.ExitCode = (int)ExitCodes.FileDoesNotExist;
            return;
        }

        _logger.LogInformation("Reading {0}", _options.FileName);

        IEnumerable<CCMDSRecord> records = _parser.ReadFile(_options.FileName, cancellationToken);

        _logger.LogInformation("Streaming records...");

        await _susInserter.Insert(records, cancellationToken);

        _logger.LogInformation("Staging complete.");
    }
}