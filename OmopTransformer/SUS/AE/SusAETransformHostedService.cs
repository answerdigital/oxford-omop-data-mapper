using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.AE;

internal class SusAETransformHostedService : FinalHostedService
{
    private readonly SusAETransformer _transformer;

    public SusAETransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, SusAETransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}