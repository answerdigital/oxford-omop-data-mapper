using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.OP;

internal class SusOPLoadStagingHostedService : FinalHostedService
{
    private readonly ISusOPStaging _susOPStaging;

    public SusOPLoadStagingHostedService(IHostApplicationLifetime appLifetime, ISusOPStaging susStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _susOPStaging = susStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _susOPStaging.StageData(cancellationToken);
    }
}