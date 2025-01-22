using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.AE;

internal class SusAELoadStagingHostedService : FinalHostedService
{
    private readonly ISusAEStaging _susAEStaging;

    public SusAELoadStagingHostedService(IHostApplicationLifetime appLifetime, ISusAEStaging susStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _susAEStaging = susStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _susAEStaging.StageData(cancellationToken);
    }
}