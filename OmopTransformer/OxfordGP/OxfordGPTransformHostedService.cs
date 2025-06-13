using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.OxfordGP;

internal class OxfordGPTransformHostedService : FinalHostedService
{
    private readonly OxfordGPTransformer _transformer;

    public OxfordGPTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, OxfordGPTransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}