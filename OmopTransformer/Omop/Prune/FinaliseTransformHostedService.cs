using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.Omop.Prune;

internal class FinaliseTransformHostedService : FinalHostedService
{
    private readonly OmopFinaliser _finaliser;

    public FinaliseTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, OmopFinaliser finaliser) : base(appLifetime, logger)
    {
        _finaliser = finaliser;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _finaliser.Prune(cancellationToken);
    }
}