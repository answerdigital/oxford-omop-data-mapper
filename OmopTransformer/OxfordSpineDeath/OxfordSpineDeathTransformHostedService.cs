using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.OxfordSpineDeath;

internal class OxfordSpineDeathTransformHostedService : FinalHostedService
{
    private readonly OxfordSpineDeathTransformer _transformer;

    public OxfordSpineDeathTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, OxfordSpineDeathTransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}