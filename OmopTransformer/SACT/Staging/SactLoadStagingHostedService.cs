using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SACT.Staging;

internal class SactLoadStagingHostedService : FinalHostedService
{
    private readonly ISactStaging _sactStaging;

    public SactLoadStagingHostedService(IHostApplicationLifetime appLifetime, ISactStaging sactStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _sactStaging = sactStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _sactStaging.StageData(cancellationToken);
    }
}