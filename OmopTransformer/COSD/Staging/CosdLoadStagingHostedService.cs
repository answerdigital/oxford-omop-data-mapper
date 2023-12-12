using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.COSD.Staging;

internal class CosdLoadStagingHostedService : FinalHostedService
{
    private readonly ICosdStaging _cosdStaging;

    public CosdLoadStagingHostedService(IHostApplicationLifetime appLifetime, ICosdStaging cosdStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _cosdStaging = cosdStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _cosdStaging.StageData(cancellationToken);
    }
}