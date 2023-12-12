using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.CDS.Staging;

internal class CdsLoadStagingHostedService : FinalHostedService
{
    private readonly ICdsStaging _cdsStaging;

    public CdsLoadStagingHostedService(IHostApplicationLifetime appLifetime, ICdsStaging cdsStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _cdsStaging = cdsStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _cdsStaging.StageData(cancellationToken);
    }
}