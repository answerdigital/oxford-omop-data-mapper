using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.Init;

internal sealed class InitHostedService : FinalHostedService
{
    private readonly IInitiation _initiation;

    public InitHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, IInitiation initiation) : base(appLifetime, logger)
    {
        _initiation = initiation;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _initiation.Initiate(cancellationToken);
    }
}