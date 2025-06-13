using Microsoft.Extensions.Logging;

namespace OmopTransformer.OxfordGP.Staging;

internal class OxfordGPStaging : IOxfordGPStaging
{
    private readonly ILogger<OxfordGPStaging> _logger;
    private readonly StagingOptions _options;
    private readonly IOxfordGPRecordInserter _inserter;
    private readonly IOxfordGPParser _parser;

    public OxfordGPStaging(
        ILogger<OxfordGPStaging> logger, 
        StagingOptions options,
        IOxfordGPRecordInserter inserter,
        IOxfordGPParser parser)
    {
        _logger = logger;
        _options = options;
        _inserter = inserter;
        _parser = parser;
    }

    public async Task StageData(CancellationToken cancellationToken)
    {

        _logger.LogInformation("Staging GP data.");

        if (FileDoesNotExist(_options.Demographics) || FileDoesNotExist(_options.Appointments) || FileDoesNotExist(_options.Events) || FileDoesNotExist(_options.Medications))
            return;

        _logger.LogInformation("Streaming records...");

        var gpRecord = 
            new GPRecord
            {
                Appointments = _parser.ReadAppointmentFile(_options.Appointments!, cancellationToken),
                Demographics = _parser.ReadDemographicFile(_options.Demographics!, cancellationToken),
                Events = _parser.ReadEventFile(_options.Events!, cancellationToken),
                Medications = _parser.ReadMedicationFile(_options.Medications!, cancellationToken)
            };

        await _inserter.Insert(gpRecord, cancellationToken);

        _logger.LogInformation("Staging complete.");
    }

    private bool FileDoesNotExist(string? path)
    {
        if (!File.Exists(path))
        {
            _logger.LogError("File does not exist or is inaccessible. {0}", path);
            Environment.ExitCode = (int)ExitCodes.FileDoesNotExist;

            return true;
        }

        return false;
    }
}