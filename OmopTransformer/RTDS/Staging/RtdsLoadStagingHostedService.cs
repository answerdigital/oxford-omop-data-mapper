using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OmopTransformer.RTDS.Parser;

namespace OmopTransformer.Rtds.Staging;

internal class RtdsLoadStagingHostedService : FinalHostedService
{
    private readonly IRtdsStaging _rtdsStaging;

    public RtdsLoadStagingHostedService(IHostApplicationLifetime appLifetime, IRtdsStaging rtdsStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _rtdsStaging = rtdsStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _rtdsStaging.StageData(cancellationToken);
    }
}