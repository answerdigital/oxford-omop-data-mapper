using Microsoft.Extensions.Logging;
using OmopTransformer.SUS.Staging.Inpatient.APC;
using OmopTransformer.SUS.Staging.Inpatient.CCMDS;

namespace OmopTransformer.SUS.Staging.Inpatient;

internal class SusInpatientStaging : ISusInpatientStaging
{
    private readonly ILogger<SusInpatientStaging> _logger;
    private readonly StagingOptions _options;
    private readonly ISusAPCInserter _susApcInserter;
    private readonly ISusAPCParser _susApcParser;
    private readonly ISusCCMDSInserter _susCCMDSInserter;
    private readonly ISusCCMDSParser _susCCMDSParser;

    public SusInpatientStaging(
        ILogger<SusInpatientStaging> logger, 
        StagingOptions options, 
        ISusAPCInserter susApcInserter, 
        ISusAPCParser susApcParser, 
        ISusCCMDSInserter susCcmdsInserter, 
        ISusCCMDSParser susCcmdsParser)
    {
        _logger = logger;
        _options = options;
        _susApcInserter = susApcInserter;
        _susApcParser = susApcParser;
        _susCCMDSInserter = susCcmdsInserter;
        _susCCMDSParser = susCcmdsParser;
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

        IEnumerable<APCRecord> records = _susApcParser.ReadFile(_options.FileName, cancellationToken);

        _logger.LogInformation("Streaming records...");

        await _susApcInserter.Insert(records, cancellationToken);

        _logger.LogInformation("Staging complete.");

        if (_options.CCMDSFileName == null)
        {
            _logger.LogWarning("Pairing CCMDS file was not specified.");
            return;
        }

        _logger.LogInformation("Staging CCMDS SUS data.");

        if (!File.Exists(_options.CCMDSFileName))
        {
            _logger.LogError("File does not exist or is inaccessible. {0}", _options.CCMDSFileName);
            Environment.ExitCode = (int)ExitCodes.FileDoesNotExist;
            return;
        }

        _logger.LogInformation("Reading {0}", _options.CCMDSFileName);

        IEnumerable<CCMDSRecord> ccmds = _susCCMDSParser.ReadFile(_options.CCMDSFileName, cancellationToken);

        _logger.LogInformation("Streaming records...");

        await _susCCMDSInserter.Insert(ccmds, cancellationToken);

        _logger.LogInformation("Staging complete.");
    }
}