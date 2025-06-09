using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.OxfordPrescribing.Staging;

internal class OxfordPrescribingLoadStagingHostedService : FinalHostedService
{
    private readonly IOxfordPrescribingStaging _oxfordPrescribingStaging;

    public OxfordPrescribingLoadStagingHostedService(IHostApplicationLifetime appLifetime, IOxfordPrescribingStaging oxfordPrescribingStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _oxfordPrescribingStaging = oxfordPrescribingStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _oxfordPrescribingStaging.StageData(cancellationToken);
    }
}