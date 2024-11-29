using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.APC;

internal class SusAPCLoadStagingHostedService : FinalHostedService
{
    private readonly ISusApcStaging _susApcStaging;

    public SusAPCLoadStagingHostedService(IHostApplicationLifetime appLifetime, ISusApcStaging susApcStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _susApcStaging = susApcStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _susApcStaging.StageData(cancellationToken);
    }
}