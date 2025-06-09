using Microsoft.Extensions.Logging;

namespace OmopTransformer.OxfordPrescribing.Staging;

internal class OxfordPrescribingStaging : IOxfordPrescribingStaging
{
    private readonly ILogger<OxfordPrescribingStaging> _logger;
    private readonly StagingOptions _options;
    private readonly IOxfordPrescribingRecordInserter _inserter;
    private readonly IOxfordPrescribingRecordParser _parser;

    public OxfordPrescribingStaging(
        ILogger<OxfordPrescribingStaging> logger, 
        StagingOptions options,
        IOxfordPrescribingRecordInserter inserter, 
        IOxfordPrescribingRecordParser parser)
    {
        _logger = logger;
        _options = options;
        _inserter = inserter;
        _parser = parser;
    }

    public async Task StageData(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Staging Prescribing data.");

        if (!File.Exists(_options.FileName))
        {
            _logger.LogError("File does not exist or is inaccessible. {0}", _options.FileName);
            Environment.ExitCode = (int)ExitCodes.FileDoesNotExist;
            return;
        }

        _logger.LogInformation("Reading {0}", _options.FileName);

        IEnumerable<OxfordPrescribingRecord> records = _parser.ReadFile(_options.FileName, cancellationToken);

        _logger.LogInformation("Streaming records...");

        await _inserter.Insert(records, cancellationToken);

        _logger.LogInformation("Staging complete.");
    }
}