using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging;

internal class SusLoadStagingHostedService : FinalHostedService
{
    private readonly ISusStaging _susStaging;

    public SusLoadStagingHostedService(IHostApplicationLifetime appLifetime, ISusStaging susStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _susStaging = susStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _susStaging.StageData(cancellationToken);
    }
}