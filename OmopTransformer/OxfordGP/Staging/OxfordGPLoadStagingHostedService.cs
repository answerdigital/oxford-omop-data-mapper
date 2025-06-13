using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.OxfordGP.Staging;

internal class OxfordGPLoadStagingHostedService : FinalHostedService
{
    private readonly IOxfordGPStaging _oxfordGpStaging;

    public OxfordGPLoadStagingHostedService(IHostApplicationLifetime appLifetime, IOxfordGPStaging OxfordGPStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _oxfordGpStaging = OxfordGPStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _oxfordGpStaging.StageData(cancellationToken);
    }
}