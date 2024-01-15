using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.Omop.Prune;

internal class PruneTransformHostedService : FinalHostedService
{
    private readonly OmopPruner _pruner;

    public PruneTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, OmopPruner pruner) : base(appLifetime, logger)
    {
        _pruner = pruner;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _pruner.Prune(cancellationToken);
    }
}